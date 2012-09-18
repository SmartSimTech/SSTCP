// System Libraries
using System;
using System.Windows.Forms;
using System.Collections;
using System.CodeDom.Compiler;
using System.IO;
using System.Text;
using System.Xml;
using System.Threading;
using System.Xml.Serialization;
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

namespace SSTCP.Boards.SST30I.A
{
    public partial class frmSST30IA : RibbonForm, SmartSimTech.BasicScriptingCommands.IHost
    {
        private Cards objCardsDB = new Cards();
        private readonly string _CardModel = "SST30I";
        private int _usbDeviceID;
        private string _CardRevision;
        private Int32 _CardSerialNumber;
        private HidDevice Card;
        private frmMain _parent;
        private string _cardGUID;
        private Cards obj;
        private int _iconCount = 0;
        private bool _CardOpened = false;
        private string _DefaultCode = @"Public Class VBScript
                                            Implements SmartSimTech.BasicScriptingCommands.IScript

                                            Dim Host as SmartSimTech.BasicScriptingCommands.IHost

                                            Public Sub Initialize(Host as SmartSimTech.BasicScriptingCommands.IHost) Implements SmartSimTech.BasicScriptingCommands.IScript.Initialize
                                                Me.Host = Host
                                            End Sub

                                            Public Sub Script() Implements SmartSimTech.BasicScriptingCommands.IScript.Script
                                                {{{CODE}}}
                                            End Sub

