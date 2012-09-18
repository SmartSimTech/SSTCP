// System Libraries
using System;
using System.Windows.Forms;
using System.Collections;
using System.CodeDom.Compiler;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;
using System.Threading;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text.RegularExpressions;
// DevExpress Libraries
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
// USB Library
using HIDLibrary;
// Smart Sim Tech Libraries
using SSTCP.Forms;
using SSTCP.Classes;
using SSTCP.Database;
using SSTCP.XMLConfiguration;
// Code Editor
using FastColoredTextBoxNS;

namespace SSTCP.Boards.SST24O.A
{
    public partial class frmSST24OA : RibbonForm, SmartSimTech.BasicScriptingCommands.IHost
    {
        private Cards objCardsDB = new Cards();
        private readonly string _CardModel = "SST24O";
        private int _usbDeviceID;
        private string _CardRevision;
        private Int32 _CardSerialNumber;
        private HidDevice Card;
        private frmMain _parent;
        private string _cardGUID;
        private Cards obj;
        private DataTable _dtOutputs;
        private int _selftest = 0;
        private int _iconCount = 0;
        private DataTable _dtOffsets;
        private bool _editorsave = false;
        private bool _CardOpened = false;
        private AutocompleteMenu popupMenu;
        private string _DefaultCode = @"Public Class VBScript
                                            Implements SmartSimTech.BasicScriptingCommands.IScript

                                            Dim Host as SmartSimTech.BasicScriptingCommands.IHost

                                            Public Sub Initialize(Host as SmartSimTech.BasicScriptingCommands.IHost) Implements SmartSimTech.BasicScriptingCommands.IScript.Initialize
                                                Me.Host = Host
                                            End Sub
                
                                            Public Sub Script() Implements SmartSimTech.BasicScriptingCommands.IScript.Script
                                                'Not Used
                                            End Sub
                                            
                                            Public Sub OScript(offsetvalue as long) Implements SmartSimTech.BasicScriptingCommands.IScript.OScript
                                                {{{CODE}}}
                                            End Sub
                                        End Class";

        delegate void SetReportDataParm(HidReport Report);

        #region "Properties"
        public int usbDeviceID
        {
            set
            {
                _usbDeviceID = value;
            }
            get
            {
                return _usbDeviceID;
            }
        }
        public string CardRevision
        {
            set
            {
                _CardRevision = value;
            }
            get
            {
                return _CardRevision;
            }
        }
        public Int32 CardSerialNumber
        {
            set
            {
                _CardSerialNumber = value;
            }
            get
            {
                return _CardSerialNumber;
            }
        }
        public frmMain ParentFrm
        {
            set
            {
                _parent = value;
            }
        }
        #endregion

        #region "Basic Scripting Voids"
        public void ShowMessage(string Message)
        {
           
        }
        public void SendByte(string offset, long value, int length)
        {

        }
        public void SendBit(string offset, int bit, bool value, int length)
        {

        }
        public void SetOutput(int output, bool value)
        {
            gridView1.SetRowCellValue(output - 1, "OutputStatus", value);
        }
        #endregion

