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
using HIDLibrary;
using DevExpress.XtraEditors;
using SmartSimTech.FSUIPC;
using WindowsTaskDialog;

namespace SSTCP.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ArrayList _usbDeviceGUID = new ArrayList();
        public bool loaded = false;
        private FSUIPC _FSUIPCCon = new FSUIPC();       // FSUIPC Connection
        private bool _FSUIPCConnection = false;         // FSUIPC Connection Bool
        private bool _FSUIPCShowConnErrorMsg = true;    // Show Connection Error Message
        private bool _FSUIPCLostConnection = false;     // Show Connection Established Message
        private int _dwFSReq = 0;                       // Any Version of Flight Sim is OK
        private int _dwResult = -1;                     // Variable to Hold Result
        private bool _fsResult = false;                 // Return Bool for FSUIPC method calls
        private int _token = -1;

        public FSUIPC FSUIPCCon
        {
            get { return _FSUIPCCon; }
        }

        public bool FSUIPCConnection
        {
            get { return _FSUIPCConnection; }
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
            // Set template
            UserLookAndFeel.Default.SetSkinStyle("Sharp Plus");

            // Set Application Version
            Version vrs = new Version(Application.ProductVersion);
            lblAppVersion.Caption = String.Format("Version: {0}.{1}.{2}", vrs.Major, vrs.Minor, vrs.Build);
            
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

            loaded = true;
        }

        private void LoadChildrenForms()
        {
            XPView cards = new XPView(Session.DefaultSession, typeof(Database.Cards));
            cards.AddProperty("Model", "CardModel");
            cards.AddProperty("Rev", "CardRevision");
            cards.AddProperty("Serial", "CardSerialNumber");
            foreach (ViewRecord record in cards)
            {
                switch ((string)record["Model"] + (string)record["Rev"])
                {
                    // Smart Sim Tech 30 Input Cards
                    case "SST30IBeta":
                        Boards.SST30I.Beta.frmSST30IBeta SST30IBeta = new Boards.SST30I.Beta.frmSST30IBeta();
                        SST30IBeta.MdiParent = this;
                        SST30IBeta.ParentFrm = this;
                        SST30IBeta.CardSerialNumber = (int)record["Serial"];
                        SST30IBeta.Show();
                        break;

                    case "SST30IR1":
                        Boards.SST30I.Rev1.frmSST30IR1 SST30IR1 = new Boards.SST30I.Rev1.frmSST30IR1();
                        SST30IR1.MdiParent = this;
                        SST30IR1.CardSerialNumber = (int)record["Serial"];
                        SST30IR1.Show();
                        break;

                    default:
                        break;
                }
            }
        }

        public void LoadForm(string CardModel, string CardRevision, string cardSerial)
        {
            switch (CardModel + CardRevision)
            {
                // Smart Sim Tech 30 Input Cards
                case "SST30IBeta":
                    Boards.SST30I.Beta.frmSST30IBeta SST30IBeta = new Boards.SST30I.Beta.frmSST30IBeta();
                    SST30IBeta.MdiParent = this;
                    SST30IBeta.ParentFrm = this;
                    SST30IBeta.CardSerialNumber = Convert.ToInt32(cardSerial);
                    SST30IBeta.Show();
                    break;

                case "SST30IR1":
                    Boards.SST30I.Rev1.frmSST30IR1 SST30IR1 = new Boards.SST30I.Rev1.frmSST30IR1();
                    SST30IR1.MdiParent = this;
                    SST30IR1.CardSerialNumber = Convert.ToInt32(cardSerial);
                    SST30IR1.Show();
                    break;

                default:
                    break;
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            
        }

        public void SelectGeneral()
        {
            ribbon.SelectedPage = rpGeneral;
        }

        private void bbtnManageCards_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool showCards = true;
            foreach (Form mdi in MdiChildren)
            {
                if (mdi is frmCards)
                {
                    showCards = false;
                    mdi.Activate();
                }
            }

            if (showCards)
            {
                frmCards frm = new frmCards();
                frm.MdiParent = this;
                frm.ParentFrm = this;
                frm.Show();
            }
        }

        private void bbtnAddCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAddCardWizard frm = new frmAddCardWizard();
            frm.ShowDialog();
            string CardModelNumber = frm.CardModelNumber;
            string CardRevisionNumber = frm.CardRevisionNumber;
            string CardSerialNumber = frm.CardSerialNumber;
            frm.Dispose();

            LoadForm(CardModelNumber, CardRevisionNumber, CardSerialNumber);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create task dialog.
            TaskDialog taskDialog = new TaskDialog();
            taskDialog.WindowTitle = "Close Smart Sim Tech Control Panel";
            taskDialog.MainIcon = TaskDialogIcon.Information;
            taskDialog.MainInstruction = "Close Smart Sim Tech Control Panel";
            taskDialog.Content = "Are you sure you wish to close the Smart Sim Tech Control Panel?  The cards will be offline once this application is closed.";
            taskDialog.CommonButtons = WindowsTaskDialog.TaskDialogCommonButtons.Yes |
                                       WindowsTaskDialog.TaskDialogCommonButtons.No;
            List<WindowsTaskDialog.TaskDialogButton> buttons = new List<WindowsTaskDialog.TaskDialogButton>();
            buttons.Add(new WindowsTaskDialog.TaskDialogButton(1000, "Minimize"));
            taskDialog.Buttons = buttons.ToArray();
            TaskDialog.ShowNonVistaTaskDialogOnVistaOS = true;

            // Show task dialog.
            int dialogResult = taskDialog.Show(this);

            switch (dialogResult)
            {
                case 1000:
                    e.Cancel = true;
                    WindowState = FormWindowState.Minimized;
                    break;
                case 4:
                    e.Cancel = true;
                    break;
                default:
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

        private void trmCheckUSB_Tick(object sender, EventArgs e)
        {

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

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            
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
                _FSUIPCCon.FSUIPC_Initialization();
                _fsResult = _FSUIPCCon.FSUIPC_Open(_dwFSReq, ref _dwResult);
                if (_fsResult)
                {
                    _FSUIPCConnection = true;
                    _FSUIPCShowConnErrorMsg = true;
                    if (_FSUIPCLostConnection)
                    {
                        alertControl1.Show(this, "Smart Sim Tech Control Panel", "Connection to FSUIPC has been established");
                        _FSUIPCLostConnection = false;
                    }
                }
                else
                {
                    if (_FSUIPCShowConnErrorMsg)
                    {
                        alertControl1.Show(this, "Smart Sim Tech Control Panel", "Can not connect to FSUIPC, please make sure Flight Sim or Wide Client is running.");
                        _FSUIPCShowConnErrorMsg = false;
                        _FSUIPCLostConnection = true;
                    }
                }
            }

            if (_FSUIPCConnection)
            {
                _fsResult = _FSUIPCCon.FSUIPC_Read(0x0564, 4, ref _token, ref _dwResult);
                _fsResult = _FSUIPCCon.FSUIPC_Process(ref _dwResult);
                _fsResult = _FSUIPCCon.FSUIPC_Get(ref _token, ref _dwResult);

                if (!_fsResult)
                {
                    _FSUIPCConnection = false;
                    _FSUIPCCon.FSUIPC_Close();
                }
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
    }
}