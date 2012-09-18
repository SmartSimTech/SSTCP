namespace SSTCP.Forms
{
    partial class frmCloseSoftwareBox
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
            this.bbtnMinimize = new DevExpress.XtraEditors.SimpleButton();
            this.bbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.bbtnOk = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // bbtnMinimize
            // 
            this.bbtnMinimize.Location = new System.Drawing.Point(247, 79);
            this.bbtnMinimize.Name = "bbtnMinimize";
            this.bbtnMinimize.Size = new System.Drawing.Size(75, 23);
            this.bbtnMinimize.TabIndex = 0;
            this.bbtnMinimize.Text = "Minimize";
            this.bbtnMinimize.Click += new System.EventHandler(this.bbtnMinimize_Click);
            // 
            // bbtnCancel
            // 
            this.bbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bbtnCancel.Location = new System.Drawing.Point(166, 79);
            this.bbtnCancel.Name = "bbtnCancel";
            this.bbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.bbtnCancel.TabIndex = 1;
            this.bbtnCancel.Text = "Cancel";
            this.bbtnCancel.Click += new System.EventHandler(this.bbtnCancel_Click);
            // 
            // bbtnOk
            // 
            this.bbtnOk.Location = new System.Drawing.Point(85, 79);
            this.bbtnOk.Name = "bbtnOk";
            this.bbtnOk.Size = new System.Drawing.Size(75, 23);
            this.bbtnOk.TabIndex = 2;
            this.bbtnOk.Text = "Ok";
            this.bbtnOk.Click += new System.EventHandler(this.bbtnOk_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(374, 26);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Are you sure you with to close the Smart Sim Tech Control Pannel Application?\r\nDo" +
                "ing so will put all cards offline, and shutdown the interface with Flight Sim.";
            // 
            // frmCloseSoftwareBox
            // 
            this.AcceptButton = this.bbtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bbtnCancel;
            this.ClientSize = new System.Drawing.Size(401, 114);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bbtnOk);
            this.Controls.Add(this.bbtnCancel);
            this.Controls.Add(this.bbtnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCloseSoftwareBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Close Smart Sim Tech Control Panel?";
            this.Load += new System.EventHandler(this.frmCloseSoftwareBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bbtnMinimize;
        private DevExpress.XtraEditors.SimpleButton bbtnCancel;
        private DevExpress.XtraEditors.SimpleButton bbtnOk;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}