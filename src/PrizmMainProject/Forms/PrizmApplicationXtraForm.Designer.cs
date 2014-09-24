namespace PrizmMain.Forms
{
    partial class PrizmApplicationXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrizmApplicationXtraForm));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barTools = new DevExpress.XtraBars.Bar();
            this.barButtonClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.barSubItemApplication = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemExit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemPipes = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemNewPipe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFindPipes = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemJoints = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemNewJoint = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFindJoints = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemComponentry = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemNewComponent = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFindComponentry = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemReports = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemReport = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemSettings = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemSettingsPipe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSettingsPipeline = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSettingsUsers = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSettingsDictionaries = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barTools,
            this.barMenu,
            this.barStatus});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemPipes,
            this.barSubItemSettings,
            this.barButtonItemSettingsPipe,
            this.barButtonItemSettingsPipeline,
            this.barButtonItemSettingsUsers,
            this.barButtonItemSettingsDictionaries,
            this.barStaticItem1,
            this.barButtonClose,
            this.barButtonSave,
            this.barSubItemJoints,
            this.barSubItemComponentry,
            this.barSubItemReports,
            this.barButtonItemAbout,
            this.barButtonItemNewPipe,
            this.barButtonItemFindPipes,
            this.barSubItemApplication,
            this.barButtonItemExit,
            this.barButtonItemNewComponent,
            this.barButtonItemFindComponentry,
            this.barButtonItemNewJoint,
            this.barButtonItemFindJoints,
            this.barButtonItemReport});
            this.barManager1.MainMenu = this.barMenu;
            this.barManager1.MaxItemId = 25;
            this.barManager1.StatusBar = this.barStatus;
            // 
            // barTools
            // 
            this.barTools.BarName = "Tools";
            this.barTools.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barTools.DockCol = 0;
            this.barTools.DockRow = 1;
            this.barTools.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barTools.FloatLocation = new System.Drawing.Point(1247, 600);
            this.barTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barTools.OptionsBar.AllowQuickCustomization = false;
            this.barTools.OptionsBar.DisableClose = true;
            this.barTools.OptionsBar.DisableCustomization = true;
            this.barTools.Text = "Tools";
            // 
            // barButtonClose
            // 
            this.barButtonClose.Caption = "&Close";
            this.barButtonClose.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonClose.Glyph")));
            this.barButtonClose.Id = 9;
            this.barButtonClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonClose.LargeGlyph")));
            this.barButtonClose.Name = "barButtonClose";
            this.barButtonClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonClose_ItemClick);
            // 
            // barButtonSave
            // 
            this.barButtonSave.Caption = "&Save";
            this.barButtonSave.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonSave.Glyph")));
            this.barButtonSave.Id = 10;
            this.barButtonSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonSave.LargeGlyph")));
            this.barButtonSave.Name = "barButtonSave";
            // 
            // barMenu
            // 
            this.barMenu.BarName = "Main menu";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemApplication),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemPipes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemJoints),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemComponentry),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemReports),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemSettings),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAbout)});
            this.barMenu.OptionsBar.DisableClose = true;
            this.barMenu.OptionsBar.DisableCustomization = true;
            this.barMenu.OptionsBar.MultiLine = true;
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Main menu";
            // 
            // barSubItemApplication
            // 
            this.barSubItemApplication.Caption = "&Application";
            this.barSubItemApplication.Id = 18;
            this.barSubItemApplication.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExit)});
            this.barSubItemApplication.Name = "barSubItemApplication";
            // 
            // barButtonItemExit
            // 
            this.barButtonItemExit.Caption = "E&xit";
            this.barButtonItemExit.Id = 19;
            this.barButtonItemExit.Name = "barButtonItemExit";
            this.barButtonItemExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExit_ItemClick);
            // 
            // barSubItemPipes
            // 
            this.barSubItemPipes.Caption = "&Pipes";
            this.barSubItemPipes.Id = 0;
            this.barSubItemPipes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemNewPipe),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemFindPipes)});
            this.barSubItemPipes.Name = "barSubItemPipes";
            // 
            // barButtonItemNewPipe
            // 
            this.barButtonItemNewPipe.Caption = "&New pipe";
            this.barButtonItemNewPipe.Id = 16;
            this.barButtonItemNewPipe.Name = "barButtonItemNewPipe";
            this.barButtonItemNewPipe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewPipe_ItemClick);
            // 
            // barButtonItemFindPipes
            // 
            this.barButtonItemFindPipes.Caption = "&Find pipes...";
            this.barButtonItemFindPipes.Id = 17;
            this.barButtonItemFindPipes.Name = "barButtonItemFindPipes";
            this.barButtonItemFindPipes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFindPipes_ItemClick);
            // 
            // barSubItemJoints
            // 
            this.barSubItemJoints.Caption = "&Joints";
            this.barSubItemJoints.Id = 12;
            this.barSubItemJoints.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemNewJoint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemFindJoints)});
            this.barSubItemJoints.Name = "barSubItemJoints";
            // 
            // barButtonItemNewJoint
            // 
            this.barButtonItemNewJoint.Caption = "&New joint";
            this.barButtonItemNewJoint.Id = 22;
            this.barButtonItemNewJoint.Name = "barButtonItemNewJoint";
            this.barButtonItemNewJoint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewJoint_ItemClick);
            // 
            // barButtonItemFindJoints
            // 
            this.barButtonItemFindJoints.Caption = "&Find joints...";
            this.barButtonItemFindJoints.Id = 23;
            this.barButtonItemFindJoints.Name = "barButtonItemFindJoints";
            this.barButtonItemFindJoints.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFindJoints_ItemClick);
            // 
            // barSubItemComponentry
            // 
            this.barSubItemComponentry.Caption = "C&omponentry";
            this.barSubItemComponentry.Id = 13;
            this.barSubItemComponentry.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemNewComponent),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemFindComponentry)});
            this.barSubItemComponentry.Name = "barSubItemComponentry";
            // 
            // barButtonItemNewComponent
            // 
            this.barButtonItemNewComponent.Caption = "&New component";
            this.barButtonItemNewComponent.Id = 20;
            this.barButtonItemNewComponent.Name = "barButtonItemNewComponent";
            this.barButtonItemNewComponent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewComponent_ItemClick);
            // 
            // barButtonItemFindComponentry
            // 
            this.barButtonItemFindComponentry.Caption = "&Find componentry...";
            this.barButtonItemFindComponentry.Id = 21;
            this.barButtonItemFindComponentry.Name = "barButtonItemFindComponentry";
            this.barButtonItemFindComponentry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFindComponentry_ItemClick);
            // 
            // barSubItemReports
            // 
            this.barSubItemReports.Caption = "&Reports";
            this.barSubItemReports.Id = 14;
            this.barSubItemReports.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemReport)});
            this.barSubItemReports.Name = "barSubItemReports";
            // 
            // barButtonItemReport
            // 
            this.barButtonItemReport.Caption = "Report";
            this.barButtonItemReport.Id = 24;
            this.barButtonItemReport.Name = "barButtonItemReport";
            this.barButtonItemReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemReport_ItemClick);
            // 
            // barSubItemSettings
            // 
            this.barSubItemSettings.Caption = "&Settings";
            this.barSubItemSettings.Id = 1;
            this.barSubItemSettings.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSettingsPipe),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSettingsPipeline),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSettingsUsers),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSettingsDictionaries)});
            this.barSubItemSettings.Name = "barSubItemSettings";
            // 
            // barButtonItemSettingsPipe
            // 
            this.barButtonItemSettingsPipe.Caption = "&Pipe";
            this.barButtonItemSettingsPipe.Hint = "Pipe settings";
            this.barButtonItemSettingsPipe.Id = 2;
            this.barButtonItemSettingsPipe.Name = "barButtonItemSettingsPipe";
            this.barButtonItemSettingsPipe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSettingsPipe_ItemClick);
            // 
            // barButtonItemSettingsPipeline
            // 
            this.barButtonItemSettingsPipeline.Caption = "Pipe&line";
            this.barButtonItemSettingsPipeline.Id = 3;
            this.barButtonItemSettingsPipeline.Name = "barButtonItemSettingsPipeline";
            this.barButtonItemSettingsPipeline.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSettingsPipeline_ItemClick);
            // 
            // barButtonItemSettingsUsers
            // 
            this.barButtonItemSettingsUsers.Caption = "&Users";
            this.barButtonItemSettingsUsers.Id = 4;
            this.barButtonItemSettingsUsers.Name = "barButtonItemSettingsUsers";
            this.barButtonItemSettingsUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSettingsUsers_ItemClick);
            // 
            // barButtonItemSettingsDictionaries
            // 
            this.barButtonItemSettingsDictionaries.Caption = "&Dictionaries";
            this.barButtonItemSettingsDictionaries.Id = 5;
            this.barButtonItemSettingsDictionaries.Name = "barButtonItemSettingsDictionaries";
            this.barButtonItemSettingsDictionaries.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSettingsDictionaries_ItemClick);
            // 
            // barButtonItemAbout
            // 
            this.barButtonItemAbout.Caption = "A&bout";
            this.barButtonItemAbout.Id = 15;
            this.barButtonItemAbout.Name = "barButtonItemAbout";
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status bar";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DisableClose = true;
            this.barStatus.OptionsBar.DisableCustomization = true;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Status text";
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(741, 69);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 484);
            this.barDockControlBottom.Size = new System.Drawing.Size(741, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 69);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 415);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(741, 69);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 415);
            // 
            // PrizmApplicationXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 509);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "PrizmApplicationXtraForm";
            this.Text = "PRIZMA";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barTools;
        private DevExpress.XtraBars.Bar barMenu;
        private DevExpress.XtraBars.BarSubItem barSubItemPipes;
        private DevExpress.XtraBars.BarSubItem barSubItemSettings;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSettingsPipe;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSettingsPipeline;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSettingsUsers;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSettingsDictionaries;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonClose;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarSubItem barSubItemJoints;
        private DevExpress.XtraBars.BarSubItem barSubItemComponentry;
        private DevExpress.XtraBars.BarSubItem barSubItemReports;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAbout;
        private DevExpress.XtraBars.BarSubItem barSubItemApplication;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewPipe;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFindPipes;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewJoint;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFindJoints;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewComponent;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFindComponentry;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReport;





    }
}