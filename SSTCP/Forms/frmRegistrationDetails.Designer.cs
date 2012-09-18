namespace SSTCP.Forms
{
    partial class frmRegistrationDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrationDetails));
            this.bbtnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.tbName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbCompany = new DevExpress.XtraEditors.TextEdit();
            this.tbKey = new DevExpress.XtraEditors.TextEdit();
            this.bbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bbtnRegister
            // 
            this.bbtnRegister.Location = new System.Drawing.Point(286, 116);
            this.bbtnRegister.Name = "bbtnRegister";
            this.bbtnRegister.Size = new System.Drawing.Size(104, 23);
            this.bbtnRegister.TabIndex = 0;
            this.bbtnRegister.Text = "Register";
            this.bbtnRegister.Click += new System.EventHandler(this.bbtnRegister_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(76, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(314, 20);
            this.tbName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(214, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Please register Smart Sim Tech Control Panel";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Key:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Name:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Company:";
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(76, 64);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(314, 20);
            this.tbCompany.TabIndex = 6;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(76, 90);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(314, 20);
            this.tbKey.TabIndex = 7;
            // 
            // bbtnCancel
            // 
            this.bbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bbtnCancel.Location = new System.Drawing.Point(176, 116);
            this.bbtnCancel.Name = "bbtnCancel";
            this.bbtnCancel.Size = new System.Drawing.Size(104, 23);
            this.bbtnCancel.TabIndex = 8;
            this.bbtnCancel.Text = "Later";
            this.bbtnCancel.Click += new System.EventHandler(this.bbtnCancel_Click);
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "Registration Page";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(12, 121);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit1.Size = new System.Drawing.Size(89, 18);
            this.hyperLinkEdit1.TabIndex = 9;
            this.hyperLinkEdit1.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hyperLinkEdit1_OpenLink);
            // 
            // frmRegistrationDetails
            // 
            this.AcceptButton = this.bbtnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bbtnCancel;
            this.ClientSize = new System.Drawing.Size(402, 148);
            this.Controls.Add(this.hyperLinkEdit1);
            this.Controls.Add(this.bbtnCancel);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.bbtnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration Details";
            this.Activated += new System.EventHandler(this.frmRegistrationDetails_Activated);
            this.Load += new System.EventHandler(this.frmRegistrationDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bbtnRegister;
        private DevExpress.XtraEditors.TextEdit tbName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbCompany;
        private DevExpress.XtraEditors.TextEdit tbKey;
        private DevExpress.XtraEditors.SimpleButton bbtnCancel;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
    }
}