                                            Public Sub OScript(offsetvalue as long) Implements SmartSimTech.BasicScriptingCommands.IScript.OScript
                                                'Not Used
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
            _parent.alertControl1.Show(this, "Card Notice - " + Text, Message);
        }
        public void SendByte(string Offset, long data, int length)
        {
            int dwOffset = Int32.Parse(Offset, System.Globalization.NumberStyles.HexNumber);
            bool result = false;
            if (length > 1)
            {
                result = _parent.FSUIPC_SendBytes(dwOffset, data, length);
            }
            else
            {
                result = _parent.FSUIPC_SendByte(dwOffset, data);
            }

            if (result)
                LogEvent("Sent FSUIPC command", "F001", clsEventLogType.EventLogType.Info);
            else
                LogEvent("Failed to send FSUIPC command", "F001", clsEventLogType.EventLogType.Error);
        }
        public void SendBit(string Offset, int Bit, bool Value, int length)
        {
            int dwOffset = Int32.Parse(Offset, System.Globalization.NumberStyles.HexNumber);
            bool result = false;
            result = _parent.FSUIPC_SendBit(dwOffset, Bit, Value, length);

            if (result)
                LogEvent("Sent FSUIPC command", "F001", clsEventLogType.EventLogType.Info);
            else
                LogEvent("Failed to send FSUIPC command", "F001", clsEventLogType.EventLogType.Error);
        }
        public void SetOutput(int output, bool value)
        {

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

                        // Ask card for its inputs
                        tmrRequestButtonStatus.Enabled = true;
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
            // Check report to see what to do with the data
            clsUSBData CardData = new clsUSBData(Report.Data, 3);
            if (!_CardOpened)
                return;

            if (!CardData.Error)
            {
                byte[] Data = CardData.USBDeviceData;
                switch (Data[0])
                {
                    case 0:  // Button Press
                        int ButtonP = Convert.ToInt32(Data[1]);
                        int ValueP = Convert.ToInt32(Data[2]);
                        bool ButtonValueP;
                        if (ValueP == 0)
                            ButtonValueP = false;
                        else
                            ButtonValueP = true;

                        HandleButtonStatus(ButtonP, ButtonValueP);
                        if (!chkDebugEnabled.Checked)
                            HandleButton(ButtonP, ButtonValueP);
                        break;

                    case 1:  // Button Status
                        int Button = Convert.ToInt32(Data[1]);
                        int Value = Convert.ToInt32(Data[2]);
                        bool ButtonValue;
                        if (Value == 0)
                            ButtonValue = false;
                        else
                            ButtonValue = true;

                        HandleButtonStatus(Button, ButtonValue);
                        tmrRequestButtonStatus.Enabled = false;
                        break;

                    case 253:  // Firmware Version

                        break;

                    case 254:  // Model Revision

                        break;

                    case 255:  // Serial Number

                        break;

                    default:  // oh no...
                        break;
                }
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
        private void HandleButton(int _Input, bool ButtonValue)
        {
            if (_Input == 0)
                return;

            AnalogInputConfiguration obj = Session.DefaultSession.FindObject<AnalogInputConfiguration>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [CardModel] ==? AND [Input] == ?", _CardSerialNumber, _CardRevision, _CardModel, _Input));

            if (obj.InputEnabled)
                return;

            string SourceCode;

            if (ButtonValue)
            {
                SourceCode = obj.CodeButtonDown;
            }
            else
            {
                SourceCode = obj.CodeButtonUp;
            }
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
                if (Script != null) Script.Script();
            }
        }
        private void HandleButtonStatus(int _Input, bool ButtonValue)
        {
            if (!_CardOpened)
                return;

            try
            {
                AnalogInputConfiguration obj = Session.DefaultSession.FindObject<AnalogInputConfiguration>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [Input] == ?", _CardSerialNumber, _CardRevision, _Input));
                obj.InputStatus = ButtonValue;
                obj.Save();
                //gridControl1.RefreshDataSource();
                LogEvent(String.Format("Card Input - {0} - {1}", _Input, ButtonValue), "I002", clsEventLogType.EventLogType.Info);
            }
            catch (Exception ex)
            {
                LogEvent(ex.Message, "E001", clsEventLogType.EventLogType.Error);
            }
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
        private void frmSST30IA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                if (XtraMessageBox.Show("Are you sure you wish to close this window?  If you close this window it will put the card offline.", "Close Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    e.Cancel = true;
        }
        private void frmSST30IA_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.usbRemoveGUID(_cardGUID);
            Dispose();
        }
        private string SerializeArrayList(ArrayList obj)
        {
            System.Xml.XmlDocument doc = new XmlDocument();
            Type[] extraTypes = new Type[1];
            extraTypes[0] = typeof(xmlAnalogInputConfiguration);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ArrayList), extraTypes);
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            try
            {
                serializer.Serialize(stream, obj);
                stream.Position = 0;
                doc.Load(stream);
                return doc.InnerXml;
            }
            catch { throw; }
            finally
            {
                stream.Close();
                stream.Dispose();
            }
        }
        private void SetupFunctionDropdown()
        {
            repositoryItemImageComboBox1.Items.Clear();
            AnalogInputConfiguration obj;

            for (int i = 1; i <= 30; i++)
            {
                obj = Session.DefaultSession.FindObject<AnalogInputConfiguration>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [CardModel] == ? AND [Input] == ?", _CardSerialNumber, _CardRevision, _CardModel, i));

                ImageComboBoxItem item;
                string ButtonDescription = obj.InputName;

                item = new ImageComboBoxItem
                {
                    Description = string.Format("Input {0} Button On ({1})", i, ButtonDescription),
                    Value = i + "|down",
                    ImageIndex = 6
                };
                repositoryItemImageComboBox1.Items.Add(item);

                item = new ImageComboBoxItem
                {
                    Description = string.Format("Input {0} Button Off ({1})", i, ButtonDescription),
                    Value = i + "|up",
                    ImageIndex = 5
                };
                repositoryItemImageComboBox1.Items.Add(item);
            }

            ilFunction.EditValue = "1|down";
        }
        #endregion

        #region "Buttons"
        private void bbtnEditInput_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Get input ID
            Int32 inputID = (int)gridView1.GetFocusedRowCellValue("Input");

            Forms.frmEditCardDetails frm = new Forms.frmEditCardDetails();
            frm.DialogMode = clsEditCardDetailsDialogType.DialogType.InputEdit;
            frm.InputID = inputID;
            frm.CardSerial = _CardSerialNumber;
            frm.CardRevision = _CardRevision;
            frm.ShowDialog(this);

