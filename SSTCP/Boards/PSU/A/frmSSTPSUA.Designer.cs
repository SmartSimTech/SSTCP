namespace SSTCP.Boards.PSU.A
{
    partial class frmSSTPSUA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSSTPSUA));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.chkDebugEnabled = new DevExpress.XtraEditors.CheckEdit();
            this.chkUSBConnected = new DevExpress.XtraEditors.CheckEdit();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.bbtnToggleDebugMode = new DevExpress.XtraNavBar.NavBarItem();
            this.bbtnFactoryReset = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.bbtnRefreshPSUStatus = new DevExpress.XtraNavBar.NavBarItem();
            this.bbtnTurnOnPSU = new DevExpress.XtraNavBar.NavBarItem();
            this.bbtnTurnOffPSU = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.bbtnExportDebugLog = new DevExpress.XtraNavBar.NavBarItem();
            this.bbtnScriptRefGuide = new DevExpress.XtraNavBar.NavBarItem();
            this.imgSideBar = new DevExpress.Utils.ImageCollection(this.components);
            this.tmrCheckUSB = new System.Windows.Forms.Timer(this.components);
            this.tmrCheckFormDetails = new System.Windows.Forms.Timer(this.components);
            this.imgLogIcons = new DevExpress.Utils.ImageCollection(this.components);
            this.gcDebugLog = new DevExpress.XtraEditors.PanelControl();
            this.lbDebugLog = new DevExpress.XtraEditors.ImageListBoxControl();
            this.gcCardSettings = new DevExpress.XtraEditors.PanelControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.xpCollectionCardInfo = new DevExpress.Xpo.XPCollection();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow6 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.tmrRequestPSUStatus = new System.Windows.Forms.Timer(this.components);
            this.gcCardConfiguration = new DevExpress.XtraEditors.PanelControl();
            this.vGridControl2 = new DevExpress.XtraVerticalGrid.VGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDebugEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUSBConnected.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDebugLog)).BeginInit();
            this.gcDebugLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbDebugLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCardSettings)).BeginInit();
            this.gcCardSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCardInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCardConfiguration)).BeginInit();
            this.gcCardConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(1091, 50);
            // 
            // chkDebugEnabled
            // 
            this.chkDebugEnabled.Location = new System.Drawing.Point(211, 81);
            this.chkDebugEnabled.Name = "chkDebugEnabled";
            this.chkDebugEnabled.Properties.Caption = "Debug Enabled";
            this.chkDebugEnabled.Size = new System.Drawing.Size(97, 19);
            this.chkDebugEnabled.TabIndex = 21;
            this.chkDebugEnabled.Visible = false;
            // 
            // chkUSBConnected
            // 
            this.chkUSBConnected.Location = new System.Drawing.Point(211, 56);
            this.chkUSBConnected.MenuManager = this.ribbon;
            this.chkUSBConnected.Name = "chkUSBConnected";
            this.chkUSBConnected.Properties.Caption = "USB Connected";
            this.chkUSBConnected.Size = new System.Drawing.Size(97, 19);
            this.chkUSBConnected.TabIndex = 20;
            this.chkUSBConnected.Visible = false;
            this.chkUSBConnected.CheckedChanged += new System.EventHandler(this.chkUSBConnected_CheckedChanged);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup2;
            this.navBarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.bbtnExportDebugLog,
            this.bbtnTurnOnPSU,
            this.bbtnTurnOffPSU,
            this.bbtnRefreshPSUStatus,
            this.bbtnToggleDebugMode,
            this.bbtnFactoryReset,
            this.navBarItem8,
            this.navBarItem9,
            this.bbtnScriptRefGuide});
            this.navBarControl1.Location = new System.Drawing.Point(0, 50);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.NavigationPaneMaxVisibleGroups = 4;
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 200;
            this.navBarControl1.OptionsNavPane.ShowExpandButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.OptionsNavPane.ShowSplitter = false;
            this.navBarControl1.Size = new System.Drawing.Size(205, 386);
            this.navBarControl1.SmallImages = this.imgSideBar;
            this.navBarControl1.TabIndex = 22;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            this.navBarControl1.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl1_ActiveGroupChanged);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Card Settings";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbtnToggleDebugMode),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbtnFactoryReset),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9)});
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImageIndex = 0;
            // 
            // bbtnToggleDebugMode
            // 
            this.bbtnToggleDebugMode.Caption = "Toggle Debug Mode";
            this.bbtnToggleDebugMode.Name = "bbtnToggleDebugMode";
            this.bbtnToggleDebugMode.SmallImageIndex = 16;
            this.bbtnToggleDebugMode.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbtnToggleDebugMode_LinkClicked);
            // 
            // bbtnFactoryReset
            // 
            this.bbtnFactoryReset.Caption = "Factory Reset";
            this.bbtnFactoryReset.Name = "bbtnFactoryReset";
            this.bbtnFactoryReset.SmallImageIndex = 11;
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Export Configuration";
            this.navBarItem8.Enabled = false;
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.SmallImageIndex = 14;
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Import Configuration";
            this.navBarItem9.Enabled = false;
            this.navBarItem9.Name = "navBarItem9";
            this.navBarItem9.SmallImageIndex = 13;
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Power Supply Settings";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbtnRefreshPSUStatus),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbtnTurnOnPSU),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbtnTurnOffPSU)});
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.SmallImageIndex = 1;
            // 
            // bbtnRefreshPSUStatus
            // 
            this.bbtnRefreshPSUStatus.Caption = "Refresh Power Supply Status";
            this.bbtnRefreshPSUStatus.Name = "bbtnRefreshPSUStatus";
            this.bbtnRefreshPSUStatus.SmallImageIndex = 15;
            // 
            // bbtnTurnOnPSU
            // 
            this.bbtnTurnOnPSU.Caption = "Turn On Power Supply";
            this.bbtnTurnOnPSU.Name = "bbtnTurnOnPSU";
            this.bbtnTurnOnPSU.SmallImageIndex = 17;
            this.bbtnTurnOnPSU.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbtnTurnOnPSU_LinkClicked);
            // 
            // bbtnTurnOffPSU
            // 
            this.bbtnTurnOffPSU.Caption = "Turn Off Power Supply";
            this.bbtnTurnOffPSU.Name = "bbtnTurnOffPSU";
            this.bbtnTurnOffPSU.SmallImageIndex = 16;
            this.bbtnTurnOffPSU.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbtnTurnOffPSU_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Card Log";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbtnExportDebugLog)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImageIndex = 2;
            // 
            // bbtnExportDebugLog
            // 
            this.bbtnExportDebugLog.Caption = "Export Debug Log";
            this.bbtnExportDebugLog.Name = "bbtnExportDebugLog";
            this.bbtnExportDebugLog.SmallImageIndex = 8;
            // 
            // bbtnScriptRefGuide
            // 
            this.bbtnScriptRefGuide.Caption = "Script Reference Guide";
            this.bbtnScriptRefGuide.Name = "bbtnScriptRefGuide";
            this.bbtnScriptRefGuide.SmallImageIndex = 18;
            // 
            // imgSideBar
            // 
            this.imgSideBar.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgSideBar.ImageStream")));
            this.imgSideBar.Images.SetKeyName(0, "16x16-Gear.png");
            this.imgSideBar.Images.SetKeyName(1, "16x16-Go Out.png");
            this.imgSideBar.Images.SetKeyName(2, "16x16-Database.png");
            this.imgSideBar.Images.SetKeyName(3, "16x16-Write Message.png");
            this.imgSideBar.Images.SetKeyName(4, "16x16-Minus.png");
            this.imgSideBar.Images.SetKeyName(5, "16x16-Plus.png");
            this.imgSideBar.Images.SetKeyName(6, "16x16-Star.png");
            this.imgSideBar.Images.SetKeyName(7, "16x16-Start.png");
            this.imgSideBar.Images.SetKeyName(8, "16x16-Save.png");
            this.imgSideBar.Images.SetKeyName(9, "16x16-Dots Down.png");
            this.imgSideBar.Images.SetKeyName(10, "16x16-Dots Up.png");
            this.imgSideBar.Images.SetKeyName(11, "16x16-Loop.png");
            this.imgSideBar.Images.SetKeyName(12, "16x16-Search.png");
            this.imgSideBar.Images.SetKeyName(13, "16x16-Trackback.png");
            this.imgSideBar.Images.SetKeyName(14, "16x16-Trackback180.png");
            this.imgSideBar.Images.SetKeyName(15, "16x16-Refresh.png");
            this.imgSideBar.Images.SetKeyName(16, "16x16-Tool.png");
            this.imgSideBar.Images.SetKeyName(17, "16x16-Direction Diag1.png");
            this.imgSideBar.Images.SetKeyName(18, "16x16-Question.png");
            // 
            // tmrCheckUSB
            // 
            this.tmrCheckUSB.Interval = 700;
            this.tmrCheckUSB.Tick += new System.EventHandler(this.tmrCheckUSB_Tick);
            // 
            // tmrCheckFormDetails
            // 
            this.tmrCheckFormDetails.Interval = 700;
            this.tmrCheckFormDetails.Tick += new System.EventHandler(this.tmrCheckFormDetails_Tick);
            // 
            // imgLogIcons
            // 
            this.imgLogIcons.ImageSize = new System.Drawing.Size(12, 12);
            this.imgLogIcons.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgLogIcons.ImageStream")));
            this.imgLogIcons.Images.SetKeyName(0, "info.png");
            this.imgLogIcons.Images.SetKeyName(1, "warning.png");
            this.imgLogIcons.Images.SetKeyName(2, "error.png");
            // 
            // gcDebugLog
            // 
            this.gcDebugLog.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gcDebugLog.Controls.Add(this.lbDebugLog);
            this.gcDebugLog.Location = new System.Drawing.Point(213, 139);
            this.gcDebugLog.Name = "gcDebugLog";
            this.gcDebugLog.Size = new System.Drawing.Size(200, 100);
            this.gcDebugLog.TabIndex = 24;
            // 
            // lbDebugLog
            // 
            this.lbDebugLog.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbDebugLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDebugLog.ImageList = this.imgLogIcons;
            this.lbDebugLog.Location = new System.Drawing.Point(0, 0);
            this.lbDebugLog.Margin = new System.Windows.Forms.Padding(0);
            this.lbDebugLog.Name = "lbDebugLog";
            this.lbDebugLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDebugLog.Size = new System.Drawing.Size(200, 100);
            this.lbDebugLog.TabIndex = 2;
            // 
            // gcCardSettings
            // 
            this.gcCardSettings.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gcCardSettings.Controls.Add(this.vGridControl1);
            this.gcCardSettings.Location = new System.Drawing.Point(419, 139);
            this.gcCardSettings.Name = "gcCardSettings";
            this.gcCardSettings.Size = new System.Drawing.Size(200, 100);
            this.gcCardSettings.TabIndex = 25;
            // 
            // vGridControl1
            // 
            this.vGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl1.DataSource = this.xpCollectionCardInfo;
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(0, 0);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsView.AutoScaleBands = true;
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryRow1,
            this.categoryRow2});
            this.vGridControl1.Size = new System.Drawing.Size(200, 100);
            this.vGridControl1.TabIndex = 0;
            // 
            // xpCollectionCardInfo
            // 
            this.xpCollectionCardInfo.ObjectType = typeof(SSTCP.Database.Cards);
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // categoryRow1
            // 
            this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow1,
            this.editorRow2,
            this.editorRow3,
            this.editorRow6});
            this.categoryRow1.Name = "categoryRow1";
            this.categoryRow1.Properties.Caption = "Card Details";
            // 
            // editorRow1
            // 
            this.editorRow1.Name = "editorRow1";
            this.editorRow1.Properties.Caption = "Card Model Number";
            this.editorRow1.Properties.FieldName = "CardModel";
            this.editorRow1.Properties.ReadOnly = true;
            // 
            // editorRow2
            // 
            this.editorRow2.Appearance.Options.UseTextOptions = true;
            this.editorRow2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.editorRow2.Name = "editorRow2";
            this.editorRow2.Properties.Caption = "Card Serial Number";
            this.editorRow2.Properties.FieldName = "CardSerialNumber";
            this.editorRow2.Properties.ReadOnly = true;
            // 
            // editorRow3
            // 
            this.editorRow3.Name = "editorRow3";
            this.editorRow3.Properties.Caption = "Card Firmware Version";
            this.editorRow3.Properties.ReadOnly = true;
            // 
            // editorRow6
            // 
            this.editorRow6.Name = "editorRow6";
            this.editorRow6.Properties.Caption = "Card Revision";
            this.editorRow6.Properties.FieldName = "CardRevision";
            this.editorRow6.Properties.ReadOnly = true;
            // 
            // categoryRow2
            // 
            this.categoryRow2.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow4,
            this.editorRow5});
            this.categoryRow2.Name = "categoryRow2";
            this.categoryRow2.Properties.Caption = "Card Properties";
            // 
            // editorRow4
            // 
            this.editorRow4.Name = "editorRow4";
            this.editorRow4.Properties.Caption = "Card Name";
            this.editorRow4.Properties.FieldName = "CardName";
            // 
            // editorRow5
            // 
            this.editorRow5.Height = 100;
            this.editorRow5.Name = "editorRow5";
            this.editorRow5.Properties.Caption = "Card Description";
            this.editorRow5.Properties.FieldName = "CardDescription";
            this.editorRow5.Properties.RowEdit = this.repositoryItemMemoEdit1;
            // 
            // tmrRequestPSUStatus
            // 
            this.tmrRequestPSUStatus.Interval = 500;
            this.tmrRequestPSUStatus.Tick += new System.EventHandler(this.tmrRequestPSUStatus_Tick);
            // 
            // gcCardConfiguration
            // 
            this.gcCardConfiguration.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gcCardConfiguration.Controls.Add(this.vGridControl2);
            this.gcCardConfiguration.Location = new System.Drawing.Point(625, 139);
            this.gcCardConfiguration.Name = "gcCardConfiguration";
            this.gcCardConfiguration.Size = new System.Drawing.Size(200, 100);
            this.gcCardConfiguration.TabIndex = 27;
            // 
            // vGridControl2
            // 
            this.vGridControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl2.Location = new System.Drawing.Point(0, 0);
            this.vGridControl2.Name = "vGridControl2";
            this.vGridControl2.Size = new System.Drawing.Size(200, 100);
            this.vGridControl2.TabIndex = 0;
            // 
            // frmSSTPSUA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 436);
            this.Controls.Add(this.gcCardConfiguration);
            this.Controls.Add(this.gcCardSettings);
            this.Controls.Add(this.gcDebugLog);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.chkDebugEnabled);
            this.Controls.Add(this.chkUSBConnected);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSSTPSUA";
            this.Ribbon = this.ribbon;
            this.Text = "frmSSTPSUA";
            this.Load += new System.EventHandler(this.frmSSTPSUA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDebugEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUSBConnected.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDebugLog)).EndInit();
            this.gcDebugLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbDebugLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCardSettings)).EndInit();
            this.gcCardSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCardInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCardConfiguration)).EndInit();
            this.gcCardConfiguration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.CheckEdit chkDebugEnabled;
        private DevExpress.XtraEditors.CheckEdit chkUSBConnected;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem bbtnToggleDebugMode;
        private DevExpress.XtraNavBar.NavBarItem bbtnFactoryReset;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem bbtnRefreshPSUStatus;
        private DevExpress.XtraNavBar.NavBarItem bbtnTurnOnPSU;
        private DevExpress.XtraNavBar.NavBarItem bbtnTurnOffPSU;
        private DevExpress.XtraNavBar.NavBarItem bbtnScriptRefGuide;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem bbtnExportDebugLog;
        private System.Windows.Forms.Timer tmrCheckUSB;
        private System.Windows.Forms.Timer tmrCheckFormDetails;
        private DevExpress.Utils.ImageCollection imgSideBar;
        private DevExpress.Utils.ImageCollection imgLogIcons;
        private DevExpress.XtraEditors.PanelControl gcDebugLog;
        private DevExpress.XtraEditors.ImageListBoxControl lbDebugLog;
        private DevExpress.XtraEditors.PanelControl gcCardSettings;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow6;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow5;
        private DevExpress.Xpo.XPCollection xpCollectionCardInfo;
        private System.Windows.Forms.Timer tmrRequestPSUStatus;
        private DevExpress.XtraEditors.PanelControl gcCardConfiguration;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl2;
    }
}