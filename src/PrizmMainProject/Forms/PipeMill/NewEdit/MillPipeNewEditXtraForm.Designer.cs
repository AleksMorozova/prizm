namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    partial class MillPipeNewEditXtraForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MillPipeNewEditXtraForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.Utils.Animation.FadeTransition fadeTransition1 = new DevExpress.Utils.Animation.FadeTransition();
            this.weldersListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.firstNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weldingHistory = new DevExpress.XtraGrid.GridControl();
            this.weldBindingSource = new System.Windows.Forms.BindingSource();
            this.weldingHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.weldingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weldersGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPopupWelders = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.weldersDataSource = new System.Windows.Forms.BindingSource();
            this.steelGrade = new DevExpress.XtraEditors.TextEdit();
            this.generalPipeLayout = new DevExpress.XtraLayout.LayoutControl();
            this.pipeLength = new DevExpress.XtraEditors.TextEdit();
            this.inspections = new DevExpress.XtraGrid.GridControl();
            this.inspectionOperation = new System.Windows.Forms.BindingSource();
            this.inspectionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectionNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expectedResultGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.valueGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testResultValue = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.inspectionResultGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultStatusLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.inspectorsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorsPopupContainerEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.controlDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionCodeLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoryGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plateThickness = new DevExpress.XtraEditors.TextEdit();
            this.plateNumber = new DevExpress.XtraEditors.TextEdit();
            this.shippedDate = new DevExpress.XtraEditors.TextEdit();
            this.ordersLookUp = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.heatsLookUp = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.heatsNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.destination = new DevExpress.XtraEditors.TextEdit();
            this.purchaseOrderDate = new DevExpress.XtraEditors.TextEdit();
            this.railcarNumber = new DevExpress.XtraEditors.TextEdit();
            this.saveAndNewButton = new DevExpress.XtraEditors.SimpleButton();
            this.coatingHistory = new DevExpress.XtraGrid.GridControl();
            this.coatDataSource = new System.Windows.Forms.BindingSource();
            this.coatingHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coatingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coatingTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditCoatType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.deactivated = new DevExpress.XtraEditors.CheckEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.diameter = new DevExpress.XtraEditors.TextEdit();
            this.attachmentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.length = new DevExpress.XtraEditors.TextEdit();
            this.weight = new DevExpress.XtraEditors.TextEdit();
            this.pipeCreationDate = new DevExpress.XtraEditors.DateEdit();
            this.thickness = new DevExpress.XtraEditors.TextEdit();
            this.pipeNumber = new DevExpress.XtraEditors.TextEdit();
            this.plateManufacturer = new DevExpress.XtraEditors.TextEdit();
            this.pipeSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.millStatus = new DevExpress.XtraEditors.TextEdit();
            this.generalLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipeNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeSizeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.creationDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.purchaseOrderDateLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.heatsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.ordersLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.attachmentsButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.deactivateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.footerEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.saveButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveNewLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.pipeTabLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.plateLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.plateNumberLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.plateManufacturerLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.plateThicknessLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.steelGradeLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.coverLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.coatsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.shippingLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.railcarLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.destinationLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.shippedDateLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldsLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.weldsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.factSizeLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.weightLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeLengthLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.typeSizeaParametersLyoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lengthLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.diameterLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.thicknessLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectionsTabLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspectionsGridLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.plateNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.weldingDs = new System.Windows.Forms.BindingSource();
            this.pipeNewEditBindingSource = new System.Windows.Forms.BindingSource();
            this.inspectorsDataSource = new System.Windows.Forms.BindingSource();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.workspaceManager = new DevExpress.Utils.WorkspaceManager();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.weldersListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupWelders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalPipeLayout)).BeginInit();
            this.generalPipeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultStatusLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsPopupContainerEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionCodeLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatsLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destination.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCoatType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactivated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeCreationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeCreationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creationDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDateLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatsLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactivateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerEmptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveNewLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTabLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumberLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturerLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateThicknessLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGradeLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDateLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldsLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factSizeLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLengthLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSizeaParametersLyoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsTabLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsGridLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNewEditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // weldersListGridView
            // 
            this.weldersListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.firstNameGridColumn,
            this.lastNameGridColumn});
            this.weldersListGridView.GridControl = this.weldingHistory;
            this.weldersListGridView.Name = "weldersListGridView";
            // 
            // firstNameGridColumn
            // 
            this.firstNameGridColumn.Caption = "Имя";
            this.firstNameGridColumn.FieldName = "Name";
            this.firstNameGridColumn.Name = "firstNameGridColumn";
            this.firstNameGridColumn.Visible = true;
            this.firstNameGridColumn.VisibleIndex = 0;
            // 
            // lastNameGridColumn
            // 
            this.lastNameGridColumn.Caption = "Фамилия";
            this.lastNameGridColumn.FieldName = "LastName";
            this.lastNameGridColumn.Name = "lastNameGridColumn";
            this.lastNameGridColumn.Visible = true;
            this.lastNameGridColumn.VisibleIndex = 1;
            // 
            // weldingHistory
            // 
            this.weldingHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.weldingHistory.DataSource = this.weldBindingSource;
            this.weldingHistory.Location = new System.Drawing.Point(448, 277);
            this.weldingHistory.MainView = this.weldingHistoryGridView;
            this.weldingHistory.Name = "weldingHistory";
            this.weldingHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPopupWelders});
            this.weldingHistory.Size = new System.Drawing.Size(796, 206);
            this.weldingHistory.TabIndex = 40;
            this.weldingHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.weldingHistoryGridView,
            this.weldersListGridView});
            // 
            // weldBindingSource
            // 
            this.weldBindingSource.DataSource = typeof(Prizm.Domain.Entity.Mill.Weld);
            // 
            // weldingHistoryGridView
            // 
            this.weldingHistoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.weldingDateGridColumn,
            this.weldersGridColumn});
            this.weldingHistoryGridView.GridControl = this.weldingHistory;
            this.weldingHistoryGridView.Name = "weldingHistoryGridView";
            this.weldingHistoryGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.weldingHistoryGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.weldingHistoryGridView.OptionsNavigation.UseTabKey = false;
            this.weldingHistoryGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.weldingHistoryGridView.OptionsView.ShowGroupPanel = false;
            this.weldingHistoryGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.weldingHistoryGridView_InitNewRow);
            this.weldingHistoryGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.weldingHistoryGridView_KeyDown);
            // 
            // weldingDateGridColumn
            // 
            this.weldingDateGridColumn.Caption = "Дата";
            this.weldingDateGridColumn.FieldName = "Date";
            this.weldingDateGridColumn.Name = "weldingDateGridColumn";
            this.weldingDateGridColumn.Visible = true;
            this.weldingDateGridColumn.VisibleIndex = 0;
            this.weldingDateGridColumn.Width = 200;
            // 
            // weldersGridColumn
            // 
            this.weldersGridColumn.Caption = "Сварщики";
            this.weldersGridColumn.ColumnEdit = this.repositoryItemPopupWelders;
            this.weldersGridColumn.FieldName = "Welders";
            this.weldersGridColumn.Name = "weldersGridColumn";
            this.weldersGridColumn.Visible = true;
            this.weldersGridColumn.VisibleIndex = 1;
            this.weldersGridColumn.Width = 564;
            // 
            // repositoryItemPopupWelders
            // 
            this.repositoryItemPopupWelders.AutoHeight = false;
            this.repositoryItemPopupWelders.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupWelders.Name = "repositoryItemPopupWelders";
            this.repositoryItemPopupWelders.NullText = "Date first";
            this.repositoryItemPopupWelders.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.repositoryItemPopupWelders_QueryPopUp);
            this.repositoryItemPopupWelders.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.repositoryItemPopupWelders_CloseUp);
            this.repositoryItemPopupWelders.Popup += new System.EventHandler(this.repositoryItemPopupWelders_Popup);
            this.repositoryItemPopupWelders.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.repositoryItemPopupWelders_CustomDisplayText);
            // 
            // steelGrade
            // 
            this.steelGrade.EditValue = "";
            this.steelGrade.Location = new System.Drawing.Point(291, 197);
            this.steelGrade.Name = "steelGrade";
            this.steelGrade.Properties.ReadOnly = true;
            this.steelGrade.Size = new System.Drawing.Size(118, 20);
            this.steelGrade.StyleController = this.generalPipeLayout;
            this.steelGrade.TabIndex = 55;
            // 
            // generalPipeLayout
            // 
            this.generalPipeLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalPipeLayout.Controls.Add(this.pipeLength);
            this.generalPipeLayout.Controls.Add(this.inspections);
            this.generalPipeLayout.Controls.Add(this.steelGrade);
            this.generalPipeLayout.Controls.Add(this.plateThickness);
            this.generalPipeLayout.Controls.Add(this.plateNumber);
            this.generalPipeLayout.Controls.Add(this.shippedDate);
            this.generalPipeLayout.Controls.Add(this.ordersLookUp);
            this.generalPipeLayout.Controls.Add(this.certificateNumber);
            this.generalPipeLayout.Controls.Add(this.heatsLookUp);
            this.generalPipeLayout.Controls.Add(this.destination);
            this.generalPipeLayout.Controls.Add(this.purchaseOrderDate);
            this.generalPipeLayout.Controls.Add(this.railcarNumber);
            this.generalPipeLayout.Controls.Add(this.saveAndNewButton);
            this.generalPipeLayout.Controls.Add(this.coatingHistory);
            this.generalPipeLayout.Controls.Add(this.deactivated);
            this.generalPipeLayout.Controls.Add(this.weldingHistory);
            this.generalPipeLayout.Controls.Add(this.saveButton);
            this.generalPipeLayout.Controls.Add(this.diameter);
            this.generalPipeLayout.Controls.Add(this.attachmentsButton);
            this.generalPipeLayout.Controls.Add(this.length);
            this.generalPipeLayout.Controls.Add(this.weight);
            this.generalPipeLayout.Controls.Add(this.pipeCreationDate);
            this.generalPipeLayout.Controls.Add(this.thickness);
            this.generalPipeLayout.Controls.Add(this.pipeNumber);
            this.generalPipeLayout.Controls.Add(this.plateManufacturer);
            this.generalPipeLayout.Controls.Add(this.pipeSize);
            this.generalPipeLayout.Controls.Add(this.millStatus);
            this.generalPipeLayout.Location = new System.Drawing.Point(0, 0);
            this.generalPipeLayout.Name = "generalPipeLayout";
            this.generalPipeLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(5, 72, 593, 560);
            this.generalPipeLayout.Root = this.generalLayoutGroup;
            this.generalPipeLayout.Size = new System.Drawing.Size(1275, 545);
            this.generalPipeLayout.TabIndex = 24;
            this.generalPipeLayout.Text = "layoutControl1";
            // 
            // pipeLength
            // 
            this.pipeLength.Location = new System.Drawing.Point(528, 131);
            this.pipeLength.Name = "pipeLength";
            this.pipeLength.Size = new System.Drawing.Size(93, 20);
            this.pipeLength.StyleController = this.generalPipeLayout;
            this.pipeLength.TabIndex = 59;
            // 
            // inspections
            // 
            this.inspections.AccessibleDescription = "l";
            this.inspections.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspections.DataSource = this.inspectionOperation;
            this.inspections.Location = new System.Drawing.Point(26, 92);
            this.inspections.MainView = this.inspectionsGridView;
            this.inspections.Name = "inspections";
            this.inspections.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.resultStatusLookUpEdit,
            this.inspectorsPopupContainerEdit,
            this.testResultValue,
            this.inspectionCodeLookUpEdit});
            this.inspections.Size = new System.Drawing.Size(1233, 406);
            this.inspections.TabIndex = 25;
            this.inspections.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionsGridView});
            // 
            // inspectionOperation
            // 
            this.inspectionOperation.DataSource = typeof(Prizm.Main.DummyData.InspectionDummy);
            // 
            // inspectionsGridView
            // 
            this.inspectionsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectionNameGridColumn,
            this.expectedResultGridColumn,
            this.valueGridColumn,
            this.inspectionResultGridColumn,
            this.inspectorsGridColumn,
            this.controlDateGridColumn,
            this.inspectionCodeGridColumn,
            this.categoryGridColumn});
            this.inspectionsGridView.GridControl = this.inspections;
            this.inspectionsGridView.Name = "inspectionsGridView";
            this.inspectionsGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.inspectionsGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.inspectionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.inspectionsGridView.OptionsView.ShowGroupPanel = false;
            this.inspectionsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.inspectionsGridView_InitNewRow);
            this.inspectionsGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.inspectionsGridView_ValidateRow);
            this.inspectionsGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.inspectionsGridView_CustomUnboundColumnData);
            // 
            // inspectionNameGridColumn
            // 
            this.inspectionNameGridColumn.Caption = "Название операции";
            this.inspectionNameGridColumn.FieldName = "Operation.Name";
            this.inspectionNameGridColumn.Name = "inspectionNameGridColumn";
            this.inspectionNameGridColumn.OptionsColumn.AllowEdit = false;
            this.inspectionNameGridColumn.Visible = true;
            this.inspectionNameGridColumn.VisibleIndex = 1;
            this.inspectionNameGridColumn.Width = 257;
            // 
            // expectedResultGridColumn
            // 
            this.expectedResultGridColumn.Caption = "Ожидаемый результат";
            this.expectedResultGridColumn.FieldName = "Expected";
            this.expectedResultGridColumn.Name = "expectedResultGridColumn";
            this.expectedResultGridColumn.OptionsColumn.AllowEdit = false;
            this.expectedResultGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.expectedResultGridColumn.Visible = true;
            this.expectedResultGridColumn.VisibleIndex = 3;
            this.expectedResultGridColumn.Width = 120;
            // 
            // valueGridColumn
            // 
            this.valueGridColumn.Caption = "Результат измерения";
            this.valueGridColumn.ColumnEdit = this.testResultValue;
            this.valueGridColumn.FieldName = "Value";
            this.valueGridColumn.Name = "valueGridColumn";
            this.valueGridColumn.Visible = true;
            this.valueGridColumn.VisibleIndex = 4;
            this.valueGridColumn.Width = 120;
            // 
            // testResultValue
            // 
            this.testResultValue.AutoHeight = false;
            this.testResultValue.Name = "testResultValue";
            // 
            // inspectionResultGridColumn
            // 
            this.inspectionResultGridColumn.Caption = "Результат контроля";
            this.inspectionResultGridColumn.ColumnEdit = this.resultStatusLookUpEdit;
            this.inspectionResultGridColumn.FieldName = "Status";
            this.inspectionResultGridColumn.Name = "inspectionResultGridColumn";
            this.inspectionResultGridColumn.Visible = true;
            this.inspectionResultGridColumn.VisibleIndex = 5;
            this.inspectionResultGridColumn.Width = 120;
            // 
            // resultStatusLookUpEdit
            // 
            this.resultStatusLookUpEdit.AutoHeight = false;
            this.resultStatusLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resultStatusLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Статус результата")});
            this.resultStatusLookUpEdit.DisplayMember = "Text";
            this.resultStatusLookUpEdit.Name = "resultStatusLookUpEdit";
            this.resultStatusLookUpEdit.NullText = "";
            this.resultStatusLookUpEdit.ValueMember = "Value";
            // 
            // inspectorsGridColumn
            // 
            this.inspectorsGridColumn.Caption = "Инспекторы";
            this.inspectorsGridColumn.ColumnEdit = this.inspectorsPopupContainerEdit;
            this.inspectorsGridColumn.FieldName = "Inspectors";
            this.inspectorsGridColumn.Name = "inspectorsGridColumn";
            this.inspectorsGridColumn.Visible = true;
            this.inspectorsGridColumn.VisibleIndex = 7;
            this.inspectorsGridColumn.Width = 245;
            // 
            // inspectorsPopupContainerEdit
            // 
            this.inspectorsPopupContainerEdit.AutoHeight = false;
            this.inspectorsPopupContainerEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspectorsPopupContainerEdit.Name = "inspectorsPopupContainerEdit";
            this.inspectorsPopupContainerEdit.PopupFormMinSize = new System.Drawing.Size(350, 0);
            this.inspectorsPopupContainerEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.inspectorsPopupContainerEdit_QueryPopUp);
            this.inspectorsPopupContainerEdit.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.inspectorsPopupContainerEdit_CloseUp);
            this.inspectorsPopupContainerEdit.Popup += new System.EventHandler(this.inspectorsPopupContainerEdit_Popup);
            this.inspectorsPopupContainerEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.inspectorsPopupContainerEdit_CustomDisplayText);
            // 
            // controlDateGridColumn
            // 
            this.controlDateGridColumn.Caption = "Дата контроля";
            this.controlDateGridColumn.FieldName = "Date";
            this.controlDateGridColumn.Name = "controlDateGridColumn";
            this.controlDateGridColumn.Visible = true;
            this.controlDateGridColumn.VisibleIndex = 6;
            this.controlDateGridColumn.Width = 142;
            // 
            // inspectionCodeGridColumn
            // 
            this.inspectionCodeGridColumn.Caption = "Код";
            this.inspectionCodeGridColumn.ColumnEdit = this.inspectionCodeLookUpEdit;
            this.inspectionCodeGridColumn.FieldName = "Operation.Code";
            this.inspectionCodeGridColumn.Name = "inspectionCodeGridColumn";
            this.inspectionCodeGridColumn.Visible = true;
            this.inspectionCodeGridColumn.VisibleIndex = 0;
            this.inspectionCodeGridColumn.Width = 58;
            // 
            // inspectionCodeLookUpEdit
            // 
            this.inspectionCodeLookUpEdit.AutoHeight = false;
            this.inspectionCodeLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.inspectionCodeLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspectionCodeLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Код"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.inspectionCodeLookUpEdit.DisplayMember = "Code";
            this.inspectionCodeLookUpEdit.Name = "inspectionCodeLookUpEdit";
            this.inspectionCodeLookUpEdit.NullText = "";
            this.inspectionCodeLookUpEdit.ValueMember = "Code";
            this.inspectionCodeLookUpEdit.EditValueChanged += new System.EventHandler(this.inspectionCodeLookUpEdit_EditValueChanged);
            // 
            // categoryGridColumn
            // 
            this.categoryGridColumn.Caption = "Категория";
            this.categoryGridColumn.FieldName = "Operation.Category.Name";
            this.categoryGridColumn.Name = "categoryGridColumn";
            this.categoryGridColumn.Visible = true;
            this.categoryGridColumn.VisibleIndex = 2;
            this.categoryGridColumn.Width = 120;
            // 
            // plateThickness
            // 
            this.plateThickness.Location = new System.Drawing.Point(291, 147);
            this.plateThickness.Name = "plateThickness";
            this.plateThickness.Properties.Mask.EditMask = "f2";
            this.plateThickness.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.plateThickness.Size = new System.Drawing.Size(118, 20);
            this.plateThickness.StyleController = this.generalPipeLayout;
            this.plateThickness.TabIndex = 58;
            // 
            // plateNumber
            // 
            this.plateNumber.Location = new System.Drawing.Point(46, 147);
            this.plateNumber.Name = "plateNumber";
            this.plateNumber.Size = new System.Drawing.Size(231, 20);
            this.plateNumber.StyleController = this.generalPipeLayout;
            this.plateNumber.TabIndex = 25;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider.SetValidationRule(this.plateNumber, conditionValidationRule1);
            this.plateNumber.EditValueChanged += new System.EventHandler(this.plateNumber_EditValueChanged);
            // 
            // shippedDate
            // 
            this.shippedDate.Location = new System.Drawing.Point(879, 197);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Properties.ReadOnly = true;
            this.shippedDate.Size = new System.Drawing.Size(101, 20);
            this.shippedDate.StyleController = this.generalPipeLayout;
            this.shippedDate.TabIndex = 56;
            // 
            // ordersLookUp
            // 
            this.ordersLookUp.Location = new System.Drawing.Point(605, 27);
            this.ordersLookUp.Name = "ordersLookUp";
            this.ordersLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ordersLookUp.Properties.DisplayMember = "Number";
            this.ordersLookUp.Properties.NullText = "";
            this.ordersLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.ordersLookUp.Properties.View = this.gridLookUpEdit2View;
            this.ordersLookUp.Size = new System.Drawing.Size(123, 20);
            this.ordersLookUp.StyleController = this.generalPipeLayout;
            this.ordersLookUp.TabIndex = 34;
            this.ordersLookUp.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.ordersLookUp_ProcessNewValue);
            this.ordersLookUp.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.ordersLookUp_QueryPopUp);
            this.ordersLookUp.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ordersLookUp_ButtonClick);
            this.ordersLookUp.Validated += new System.EventHandler(this.ordersLookUp_Validated);
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.orderNumberCol,
            this.orderDateCol});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // orderNumberCol
            // 
            this.orderNumberCol.Caption = "Номер";
            this.orderNumberCol.FieldName = "Number";
            this.orderNumberCol.Name = "orderNumberCol";
            this.orderNumberCol.Visible = true;
            this.orderNumberCol.VisibleIndex = 0;
            // 
            // orderDateCol
            // 
            this.orderDateCol.Caption = "Дата";
            this.orderDateCol.FieldName = "Date";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 1;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(994, 147);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Properties.ReadOnly = true;
            this.certificateNumber.Size = new System.Drawing.Size(245, 20);
            this.certificateNumber.StyleController = this.generalPipeLayout;
            this.certificateNumber.TabIndex = 55;
            // 
            // heatsLookUp
            // 
            this.heatsLookUp.EditValue = "";
            this.heatsLookUp.Location = new System.Drawing.Point(398, 27);
            this.heatsLookUp.Name = "heatsLookUp";
            this.heatsLookUp.Properties.AutoComplete = false;
            this.heatsLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.heatsLookUp.Properties.DisplayMember = "Number";
            this.heatsLookUp.Properties.NullText = "";
            this.heatsLookUp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.heatsLookUp.Properties.View = this.gridLookUpEdit1View;
            this.heatsLookUp.Size = new System.Drawing.Size(173, 20);
            this.heatsLookUp.StyleController = this.generalPipeLayout;
            this.heatsLookUp.TabIndex = 33;
            this.heatsLookUp.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.heatsLookUp_ProcessNewValue);
            this.heatsLookUp.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.heatsLookUp_QueryPopUp);
            this.heatsLookUp.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.heatsLookUp_ButtonClick);
            this.heatsLookUp.Validated += new System.EventHandler(this.heatsLookUp_Validated);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.heatsNumberCol});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // heatsNumberCol
            // 
            this.heatsNumberCol.Caption = "Номер";
            this.heatsNumberCol.FieldName = "Number";
            this.heatsNumberCol.Name = "heatsNumberCol";
            this.heatsNumberCol.Visible = true;
            this.heatsNumberCol.VisibleIndex = 0;
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(994, 197);
            this.destination.Name = "destination";
            this.destination.Properties.ReadOnly = true;
            this.destination.Size = new System.Drawing.Size(245, 20);
            this.destination.StyleController = this.generalPipeLayout;
            this.destination.TabIndex = 54;
            // 
            // purchaseOrderDate
            // 
            this.purchaseOrderDate.Location = new System.Drawing.Point(762, 27);
            this.purchaseOrderDate.Name = "purchaseOrderDate";
            this.purchaseOrderDate.Properties.ReadOnly = true;
            this.purchaseOrderDate.Size = new System.Drawing.Size(149, 20);
            this.purchaseOrderDate.StyleController = this.generalPipeLayout;
            this.purchaseOrderDate.TabIndex = 32;
            // 
            // railcarNumber
            // 
            this.railcarNumber.Location = new System.Drawing.Point(879, 147);
            this.railcarNumber.Name = "railcarNumber";
            this.railcarNumber.Properties.ReadOnly = true;
            this.railcarNumber.Size = new System.Drawing.Size(101, 20);
            this.railcarNumber.StyleController = this.generalPipeLayout;
            this.railcarNumber.TabIndex = 53;
            // 
            // saveAndNewButton
            // 
            this.saveAndNewButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAndNewButton.Image")));
            this.saveAndNewButton.Location = new System.Drawing.Point(1104, 514);
            this.saveAndNewButton.Name = "saveAndNewButton";
            this.saveAndNewButton.Size = new System.Drawing.Size(151, 22);
            this.saveAndNewButton.StyleController = this.generalPipeLayout;
            this.saveAndNewButton.TabIndex = 29;
            this.saveAndNewButton.Text = "Сох&ранить / Создать";
            // 
            // coatingHistory
            // 
            this.coatingHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.coatingHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.coatingHistory.DataSource = this.coatDataSource;
            this.coatingHistory.Location = new System.Drawing.Point(41, 277);
            this.coatingHistory.MainView = this.coatingHistoryGridView;
            this.coatingHistory.Name = "coatingHistory";
            this.coatingHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditCoatType});
            this.coatingHistory.Size = new System.Drawing.Size(373, 206);
            this.coatingHistory.TabIndex = 45;
            this.coatingHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.coatingHistoryGridView});
            // 
            // coatDataSource
            // 
            this.coatDataSource.DataMember = "Coats";
            // 
            // coatingHistoryGridView
            // 
            this.coatingHistoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coatingDateGridColumn,
            this.coatingTypeGridColumn});
            this.coatingHistoryGridView.GridControl = this.coatingHistory;
            this.coatingHistoryGridView.Name = "coatingHistoryGridView";
            this.coatingHistoryGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.coatingHistoryGridView.OptionsNavigation.UseTabKey = false;
            this.coatingHistoryGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.coatingHistoryGridView.OptionsView.ShowGroupPanel = false;
            this.coatingHistoryGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.coatingHistoryGridView_InitNewRow);
            this.coatingHistoryGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coatingHistoryGridView_KeyDown);
            // 
            // coatingDateGridColumn
            // 
            this.coatingDateGridColumn.Caption = "Дата";
            this.coatingDateGridColumn.FieldName = "Date";
            this.coatingDateGridColumn.Name = "coatingDateGridColumn";
            this.coatingDateGridColumn.Visible = true;
            this.coatingDateGridColumn.VisibleIndex = 0;
            this.coatingDateGridColumn.Width = 150;
            // 
            // coatingTypeGridColumn
            // 
            this.coatingTypeGridColumn.Caption = "Тип покрытия";
            this.coatingTypeGridColumn.ColumnEdit = this.repositoryItemLookUpEditCoatType;
            this.coatingTypeGridColumn.FieldName = "Type";
            this.coatingTypeGridColumn.Name = "coatingTypeGridColumn";
            this.coatingTypeGridColumn.Visible = true;
            this.coatingTypeGridColumn.VisibleIndex = 1;
            this.coatingTypeGridColumn.Width = 357;
            // 
            // repositoryItemLookUpEditCoatType
            // 
            this.repositoryItemLookUpEditCoatType.AutoHeight = false;
            this.repositoryItemLookUpEditCoatType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditCoatType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Key", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value")});
            this.repositoryItemLookUpEditCoatType.Name = "repositoryItemLookUpEditCoatType";
            this.repositoryItemLookUpEditCoatType.NullText = "";
            this.repositoryItemLookUpEditCoatType.ShowHeader = false;
            this.repositoryItemLookUpEditCoatType.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEditCoatType_EditValueChanged);
            this.repositoryItemLookUpEditCoatType.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.repositoryItemLookUpEditCoatType_CustomDisplayText);
            // 
            // deactivated
            // 
            this.deactivated.Location = new System.Drawing.Point(140, 517);
            this.deactivated.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.deactivated.Name = "deactivated";
            this.deactivated.Properties.Caption = "Труба деактивирована";
            this.deactivated.Size = new System.Drawing.Size(194, 19);
            this.deactivated.StyleController = this.generalPipeLayout;
            this.deactivated.TabIndex = 28;
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(960, 514);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 22);
            this.saveButton.StyleController = this.generalPipeLayout;
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Со&хранить";
            // 
            // diameter
            // 
            this.diameter.Location = new System.Drawing.Point(740, 165);
            this.diameter.Name = "diameter";
            this.diameter.Properties.Mask.EditMask = "d";
            this.diameter.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.diameter.Size = new System.Drawing.Size(95, 20);
            this.diameter.StyleController = this.generalPipeLayout;
            this.diameter.TabIndex = 28;
            // 
            // attachmentsButton
            // 
            this.attachmentsButton.Image = ((System.Drawing.Image)(resources.GetObject("attachmentsButton.Image")));
            this.attachmentsButton.Location = new System.Drawing.Point(14, 514);
            this.attachmentsButton.Name = "attachmentsButton";
            this.attachmentsButton.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.attachmentsButton.Size = new System.Drawing.Size(97, 22);
            this.attachmentsButton.StyleController = this.generalPipeLayout;
            this.attachmentsButton.TabIndex = 25;
            this.attachmentsButton.Text = "В&ложения";
            this.attachmentsButton.Click += new System.EventHandler(this.attachmentsButton_Click);
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(740, 131);
            this.length.Name = "length";
            this.length.Properties.Mask.EditMask = "d";
            this.length.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.length.Size = new System.Drawing.Size(95, 20);
            this.length.StyleController = this.generalPipeLayout;
            this.length.TabIndex = 25;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(528, 165);
            this.weight.Name = "weight";
            this.weight.Properties.Mask.EditMask = "d";
            this.weight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.weight.Properties.ReadOnly = true;
            this.weight.Size = new System.Drawing.Size(93, 20);
            this.weight.StyleController = this.generalPipeLayout;
            this.weight.TabIndex = 27;
            // 
            // pipeCreationDate
            // 
            this.pipeCreationDate.EditValue = null;
            this.pipeCreationDate.Location = new System.Drawing.Point(945, 27);
            this.pipeCreationDate.Name = "pipeCreationDate";
            this.pipeCreationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeCreationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeCreationDate.Size = new System.Drawing.Size(127, 20);
            this.pipeCreationDate.StyleController = this.generalPipeLayout;
            this.pipeCreationDate.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider.SetValidationRule(this.pipeCreationDate, conditionValidationRule2);
            this.pipeCreationDate.EditValueChanged += new System.EventHandler(this.pipeCreationDate_EditValueChanged);
            // 
            // thickness
            // 
            this.thickness.Location = new System.Drawing.Point(740, 199);
            this.thickness.Name = "thickness";
            this.thickness.Properties.Mask.EditMask = "f2";
            this.thickness.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.thickness.Size = new System.Drawing.Size(95, 20);
            this.thickness.StyleController = this.generalPipeLayout;
            this.thickness.TabIndex = 26;
            // 
            // pipeNumber
            // 
            this.pipeNumber.Location = new System.Drawing.Point(14, 27);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.pipeNumber.Properties.Appearance.Options.UseBackColor = true;
            this.pipeNumber.Size = new System.Drawing.Size(156, 20);
            this.pipeNumber.StyleController = this.generalPipeLayout;
            this.pipeNumber.TabIndex = 0;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider.SetValidationRule(this.pipeNumber, conditionValidationRule3);
            this.pipeNumber.EditValueChanged += new System.EventHandler(this.pipeNumber_EditValueChanged);
            this.pipeNumber.Validating += new System.ComponentModel.CancelEventHandler(this.pipeNumber_Validating);
            // 
            // plateManufacturer
            // 
            this.plateManufacturer.EditValue = "Нижнеднепровский трубопрокатный завод";
            this.plateManufacturer.Location = new System.Drawing.Point(46, 197);
            this.plateManufacturer.Name = "plateManufacturer";
            this.plateManufacturer.Properties.ReadOnly = true;
            this.plateManufacturer.Size = new System.Drawing.Size(231, 20);
            this.plateManufacturer.StyleController = this.generalPipeLayout;
            this.plateManufacturer.TabIndex = 57;
            // 
            // pipeSize
            // 
            this.pipeSize.Location = new System.Drawing.Point(204, 27);
            this.pipeSize.Name = "pipeSize";
            this.pipeSize.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.pipeSize.Properties.Appearance.Options.UseBackColor = true;
            this.pipeSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.pipeSize.Size = new System.Drawing.Size(160, 20);
            this.pipeSize.StyleController = this.generalPipeLayout;
            this.pipeSize.TabIndex = 1;
            this.pipeSize.SelectedIndexChanged += new System.EventHandler(this.pipeSize_SelectedIndexChanged);
            this.pipeSize.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.pipeSize_EditValueChanging);
            // 
            // millStatus
            // 
            this.millStatus.Location = new System.Drawing.Point(1106, 27);
            this.millStatus.Name = "millStatus";
            this.millStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.millStatus.Properties.Appearance.Options.UseBackColor = true;
            this.millStatus.Properties.ReadOnly = true;
            this.millStatus.Size = new System.Drawing.Size(149, 20);
            this.millStatus.StyleController = this.generalPipeLayout;
            this.millStatus.TabIndex = 4;
            // 
            // generalLayoutGroup
            // 
            this.generalLayoutGroup.CustomizationFormText = "Основная форма";
            this.generalLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalLayoutGroup.GroupBordersVisible = false;
            this.generalLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipeNumberLayout,
            this.pipeSizeLayout,
            this.statusLayout,
            this.creationDateLayout,
            this.purchaseOrderDateLayoutControl,
            this.heatsLayout,
            this.ordersLayout,
            this.attachmentsButtonLayout,
            this.deactivateLayout,
            this.footerEmptySpaceItem,
            this.saveButtonLayout,
            this.saveNewLayoutControlItem,
            this.tabbedControlGroup});
            this.generalLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalLayoutGroup.Name = "Root";
            this.generalLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.generalLayoutGroup.Size = new System.Drawing.Size(1275, 545);
            this.generalLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 5);
            this.generalLayoutGroup.Text = "Основная форма";
            this.generalLayoutGroup.TextVisible = false;
            // 
            // pipeNumberLayout
            // 
            this.pipeNumberLayout.Control = this.pipeNumber;
            this.pipeNumberLayout.CustomizationFormText = "Номер трубы";
            this.pipeNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.pipeNumberLayout.Name = "pipeNumberLayout";
            this.pipeNumberLayout.Size = new System.Drawing.Size(175, 54);
            this.pipeNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 7);
            this.pipeNumberLayout.Text = "Номер тр&убы";
            this.pipeNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // pipeSizeLayout
            // 
            this.pipeSizeLayout.Control = this.pipeSize;
            this.pipeSizeLayout.CustomizationFormText = "Типоразмер";
            this.pipeSizeLayout.Location = new System.Drawing.Point(175, 0);
            this.pipeSizeLayout.Name = "pipeSizeLayout";
            this.pipeSizeLayout.Size = new System.Drawing.Size(194, 54);
            this.pipeSizeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.pipeSizeLayout.Text = "Типораз&мер трубы";
            this.pipeSizeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeSizeLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // statusLayout
            // 
            this.statusLayout.Control = this.millStatus;
            this.statusLayout.CustomizationFormText = "Статус";
            this.statusLayout.Location = new System.Drawing.Point(1077, 0);
            this.statusLayout.Name = "statusLayout";
            this.statusLayout.Size = new System.Drawing.Size(184, 54);
            this.statusLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 16, 7, 7);
            this.statusLayout.Text = "Статус на завод&е";
            this.statusLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.statusLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // creationDateLayout
            // 
            this.creationDateLayout.Control = this.pipeCreationDate;
            this.creationDateLayout.CustomizationFormText = "Creation date";
            this.creationDateLayout.Location = new System.Drawing.Point(916, 0);
            this.creationDateLayout.Name = "creationDateLayout";
            this.creationDateLayout.Size = new System.Drawing.Size(161, 54);
            this.creationDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.creationDateLayout.Text = "Дата &изготовления";
            this.creationDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.creationDateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // purchaseOrderDateLayoutControl
            // 
            this.purchaseOrderDateLayoutControl.Control = this.purchaseOrderDate;
            this.purchaseOrderDateLayoutControl.CustomizationFormText = "Дата наряд-заказа";
            this.purchaseOrderDateLayoutControl.Location = new System.Drawing.Point(733, 0);
            this.purchaseOrderDateLayoutControl.Name = "purchaseOrderDateLayoutControl";
            this.purchaseOrderDateLayoutControl.Size = new System.Drawing.Size(183, 54);
            this.purchaseOrderDateLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.purchaseOrderDateLayoutControl.Text = "&Дата наряд-заказа";
            this.purchaseOrderDateLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.purchaseOrderDateLayoutControl.TextSize = new System.Drawing.Size(101, 13);
            // 
            // heatsLayout
            // 
            this.heatsLayout.Control = this.heatsLookUp;
            this.heatsLayout.CustomizationFormText = "Плавка";
            this.heatsLayout.Location = new System.Drawing.Point(369, 0);
            this.heatsLayout.Name = "heatsLayout";
            this.heatsLayout.Size = new System.Drawing.Size(207, 54);
            this.heatsLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.heatsLayout.Text = "&Плавка";
            this.heatsLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.heatsLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ordersLayout
            // 
            this.ordersLayout.Control = this.ordersLookUp;
            this.ordersLayout.CustomizationFormText = "Наряд-заказ";
            this.ordersLayout.Location = new System.Drawing.Point(576, 0);
            this.ordersLayout.Name = "ordersLayout";
            this.ordersLayout.Size = new System.Drawing.Size(157, 54);
            this.ordersLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.ordersLayout.Text = "Нар&яд-заказ";
            this.ordersLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.ordersLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // attachmentsButtonLayout
            // 
            this.attachmentsButtonLayout.Control = this.attachmentsButton;
            this.attachmentsButtonLayout.ControlAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.attachmentsButtonLayout.CustomizationFormText = "Вложения";
            this.attachmentsButtonLayout.Location = new System.Drawing.Point(0, 510);
            this.attachmentsButtonLayout.Name = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Size = new System.Drawing.Size(101, 26);
            this.attachmentsButtonLayout.Text = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.attachmentsButtonLayout.TextVisible = false;
            this.attachmentsButtonLayout.TrimClientAreaToControl = false;
            // 
            // deactivateLayout
            // 
            this.deactivateLayout.Control = this.deactivated;
            this.deactivateLayout.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.deactivateLayout.CustomizationFormText = "Деактивация";
            this.deactivateLayout.Location = new System.Drawing.Point(101, 510);
            this.deactivateLayout.Name = "deactivateLayout";
            this.deactivateLayout.Size = new System.Drawing.Size(238, 26);
            this.deactivateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(25, 15, 0, 0);
            this.deactivateLayout.Text = "deactivateLayout";
            this.deactivateLayout.TextSize = new System.Drawing.Size(0, 0);
            this.deactivateLayout.TextVisible = false;
            this.deactivateLayout.TrimClientAreaToControl = false;
            // 
            // footerEmptySpaceItem
            // 
            this.footerEmptySpaceItem.AllowHotTrack = false;
            this.footerEmptySpaceItem.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.footerEmptySpaceItem.CustomizationFormText = "Разделитель";
            this.footerEmptySpaceItem.Location = new System.Drawing.Point(339, 510);
            this.footerEmptySpaceItem.Name = "footerEmptySpaceItem";
            this.footerEmptySpaceItem.Size = new System.Drawing.Size(592, 26);
            this.footerEmptySpaceItem.Text = "Разделитель";
            this.footerEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            this.footerEmptySpaceItem.TrimClientAreaToControl = false;
            // 
            // saveButtonLayout
            // 
            this.saveButtonLayout.Control = this.saveButton;
            this.saveButtonLayout.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.saveButtonLayout.CustomizationFormText = "Сохранить";
            this.saveButtonLayout.Location = new System.Drawing.Point(931, 510);
            this.saveButtonLayout.Name = "saveButtonLayout";
            this.saveButtonLayout.Size = new System.Drawing.Size(149, 26);
            this.saveButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 5, 0, 0);
            this.saveButtonLayout.Text = "saveButtonLayout";
            this.saveButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayout.TextVisible = false;
            this.saveButtonLayout.TrimClientAreaToControl = false;
            // 
            // saveNewLayoutControlItem
            // 
            this.saveNewLayoutControlItem.Control = this.saveAndNewButton;
            this.saveNewLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.saveNewLayoutControlItem.CustomizationFormText = "Сохранить и создать";
            this.saveNewLayoutControlItem.Location = new System.Drawing.Point(1080, 510);
            this.saveNewLayoutControlItem.Name = "saveNewLayoutControlItem";
            this.saveNewLayoutControlItem.Size = new System.Drawing.Size(181, 26);
            this.saveNewLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 16, 0, 0);
            this.saveNewLayoutControlItem.Text = "saveNewLayoutControlItem";
            this.saveNewLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveNewLayoutControlItem.TextVisible = false;
            this.saveNewLayoutControlItem.TrimClientAreaToControl = false;
            // 
            // tabbedControlGroup
            // 
            this.tabbedControlGroup.CustomizationFormText = "Вкладки";
            this.tabbedControlGroup.Location = new System.Drawing.Point(0, 54);
            this.tabbedControlGroup.Name = "tabbedControlGroup";
            this.tabbedControlGroup.SelectedTabPage = this.pipeTabLayoutControlGroup;
            this.tabbedControlGroup.SelectedTabPageIndex = 0;
            this.tabbedControlGroup.Size = new System.Drawing.Size(1261, 456);
            this.tabbedControlGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipeTabLayoutControlGroup,
            this.inspectionsTabLayoutControlGroup});
            this.tabbedControlGroup.Text = "Вкладки";
            // 
            // pipeTabLayoutControlGroup
            // 
            this.pipeTabLayoutControlGroup.CustomizationFormText = "Вкладка данных трубы";
            this.pipeTabLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.plateLayoutControlGroup,
            this.coverLayoutControlGroup,
            this.shippingLayoutControlGroup,
            this.weldsLayoutControlGroup,
            this.factSizeLayoutControlGroup,
            this.typeSizeaParametersLyoutGroup});
            this.pipeTabLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.pipeTabLayoutControlGroup.Name = "pipeTabLayoutControlGroup";
            this.pipeTabLayoutControlGroup.Size = new System.Drawing.Size(1237, 410);
            this.pipeTabLayoutControlGroup.Text = "Общие параметры трубы";
            // 
            // plateLayoutControlGroup
            // 
            this.plateLayoutControlGroup.CustomizationFormText = "Параметры листа";
            this.plateLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.plateNumberLayoutControlItem,
            this.plateManufacturerLayoutControlItem,
            this.plateThicknessLayoutControlItem,
            this.steelGradeLayoutControlItem});
            this.plateLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.plateLayoutControlGroup.Name = "plateLayoutControlGroup";
            this.plateLayoutControlGroup.Size = new System.Drawing.Size(407, 151);
            this.plateLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.plateLayoutControlGroup.Text = "Параметры листа";
            // 
            // plateNumberLayoutControlItem
            // 
            this.plateNumberLayoutControlItem.Control = this.plateNumber;
            this.plateNumberLayoutControlItem.CustomizationFormText = "Номер";
            this.plateNumberLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.plateNumberLayoutControlItem.Name = "plateNumberLayoutControlItem";
            this.plateNumberLayoutControlItem.Size = new System.Drawing.Size(245, 50);
            this.plateNumberLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.plateNumberLayoutControlItem.Text = "Номер";
            this.plateNumberLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateNumberLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // plateManufacturerLayoutControlItem
            // 
            this.plateManufacturerLayoutControlItem.Control = this.plateManufacturer;
            this.plateManufacturerLayoutControlItem.CustomizationFormText = "Производитель";
            this.plateManufacturerLayoutControlItem.Location = new System.Drawing.Point(0, 50);
            this.plateManufacturerLayoutControlItem.Name = "plateManufacturerLayoutControlItem";
            this.plateManufacturerLayoutControlItem.Size = new System.Drawing.Size(245, 52);
            this.plateManufacturerLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.plateManufacturerLayoutControlItem.Text = "Производитель";
            this.plateManufacturerLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateManufacturerLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // plateThicknessLayoutControlItem
            // 
            this.plateThicknessLayoutControlItem.Control = this.plateThickness;
            this.plateThicknessLayoutControlItem.CustomizationFormText = "Толщина";
            this.plateThicknessLayoutControlItem.Location = new System.Drawing.Point(245, 0);
            this.plateThicknessLayoutControlItem.Name = "plateThicknessLayoutControlItem";
            this.plateThicknessLayoutControlItem.Size = new System.Drawing.Size(132, 50);
            this.plateThicknessLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.plateThicknessLayoutControlItem.Text = "Тол&щина";
            this.plateThicknessLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateThicknessLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // steelGradeLayoutControlItem
            // 
            this.steelGradeLayoutControlItem.Control = this.steelGrade;
            this.steelGradeLayoutControlItem.CustomizationFormText = "Марка стали";
            this.steelGradeLayoutControlItem.Location = new System.Drawing.Point(245, 50);
            this.steelGradeLayoutControlItem.Name = "steelGradeLayoutControlItem";
            this.steelGradeLayoutControlItem.Size = new System.Drawing.Size(132, 52);
            this.steelGradeLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.steelGradeLayoutControlItem.Text = "Марка стали";
            this.steelGradeLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.steelGradeLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // coverLayoutControlGroup
            // 
            this.coverLayoutControlGroup.CustomizationFormText = "Параметры покрытия";
            this.coverLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.coatsLayoutControlItem});
            this.coverLayoutControlGroup.Location = new System.Drawing.Point(0, 151);
            this.coverLayoutControlGroup.Name = "coverLayoutControlGroup";
            this.coverLayoutControlGroup.Size = new System.Drawing.Size(407, 259);
            this.coverLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.coverLayoutControlGroup.Text = "Параметр&ы покрытия";
            // 
            // coatsLayoutControlItem
            // 
            this.coatsLayoutControlItem.Control = this.coatingHistory;
            this.coatsLayoutControlItem.CustomizationFormText = "Параметры покрытия";
            this.coatsLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.coatsLayoutControlItem.Name = "coatsLayoutControlItem";
            this.coatsLayoutControlItem.Size = new System.Drawing.Size(377, 210);
            this.coatsLayoutControlItem.Text = "coatsLayoutControlItem";
            this.coatsLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.coatsLayoutControlItem.TextVisible = false;
            this.coatsLayoutControlItem.TrimClientAreaToControl = false;
            // 
            // shippingLayoutControlGroup
            // 
            this.shippingLayoutControlGroup.CustomizationFormText = "Параметры отгрузки";
            this.shippingLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.railcarLayoutControlItem,
            this.destinationLayoutControlItem,
            this.certificateLayoutControlItem,
            this.shippedDateLayoutControlItem});
            this.shippingLayoutControlGroup.Location = new System.Drawing.Point(833, 0);
            this.shippingLayoutControlGroup.Name = "shippingLayoutControlGroup";
            this.shippingLayoutControlGroup.Size = new System.Drawing.Size(404, 151);
            this.shippingLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.shippingLayoutControlGroup.Text = "Параметры от&грузки";
            // 
            // railcarLayoutControlItem
            // 
            this.railcarLayoutControlItem.Control = this.railcarNumber;
            this.railcarLayoutControlItem.CustomizationFormText = "Номер вагона";
            this.railcarLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.railcarLayoutControlItem.Name = "railcarLayoutControlItem";
            this.railcarLayoutControlItem.Size = new System.Drawing.Size(115, 50);
            this.railcarLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.railcarLayoutControlItem.Text = "Номер вагона";
            this.railcarLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.railcarLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // destinationLayoutControlItem
            // 
            this.destinationLayoutControlItem.Control = this.destination;
            this.destinationLayoutControlItem.CustomizationFormText = "Получатель";
            this.destinationLayoutControlItem.Location = new System.Drawing.Point(115, 50);
            this.destinationLayoutControlItem.Name = "destinationLayoutControlItem";
            this.destinationLayoutControlItem.Size = new System.Drawing.Size(259, 52);
            this.destinationLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.destinationLayoutControlItem.Text = "Получатель";
            this.destinationLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.destinationLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // certificateLayoutControlItem
            // 
            this.certificateLayoutControlItem.Control = this.certificateNumber;
            this.certificateLayoutControlItem.CustomizationFormText = "Номер сертификата";
            this.certificateLayoutControlItem.Location = new System.Drawing.Point(115, 0);
            this.certificateLayoutControlItem.Name = "certificateLayoutControlItem";
            this.certificateLayoutControlItem.Size = new System.Drawing.Size(259, 50);
            this.certificateLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.certificateLayoutControlItem.Text = "Номер сертификата";
            this.certificateLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // shippedDateLayoutControlItem
            // 
            this.shippedDateLayoutControlItem.Control = this.shippedDate;
            this.shippedDateLayoutControlItem.CustomizationFormText = "Дата";
            this.shippedDateLayoutControlItem.Location = new System.Drawing.Point(0, 50);
            this.shippedDateLayoutControlItem.Name = "shippedDateLayoutControlItem";
            this.shippedDateLayoutControlItem.Size = new System.Drawing.Size(115, 52);
            this.shippedDateLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.shippedDateLayoutControlItem.Text = "Дата";
            this.shippedDateLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.shippedDateLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // weldsLayoutControlGroup
            // 
            this.weldsLayoutControlGroup.CustomizationFormText = "История сварки";
            this.weldsLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.weldsLayoutControlItem});
            this.weldsLayoutControlGroup.Location = new System.Drawing.Point(407, 151);
            this.weldsLayoutControlGroup.Name = "weldsLayoutControlGroup";
            this.weldsLayoutControlGroup.Size = new System.Drawing.Size(830, 259);
            this.weldsLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.weldsLayoutControlGroup.Text = "История с&варки";
            // 
            // weldsLayoutControlItem
            // 
            this.weldsLayoutControlItem.Control = this.weldingHistory;
            this.weldsLayoutControlItem.CustomizationFormText = "История сварки";
            this.weldsLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.weldsLayoutControlItem.Name = "weldsLayoutControlItem";
            this.weldsLayoutControlItem.Size = new System.Drawing.Size(800, 210);
            this.weldsLayoutControlItem.Text = "weldsLayoutControlItem";
            this.weldsLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.weldsLayoutControlItem.TextVisible = false;
            // 
            // factSizeLayoutControlGroup
            // 
            this.factSizeLayoutControlGroup.CustomizationFormText = "Фактический размер";
            this.factSizeLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.weightLayoutControlItem,
            this.pipeLengthLayout});
            this.factSizeLayoutControlGroup.Location = new System.Drawing.Point(407, 0);
            this.factSizeLayoutControlGroup.Name = "factSizeLayoutControlGroup";
            this.factSizeLayoutControlGroup.Size = new System.Drawing.Size(212, 151);
            this.factSizeLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.factSizeLayoutControlGroup.Text = "Фак&тический размер";
            // 
            // weightLayoutControlItem
            // 
            this.weightLayoutControlItem.Control = this.weight;
            this.weightLayoutControlItem.CustomizationFormText = "Вес";
            this.weightLayoutControlItem.Location = new System.Drawing.Point(0, 34);
            this.weightLayoutControlItem.Name = "weightLayoutControlItem";
            this.weightLayoutControlItem.Size = new System.Drawing.Size(182, 68);
            this.weightLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.weightLayoutControlItem.Text = "Вес";
            this.weightLayoutControlItem.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.weightLayoutControlItem.TextSize = new System.Drawing.Size(70, 13);
            this.weightLayoutControlItem.TextToControlDistance = 5;
            // 
            // pipeLengthLayout
            // 
            this.pipeLengthLayout.Control = this.pipeLength;
            this.pipeLengthLayout.CustomizationFormText = "Длина";
            this.pipeLengthLayout.Location = new System.Drawing.Point(0, 0);
            this.pipeLengthLayout.Name = "pipeLengthLayout";
            this.pipeLengthLayout.Size = new System.Drawing.Size(182, 34);
            this.pipeLengthLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.pipeLengthLayout.Text = "Длина";
            this.pipeLengthLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.pipeLengthLayout.TextSize = new System.Drawing.Size(70, 13);
            this.pipeLengthLayout.TextToControlDistance = 5;
            // 
            // typeSizeaParametersLyoutGroup
            // 
            this.typeSizeaParametersLyoutGroup.CustomizationFormText = "Типоразмер";
            this.typeSizeaParametersLyoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lengthLayoutControlItem,
            this.diameterLayoutControlItem,
            this.thicknessLayoutControlItem});
            this.typeSizeaParametersLyoutGroup.Location = new System.Drawing.Point(619, 0);
            this.typeSizeaParametersLyoutGroup.Name = "typeSizeaParametersLyoutGroup";
            this.typeSizeaParametersLyoutGroup.Size = new System.Drawing.Size(214, 151);
            this.typeSizeaParametersLyoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.typeSizeaParametersLyoutGroup.Text = "Типораз&мер";
            // 
            // lengthLayoutControlItem
            // 
            this.lengthLayoutControlItem.Control = this.length;
            this.lengthLayoutControlItem.CustomizationFormText = "Длина";
            this.lengthLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.lengthLayoutControlItem.Name = "lengthLayoutControlItem";
            this.lengthLayoutControlItem.Size = new System.Drawing.Size(184, 34);
            this.lengthLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lengthLayoutControlItem.Text = "Длина";
            this.lengthLayoutControlItem.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lengthLayoutControlItem.TextSize = new System.Drawing.Size(70, 13);
            this.lengthLayoutControlItem.TextToControlDistance = 5;
            // 
            // diameterLayoutControlItem
            // 
            this.diameterLayoutControlItem.Control = this.diameter;
            this.diameterLayoutControlItem.CustomizationFormText = "Диаметр";
            this.diameterLayoutControlItem.Location = new System.Drawing.Point(0, 34);
            this.diameterLayoutControlItem.Name = "diameterLayoutControlItem";
            this.diameterLayoutControlItem.Size = new System.Drawing.Size(184, 34);
            this.diameterLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.diameterLayoutControlItem.Text = "Диаметр";
            this.diameterLayoutControlItem.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.diameterLayoutControlItem.TextSize = new System.Drawing.Size(70, 13);
            this.diameterLayoutControlItem.TextToControlDistance = 5;
            // 
            // thicknessLayoutControlItem
            // 
            this.thicknessLayoutControlItem.Control = this.thickness;
            this.thicknessLayoutControlItem.CustomizationFormText = "Толщина";
            this.thicknessLayoutControlItem.Location = new System.Drawing.Point(0, 68);
            this.thicknessLayoutControlItem.Name = "thicknessLayoutControlItem";
            this.thicknessLayoutControlItem.Size = new System.Drawing.Size(184, 34);
            this.thicknessLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.thicknessLayoutControlItem.Text = "Толщина";
            this.thicknessLayoutControlItem.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.thicknessLayoutControlItem.TextSize = new System.Drawing.Size(70, 13);
            this.thicknessLayoutControlItem.TextToControlDistance = 5;
            // 
            // inspectionsTabLayoutControlGroup
            // 
            this.inspectionsTabLayoutControlGroup.CustomizationFormText = "Вкладка контрольных операций";
            this.inspectionsTabLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectionsGridLayoutControlItem});
            this.inspectionsTabLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.inspectionsTabLayoutControlGroup.Name = "inspectionsTabLayoutControlGroup";
            this.inspectionsTabLayoutControlGroup.Size = new System.Drawing.Size(1237, 410);
            this.inspectionsTabLayoutControlGroup.Text = "Контрольные операции";
            // 
            // inspectionsGridLayoutControlItem
            // 
            this.inspectionsGridLayoutControlItem.Control = this.inspections;
            this.inspectionsGridLayoutControlItem.CustomizationFormText = "Таблица контрольных операций";
            this.inspectionsGridLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.inspectionsGridLayoutControlItem.Name = "inspectionsGridLayoutControlItem";
            this.inspectionsGridLayoutControlItem.Size = new System.Drawing.Size(1237, 410);
            this.inspectionsGridLayoutControlItem.Text = "Таблица контрольных операций";
            this.inspectionsGridLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.inspectionsGridLayoutControlItem.TextVisible = false;
            // 
            // plateNumberLayout
            // 
            this.plateNumberLayout.Control = this.plateNumber;
            this.plateNumberLayout.CustomizationFormText = "layoutControlItem3";
            this.plateNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.plateNumberLayout.Name = "layoutControlItem3";
            this.plateNumberLayout.Size = new System.Drawing.Size(1237, 24);
            this.plateNumberLayout.Text = "layoutControlItem3";
            this.plateNumberLayout.TextSize = new System.Drawing.Size(99, 13);
            // 
            // certificateEmptySpace
            // 
            this.certificateEmptySpace.AllowHotTrack = false;
            this.certificateEmptySpace.CustomizationFormText = "certificateEmptySpace";
            this.certificateEmptySpace.Location = new System.Drawing.Point(351, 0);
            this.certificateEmptySpace.Name = "certificateEmptySpace";
            this.certificateEmptySpace.Size = new System.Drawing.Size(33, 50);
            this.certificateEmptySpace.Text = "certificateEmptySpace";
            this.certificateEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // weldingDs
            // 
            this.weldingDs.DataSource = typeof(Prizm.Main.DummyData.WeldersDummy);
            // 
            // workspaceManager
            // 
            this.workspaceManager.TargetControl = this;
            this.workspaceManager.TransitionType = fadeTransition1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Layouts|*.xml";
            // 
            // MillPipeNewEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1275, 550);
            this.Controls.Add(this.generalPipeLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MillPipeNewEditXtraForm";
            this.Text = "Труба";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MillPipeNewEditXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.MillPipeNewEditXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weldersListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupWelders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalPipeLayout)).EndInit();
            this.generalPipeLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultStatusLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsPopupContainerEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionCodeLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatsLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destination.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCoatType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactivated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeCreationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeCreationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creationDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDateLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatsLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactivateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerEmptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveNewLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTabLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumberLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturerLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateThicknessLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGradeLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDateLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldsLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factSizeLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLengthLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSizeaParametersLyoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsTabLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsGridLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNewEditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit pipeSize;
        private DevExpress.XtraEditors.TextEdit pipeNumber;
        private DevExpress.XtraEditors.DateEdit pipeCreationDate;
        private DevExpress.XtraLayout.LayoutControl generalPipeLayout;
        private DevExpress.XtraLayout.LayoutControlGroup generalLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipeNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem pipeSizeLayout;
        private DevExpress.XtraLayout.LayoutControlItem statusLayout;
        private DevExpress.XtraLayout.LayoutControlItem creationDateLayout;
        private DevExpress.XtraEditors.TextEdit length;
        private DevExpress.XtraGrid.GridControl weldingHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView weldingHistoryGridView;
        private DevExpress.XtraEditors.TextEdit diameter;
        private DevExpress.XtraEditors.TextEdit weight;
        private DevExpress.XtraEditors.TextEdit thickness;
        private DevExpress.XtraGrid.GridControl coatingHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView coatingHistoryGridView;
        private DevExpress.XtraEditors.SimpleButton attachmentsButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.CheckEdit deactivated;
        private DevExpress.XtraEditors.TextEdit shippedDate;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraEditors.TextEdit destination;
        private DevExpress.XtraEditors.TextEdit railcarNumber;
        private DevExpress.XtraLayout.EmptySpaceItem certificateEmptySpace;
        private DevExpress.XtraGrid.Views.Grid.GridView weldersListGridView;
        private System.Windows.Forms.BindingSource inspectionOperation;
        private DevExpress.XtraGrid.GridControl inspections;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn expectedResultGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn valueGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionResultGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorsGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn controlDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionCodeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn weldingDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn weldersGridColumn;
        private System.Windows.Forms.BindingSource weldingDs;
        private System.Windows.Forms.BindingSource pipeNewEditBindingSource;
        private System.Windows.Forms.BindingSource weldBindingSource;
        private System.Windows.Forms.BindingSource weldersDataSource;
        private DevExpress.XtraGrid.Columns.GridColumn coatingDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn coatingTypeGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupWelders;
        private System.Windows.Forms.BindingSource coatDataSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditCoatType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit resultStatusLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit inspectorsPopupContainerEdit;
        private System.Windows.Forms.BindingSource inspectorsDataSource;
        private DevExpress.XtraEditors.TextEdit plateNumber;
        private DevExpress.XtraEditors.TextEdit plateThickness;
        private DevExpress.XtraEditors.SimpleButton saveAndNewButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit testResultValue;
        private DevExpress.XtraEditors.TextEdit plateManufacturer;
        private DevExpress.XtraEditors.TextEdit purchaseOrderDate;
        private DevExpress.XtraLayout.LayoutControlItem purchaseOrderDateLayoutControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit inspectionCodeLookUpEdit;
        private DevExpress.XtraEditors.TextEdit millStatus;
        private DevExpress.XtraGrid.Columns.GridColumn categoryGridColumn;
        private DevExpress.XtraEditors.GridLookUpEdit heatsLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem heatsLayout;
        private DevExpress.XtraEditors.GridLookUpEdit ordersLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraLayout.LayoutControlItem ordersLayout;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn heatsNumberCol;
        private DevExpress.XtraEditors.TextEdit steelGrade;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.Utils.WorkspaceManager workspaceManager;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraLayout.LayoutControlItem plateNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem attachmentsButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem deactivateLayout;
        private DevExpress.XtraLayout.EmptySpaceItem footerEmptySpaceItem;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem saveNewLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup inspectionsTabLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem inspectionsGridLayoutControlItem;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup pipeTabLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup plateLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem plateNumberLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem plateManufacturerLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem plateThicknessLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem steelGradeLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup factSizeLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem thicknessLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem weightLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem lengthLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem diameterLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup weldsLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem weldsLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup coverLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem coatsLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup shippingLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem railcarLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem destinationLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem certificateLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem shippedDateLayoutControlItem;
        private DevExpress.XtraEditors.TextEdit pipeLength;
        private DevExpress.XtraLayout.LayoutControlItem pipeLengthLayout;
        private DevExpress.XtraLayout.LayoutControlGroup typeSizeaParametersLyoutGroup;

    }
}