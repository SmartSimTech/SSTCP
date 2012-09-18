namespace SSTCP.Forms
{
    partial class frmStartPage
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.clientPanel = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bbtnUpdates = new DevExpress.XtraEditors.SimpleButton();
            this.bbtnSupport = new DevExpress.XtraEditors.SimpleButton();
            this.bbtnCardManager = new DevExpress.XtraEditors.SimpleButton();
            this.bbtnAddCard = new DevExpress.XtraEditors.SimpleButton();
            this.wbNews = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).BeginInit();
            this.clientPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.SelectedPage = this.ribbonPage1;
            this.ribbon.Size = new System.Drawing.Size(860, 143);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // clientPanel
            // 
            this.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clientPanel.Controls.Add(this.tableLayoutPanel1);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 143);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(860, 412);
            this.clientPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bbtnUpdates, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bbtnSupport, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bbtnCardManager, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bbtnAddCard, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.wbNews, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 412);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox3, 2);
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(854, 94);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // bbtnUpdates
            // 
            this.bbtnUpdates.AllowFocus = false;
            this.bbtnUpdates.Appearance.Options.UseTextOptions = true;
            this.bbtnUpdates.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bbtnUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbtnUpdates.Image = global::SSTCP.Properties.Resources.Refresh;
            this.bbtnUpdates.Location = new System.Drawing.Point(3, 208);
            this.bbtnUpdates.Name = "bbtnUpdates";
            this.bbtnUpdates.Size = new System.Drawing.Size(194, 29);
            this.bbtnUpdates.TabIndex = 6;
            this.bbtnUpdates.Text = "Check for Updates";
            // 
            // bbtnSupport
            // 
            this.bbtnSupport.AllowFocus = false;
            this.bbtnSupport.Appearance.Options.UseTextOptions = true;
            this.bbtnSupport.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bbtnSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbtnSupport.Image = global::SSTCP.Properties.Resources.Contact;
            this.bbtnSupport.Location = new System.Drawing.Point(3, 173);
            this.bbtnSupport.Name = "bbtnSupport";
            this.bbtnSupport.Size = new System.Drawing.Size(194, 29);
            this.bbtnSupport.TabIndex = 7;
            this.bbtnSupport.Text = "Support";
            // 
            // bbtnCardManager
            // 
            this.bbtnCardManager.AllowFocus = false;
            this.bbtnCardManager.Appearance.Options.UseTextOptions = true;
            this.bbtnCardManager.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bbtnCardManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbtnCardManager.Image = global::SSTCP.Properties.Resources.EditBoards;
            this.bbtnCardManager.Location = new System.Drawing.Point(3, 138);
            this.bbtnCardManager.Name = "bbtnCardManager";
            this.bbtnCardManager.Size = new System.Drawing.Size(194, 29);
            this.bbtnCardManager.TabIndex = 8;
            this.bbtnCardManager.Text = "Card Manager";
            this.bbtnCardManager.Click += new System.EventHandler(this.bbtnCardManager_Click);
            // 
            // bbtnAddCard
            // 
            this.bbtnAddCard.AllowFocus = false;
            this.bbtnAddCard.Appearance.Options.UseTextOptions = true;
            this.bbtnAddCard.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.bbtnAddCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbtnAddCard.Image = global::SSTCP.Properties.Resources.NewCard;
            this.bbtnAddCard.Location = new System.Drawing.Point(3, 103);
            this.bbtnAddCard.Name = "bbtnAddCard";
            this.bbtnAddCard.Size = new System.Drawing.Size(194, 29);
            this.bbtnAddCard.TabIndex = 9;
            this.bbtnAddCard.Text = "Add New Card";
            this.bbtnAddCard.Click += new System.EventHandler(this.bbtnAddCard_Click);
            // 
            // wbNews
            // 
            this.wbNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbNews.Location = new System.Drawing.Point(203, 103);
            this.wbNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNews.Name = "wbNews";
            this.tableLayoutPanel1.SetRowSpan(this.wbNews, 5);
            this.wbNews.Size = new System.Drawing.Size(654, 306);
            this.wbNews.TabIndex = 10;
            // 
            // frmStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 555);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.ribbon);
            this.Name = "frmStartPage";
            this.Ribbon = this.ribbon;
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.frmStartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).EndInit();
            this.clientPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PanelControl clientPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.SimpleButton bbtnUpdates;
        private DevExpress.XtraEditors.SimpleButton bbtnSupport;
        private DevExpress.XtraEditors.SimpleButton bbtnCardManager;
        private DevExpress.XtraEditors.SimpleButton bbtnAddCard;
        private System.Windows.Forms.WebBrowser wbNews;
    }
}