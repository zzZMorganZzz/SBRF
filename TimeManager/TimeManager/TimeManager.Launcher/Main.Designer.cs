namespace TimeManager.Launcher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem_ReloadProjects = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_CheckProject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DownloadProject = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem_UserProfile = new DevExpress.XtraBars.BarHeaderItem();
            this.ribbonPage_Main = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl_ProjectShow = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceProject = new System.Windows.Forms.BindingSource(this.components);
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ProjectShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem_ReloadProjects,
            this.barButtonItem_CheckProject,
            this.barButtonItem_DownloadProject,
            this.barHeaderItem_UserProfile});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_Main});
            this.ribbonControl1.Size = new System.Drawing.Size(1179, 117);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem_ReloadProjects
            // 
            this.barButtonItem_ReloadProjects.Caption = "Обновить все приложения";
            this.barButtonItem_ReloadProjects.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ReloadProjects.Glyph")));
            this.barButtonItem_ReloadProjects.Id = 1;
            this.barButtonItem_ReloadProjects.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ReloadProjects.LargeGlyph")));
            this.barButtonItem_ReloadProjects.Name = "barButtonItem_ReloadProjects";
            // 
            // barButtonItem_CheckProject
            // 
            this.barButtonItem_CheckProject.Caption = "Проверить версии файлов приложения";
            this.barButtonItem_CheckProject.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_CheckProject.Glyph")));
            this.barButtonItem_CheckProject.Id = 2;
            this.barButtonItem_CheckProject.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_CheckProject.LargeGlyph")));
            this.barButtonItem_CheckProject.Name = "barButtonItem_CheckProject";
            // 
            // barButtonItem_DownloadProject
            // 
            this.barButtonItem_DownloadProject.Caption = "Загрузить приложение";
            this.barButtonItem_DownloadProject.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_DownloadProject.Glyph")));
            this.barButtonItem_DownloadProject.Id = 3;
            this.barButtonItem_DownloadProject.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_DownloadProject.LargeGlyph")));
            this.barButtonItem_DownloadProject.Name = "barButtonItem_DownloadProject";
            // 
            // barHeaderItem_UserProfile
            // 
            this.barHeaderItem_UserProfile.Id = 4;
            this.barHeaderItem_UserProfile.Name = "barHeaderItem_UserProfile";
            // 
            // ribbonPage_Main
            // 
            this.ribbonPage_Main.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage_Main.Name = "ribbonPage_Main";
            this.ribbonPage_Main.Text = "Главная";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_ReloadProjects);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_CheckProject);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem_DownloadProject);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Управление приложениями";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barHeaderItem_UserProfile);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 623);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1179, 27);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 123);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl_ProjectShow);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1155, 484);
            this.splitContainerControl1.SplitterPosition = 1013;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl_ProjectShow
            // 
            this.gridControl_ProjectShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl_ProjectShow.DataSource = this.bindingSourceProject;
            this.gridControl_ProjectShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ProjectShow.Location = new System.Drawing.Point(0, 0);
            this.gridControl_ProjectShow.MainView = this.winExplorerView1;
            this.gridControl_ProjectShow.MenuManager = this.ribbonControl1;
            this.gridControl_ProjectShow.Name = "gridControl_ProjectShow";
            this.gridControl_ProjectShow.Size = new System.Drawing.Size(1013, 484);
            this.gridControl_ProjectShow.TabIndex = 0;
            this.gridControl_ProjectShow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView1});
            // 
            // bindingSourceProject
            // 
            this.bindingSourceProject.DataSource = typeof(TimeManager.Launcher.Upload.Project);
            // 
            // winExplorerView1
            // 
            this.winExplorerView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProjectName,
            this.colOwner});
            this.winExplorerView1.ColumnSet.LargeImageColumn = this.colProjectName;
            this.winExplorerView1.ColumnSet.TextColumn = this.colProjectName;
            this.winExplorerView1.GridControl = this.gridControl_ProjectShow;
            this.winExplorerView1.Name = "winExplorerView1";
            // 
            // colProjectName
            // 
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 0;
            // 
            // colOwner
            // 
            this.colOwner.FieldName = "Owner";
            this.colOwner.Name = "colOwner";
            this.colOwner.Visible = true;
            this.colOwner.VisibleIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 650);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Main";
            this.Text = "Система обновления приложений [0.0.0.1] Beta";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ProjectShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Main;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ReloadProjects;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_CheckProject;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DownloadProject;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem_UserProfile;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl_ProjectShow;
        private System.Windows.Forms.BindingSource bindingSourceProject;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colOwner;

    }
}

