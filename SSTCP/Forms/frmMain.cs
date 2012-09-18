using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.LookAndFeel;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using SmartSimTech.FSUIPC;
using WindowsTaskDialog;
using System.Net;
// USB Library
using HIDLibrary;
using FSUIPC;

namespace SSTCP.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ArrayList _usbDeviceGUID = new ArrayList();
        public bool loaded = false;
        private bool _FSUIPCConnection = false;         // FSUIPC Connection Bool
        private bool _FSUIPCShowConnErrorMsg = true;    // Show Connection Error Message
        private bool _FSUIPCLostConnection = false;     // Show Connection Established Message
        private int _dwFSReq = 0;                       // Any Version of Flight Sim is OK
        private int _dwResult = -1;                     // Variable to Hold Result
        private bool _fsResult = false;                 // Return Bool for FSUIPC method calls
        private int _token = -1;
        private DataTable _usbDeviceList;               // USB Device List
        private readonly int _usbVendorID = 0x7780;
        private Forms.frmTransparentSplash _LaunchProcess;
        private string _AppVersion;
        private string _BaseURL = "http://www.smartsimtech.com/software/";
        private string _BaseFile = "sstcp-";
        private string _ExtInfo = ".rtf";

        public DataTable USBDeviceList
        {
            get { return _usbDeviceList; }
        }

        public Forms.frmTransparentSplash LaunchProcess
        {
            set { _LaunchProcess = value; }
        }

        public HidDevice GetHIDHandle(string usbGUID)
        {
            HidDevice[] Devices = HidDevices.Enumerate(_usbVendorID);

            HidDevice card = null;

            if (Devices != null && Devices.Length > 0)
            {
                foreach (HidDevice SSTCard in Devices)
                {
                    if (SSTCard.DevicePath == usbGUID)
                    {
                        card = SSTCard;
                    }
                }
            }

            return card;
        }

        public string GetUSBGUID(int CardSerialNumber, int usbDeviceID)
        {
            string usbGUID = "-1";
            for (int i = 0; i < _usbDeviceList.Rows.Count; i++)
            {
                if (_usbDeviceList.Rows[i]["serial"] is DBNull)
                {
                    usbGUID = "-1";
                }
                else
                {
                    int dbSerial = (int)_usbDeviceList.Rows[i]["serial"];
                    int dbDevID = (int)_usbDeviceList.Rows[i]["deviceid"];

                    if (dbSerial == CardSerialNumber && dbDevID == usbDeviceID)
                    {
                        usbGUID = (string)_usbDeviceList.Rows[i]["usbGUID"];
                    }
                }
            }
            return usbGUID;
        }

        public void usbAddGUID(string GUID)
        {
            _usbDeviceGUID.Add(GUID);
        }

        public void usbRemoveGUID(string GUID)
        {
            _usbDeviceGUID.Remove(GUID);
        }

        public bool usbGUIDExist(string GUID)
        {
            int Location = _usbDeviceGUID.BinarySearch(GUID);
            if (Location >= 0)
                return true;
            else
                return false;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool showStartPage = true;
            foreach (Form mdi in MdiChildren)
            {
                if (mdi is frmStartPage)
                {
                    showStartPage = false;
                    mdi.Activate();
                }
            }

            if (showStartPage)
            {
                frmStartPage frm = new frmStartPage();
                frm.MdiParent = this;
                frm.ParentFrm = this;
                frm.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            richEditControl1.LoadDocument("About Smart Sim Tech.rtf");

            Version vrs = new Version(Application.ProductVersion);
            _AppVersion = String.Format("{0}.{1}.{2}", vrs.Major, vrs.Minor, vrs.Build);

            try
            {
                WebClient getrtf = new WebClient();
                richEditControl2.RtfText = getrtf.DownloadString(_BaseURL + _BaseFile + _AppVersion + _ExtInfo);
            }
            catch (Exception)
            {
                // No Internet Connection
                richEditControl2.Text = "Release notes file not found...";
            }
            
            // Load USB Device List DataTable
            _usbDeviceList = new DataTable();

            _usbDeviceList.Columns.Add("usbGUID", typeof(string));
            _usbDeviceList.Columns.Add("GUID", typeof(string));
            _usbDeviceList.Columns.Add("cardtype", typeof(string));
            _usbDeviceList.Columns.Add("serial", typeof(int));
            _usbDeviceList.Columns.Add("deviceid", typeof(int));
            _usbDeviceList.Columns.Add("connected", typeof(bool));

            tmrEnumerateUSB.Enabled = true;
            tmrCheckFSUIPC.Enabled = true;

            // Set Application Version
            lblAppVersion.Caption = String.Format("Version: {0}", _AppVersion);
            
            // Load Start Page
            frmStartPage frm = new frmStartPage();
            frm.MdiParent = this;
            frm.ParentFrm = this;
            frm.Show();

            // Load Registration Details
            XPView view = new XPView(Session.DefaultSession, typeof(Database.Registration));
            view.AddProperty("Name", "Name");
            view.AddProperty("Company", "Company");
            bool registered = false;
            foreach (ViewRecord record in view)
            {
                lblRegisteredName.Caption = "Registered To: " + (string)record["Name"];
                registered = true;
            }

            if (!registered)
                lblRegisteredName.Caption = "Registered To: Unregistered";

            // Load Child Forms
            LoadChildrenForms();

            // Set Start Page as Default Page
            foreach (Form mdi in MdiChildren)
            {
                if (mdi is frmStartPage)
                {
                    mdi.Activate();
                }
            }

            // Set Notification Icon
            notifyIcon1.Icon = Icon;

            // Set CardConnected = false to all records in the cards database
            XPCollection cardsdb = new XPCollection(typeof(Database.Cards));
            foreach (Database.Cards record in cardsdb)
            {
                record.CardConnected = false;
                record.Save();
            }

            loaded = true;

            // Show Window
            Show();
            Refresh();

            _LaunchProcess.ApplicationLoading();

            tmrCloseSplash.Enabled = true;
        }

        private void LoadChildrenForms()
        {
            XPView cards = new XPView(Session.DefaultSession, typeof(Database.Cards));
            cards.AddProperty("Model", "CardModel");
            cards.AddProperty("Rev", "CardRevision");
            cards.AddProperty("Serial", "CardSerialNumber");
            foreach (ViewRecord record in cards)
            {
                LoadForm((string)record["Model"], (string)record["Rev"], record["Serial"].ToString());
            }
        }

        public void LoadForm(string CardModel, string CardRevision, string cardSerial)
        {
            switch (CardModel + CardRevision)
            {
                // Smart Sim Tech 30 Input Cards
                case "SST30IBeta":
                    Boards.SST30I.A.frmSST30IA SST30IBeta = new Boards.SST30I.A.frmSST30IA();
                    SST30IBeta.MdiParent = this;
                    SST30IBeta.ParentFrm = this;
                    SST30IBeta.usbDeviceID = 0x0001;
                    SST30IBeta.CardRevision = "Beta";
                    SST30IBeta.CardSerialNumber = Convert.ToInt32(cardSerial);
                    SST30IBeta.Show();
                    break;


                case "SST30IR1":
                    Boards.SST30I.A.frmSST30IA SST30IR1 = new Boards.SST30I.A.frmSST30IA();
                    SST30IR1.MdiParent = this;
                    SST30IR1.ParentFrm = this;
                    SST30IR1.usbDeviceID = 0x0002;
                    SST30IR1.CardRevision = "R1";
                    SST30IR1.CardSerialNumber = Convert.ToInt32(cardSerial);
                    SST30IR1.Show();
                    break;

                case "SST30IR2":
                    Boards.SST30I.A.frmSST30IA SST30IR2 = new Boards.SST30I.A.frmSST30IA();
                    SST30IR2.MdiParent = this;
                    SST30IR2.ParentFrm = this;
                    SST30IR2.usbDeviceID = 0x0003;
                    SST30IR2.CardRevision = "R2";
                    SST30IR2.CardSerialNumber = Convert.ToInt32(cardSerial);
                    SST30IR2.Show();
                    break;

                // Smart Sim Tech 24 Input Cards
                case "SST24OR1":
                    Boards.SST24O.A.frmSST24OA SST24OR1 = new Boards.SST24O.A.frmSST24OA();
                    SST24OR1.MdiParent = this;
                    SST24OR1.ParentFrm = this;
                    SST24OR1.usbDeviceID = 0x0004;
                    SST24OR1.CardRevision = "R1";
                    SST24OR1.CardSerialNumber = Convert.ToInt32(cardSerial);
                    SST24OR1.Show();
                    break;

                case "SST24OR2":
                    Boards.SST24O.A.frmSST24OA SST24OR2 = new Boards.SST24O.A.frmSST24OA();
                    SST24OR2.MdiParent = this;
                    SST24OR2.ParentFrm = this;
                    SST24OR2.usbDeviceID = 0x0005;
                    SST24OR2.CardRevision = "R2";
                    SST24OR2.CardSerialNumber = Convert.ToInt32(cardSerial);
                    SST24OR2.Show();
                    break;

                // Smart Sim Tech Accessory Cards
                case "SSTPSUR1":
                    Boards.PSU.A.frmSSTPSUA SSTPSUR1 = new Boards.PSU.A.frmSSTPSUA();
                    SSTPSUR1.MdiParent = this;
                    SSTPSUR1.ParentFrm = this;
                    SSTPSUR1.usbDeviceID = 0x0010;
                    SSTPSUR1.CardRevision = "R1";
                    SSTPSUR1.CardSerialNumber = Convert.ToInt32(cardSerial);
                    SSTPSUR1.Show();
                    break;
                default:
                    break;
            }
        }

        public void SelectGeneral()
        {
            ribbon.SelectedPage = rpGeneral;
        }

        private void bbtnAddCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAddCardWizard frm = new frmAddCardWizard();
            frm.ShowDialog();
            string CardModelNumber = frm.CardModelNumber;
            string CardRevisionNumber = frm.CardRevisionNumber;
            string CardSerialNumber = frm.CardSerialNumber;
            frm.Dispose();

            try
            {
                LoadForm(CardModelNumber, CardRevisionNumber, CardSerialNumber);
            }
            catch
            {
                //todo: fix this
                XtraMessageBox.Show("Error while adding card, possibly because cancel was hit");
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show Custom Dialog Box
            frmCloseSoftwareBox frm = new frmCloseSoftwareBox();
            frm.ShowDialog(this);

            switch (frm.CloseSoftwareBoxResult)
            {
                case Enum.enumCloseApplicationBox.ApplicationCloseBox.Minimize:
                    e.Cancel = true;
                    WindowState = FormWindowState.Minimized;
                    break;
                case Enum.enumCloseApplicationBox.ApplicationCloseBox.No:
                    e.Cancel = true;
                    break;
                case Enum.enumCloseApplicationBox.ApplicationCloseBox.Yes:
                    break;
            }            
        }

        private void xtraTabbedMdiManager_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallBack);
            Bitmap img = e.Page.MdiChild.Icon.ToBitmap();
            Image thumbnail = img.GetThumbnailImage(24, 24, callback, IntPtr.Zero);
            e.Page.Image = thumbnail;
        }

        private void updateTabIcons()
        {
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage Page in xtraTabbedMdiManager.Pages)
            {
                Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallBack);
                Bitmap img = Page.MdiChild.Icon.ToBitmap();
                Image thumbnail = img.GetThumbnailImage(24, 24, callback, IntPtr.Zero);
                Page.Image = thumbnail;
            }
        }

        private bool ThumbnailCallBack()
        {
            return false;
        }

        private void tmrUpdateTabIcons_Tick(object sender, EventArgs e)
        {
            updateTabIcons();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // Hide in taskbar
                ShowInTaskbar = false;
            }
            else
            {
                ShowInTaskbar = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;

                Select();
            }
        }

        private void tmrCheckFSUIPC_Tick(object sender, EventArgs e)
        {
            if (!_FSUIPCConnection)
            {
                try
                {
                    FSUIPCConnection.Open();
                    _FSUIPCConnection = true;
                }
                catch (Exception)
                {
                    FSUIPCConnection.Close();
                    _FSUIPCConnection = false;
                }
            }

            if (_FSUIPCConnection)
            {
                // Test FSUIPC Connection
                Offset<byte[]> testoffset = new Offset<byte[]>(0x0264, 2);
                try
                {
                    FSUIPCConnection.Process();
                }
                catch (Exception)
                {
                    _FSUIPCConnection = false;
                    FSUIPCConnection.Close();
                }
                testoffset.Disconnect();
            }

            if (_FSUIPCConnection)
                lblFSUIPCConnection.Caption = "FSUIPC Connection: Connected";
            else
                lblFSUIPCConnection.Caption = "FSUIPC Connection: Disconnected";
        }

        private void frmMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Help");
        }

        private void bbtnAdvancedSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAdvancedSettings frm = new frmAdvancedSettings();
            frm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("As of this release, checking for updates has not been added yet", "Check for updates");
        }

        private void bbtnHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("As of this release, the help manual has not been fully completed", "Help");
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("As of this release, the About page has not been completed yet", "About");
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bbtnRegisterSoftware_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRegistrationDetails frm = new frmRegistrationDetails();
            frm.ShowDialog();

            // Load Registration Details
            XPView view = new XPView(Session.DefaultSession, typeof(Database.Registration));
            view.AddProperty("Name", "Name");
            view.AddProperty("Company", "Company");
            bool registered = false;
            foreach (ViewRecord record in view)
            {
                lblRegisteredName.Caption = "Registered To: " + (string)record["Name"];
                registered = true;
            }

            if (!registered)
                lblRegisteredName.Caption = "Registered To: Unregistered";
        }

        private void tmrEnumerateUSB_Tick(object sender, EventArgs e)
        {
            // First clear the connected status of all cards
            for (int i = 0; i < _usbDeviceList.Rows.Count; i++)
            {
                _usbDeviceList.Rows[i]["connected"] = false;
            }

            // Enumerate all SST USB Devices
            HidDevice[] Devices = HidDevices.Enumerate(_usbVendorID);

            if (Devices != null && Devices.Length > 0)
            {
                foreach (HidDevice SSTCard in Devices)
                {
                    // Get details from card
                    int usbDeviceID = SSTCard.Attributes.ProductId;
                    string usbGUID = SSTCard.DevicePath;

                    // Next see if the card is in the database
                    int dbRecord = -1;
                    for (int i = 0; i < _usbDeviceList.Rows.Count; i++)
                    {
                        string dbGUID = (string)_usbDeviceList.Rows[i]["usbGUID"];
                        if (usbGUID == dbGUID)
                        {
                            dbRecord = i;
                        }
                    }

                    if (dbRecord != -1)
                    {
                        // Update connected flag
                        _usbDeviceList.Rows[dbRecord]["connected"] = true;

                        // Next check to see if there is a serial number
                        if (_usbDeviceList.Rows[dbRecord]["serial"] is DBNull)
                        {
                            int CardSerial = getUSBDeviceSerial(SSTCard);
                            if (CardSerial != -1)
                            {
                                _usbDeviceList.Rows[dbRecord]["serial"] = CardSerial;
                            }
                        }
                    }
                    else
                    {
                        // Add Card to Database, enumerate serial number
                        DataRow row = _usbDeviceList.NewRow();

                        string CardType = "Unknown";
                        switch (SSTCard.Attributes.ProductHexId)
                        {
                            case "0x0001":
                                CardType = "Smart Sim Tech 30 Input Card - Beta";
                                break;
                            case "0x0002":
                                CardType = "Smart Sim Tech 30 Input Card - Rev 1";
                                break;
                            case "0x0003":
                                CardType = "Smart Sim Tech 30 Input Card - Rev 2";
                                break;
                            case "0x0004":
                                CardType = "Smart Sim Tech 24 Output Card - Rev 1";
                                break;
                            case "0x0005":
                                CardType = "Smart Sim Tech 24 Output Card - Rev 2";
                                break;
                            case "0x0010":
                                CardType = "Smart Sim Tech Power Supply Controller - Rev 1";
                                break;
                        }

                        row["usbGUID"] = SSTCard.DevicePath;
                        row["cardtype"] = CardType;
                        row["connected"] = true;
                        row["serial"] = DBNull.Value;
                        row["deviceid"] = SSTCard.Attributes.ProductId;
                        _usbDeviceList.Rows.Add(row);
                    }
                }
            }

            // Delete all cards that are disconnected
            for (int i = 0; i < _usbDeviceList.Rows.Count; i++)
            {
                if ((bool)_usbDeviceList.Rows[i]["connected"] == false)
                {
                    _usbDeviceList.Rows[i].Delete();
                }
            }
        }

        private int getUSBDeviceSerial(HidDevice Device)
        {
            int CardSerial = -1;
            HidReport Report;
            Device.Open();

            do
            {
                Application.DoEvents();     // Prevent App Freezing.
            } while (Device.IsConnected == false);

            // Ask for serial number
            HidReport SerialNumber = new HidReport(3);
            SerialNumber.Data[0] = 0xFF;
            SerialNumber.Data[1] = 0x01;
            Device.WriteReport(SerialNumber);

            Report = Device.ReadReport();
            
            if (Report.Exists)
            {
                int Serial1 = Convert.ToInt32(Report.Data[1]);
                int Serial2 = Convert.ToInt32(Report.Data[2]);
                               
                CardSerial = (255 * Serial1) + Serial2;
            }
            Device.Close();
            return CardSerial;
        }

        private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Send a single byte to FSUIPC
        /// </summary>
        /// <param name="offset">Offset to send data to</param>
        /// <param name="data">Data to send as a Long</param>
        /// <returns></returns>
        public bool FSUIPC_SendByte(int offset, long data)
        {
            if (_FSUIPCConnection == false)
                return false;

            Offset<byte> testoffset = new Offset<byte>(offset);
            byte offsetvalue = Convert.ToByte(data);
            testoffset.Value = offsetvalue;
            try
            {
                FSUIPCConnection.Process();
            }
            catch (Exception)
            {
                _FSUIPCConnection = false;
                testoffset.Disconnect();
                FSUIPCConnection.Close();
                return false;
            }
            testoffset.Disconnect();
            return true;
        }

        /// <summary>
        /// Send multiple bytes to FSUIPC
        /// </summary>
        /// <param name="offset">Offset to send data to</param>
        /// <param name="data">Data to send as a Long</param>
        /// <param name="length">Length of the offset</param>
        /// <returns></returns>
        public bool FSUIPC_SendBytes(int offset, long data, int length)
        {
            if (_FSUIPCConnection == false)
                return false;

            Offset<byte[]> testoffset = new Offset<byte[]>(offset, length);
            byte[] offsetvalue = new byte[length];
            byte[] rawvalue = BitConverter.GetBytes(data);
            for (int i = 0; i < length; i++)
            {
                offsetvalue[i] = rawvalue[i];
            }
            testoffset.Value = offsetvalue;
            try
            {
                FSUIPCConnection.Process();
            }
            catch (Exception)
            {
                _FSUIPCConnection = false;
                testoffset.Disconnect();
                FSUIPCConnection.Close();
                return false;
            }
            testoffset.Disconnect();
            return true;
        }

        public bool FSUIPC_SendBit(int offset, int bit, bool value, int length)
        {
            if (_FSUIPCConnection == false)
                return false;

            //int bitnum = Convert.ToInt32(bit);
            //double bittest = bitnum / 8;
            //int length = Convert.ToInt32(Math.Floor(bittest)) + 1;
            Offset<BitArray> testoffset = new Offset<BitArray>(offset, length);
            try
            {
                FSUIPCConnection.Process();
            }
            catch (Exception)
            {
                _FSUIPCConnection = false;
                testoffset.Disconnect();
                FSUIPCConnection.Close();
                return false;
            }
            testoffset.Value[bit] = value;
            try
            {
                FSUIPCConnection.Process();
            }
            catch (Exception)
            {
                _FSUIPCConnection = false;
                testoffset.Disconnect();
                FSUIPCConnection.Close();
                return false;
            }
            testoffset.Disconnect();
            return true;
        }

        public bool FSUIPC_GetByte(int offset, ref int data)
        {
            if (_FSUIPCConnection == false)
                return false;

            Offset<byte> testoffset = new Offset<byte>(offset);
            try
            {
                FSUIPCConnection.Process();
            }
            catch (Exception)
            {
                _FSUIPCConnection = false;
                testoffset.Disconnect();
                FSUIPCConnection.Close();
                return false;
            }
            data = testoffset.Value;
            testoffset.Disconnect();
            return true;
        }

        public bool FSUIPC_GetBytes(int offset, int length, ref int data)
        {
            if (_FSUIPCConnection == false)
                return false;

            Offset<byte[]> testoffset = new Offset<byte[]>(offset, length);
            try
            {
                FSUIPCConnection.Process();
            }
            catch (Exception)
            {
                _FSUIPCConnection = false;
                testoffset.Disconnect();
                FSUIPCConnection.Close();
                return false;
            }
            string test = BitConverter.ToString(testoffset.Value, 0);
            string[] test2 = test.Split('-');
            string test3 = "";
            for (int i = test2.Length - 1; i >= 0; i--)
            {
                test3 = test3 + test2[i];
            }
            data = Convert.ToInt32(test3, 16);
            //data = BitConverter.ToInt32(testoffset.Value, 0);
            testoffset.Disconnect();
            return true;
        }

        public bool FSUIPC_GetBytes(int offset, int length, ref long data)
        {
            if (_FSUIPCConnection == false)
                return false;

            Offset<byte[]> testoffset = new Offset<byte[]>(offset, length);
            try
            {
                FSUIPCConnection.Process();
            }
            catch (Exception)
            {
                _FSUIPCConnection = false;
                testoffset.Disconnect();
                FSUIPCConnection.Close();
                return false;
            }
            //data = BitConverter.ToInt64(testoffset.Value, 0);
            data = BitConverter.ToInt32(testoffset.Value, 0);
            testoffset.Disconnect();
            return true;
        }

        public bool FSUIPC_GetBit(int offset, int bit, int bytes, ref bool data)
        {
            if (_FSUIPCConnection == false)
                return false;

            Offset<BitArray> testoffset = new Offset<BitArray>(offset, bytes);
            try
            {
                FSUIPCConnection.Process();
            }
            catch (Exception)
            {
                _FSUIPCConnection = false;
                testoffset.Disconnect();
                FSUIPCConnection.Close();
                return false;
            }
            data = testoffset.Value[bit];
            testoffset.Disconnect();
            return true;
        }

        private void trmCheckUSB_Tick(object sender, EventArgs e)
        {

        }

        private void bbtnLaunchTest_ItemClick(object sender, ItemClickEventArgs e)
        {
            Boards.Test.frmTest frm = new Boards.Test.frmTest();
            frm.MdiParent = this;
            frm.ParentFrm = this;
            frm.Show();
        }

        private void tmrCloseSplash_Tick(object sender, EventArgs e)
        {
            _LaunchProcess.Close();
            tmrCloseSplash.Enabled = false;
        }
    }
}