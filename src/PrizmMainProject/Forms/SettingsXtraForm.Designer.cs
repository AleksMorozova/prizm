﻿namespace PrizmMain.Forms
{
    partial class SettingsXtraForm
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
            this.settings = new DevExpress.XtraTab.XtraTabControl();
            this.pipePage = new DevExpress.XtraTab.XtraTabPage();
            this.sizeGradeLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeManufacturerLabel = new DevExpress.XtraEditors.LabelControl();
            this.sizeGrade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pipeManufacturers = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pipeSetup = new DevExpress.XtraTab.XtraTabControl();
            this.generalPipeSetupPage = new DevExpress.XtraTab.XtraTabPage();
            this.internalCoating = new DevExpress.XtraEditors.GroupControl();
            this.internalMaterialLabel = new DevExpress.XtraEditors.LabelControl();
            this.internalAdhesionLabel = new DevExpress.XtraEditors.LabelControl();
            this.internalThicknessLabel = new DevExpress.XtraEditors.LabelControl();
            this.internalMaterial = new DevExpress.XtraEditors.TextEdit();
            this.internalCoatingCheck = new DevExpress.XtraEditors.CheckEdit();
            this.internalAdhesion = new DevExpress.XtraEditors.TextEdit();
            this.internalThickness = new DevExpress.XtraEditors.TextEdit();
            this.externalCoating = new DevExpress.XtraEditors.GroupControl();
            this.externalMaterialLabel = new DevExpress.XtraEditors.LabelControl();
            this.externalAdhesionLabel = new DevExpress.XtraEditors.LabelControl();
            this.externalThicknessLabel = new DevExpress.XtraEditors.LabelControl();
            this.externalMaterial = new DevExpress.XtraEditors.TextEdit();
            this.externalAdhesion = new DevExpress.XtraEditors.TextEdit();
            this.externalThickness = new DevExpress.XtraEditors.TextEdit();
            this.externalCoatingCheck = new DevExpress.XtraEditors.CheckEdit();
            this.helical = new DevExpress.XtraEditors.CheckEdit();
            this.longitudinal = new DevExpress.XtraEditors.CheckEdit();
            this.weldTypeLabel = new DevExpress.XtraEditors.LabelControl();
            this.inspectionPage = new DevExpress.XtraTab.XtraTabPage();
            this.inspectionGrid = new DevExpress.XtraGrid.GridControl();
            this.inspectionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stageColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.objectColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.frequencyColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificationColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeSetupLabel = new DevExpress.XtraEditors.LabelControl();
            this.projectPage = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.plateManufacturersList = new DevExpress.XtraGrid.GridControl();
            this.plateManufacturersListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plateManufacturerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plateManufacturersLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeManufacturersList = new DevExpress.XtraGrid.GridControl();
            this.pipeManufacturerListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeManufacturerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeSizeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeSizeItem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.pipeManufacturersLabel = new DevExpress.XtraEditors.LabelControl();
            this.designLabel = new DevExpress.XtraEditors.LabelControl();
            this.clientLabel = new DevExpress.XtraEditors.LabelControl();
            this.design = new DevExpress.XtraEditors.TextEdit();
            this.client = new DevExpress.XtraEditors.TextEdit();
            this.pipelinePage = new DevExpress.XtraTab.XtraTabPage();
            this.usersPage = new DevExpress.XtraTab.XtraTabPage();
            this.users = new DevExpress.XtraGrid.GridControl();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userAddButton = new DevExpress.XtraEditors.SimpleButton();
            this.userEditButton = new DevExpress.XtraEditors.SimpleButton();
            this.usersLabel = new DevExpress.XtraEditors.LabelControl();
            this.rolesPage = new DevExpress.XtraTab.XtraTabPage();
            this.roleAddButton = new DevExpress.XtraEditors.SimpleButton();
            this.editRoleButton = new DevExpress.XtraEditors.SimpleButton();
            this.roles = new DevExpress.XtraGrid.GridControl();
            this.rolesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rolesLabel = new DevExpress.XtraEditors.LabelControl();
            this.dictionariesPage = new DevExpress.XtraTab.XtraTabPage();
            this.dictionaries = new DevExpress.XtraGrid.GridControl();
            this.dictionaryView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dictionaryNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editDictionary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.settings.SuspendLayout();
            this.pipePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSetup)).BeginInit();
            this.pipeSetup.SuspendLayout();
            this.generalPipeSetupPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalCoating)).BeginInit();
            this.internalCoating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalCoatingCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalAdhesion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalCoating)).BeginInit();
            this.externalCoating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.externalMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalAdhesion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalCoatingCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longitudinal.Properties)).BeginInit();
            this.inspectionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).BeginInit();
            this.projectPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturerListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.design.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).BeginInit();
            this.usersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.rolesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesView)).BeginInit();
            this.dictionariesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).BeginInit();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Name = "settings";
            this.settings.SelectedTabPage = this.pipePage;
            this.settings.Size = new System.Drawing.Size(725, 425);
            this.settings.TabIndex = 0;
            this.settings.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.projectPage,
            this.pipePage,
            this.pipelinePage,
            this.usersPage,
            this.rolesPage,
            this.dictionariesPage});
            // 
            // pipePage
            // 
            this.pipePage.Controls.Add(this.sizeGradeLabel);
            this.pipePage.Controls.Add(this.pipeManufacturerLabel);
            this.pipePage.Controls.Add(this.sizeGrade);
            this.pipePage.Controls.Add(this.pipeManufacturers);
            this.pipePage.Controls.Add(this.pipeSetup);
            this.pipePage.Controls.Add(this.pipeSetupLabel);
            this.pipePage.Name = "pipePage";
            this.pipePage.Size = new System.Drawing.Size(719, 397);
            this.pipePage.Text = "Pip&e";
            // 
            // sizeGradeLabel
            // 
            this.sizeGradeLabel.Location = new System.Drawing.Point(473, 25);
            this.sizeGradeLabel.Name = "sizeGradeLabel";
            this.sizeGradeLabel.Size = new System.Drawing.Size(54, 13);
            this.sizeGradeLabel.TabIndex = 8;
            this.sizeGradeLabel.Text = "Size grade:";
            // 
            // pipeManufacturerLabel
            // 
            this.pipeManufacturerLabel.Location = new System.Drawing.Point(161, 25);
            this.pipeManufacturerLabel.Name = "pipeManufacturerLabel";
            this.pipeManufacturerLabel.Size = new System.Drawing.Size(97, 13);
            this.pipeManufacturerLabel.TabIndex = 7;
            this.pipeManufacturerLabel.Text = "Pipe manufacturers:";
            // 
            // sizeGrade
            // 
            this.sizeGrade.Location = new System.Drawing.Point(541, 22);
            this.sizeGrade.Name = "sizeGrade";
            this.sizeGrade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sizeGrade.Size = new System.Drawing.Size(165, 20);
            this.sizeGrade.TabIndex = 6;
            // 
            // pipeManufacturers
            // 
            this.pipeManufacturers.Location = new System.Drawing.Point(270, 22);
            this.pipeManufacturers.Name = "pipeManufacturers";
            this.pipeManufacturers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeManufacturers.Size = new System.Drawing.Size(165, 20);
            this.pipeManufacturers.TabIndex = 5;
            // 
            // pipeSetup
            // 
            this.pipeSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pipeSetup.Location = new System.Drawing.Point(11, 57);
            this.pipeSetup.Name = "pipeSetup";
            this.pipeSetup.SelectedTabPage = this.generalPipeSetupPage;
            this.pipeSetup.Size = new System.Drawing.Size(700, 337);
            this.pipeSetup.TabIndex = 0;
            this.pipeSetup.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.generalPipeSetupPage,
            this.inspectionPage});
            // 
            // generalPipeSetupPage
            // 
            this.generalPipeSetupPage.Controls.Add(this.internalCoating);
            this.generalPipeSetupPage.Controls.Add(this.externalCoating);
            this.generalPipeSetupPage.Controls.Add(this.helical);
            this.generalPipeSetupPage.Controls.Add(this.longitudinal);
            this.generalPipeSetupPage.Controls.Add(this.weldTypeLabel);
            this.generalPipeSetupPage.Name = "generalPipeSetupPage";
            this.generalPipeSetupPage.Size = new System.Drawing.Size(694, 309);
            this.generalPipeSetupPage.Text = "&General set up";
            // 
            // internalCoating
            // 
            this.internalCoating.Controls.Add(this.internalMaterialLabel);
            this.internalCoating.Controls.Add(this.internalAdhesionLabel);
            this.internalCoating.Controls.Add(this.internalThicknessLabel);
            this.internalCoating.Controls.Add(this.internalMaterial);
            this.internalCoating.Controls.Add(this.internalCoatingCheck);
            this.internalCoating.Controls.Add(this.internalAdhesion);
            this.internalCoating.Controls.Add(this.internalThickness);
            this.internalCoating.Location = new System.Drawing.Point(11, 154);
            this.internalCoating.Name = "internalCoating";
            this.internalCoating.Size = new System.Drawing.Size(412, 115);
            this.internalCoating.TabIndex = 8;
            // 
            // internalMaterialLabel
            // 
            this.internalMaterialLabel.Location = new System.Drawing.Point(19, 87);
            this.internalMaterialLabel.Name = "internalMaterialLabel";
            this.internalMaterialLabel.Size = new System.Drawing.Size(38, 13);
            this.internalMaterialLabel.TabIndex = 6;
            this.internalMaterialLabel.Text = "Material";
            // 
            // internalAdhesionLabel
            // 
            this.internalAdhesionLabel.Location = new System.Drawing.Point(19, 58);
            this.internalAdhesionLabel.Name = "internalAdhesionLabel";
            this.internalAdhesionLabel.Size = new System.Drawing.Size(89, 13);
            this.internalAdhesionLabel.TabIndex = 5;
            this.internalAdhesionLabel.Text = "Adhesion, kgf/cm2";
            // 
            // internalThicknessLabel
            // 
            this.internalThicknessLabel.Location = new System.Drawing.Point(18, 29);
            this.internalThicknessLabel.Name = "internalThicknessLabel";
            this.internalThicknessLabel.Size = new System.Drawing.Size(69, 13);
            this.internalThicknessLabel.TabIndex = 4;
            this.internalThicknessLabel.Text = "Thickness, mm";
            // 
            // internalMaterial
            // 
            this.internalMaterial.Location = new System.Drawing.Point(129, 84);
            this.internalMaterial.Name = "internalMaterial";
            this.internalMaterial.Size = new System.Drawing.Size(273, 20);
            this.internalMaterial.TabIndex = 2;
            // 
            // internalCoatingCheck
            // 
            this.internalCoatingCheck.Location = new System.Drawing.Point(5, 1);
            this.internalCoatingCheck.Name = "internalCoatingCheck";
            this.internalCoatingCheck.Properties.Caption = "Internal coating";
            this.internalCoatingCheck.Size = new System.Drawing.Size(103, 19);
            this.internalCoatingCheck.TabIndex = 1;
            // 
            // internalAdhesion
            // 
            this.internalAdhesion.Location = new System.Drawing.Point(129, 55);
            this.internalAdhesion.Name = "internalAdhesion";
            this.internalAdhesion.Size = new System.Drawing.Size(100, 20);
            this.internalAdhesion.TabIndex = 1;
            // 
            // internalThickness
            // 
            this.internalThickness.Location = new System.Drawing.Point(129, 26);
            this.internalThickness.Name = "internalThickness";
            this.internalThickness.Size = new System.Drawing.Size(100, 20);
            this.internalThickness.TabIndex = 0;
            // 
            // externalCoating
            // 
            this.externalCoating.Controls.Add(this.externalMaterialLabel);
            this.externalCoating.Controls.Add(this.externalAdhesionLabel);
            this.externalCoating.Controls.Add(this.externalThicknessLabel);
            this.externalCoating.Controls.Add(this.externalMaterial);
            this.externalCoating.Controls.Add(this.externalAdhesion);
            this.externalCoating.Controls.Add(this.externalThickness);
            this.externalCoating.Controls.Add(this.externalCoatingCheck);
            this.externalCoating.Location = new System.Drawing.Point(11, 35);
            this.externalCoating.Name = "externalCoating";
            this.externalCoating.Size = new System.Drawing.Size(412, 113);
            this.externalCoating.TabIndex = 7;
            // 
            // externalMaterialLabel
            // 
            this.externalMaterialLabel.Location = new System.Drawing.Point(20, 92);
            this.externalMaterialLabel.Name = "externalMaterialLabel";
            this.externalMaterialLabel.Size = new System.Drawing.Size(38, 13);
            this.externalMaterialLabel.TabIndex = 11;
            this.externalMaterialLabel.Text = "Material";
            // 
            // externalAdhesionLabel
            // 
            this.externalAdhesionLabel.Location = new System.Drawing.Point(20, 63);
            this.externalAdhesionLabel.Name = "externalAdhesionLabel";
            this.externalAdhesionLabel.Size = new System.Drawing.Size(89, 13);
            this.externalAdhesionLabel.TabIndex = 10;
            this.externalAdhesionLabel.Text = "Adhesion, kgf/cm2";
            // 
            // externalThicknessLabel
            // 
            this.externalThicknessLabel.Location = new System.Drawing.Point(19, 34);
            this.externalThicknessLabel.Name = "externalThicknessLabel";
            this.externalThicknessLabel.Size = new System.Drawing.Size(69, 13);
            this.externalThicknessLabel.TabIndex = 9;
            this.externalThicknessLabel.Text = "Thickness, mm";
            // 
            // externalMaterial
            // 
            this.externalMaterial.Location = new System.Drawing.Point(129, 86);
            this.externalMaterial.Name = "externalMaterial";
            this.externalMaterial.Size = new System.Drawing.Size(273, 20);
            this.externalMaterial.TabIndex = 8;
            // 
            // externalAdhesion
            // 
            this.externalAdhesion.Location = new System.Drawing.Point(129, 60);
            this.externalAdhesion.Name = "externalAdhesion";
            this.externalAdhesion.Size = new System.Drawing.Size(100, 20);
            this.externalAdhesion.TabIndex = 7;
            // 
            // externalThickness
            // 
            this.externalThickness.Location = new System.Drawing.Point(129, 31);
            this.externalThickness.Name = "externalThickness";
            this.externalThickness.Size = new System.Drawing.Size(100, 20);
            this.externalThickness.TabIndex = 6;
            // 
            // externalCoatingCheck
            // 
            this.externalCoatingCheck.Location = new System.Drawing.Point(5, 1);
            this.externalCoatingCheck.Name = "externalCoatingCheck";
            this.externalCoatingCheck.Properties.Caption = "External coating";
            this.externalCoatingCheck.Size = new System.Drawing.Size(103, 19);
            this.externalCoatingCheck.TabIndex = 1;
            // 
            // helical
            // 
            this.helical.Location = new System.Drawing.Point(277, 13);
            this.helical.Name = "helical";
            this.helical.Properties.Caption = "Helical";
            this.helical.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.helical.Size = new System.Drawing.Size(75, 19);
            this.helical.TabIndex = 6;
            // 
            // longitudinal
            // 
            this.longitudinal.Location = new System.Drawing.Point(138, 13);
            this.longitudinal.Name = "longitudinal";
            this.longitudinal.Properties.Caption = "Longitudinal";
            this.longitudinal.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.longitudinal.Size = new System.Drawing.Size(75, 19);
            this.longitudinal.TabIndex = 4;
            // 
            // weldTypeLabel
            // 
            this.weldTypeLabel.Location = new System.Drawing.Point(18, 16);
            this.weldTypeLabel.Name = "weldTypeLabel";
            this.weldTypeLabel.Size = new System.Drawing.Size(49, 13);
            this.weldTypeLabel.TabIndex = 3;
            this.weldTypeLabel.Text = "Weld type";
            // 
            // inspectionPage
            // 
            this.inspectionPage.Controls.Add(this.inspectionGrid);
            this.inspectionPage.Name = "inspectionPage";
            this.inspectionPage.Size = new System.Drawing.Size(694, 309);
            this.inspectionPage.Text = "&Inspection";
            // 
            // inspectionGrid
            // 
            this.inspectionGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspectionGrid.Location = new System.Drawing.Point(4, 4);
            this.inspectionGrid.MainView = this.inspectionView;
            this.inspectionGrid.Name = "inspectionGrid";
            this.inspectionGrid.Size = new System.Drawing.Size(687, 302);
            this.inspectionGrid.TabIndex = 0;
            this.inspectionGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionView});
            // 
            // inspectionView
            // 
            this.inspectionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idColumn,
            this.stageColumn,
            this.objectColumn,
            this.frequencyColumn,
            this.documentColumn,
            this.certificationColumn,
            this.inspectionColumn});
            this.inspectionView.GridControl = this.inspectionGrid;
            this.inspectionView.Name = "inspectionView";
            // 
            // idColumn
            // 
            this.idColumn.Caption = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = true;
            this.idColumn.VisibleIndex = 0;
            // 
            // stageColumn
            // 
            this.stageColumn.Caption = "Stage";
            this.stageColumn.Name = "stageColumn";
            this.stageColumn.Visible = true;
            this.stageColumn.VisibleIndex = 1;
            // 
            // objectColumn
            // 
            this.objectColumn.Caption = "Object";
            this.objectColumn.Name = "objectColumn";
            this.objectColumn.Visible = true;
            this.objectColumn.VisibleIndex = 2;
            // 
            // frequencyColumn
            // 
            this.frequencyColumn.Caption = "Frequency";
            this.frequencyColumn.Name = "frequencyColumn";
            this.frequencyColumn.Visible = true;
            this.frequencyColumn.VisibleIndex = 3;
            // 
            // documentColumn
            // 
            this.documentColumn.Caption = "Document";
            this.documentColumn.Name = "documentColumn";
            this.documentColumn.Visible = true;
            this.documentColumn.VisibleIndex = 4;
            // 
            // certificationColumn
            // 
            this.certificationColumn.Caption = "Certification";
            this.certificationColumn.Name = "certificationColumn";
            this.certificationColumn.Visible = true;
            this.certificationColumn.VisibleIndex = 5;
            // 
            // inspectionColumn
            // 
            this.inspectionColumn.Caption = "Inspection";
            this.inspectionColumn.Name = "inspectionColumn";
            this.inspectionColumn.Visible = true;
            this.inspectionColumn.VisibleIndex = 6;
            // 
            // pipeSetupLabel
            // 
            this.pipeSetupLabel.Location = new System.Drawing.Point(15, 25);
            this.pipeSetupLabel.Name = "pipeSetupLabel";
            this.pipeSetupLabel.Size = new System.Drawing.Size(101, 13);
            this.pipeSetupLabel.TabIndex = 4;
            this.pipeSetupLabel.Text = "Set pipe parameters:";
            // 
            // projectPage
            // 
            this.projectPage.Controls.Add(this.panelControl1);
            this.projectPage.Controls.Add(this.splitContainer);
            this.projectPage.Controls.Add(this.designLabel);
            this.projectPage.Controls.Add(this.clientLabel);
            this.projectPage.Controls.Add(this.design);
            this.projectPage.Controls.Add(this.client);
            this.projectPage.Name = "projectPage";
            this.projectPage.Size = new System.Drawing.Size(719, 397);
            this.projectPage.Text = "Project";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(25, 314);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(365, 43);
            this.panelControl1.TabIndex = 20;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "1024";
            this.textEdit1.Location = new System.Drawing.Point(199, 10);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(172, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "External document size limit, Kbytes";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainer.Location = new System.Drawing.Point(25, 82);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.plateManufacturersList);
            this.splitContainer.Panel1.Controls.Add(this.plateManufacturersLabel);
            this.splitContainer.Panel1.Text = "PlatePanel";
            this.splitContainer.Panel2.Controls.Add(this.pipeManufacturersList);
            this.splitContainer.Panel2.Controls.Add(this.pipeManufacturersLabel);
            this.splitContainer.Panel2.Text = "PipePanel";
            this.splitContainer.Size = new System.Drawing.Size(678, 226);
            this.splitContainer.SplitterPosition = 339;
            this.splitContainer.TabIndex = 16;
            this.splitContainer.Text = "splitContainerControl1";
            // 
            // plateManufacturersList
            // 
            this.plateManufacturersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plateManufacturersList.Cursor = System.Windows.Forms.Cursors.Default;
            this.plateManufacturersList.Location = new System.Drawing.Point(3, 57);
            this.plateManufacturersList.MainView = this.plateManufacturersListView;
            this.plateManufacturersList.Name = "plateManufacturersList";
            this.plateManufacturersList.Size = new System.Drawing.Size(325, 169);
            this.plateManufacturersList.TabIndex = 10;
            this.plateManufacturersList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.plateManufacturersListView});
            // 
            // plateManufacturersListView
            // 
            this.plateManufacturersListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.plateManufacturerGridColumn});
            this.plateManufacturersListView.GridControl = this.plateManufacturersList;
            this.plateManufacturersListView.Name = "plateManufacturersListView";
            // 
            // plateManufacturerGridColumn
            // 
            this.plateManufacturerGridColumn.Caption = "Manufacture";
            this.plateManufacturerGridColumn.Name = "plateManufacturerGridColumn";
            this.plateManufacturerGridColumn.Visible = true;
            this.plateManufacturerGridColumn.VisibleIndex = 0;
            // 
            // plateManufacturersLabel
            // 
            this.plateManufacturersLabel.Location = new System.Drawing.Point(3, 20);
            this.plateManufacturersLabel.Name = "plateManufacturersLabel";
            this.plateManufacturersLabel.Size = new System.Drawing.Size(97, 13);
            this.plateManufacturersLabel.TabIndex = 9;
            this.plateManufacturersLabel.Text = "Plate manufacturers";
            // 
            // pipeManufacturersList
            // 
            this.pipeManufacturersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pipeManufacturersList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipeManufacturersList.Location = new System.Drawing.Point(14, 57);
            this.pipeManufacturersList.MainView = this.pipeManufacturerListView;
            this.pipeManufacturersList.Name = "pipeManufacturersList";
            this.pipeManufacturersList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.pipeSizeItem});
            this.pipeManufacturersList.Size = new System.Drawing.Size(319, 169);
            this.pipeManufacturersList.TabIndex = 11;
            this.pipeManufacturersList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipeManufacturerListView});
            // 
            // pipeManufacturerListView
            // 
            this.pipeManufacturerListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeManufacturerGridColumn,
            this.pipeSizeGridColumn});
            this.pipeManufacturerListView.GridControl = this.pipeManufacturersList;
            this.pipeManufacturerListView.Name = "pipeManufacturerListView";
            // 
            // pipeManufacturerGridColumn
            // 
            this.pipeManufacturerGridColumn.Caption = "Manufacturer";
            this.pipeManufacturerGridColumn.Name = "pipeManufacturerGridColumn";
            this.pipeManufacturerGridColumn.Visible = true;
            this.pipeManufacturerGridColumn.VisibleIndex = 0;
            // 
            // pipeSizeGridColumn
            // 
            this.pipeSizeGridColumn.Caption = "Pipe size";
            this.pipeSizeGridColumn.ColumnEdit = this.pipeSizeItem;
            this.pipeSizeGridColumn.Name = "pipeSizeGridColumn";
            this.pipeSizeGridColumn.Visible = true;
            this.pipeSizeGridColumn.VisibleIndex = 1;
            // 
            // pipeSizeItem
            // 
            this.pipeSizeItem.AutoHeight = false;
            this.pipeSizeItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeSizeItem.Name = "pipeSizeItem";
            // 
            // pipeManufacturersLabel
            // 
            this.pipeManufacturersLabel.Location = new System.Drawing.Point(14, 20);
            this.pipeManufacturersLabel.Name = "pipeManufacturersLabel";
            this.pipeManufacturersLabel.Size = new System.Drawing.Size(93, 13);
            this.pipeManufacturersLabel.TabIndex = 10;
            this.pipeManufacturersLabel.Text = "Pipe manufacturers";
            // 
            // designLabel
            // 
            this.designLabel.Location = new System.Drawing.Point(25, 56);
            this.designLabel.Name = "designLabel";
            this.designLabel.Size = new System.Drawing.Size(42, 13);
            this.designLabel.TabIndex = 15;
            this.designLabel.Text = "Designer";
            // 
            // clientLabel
            // 
            this.clientLabel.Location = new System.Drawing.Point(25, 20);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(27, 13);
            this.clientLabel.TabIndex = 14;
            this.clientLabel.Text = "Client";
            // 
            // design
            // 
            this.design.Location = new System.Drawing.Point(139, 49);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(251, 20);
            this.design.TabIndex = 13;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(139, 13);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(251, 20);
            this.client.TabIndex = 12;
            // 
            // pipelinePage
            // 
            this.pipelinePage.Name = "pipelinePage";
            this.pipelinePage.Size = new System.Drawing.Size(719, 397);
            this.pipelinePage.Text = "Pipe&line";
            // 
            // usersPage
            // 
            this.usersPage.Controls.Add(this.users);
            this.usersPage.Controls.Add(this.userAddButton);
            this.usersPage.Controls.Add(this.userEditButton);
            this.usersPage.Controls.Add(this.usersLabel);
            this.usersPage.Name = "usersPage";
            this.usersPage.Size = new System.Drawing.Size(719, 397);
            this.usersPage.Text = "&Users";
            // 
            // users
            // 
            this.users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.users.Cursor = System.Windows.Forms.Cursors.Default;
            this.users.DataSource = this.userBindingSource;
            this.users.Location = new System.Drawing.Point(11, 37);
            this.users.MainView = this.gridView1;
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(701, 287);
            this.users.TabIndex = 4;
            this.users.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(PrizmMain.DummyData.User);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colLogin,
            this.colPassword,
            this.colRole});
            this.gridView1.GridControl = this.users;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MaxWidth = 50;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 50;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            // 
            // colMiddleName
            // 
            this.colMiddleName.FieldName = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 3;
            // 
            // colLogin
            // 
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 4;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.MaxWidth = 50;
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 50;
            // 
            // colRole
            // 
            this.colRole.FieldName = "Role.Name";
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 5;
            // 
            // userAddButton
            // 
            this.userAddButton.Location = new System.Drawing.Point(11, 330);
            this.userAddButton.Name = "userAddButton";
            this.userAddButton.Size = new System.Drawing.Size(87, 23);
            this.userAddButton.TabIndex = 3;
            this.userAddButton.Text = "Add New User";
            // 
            // userEditButton
            // 
            this.userEditButton.Location = new System.Drawing.Point(104, 330);
            this.userEditButton.Name = "userEditButton";
            this.userEditButton.Size = new System.Drawing.Size(75, 23);
            this.userEditButton.TabIndex = 2;
            this.userEditButton.Text = "Edit User";
            this.userEditButton.Click += new System.EventHandler(this.userEditButton_Click);
            // 
            // usersLabel
            // 
            this.usersLabel.Location = new System.Drawing.Point(11, 18);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(27, 13);
            this.usersLabel.TabIndex = 0;
            this.usersLabel.Text = "Users";
            // 
            // rolesPage
            // 
            this.rolesPage.Controls.Add(this.roleAddButton);
            this.rolesPage.Controls.Add(this.editRoleButton);
            this.rolesPage.Controls.Add(this.roles);
            this.rolesPage.Controls.Add(this.rolesLabel);
            this.rolesPage.Name = "rolesPage";
            this.rolesPage.Size = new System.Drawing.Size(719, 397);
            this.rolesPage.Text = "Roles";
            // 
            // roleAddButton
            // 
            this.roleAddButton.Location = new System.Drawing.Point(11, 330);
            this.roleAddButton.Name = "roleAddButton";
            this.roleAddButton.Size = new System.Drawing.Size(87, 23);
            this.roleAddButton.TabIndex = 4;
            this.roleAddButton.Text = "Add New Role";
            // 
            // editRoleButton
            // 
            this.editRoleButton.Location = new System.Drawing.Point(104, 330);
            this.editRoleButton.Name = "editRoleButton";
            this.editRoleButton.Size = new System.Drawing.Size(75, 23);
            this.editRoleButton.TabIndex = 3;
            this.editRoleButton.Text = "Edit Role";
            this.editRoleButton.Click += new System.EventHandler(this.editRoleButton_Click);
            // 
            // roles
            // 
            this.roles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roles.Cursor = System.Windows.Forms.Cursors.Default;
            this.roles.Location = new System.Drawing.Point(11, 37);
            this.roles.MainView = this.rolesView;
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(701, 287);
            this.roles.TabIndex = 2;
            this.roles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rolesView});
            // 
            // rolesView
            // 
            this.rolesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.rolesView.GridControl = this.roles;
            this.rolesView.Name = "rolesView";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "№";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "User full name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Role";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // rolesLabel
            // 
            this.rolesLabel.Location = new System.Drawing.Point(11, 18);
            this.rolesLabel.Name = "rolesLabel";
            this.rolesLabel.Size = new System.Drawing.Size(26, 13);
            this.rolesLabel.TabIndex = 1;
            this.rolesLabel.Text = "Roles";
            // 
            // dictionariesPage
            // 
            this.dictionariesPage.Controls.Add(this.dictionaries);
            this.dictionariesPage.Name = "dictionariesPage";
            this.dictionariesPage.Size = new System.Drawing.Size(719, 397);
            this.dictionariesPage.Text = "&Dictionaries";
            // 
            // dictionaries
            // 
            this.dictionaries.Cursor = System.Windows.Forms.Cursors.Default;
            this.dictionaries.Location = new System.Drawing.Point(11, 18);
            this.dictionaries.MainView = this.dictionaryView;
            this.dictionaries.Name = "dictionaries";
            this.dictionaries.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.editItem});
            this.dictionaries.Size = new System.Drawing.Size(347, 346);
            this.dictionaries.TabIndex = 0;
            this.dictionaries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dictionaryView});
            // 
            // dictionaryView
            // 
            this.dictionaryView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dictionaryNameGridColumn,
            this.editDictionary});
            this.dictionaryView.GridControl = this.dictionaries;
            this.dictionaryView.Name = "dictionaryView";
            // 
            // dictionaryNameGridColumn
            // 
            this.dictionaryNameGridColumn.Caption = "Dictionary";
            this.dictionaryNameGridColumn.Name = "dictionaryNameGridColumn";
            this.dictionaryNameGridColumn.Visible = true;
            this.dictionaryNameGridColumn.VisibleIndex = 0;
            // 
            // editDictionary
            // 
            this.editDictionary.Caption = "Edit";
            this.editDictionary.ColumnEdit = this.editItem;
            this.editDictionary.Name = "editDictionary";
            this.editDictionary.Visible = true;
            this.editDictionary.VisibleIndex = 1;
            this.editDictionary.Width = 117;
            // 
            // editItem
            // 
            this.editItem.AutoHeight = false;
            this.editItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.editItem.Name = "editItem";
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // SettingsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.ControlBox = false;
            this.Controls.Add(this.settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsXtraForm";
            this.Text = "SettingsXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.settings.ResumeLayout(false);
            this.pipePage.ResumeLayout(false);
            this.pipePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSetup)).EndInit();
            this.pipeSetup.ResumeLayout(false);
            this.generalPipeSetupPage.ResumeLayout(false);
            this.generalPipeSetupPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalCoating)).EndInit();
            this.internalCoating.ResumeLayout(false);
            this.internalCoating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalCoatingCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalAdhesion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalCoating)).EndInit();
            this.externalCoating.ResumeLayout(false);
            this.externalCoating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.externalMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalAdhesion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalCoatingCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longitudinal.Properties)).EndInit();
            this.inspectionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).EndInit();
            this.projectPage.ResumeLayout(false);
            this.projectPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturerListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.design.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).EndInit();
            this.usersPage.ResumeLayout(false);
            this.usersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.rolesPage.ResumeLayout(false);
            this.rolesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesView)).EndInit();
            this.dictionariesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dictionaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage pipePage;
        private DevExpress.XtraTab.XtraTabPage pipelinePage;
        private DevExpress.XtraTab.XtraTabControl pipeSetup;
        private DevExpress.XtraTab.XtraTabPage generalPipeSetupPage;
        private DevExpress.XtraTab.XtraTabPage inspectionPage;
        private DevExpress.XtraEditors.CheckEdit longitudinal;
        private DevExpress.XtraEditors.LabelControl weldTypeLabel;
        private DevExpress.XtraEditors.LabelControl pipeSetupLabel;
        private DevExpress.XtraEditors.ComboBoxEdit sizeGrade;
        private DevExpress.XtraEditors.ComboBoxEdit pipeManufacturers;
        private DevExpress.XtraEditors.CheckEdit helical;
        private DevExpress.XtraEditors.LabelControl sizeGradeLabel;
        private DevExpress.XtraEditors.LabelControl pipeManufacturerLabel;
        private DevExpress.XtraEditors.GroupControl internalCoating;
        private DevExpress.XtraEditors.LabelControl internalMaterialLabel;
        private DevExpress.XtraEditors.LabelControl internalAdhesionLabel;
        private DevExpress.XtraEditors.LabelControl internalThicknessLabel;
        private DevExpress.XtraEditors.TextEdit internalMaterial;
        private DevExpress.XtraEditors.CheckEdit internalCoatingCheck;
        private DevExpress.XtraEditors.TextEdit internalAdhesion;
        private DevExpress.XtraEditors.TextEdit internalThickness;
        private DevExpress.XtraEditors.GroupControl externalCoating;
        private DevExpress.XtraEditors.LabelControl externalMaterialLabel;
        private DevExpress.XtraEditors.LabelControl externalAdhesionLabel;
        private DevExpress.XtraEditors.LabelControl externalThicknessLabel;
        private DevExpress.XtraEditors.TextEdit externalMaterial;
        private DevExpress.XtraEditors.TextEdit externalAdhesion;
        private DevExpress.XtraEditors.TextEdit externalThickness;
        private DevExpress.XtraEditors.CheckEdit externalCoatingCheck;

        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraTab.XtraTabPage usersPage;
        private DevExpress.XtraTab.XtraTabPage dictionariesPage;
        private DevExpress.XtraEditors.LabelControl usersLabel;
        private DevExpress.XtraGrid.GridControl dictionaries;
        private DevExpress.XtraGrid.Views.Grid.GridView dictionaryView;
        private DevExpress.XtraGrid.Columns.GridColumn dictionaryNameGridColumn;
        public DevExpress.XtraTab.XtraTabControl settings;
        private DevExpress.XtraTab.XtraTabPage projectPage;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer;
        private DevExpress.XtraGrid.GridControl plateManufacturersList;
        private DevExpress.XtraGrid.Views.Grid.GridView plateManufacturersListView;
        private DevExpress.XtraGrid.Columns.GridColumn plateManufacturerGridColumn;
        private DevExpress.XtraEditors.LabelControl plateManufacturersLabel;
        private DevExpress.XtraGrid.GridControl pipeManufacturersList;
        private DevExpress.XtraGrid.Views.Grid.GridView pipeManufacturerListView;
        private DevExpress.XtraGrid.Columns.GridColumn pipeManufacturerGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit pipeSizeItem;
        private DevExpress.XtraEditors.LabelControl pipeManufacturersLabel;
        private DevExpress.XtraEditors.LabelControl designLabel;
        private DevExpress.XtraEditors.LabelControl clientLabel;
        private DevExpress.XtraEditors.TextEdit design;
        private DevExpress.XtraEditors.TextEdit client;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabPage rolesPage;
        private DevExpress.XtraEditors.LabelControl rolesLabel;
        private DevExpress.XtraEditors.SimpleButton userEditButton;
        private DevExpress.XtraEditors.SimpleButton editRoleButton;
        private DevExpress.XtraGrid.GridControl roles;
        private DevExpress.XtraGrid.Views.Grid.GridView rolesView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton userAddButton;
        private DevExpress.XtraEditors.SimpleButton roleAddButton;
        private DevExpress.XtraGrid.Columns.GridColumn editDictionary;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit editItem;
        private DevExpress.XtraGrid.GridControl inspectionGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionView;
        private DevExpress.XtraGrid.Columns.GridColumn idColumn;
        private DevExpress.XtraGrid.Columns.GridColumn stageColumn;
        private DevExpress.XtraGrid.Columns.GridColumn objectColumn;
        private DevExpress.XtraGrid.Columns.GridColumn frequencyColumn;
        private DevExpress.XtraGrid.Columns.GridColumn documentColumn;
        private DevExpress.XtraGrid.Columns.GridColumn certificationColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionColumn;
        private DevExpress.XtraGrid.GridControl users;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
    }
}