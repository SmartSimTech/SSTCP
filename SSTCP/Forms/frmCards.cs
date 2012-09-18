using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SSTCP.Database;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using SSTCP.Classes;
using SSTCP.Boards;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace SSTCP.Forms
{
    public partial class frmCards : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private frmMain _parent;

        public frmMain ParentFrm
        {
            set
            {
                _parent = value;
            }
        }

        public frmCards()
        {
            InitializeComponent();
        }

        private void frmCards_Load(object sender, EventArgs e)
        {

        }

        private void tmrReload_Tick(object sender, EventArgs e)
        {
            xpCollection1.Reload();
        }

        private void bbtnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bbtnNewCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAddCardWizard frm = new frmAddCardWizard();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void gridView1_ShowGridMenu(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                popupMenu1.ShowPopup(PointToScreen(e.Point));
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void bbtnEditCardDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
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

        private void bbtnDeleteCard_ItemClick(object sender, ItemClickEventArgs e)
        {
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
                            AnalogInputConfiguration obj;
                            for (int i = 1; i <= 30; i++)
                            {
                                obj = Session.DefaultSession.FindObject<AnalogInputConfiguration>(CriteriaOperator.Parse("[CardSerial] == ? AND [CardRevision] == ? AND [CardModel] == ? AND [Input] == ?", cardSerialNumber, cardRevision, cardModel, i));
                                obj.Delete();
                            }

                            Cards obj2;
                            obj2 = Session.DefaultSession.FindObject<Cards>(CriteriaOperator.Parse("[CardModel] == ? AND [CardRevision] == ? AND [CardSerialNumber] ==?", cardModel, cardRevision, cardSerialNumber));
                            obj2.Delete();
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }
            
            return null;
        }

        private void bbtnOpenCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            int cardSerialNumber = (int)gridView1.GetFocusedRowCellValue("CardSerialNumber");
            string cardRevision = (string)gridView1.GetFocusedRowCellValue("CardRevision");
            string cardModel = (string)gridView1.GetFocusedRowCellValue("CardModel");
            
            string cardtype = cardModel + cardRevision;

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
                                    frm.Activate();
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
                        Boards.SST30I.A.frmSST30IA SST30IBeta = new Boards.SST30I.A.frmSST30IA();
                        SST30IBeta.MdiParent = _parent;
                        SST30IBeta.ParentFrm = _parent;
                        SST30IBeta.CardSerialNumber = cardSerialNumber;
                        SST30IBeta.usbDeviceID = 0x0001;
                        SST30IBeta.CardRevision = "Beta";
                        SST30IBeta.Show();
                        break;

                    case "SST30IR1":
                        Boards.SST30I.A.frmSST30IA SST30IR1 = new Boards.SST30I.A.frmSST30IA();
                        SST30IR1.MdiParent = _parent;
                        SST30IR1.ParentFrm = _parent;
                        SST30IR1.usbDeviceID = 0x0002;
                        SST30IR1.CardRevision = "R1";
                        SST30IR1.CardSerialNumber = cardSerialNumber;
                        SST30IR1.Show();
                        break;

                    case "SST30IR2":
                        Boards.SST30I.A.frmSST30IA SST30IR2 = new Boards.SST30I.A.frmSST30IA();
                        SST30IR2.MdiParent = _parent;
                        SST30IR2.ParentFrm = _parent;
                        SST30IR2.usbDeviceID = 0x0003;
                        SST30IR2.CardRevision = "R2";
                        SST30IR2.CardSerialNumber = cardSerialNumber;
                        SST30IR2.Show();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}