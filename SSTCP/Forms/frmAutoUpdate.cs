using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using System.Net;

namespace SSTCP.Forms
{
    public partial class frmAutoUpdate : DevExpress.XtraEditors.XtraForm
    {
        WebClient webClient1 = new WebClient();
        string _AppVersion;
        string _BaseURL = "http://www.smartsimtech.com/software/";
        string _BaseFile = "sstcp-";
        string _ExtDownload = ".msi";
        string _ExtInfo = ".rtf";
        bool _ApplyUpdate = false;

        public string AppVersion
        {
            set
            {
                _AppVersion = value;
            }
        }

        public bool ApplyUpdate
        {
            get
            {
                return _ApplyUpdate;
            }
        }

        public frmAutoUpdate()
        {
            InitializeComponent();
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarControl1.Text = e.ProgressPercentage.ToString();
            lblUpdateSize.Text = formatBytes(e.BytesReceived) + " of " + formatBytes(e.TotalBytesToReceive);  
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (progressBarControl1.Text == "100")
            {
                Process update = new Process();
                update.StartInfo.FileName = "sstcpupdate.msi";
                update.Start();
                _ApplyUpdate = true;
                Close();
            }
        }

        private string formatBytes(float bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = 0;
            for (i = 0; (int)(bytes / 1024) > 0; i++, bytes /= 1024)
                dblSByte = bytes / 1024.0;
            return String.Format("{0:0.00} {1}", dblSByte, Suffix[i]);
        }

        private void frmAutoUpdate_Load(object sender, EventArgs e)
        {
            WebClient getrtf = new WebClient();
            richEditControl1.RtfText = getrtf.DownloadString(_BaseURL + _BaseFile + _AppVersion + _ExtInfo);
            labelControl3.Text = labelControl3.Text.Replace("###", _AppVersion);

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(_BaseURL + _BaseFile + _AppVersion + _ExtDownload);
            req.Method = "HEAD";
            HttpWebResponse resp = (HttpWebResponse)(req.GetResponse());
            lblUpdateSize.Text = "Update Size: " + formatBytes(resp.ContentLength);
        }

        private void bbtnUpdate_Click(object sender, EventArgs e)
        {
            bbtnUpdate.Visible = false;
            richEditControl1.Height = richEditControl1.Height - progressBarControl1.Height - 4;
            progressBarControl1.Visible = true;
            progressBarControl1.Text = "0";
            bbtnClose.Text = "Cancel Download";

            webClient1.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient1.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient1.DownloadFileAsync(new Uri(_BaseURL + _BaseFile + _AppVersion + _ExtDownload), @"sstcpupdate.msi");
        }

        private void bbtnClose_Click(object sender, EventArgs e)
        {
            if (progressBarControl1.Visible == false)
            {
                _ApplyUpdate = false;
                Close(); // Skip Update
            }
            else
            {
                _ApplyUpdate = false;
                webClient1.CancelAsync();
                Close(); // Cancel Update;
            }
        }

    }
}