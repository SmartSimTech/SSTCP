using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// USB Library
using HIDLibrary;
// SST
using SSTCP.Classes;
using SSTCP.Boards;
using SSTCP.Database;
// Devexpress
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;


namespace SSTCP.Forms
{
    public partial class frmStartPage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private frmMain _parent;
        private readonly int _usbVendorID = 0x7780;

        public frmMain ParentFrm
        {
            set
            {
                _parent = value;
            }
        }

        public frmStartPage()
        {
            InitializeComponent();
        }

        private void frmStartPage_Load(object sender, EventArgs e)
        {
            //wbNews.Navigate("http://www.smartsimtech.com/sstcp/news.php?appversion=");

            // Setup Group Control Boxes
            gcCards.Dock = DockStyle.Fill;
            gcSupport.Dock = DockStyle.Fill;
            gcUSB.Dock = DockStyle.Fill;

            // Hide Group Control Boxes
            gcSupport.Visible = false;
            gcUSB.Visible = false;

            // Enumerate Cards
            EnumerateCards();
        }

        private void EnumerateCards()
        {
            DataTable dtCards = new DataTable();
            dtCards = _parent.USBDeviceList;
            gridControl2.DataSource = dtCards;
        }

        private void bbtnAddCard_Click(object sender, EventArgs e)
        {
            frmAddCardWizard frm = new frmAddCardWizard();
            frm.ShowDialog();
            string CardModelNumber = frm.CardModelNumber;
            string CardRevisionNumber = frm.CardRevisionNumber;
            string CardSerialNumber = frm.CardSerialNumber;
            frm.Dispose();

            _parent.LoadForm(CardModelNumber, CardRevisionNumber, CardSerialNumber);
        }

