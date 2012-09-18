namespace SSTCP.Forms
{
    partial class frmCards
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
            this.xpCollection1 = new DevExpress.Xpo.XPCollection();
            this.tmrReload = new System.Windows.Forms.Timer(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnNewCard = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDeleteCard = new DevExpress.XtraBars.BarButtonItem();
            this.rpGeneral = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardRevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clientPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).BeginInit();
            this.clientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpCollection1
            // 
            this.xpCollection1.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowRemove;
            this.xpCollection1.ObjectType = typeof(SSTCP.Database.Cards);
            // 
            // tmrReload
            // 
            this.tmrReload.Enabled = true;
            this.tmrReload.Interval = 500;
            this.tmrReload.Tick += new System.EventHandler(this.tmrReload_Tick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.bbtnDeleteCard);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtnClose,
            this.bbtnNewCard,
            this.bbtnDeleteCard});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpGeneral});
            this.ribbon.SelectedPage = this.rpGeneral;
            this.ribbon.Size = new System.Drawing.Size(793, 143);
            // 
            // bbtnClose
            // 
            this.bbtnClose.Caption = "Close";
            this.bbtnClose.Id = 1;
            this.bbtnClose.Name = "bbtnClose";
            this.bbtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnClose_ItemClick);
            // 
            // bbtnNewCard
            // 
            this.bbtnNewCard.Caption = "New Card";
            this.bbtnNewCard.Id = 2;
            this.bbtnNewCard.Name = "bbtnNewCard";
            this.bbtnNewCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnNewCard_ItemClick);
            // 
            // bbtnDeleteCard
            // 
            this.bbtnDeleteCard.Caption = "Delete Card";
            this.bbtnDeleteCard.Id = 3;
            this.bbtnDeleteCard.Name = "bbtnDeleteCard";
            // 
            // rpGeneral
            // 
            this.rpGeneral.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpGeneral.Name = "rpGeneral";
            this.rpGeneral.Text = "General";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnClose);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnNewCard);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "File";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollection1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(793, 380);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colCardModel,
            this.colCardRevision,
            this.colCardSerialNumber,
            this.colCardName,
            this.colCardDescription});
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
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCardModel, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridView1_ShowGridMenu);
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
            this.colCardSerialNumber.FieldName = "CardSerialNumber";
            this.colCardSerialNumber.Name = "colCardSerialNumber";
            this.colCardSerialNumber.Visible = true;
            this.colCardSerialNumber.VisibleIndex = 2;
            // 
            // colCardName
            // 
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 3;
            // 
            // colCardDescription
            // 
            this.colCardDescription.FieldName = "CardDescription";
            this.colCardDescription.Name = "colCardDescription";
            this.colCardDescription.Visible = true;
            this.colCardDescription.VisibleIndex = 4;
            // 
            // clientPanel
            // 
            this.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clientPanel.Controls.Add(this.gridControl1);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 143);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(793, 380);
            this.clientPanel.TabIndex = 2;
            // 
            // frmCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 523);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.ribbon);
            this.Name = "frmCards";
            this.Ribbon = this.ribbon;
            this.Text = "Card Manager";
            this.Load += new System.EventHandler(this.frmCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).EndInit();
            this.clientPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpCollection1;
        private System.Windows.Forms.Timer tmrReload;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem bbtnClose;
        private DevExpress.XtraBars.BarButtonItem bbtnNewCard;
        private DevExpress.XtraBars.BarButtonItem bbtnDeleteCard;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpGeneral;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colCardModel;
        private DevExpress.XtraGrid.Columns.GridColumn colCardRevision;
        private DevExpress.XtraGrid.Columns.GridColumn colCardSerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colCardDescription;
        private DevExpress.XtraEditors.PanelControl clientPanel;
    }
}