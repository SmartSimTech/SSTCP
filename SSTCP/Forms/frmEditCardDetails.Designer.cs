namespace SSTCP.Forms
{
    partial class frmEditCardDetails
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.tbDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.tbName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.bbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.bbtnOk = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Controls.Add(this.xtraTabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bbtnCancel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bbtnOk, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.xtraTabControl1, 3);
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(367, 266);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.tbDescription);
            this.xtraTabPage1.Controls.Add(this.lblDescription);
            this.xtraTabPage1.Controls.Add(this.tbName);
            this.xtraTabPage1.Controls.Add(this.lblName);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(361, 239);
            this.xtraTabPage1.Text = "General";
            // 
            // tbDescription
            // 
            this.tbDescription.EditValue = "";
            this.tbDescription.Location = new System.Drawing.Point(3, 67);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(355, 169);
            this.tbDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(3, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Input Description:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 22);
            this.tbName.Name = "tbName";
            this.tbName.Properties.MaxLength = 40;
            this.tbName.Size = new System.Drawing.Size(355, 20);
            this.tbName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Input Name:";
            // 
            // bbtnCancel
            // 
            this.bbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bbtnCancel.Location = new System.Drawing.Point(214, 275);
            this.bbtnCancel.Name = "bbtnCancel";
            this.bbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.bbtnCancel.TabIndex = 1;
            this.bbtnCancel.Text = "Cancel";
            // 
            // bbtnOk
            // 
            this.bbtnOk.Location = new System.Drawing.Point(295, 275);
            this.bbtnOk.Name = "bbtnOk";
            this.bbtnOk.Size = new System.Drawing.Size(75, 23);
            this.bbtnOk.TabIndex = 2;
            this.bbtnOk.Text = "Ok";
            this.bbtnOk.Click += new System.EventHandler(this.bbtnOk_Click);
            // 
            // frmEditCardDetails
            // 
            this.AcceptButton = this.bbtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bbtnCancel;
            this.ClientSize = new System.Drawing.Size(373, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditCardDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Details";
            this.Load += new System.EventHandler(this.frmEditCardDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton bbtnCancel;
        private DevExpress.XtraEditors.SimpleButton bbtnOk;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.MemoEdit tbDescription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        public DevExpress.XtraEditors.TextEdit tbName;

    }
}