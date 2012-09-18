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

namespace SSTCP.Forms
{
    public partial class frmCards : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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

        private void gridView1_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                popupMenu1.ShowPopup(PointToScreen(e.Point));
            }
        }
    }
}