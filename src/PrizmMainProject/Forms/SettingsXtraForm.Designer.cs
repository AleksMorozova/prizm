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
            this.generalPipeLayout = new DevExpress.XtraLayout.LayoutControl();
            this.addPipeSizeButton = new DevExpress.XtraEditors.SimpleButton();
            this.pipesSizeList = new DevExpress.XtraGrid.GridControl();
            this.pipesSizeListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeSizeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeSize = new DevExpress.XtraEditors.TextEdit();
            this.inspectionOperation = new DevExpress.XtraGrid.GridControl();
            this.inspectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectionCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testSubjectGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.minExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maxExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.boolExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isRequiredGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isRequired = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pipeParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspectionOperationLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeSizeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeSizeEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pipesSizeListLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipesSizeListmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.addPipeSizeButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.addPipeSizeButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.projectPage = new DevExpress.XtraTab.XtraTabPage();
            this.generalProjectLayout = new DevExpress.XtraLayout.LayoutControl();
            this.addPlateManufacturerButton = new DevExpress.XtraEditors.SimpleButton();
            this.plateManufacturer = new DevExpress.XtraEditors.TextEdit();
            this.design = new DevExpress.XtraEditors.TextEdit();
            this.externalDocumentSize = new DevExpress.XtraEditors.TextEdit();
            this.client = new DevExpress.XtraEditors.TextEdit();
            this.plateManufacturersList = new DevExpress.XtraGrid.GridControl();
            this.plateManufacturersListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plateManufacturerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.projectLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.generalProjectParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.clientLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.plateManufacturerLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.designLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.clientEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.plateManufacturersLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.addPlateManufacturerButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.addPlateManufacturerLmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.generalPlateManufacturerEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.technicalProjectParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.externalDocumentSizeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.externalDocumentSizeEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.generalEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
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
            this.settingsTabPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.settings.SuspendLayout();
            this.pipePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalPipeLayout)).BeginInit();
            this.generalPipeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRequired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperationLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPipeSizeButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPipeSizeButtonEmptySpace)).BeginInit();
            this.projectPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalProjectLayout)).BeginInit();
            this.generalProjectLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.design.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalProjectParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturerLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPlateManufacturerButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPlateManufacturerLmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalPlateManufacturerEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalProjectParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalEmptySpace)).BeginInit();
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
            this.settings.Location = new System.Drawing.Point(0, 15);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(5);
            this.settings.SelectedTabPage = this.pipePage;
            this.settings.Size = new System.Drawing.Size(940, 435);
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
            this.pipePage.Controls.Add(this.generalPipeLayout);
            this.pipePage.Name = "pipePage";
            this.pipePage.Size = new System.Drawing.Size(934, 407);
            this.pipePage.Text = "Pip&e";
            // 
            // generalPipeLayout
            // 
            this.generalPipeLayout.Controls.Add(this.addPipeSizeButton);
            this.generalPipeLayout.Controls.Add(this.pipesSizeList);
            this.generalPipeLayout.Controls.Add(this.pipeSize);
            this.generalPipeLayout.Controls.Add(this.inspectionOperation);
            this.generalPipeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalPipeLayout.Location = new System.Drawing.Point(0, 0);
            this.generalPipeLayout.Name = "generalPipeLayout";
            this.generalPipeLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(346, 216, 250, 350);
            this.generalPipeLayout.Root = this.pipeParametersLayoutGroup;
            this.generalPipeLayout.Size = new System.Drawing.Size(934, 407);
            this.generalPipeLayout.TabIndex = 10;
            this.generalPipeLayout.Text = "layoutControl2";
            // 
            // addPipeSizeButton
            // 
            this.addPipeSizeButton.Location = new System.Drawing.Point(345, 31);
            this.addPipeSizeButton.Name = "addPipeSizeButton";
            this.addPipeSizeButton.Size = new System.Drawing.Size(105, 22);
            this.addPipeSizeButton.StyleController = this.generalPipeLayout;
            this.addPipeSizeButton.TabIndex = 12;
            this.addPipeSizeButton.Text = "Добавить";
            // 
            // pipesSizeList
            // 
            this.pipesSizeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipesSizeList.Location = new System.Drawing.Point(17, 83);
            this.pipesSizeList.MainView = this.pipesSizeListGridView;
            this.pipesSizeList.Name = "pipesSizeList";
            this.pipesSizeList.Size = new System.Drawing.Size(433, 67);
            this.pipesSizeList.TabIndex = 11;
            this.pipesSizeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipesSizeListGridView});
            // 
            // pipesSizeListGridView
            // 
            this.pipesSizeListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeSizeGridColumn});
            this.pipesSizeListGridView.GridControl = this.pipesSizeList;
            this.pipesSizeListGridView.Name = "pipesSizeListGridView";
            this.pipesSizeListGridView.OptionsView.ShowGroupPanel = false;
            // 
            // pipeSizeGridColumn
            // 
            this.pipeSizeGridColumn.Caption = "Типоразмер";
            this.pipeSizeGridColumn.Name = "pipeSizeGridColumn";
            this.pipeSizeGridColumn.Visible = true;
            this.pipeSizeGridColumn.VisibleIndex = 0;
            // 
            // pipeSize
            // 
            this.pipeSize.Location = new System.Drawing.Point(17, 33);
            this.pipeSize.Name = "pipeSize";
            this.pipeSize.Size = new System.Drawing.Size(319, 20);
            this.pipeSize.StyleController = this.generalPipeLayout;
            this.pipeSize.TabIndex = 10;
            // 
            // inspectionOperation
            // 
            this.inspectionOperation.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspectionOperation.DataSource = this.inspectionBindingSource;
            this.inspectionOperation.Location = new System.Drawing.Point(17, 180);
            this.inspectionOperation.MainView = this.inspectionView;
            this.inspectionOperation.Name = "inspectionOperation";
            this.inspectionOperation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isRequired});
            this.inspectionOperation.Size = new System.Drawing.Size(895, 205);
            this.inspectionOperation.TabIndex = 9;
            this.inspectionOperation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionView});
            // 
            // inspectionBindingSource
            // 
            this.inspectionBindingSource.DataSource = typeof(PrizmMain.DummyData.Inspection);
            // 
            // inspectionView
            // 
            this.inspectionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectionCodeGridColumn,
            this.inspectionNameGridColumn,
            this.testSubjectGridColumn,
            this.controlTypeGridColumn,
            this.resultTypeGridColumn,
            this.minExpectedGridColumn,
            this.maxExpectedGridColumn,
            this.boolExpectedGridColumn,
            this.isRequiredGridColumn});
            this.inspectionView.GridControl = this.inspectionOperation;
            this.inspectionView.Name = "inspectionView";
            this.inspectionView.OptionsView.ShowGroupPanel = false;
            // 
            // inspectionCodeGridColumn
            // 
            this.inspectionCodeGridColumn.Caption = "Код операции";
            this.inspectionCodeGridColumn.FieldName = "Code";
            this.inspectionCodeGridColumn.Name = "inspectionCodeGridColumn";
            this.inspectionCodeGridColumn.Visible = true;
            this.inspectionCodeGridColumn.VisibleIndex = 0;
            // 
            // inspectionNameGridColumn
            // 
            this.inspectionNameGridColumn.Caption = "Название операции";
            this.inspectionNameGridColumn.FieldName = "Name";
            this.inspectionNameGridColumn.Name = "inspectionNameGridColumn";
            this.inspectionNameGridColumn.Visible = true;
            this.inspectionNameGridColumn.VisibleIndex = 1;
            // 
            // testSubjectGridColumn
            // 
            this.testSubjectGridColumn.Caption = "Объект инспекции";
            this.testSubjectGridColumn.FieldName = "TestSubject";
            this.testSubjectGridColumn.Name = "testSubjectGridColumn";
            this.testSubjectGridColumn.Visible = true;
            this.testSubjectGridColumn.VisibleIndex = 2;
            // 
            // controlTypeGridColumn
            // 
            this.controlTypeGridColumn.Caption = "Вид контроля";
            this.controlTypeGridColumn.FieldName = "ControlType";
            this.controlTypeGridColumn.Name = "controlTypeGridColumn";
            this.controlTypeGridColumn.Visible = true;
            this.controlTypeGridColumn.VisibleIndex = 3;
            // 
            // resultTypeGridColumn
            // 
            this.resultTypeGridColumn.Caption = "Тип результата";
            this.resultTypeGridColumn.FieldName = "ResultType";
            this.resultTypeGridColumn.Name = "resultTypeGridColumn";
            this.resultTypeGridColumn.Visible = true;
            this.resultTypeGridColumn.VisibleIndex = 4;
            // 
            // minExpectedGridColumn
            // 
            this.minExpectedGridColumn.Caption = "min";
            this.minExpectedGridColumn.FieldName = "MinExpected";
            this.minExpectedGridColumn.Name = "minExpectedGridColumn";
            this.minExpectedGridColumn.Visible = true;
            this.minExpectedGridColumn.VisibleIndex = 5;
            // 
            // maxExpectedGridColumn
            // 
            this.maxExpectedGridColumn.Caption = "max";
            this.maxExpectedGridColumn.FieldName = "MaxExpected";
            this.maxExpectedGridColumn.Name = "maxExpectedGridColumn";
            this.maxExpectedGridColumn.Visible = true;
            this.maxExpectedGridColumn.VisibleIndex = 6;
            // 
            // boolExpectedGridColumn
            // 
            this.boolExpectedGridColumn.Caption = "Контрольное значение";
            this.boolExpectedGridColumn.FieldName = "BollExpected";
            this.boolExpectedGridColumn.Name = "boolExpectedGridColumn";
            this.boolExpectedGridColumn.Visible = true;
            this.boolExpectedGridColumn.VisibleIndex = 7;
            // 
            // isRequiredGridColumn
            // 
            this.isRequiredGridColumn.Caption = "Обязательна для отгрузки";
            this.isRequiredGridColumn.ColumnEdit = this.isRequired;
            this.isRequiredGridColumn.FieldName = "IsRequired";
            this.isRequiredGridColumn.Name = "isRequiredGridColumn";
            this.isRequiredGridColumn.Visible = true;
            this.isRequiredGridColumn.VisibleIndex = 8;
            this.isRequiredGridColumn.Width = 93;
            // 
            // isRequired
            // 
            this.isRequired.AutoHeight = false;
            this.isRequired.Name = "isRequired";
            // 
            // pipeParametersLayoutGroup
            // 
            this.pipeParametersLayoutGroup.CustomizationFormText = "pipeParametersLayoutGroup";
            this.pipeParametersLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.pipeParametersLayoutGroup.GroupBordersVisible = false;
            this.pipeParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectionOperationLayout,
            this.pipeSizeLayout,
            this.pipeSizeEmptySpace,
            this.pipesSizeListLayout,
            this.pipesSizeListmptySpace,
            this.addPipeSizeButtonLayout,
            this.addPipeSizeButtonEmptySpace});
            this.pipeParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.pipeParametersLayoutGroup.Name = "pipeParametersLayoutGroup";
            this.pipeParametersLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 10, 10, 10);
            this.pipeParametersLayoutGroup.Size = new System.Drawing.Size(934, 407);
            this.pipeParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.pipeParametersLayoutGroup.Text = "pipeParametersLayoutGroup";
            this.pipeParametersLayoutGroup.TextVisible = false;
            // 
            // inspectionOperationLayout
            // 
            this.inspectionOperationLayout.Control = this.inspectionOperation;
            this.inspectionOperationLayout.CustomizationFormText = "Список контрольных операций:";
            this.inspectionOperationLayout.Location = new System.Drawing.Point(0, 142);
            this.inspectionOperationLayout.Name = "inspectionOperationLayout";
            this.inspectionOperationLayout.Size = new System.Drawing.Size(909, 235);
            this.inspectionOperationLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.inspectionOperationLayout.Text = "Список контрольных операций для выбранного типоразмера:";
            this.inspectionOperationLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectionOperationLayout.TextSize = new System.Drawing.Size(316, 13);
            // 
            // pipeSizeLayout
            // 
            this.pipeSizeLayout.Control = this.pipeSize;
            this.pipeSizeLayout.CustomizationFormText = "Типоразмер труб:";
            this.pipeSizeLayout.Location = new System.Drawing.Point(0, 0);
            this.pipeSizeLayout.Name = "pipeSizeLayout";
            this.pipeSizeLayout.Size = new System.Drawing.Size(328, 45);
            this.pipeSizeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 5);
            this.pipeSizeLayout.Text = "Типоразмер труб:";
            this.pipeSizeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeSizeLayout.TextSize = new System.Drawing.Size(316, 13);
            // 
            // pipeSizeEmptySpace
            // 
            this.pipeSizeEmptySpace.AllowHotTrack = false;
            this.pipeSizeEmptySpace.CustomizationFormText = "pipeSizeEmptySpace";
            this.pipeSizeEmptySpace.Location = new System.Drawing.Point(447, 0);
            this.pipeSizeEmptySpace.Name = "pipeSizeEmptySpace";
            this.pipeSizeEmptySpace.Size = new System.Drawing.Size(462, 45);
            this.pipeSizeEmptySpace.Text = "pipeSizeEmptySpace";
            this.pipeSizeEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pipesSizeListLayout
            // 
            this.pipesSizeListLayout.Control = this.pipesSizeList;
            this.pipesSizeListLayout.CustomizationFormText = "Список типоразмеров";
            this.pipesSizeListLayout.Location = new System.Drawing.Point(0, 45);
            this.pipesSizeListLayout.Name = "pipesSizeListLayout";
            this.pipesSizeListLayout.Size = new System.Drawing.Size(447, 97);
            this.pipesSizeListLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.pipesSizeListLayout.Text = "Список типоразмеров";
            this.pipesSizeListLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipesSizeListLayout.TextSize = new System.Drawing.Size(316, 13);
            // 
            // pipesSizeListmptySpace
            // 
            this.pipesSizeListmptySpace.AllowHotTrack = false;
            this.pipesSizeListmptySpace.CustomizationFormText = "pipesSizeListmptySpace";
            this.pipesSizeListmptySpace.Location = new System.Drawing.Point(447, 45);
            this.pipesSizeListmptySpace.Name = "pipesSizeListmptySpace";
            this.pipesSizeListmptySpace.Size = new System.Drawing.Size(462, 97);
            this.pipesSizeListmptySpace.Text = "pipesSizeListmptySpace";
            this.pipesSizeListmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // addPipeSizeButtonLayout
            // 
            this.addPipeSizeButtonLayout.Control = this.addPipeSizeButton;
            this.addPipeSizeButtonLayout.CustomizationFormText = "addPipeSizeButtonLayout";
            this.addPipeSizeButtonLayout.Location = new System.Drawing.Point(328, 14);
            this.addPipeSizeButtonLayout.Name = "addPipeSizeButtonLayout";
            this.addPipeSizeButtonLayout.Size = new System.Drawing.Size(119, 31);
            this.addPipeSizeButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 5);
            this.addPipeSizeButtonLayout.Text = "addPipeSizeButtonLayout";
            this.addPipeSizeButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.addPipeSizeButtonLayout.TextToControlDistance = 0;
            this.addPipeSizeButtonLayout.TextVisible = false;
            // 
            // addPipeSizeButtonEmptySpace
            // 
            this.addPipeSizeButtonEmptySpace.AllowHotTrack = false;
            this.addPipeSizeButtonEmptySpace.CustomizationFormText = "addPipeSizeButtonEmptySpace";
            this.addPipeSizeButtonEmptySpace.Location = new System.Drawing.Point(328, 0);
            this.addPipeSizeButtonEmptySpace.Name = "addPipeSizeButtonEmptySpace";
            this.addPipeSizeButtonEmptySpace.Size = new System.Drawing.Size(119, 14);
            this.addPipeSizeButtonEmptySpace.Text = "addPipeSizeButtonEmptySpace";
            this.addPipeSizeButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // projectPage
            // 
            this.projectPage.Controls.Add(this.generalProjectLayout);
            this.projectPage.Name = "projectPage";
            this.projectPage.Size = new System.Drawing.Size(934, 407);
            this.projectPage.Text = "Project";
            // 
            // generalProjectLayout
            // 
            this.generalProjectLayout.Controls.Add(this.addPlateManufacturerButton);
            this.generalProjectLayout.Controls.Add(this.plateManufacturer);
            this.generalProjectLayout.Controls.Add(this.design);
            this.generalProjectLayout.Controls.Add(this.externalDocumentSize);
            this.generalProjectLayout.Controls.Add(this.client);
            this.generalProjectLayout.Controls.Add(this.plateManufacturersList);
            this.generalProjectLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.generalProjectLayout.Location = new System.Drawing.Point(0, 0);
            this.generalProjectLayout.Name = "generalProjectLayout";
            this.generalProjectLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(502, 203, 250, 350);
            this.generalProjectLayout.Root = this.projectLayoutGroup;
            this.generalProjectLayout.Size = new System.Drawing.Size(845, 407);
            this.generalProjectLayout.TabIndex = 16;
            this.generalProjectLayout.Text = "layoutControl1";
            // 
            // addPlateManufacturerButton
            // 
            this.addPlateManufacturerButton.Location = new System.Drawing.Point(276, 120);
            this.addPlateManufacturerButton.Name = "addPlateManufacturerButton";
            this.addPlateManufacturerButton.Size = new System.Drawing.Size(85, 22);
            this.addPlateManufacturerButton.StyleController = this.generalProjectLayout;
            this.addPlateManufacturerButton.TabIndex = 15;
            this.addPlateManufacturerButton.Text = "Добавить";
            // 
            // plateManufacturer
            // 
            this.plateManufacturer.Location = new System.Drawing.Point(32, 122);
            this.plateManufacturer.Name = "plateManufacturer";
            this.plateManufacturer.Size = new System.Drawing.Size(228, 20);
            this.plateManufacturer.StyleController = this.generalProjectLayout;
            this.plateManufacturer.TabIndex = 14;
            // 
            // design
            // 
            this.design.Location = new System.Drawing.Point(276, 62);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(228, 20);
            this.design.StyleController = this.generalProjectLayout;
            this.design.TabIndex = 13;
            // 
            // externalDocumentSize
            // 
            this.externalDocumentSize.EditValue = "1024";
            this.externalDocumentSize.Location = new System.Drawing.Point(579, 64);
            this.externalDocumentSize.Name = "externalDocumentSize";
            this.externalDocumentSize.Size = new System.Drawing.Size(172, 20);
            this.externalDocumentSize.StyleController = this.generalProjectLayout;
            this.externalDocumentSize.TabIndex = 3;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(32, 62);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(228, 20);
            this.client.StyleController = this.generalProjectLayout;
            this.client.TabIndex = 12;
            // 
            // plateManufacturersList
            // 
            this.plateManufacturersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plateManufacturersList.Cursor = System.Windows.Forms.Cursors.Default;
            this.plateManufacturersList.Location = new System.Drawing.Point(34, 172);
            this.plateManufacturersList.MainView = this.plateManufacturersListView;
            this.plateManufacturersList.Name = "plateManufacturersList";
            this.plateManufacturersList.Size = new System.Drawing.Size(495, 201);
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
            this.plateManufacturersListView.OptionsView.ShowGroupPanel = false;
            // 
            // plateManufacturerGridColumn
            // 
            this.plateManufacturerGridColumn.Caption = "Manufacture";
            this.plateManufacturerGridColumn.Name = "plateManufacturerGridColumn";
            this.plateManufacturerGridColumn.Visible = true;
            this.plateManufacturerGridColumn.VisibleIndex = 0;
            // 
            // projectLayoutGroup
            // 
            this.projectLayoutGroup.CustomizationFormText = "projectLayoutGroup";
            this.projectLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.projectLayoutGroup.GroupBordersVisible = false;
            this.projectLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.generalProjectParametersLayoutGroup,
            this.technicalProjectParametersLayoutGroup,
            this.generalEmptySpace});
            this.projectLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.projectLayoutGroup.Name = "projectLayoutGroup";
            this.projectLayoutGroup.Size = new System.Drawing.Size(845, 407);
            this.projectLayoutGroup.Text = "projectLayoutGroup";
            this.projectLayoutGroup.TextVisible = false;
            // 
            // generalProjectParametersLayoutGroup
            // 
            this.generalProjectParametersLayoutGroup.CustomizationFormText = "Общие параметры проекта";
            this.generalProjectParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.clientLayout,
            this.plateManufacturerLayout,
            this.designLayout,
            this.clientEmptySpace,
            this.plateManufacturersLayout,
            this.addPlateManufacturerButtonLayout,
            this.addPlateManufacturerLmptySpace,
            this.generalPlateManufacturerEmptySpace});
            this.generalProjectParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalProjectParametersLayoutGroup.Name = "generalProjectParametersLayoutGroup";
            this.generalProjectParametersLayoutGroup.Size = new System.Drawing.Size(540, 387);
            this.generalProjectParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 2, 5, 7);
            this.generalProjectParametersLayoutGroup.Text = "Общие параметры проекта";
            // 
            // clientLayout
            // 
            this.clientLayout.Control = this.client;
            this.clientLayout.CustomizationFormText = "Заказчик";
            this.clientLayout.Location = new System.Drawing.Point(0, 0);
            this.clientLayout.Name = "clientLayout";
            this.clientLayout.Size = new System.Drawing.Size(244, 40);
            this.clientLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 0);
            this.clientLayout.Text = "Заказчик";
            this.clientLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.clientLayout.TextSize = new System.Drawing.Size(172, 13);
            // 
            // plateManufacturerLayout
            // 
            this.plateManufacturerLayout.Control = this.plateManufacturer;
            this.plateManufacturerLayout.CustomizationFormText = "Производитель";
            this.plateManufacturerLayout.Location = new System.Drawing.Point(0, 40);
            this.plateManufacturerLayout.Name = "plateManufacturerLayout";
            this.plateManufacturerLayout.Size = new System.Drawing.Size(244, 60);
            this.plateManufacturerLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 20, 0);
            this.plateManufacturerLayout.Text = "Производитель листов";
            this.plateManufacturerLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateManufacturerLayout.TextSize = new System.Drawing.Size(172, 13);
            // 
            // designLayout
            // 
            this.designLayout.Control = this.design;
            this.designLayout.CustomizationFormText = "Производитель";
            this.designLayout.Location = new System.Drawing.Point(244, 0);
            this.designLayout.Name = "designLayout";
            this.designLayout.Size = new System.Drawing.Size(244, 40);
            this.designLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 0);
            this.designLayout.Text = "Производитель";
            this.designLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.designLayout.TextSize = new System.Drawing.Size(172, 13);
            // 
            // clientEmptySpace
            // 
            this.clientEmptySpace.AllowHotTrack = false;
            this.clientEmptySpace.CustomizationFormText = "clientEmptySpace";
            this.clientEmptySpace.Location = new System.Drawing.Point(488, 0);
            this.clientEmptySpace.Name = "clientEmptySpace";
            this.clientEmptySpace.Size = new System.Drawing.Size(25, 40);
            this.clientEmptySpace.Text = "clientEmptySpace";
            this.clientEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // plateManufacturersLayout
            // 
            this.plateManufacturersLayout.Control = this.plateManufacturersList;
            this.plateManufacturersLayout.CustomizationFormText = "производители листов";
            this.plateManufacturersLayout.Location = new System.Drawing.Point(0, 100);
            this.plateManufacturersLayout.Name = "plateManufacturersLayout";
            this.plateManufacturersLayout.Size = new System.Drawing.Size(513, 236);
            this.plateManufacturersLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 10, 5);
            this.plateManufacturersLayout.Text = "Производители листов";
            this.plateManufacturersLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateManufacturersLayout.TextSize = new System.Drawing.Size(172, 13);
            // 
            // addPlateManufacturerButtonLayout
            // 
            this.addPlateManufacturerButtonLayout.Control = this.addPlateManufacturerButton;
            this.addPlateManufacturerButtonLayout.CustomizationFormText = "addPlateManufacturerButtonLayout";
            this.addPlateManufacturerButtonLayout.Location = new System.Drawing.Point(244, 69);
            this.addPlateManufacturerButtonLayout.Name = "addPlateManufacturerButtonLayout";
            this.addPlateManufacturerButtonLayout.Size = new System.Drawing.Size(104, 31);
            this.addPlateManufacturerButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 10, 5, 0);
            this.addPlateManufacturerButtonLayout.Text = "addPlateManufacturerButtonLayout";
            this.addPlateManufacturerButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.addPlateManufacturerButtonLayout.TextToControlDistance = 0;
            this.addPlateManufacturerButtonLayout.TextVisible = false;
            // 
            // addPlateManufacturerLmptySpace
            // 
            this.addPlateManufacturerLmptySpace.AllowHotTrack = false;
            this.addPlateManufacturerLmptySpace.CustomizationFormText = "addPlateManufacturerLmptySpace";
            this.addPlateManufacturerLmptySpace.Location = new System.Drawing.Point(244, 40);
            this.addPlateManufacturerLmptySpace.Name = "addPlateManufacturerLmptySpace";
            this.addPlateManufacturerLmptySpace.Size = new System.Drawing.Size(104, 29);
            this.addPlateManufacturerLmptySpace.Text = "addPlateManufacturerLmptySpace";
            this.addPlateManufacturerLmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // generalPlateManufacturerEmptySpace
            // 
            this.generalPlateManufacturerEmptySpace.AllowHotTrack = false;
            this.generalPlateManufacturerEmptySpace.CustomizationFormText = "generalPlateManufacturerEmptySpace";
            this.generalPlateManufacturerEmptySpace.Location = new System.Drawing.Point(348, 40);
            this.generalPlateManufacturerEmptySpace.Name = "generalPlateManufacturerEmptySpace";
            this.generalPlateManufacturerEmptySpace.Size = new System.Drawing.Size(165, 60);
            this.generalPlateManufacturerEmptySpace.Text = "generalPlateManufacturerEmptySpace";
            this.generalPlateManufacturerEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // technicalProjectParametersLayoutGroup
            // 
            this.technicalProjectParametersLayoutGroup.CustomizationFormText = "Технические параметры проекта";
            this.technicalProjectParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.externalDocumentSizeLayout,
            this.externalDocumentSizeEmptySpace});
            this.technicalProjectParametersLayoutGroup.Location = new System.Drawing.Point(540, 0);
            this.technicalProjectParametersLayoutGroup.Name = "technicalProjectParametersLayoutGroup";
            this.technicalProjectParametersLayoutGroup.Size = new System.Drawing.Size(285, 96);
            this.technicalProjectParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 5, 7, 5);
            this.technicalProjectParametersLayoutGroup.Text = "Технические параметры проекта";
            // 
            // externalDocumentSizeLayout
            // 
            this.externalDocumentSizeLayout.Control = this.externalDocumentSize;
            this.externalDocumentSizeLayout.CustomizationFormText = "External document size limit, Kbytes";
            this.externalDocumentSizeLayout.Location = new System.Drawing.Point(0, 0);
            this.externalDocumentSizeLayout.Name = "externalDocumentSizeLayout";
            this.externalDocumentSizeLayout.Size = new System.Drawing.Size(183, 45);
            this.externalDocumentSizeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 0, 0, 5);
            this.externalDocumentSizeLayout.Text = "External document size limit, Kbytes";
            this.externalDocumentSizeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.externalDocumentSizeLayout.TextSize = new System.Drawing.Size(172, 13);
            // 
            // externalDocumentSizeEmptySpace
            // 
            this.externalDocumentSizeEmptySpace.AllowHotTrack = false;
            this.externalDocumentSizeEmptySpace.CustomizationFormText = "externalDocumentSizeEmptySpace";
            this.externalDocumentSizeEmptySpace.Location = new System.Drawing.Point(183, 0);
            this.externalDocumentSizeEmptySpace.Name = "externalDocumentSizeEmptySpace";
            this.externalDocumentSizeEmptySpace.Size = new System.Drawing.Size(67, 45);
            this.externalDocumentSizeEmptySpace.Text = "externalDocumentSizeEmptySpace";
            this.externalDocumentSizeEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // generalEmptySpace
            // 
            this.generalEmptySpace.AllowHotTrack = false;
            this.generalEmptySpace.CustomizationFormText = "generalEmptySpace";
            this.generalEmptySpace.Location = new System.Drawing.Point(540, 96);
            this.generalEmptySpace.Name = "generalEmptySpace";
            this.generalEmptySpace.Size = new System.Drawing.Size(285, 291);
            this.generalEmptySpace.Text = "generalEmptySpace";
            this.generalEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pipelinePage
            // 
            this.pipelinePage.Name = "pipelinePage";
            this.pipelinePage.Size = new System.Drawing.Size(934, 407);
            this.pipelinePage.Text = "Pipe&line";
            // 
            // usersPage
            // 
            this.usersPage.Controls.Add(this.usersLayoutControl);
            this.usersPage.Name = "usersPage";
            this.usersPage.Size = new System.Drawing.Size(934, 407);
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
            this.usersLayoutControl.Size = new System.Drawing.Size(934, 407);
            this.usersLayoutControl.TabIndex = 0;
            this.usersLayoutControl.Text = "UsersLayoutControl";
            // 
            // userEditButton
            // 
            this.userEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userEditButton.Image = ((System.Drawing.Image)(resources.GetObject("userEditButton.Image")));
            this.userEditButton.Location = new System.Drawing.Point(138, 17);
            this.userEditButton.MinimumSize = new System.Drawing.Size(130, 0);
            this.userEditButton.Name = "userEditButton";
            this.userEditButton.Size = new System.Drawing.Size(150, 22);
            this.userEditButton.StyleController = this.usersLayoutControl;
            this.userEditButton.TabIndex = 5;
            this.userEditButton.Text = "Ðåäàêòèðîâàòü";
            this.userEditButton.Click += new System.EventHandler(this.userEditButton_Click);
            // 
            // userAddButton
            // 
            this.userAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userAddButton.Image = ((System.Drawing.Image)(resources.GetObject("userAddButton.Image")));
            this.userAddButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.userAddButton.Location = new System.Drawing.Point(17, 17);
            this.userAddButton.Name = "userAddButton";
            this.userAddButton.Size = new System.Drawing.Size(103, 22);
            this.userAddButton.StyleController = this.usersLayoutControl;
            this.userAddButton.TabIndex = 6;
            this.userAddButton.Text = "Äîáàâèòü";
            // 
            // users
            // 
            this.users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.users.Cursor = System.Windows.Forms.Cursors.Default;
            this.users.DataSource = this.userBindingSource;
            this.users.Location = new System.Drawing.Point(17, 69);
            this.users.MainView = this.usersGridView;
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(900, 321);
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
            this.colId.Caption = "¹";
            this.colId.FieldName = "Id";
            this.colId.MaxWidth = 50;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 50;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Ôàìèëèÿ";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Èìÿ";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            // 
            // colMiddleName
            // 
            this.colMiddleName.Caption = "Îò÷åñòâî";
            this.colMiddleName.FieldName = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 3;
            // 
            // colLogin
            // 
            this.colLogin.Caption = "Ëîãèí";
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 4;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Ïàðîëü";
            this.colPassword.FieldName = "Password";
            this.colPassword.MaxWidth = 50;
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 50;
            // 
            // colRole
            // 
            this.colRole.Caption = "Ðîëü";
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
            this.usersRootGroup.Size = new System.Drawing.Size(934, 407);
            this.usersRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.usersRootGroup.Text = "usersRootGroup";
            this.usersRootGroup.TextVisible = false;
            // 
            // usersAddButtonLayoutControl
            // 
            this.usersAddButtonLayoutControl.Control = this.userAddButton;
            this.usersAddButtonLayoutControl.CustomizationFormText = "usersAddButtonLayoutControl";
            this.usersAddButtonLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.usersAddButtonLayoutControl.MaxSize = new System.Drawing.Size(154, 26);
            this.usersAddButtonLayoutControl.MinSize = new System.Drawing.Size(100, 26);
            this.usersAddButtonLayoutControl.Name = "usersAddButtonLayoutControl";
            this.usersAddButtonLayoutControl.Size = new System.Drawing.Size(107, 26);
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
            this.editUserLayoutControl.Location = new System.Drawing.Point(121, 0);
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
            this.usersLabel.CustomizationFormText = "Ïîëüçîâàòåëè";
            this.usersLabel.Location = new System.Drawing.Point(0, 26);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(904, 351);
            this.usersLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.usersLabel.Text = "Ïîëüçîâàòåëè";
            this.usersLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.usersLabel.TextSize = new System.Drawing.Size(61, 13);
            // 
            // rightUsersButtonEmptySpace
            // 
            this.rightUsersButtonEmptySpace.AllowHotTrack = false;
            this.rightUsersButtonEmptySpace.CustomizationFormText = "rightUsersButtonEmptySpace";
            this.rightUsersButtonEmptySpace.Location = new System.Drawing.Point(275, 0);
            this.rightUsersButtonEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.rightUsersButtonEmptySpace.Name = "rightUsersButtonEmptySpace";
            this.rightUsersButtonEmptySpace.Size = new System.Drawing.Size(629, 26);
            this.rightUsersButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.rightUsersButtonEmptySpace.Text = "rightUsersButtonEmptySpace";
            this.rightUsersButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // divideButtonUsersEmptySpace
            // 
            this.divideButtonUsersEmptySpace.AllowHotTrack = false;
            this.divideButtonUsersEmptySpace.CustomizationFormText = "divideButtonUsersEmptySpace";
            this.divideButtonUsersEmptySpace.Location = new System.Drawing.Point(107, 0);
            this.divideButtonUsersEmptySpace.Name = "divideButtonUsersEmptySpace";
            this.divideButtonUsersEmptySpace.Size = new System.Drawing.Size(14, 26);
            this.divideButtonUsersEmptySpace.Text = "divideButtonUsersEmptySpace";
            this.divideButtonUsersEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // rolesPage
            // 
            this.rolesPage.Controls.Add(this.usersButtonLayoutControl);
            this.rolesPage.Name = "rolesPage";
            this.rolesPage.Size = new System.Drawing.Size(934, 407);
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
            this.usersButtonLayoutControl.Size = new System.Drawing.Size(934, 407);
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
            this.roles.Location = new System.Drawing.Point(17, 76);
            this.roles.MainView = this.rolesGridView;
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(900, 314);
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
            this.rolesColId.Caption = "¹";
            this.rolesColId.FieldName = "Id";
            this.rolesColId.MaxWidth = 50;
            this.rolesColId.Name = "rolesColId";
            this.rolesColId.Visible = true;
            this.rolesColId.VisibleIndex = 0;
            this.rolesColId.Width = 50;
            // 
            // colName
            // 
            this.colName.Caption = "Ðîëü";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Îïèñàíèå";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // roleEditButton
            // 
            this.roleEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roleEditButton.Image = ((System.Drawing.Image)(resources.GetObject("roleEditButton.Image")));
            this.roleEditButton.Location = new System.Drawing.Point(181, 17);
            this.roleEditButton.Name = "roleEditButton";
            this.roleEditButton.Size = new System.Drawing.Size(150, 24);
            this.roleEditButton.StyleController = this.usersButtonLayoutControl;
            this.roleEditButton.TabIndex = 3;
            this.roleEditButton.Text = "Ðåäàêòèðîâàòü";
            this.roleEditButton.Click += new System.EventHandler(this.editRoleButton_Click);
            // 
            // roleAddButton
            // 
            this.roleAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roleAddButton.Image = ((System.Drawing.Image)(resources.GetObject("roleAddButton.Image")));
            this.roleAddButton.Location = new System.Drawing.Point(17, 17);
            this.roleAddButton.Name = "roleAddButton";
            this.roleAddButton.Size = new System.Drawing.Size(150, 24);
            this.roleAddButton.StyleController = this.usersButtonLayoutControl;
            this.roleAddButton.TabIndex = 4;
            this.roleAddButton.Text = "Äîáàâèòü";
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
            this.rolesRootGroup.Size = new System.Drawing.Size(934, 407);
            this.rolesRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.rolesRootGroup.Text = "rolesRootGroup";
            this.rolesRootGroup.TextVisible = false;
            // 
            // roleLayoutControl
            // 
            this.roleLayoutControl.Control = this.roles;
            this.roleLayoutControl.CustomizationFormText = "Ðîëè";
            this.roleLayoutControl.Location = new System.Drawing.Point(0, 28);
            this.roleLayoutControl.MinSize = new System.Drawing.Size(104, 40);
            this.roleLayoutControl.Name = "roleLayoutControl";
            this.roleLayoutControl.Size = new System.Drawing.Size(904, 349);
            this.roleLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.roleLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 15, 0);
            this.roleLayoutControl.Text = "Ðîëè";
            this.roleLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.roleLayoutControl.TextSize = new System.Drawing.Size(22, 13);
            // 
            // roleButtonRightEmptySpace
            // 
            this.roleButtonRightEmptySpace.AllowHotTrack = false;
            this.roleButtonRightEmptySpace.CustomizationFormText = "roleButtonRightEmptySpace";
            this.roleButtonRightEmptySpace.Location = new System.Drawing.Point(318, 0);
            this.roleButtonRightEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.roleButtonRightEmptySpace.Name = "roleButtonRightEmptySpace";
            this.roleButtonRightEmptySpace.Size = new System.Drawing.Size(586, 28);
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
            this.dictionariesPage.Size = new System.Drawing.Size(934, 407);
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
            this.dictionaries.Size = new System.Drawing.Size(934, 407);
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
            this.dictionaryView.OptionsView.ShowGroupPanel = false;
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
            // settingsTabPanel
            // 
            this.settingsTabPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.settingsTabPanel.Controls.Add(this.settings);
            this.settingsTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTabPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsTabPanel.Name = "settingsTabPanel";
            this.settingsTabPanel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.settingsTabPanel.Size = new System.Drawing.Size(940, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.generalPipeLayout)).EndInit();
            this.generalPipeLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRequired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperationLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPipeSizeButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPipeSizeButtonEmptySpace)).EndInit();
            this.projectPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generalProjectLayout)).EndInit();
            this.generalProjectLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.design.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalProjectParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturerLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPlateManufacturerButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPlateManufacturerLmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalPlateManufacturerEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalProjectParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalEmptySpace)).EndInit();
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
        private DevExpress.XtraTab.XtraTabPage usersPage;
        private DevExpress.XtraTab.XtraTabPage dictionariesPage;
        private DevExpress.XtraGrid.GridControl dictionaries;
        private DevExpress.XtraGrid.Views.Grid.GridView dictionaryView;
        private DevExpress.XtraGrid.Columns.GridColumn dictionaryNameGridColumn;
        public DevExpress.XtraTab.XtraTabControl settings;
        private DevExpress.XtraTab.XtraTabPage projectPage;
        private DevExpress.XtraGrid.GridControl plateManufacturersList;
        private DevExpress.XtraGrid.Views.Grid.GridView plateManufacturersListView;
        private DevExpress.XtraGrid.Columns.GridColumn plateManufacturerGridColumn;
        private DevExpress.XtraEditors.TextEdit design;
        private DevExpress.XtraEditors.TextEdit client;
        private DevExpress.XtraEditors.TextEdit externalDocumentSize;
        private DevExpress.XtraTab.XtraTabPage rolesPage;
        private DevExpress.XtraEditors.SimpleButton roleEditButton;
        private DevExpress.XtraEditors.SimpleButton roleAddButton;
        private DevExpress.XtraGrid.Columns.GridColumn editDictionary;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit editItem;
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
        private DevExpress.XtraGrid.GridControl inspectionOperation;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionCodeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testSubjectGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn controlTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn resultTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn minExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn maxExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn boolExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isRequiredGridColumn;
        private DevExpress.XtraLayout.LayoutControl generalProjectLayout;
        private DevExpress.XtraLayout.LayoutControlGroup projectLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem plateManufacturersLayout;
        private DevExpress.XtraLayout.LayoutControlItem externalDocumentSizeLayout;
        private DevExpress.XtraLayout.LayoutControlItem clientLayout;
        private DevExpress.XtraLayout.LayoutControlItem designLayout;
        private DevExpress.XtraLayout.EmptySpaceItem generalEmptySpace;
        private DevExpress.XtraLayout.LayoutControlGroup technicalProjectParametersLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem externalDocumentSizeEmptySpace;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isRequired;
        private DevExpress.XtraEditors.SimpleButton addPlateManufacturerButton;
        private DevExpress.XtraEditors.TextEdit plateManufacturer;
        private DevExpress.XtraLayout.LayoutControlItem plateManufacturerLayout;
        private DevExpress.XtraLayout.LayoutControlItem addPlateManufacturerButtonLayout;
        private DevExpress.XtraLayout.LayoutControlGroup generalProjectParametersLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem clientEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem addPlateManufacturerLmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem generalPlateManufacturerEmptySpace;
        private DevExpress.XtraLayout.LayoutControl generalPipeLayout;
        private DevExpress.XtraEditors.TextEdit pipeSize;
        private DevExpress.XtraLayout.LayoutControlGroup pipeParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem inspectionOperationLayout;
        private DevExpress.XtraLayout.LayoutControlItem pipeSizeLayout;
        private DevExpress.XtraLayout.EmptySpaceItem pipeSizeEmptySpace;
        private System.Windows.Forms.BindingSource inspectionBindingSource;
        private DevExpress.XtraEditors.SimpleButton addPipeSizeButton;
        private DevExpress.XtraGrid.GridControl pipesSizeList;
        private DevExpress.XtraGrid.Views.Grid.GridView pipesSizeListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeGridColumn;
        private DevExpress.XtraLayout.LayoutControlItem pipesSizeListLayout;
        private DevExpress.XtraLayout.EmptySpaceItem pipesSizeListmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem addPipeSizeButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem addPipeSizeButtonEmptySpace;
    }
}