            if (!frm.Canceled)
            {
                // Refresh Data
                //gridControl1.RefreshDataSource();

                // Edit the dropdown list
                string ButtonDescription = frm.tbName.Text;
                repositoryItemImageComboBox1.Items[(inputID * 2) - 2].Description = string.Format("Input{0}_ButtonDown() - {1}", inputID, ButtonDescription);
                repositoryItemImageComboBox1.Items[(inputID * 2) - 1].Description = string.Format("Input{0}_ButtonUp() - {1}", inputID, ButtonDescription);
            }
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
        private void bbtnExportConfiguration_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "sec";
            sfd.Filter = "Smart Sim Tech Export Configuration (*.sec)|*.sec";
            sfd.AddExtension = true;
            sfd.RestoreDirectory = true;
            sfd.Title = "Export Card Configuration";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //xmlCardConfiguration[] CardConfig = new xmlCardConfiguration[1];
                //CardConfig[0] = new xmlCardConfiguration(_CardRevision, _CardModel, Text, lblCardDescription.Text);

                ArrayList AIC = new ArrayList();
                for (int i = 0; i < 30; i++)
                {
                    string _CodeUp = (string)gridView1.GetRowCellValue(i, colCodeButtonUp);
                    string _CodeDown = (string)gridView1.GetRowCellValue(i, colCodeButtonDown);
                    string _InputName = (string)gridView1.GetRowCellValue(i, colInputName);
                    string _InputDescription = (string)gridView1.GetRowCellValue(i, colInputDescription);
                    bool _InputEnabled = (bool)gridView1.GetRowCellValue(i, colInputEnabled);

                    AIC.Add(new xmlAnalogInputConfiguration(i + 1, _InputName, _CodeUp, _CodeDown, _InputDescription, _InputEnabled));
                }

                //XmlSerializer serializer = new XmlSerializer(typeof(xmlAnalogInputConfiguration));
                //TextWriter textWriter = new StreamWriter(sfd.FileName);
                //serializer.Serialize(textWriter, AIC);
                //textWriter.Close();
                MessageBox.Show(SerializeArrayList(AIC));

