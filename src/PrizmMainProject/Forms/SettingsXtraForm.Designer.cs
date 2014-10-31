namespace PrizmMain.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsXtraForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.externalDocumentPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.externalDocumentSize = new DevExpress.XtraEditors.TextEdit();
            this.externalDocumentLabel = new DevExpress.XtraEditors.LabelControl();
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
            this.usersLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.userEditButton = new DevExpress.XtraEditors.SimpleButton();
            this.userAddButton = new DevExpress.XtraEditors.SimpleButton();
            this.users = new DevExpress.XtraGrid.GridControl();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usersRootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.usersAddButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.editUserLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.usersLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.rightUsersButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.divideButtonUsersEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.rolesPage = new DevExpress.XtraTab.XtraTabPage();
            this.usersButtonLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.roles = new DevExpress.XtraGrid.GridControl();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rolesColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.roleEditButton = new DevExpress.XtraEditors.SimpleButton();
            this.roleAddButton = new DevExpress.XtraEditors.SimpleButton();
            this.rolesRootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.roleLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.roleButtonRightEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.roleAddButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.roleEditLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.roleButtonDivideEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dictionariesPage = new DevExpress.XtraTab.XtraTabPage();
            this.dictionaries = new DevExpress.XtraGrid.GridControl();
            this.dictionaryView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dictionaryNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editDictionary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.settingsTabPanel = new DevExpress.XtraEditors.PanelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentPanelControl)).BeginInit();
            this.externalDocumentPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.usersLayoutControl)).BeginInit();
            this.usersLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRootGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAddButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUserLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightUsersButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonUsersEmptySpace)).BeginInit();
            this.rolesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersButtonLayoutControl)).BeginInit();
            this.usersButtonLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesRootGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleButtonRightEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleAddButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEditLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleButtonDivideEmptySpace)).BeginInit();
            this.dictionariesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsTabPanel)).BeginInit();
            this.settingsTabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Name = "settings";
            this.settings.SelectedTabPage = this.pipePage;
            this.settings.Size = new System.Drawing.Size(940, 426);
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
            this.pipePage.Size = new System.Drawing.Size(934, 398);
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
            this.pipeSetup.Size = new System.Drawing.Size(915, 338);
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
            this.generalPipeSetupPage.Size = new System.Drawing.Size(909, 310);
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
            this.inspectionPage.Size = new System.Drawing.Size(909, 310);
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
            this.projectPage.Controls.Add(this.externalDocumentPanelControl);
            this.projectPage.Controls.Add(this.splitContainer);
            this.projectPage.Controls.Add(this.designLabel);
            this.projectPage.Controls.Add(this.clientLabel);
            this.projectPage.Controls.Add(this.design);
            this.projectPage.Controls.Add(this.client);
            this.projectPage.Name = "projectPage";
            this.projectPage.Size = new System.Drawing.Size(934, 398);
            this.projectPage.Text = "Project";
            // 
            // externalDocumentPanelControl
            // 
            this.externalDocumentPanelControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.externalDocumentPanelControl.Appearance.Options.UseBackColor = true;
            this.externalDocumentPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.externalDocumentPanelControl.Controls.Add(this.externalDocumentSize);
            this.externalDocumentPanelControl.Controls.Add(this.externalDocumentLabel);
            this.externalDocumentPanelControl.Location = new System.Drawing.Point(25, 345);
            this.externalDocumentPanelControl.Name = "externalDocumentPanelControl";
            this.externalDocumentPanelControl.Size = new System.Drawing.Size(365, 43);
            this.externalDocumentPanelControl.TabIndex = 20;
            // 
            // externalDocumentSize
            // 
            this.externalDocumentSize.EditValue = "1024";
            this.externalDocumentSize.Location = new System.Drawing.Point(199, 10);
            this.externalDocumentSize.Name = "externalDocumentSize";
            this.externalDocumentSize.Size = new System.Drawing.Size(100, 20);
            this.externalDocumentSize.TabIndex = 3;
            // 
            // externalDocumentLabel
            // 
            this.externalDocumentLabel.Location = new System.Drawing.Point(3, 14);
            this.externalDocumentLabel.Name = "externalDocumentLabel";
            this.externalDocumentLabel.Size = new System.Drawing.Size(172, 13);
            this.externalDocumentLabel.TabIndex = 2;
            this.externalDocumentLabel.Text = "External document size limit, Kbytes";
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
            this.designLabel.Location = new System.Drawing.Point(383, 22);
            this.designLabel.Name = "designLabel";
            this.designLabel.Size = new System.Drawing.Size(42, 13);
            this.designLabel.TabIndex = 15;
            this.designLabel.Text = "Designer";
            // 
            // clientLabel
            // 
            this.clientLabel.Location = new System.Drawing.Point(25, 22);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(27, 13);
            this.clientLabel.TabIndex = 14;
            this.clientLabel.Text = "Client";
            // 
            // design
            // 
            this.design.Location = new System.Drawing.Point(383, 41);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(251, 20);
            this.design.TabIndex = 13;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(25, 41);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(251, 20);
            this.client.TabIndex = 12;
            // 
            // pipelinePage
            // 
            this.pipelinePage.Name = "pipelinePage";
            this.pipelinePage.Size = new System.Drawing.Size(934, 398);
            this.pipelinePage.Text = "Pipe&line";
            // 
            // usersPage
            // 
            this.usersPage.Controls.Add(this.usersLayoutControl);
            this.usersPage.Name = "usersPage";
            this.usersPage.Size = new System.Drawing.Size(934, 398);
            this.usersPage.Text = "&Users";
            // 
            // usersLayoutControl
            // 
            this.usersLayoutControl.Controls.Add(this.userEditButton);
            this.usersLayoutControl.Controls.Add(this.userAddButton);
            this.usersLayoutControl.Controls.Add(this.users);
            this.usersLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.usersLayoutControl.Name = "usersLayoutControl";
            this.usersLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(346, 216, 250, 350);
            this.usersLayoutControl.Root = this.usersRootGroup;
            this.usersLayoutControl.Size = new System.Drawing.Size(934, 398);
            this.usersLayoutControl.TabIndex = 0;
            this.usersLayoutControl.Text = "UsersLayoutControl";
            // 
            // userEditButton
            // 
            this.userEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userEditButton.Image = ((System.Drawing.Image)(resources.GetObject("userEditButton.Image")));
            this.userEditButton.Location = new System.Drawing.Point(196, 32);
            this.userEditButton.Name = "userEditButton";
            this.userEditButton.Size = new System.Drawing.Size(150, 22);
            this.userEditButton.StyleController = this.usersLayoutControl;
            this.userEditButton.TabIndex = 5;
            this.userEditButton.Text = "Редактировать";
            this.userEditButton.Click += new System.EventHandler(this.userEditButton_Click);
            // 
            // userAddButton
            // 
            this.userAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userAddButton.Image = ((System.Drawing.Image)(resources.GetObject("userAddButton.Image")));
            this.userAddButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.userAddButton.Location = new System.Drawing.Point(32, 32);
            this.userAddButton.Name = "userAddButton";
            this.userAddButton.Size = new System.Drawing.Size(150, 22);
            this.userAddButton.StyleController = this.usersLayoutControl;
            this.userAddButton.TabIndex = 6;
            this.userAddButton.Text = "Добавить";
            // 
            // users
            // 
            this.users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.users.Cursor = System.Windows.Forms.Cursors.Default;
            this.users.DataSource = this.userBindingSource;
            this.users.Location = new System.Drawing.Point(32, 89);
            this.users.MainView = this.usersGridView;
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(870, 277);
            this.users.TabIndex = 7;
            this.users.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usersGridView});
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(PrizmMain.DummyData.User);
            // 
            // usersGridView
            // 
            this.usersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colLogin,
            this.colPassword,
            this.colRole});
            this.usersGridView.GridControl = this.users;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.OptionsBehavior.Editable = false;
            this.usersGridView.OptionsCustomization.AllowGroup = false;
            this.usersGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "№";
            this.colId.FieldName = "Id";
            this.colId.MaxWidth = 50;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 50;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Фамилия";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Имя";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            // 
            // colMiddleName
            // 
            this.colMiddleName.Caption = "Отчество";
            this.colMiddleName.FieldName = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 3;
            // 
            // colLogin
            // 
            this.colLogin.Caption = "Логин";
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 4;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Пароль";
            this.colPassword.FieldName = "Password";
            this.colPassword.MaxWidth = 50;
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 50;
            // 
            // colRole
            // 
            this.colRole.Caption = "Роль";
            this.colRole.FieldName = "Role.Name";
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 5;
            // 
            // usersRootGroup
            // 
            this.usersRootGroup.CustomizationFormText = "Root";
            this.usersRootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.usersRootGroup.GroupBordersVisible = false;
            this.usersRootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.usersAddButtonLayoutControl,
            this.editUserLayoutControl,
            this.usersLabel,
            this.rightUsersButtonEmptySpace,
            this.divideButtonUsersEmptySpace});
            this.usersRootGroup.Location = new System.Drawing.Point(0, 0);
            this.usersRootGroup.Name = "usersRootGroup";
            this.usersRootGroup.Size = new System.Drawing.Size(934, 398);
            this.usersRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.usersRootGroup.Text = "usersRootGroup";
            this.usersRootGroup.TextVisible = false;
            // 
            // usersAddButtonLayoutControl
            // 
            this.usersAddButtonLayoutControl.Control = this.userAddButton;
            this.usersAddButtonLayoutControl.CustomizationFormText = "usersAddButtonLayoutControl";
            this.usersAddButtonLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.usersAddButtonLayoutControl.MaxSize = new System.Drawing.Size(154, 26);
            this.usersAddButtonLayoutControl.MinSize = new System.Drawing.Size(154, 26);
            this.usersAddButtonLayoutControl.Name = "usersAddButtonLayoutControl";
            this.usersAddButtonLayoutControl.Size = new System.Drawing.Size(154, 26);
            this.usersAddButtonLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.usersAddButtonLayoutControl.Text = "usersAddButtonLayoutControl";
            this.usersAddButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.usersAddButtonLayoutControl.TextToControlDistance = 0;
            this.usersAddButtonLayoutControl.TextVisible = false;
            // 
            // editUserLayoutControl
            // 
            this.editUserLayoutControl.Control = this.userEditButton;
            this.editUserLayoutControl.CustomizationFormText = "editUserLayoutControl";
            this.editUserLayoutControl.Location = new System.Drawing.Point(164, 0);
            this.editUserLayoutControl.MaxSize = new System.Drawing.Size(154, 26);
            this.editUserLayoutControl.MinSize = new System.Drawing.Size(154, 26);
            this.editUserLayoutControl.Name = "editUserLayoutControl";
            this.editUserLayoutControl.Size = new System.Drawing.Size(154, 26);
            this.editUserLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.editUserLayoutControl.Text = "editUserLayoutControl";
            this.editUserLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.editUserLayoutControl.TextToControlDistance = 0;
            this.editUserLayoutControl.TextVisible = false;
            // 
            // usersLabel
            // 
            this.usersLabel.Control = this.users;
            this.usersLabel.CustomizationFormText = "Пользователи";
            this.usersLabel.Location = new System.Drawing.Point(0, 26);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(874, 312);
            this.usersLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 15, 0);
            this.usersLabel.Text = "Пользователи";
            this.usersLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.usersLabel.TextSize = new System.Drawing.Size(72, 13);
            // 
            // rightUsersButtonEmptySpace
            // 
            this.rightUsersButtonEmptySpace.AllowHotTrack = false;
            this.rightUsersButtonEmptySpace.CustomizationFormText = "rightUsersButtonEmptySpace";
            this.rightUsersButtonEmptySpace.Location = new System.Drawing.Point(318, 0);
            this.rightUsersButtonEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.rightUsersButtonEmptySpace.Name = "rightUsersButtonEmptySpace";
            this.rightUsersButtonEmptySpace.Size = new System.Drawing.Size(556, 26);
            this.rightUsersButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.rightUsersButtonEmptySpace.Text = "rightUsersButtonEmptySpace";
            this.rightUsersButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // divideButtonUsersEmptySpace
            // 
            this.divideButtonUsersEmptySpace.AllowHotTrack = false;
            this.divideButtonUsersEmptySpace.CustomizationFormText = "divideButtonUsersEmptySpace";
            this.divideButtonUsersEmptySpace.Location = new System.Drawing.Point(154, 0);
            this.divideButtonUsersEmptySpace.Name = "divideButtonUsersEmptySpace";
            this.divideButtonUsersEmptySpace.Size = new System.Drawing.Size(10, 26);
            this.divideButtonUsersEmptySpace.Text = "divideButtonUsersEmptySpace";
            this.divideButtonUsersEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // rolesPage
            // 
            this.rolesPage.Controls.Add(this.usersButtonLayoutControl);
            this.rolesPage.Name = "rolesPage";
            this.rolesPage.Size = new System.Drawing.Size(934, 398);
            this.rolesPage.Text = "Roles";
            // 
            // usersButtonLayoutControl
            // 
            this.usersButtonLayoutControl.Controls.Add(this.roles);
            this.usersButtonLayoutControl.Controls.Add(this.roleEditButton);
            this.usersButtonLayoutControl.Controls.Add(this.roleAddButton);
            this.usersButtonLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersButtonLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.usersButtonLayoutControl.Name = "usersButtonLayoutControl";
            this.usersButtonLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(346, 216, 250, 350);
            this.usersButtonLayoutControl.Root = this.rolesRootGroup;
            this.usersButtonLayoutControl.Size = new System.Drawing.Size(934, 398);
            this.usersButtonLayoutControl.TabIndex = 6;
            this.usersButtonLayoutControl.Text = "layoutControl2";
            // 
            // roles
            // 
            this.roles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roles.Cursor = System.Windows.Forms.Cursors.Default;
            this.roles.DataSource = this.roleBindingSource;
            this.roles.Location = new System.Drawing.Point(32, 91);
            this.roles.MainView = this.rolesGridView;
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(870, 275);
            this.roles.TabIndex = 5;
            this.roles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rolesGridView});
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(PrizmMain.DummyData.Role);
            // 
            // rolesGridView
            // 
            this.rolesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.rolesColId,
            this.colName,
            this.colDescription});
            this.rolesGridView.GridControl = this.roles;
            this.rolesGridView.Name = "rolesGridView";
            this.rolesGridView.OptionsBehavior.Editable = false;
            this.rolesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // rolesColId
            // 
            this.rolesColId.Caption = "№";
            this.rolesColId.FieldName = "Id";
            this.rolesColId.MaxWidth = 50;
            this.rolesColId.Name = "rolesColId";
            this.rolesColId.Visible = true;
            this.rolesColId.VisibleIndex = 0;
            this.rolesColId.Width = 50;
            // 
            // colName
            // 
            this.colName.Caption = "Роль";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Описание";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // roleEditButton
            // 
            this.roleEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roleEditButton.Image = ((System.Drawing.Image)(resources.GetObject("roleEditButton.Image")));
            this.roleEditButton.Location = new System.Drawing.Point(196, 32);
            this.roleEditButton.Name = "roleEditButton";
            this.roleEditButton.Size = new System.Drawing.Size(150, 24);
            this.roleEditButton.StyleController = this.usersButtonLayoutControl;
            this.roleEditButton.TabIndex = 3;
            this.roleEditButton.Text = "Редактировать";
            this.roleEditButton.Click += new System.EventHandler(this.editRoleButton_Click);
            // 
            // roleAddButton
            // 
            this.roleAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roleAddButton.Image = ((System.Drawing.Image)(resources.GetObject("roleAddButton.Image")));
            this.roleAddButton.Location = new System.Drawing.Point(32, 32);
            this.roleAddButton.Name = "roleAddButton";
            this.roleAddButton.Size = new System.Drawing.Size(150, 24);
            this.roleAddButton.StyleController = this.usersButtonLayoutControl;
            this.roleAddButton.TabIndex = 4;
            this.roleAddButton.Text = "Добавить";
            this.roleAddButton.Click += new System.EventHandler(this.roleAddButton_Click);
            // 
            // rolesRootGroup
            // 
            this.rolesRootGroup.CustomizationFormText = "Root";
            this.rolesRootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.rolesRootGroup.GroupBordersVisible = false;
            this.rolesRootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.roleLayoutControl,
            this.roleButtonRightEmptySpace,
            this.roleAddButtonLayoutControl,
            this.roleEditLayoutControl,
            this.roleButtonDivideEmptySpace});
            this.rolesRootGroup.Location = new System.Drawing.Point(0, 0);
            this.rolesRootGroup.Name = "rolesRootGroup";
            this.rolesRootGroup.Size = new System.Drawing.Size(934, 398);
            this.rolesRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.rolesRootGroup.Text = "rolesRootGroup";
            this.rolesRootGroup.TextVisible = false;
            // 
            // roleLayoutControl
            // 
            this.roleLayoutControl.Control = this.roles;
            this.roleLayoutControl.CustomizationFormText = "Роли";
            this.roleLayoutControl.Location = new System.Drawing.Point(0, 28);
            this.roleLayoutControl.MinSize = new System.Drawing.Size(104, 40);
            this.roleLayoutControl.Name = "roleLayoutControl";
            this.roleLayoutControl.Size = new System.Drawing.Size(874, 310);
            this.roleLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.roleLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 15, 0);
            this.roleLayoutControl.Text = "Роли";
            this.roleLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.roleLayoutControl.TextSize = new System.Drawing.Size(24, 13);
            // 
            // roleButtonRightEmptySpace
            // 
            this.roleButtonRightEmptySpace.AllowHotTrack = false;
            this.roleButtonRightEmptySpace.CustomizationFormText = "roleButtonRightEmptySpace";
            this.roleButtonRightEmptySpace.Location = new System.Drawing.Point(318, 0);
            this.roleButtonRightEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.roleButtonRightEmptySpace.Name = "roleButtonRightEmptySpace";
            this.roleButtonRightEmptySpace.Size = new System.Drawing.Size(556, 28);
            this.roleButtonRightEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.roleButtonRightEmptySpace.Text = "roleButtonRightEmptySpace";
            this.roleButtonRightEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // roleAddButtonLayoutControl
            // 
            this.roleAddButtonLayoutControl.Control = this.roleAddButton;
            this.roleAddButtonLayoutControl.CustomizationFormText = "roleAddButtonLayoutControl";
            this.roleAddButtonLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.roleAddButtonLayoutControl.MaxSize = new System.Drawing.Size(154, 28);
            this.roleAddButtonLayoutControl.MinSize = new System.Drawing.Size(154, 28);
            this.roleAddButtonLayoutControl.Name = "roleAddButtonLayoutControl";
            this.roleAddButtonLayoutControl.Size = new System.Drawing.Size(154, 28);
            this.roleAddButtonLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.roleAddButtonLayoutControl.Text = "roleAddButtonLayoutControl";
            this.roleAddButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.roleAddButtonLayoutControl.TextToControlDistance = 0;
            this.roleAddButtonLayoutControl.TextVisible = false;
            // 
            // roleEditLayoutControl
            // 
            this.roleEditLayoutControl.Control = this.roleEditButton;
            this.roleEditLayoutControl.CustomizationFormText = "roleEditLayoutControl";
            this.roleEditLayoutControl.Location = new System.Drawing.Point(164, 0);
            this.roleEditLayoutControl.MaxSize = new System.Drawing.Size(154, 28);
            this.roleEditLayoutControl.MinSize = new System.Drawing.Size(154, 28);
            this.roleEditLayoutControl.Name = "roleEditLayoutControl";
            this.roleEditLayoutControl.Size = new System.Drawing.Size(154, 28);
            this.roleEditLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.roleEditLayoutControl.Text = "roleEditLayoutControl";
            this.roleEditLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.roleEditLayoutControl.TextToControlDistance = 0;
            this.roleEditLayoutControl.TextVisible = false;
            // 
            // roleButtonDivideEmptySpace
            // 
            this.roleButtonDivideEmptySpace.AllowHotTrack = false;
            this.roleButtonDivideEmptySpace.CustomizationFormText = "roleButtonDivideEmptySpace";
            this.roleButtonDivideEmptySpace.Location = new System.Drawing.Point(154, 0);
            this.roleButtonDivideEmptySpace.Name = "roleButtonDivideEmptySpace";
            this.roleButtonDivideEmptySpace.Size = new System.Drawing.Size(10, 28);
            this.roleButtonDivideEmptySpace.Text = "roleButtonDivideEmptySpace";
            this.roleButtonDivideEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dictionariesPage
            // 
            this.dictionariesPage.Controls.Add(this.dictionaries);
            this.dictionariesPage.Name = "dictionariesPage";
            this.dictionariesPage.Size = new System.Drawing.Size(934, 398);
            this.dictionariesPage.Text = "&Dictionaries";
            // 
            // dictionaries
            // 
            this.dictionaries.Cursor = System.Windows.Forms.Cursors.Default;
            this.dictionaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dictionaries.Location = new System.Drawing.Point(0, 0);
            this.dictionaries.MainView = this.dictionaryView;
            this.dictionaries.Name = "dictionaries";
            this.dictionaries.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.editItem});
            this.dictionaries.Size = new System.Drawing.Size(934, 398);
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
            this.dictionaryNameGridColumn.FieldName = "DictionaryName";
            this.dictionaryNameGridColumn.Name = "dictionaryNameGridColumn";
            this.dictionaryNameGridColumn.Visible = true;
            this.dictionaryNameGridColumn.VisibleIndex = 0;
            this.dictionaryNameGridColumn.Width = 864;
            // 
            // editDictionary
            // 
            this.editDictionary.ColumnEdit = this.editItem;
            this.editDictionary.Name = "editDictionary";
            this.editDictionary.Visible = true;
            this.editDictionary.VisibleIndex = 1;
            this.editDictionary.Width = 52;
            // 
            // editItem
            // 
            this.editItem.AutoHeight = false;
            this.editItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("editItem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.editItem.Name = "editItem";
            this.editItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // settingsTabPanel
            // 
            this.settingsTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.settingsTabPanel.Controls.Add(this.settings);
            this.settingsTabPanel.Location = new System.Drawing.Point(0, 24);
            this.settingsTabPanel.Name = "settingsTabPanel";
            this.settingsTabPanel.Size = new System.Drawing.Size(940, 426);
            this.settingsTabPanel.TabIndex = 1;
            // 
            // SettingsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.settingsTabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsXtraForm";
            this.Text = "Settings";
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
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentPanelControl)).EndInit();
            this.externalDocumentPanelControl.ResumeLayout(false);
            this.externalDocumentPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.usersLayoutControl)).EndInit();
            this.usersLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRootGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAddButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUserLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightUsersButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonUsersEmptySpace)).EndInit();
            this.rolesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersButtonLayoutControl)).EndInit();
            this.usersButtonLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesRootGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleButtonRightEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleAddButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEditLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleButtonDivideEmptySpace)).EndInit();
            this.dictionariesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dictionaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsTabPanel)).EndInit();
            this.settingsTabPanel.ResumeLayout(false);
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
        private DevExpress.XtraEditors.TextEdit externalDocumentSize;
        private DevExpress.XtraEditors.LabelControl externalDocumentLabel;
        private DevExpress.XtraEditors.PanelControl externalDocumentPanelControl;
        private DevExpress.XtraTab.XtraTabPage rolesPage;
        private DevExpress.XtraEditors.SimpleButton roleEditButton;
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
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.GridControl roles;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView rolesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn rolesColId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraLayout.LayoutControl usersLayoutControl;
        private DevExpress.XtraEditors.SimpleButton userEditButton;
        private DevExpress.XtraEditors.SimpleButton userAddButton;
        private DevExpress.XtraGrid.GridControl users;
        private DevExpress.XtraGrid.Views.Grid.GridView usersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraLayout.LayoutControlGroup usersRootGroup;
        private DevExpress.XtraLayout.LayoutControlItem usersAddButtonLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem editUserLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem usersLabel;
        private DevExpress.XtraLayout.EmptySpaceItem rightUsersButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem divideButtonUsersEmptySpace;
        private DevExpress.XtraLayout.LayoutControl usersButtonLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup rolesRootGroup;
        private DevExpress.XtraLayout.LayoutControlItem roleEditLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem roleLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem roleAddButtonLayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem roleButtonRightEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem roleButtonDivideEmptySpace;
        private DevExpress.XtraEditors.PanelControl settingsTabPanel;
    }
}