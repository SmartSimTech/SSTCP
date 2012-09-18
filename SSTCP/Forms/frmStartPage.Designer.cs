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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartPage));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imgToolBarLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.imgButtonImages = new DevExpress.Utils.ImageCollection(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.bbtnDeleteSelectedCard = new DevExpress.XtraNavBar.NavBarItem();
            this.bbtnEditSelectedCard = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.bbtnRefreshUSBList = new DevExpress.XtraNavBar.NavBarItem();
            this.bbtnExportUSBList = new DevExpress.XtraNavBar.NavBarItem();
            this.imgSideBar = new DevExpress.Utils.ImageCollection(this.components);
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.gcCards = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardRevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardConnection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcSupport = new DevExpress.XtraEditors.PanelControl();
            this.gcUSB = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tmrRefreshCards = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBarLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButtonImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCards)).BeginInit();
            this.gcCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUSB)).BeginInit();
            this.gcUSB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
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
            this.ribbon.LargeImages = this.imgToolBarLarge;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(860, 71);
            // 
            // imgToolBarLarge
            // 
            this.imgToolBarLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imgToolBarLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgToolBarLarge.ImageStream")));
            this.imgToolBarLarge.Images.SetKeyName(0, "32x32-Standby.png");
            this.imgToolBarLarge.Images.SetKeyName(1, "32x32-Question.png");
            // 
            // imgButtonImages
            // 
            this.imgButtonImages.ImageSize = new System.Drawing.Size(24, 24);
            this.imgButtonImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgButtonImages.ImageStream")));
            this.imgButtonImages.Images.SetKeyName(0, "Add Card.png");
            this.imgButtonImages.Images.SetKeyName(1, "Check for Updates.png");
            this.imgButtonImages.Images.SetKeyName(2, "Edit Card.png");
            this.imgButtonImages.Images.SetKeyName(3, "Request Support.png");
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup3;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup3,
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem3,
            this.navBarItem4,
            this.bbtnRefreshUSBList,
            this.bbtnExportUSBList,
            this.bbtnDeleteSelectedCard,
            this.bbtnEditSelectedCard});
            this.navBarControl1.Location = new System.Drawing.Point(0, 71);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.NavigationPaneMaxVisibleGroups = 4;
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 205;
            this.navBarControl1.OptionsNavPane.ShowExpandButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.OptionsNavPane.ShowSplitter = false;
            this.navBarControl1.Size = new System.Drawing.Size(205, 484);
            this.navBarControl1.SmallImages = this.imgSideBar;
            this.navBarControl1.TabIndex = 5;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            this.navBarControl1.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl1_ActiveGroupChanged);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Cards";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbtnDeleteSelectedCard),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbtnEditSelectedCard)});
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.SmallImageIndex = 4;
            // 
            // bbtnDeleteSelectedCard
            // 
            this.bbtnDeleteSelectedCard.Caption = "Delete Selected Card";
            this.bbtnDeleteSelectedCard.Name = "bbtnDeleteSelectedCard";
            this.bbtnDeleteSelectedCard.SmallImageIndex = 10;
            this.bbtnDeleteSelectedCard.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbtnDeleteSelectedCard_LinkClicked);
            // 
            // bbtnEditSelectedCard
            // 
            this.bbtnEditSelectedCard.Caption = "Edit Selected Card";
            this.bbtnEditSelectedCard.Name = "bbtnEditSelectedCard";
            this.bbtnEditSelectedCard.SmallImageIndex = 9;
            this.bbtnEditSelectedCard.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbtnEditSelectedCard_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Support";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImageIndex = 3;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Product Support";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImageIndex = 3;
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Check for Updates";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImageIndex = 2;
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "USB Browser";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbtnRefreshUSBList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bbtnExportUSBList)});
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImageIndex = 6;
            // 
            // bbtnRefreshUSBList
            // 
            this.bbtnRefreshUSBList.Caption = "Refresh List";
            this.bbtnRefreshUSBList.Name = "bbtnRefreshUSBList";
            this.bbtnRefreshUSBList.SmallImageIndex = 7;
            this.bbtnRefreshUSBList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbtnRefreshUSBList_LinkClicked);
            // 
            // bbtnExportUSBList
            // 
            this.bbtnExportUSBList.Caption = "Export List";
            this.bbtnExportUSBList.Name = "bbtnExportUSBList";
            this.bbtnExportUSBList.SmallImageIndex = 8;
            this.bbtnExportUSBList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bbtnExportUSBList_LinkClicked);
            // 
            // imgSideBar
            // 
            this.imgSideBar.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgSideBar.ImageStream")));
            this.imgSideBar.Images.SetKeyName(0, "16x16-Minus.png");
            this.imgSideBar.Images.SetKeyName(1, "16x16-Plus.png");
            this.imgSideBar.Images.SetKeyName(2, "16x16-Download.png");
            this.imgSideBar.Images.SetKeyName(3, "16x16-Question.png");
            this.imgSideBar.Images.SetKeyName(4, "16x16-Puzzle.png");
            this.imgSideBar.Images.SetKeyName(5, "16x16-Applications.png");
            this.imgSideBar.Images.SetKeyName(6, "16x16-Sitemap.png");
            this.imgSideBar.Images.SetKeyName(7, "16x16-Refresh.png");
            this.imgSideBar.Images.SetKeyName(8, "16x16-Save.png");
            this.imgSideBar.Images.SetKeyName(9, "16x16-Write Message.png");
            this.imgSideBar.Images.SetKeyName(10, "16x16-Trash.png");
            // 
            // xpCollection1
            // 
            this.xpCollection1.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowRemove;
            this.xpCollection1.ObjectType = typeof(SSTCP.Database.Cards);
            this.xpCollection1.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[CardModel]", DevExpress.Xpo.DB.SortingDirection.Ascending),
            new DevExpress.Xpo.SortProperty("[CardRevision]", DevExpress.Xpo.DB.SortingDirection.Ascending),
            new DevExpress.Xpo.SortProperty("[CardSerialNumber]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            // 
            // gcCards
            // 
            this.gcCards.Controls.Add(this.gridControl1);
            this.gcCards.Location = new System.Drawing.Point(530, 86);
            this.gcCards.Name = "gcCards";
            this.gcCards.Size = new System.Drawing.Size(313, 187);
            this.gcCards.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollection1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(309, 183);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colCardModel,
            this.colCardRevision,
            this.colCardSerialNumber,
            this.colCardName,
            this.colCardDescription,
            this.colCardConnection});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCardModel, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            // 
            // colCardModel
            // 
            this.colCardModel.FieldName = "CardModel";
            this.colCardModel.Name = "colCardModel";
            this.colCardModel.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colCardModel.Visible = true;
            this.colCardModel.VisibleIndex = 0;
            // 
            // colCardRevision
            // 
            this.colCardRevision.FieldName = "CardRevision";
            this.colCardRevision.Name = "colCardRevision";
            this.colCardRevision.Visible = true;
            this.colCardRevision.VisibleIndex = 1;
            // 
            // colCardSerialNumber
            // 
            this.colCardSerialNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colCardSerialNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCardSerialNumber.FieldName = "CardSerialNumber";
            this.colCardSerialNumber.Name = "colCardSerialNumber";
            this.colCardSerialNumber.Visible = true;
            this.colCardSerialNumber.VisibleIndex = 2;
            // 
            // colCardName
            // 
            this.colCardName.AppearanceCell.Options.UseTextOptions = true;
            this.colCardName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 3;
            // 
            // colCardDescription
            // 
            this.colCardDescription.FieldName = "CardDescription";
            this.colCardDescription.Name = "colCardDescription";
            // 
            // colCardConnection
            // 
            this.colCardConnection.Caption = "Connection Status";
            this.colCardConnection.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colCardConnection.FieldName = "CardConnected";
            this.colCardConnection.Name = "colCardConnection";
            this.colCardConnection.Visible = true;
            this.colCardConnection.VisibleIndex = 4;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.PictureChecked = global::SSTCP.Properties.Resources._16x16_GreenApplication;
            this.repositoryItemCheckEdit1.PictureUnchecked = global::SSTCP.Properties.Resources._16x16_RedApplication;
            // 
            // gcSupport
            // 
            this.gcSupport.Location = new System.Drawing.Point(228, 304);
            this.gcSupport.Name = "gcSupport";
            this.gcSupport.Size = new System.Drawing.Size(313, 191);
            this.gcSupport.TabIndex = 11;
            // 
            // gcUSB
            // 
            this.gcUSB.Controls.Add(this.gridControl2);
            this.gcUSB.Location = new System.Drawing.Point(530, 249);
            this.gcUSB.Name = "gcUSB";
            this.gcUSB.Size = new System.Drawing.Size(305, 207);
            this.gcUSB.TabIndex = 13;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 2);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.MenuManager = this.ribbon;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gridControl2.Size = new System.Drawing.Size(301, 203);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.gridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsCustomization.AllowColumnMoving = false;
            this.gridView2.OptionsCustomization.AllowColumnResizing = false;
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Serial";
            this.gridColumn2.FieldName = "serial";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 50;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "connected";
            this.gridColumn3.FieldName = "connected";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "deviceid";
            this.gridColumn4.FieldName = "deviceid";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Card Type";
            this.gridColumn5.FieldName = "cardtype";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 138;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.PictureChecked = global::SSTCP.Properties.Resources._16x16_GreenApplication;
            this.repositoryItemCheckEdit2.PictureUnchecked = global::SSTCP.Properties.Resources._16x16_RedApplication;
            // 
            // tmrRefreshCards
            // 
            this.tmrRefreshCards.Enabled = true;
            this.tmrRefreshCards.Interval = 500;
            this.tmrRefreshCards.Tick += new System.EventHandler(this.tmrRefreshCards_Tick);
            // 
            // frmStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 555);
            this.Controls.Add(this.gcUSB);
            this.Controls.Add(this.gcSupport);
            this.Controls.Add(this.gcCards);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStartPage";
            this.Ribbon = this.ribbon;
            this.Text = "Start Page";
            this.Activated += new System.EventHandler(this.frmStartPage_Activated);
            this.Load += new System.EventHandler(this.frmStartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBarLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButtonImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCards)).EndInit();
            this.gcCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUSB)).EndInit();
            this.gcUSB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.Utils.ImageCollection imgButtonImages;
        private DevExpress.Utils.ImageCollection imgToolBarLarge;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.Utils.ImageCollection imgSideBar;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.XtraEditors.PanelControl gcCards;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colCardModel;
        private DevExpress.XtraGrid.Columns.GridColumn colCardRevision;
        private DevExpress.XtraGrid.Columns.GridColumn colCardSerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colCardDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCardConnection;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl gcSupport;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraEditors.PanelControl gcUSB;
        private DevExpress.XtraNavBar.NavBarItem bbtnRefreshUSBList;
        private DevExpress.XtraNavBar.NavBarItem bbtnExportUSBList;
        private DevExpress.XtraNavBar.NavBarItem bbtnDeleteSelectedCard;
        private DevExpress.XtraNavBar.NavBarItem bbtnEditSelectedCard;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Timer tmrRefreshCards;
    }
}