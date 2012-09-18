namespace SSTCP.Forms
{
    partial class frmAddCardWizard
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
            this.components = new System.ComponentModel.Container();
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbModelNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbRevisionNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbSerialNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblStep1Error = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.meCardDetails = new DevExpress.XtraEditors.MemoEdit();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbCardName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tbCardDescription = new DevExpress.XtraEditors.MemoEdit();
            this.defaultToolTipController1 = new DevExpress.Utils.DefaultToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.welcomeWizardPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbModelNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRevisionNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSerialNumber.Properties)).BeginInit();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meCardDetails.Properties)).BeginInit();
            this.wizardPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCardName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCardDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.wizardControl1, DevExpress.Utils.DefaultBoolean.Default);
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage2);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.wizardPage2,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(505, 319);
            this.wizardControl1.Text = "Card Wizard";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControl1_SelectedPageChanging);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.AllowBack = false;
            this.defaultToolTipController1.SetAllowHtmlText(this.welcomeWizardPage1, DevExpress.Utils.DefaultBoolean.Default);
            this.welcomeWizardPage1.AllowNext = false;
            this.welcomeWizardPage1.Controls.Add(this.tableLayoutPanel1);
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(445, 157);
            this.welcomeWizardPage1.Text = "Card Details";
            // 
            // tableLayoutPanel1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.tableLayoutPanel1, DevExpress.Utils.DefaultBoolean.Default);
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbModelNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbRevisionNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbSerialNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStep1Error, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Model Number:";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Revision Number:";
            // 
            // cbModelNumber
            // 
            this.cbModelNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbModelNumber.Location = new System.Drawing.Point(103, 3);
            this.cbModelNumber.Name = "cbModelNumber";
            this.cbModelNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbModelNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbModelNumber.Size = new System.Drawing.Size(339, 20);
            this.cbModelNumber.TabIndex = 2;
            this.cbModelNumber.SelectedIndexChanged += new System.EventHandler(this.cbModelNumber_SelectedIndexChanged);
            // 
            // cbRevisionNumber
            // 
            this.cbRevisionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRevisionNumber.Location = new System.Drawing.Point(103, 28);
            this.cbRevisionNumber.Name = "cbRevisionNumber";
            this.cbRevisionNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRevisionNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbRevisionNumber.Size = new System.Drawing.Size(339, 20);
            this.cbRevisionNumber.TabIndex = 3;
            this.cbRevisionNumber.SelectedIndexChanged += new System.EventHandler(this.cbRevisionNumber_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Serial Number:";
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSerialNumber.Location = new System.Drawing.Point(103, 53);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(339, 20);
            this.tbSerialNumber.TabIndex = 5;
            this.tbSerialNumber.EditValueChanged += new System.EventHandler(this.tbSerialNumber_EditValueChanged);
            // 
            // lblStep1Error
            // 
            this.lblStep1Error.Appearance.Options.UseTextOptions = true;
            this.lblStep1Error.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblStep1Error.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblStep1Error.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStep1Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStep1Error.Location = new System.Drawing.Point(103, 78);
            this.lblStep1Error.Name = "lblStep1Error";
            this.lblStep1Error.Size = new System.Drawing.Size(339, 76);
            this.lblStep1Error.TabIndex = 6;
            // 
            // wizardPage1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.wizardPage1, DevExpress.Utils.DefaultBoolean.Default);
            this.wizardPage1.Controls.Add(this.meCardDetails);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(445, 157);
            this.wizardPage1.Text = "Confirm Card Details";
            // 
            // meCardDetails
            // 
            this.meCardDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meCardDetails.Location = new System.Drawing.Point(0, 0);
            this.meCardDetails.Name = "meCardDetails";
            this.meCardDetails.Properties.ReadOnly = true;
            this.meCardDetails.Size = new System.Drawing.Size(445, 157);
            this.meCardDetails.TabIndex = 0;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.AllowBack = false;
            this.completionWizardPage1.AllowCancel = false;
            this.defaultToolTipController1.SetAllowHtmlText(this.completionWizardPage1, DevExpress.Utils.DefaultBoolean.Default);
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(445, 157);
            // 
            // wizardPage2
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.wizardPage2, DevExpress.Utils.DefaultBoolean.Default);
            this.wizardPage2.Controls.Add(this.tableLayoutPanel2);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(445, 157);
            this.wizardPage2.Text = "Extended Card Details";
            // 
            // tableLayoutPanel2
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.tableLayoutPanel2, DevExpress.Utils.DefaultBoolean.Default);
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tbCardName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbCardDescription, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(445, 157);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbCardName
            // 
            this.tbCardName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCardName.Location = new System.Drawing.Point(103, 3);
            this.tbCardName.Name = "tbCardName";
            this.tbCardName.Size = new System.Drawing.Size(339, 20);
            this.tbCardName.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(3, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 19);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Card Name:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(3, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 126);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Card Description:";
            // 
            // tbCardDescription
            // 
            this.tbCardDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCardDescription.Location = new System.Drawing.Point(103, 28);
            this.tbCardDescription.Name = "tbCardDescription";
            this.tbCardDescription.Size = new System.Drawing.Size(339, 126);
            this.tbCardDescription.TabIndex = 4;
            // 
            // frmAddCardWizard
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 319);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCardWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Card Wizard";
            this.Load += new System.EventHandler(this.frmAddCardWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.welcomeWizardPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbModelNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRevisionNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSerialNumber.Properties)).EndInit();
            this.wizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meCardDetails.Properties)).EndInit();
            this.wizardPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCardName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCardDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbModelNumber;
        private DevExpress.XtraEditors.ComboBoxEdit cbRevisionNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbSerialNumber;
        private DevExpress.XtraEditors.MemoEdit meCardDetails;
        private DevExpress.Utils.DefaultToolTipController defaultToolTipController1;
        private DevExpress.XtraEditors.LabelControl lblStep1Error;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.TextEdit tbCardName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit tbCardDescription;
    }
}