                XtraMessageBox.Show("Data exported ok", "Data Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sfd.Dispose();
        }
        private void bbtnRun_ItemClick(object sender, ItemClickEventArgs e)
        {
            SmartSimTech.BasicScriptingCommands.IScript _compiledScript = null;

            // Find Refrence
            string reference = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!reference.EndsWith(@"\"))
                reference += @"\";
            reference += "SmartSimTech.BasicScriptingCommands.dll";

            CompilerResults results = Classes.clsBasicScripting.CompileScript(_DefaultCode.Replace("{{{CODE}}}", fastColoredTextBox1.Text), reference, Classes.clsBasicScripting.Languages.VB);
            
            if (results.Errors.Count == 0)
            {
                _compiledScript = (SmartSimTech.BasicScriptingCommands.IScript)Classes.clsBasicScripting.FindInterface(results.CompiledAssembly, "IScript");
                SmartSimTech.BasicScriptingCommands.IScript Script = null;
                Script = _compiledScript;
                Script.Initialize(this);
                if (Script != null) Script.Script();
            }
            else
                XtraMessageBox.Show(String.Format("There are {0} error(s) in the code.  This must be fixed before the source code can be run.  Please click Verify for a list of the errors.", results.Errors.Count), "Source Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void bbtnToggleDebugMode_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (chkDebugEnabled.Checked)
                chkDebugEnabled.Checked = false;
            else
                chkDebugEnabled.Checked = true;
        }
        private void bbtnExportDebugLog_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.Filter = "Text file (*.txt)|*.txt";
            sfd.AddExtension = true;
            sfd.RestoreDirectory = true;
            sfd.Title = "Export Log Data";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("You selected the file: " + sfd.FileName);
                //Open the File
                StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.ASCII);

                foreach (ImageListBoxItem item in lbDebugLog.Items)
                {
                    sw.WriteLine(item.Value.ToString());
                }

                //close the file
                sw.Close();
                sw.Dispose();
            }
            sfd.Dispose();
        }
        private void bbtnIgnoreSelectedInput_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Please select an input from the Input Configration window", "Select Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Toggle the input
            bool inputStatus = (bool)gridView1.GetFocusedRowCellValue("InputEnabled");

            if (inputStatus)
            {
                gridView1.SetFocusedRowCellValue("InputEnabled", false);
            }
            else
            {
                gridView1.SetFocusedRowCellValue("InputEnabled", true);
            }
        }
        private void bbtnEditSelectedInput_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Please select an input from the Input Configration window", "Select Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get input ID
            Int32 inputID = (int)gridView1.GetFocusedRowCellValue("Input");

            Forms.frmEditCardDetails frm = new Forms.frmEditCardDetails();
            frm.DialogMode = clsEditCardDetailsDialogType.DialogType.InputEdit;
            frm.InputID = inputID;
            frm.CardSerial = _CardSerialNumber;
            frm.CardRevision = _CardRevision;
            frm.ShowDialog(this);

            if (!frm.Canceled)
            {
                // Refresh Data
                //gridControl1.RefreshDataSource();

                // Edit the dropdown list
                string ButtonDescription = frm.tbName.Text;
                repositoryItemImageComboBox1.Items[(inputID * 2) - 2].Description = string.Format("Input{0}_ButtonDown() - {1}", inputID, ButtonDescription);
                repositoryItemImageComboBox1.Items[(inputID * 2) - 1].Description = string.Format("Input{0}_ButtonUp() - {1}", inputID, ButtonDescription);
            }
        }
        private void bbtnToggleSelectedInput_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (chkUSBConnected.Checked)
            {
                XtraMessageBox.Show("The USB is connected, unable to toggle the input while the USB is connected", "USB Connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gridView1.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Please select an input from the Input Configration window", "Select Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Toggle the input
            bool inputStatus = (bool)gridView1.GetFocusedRowCellValue("InputStatus");

            if (inputStatus)
            {
                gridView1.SetFocusedRowCellValue("InputStatus", false);
            }
            else
            {
                gridView1.SetFocusedRowCellValue("InputStatus", true);
            }
        }
        private void bbtnRefreshInputs_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (chkUSBConnected.Checked)
            {
                LogEvent("Requesting Card Input Status", "I001", clsEventLogType.EventLogType.Warning);

                HidReport SerialNumber = new HidReport(2);
                SerialNumber.Data[0] = 0xFF;
                SerialNumber.Data[1] = 20;
                Card.WriteReport(SerialNumber);
            }
            else
            {
                LogEvent("USB not connected, unable to request input status", "I002", clsEventLogType.EventLogType.Error);
                XtraMessageBox.Show("USB not connected, unable to request input status", "Refresh Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bbtnFactoryReset_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you wish to perform a factory reset on this card?  It will clear out all data.", "Factory Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                return;

            // Clear all data
            AnalogInputConfiguration obj;

            for (int i = 1; i <= 30; i++)
            {
                obj = Session.DefaultSession.FindObject<AnalogInputConfiguration>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [CardModel] == ? AND [Input] == ?", _CardSerialNumber, _CardRevision, _CardModel, i));
                obj.InputDescription = "";
                obj.InputEnabled = false;
                obj.InputName = "Input #" + i;
                obj.CodeButtonDown = "";
                obj.CodeButtonUp = "";
                obj.Save();
            }

            Cards obj2 = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardModel] == ? AND [CardRevision] == ? AND [CardSerialNumber] ==?", _CardModel, _CardRevision, _CardSerialNumber));
            obj2.CardName = String.Format("{0}{1} [{2}]", _CardModel, _CardRevision, _CardSerialNumber);
            obj2.CardDescription = "";
            obj2.Save();

            // Reset dropdown...
            SetupFunctionDropdown();

            // Reset Code Box
            fastColoredTextBox1.Text = "";
        }
        private void bbtnScriptRefGuide_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.smartsimtech.com/support/46/47/");
        }
        private void bbtnEditCardConfiguration_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Show Edit Box
            Forms.frmEditCardDetails frm = new Forms.frmEditCardDetails();
            frm.DialogMode = clsEditCardDetailsDialogType.DialogType.CardEdit;
            frm.CardSerial = _CardSerialNumber;
            frm.CardModel = _CardModel;
            frm.CardRevision = _CardRevision;
            frm.ShowDialog(this);

            if (!frm.Canceled)
            {
                // Refresh Data

            }
        }
        private void bbtnImportConfiguration_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "sec";
            ofd.Filter = "Smart Sim Tech Export Configuration (*.sec)|*.sec";
            ofd.AddExtension = true;
            ofd.RestoreDirectory = true;
            ofd.Title = "Import Card Configuration";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void bbtnSaveCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            string[] selected = ilFunction.EditValue.ToString().Split('|');
            int SelectInputID = Convert.ToInt32(selected[0]);
            bool ButtonPressed;
            if (selected[1] == "up")
                ButtonPressed = false;
            else
                ButtonPressed = true;

            AnalogInputConfiguration obj = Session.DefaultSession.FindObject<AnalogInputConfiguration>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [CardModel] == ? AND [Input] == ?", _CardSerialNumber, _CardRevision, _CardModel, SelectInputID));

            if (ButtonPressed)
            {
                obj.CodeButtonDown = fastColoredTextBox1.Text;
            }
            else
            {
                obj.CodeButtonUp = fastColoredTextBox1.Text;
            }

            obj.Save();
        }
        #endregion

        #region "Timers"
        private void tmrInputConfigRefresh_Tick(object sender, EventArgs e)
        {
            xpCollectionConfiguration.Reload();
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
        private void tmrRequestButtonStatus_Tick(object sender, EventArgs e)
        {
            LogEvent("Requesting Card Input Status", "I001", clsEventLogType.EventLogType.Warning);
            Card.Open();
            HidReport SerialNumber = new HidReport(2);
            SerialNumber.Data[0] = 0xFF;
            SerialNumber.Data[1] = 20;
            Card.WriteReport(SerialNumber);
        }
        #endregion

        public frmSST30IA()
        {
            InitializeComponent();
        }

        private void frmSST30IA_Load(object sender, EventArgs e)
        {
            // Set Code Box...
            fastColoredTextBox1.Language = Language.VB;
            
            // Load Card Details
            obj = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardSerialNumber] == ? AND [CardModel] == ? AND [CardRevision] == ?", _CardSerialNumber, _CardModel, _CardRevision));
            Text = obj.CardName;

            // Card Details
            LogEvent("Card Model Number: " + _CardModel, "X001", clsEventLogType.EventLogType.Info);
            LogEvent("Card Revision: " + _CardRevision, "X002", clsEventLogType.EventLogType.Info);
            LogEvent("Card Serial Number: " + _CardSerialNumber, "X003", clsEventLogType.EventLogType.Info);

            // Check to see if the card details exist in the database
            XPView CardDetails = new XPView(Session.DefaultSession, typeof(Database.AnalogInputConfiguration));
            CardDetails.AddProperty("Serial", "CardSerial");
            CardDetails.Criteria = CriteriaOperator.Parse(String.Format("[CardRevision] = '{0}' And [CardModel] = '{1}' And [CardSerial] == {2}", _CardRevision, _CardModel, _CardSerialNumber), null);

            bool CardAdded;
            if (CardDetails.Count > 0)
                CardAdded = true;
            else
                CardAdded = false;

            if (!CardAdded)
            {
                for (int i = 1; i <= 30; i++)
                {
                    Database.AnalogInputConfiguration dbConfiguration = new Database.AnalogInputConfiguration();
                    dbConfiguration.Input = i;
                    dbConfiguration.InputName = "Input #" + i;
                    dbConfiguration.InputStatus = false;
                    dbConfiguration.CodeButtonUp = "";
                    dbConfiguration.CodeButtonDown = "";
                    dbConfiguration.CardSerial = _CardSerialNumber;
                    dbConfiguration.CardRevision = _CardRevision;
                    dbConfiguration.CardModel = _CardModel;
                    dbConfiguration.Save();
                }
            }

            xpCollectionCardInfo.Criteria = CriteriaOperator.Parse(String.Format("[CardModel] = '{0}' And [CardRevision] = '{1}' And [CardSerialNumber] = {2}", _CardModel, _CardRevision, _CardSerialNumber), null);

            xpCollectionConfiguration.Criteria = CriteriaOperator.Parse(String.Format("[CardRevision] = '{0}' And [CardModel] = '{1}' And [CardSerial] = {2}", _CardRevision, _CardModel, _CardSerialNumber), null);

            // Setup Code Dropdown
            SetupFunctionDropdown();

            // Setup Group Control Boxes
            gcCardConfiguration.Dock = DockStyle.Fill;
            gcCardSettings.Dock = DockStyle.Fill;
            gcDebugLog.Dock = DockStyle.Fill;
            gcInputScripts.Dock = DockStyle.Fill;

            // Hide Group Control Boxes
            gcCardConfiguration.Visible = false;
            gcDebugLog.Visible = false;
            gcInputScripts.Visible = false;

            // Enable Timers
            tmrInputConfigRefresh.Enabled = true;
            tmrCheckUSB.Enabled = true;
            tmrCheckFormDetails.Enabled = true;

            // Set Form Details
            objCardsDB = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardSerialNumber] == ? AND [CardModel] == ? AND [CardRevision] == ?", _CardSerialNumber, _CardModel, _CardRevision));
            DataBindings.Add("Text", objCardsDB, "CardName");
            chkUSBConnected.DataBindings.Add("Text", objCardsDB, "CardConnected");
        }
        
        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                bbtnEditInput.Caption = "Edit Card Input " + view.GetRowCellValue(hitInfo.RowHandle, "Input");
                menuConfigurationPopup.ShowPopup(Control.MousePosition);
            }
        }       

        private void ilFunction_EditValueChanged(object sender, EventArgs e)
        {
            string[] selected = ilFunction.EditValue.ToString().Split('|');
            int SelectInputID = Convert.ToInt32(selected[0]);
            bool ButtonPressed;
            if (selected[1] == "up")
                ButtonPressed = false;
            else
                ButtonPressed = true;

            AnalogInputConfiguration obj = Session.DefaultSession.FindObject<AnalogInputConfiguration>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [CardModel] == ? AND [Input] == ?", _CardSerialNumber, _CardRevision, _CardModel, SelectInputID));
            
            string SourceCode;

            if (ButtonPressed)
            {
                SourceCode = obj.CodeButtonDown;
            }
            else
            {
                SourceCode = obj.CodeButtonUp;
            }

            fastColoredTextBox1.Text = SourceCode;
            fastColoredTextBox1.Refresh();
        }
                        
        private void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            switch (e.Group.Caption)
            {
                case "Card Settings":
                    gcCardSettings.Visible = true;
                    gcCardConfiguration.Visible = false;
                    gcDebugLog.Visible = false;
                    gcInputScripts.Visible = false;
                    break;

                case "Input Settings":
                    gcCardSettings.Visible = false;
                    gcCardConfiguration.Visible = true;
                    gcDebugLog.Visible = false;
                    gcInputScripts.Visible = false;
                    break;

                case "Input Scripts":
                    gcCardSettings.Visible = false;
                    gcCardConfiguration.Visible = false;
                    gcDebugLog.Visible = false;
                    gcInputScripts.Visible = true;
                    break;

                case "Card Log":
                    gcCardSettings.Visible = false;
                    gcCardConfiguration.Visible = false;
                    gcDebugLog.Visible = true;
                    gcInputScripts.Visible = false;
                    break;
                    
                default:
                    break;
            }
        }
    }
}