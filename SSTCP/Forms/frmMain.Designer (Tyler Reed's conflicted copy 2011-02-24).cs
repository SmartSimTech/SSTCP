namespace SSTCP.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.imgToolBarSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.bbtnStartPage = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.lblAppVersion = new DevExpress.XtraBars.BarStaticItem();
            this.lblRegisteredName = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem2 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.bbtnManageCards = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnAddCard = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.lblFSUIPCConnection = new DevExpress.XtraBars.BarStaticItem();
            this.imgToolBarLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.rpGeneral = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.skinDefaultLook = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.trmCheckUSB = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateTabIcons = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tmrCheckFSUIPC = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBarSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBarLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu;
            this.ribbon.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Images = this.imgToolBarSmall;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbtnStartPage,
            this.barMdiChildrenListItem1,
            this.lblAppVersion,
            this.lblRegisteredName,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barMdiChildrenListItem2,
            this.bbtnManageCards,
            this.bbtnAddCard,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.lblFSUIPCConnection,
            this.bbtnHelp});
            this.ribbon.LargeImages = this.imgToolBarLarge;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpGeneral,
            this.ribbonPage2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.SelectedPage = this.rpGeneral;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1006, 145);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // applicationMenu
            // 
            this.applicationMenu.ItemLinks.Add(this.barButtonItem2);
            this.applicationMenu.ItemLinks.Add(this.barButtonItem3);
            this.applicationMenu.ItemLinks.Add(this.bbtnHelp);
            this.applicationMenu.ItemLinks.Add(this.barButtonItem4, true);
            this.applicationMenu.Name = "applicationMenu";
            this.applicationMenu.Ribbon = this.ribbon;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "About";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.LargeImageIndex = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Check for Updates";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.LargeImageIndex = 1;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // bbtnHelp
            // 
            this.bbtnHelp.Caption = "Help";
            this.bbtnHelp.Id = 16;
            this.bbtnHelp.LargeImageIndex = 9;
            this.bbtnHelp.Name = "bbtnHelp";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Quit";
            this.barButtonItem4.Id = 8;
            this.barButtonItem4.LargeImageIndex = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // imgToolBarSmall
            // 
            this.imgToolBarSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgToolBarSmall.ImageStream")));
            this.imgToolBarSmall.Images.SetKeyName(0, "flag.png");
            this.imgToolBarSmall.Images.SetKeyName(1, "monitor.png");
            this.imgToolBarSmall.Images.SetKeyName(2, "registeredto.png");
            // 
            // bbtnStartPage
            // 
            this.bbtnStartPage.Caption = "Start Page";
            this.bbtnStartPage.Id = 1;
            this.bbtnStartPage.LargeImageIndex = 0;
            this.bbtnStartPage.LargeWidth = 85;
            this.bbtnStartPage.Name = "bbtnStartPage";
            this.bbtnStartPage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 2;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblAppVersion.Caption = "{Application Version}";
            this.lblAppVersion.Id = 3;
            this.lblAppVersion.ImageIndex = 1;
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblRegisteredName
            // 
            this.lblRegisteredName.Caption = "Registered To: {Name}";
            this.lblRegisteredName.Id = 4;
            this.lblRegisteredName.ImageIndex = 2;
            this.lblRegisteredName.Name = "lblRegisteredName";
            this.lblRegisteredName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Check for Updates";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.LargeImageIndex = 1;
            this.barButtonItem1.LargeWidth = 85;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barMdiChildrenListItem2
            // 
            this.barMdiChildrenListItem2.Caption = "Window List";
            this.barMdiChildrenListItem2.Id = 9;
            this.barMdiChildrenListItem2.LargeImageIndex = 2;
            this.barMdiChildrenListItem2.LargeWidth = 85;
            this.barMdiChildrenListItem2.Name = "barMdiChildrenListItem2";
            // 
            // bbtnManageCards
            // 
            this.bbtnManageCards.Caption = "Manage Cards";
            this.bbtnManageCards.Id = 10;
            this.bbtnManageCards.LargeImageIndex = 5;
            this.bbtnManageCards.LargeWidth = 85;
            this.bbtnManageCards.Name = "bbtnManageCards";
            this.bbtnManageCards.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnManageCards_ItemClick);
            // 
            // bbtnAddCard
            // 
            this.bbtnAddCard.Caption = "Add Card";
            this.bbtnAddCard.Id = 11;
            this.bbtnAddCard.LargeImageIndex = 6;
            this.bbtnAddCard.LargeWidth = 85;
            this.bbtnAddCard.Name = "bbtnAddCard";
            this.bbtnAddCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnAddCard_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Enter Serial Number";
            this.barButtonItem7.Enabled = false;
            this.barButtonItem7.Id = 12;
            this.barButtonItem7.LargeImageIndex = 7;
            this.barButtonItem7.LargeWidth = 85;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Get Serial Number";
            this.barButtonItem8.Enabled = false;
            this.barButtonItem8.Id = 13;
            this.barButtonItem8.LargeImageIndex = 8;
            this.barButtonItem8.LargeWidth = 85;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Import from Template";
            this.barButtonItem9.Enabled = false;
            this.barButtonItem9.Id = 14;
            this.barButtonItem9.LargeImageIndex = 6;
            this.barButtonItem9.LargeWidth = 85;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // lblFSUIPCConnection
            // 
            this.lblFSUIPCConnection.Caption = "FSUIPC Connection: Disconnected";
            this.lblFSUIPCConnection.Id = 15;
            this.lblFSUIPCConnection.ImageIndex = 0;
            this.lblFSUIPCConnection.Name = "lblFSUIPCConnection";
            this.lblFSUIPCConnection.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // imgToolBarLarge
            // 
            this.imgToolBarLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imgToolBarLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgToolBarLarge.ImageStream")));
            this.imgToolBarLarge.Images.SetKeyName(0, "startpage.png");
            this.imgToolBarLarge.Images.SetKeyName(1, "checkforupdates.png");
            this.imgToolBarLarge.Images.SetKeyName(2, "windows.png");
            this.imgToolBarLarge.Images.SetKeyName(3, "about.png");
            this.imgToolBarLarge.Images.SetKeyName(4, "quit.png");
            this.imgToolBarLarge.Images.SetKeyName(5, "editcards.png");
            this.imgToolBarLarge.Images.SetKeyName(6, "addcard.png");
            this.imgToolBarLarge.Images.SetKeyName(7, "enterserial.png");
            this.imgToolBarLarge.Images.SetKeyName(8, "getserial.png");
            this.imgToolBarLarge.Images.SetKeyName(9, "help.png");
            // 
            // rpGeneral
            // 
            this.rpGeneral.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.rpGeneral.Name = "rpGeneral";
            this.rpGeneral.Text = "General";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnStartPage);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnManageCards);
            this.ribbonPageGroup1.ItemLinks.Add(this.barMdiChildrenListItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Window";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnAddCard);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Tools";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Settings";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Application";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Registration";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lblAppVersion);
            this.ribbonStatusBar.ItemLinks.Add(this.lblRegisteredName);
            this.ribbonStatusBar.ItemLinks.Add(this.lblFSUIPCConnection);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 540);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1006, 31);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager.FloatOnDrag = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager.HeaderButtons = ((DevExpress.XtraTab.TabButtons)(((DevExpress.XtraTab.TabButtons.Prev | DevExpress.XtraTab.TabButtons.Next)
                        | DevExpress.XtraTab.TabButtons.Close)));
            this.xtraTabbedMdiManager.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Always;
            this.xtraTabbedMdiManager.MdiParent = this;
            this.xtraTabbedMdiManager.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.Windows;
            this.xtraTabbedMdiManager.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager_PageAdded);
            // 
            // trmCheckUSB
            // 
            this.trmCheckUSB.Enabled = true;
            this.trmCheckUSB.Tick += new System.EventHandler(this.trmCheckUSB_Tick);
            // 
            // tmrUpdateTabIcons
            // 
            this.tmrUpdateTabIcons.Enabled = true;
            this.tmrUpdateTabIcons.Interval = 1000;
            this.tmrUpdateTabIcons.Tick += new System.EventHandler(this.tmrUpdateTabIcons_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Smart Sim Tech Control Panel";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tmrCheckFSUIPC
            // 
            this.tmrCheckFSUIPC.Enabled = true;
            this.tmrCheckFSUIPC.Interval = 1000;
            this.tmrCheckFSUIPC.Tick += new System.EventHandler(this.tmrCheckFSUIPC_Tick);
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 571);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Smart Sim Tech Control Panel";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmMain_HelpButtonClicked);
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBarSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBarLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpGeneral;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel skinDefaultLook;
        private DevExpress.XtraBars.BarButtonItem bbtnStartPage;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarStaticItem lblAppVersion;
        private DevExpress.XtraBars.BarStaticItem lblRegisteredName;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu;
        private System.Windows.Forms.Timer trmCheckUSB;
        private DevExpress.Utils.ImageCollection imgToolBarLarge;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem2;
        private DevExpress.XtraBars.BarButtonItem bbtnManageCards;
        private DevExpress.XtraBars.BarButtonItem bbtnAddCard;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private System.Windows.Forms.Timer tmrUpdateTabIcons;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.Timer tmrCheckFSUIPC;
        private DevExpress.XtraBars.BarStaticItem lblFSUIPCConnection;
        private DevExpress.Utils.ImageCollection imgToolBarSmall;
        private DevExpress.XtraBars.BarButtonItem bbtnHelp;
    }
}