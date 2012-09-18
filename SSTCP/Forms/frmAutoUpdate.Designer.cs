namespace SSTCP.Forms
{
    partial class frmAutoUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoUpdate));
            this.bbtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.lblUpdateSize = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.bbtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bbtnClose
            // 
            this.bbtnClose.Location = new System.Drawing.Point(500, 344);
            this.bbtnClose.Name = "bbtnClose";
            this.bbtnClose.Size = new System.Drawing.Size(110, 23);
            this.bbtnClose.TabIndex = 1;
            this.bbtnClose.Text = "Skip Update";
            this.bbtnClose.Click += new System.EventHandler(this.bbtnClose_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.EditValue = "0";
            this.progressBarControl1.Location = new System.Drawing.Point(12, 320);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(598, 18);
            this.progressBarControl1.TabIndex = 2;
            this.progressBarControl1.Visible = false;
            // 
            // richEditControl1
            // 
            this.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl1.Location = new System.Drawing.Point(12, 31);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.ReadOnly = true;
            this.richEditControl1.ShowCaretInReadOnly = false;
            this.richEditControl1.Size = new System.Drawing.Size(598, 307);
            this.richEditControl1.TabIndex = 6;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // lblUpdateSize
            // 
            this.lblUpdateSize.Location = new System.Drawing.Point(12, 344);
            this.lblUpdateSize.Name = "lblUpdateSize";
            this.lblUpdateSize.Size = new System.Drawing.Size(61, 13);
            this.lblUpdateSize.TabIndex = 7;
            this.lblUpdateSize.Text = "Update Size:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(361, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Smart Sim Tech Control Panel Version ### is now available for download...";
            // 
            // bbtnUpdate
            // 
            this.bbtnUpdate.Location = new System.Drawing.Point(384, 344);
            this.bbtnUpdate.Name = "bbtnUpdate";
            this.bbtnUpdate.Size = new System.Drawing.Size(110, 23);
            this.bbtnUpdate.TabIndex = 9;
            this.bbtnUpdate.Text = "Update";
            this.bbtnUpdate.Click += new System.EventHandler(this.bbtnUpdate_Click);
            // 
            // frmAutoUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 379);
            this.Controls.Add(this.bbtnUpdate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblUpdateSize);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.bbtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAutoUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Sim Tech Auto Update";
            this.Load += new System.EventHandler(this.frmAutoUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bbtnClose;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.LabelControl lblUpdateSize;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton bbtnUpdate;
    }
}