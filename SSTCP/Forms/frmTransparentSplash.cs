using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SSTCP.Forms
{
    public partial class frmTransparentSplash : Form
    {
        public bool RunApplication = true;

        public frmTransparentSplash()
        {
            InitializeComponent();
        }

        public void CheckDatabase()
        {
            pictureEdit2.Enabled = true;
            labelControl1.Text = "Checking for application database...";
            Refresh();
            Thread.Sleep(2000);
        }

        public void CheckRegistration()
        {
            pictureEdit3.Enabled = true;
            labelControl1.Text = "Checking for software registration...";
            Refresh();
            Thread.Sleep(2000);
        }

        public void LaunchApplication()
        {
            pictureEdit4.Enabled = true;
            labelControl1.Text = "Launching Smart Sim Tech Control Panel...";
            Refresh();
            Thread.Sleep(1000);
        }

        public void ApplicationLoading()
        {
            labelControl1.Text = "Loading Application and Settings...";
            TopMost = true;
            Refresh();
        }

        private void frmTransparentSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
