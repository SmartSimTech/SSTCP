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
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.clientPanel = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pcAddBoard = new DevExpress.XtraEditors.PanelControl();
            this.lblAddBoard = new DevExpress.XtraEditors.LabelControl();
            this.imgAddBoard = new System.Windows.Forms.PictureBox();
            this.pcBoardList = new DevExpress.XtraEditors.PanelControl();
            this.lblBoardList = new DevExpress.XtraEditors.LabelControl();
            this.imgBoardList = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcWebBrowser = new DevExpress.XtraEditors.PanelControl();
            this.wbNews = new System.Windows.Forms.WebBrowser();
            this.pcRequestSupport = new DevExpress.XtraEditors.PanelControl();
            this.lblRequestSupport = new DevExpress.XtraEditors.LabelControl();
            this.imgRequestSupport = new System.Windows.Forms.PictureBox();
            this.pcCheckForUpdates = new DevExpress.XtraEditors.PanelControl();
            this.lblCheckForUpdates = new DevExpress.XtraEditors.LabelControl();
            this.imgCheckForUpdates = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).BeginInit();
            this.clientPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAddBoard)).BeginInit();
            this.pcAddBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoardList)).BeginInit();
            this.pcBoardList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoardList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcWebBrowser)).BeginInit();
            this.pcWebBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRequestSupport)).BeginInit();
            this.pcRequestSupport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRequestSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCheckForUpdates)).BeginInit();
            this.pcCheckForUpdates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCheckForUpdates)).BeginInit();
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
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 530);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(860, 25);
            // 
            // clientPanel
            // 
            this.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clientPanel.Controls.Add(this.tableLayoutPanel1);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 143);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(860, 387);
            this.clientPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pcAddBoard, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pcBoardList, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pcWebBrowser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pcRequestSupport, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pcCheckForUpdates, 0, 4);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 387);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pcAddBoard
            // 
            this.pcAddBoard.Controls.Add(this.lblAddBoard);
            this.pcAddBoard.Controls.Add(this.imgAddBoard);
            this.pcAddBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcAddBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcAddBoard.Location = new System.Drawing.Point(3, 103);
            this.pcAddBoard.Name = "pcAddBoard";
            this.pcAddBoard.Size = new System.Drawing.Size(244, 29);
            this.pcAddBoard.TabIndex = 0;
            // 
            // lblAddBoard
            // 
            this.lblAddBoard.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAddBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddBoard.Location = new System.Drawing.Point(27, 2);
            this.lblAddBoard.Name = "lblAddBoard";
            this.lblAddBoard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblAddBoard.Size = new System.Drawing.Size(215, 25);
            this.lblAddBoard.TabIndex = 1;
            this.lblAddBoard.Text = "Add New Board";
            // 
            // imgAddBoard
            // 
            this.imgAddBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgAddBoard.Image = global::SSTCP.Properties.Resources.NewCard;
            this.imgAddBoard.Location = new System.Drawing.Point(2, 2);
            this.imgAddBoard.Name = "imgAddBoard";
            this.imgAddBoard.Size = new System.Drawing.Size(25, 25);
            this.imgAddBoard.TabIndex = 0;
            this.imgAddBoard.TabStop = false;
            // 
            // pcBoardList
            // 
            this.pcBoardList.Controls.Add(this.lblBoardList);
            this.pcBoardList.Controls.Add(this.imgBoardList);
            this.pcBoardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBoardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcBoardList.Location = new System.Drawing.Point(3, 138);
            this.pcBoardList.Name = "pcBoardList";
            this.pcBoardList.Size = new System.Drawing.Size(244, 29);
            this.pcBoardList.TabIndex = 1;
            this.pcBoardList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcBoardList_MouseClick);
            // 
            // lblBoardList
            // 
            this.lblBoardList.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBoardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBoardList.Location = new System.Drawing.Point(27, 2);
            this.lblBoardList.Name = "lblBoardList";
            this.lblBoardList.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblBoardList.Size = new System.Drawing.Size(215, 25);
            this.lblBoardList.TabIndex = 2;
            this.lblBoardList.Text = "Board List";
            this.lblBoardList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblBoardList_MouseClick);
            // 
            // imgBoardList
            // 
            this.imgBoardList.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgBoardList.Image = global::SSTCP.Properties.Resources.EditBoards;
            this.imgBoardList.Location = new System.Drawing.Point(2, 2);
            this.imgBoardList.Name = "imgBoardList";
            this.imgBoardList.Size = new System.Drawing.Size(25, 25);
            this.imgBoardList.TabIndex = 1;
            this.imgBoardList.TabStop = false;
            this.imgBoardList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgBoardList_MouseClick);
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
            // pcWebBrowser
            // 
            this.pcWebBrowser.Controls.Add(this.wbNews);
            this.pcWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcWebBrowser.Location = new System.Drawing.Point(253, 103);
            this.pcWebBrowser.Name = "pcWebBrowser";
            this.tableLayoutPanel1.SetRowSpan(this.pcWebBrowser, 5);
            this.pcWebBrowser.Size = new System.Drawing.Size(604, 281);
            this.pcWebBrowser.TabIndex = 3;
            // 
            // wbNews
            // 
            this.wbNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbNews.Location = new System.Drawing.Point(2, 2);
            this.wbNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNews.Name = "wbNews";
            this.wbNews.Size = new System.Drawing.Size(600, 277);
            this.wbNews.TabIndex = 0;
            // 
            // pcRequestSupport
            // 
            this.pcRequestSupport.Controls.Add(this.lblRequestSupport);
            this.pcRequestSupport.Controls.Add(this.imgRequestSupport);
            this.pcRequestSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRequestSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcRequestSupport.Location = new System.Drawing.Point(3, 173);
            this.pcRequestSupport.Name = "pcRequestSupport";
            this.pcRequestSupport.Size = new System.Drawing.Size(244, 29);
            this.pcRequestSupport.TabIndex = 4;
            this.pcRequestSupport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcRequestSupport_MouseClick);
            // 
            // lblRequestSupport
            // 
            this.lblRequestSupport.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRequestSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRequestSupport.Location = new System.Drawing.Point(27, 2);
            this.lblRequestSupport.Name = "lblRequestSupport";
            this.lblRequestSupport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblRequestSupport.Size = new System.Drawing.Size(215, 25);
            this.lblRequestSupport.TabIndex = 3;
            this.lblRequestSupport.Text = "Request Support";
            this.lblRequestSupport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblRequestSupport_MouseClick);
            // 
            // imgRequestSupport
            // 
            this.imgRequestSupport.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgRequestSupport.Image = global::SSTCP.Properties.Resources.Contact;
            this.imgRequestSupport.Location = new System.Drawing.Point(2, 2);
            this.imgRequestSupport.Name = "imgRequestSupport";
            this.imgRequestSupport.Size = new System.Drawing.Size(25, 25);
            this.imgRequestSupport.TabIndex = 2;
            this.imgRequestSupport.TabStop = false;
            this.imgRequestSupport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgRequestSupport_MouseClick);
            // 
            // pcCheckForUpdates
            // 
            this.pcCheckForUpdates.Controls.Add(this.lblCheckForUpdates);
            this.pcCheckForUpdates.Controls.Add(this.imgCheckForUpdates);
            this.pcCheckForUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcCheckForUpdates.Location = new System.Drawing.Point(3, 208);
            this.pcCheckForUpdates.Name = "pcCheckForUpdates";
            this.pcCheckForUpdates.Size = new System.Drawing.Size(244, 29);
            this.pcCheckForUpdates.TabIndex = 5;
            // 
            // lblCheckForUpdates
            // 
            this.lblCheckForUpdates.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCheckForUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCheckForUpdates.Location = new System.Drawing.Point(27, 2);
            this.lblCheckForUpdates.Name = "lblCheckForUpdates";
            this.lblCheckForUpdates.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCheckForUpdates.Size = new System.Drawing.Size(215, 25);
            this.lblCheckForUpdates.TabIndex = 4;
            this.lblCheckForUpdates.Text = "Check for Updates";
            // 
            // imgCheckForUpdates
            // 
            this.imgCheckForUpdates.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgCheckForUpdates.Image = global::SSTCP.Properties.Resources.Refresh;
            this.imgCheckForUpdates.Location = new System.Drawing.Point(2, 2);
            this.imgCheckForUpdates.Name = "imgCheckForUpdates";
            this.imgCheckForUpdates.Size = new System.Drawing.Size(25, 25);
            this.imgCheckForUpdates.TabIndex = 3;
            this.imgCheckForUpdates.TabStop = false;
            // 
            // frmStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 555);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmStartPage";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmStartPage";
            this.Load += new System.EventHandler(this.frmStartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).EndInit();
            this.clientPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcAddBoard)).EndInit();
            this.pcAddBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAddBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoardList)).EndInit();
            this.pcBoardList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoardList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcWebBrowser)).EndInit();
            this.pcWebBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcRequestSupport)).EndInit();
            this.pcRequestSupport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRequestSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCheckForUpdates)).EndInit();
            this.pcCheckForUpdates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCheckForUpdates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl clientPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl pcAddBoard;
        private DevExpress.XtraEditors.LabelControl lblAddBoard;
        private System.Windows.Forms.PictureBox imgAddBoard;
        private DevExpress.XtraEditors.PanelControl pcBoardList;
        private DevExpress.XtraEditors.LabelControl lblBoardList;
        private System.Windows.Forms.PictureBox imgBoardList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.PanelControl pcWebBrowser;
        private System.Windows.Forms.WebBrowser wbNews;
        private DevExpress.XtraEditors.PanelControl pcRequestSupport;
        private DevExpress.XtraEditors.LabelControl lblRequestSupport;
        private System.Windows.Forms.PictureBox imgRequestSupport;
        private DevExpress.XtraEditors.PanelControl pcCheckForUpdates;
        private DevExpress.XtraEditors.LabelControl lblCheckForUpdates;
        private System.Windows.Forms.PictureBox imgCheckForUpdates;
    }
}