        #region "USB I/O"
        private void tmrCheckUSB_Tick(object sender, EventArgs e)
        {
            string GUID = _parent.GetUSBGUID(_CardSerialNumber, _usbDeviceID);
            if (GUID != "-1")
            {
                if (!_CardOpened)
                {
                    try
                    {
                        Card = _parent.GetHIDHandle(GUID);
                        Card.Open();
                        do
                        {
                            Application.DoEvents();     // Prevent App Freezing.
                        } while (Card.IsConnected == false);

                        _cardGUID = GUID;

                        Card.ReadReport(OnReport);
                        Card.Removed += DeviceRemovedHandler;

                        LogEvent("Card Attached", "C001", clsEventLogType.EventLogType.Info);
                        _parent.usbAddGUID(_cardGUID);
                        chkUSBConnected.Checked = true;

                        initLED();
                        tmrSetOutputs.Enabled = true;

                        _CardOpened = true;
                    }
                    catch (Exception ex)
                    {
                        LogEvent(ex.Message, "E002", clsEventLogType.EventLogType.Error);
                    }
                }
            }
        }
        private void DeviceRemovedHandler()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(DisableCard), null);
            else
                DisableCard();
        }
        private void DisableCard()
        {
            _CardOpened = false;
            LogEvent("Card Removed", "C002", clsEventLogType.EventLogType.Info);
            Card.Close();
            Card.Dispose();
            _parent.usbRemoveGUID(_cardGUID);
            tmrCheckUSB.Enabled = true;
            chkUSBConnected.Checked = false;
            tmrSetOutputs.Enabled = false;
            _selftest = 0;
        }
        private void OnReport(HidReport Report)
        {
            if (InvokeRequired)
                Invoke(new SetReportDataParm(ReportData), Report);
            else
                ReportData(Report);
        }
        private void ReportData(HidReport Report)
        {
            clsUSBData CardData = new clsUSBData(Report.Data, 3);
            if (!_CardOpened)
                return;

            if (!CardData.Error)
            {
                // TODO: Add Input
            }
            Card.ReadReport(OnReport);
        }
        private void chkUSBConnected_CheckedChanged(object sender, EventArgs e)
        {
            Cards obj = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardSerialNumber] == ? AND [CardModel] == ? AND [CardRevision] == ?", _CardSerialNumber, _CardModel, _CardRevision));

            if (chkUSBConnected.Checked)
                obj.CardConnected = true;
            else
                obj.CardConnected = false;

            obj.Save();
        }   
        #endregion

        #region "Functions"
        private void LogEvent(string EventDetails, string EventLogID, clsEventLogType.EventLogType Type)
        {
            int logIcon;
            switch (Type)
            {
                case clsEventLogType.EventLogType.Info:
                    logIcon = 0;
                    break;
                case clsEventLogType.EventLogType.Warning:
                    logIcon = 1;
                    break;
                case clsEventLogType.EventLogType.Error:
                    logIcon = 2;
                    break;
                default:
                    logIcon = 0;
                    break;
            }

            ImageListBoxItem item = new ImageListBoxItem();
            item.Value = String.Format("[{0} {1}] ID: {2} Description: {3}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), EventLogID, EventDetails);
            item.ImageIndex = logIcon;
            lbDebugLog.Items.Insert(0, item);
            lbDebugLog.SelectedIndex = 0;
        }
        private void frmSST24OA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                if (XtraMessageBox.Show("Are you sure you wish to close this window?  If you close this window it will put the card offline.", "Close Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    e.Cancel = true;
        }
        private void frmSST24OA_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.usbRemoveGUID(_cardGUID);
            Dispose();
        }
        private void SetupScriptDropDown()
        {
            repositoryItemImageComboBox1.Items.Clear();

            XPCollection collection = new XPCollection(typeof(Database.AnalogOutputScripts), CriteriaOperator.Parse(String.Format("CardModel == '{0}' AND CardRevision == '{1}' AND CardSerial == {2}", _CardModel, _CardRevision, _CardSerialNumber)));

            foreach (Database.AnalogOutputScripts dbitem in collection)
            {
                ImageComboBoxItem item;
                if (dbitem.Bit == -1)
                {
                    // Offset is a byte
                    item = new ImageComboBoxItem
                    {
                        Description = string.Format("Offset 0x{0}", dbitem.Offset),
                        Value = dbitem.Oid,
                        ImageIndex = 6
                    };
                }
                else
                {
                    // Offset is a bit
                    item = new ImageComboBoxItem
                    {
                        Description = string.Format("Offset 0x{0}, Bit {1}", dbitem.Offset, dbitem.Bit),
                        Value = dbitem.Oid,
                        ImageIndex = 6
                    };
                }
                repositoryItemImageComboBox1.Items.Add(item);
            }

            collection.Dispose();
        }
        private void SetupScriptNewScript()
        {
            XPCollection collection = new XPCollection(typeof(Database.AnalogOutputScripts), CriteriaOperator.Parse(String.Format("CardModel == '{0}' AND CardRevision == '{1}' AND CardSerial == {2}", _CardModel, _CardRevision, _CardSerialNumber)));

            foreach (Database.AnalogOutputScripts dbitem in collection)
            {
                ImageComboBoxItem item;
                if (dbitem.Bit == -1)
                {
                    // Offset is a byte
                    item = new ImageComboBoxItem
                    {
                        Description = string.Format("Offset 0x{0}", dbitem.Offset),
                        Value = dbitem.Oid,
                        ImageIndex = 6
                    };
                }
                else
                {
                    // Offset is a bit
                    item = new ImageComboBoxItem
                    {
                        Description = string.Format("Offset 0x{0}, Bit {1}", dbitem.Offset, dbitem.Bit),
                        Value = dbitem.Oid,
                        ImageIndex = 6
                    };
                }

                bool itemadded = false;
                foreach (ImageComboBoxItem cbitem in repositoryItemImageComboBox1.Items)
                {
                    if (cbitem.Description == item.Description)
                        itemadded = true;                   
                }
                if (itemadded == false)
                    repositoryItemImageComboBox1.Items.Add(item);
            }
            collection.Dispose();
        }
        private void initLED()
        {
            for (int i = 0; i < 24; i++)
            {
                bool outputenabled = (bool)gridView1.GetRowCellValue(i, "OutputStatus");

                HidReport SetLED = new HidReport(3);
                if (outputenabled)
                    SetLED.Data[0] = 0x0A;
                else
                    SetLED.Data[0] = 0x0B;
                SetLED.Data[1] = Convert.ToByte(i);

                Card.WriteReport(SetLED);

                _dtOutputs.Rows[i]["value"] = outputenabled;
                LogEvent("Updating LED Value - LED #" + (i + 1) + " VALUE: " + outputenabled, "X", clsEventLogType.EventLogType.Info);
            }
        }
        private void initSelfTest()
        {
            if (chkUSBConnected.Checked)
            {
                if (_selftest == 0)
                {
                    for (int i = 0; i < 24; i++)
                    {
                        HidReport SetLED = new HidReport(3);
                        SetLED.Data[0] = 0x0A;
                        SetLED.Data[1] = Convert.ToByte(i);

                        Card.WriteReport(SetLED);
                    }
                    _selftest = 1;
                }
                else
                {
                    initLED();
                    _selftest = 0;
                }
            }
        }
        private void SetupScriptDatatable()
        {
            XPCollection collection = new XPCollection(typeof(Database.AnalogOutputScripts), CriteriaOperator.Parse(String.Format("CardModel == '{0}' AND CardRevision == '{1}' AND CardSerial == {2}", _CardModel, _CardRevision, _CardSerialNumber)));

            _dtOffsets.Rows.Clear();
            DataRow row;

            foreach (Database.AnalogOutputScripts dbitem in collection)
            {
                row = _dtOffsets.NewRow();
                row["offset"] = (string)dbitem.Offset;
                row["bytes"] = (int)dbitem.Length;
                row["bit"] = (int)dbitem.Bit;
                row["value"] = -1;
                _dtOffsets.Rows.Add(row);
            }
        }
        private void HandleOffsetChange(int ScriptID, long value)
        {
            string SourceCode;
            AnalogOutputScripts obj = Session.DefaultSession.GetObjectByKey<AnalogOutputScripts>(ScriptID);
            SourceCode = obj.OutputCode;

            SmartSimTech.BasicScriptingCommands.IScript _compiledScript = null;

            // Find Refrence
            string reference = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!reference.EndsWith(@"\"))
                reference += @"\";
            reference += "SmartSimTech.BasicScriptingCommands.dll";

            CompilerResults results = Classes.clsBasicScripting.CompileScript(_DefaultCode.Replace("{{{CODE}}}", SourceCode), reference, Classes.clsBasicScripting.Languages.VB);

            if (results.Errors.Count == 0)
            {
                _compiledScript = (SmartSimTech.BasicScriptingCommands.IScript)Classes.clsBasicScripting.FindInterface(results.CompiledAssembly, "IScript");
                SmartSimTech.BasicScriptingCommands.IScript Script = null;
                Script = _compiledScript;
                Script.Initialize(this);
                if (Script != null)
                {
                    Script.OScript(value);
                    LogEvent("Executing Script...", "E002", clsEventLogType.EventLogType.Info);
                }
            }
        }
        #endregion

        #region "Buttons"
        private void bbtnAddScript_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmOutputScriptWizard frm = new frmOutputScriptWizard();
            frm.CardModel = _CardModel;
            frm.CardRevision = _CardRevision;
            frm.CardSerialNumber = _CardSerialNumber;
            frm.ShowDialog();

            SetupScriptNewScript();
            SetupScriptDatatable();
        }
        private void bbtnSaveCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            AnalogOutputScripts obj = Session.DefaultSession.GetObjectByKey<AnalogOutputScripts>(ilFunction.EditValue);
            obj.OutputCode = fastColoredTextBox1.Text;
            obj.Save();
            _editorsave = false;
        }
        private void bbtnDebug_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Find Refrence
            string reference = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!reference.EndsWith(@"\"))
                reference += @"\";
            reference += "SmartSimTech.BasicScriptingCommands.dll";

            CompilerResults results = Classes.clsBasicScripting.CompileScript(_DefaultCode.Replace("{{{CODE}}}", fastColoredTextBox1.Text), reference, Classes.clsBasicScripting.Languages.VB);

            if (results.Errors.Count == 0)
                XtraMessageBox.Show("No Errors Detected", "Verify Code", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
            {
                string errmsg = "";
                foreach (CompilerError err in results.Errors)
                {
                    errmsg = String.Format("{0}{1}\n", errmsg, err.ErrorText);
                }
                XtraMessageBox.Show(errmsg, "Source Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bbtnDeleteScript_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AnalogOutputScripts obj = Session.DefaultSession.GetObjectByKey<AnalogOutputScripts>(ilFunction.EditValue);
            string DeleteMessage;
            if (obj.Bit == -1)
            {
                DeleteMessage = string.Format("Offset 0x{0}", obj.Offset);
            }
            else
            {
                DeleteMessage = string.Format("Offset 0x{0}, Bit {1}", obj.Offset, obj.Bit);
            }

            DeleteMessage = String.Format("Are you sure you wish to delete the script for {0}?", DeleteMessage);
            if (XtraMessageBox.Show(DeleteMessage, "Delete Script?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                // Delete script from the database...
                obj.Delete();
                SetupScriptDropDown();

                fastColoredTextBox1.Enabled = false;
                bbtnRunCode.Enabled = false;
                bbtnDebug.Enabled = false;
                bbtnSaveCode.Enabled = false;
                bbtnDeleteScript.Enabled = false;
                _editorsave = false;

                fastColoredTextBox1.Text = "";
            }
        }
        private void bbtnToggleDebugMode_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (chkDebugEnabled.Checked)
                chkDebugEnabled.Checked = false;
            else
                chkDebugEnabled.Checked = true;
        }
        #endregion

        #region "Timers"
        private void tmrSetOutputs_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                // Check to see if we need to set the output
                bool oldstatus = (bool)_dtOutputs.Rows[i]["value"];
                bool outputenabled = (bool)gridView1.GetRowCellValue(i, "OutputStatus");

                if (oldstatus != outputenabled)
                {
                    HidReport SetLED = new HidReport(3);
                    if (outputenabled)
                        SetLED.Data[0] = 0x0A;
                    else
                        SetLED.Data[0] = 0x0B;
                    SetLED.Data[1] = Convert.ToByte(i);

                    Card.WriteReport(SetLED);

                    _dtOutputs.Rows[i]["value"] = outputenabled;
                    LogEvent("Updating LED Value - LED #" + (i + 1) + " VALUE: " + outputenabled, "X001", clsEventLogType.EventLogType.Info);

                    // Update database with new value
                    AnalogOutputConfiguration obj = Session.DefaultSession.FindObject<AnalogOutputConfiguration>(CriteriaOperator.Parse(String.Format("CardModel == '{0}' AND CardRevision == '{1}' AND CardSerial == {2} AND Output == {3}", _CardModel, _CardRevision, _CardSerialNumber, i + 1)));
                    obj.OutputStatus = outputenabled;
                    obj.Save();
                }
            }
        }
        private void tmrCheckFormDetails_Tick(object sender, EventArgs e)
        {
            if (chkUSBConnected.Checked)
            {
                if (chkDebugEnabled.Checked)
                {
                    if (_iconCount == 0)
                    {
                        _iconCount = 1;
                        Icon = Properties.Resources.Window_Blue;
                    }
                    else
                    {
                        _iconCount = 0;
                        Icon = Properties.Resources.Window_Green;
                    }
                }
                else
                {
                    Icon = Properties.Resources.Window_Green;
                }
            }
            else
            {
                if (chkDebugEnabled.Checked)
                {
                    if (_iconCount == 0)
                    {
                        _iconCount = 1;
                        Icon = Properties.Resources.Window_Blue;
                    }
                    else
                    {
                        _iconCount = 0;
                        Icon = Properties.Resources.Window_Red;
                    }
                }
                else
                {
                    Icon = Properties.Resources.Window_Red;
                }
            }
        }
        private void tmrCheckOffsets_Tick(object sender, EventArgs e)
        {
            // Check offsets for change

            for (int i = 0; i < _dtOffsets.Rows.Count; i++)
            {
                // Get Offset
                string dOffset = (string)_dtOffsets.Rows[i]["offset"];
                int dwOffset = Int32.Parse(dOffset, System.Globalization.NumberStyles.HexNumber);
                string finaloffset = dOffset;

                // Figure out if we are reading a bit or a byte
                int bytes = (int)_dtOffsets.Rows[i]["bytes"];
                int bit = (int)_dtOffsets.Rows[i]["bit"];
                int value = (int)_dtOffsets.Rows[i]["value"];

                // Read offset
                int fsuipcresult = 0;
                bool fsuipcresultbool = false;

                if (bit == -1)
                {
                    if (bytes > 1)
                    {
                        _parent.FSUIPC_GetBytes(dwOffset, bytes, ref fsuipcresult);
                    }
                    else
                    {
                        _parent.FSUIPC_GetByte(dwOffset, ref fsuipcresult);
                    }
                }
                else
                {
                    _parent.FSUIPC_GetBit(dwOffset, bit, bytes, ref fsuipcresultbool);
                    fsuipcresult = Convert.ToInt32(fsuipcresultbool);
                    dOffset = String.Format("{0}[{1}]", dOffset, bit);
                }

                if (fsuipcresult != value)
                {
                    LogEvent(String.Format("Offset changed... Offset was {0} Old Value: {1} New Value: {2}", dOffset, value, fsuipcresult), "E001", clsEventLogType.EventLogType.Info);
                    _dtOffsets.Rows[i]["value"] = fsuipcresult;

                    // Get Script ID...
                    int scriptid;
                    if (bit == -1)
                    {
                        // Script is a bytescript                     
                        AnalogOutputScripts obj = Session.DefaultSession.FindObject<AnalogOutputScripts>(CriteriaOperator.Parse(String.Format("CardModel == '{0}' AND CardRevision == '{1}' AND CardSerial == {2} AND Offset == '{3}'", _CardModel, _CardRevision, _CardSerialNumber, finaloffset)));
                        scriptid = obj.Oid;
                    }
                    else
                    {
                        // Script is a bitscript
                        AnalogOutputScripts obj = Session.DefaultSession.FindObject<AnalogOutputScripts>(CriteriaOperator.Parse(String.Format("CardModel == '{0}' AND CardRevision == '{1}' AND CardSerial == {2} AND Offset == '{3}' AND Bit == {4}", _CardModel, _CardRevision, _CardSerialNumber, finaloffset, bit)));
                        scriptid = obj.Oid;

                    }
                    
                    // Execute Script
                    HandleOffsetChange(scriptid, fsuipcresult);
                }

            }
        }
        #endregion

        public frmSST24OA()
        {
            InitializeComponent();
        }

        private void frmSST24OA_Load(object sender, EventArgs e)
        {
            // Set Code Box...
            fastColoredTextBox1.Language = Language.VB;

            // Load Card Details
            obj = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardSerialNumber] == ? AND [CardModel] == ? AND [CardRevision] == ?", _CardSerialNumber, _CardModel, _CardRevision));
            Text = obj.CardName;
            //lblCardDescription.Text = obj.CardDescription;

            // Card Details
            LogEvent("Card Model Number: " + _CardModel, "X001", clsEventLogType.EventLogType.Info);
            LogEvent("Card Revision: " + _CardRevision, "X002", clsEventLogType.EventLogType.Info);
            LogEvent("Card Serial Number: " + _CardSerialNumber, "X003", clsEventLogType.EventLogType.Info);

            // Check to see if the card details exist in the database
            XPView CardDetails = new XPView(Session.DefaultSession, typeof(Database.AnalogOutputConfiguration));
            CardDetails.AddProperty("Serial", "CardSerial");
            CardDetails.Criteria = CriteriaOperator.Parse(String.Format("[CardRevision] = '{0}' And [CardModel] = '{1}' And [CardSerial] == {2}", _CardRevision, _CardModel, _CardSerialNumber), null);

            bool CardAdded;
            if (CardDetails.Count > 0)
                CardAdded = true;
            else
                CardAdded = false;

            if (!CardAdded)
            {
                for (int i = 1; i <= 24; i++)
                {
                    Database.AnalogOutputConfiguration dbConfiguration = new Database.AnalogOutputConfiguration();
                    dbConfiguration.Output = i;
                    dbConfiguration.OutputName = "Output #" + i;
                    dbConfiguration.OutputStatus = false;
                    dbConfiguration.CardSerial = _CardSerialNumber;
                    dbConfiguration.CardRevision = _CardRevision;
                    dbConfiguration.CardModel = _CardModel;
                    dbConfiguration.Save();
                }
            }

            // Initilize Datatable
            _dtOutputs = new DataTable();

            _dtOutputs.Columns.Add("output", typeof(int));
            _dtOutputs.Columns.Add("value", typeof(bool));
            DataRow row;
            for (int i = 1; i <= 24; i++)
            {
                row = _dtOutputs.NewRow();
                row["output"] = i;
                row["value"] = false;
                _dtOutputs.Rows.Add(row);
            }

            _dtOffsets = new DataTable();
            _dtOffsets.Columns.Add("offset", typeof(string));
            _dtOffsets.Columns.Add("bytes", typeof(int));
            _dtOffsets.Columns.Add("bit", typeof(int));
            _dtOffsets.Columns.Add("value", typeof(int));
            SetupScriptDatatable();

            xpCollectionCardInfo.Criteria = CriteriaOperator.Parse(String.Format("[CardModel] = '{0}' And [CardRevision] = '{1}' And [CardSerialNumber] = {2}", _CardModel, _CardRevision, _CardSerialNumber), null);

            xpCollectionConfiguration.Criteria = CriteriaOperator.Parse(String.Format("[CardRevision] = '{0}' And [CardModel] = '{1}' And [CardSerial] = {2}", _CardRevision, _CardModel, _CardSerialNumber), null);

            // Setup Group Control Boxes
            gcCardConfiguration.Dock = DockStyle.Fill;
            gcCardSettings.Dock = DockStyle.Fill;
            gcDebugLog.Dock = DockStyle.Fill;
            gcScripts.Dock = DockStyle.Fill;

            // Hide Group Control Boxes
            gcCardConfiguration.Visible = false;
            gcDebugLog.Visible = false;
            gcScripts.Visible = false;

            // Set Form Details
            objCardsDB = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardSerialNumber] == ? AND [CardModel] == ? AND [CardRevision] == ?", _CardSerialNumber, _CardModel, _CardRevision));
            DataBindings.Add("Text", objCardsDB, "CardName");
            //lblCardDescription.DataBindings.Add("Text", objCardsDB, "CardDescription");
            chkUSBConnected.DataBindings.Add("Text", objCardsDB, "CardConnected");
            xpCollectionConfiguration.Load();
            gridControl1.DataSource = xpCollectionConfiguration;
            gridControl1.ForceInitialize();

            SetupScriptDropDown();

            // Enable Timers
            //tmrInputConfigRefresh.Enabled = true;
            tmrCheckUSB.Enabled = true;
            tmrCheckFormDetails.Enabled = true;
        }
   
        private void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            switch (e.Group.Caption)
            {
                case "Card Settings":
                    gcCardSettings.Visible = true;
                    gcCardConfiguration.Visible = false;
                    gcDebugLog.Visible = false;
                    gcScripts.Visible = false;
                    break;

                case "Output Settings":
                    gcCardSettings.Visible = false;
                    gcCardConfiguration.Visible = true;
                    gcDebugLog.Visible = false;
                    gcScripts.Visible = false;
                    break;

                case "Output Scripts":
                    gcCardSettings.Visible = false;
                    gcCardConfiguration.Visible = false;
                    gcDebugLog.Visible = false;
                    gcScripts.Visible = true;
                    break;

                case "Card Log":
                    gcCardSettings.Visible = false;
                    gcCardConfiguration.Visible = false;
                    gcDebugLog.Visible = true;
                    gcScripts.Visible = false;
                    break;

                default:
                    break;
            }
        }

        private void nbTurnOutputOn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridView1.SetFocusedRowCellValue("OutputStatus", true);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridView1.SetFocusedRowCellValue("OutputStatus", false);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            initSelfTest();
        }       

        private void ilFunction_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ilFunction.EditValue.ToString()) != (int)fastColoredTextBox1.Tag)
                {
                    // Need to save before changing...
                    if (_editorsave)
                    {
                        if (XtraMessageBox.Show("Do you wish to save before switching code?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            ilFunction.EditValue = (int)fastColoredTextBox1.Tag;
                            return;
                        }
                        else
                        {
                            _editorsave = false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // No code loaded, will cause an error...
            }

            if (_editorsave)
                return;

            AnalogOutputScripts obj = Session.DefaultSession.GetObjectByKey<AnalogOutputScripts>(ilFunction.EditValue);
            String SourceCode = obj.OutputCode;

            fastColoredTextBox1.Tag = Convert.ToInt32(ilFunction.EditValue.ToString());
            fastColoredTextBox1.Text = SourceCode;
            //fastColoredTextBox1.RecolorCode();
            fastColoredTextBox1.Refresh();
            fastColoredTextBox1.Enabled = true;
            bbtnRunCode.Enabled = true;
            bbtnDebug.Enabled = true;
            bbtnSaveCode.Enabled = true;
            bbtnDeleteScript.Enabled = true;
            _editorsave = false;
        }

        private void fastColoredTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            _editorsave = true;
        }

        private void bbtnRunCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            string SourceCode;
            SourceCode = fastColoredTextBox1.Text;

            SmartSimTech.BasicScriptingCommands.IScript _compiledScript = null;

            // Find Refrence
            string reference = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!reference.EndsWith(@"\"))
                reference += @"\";
            reference += "SmartSimTech.BasicScriptingCommands.dll";

            CompilerResults results = Classes.clsBasicScripting.CompileScript(_DefaultCode.Replace("{{{CODE}}}", SourceCode), reference, Classes.clsBasicScripting.Languages.VB);

            if (results.Errors.Count == 0)
            {
                _compiledScript = (SmartSimTech.BasicScriptingCommands.IScript)Classes.clsBasicScripting.FindInterface(results.CompiledAssembly, "IScript");
                SmartSimTech.BasicScriptingCommands.IScript Script = null;
                Script = _compiledScript;
                Script.Initialize(this);
                if (Script != null)
                {
                    Script.OScript(0);
                    LogEvent("Executing Script...", "E002", clsEventLogType.EventLogType.Info);
                }
            }
            else
                XtraMessageBox.Show(String.Format("There are {0} error(s) in the code.  This must be fixed before the source code can be run.  Please click Verify for a list of the errors.", results.Errors.Count), "Source Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
