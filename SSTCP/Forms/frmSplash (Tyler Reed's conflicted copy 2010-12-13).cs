using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SSTCP.Forms
{
    public partial class frmSplash : DevExpress.XtraEditors.XtraForm
    {
        public bool RunApplication = false;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrCloseWindow_Tick(object sender, EventArgs e)
        {
            RunApplication = true;
            Close();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            // Check to see if application is registered

            tmrCloseWindow.Enabled = true;
        }
    }
}