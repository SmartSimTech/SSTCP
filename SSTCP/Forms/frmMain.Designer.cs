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
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.backstageViewClientControl3 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.richEditControl2 = new DevExpress.XtraRichEdit.RichEditControl();
            this.backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewTabItem3 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.backstageViewButtonItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.imgToolBarSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.bbtnStartPage = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.lblAppVersion = new DevExpress.XtraBars.BarStaticItem();
            this.lblRegisteredName = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem2 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.bbtnAddCard = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRegisterSoftware = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.lblFSUIPCConnection = new DevExpress.XtraBars.BarStaticItem();
            this.bbtnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnAdvancedSettings = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnLaunchTest = new DevExpress.XtraBars.BarButtonItem();
            this.imgToolBarLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.rpGeneral = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.applicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.skinDefaultLook = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.trmCheckUSB = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateTabIcons = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tmrCheckFSUIPC = new System.Windows.Forms.Timer(this.components);
            this.tmrEnumerateUSB = new System.Windows.Forms.Timer(this.components);
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.tmrCloseSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.backstageViewClientControl2.SuspendLayout();
            this.backstageViewClientControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBarSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBarLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.backstageViewControl1;
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
            this.bbtnAddCard,
            this.bbtnRegisterSoftware,
            this.barButtonItem9,
            this.lblFSUIPCConnection,
            this.bbtnHelp,
            this.bbtnAdvancedSettings,
            this.bbtnLaunchTest});
            this.ribbon.LargeImages = this.imgToolBarLarge;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpGeneral,
            this.ribbonPage2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(982, 166);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl2);
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl3);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem2);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem3);
            this.backstageViewControl1.Items.Add(this.backstageViewItemSeparator1);
            this.backstageViewControl1.Items.Add(this.backstageViewButtonItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(12, 165);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.Ribbon = this.ribbon;
            this.backstageViewControl1.SelectedTab = this.backstageViewTabItem2;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.Size = new System.Drawing.Size(637, 304);
            this.backstageViewControl1.TabIndex = 3;
            this.backstageViewControl1.Text = "backstageViewControl1";
            // 
            // backstageViewClientControl2
            // 
            this.backstageViewClientControl2.Controls.Add(this.richEditControl1);
            this.backstageViewClientControl2.Name = "backstageViewClientControl2";
            this.backstageViewClientControl2.TabIndex = 0;
            // 
            // richEditControl1
            // 
            this.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 0);
            this.richEditControl1.MenuManager = this.ribbon;
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.ReadOnly = true;
            this.richEditControl1.ShowCaretInReadOnly = false;
            this.richEditControl1.Size = new System.Drawing.Size(449, 304);
            this.richEditControl1.TabIndex = 0;
            // 
            // backstageViewClientControl3
            // 
            this.backstageViewClientControl3.Controls.Add(this.richEditControl2);
            this.backstageViewClientControl3.Name = "backstageViewClientControl3";
            this.backstageViewClientControl3.TabIndex = 1;
            // 
            // richEditControl2
            // 
            this.richEditControl2.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl2.Location = new System.Drawing.Point(0, 0);
            this.richEditControl2.MenuManager = this.ribbon;
            this.richEditControl2.Name = "richEditControl2";
            this.richEditControl2.ReadOnly = true;
            this.richEditControl2.ShowCaretInReadOnly = false;
            this.richEditControl2.Size = new System.Drawing.Size(449, 304);
            this.richEditControl2.TabIndex = 1;
            // 
            // backstageViewTabItem2
            // 
            this.backstageViewTabItem2.Caption = "About";
            this.backstageViewTabItem2.ContentControl = this.backstageViewClientControl2;
            this.backstageViewTabItem2.Name = "backstageViewTabItem2";
            this.backstageViewTabItem2.Selected = true;
            // 
            // backstageViewTabItem3
            // 
            this.backstageViewTabItem3.Caption = "Release Notes";
            this.backstageViewTabItem3.ContentControl = this.backstageViewClientControl3;
            this.backstageViewTabItem3.Name = "backstageViewTabItem3";
            this.backstageViewTabItem3.Selected = false;
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // backstageViewButtonItem1
            // 
            this.backstageViewButtonItem1.Caption = "Quit";
            this.backstageViewButtonItem1.Name = "backstageViewButtonItem1";
            this.backstageViewButtonItem1.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageViewButtonItem1_ItemClick);
            // 
            // imgToolBarSmall
            // 
            this.imgToolBarSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgToolBarSmall.ImageStream")));
            this.imgToolBarSmall.Images.SetKeyName(0, "16x16-Key.png");
            this.imgToolBarSmall.Images.SetKeyName(1, "16x16-Screen.png");
            this.imgToolBarSmall.Images.SetKeyName(2, "16x16-Travel.png");
            // 
            // bbtnStartPage
            // 
            this.bbtnStartPage.Caption = "Start Page";
            this.bbtnStartPage.Id = 1;
            this.bbtnStartPage.LargeImageIndex = 12;
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
            this.lblRegisteredName.ImageIndex = 0;
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
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "About";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.LargeImageIndex = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Check for Updates";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.LargeImageIndex = 1;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Quit";
            this.barButtonItem4.Id = 8;
            this.barButtonItem4.LargeImageIndex = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barMdiChildrenListItem2
            // 
            this.barMdiChildrenListItem2.Caption = "Window List";
            this.barMdiChildrenListItem2.Id = 9;
            this.barMdiChildrenListItem2.LargeImageIndex = 13;
            this.barMdiChildrenListItem2.LargeWidth = 85;
            this.barMdiChildrenListItem2.Name = "barMdiChildrenListItem2";
            // 
            // bbtnAddCard
            // 
            this.bbtnAddCard.Caption = "Add Card";
            this.bbtnAddCard.Id = 11;
            this.bbtnAddCard.LargeImageIndex = 14;
            this.bbtnAddCard.LargeWidth = 85;
            this.bbtnAddCard.Name = "bbtnAddCard";
            this.bbtnAddCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnAddCard_ItemClick);
            // 
            // bbtnRegisterSoftware
            // 
            this.bbtnRegisterSoftware.Caption = "Enter Serial Number";
            this.bbtnRegisterSoftware.Id = 12;
            this.bbtnRegisterSoftware.LargeImageIndex = 16;
            this.bbtnRegisterSoftware.LargeWidth = 85;
            this.bbtnRegisterSoftware.Name = "bbtnRegisterSoftware";
            this.bbtnRegisterSoftware.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRegisterSoftware_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Import from Template";
            this.barButtonItem9.Enabled = false;
            this.barButtonItem9.Id = 14;
            this.barButtonItem9.LargeImageIndex = 15;
            this.barButtonItem9.LargeWidth = 85;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // lblFSUIPCConnection
            // 
            this.lblFSUIPCConnection.Caption = "FSUIPC Connection: Disconnected";
            this.lblFSUIPCConnection.Id = 15;
            this.lblFSUIPCConnection.ImageIndex = 2;
            this.lblFSUIPCConnection.Name = "lblFSUIPCConnection";
            this.lblFSUIPCConnection.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bbtnHelp
            // 
            this.bbtnHelp.Caption = "Help";
            this.bbtnHelp.Id = 16;
            this.bbtnHelp.LargeImageIndex = 9;
            this.bbtnHelp.Name = "bbtnHelp";
            this.bbtnHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnHelp_ItemClick);
            // 
            // bbtnAdvancedSettings
            // 
            this.bbtnAdvancedSettings.Caption = "Advanced Settings";
            this.bbtnAdvancedSettings.Enabled = false;
            this.bbtnAdvancedSettings.Id = 18;
            this.bbtnAdvancedSettings.LargeImageIndex = 11;
            this.bbtnAdvancedSettings.LargeWidth = 85;
            this.bbtnAdvancedSettings.Name = "bbtnAdvancedSettings";
            this.bbtnAdvancedSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnAdvancedSettings_ItemClick);
            // 
            // bbtnLaunchTest
            // 
            this.bbtnLaunchTest.Caption = "Test Window";
            this.bbtnLaunchTest.Enabled = false;
            this.bbtnLaunchTest.Id = 19;
            this.bbtnLaunchTest.LargeImageIndex = 11;
            this.bbtnLaunchTest.Name = "bbtnLaunchTest";
            this.bbtnLaunchTest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnLaunchTest_ItemClick);
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
            this.imgToolBarLarge.Images.SetKeyName(10, "log.png");
            this.imgToolBarLarge.Images.SetKeyName(11, "Advanced.png");
            this.imgToolBarLarge.Images.SetKeyName(12, "32x32-Home.png");
            this.imgToolBarLarge.Images.SetKeyName(13, "32x32-Applications.png");
            this.imgToolBarLarge.Images.SetKeyName(14, "32x32-Plus.png");
            this.imgToolBarLarge.Images.SetKeyName(15, "32x32-Trackback.png");
            this.imgToolBarLarge.Images.SetKeyName(16, "32x32-Key.png");
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
            this.ribbonPageGroup4,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Settings";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnRegisterSoftware);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Registration";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bbtnAdvancedSettings);
            this.ribbonPageGroup6.ItemLinks.Add(this.bbtnLaunchTest);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Advanced";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lblAppVersion);
            this.ribbonStatusBar.ItemLinks.Add(this.lblRegisteredName);
            this.ribbonStatusBar.ItemLinks.Add(this.lblFSUIPCConnection);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 532);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(982, 39);
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
            // skinDefaultLook
            // 
            this.skinDefaultLook.LookAndFeel.SkinName = "Metropolis";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager.FloatOnDrag = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager.HeaderButtons = ((DevExpress.XtraTab.TabButtons)((DevExpress.XtraTab.TabButtons.Prev | DevExpress.XtraTab.TabButtons.Next)));
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
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tmrCheckFSUIPC
            // 
            this.tmrCheckFSUIPC.Interval = 5000;
            this.tmrCheckFSUIPC.Tick += new System.EventHandler(this.tmrCheckFSUIPC_Tick);
            // 
            // tmrEnumerateUSB
            // 
            this.tmrEnumerateUSB.Enabled = true;
            this.tmrEnumerateUSB.Interval = 2000;
            this.tmrEnumerateUSB.Tick += new System.EventHandler(this.tmrEnumerateUSB_Tick);
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "About Application";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = false;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.TabIndex = 0;
            // 
            // tmrCloseSplash
            // 
            this.tmrCloseSplash.Interval = 3000;
            this.tmrCloseSplash.Tick += new System.EventHandler(this.tmrCloseSplash_Tick);
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.backstageViewControl1);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.backstageViewClientControl2.ResumeLayout(false);
            this.backstageViewClientControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBarSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBarLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu;
        private System.Windows.Forms.Timer trmCheckUSB;
        private DevExpress.Utils.ImageCollection imgToolBarLarge;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem2;
        private DevExpress.XtraBars.BarButtonItem bbtnAddCard;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbtnRegisterSoftware;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private System.Windows.Forms.Timer tmrUpdateTabIcons;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.Timer tmrCheckFSUIPC;
        private DevExpress.XtraBars.BarStaticItem lblFSUIPCConnection;
        private DevExpress.Utils.ImageCollection imgToolBarSmall;
        private DevExpress.XtraBars.BarButtonItem bbtnHelp;
        private DevExpress.XtraBars.BarButtonItem bbtnAdvancedSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem backstageViewButtonItem1;
        private System.Windows.Forms.Timer tmrEnumerateUSB;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl3;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl2;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem3;
        private DevExpress.XtraBars.BarButtonItem bbtnLaunchTest;
        private System.Windows.Forms.Timer tmrCloseSplash;
    }
}