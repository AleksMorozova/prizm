﻿namespace PrizmMain.Forms
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
            this.barButtonItemNewProject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemChangeCurrentProject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemMill = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemNewPipe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMillFindEditPipes = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNewRailcar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFindEditShipRailcars = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMillReports = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemComponentry = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemInspectionFindEditPipes = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNewComponent = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemInspectionFindComponentry = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemInspectionReports = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemConstruction = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemConstructionFindEditPipes = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemConstructionFindEditComponentry = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNewJoint = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFindEditJoints = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemConstructionReports = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemSettings = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemSetingsProject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSettingsPipe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSettingsPipeline = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSettingsUsers = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSettingsDictionaries = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemReports = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemCustomReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItemJoints = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemRailcar = new DevExpress.XtraBars.BarButtonItem();
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
            this.barSubItemMill,
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
            this.barButtonItemMillFindEditPipes,
            this.barSubItemApplication,
            this.barButtonItemNewProject,
            this.barButtonItemNewComponent,
            this.barButtonItemInspectionFindComponentry,
            this.barButtonItemCustomReport,
            this.barButtonItemRailcar,
            this.barSubItemConstruction,
            this.barButtonItemConstructionFindEditPipes,
            this.barButtonItemConstructionFindEditComponentry,
            this.barButtonItemSetingsProject,
            this.barButtonItemChangeCurrentProject,
            this.barButtonItemExit,
            this.barButtonItemNewJoint,
            this.barButtonItemFindEditJoints,
            this.barButtonItemConstructionReports,
            this.barButtonItemInspectionFindEditPipes,
            this.barButtonItemInspectionReports,
            this.barButtonItemNewRailcar,
            this.barButtonItemFindEditShipRailcars,
            this.barButtonItemMillReports});
            this.barManager1.MainMenu = this.barMenu;
            this.barManager1.MaxItemId = 41;
            this.barManager1.StatusBar = this.barStatus;
            // 
            // barTools
            // 
            this.barTools.BarName = "Tools";
            this.barTools.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barTools.DockCol = 0;
            this.barTools.DockRow = 1;
            this.barTools.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barTools.FloatLocation = new System.Drawing.Point(962, 406);
            this.barTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonClose, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barTools.Offset = 631;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemMill),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemComponentry),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemConstruction),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemSettings),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemReports),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAbout)});
            this.barMenu.OptionsBar.DisableClose = true;
            this.barMenu.OptionsBar.DisableCustomization = true;
            this.barMenu.OptionsBar.MultiLine = true;
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Main menu";
            // 
            // barSubItemApplication
            // 
            this.barSubItemApplication.Caption = "&File";
            this.barSubItemApplication.Id = 18;
            this.barSubItemApplication.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemNewProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemChangeCurrentProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExit)});
            this.barSubItemApplication.Name = "barSubItemApplication";
            // 
            // barButtonItemNewProject
            // 
            this.barButtonItemNewProject.Caption = "&New project";
            this.barButtonItemNewProject.Id = 19;
            this.barButtonItemNewProject.Name = "barButtonItemNewProject";
            // 
            // barButtonItemChangeCurrentProject
            // 
            this.barButtonItemChangeCurrentProject.Caption = "&Change current project...";
            this.barButtonItemChangeCurrentProject.Id = 30;
            this.barButtonItemChangeCurrentProject.Name = "barButtonItemChangeCurrentProject";
            // 
            // barButtonItemExit
            // 
            this.barButtonItemExit.Caption = "&Exit";
            this.barButtonItemExit.Id = 31;
            this.barButtonItemExit.Name = "barButtonItemExit";
            // 
            // barSubItemMill
            // 
            this.barSubItemMill.Caption = "&Mill";
            this.barSubItemMill.Id = 0;
            this.barSubItemMill.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemNewPipe),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemMillFindEditPipes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemNewRailcar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemFindEditShipRailcars),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemMillReports)});
            this.barSubItemMill.Name = "barSubItemMill";
            // 
            // barButtonItemNewPipe
            // 
            this.barButtonItemNewPipe.Caption = "&New pipe";
            this.barButtonItemNewPipe.Id = 16;
            this.barButtonItemNewPipe.Name = "barButtonItemNewPipe";
            this.barButtonItemNewPipe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewPipe_ItemClick);
            // 
            // barButtonItemMillFindEditPipes
            // 
            this.barButtonItemMillFindEditPipes.Caption = "&Find/edit pipes...";
            this.barButtonItemMillFindEditPipes.Id = 17;
            this.barButtonItemMillFindEditPipes.Name = "barButtonItemMillFindEditPipes";
            this.barButtonItemMillFindEditPipes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMillFindEditPipes_ItemClick);
            // 
            // barButtonItemNewRailcar
            // 
            this.barButtonItemNewRailcar.Caption = "New r&ailcar";
            this.barButtonItemNewRailcar.Id = 37;
            this.barButtonItemNewRailcar.Name = "barButtonItemNewRailcar";
            this.barButtonItemNewRailcar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewRailcar_ItemClick);
            // 
            // barButtonItemFindEditShipRailcars
            // 
            this.barButtonItemFindEditShipRailcars.Caption = "Find/&edit/ship railcars...";
            this.barButtonItemFindEditShipRailcars.Id = 38;
            this.barButtonItemFindEditShipRailcars.Name = "barButtonItemFindEditShipRailcars";
            this.barButtonItemFindEditShipRailcars.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFindEditShipRailcars_ItemClick);
            // 
            // barButtonItemMillReports
            // 
            this.barButtonItemMillReports.Caption = "&Reports";
            this.barButtonItemMillReports.Id = 39;
            this.barButtonItemMillReports.Name = "barButtonItemMillReports";
            this.barButtonItemMillReports.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMillReports_ItemClick);
            // 
            // barSubItemComponentry
            // 
            this.barSubItemComponentry.Caption = "&Incoming inspection";
            this.barSubItemComponentry.Id = 13;
            this.barSubItemComponentry.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemInspectionFindEditPipes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemNewComponent),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemInspectionFindComponentry),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemInspectionReports)});
            this.barSubItemComponentry.Name = "barSubItemComponentry";
            // 
            // barButtonItemInspectionFindEditPipes
            // 
            this.barButtonItemInspectionFindEditPipes.Caption = "&Find/edit pipes ...";
            this.barButtonItemInspectionFindEditPipes.Id = 35;
            this.barButtonItemInspectionFindEditPipes.Name = "barButtonItemInspectionFindEditPipes";
            // 
            // barButtonItemNewComponent
            // 
            this.barButtonItemNewComponent.Caption = "&New component";
            this.barButtonItemNewComponent.Id = 20;
            this.barButtonItemNewComponent.Name = "barButtonItemNewComponent";
            this.barButtonItemNewComponent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewComponent_ItemClick);
            // 
            // barButtonItemInspectionFindComponentry
            // 
            this.barButtonItemInspectionFindComponentry.Caption = "Find/&edit componentry...";
            this.barButtonItemInspectionFindComponentry.Id = 21;
            this.barButtonItemInspectionFindComponentry.Name = "barButtonItemInspectionFindComponentry";
            this.barButtonItemInspectionFindComponentry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemInspectionFindComponentry_ItemClick);
            // 
            // barButtonItemInspectionReports
            // 
            this.barButtonItemInspectionReports.Caption = "&Reports";
            this.barButtonItemInspectionReports.Id = 36;
            this.barButtonItemInspectionReports.Name = "barButtonItemInspectionReports";
            this.barButtonItemInspectionReports.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemInspectionReports_ItemClick);
            // 
            // barSubItemConstruction
            // 
            this.barSubItemConstruction.Caption = "&Construction";
            this.barSubItemConstruction.Id = 26;
            this.barSubItemConstruction.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemConstructionFindEditPipes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemConstructionFindEditComponentry),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemNewJoint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemFindEditJoints),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemConstructionReports)});
            this.barSubItemConstruction.Name = "barSubItemConstruction";
            // 
            // barButtonItemConstructionFindEditPipes
            // 
            this.barButtonItemConstructionFindEditPipes.Caption = "&Find/edit pipes ...";
            this.barButtonItemConstructionFindEditPipes.Id = 27;
            this.barButtonItemConstructionFindEditPipes.Name = "barButtonItemConstructionFindEditPipes";
            // 
            // barButtonItemConstructionFindEditComponentry
            // 
            this.barButtonItemConstructionFindEditComponentry.Caption = "Find/&edit componentry...";
            this.barButtonItemConstructionFindEditComponentry.Id = 28;
            this.barButtonItemConstructionFindEditComponentry.Name = "barButtonItemConstructionFindEditComponentry";
            // 
            // barButtonItemNewJoint
            // 
            this.barButtonItemNewJoint.Caption = "&New joint";
            this.barButtonItemNewJoint.Id = 32;
            this.barButtonItemNewJoint.Name = "barButtonItemNewJoint";
            this.barButtonItemNewJoint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewJoint_ItemClick);
            // 
            // barButtonItemFindEditJoints
            // 
            this.barButtonItemFindEditJoints.Caption = "Find/edit joints ...";
            this.barButtonItemFindEditJoints.Id = 33;
            this.barButtonItemFindEditJoints.Name = "barButtonItemFindEditJoints";
            this.barButtonItemFindEditJoints.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFindEditJoints_ItemClick);
            // 
            // barButtonItemConstructionReports
            // 
            this.barButtonItemConstructionReports.Caption = "Reports";
            this.barButtonItemConstructionReports.Id = 34;
            this.barButtonItemConstructionReports.Name = "barButtonItemConstructionReports";
            this.barButtonItemConstructionReports.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemConstructionReports_ItemClick);
            // 
            // barSubItemSettings
            // 
            this.barSubItemSettings.Caption = "&Settings";
            this.barSubItemSettings.Id = 1;
            this.barSubItemSettings.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSetingsProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSettingsPipe),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSettingsPipeline),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSettingsUsers),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSettingsDictionaries)});
            this.barSubItemSettings.Name = "barSubItemSettings";
            // 
            // barButtonItemSetingsProject
            // 
            this.barButtonItemSetingsProject.Caption = "P&roject";
            this.barButtonItemSetingsProject.Id = 29;
            this.barButtonItemSetingsProject.Name = "barButtonItemSetingsProject";
            this.barButtonItemSetingsProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSetingsProject_ItemClick);
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
            // barSubItemReports
            // 
            this.barSubItemReports.Caption = "&Reports";
            this.barSubItemReports.Id = 14;
            this.barSubItemReports.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCustomReport, true)});
            this.barSubItemReports.Name = "barSubItemReports";
            // 
            // barButtonItemCustomReport
            // 
            this.barButtonItemCustomReport.Caption = "Custom report";
            this.barButtonItemCustomReport.Id = 24;
            this.barButtonItemCustomReport.Name = "barButtonItemCustomReport";
            // 
            // barButtonItemAbout
            // 
            this.barButtonItemAbout.Caption = "Help";
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
            this.barDockControlTop.Size = new System.Drawing.Size(749, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 437);
            this.barDockControlBottom.Size = new System.Drawing.Size(749, 72);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 415);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(749, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 415);
            // 
            // barSubItemJoints
            // 
            this.barSubItemJoints.Id = 40;
            this.barSubItemJoints.Name = "barSubItemJoints";
            // 
            // barButtonItemRailcar
            // 
            this.barButtonItemRailcar.Caption = "Railcar";
            this.barButtonItemRailcar.Id = 25;
            this.barButtonItemRailcar.Name = "barButtonItemRailcar";
            // 
            // PrizmApplicationXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 509);
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
        private DevExpress.XtraBars.BarSubItem barSubItemMill;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewProject;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewPipe;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMillFindEditPipes;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewComponent;
        private DevExpress.XtraBars.BarButtonItem barButtonItemInspectionFindComponentry;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCustomReport;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRailcar;
        private DevExpress.XtraBars.BarSubItem barSubItemConstruction;
        private DevExpress.XtraBars.BarButtonItem barButtonItemConstructionFindEditPipes;
        private DevExpress.XtraBars.BarButtonItem barButtonItemConstructionFindEditComponentry;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSetingsProject;
        private DevExpress.XtraBars.BarButtonItem barButtonItemChangeCurrentProject;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemInspectionFindEditPipes;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewJoint;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFindEditJoints;
        private DevExpress.XtraBars.BarButtonItem barButtonItemConstructionReports;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewRailcar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFindEditShipRailcars;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMillReports;
        private DevExpress.XtraBars.BarButtonItem barButtonItemInspectionReports;





    }
}