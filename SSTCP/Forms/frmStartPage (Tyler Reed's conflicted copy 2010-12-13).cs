using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SSTCP.Forms
{
    public partial class frmStartPage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmStartPage()
        {
            InitializeComponent();
        }

        private void frmStartPage_Load(object sender, EventArgs e)
        {
            wbNews.Navigate("http://www.smartsimtech.com/sstcp/news.php?appversion=");
        }

#region "Request Support Button Handler"
        private void lblRequestSupport_MouseClick(object sender, MouseEventArgs e)
        {
            pcRequestSupport_MouseClick(sender, e);
        }

        private void imgRequestSupport_MouseClick(object sender, MouseEventArgs e)
        {
            pcRequestSupport_MouseClick(sender, e);
        }

        private void pcRequestSupport_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MessageBox.Show("Request Support Clicked");
            }
        }
#endregion

        #region "Board List Button Handler"
        private void lblBoardList_MouseClick(object sender, MouseEventArgs e)
        {
            pcBoardList_MouseClick(sender, e);
        }

        private void imgBoardList_MouseClick(object sender, MouseEventArgs e)
        {
            pcBoardList_MouseClick(sender, e);
        }

        private void pcBoardList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MessageBox.Show("Board List Clicked");
            }
        }
#endregion


    }
}