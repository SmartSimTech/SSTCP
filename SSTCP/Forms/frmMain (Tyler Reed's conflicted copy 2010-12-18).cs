using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.LookAndFeel;

namespace SSTCP.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Form1 frm = new Form1();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Sharp Plus");
            // Load Start Page
            frmStartPage frm = new frmStartPage();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}