using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SSTCP.Enum;
using DevExpress.XtraEditors;

namespace SSTCP.Forms
{
    public partial class frmCloseSoftwareBox : DevExpress.XtraEditors.XtraForm
    {
        private enumCloseApplicationBox.ApplicationCloseBox _CloseSoftwareBoxResult;

        public enumCloseApplicationBox.ApplicationCloseBox CloseSoftwareBoxResult
        {
            get
            {
                return _CloseSoftwareBoxResult;
            }
        }

        public frmCloseSoftwareBox()
        {
            InitializeComponent();
        }

        private void frmCloseSoftwareBox_Load(object sender, EventArgs e)
        {

        }

        private void bbtnMinimize_Click(object sender, EventArgs e)
        {
            _CloseSoftwareBoxResult = enumCloseApplicationBox.ApplicationCloseBox.Minimize;
            Close();
        }

        private void bbtnCancel_Click(object sender, EventArgs e)
        {
            _CloseSoftwareBoxResult = enumCloseApplicationBox.ApplicationCloseBox.No;
            Close();
        }

        private void bbtnOk_Click(object sender, EventArgs e)
        {
            _CloseSoftwareBoxResult = enumCloseApplicationBox.ApplicationCloseBox.Yes;
            Close();
        }
    }
}