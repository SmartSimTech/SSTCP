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

namespace SSTCP.Boards.PSU.A
{
    public partial class frmSSTPSUA : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Cards objCardsDB = new Cards();
        private readonly string _CardModel = "SSTPSU";
        private int _usbDeviceID;
        private string _CardRevision;
        private Int32 _CardSerialNumber;
        private HidDevice Card;
        private frmMain _parent;
        private string _cardGUID;
        private Cards obj;
        private int _iconCount = 0;
        private bool _CardOpened = false;

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

                        // Ask PSU for its status
                        tmrRequestPSUStatus.Enabled = true;
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
                    case 0:    // Power Button Pressed
                        int ButtonValueP = Data[2];
                        bool PSUEnabledP;
                        if (ButtonValueP == 0)
                            PSUEnabledP = false;
                        else
                            PSUEnabledP = true;

                        LogEvent("Manual Power Button Pressed, Value: " + PSUEnabledP, "E002", clsEventLogType.EventLogType.Info);
                        break;

                    case 1:    // Power Supply Reported its Status
                        int ButtonValue = Data[2];
                        bool PSUEnabled;
                        if (ButtonValue == 0)
                            PSUEnabled = false;
                        else
                            PSUEnabled = true;

                        LogEvent("Power Supply Value: " + PSUEnabled, "E001", clsEventLogType.EventLogType.Info);
                        tmrRequestPSUStatus.Enabled = false;
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
        #endregion

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
        private void tmrRequestPSUStatus_Tick(object sender, EventArgs e)
        {
            LogEvent("Requesting PSU Status", "I001", clsEventLogType.EventLogType.Warning);
            Card.Open();
            HidReport SerialNumber = new HidReport(2);
            SerialNumber.Data[0] = 0xFF;
            SerialNumber.Data[1] = 20;
            Card.WriteReport(SerialNumber);
        }

        private void bbtnToggleDebugMode_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (chkDebugEnabled.Checked)
                chkDebugEnabled.Checked = false;
            else
                chkDebugEnabled.Checked = true;
        }

        public frmSSTPSUA()
        {
            InitializeComponent();
        }

        private void frmSSTPSUA_Load(object sender, EventArgs e)
        {
            // Load Card Details
            obj = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardSerialNumber] == ? AND [CardModel] == ? AND [CardRevision] == ?", _CardSerialNumber, _CardModel, _CardRevision));
            Text = obj.CardName;

            // Card Details
            LogEvent("Card Model Number: " + _CardModel, "X001", clsEventLogType.EventLogType.Info);
            LogEvent("Card Revision: " + _CardRevision, "X002", clsEventLogType.EventLogType.Info);
            LogEvent("Card Serial Number: " + _CardSerialNumber, "X003", clsEventLogType.EventLogType.Info);

            xpCollectionCardInfo.Criteria = CriteriaOperator.Parse(String.Format("[CardModel] = '{0}' And [CardRevision] = '{1}' And [CardSerialNumber] = {2}", _CardModel, _CardRevision, _CardSerialNumber), null);

            // Setup Group Control Boxes
            gcCardConfiguration.Dock = DockStyle.Fill;
            gcCardSettings.Dock = DockStyle.Fill;
            gcDebugLog.Dock = DockStyle.Fill;

            // Hide Group Control Boxes
            gcCardConfiguration.Visible = false;
            gcDebugLog.Visible = false;

            // Enable Timers
            tmrCheckUSB.Enabled = true;
            tmrCheckFormDetails.Enabled = true;

            // Set Form Details
            objCardsDB = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardSerialNumber] == ? AND [CardModel] == ? AND [CardRevision] == ?", _CardSerialNumber, _CardModel, _CardRevision));
            DataBindings.Add("Text", objCardsDB, "CardName");
            chkUSBConnected.DataBindings.Add("Text", objCardsDB, "CardConnected");
        }

        private void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            switch (e.Group.Caption)
            {
                case "Card Settings":
                    gcCardSettings.Visible = true;
                    gcCardConfiguration.Visible = false;
                    gcDebugLog.Visible = false;
                    break;

                case "Power Supply Settings":
                    gcCardSettings.Visible = false;
                    gcCardConfiguration.Visible = true;
                    gcDebugLog.Visible = false;
                    break;

                case "Card Log":
                    gcCardSettings.Visible = false;
                    gcCardConfiguration.Visible = false;
                    gcDebugLog.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void bbtnTurnOnPSU_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HidReport SerialNumber = new HidReport(2);
            SerialNumber.Data[0] = 0xFF;
            SerialNumber.Data[1] = 31;
            Card.WriteReport(SerialNumber);
        }

        private void bbtnTurnOffPSU_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HidReport SerialNumber = new HidReport(2);
            SerialNumber.Data[0] = 0xFF;
            SerialNumber.Data[1] = 30;
            Card.WriteReport(SerialNumber);
        }
    }
}