        private void bbtnCardManager_Click(object sender, EventArgs e)
        {
            bool showCards = true;
            foreach (Form mdi in MdiParent.MdiChildren)
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
                frm.MdiParent = MdiParent;
                frm.ParentFrm = _parent;
                frm.Show();
            }
        }

        private void frmStartPage_Activated(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(SelectGeneral));
        }

        private void SelectGeneral()
        {
            _parent.SelectGeneral();
        }

        private void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            switch (e.Group.Caption)
            {
                case "Cards":
                    gcCards.Visible = true;
                    gcSupport.Visible = false;
                    gcUSB.Visible = false;
                    break;

                case "Support":
                    gcCards.Visible = false;
                    gcSupport.Visible = true;
                    gcUSB.Visible = false;
                    break;

                case "USB Browser":
                    gcCards.Visible = false;
                    gcSupport.Visible = false;
                    gcUSB.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void bbtnRefreshUSBList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            EnumerateCards();
        }

        private void bbtnEditSelectedCard_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                return;

            // Show Edit Box
            int cardSerialNumber = (int)gridView1.GetFocusedRowCellValue("CardSerialNumber");
            string cardRevision = (string)gridView1.GetFocusedRowCellValue("CardRevision");
            string cardModel = (string)gridView1.GetFocusedRowCellValue("CardModel");

            Forms.frmEditCardDetails frm = new Forms.frmEditCardDetails();
            frm.DialogMode = clsEditCardDetailsDialogType.DialogType.CardEdit;
            frm.CardSerial = cardSerialNumber;
            frm.CardModel = cardModel;
            frm.CardRevision = cardRevision;
            frm.ShowDialog(this);

            if (!frm.Canceled)
            {
                // Refresh Data
                gridControl1.RefreshDataSource();
            }
        }

        private void bbtnDeleteSelectedCard_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
                return;

            int cardSerialNumber = (int)gridView1.GetFocusedRowCellValue("CardSerialNumber");
            string cardRevision = (string)gridView1.GetFocusedRowCellValue("CardRevision");
            string cardModel = (string)gridView1.GetFocusedRowCellValue("CardModel");

            string cardtype = cardModel + cardRevision;

            if (XtraMessageBox.Show("Are you sure you wish to delete the card?", "Delete Card", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                bool cardOpen = false;

                foreach (Form mdi in _parent.MdiChildren)
                {
                    switch (cardtype)
                    {
                        case "SST30IBeta":
                        case "SST30IR1":
                        case "SST30IR2":
                            if (mdi is Boards.SST30I.A.frmSST30IA)
                            {
                                Boards.SST30I.A.frmSST30IA frm = (Boards.SST30I.A.frmSST30IA)mdi;
                                if (frm.CardRevision == cardRevision)
                                {
                                    if (frm.CardSerialNumber == cardSerialNumber)
                                    {
                                        XtraMessageBox.Show("You must close the card first before you can delete it.", "Delete Card", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                        cardOpen = true;
                                    }
                                }
                            }
                            break;

                        case "SST24OR1":
                        case "SST24OR2":
                            if (mdi is Boards.SST24O.A.frmSST24OA)
                            {
                                Boards.SST24O.A.frmSST24OA frm = (Boards.SST24O.A.frmSST24OA)mdi;
                                if (frm.CardRevision == cardRevision)
                                {
                                    if (frm.CardSerialNumber == cardSerialNumber)
                                    {
                                        XtraMessageBox.Show("You must close the card first before you can delete it.", "Delete Card", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                        cardOpen = true;
                                    }
                                }
                            }
                            break;

                        case "SSTPSUR1":
                            if (mdi is Boards.PSU.A.frmSSTPSUA)
                            {
                                Boards.PSU.A.frmSSTPSUA frm = (Boards.PSU.A.frmSSTPSUA)mdi;
                                if (frm.CardRevision == cardRevision)
                                {
                                    if (frm.CardSerialNumber == cardSerialNumber)
                                    {
                                        XtraMessageBox.Show("You must close the card first before you can delete it.", "Delete Card", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                        cardOpen = true;
                                    }
                                }
                            }
                            break;

                        default:
                            break;
                    }
                }


                if (!cardOpen)
                {
                    switch (cardtype)
                    {
                        case "SST30IBeta":
                        case "SST30IR1":
                        case "SST30IR2":
                            AnalogInputConfiguration obja;
                            for (int i = 1; i <= 30; i++)
                            {
                                obja = Session.DefaultSession.FindObject<AnalogInputConfiguration>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [CardModel] == ? AND [Input] == ?", cardSerialNumber, cardRevision, cardModel, i));
                                obja.Delete();
                            }

                            Cards obj2a;
                            obj2a = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardModel] == ? AND [CardRevision] == ? AND [CardSerialNumber] ==?", cardModel, cardRevision, cardSerialNumber));
                            obj2a.Delete();
                            break;

                        case "SST24OR1":
                        case "SST24OR2":
                            AnalogOutputConfiguration objb;
                            for (int i = 1; i <= 24; i++)
                            {
                                objb = Session.DefaultSession.FindObject<AnalogOutputConfiguration>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [CardModel] == ? AND [Output] == ?", cardSerialNumber, cardRevision, cardModel, i));
                                objb.Delete();
                            }

                            //AnalogOutputScripts obj3b;
                            //obj3b = Session.DefaultSession.FindObject<AnalogOutputScripts>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [CardModel] == ?", cardSerialNumber, cardRevision, cardModel));
                            //obj3b.Delete();
                            //XPCollection collection = new XPCollection(typeof(Database.AnalogOutputScripts), CriteriaOperator.Parse(String.Format("CardModel == '{0}' AND CardRevision == '{1}' AND CardSerial == {2}", cardModel, cardRevision, cardSerialNumber)));
                            //foreach (Database.AnalogOutputScripts dbitem in collection)
                            //{
                            //    dbitem.Delete();
                            //}
                            //collection.Dispose();

                            Cards obj2b;
                            obj2b = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardModel] == ? AND [CardRevision] == ? AND [CardSerialNumber] ==?", cardModel, cardRevision, cardSerialNumber));
                            obj2b.Delete();
                            break;

                        case "SSTPSUR1":
                            Cards obj2c;
                            obj2c = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardModel] == ? AND [CardRevision] == ? AND [CardSerialNumber] ==?", cardModel, cardRevision, cardSerialNumber));
                            obj2c.Delete();
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        private void tmrRefreshCards_Tick(object sender, EventArgs e)
        {
            xpCollection1.Reload();
        }

        private void bbtnExportUSBList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            // Export Card List
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Title = "Export Card List";
            //sfd.
            //sfd.ShowDialog();
            //gridControl2.ExportToXlsx();
            
        }
    }
}