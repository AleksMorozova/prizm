namespace Prizm.Main.Forms.Railcar.NewEdit
{
    partial class RailcarNewEditXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RailcarNewEditXtraForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.pipesList = new DevExpress.XtraGrid.GridControl();
            this.pipesListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeSizeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeStatusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryGridLookUpEditStatus = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.unshipButton = new DevExpress.XtraEditors.SimpleButton();
            this.generalLayout = new DevExpress.XtraLayout.LayoutControl();
            this.attachmentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.destination = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.shipButton = new DevExpress.XtraEditors.SimpleButton();
            this.removePipe = new DevExpress.XtraEditors.SimpleButton();
            this.addPipeButton = new DevExpress.XtraEditors.SimpleButton();
            this.shippedDate = new DevExpress.XtraEditors.DateEdit();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.railcarNumber = new DevExpress.XtraEditors.TextEdit();
            this.pipeNumberLookUp = new DevExpress.XtraEditors.GridLookUpEdit();
            this.pipeListLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeSizeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.railcarLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.railcarNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.shippedDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeListLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.addPipeLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.removePipeLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.unshipButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.shipButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.saveButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlDestination = new DevExpress.XtraLayout.LayoutControlItem();
            this.attachmentsButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSource = new System.Windows.Forms.BindingSource();
            this.layoutControlItemRailcar = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pipesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryGridLookUpEditStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).BeginInit();
            this.generalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destination.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeListLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeListLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPipeLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removePipeLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unshipButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRailcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pipesList
            // 
            this.pipesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pipesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipesList.Location = new System.Drawing.Point(20, 65);
            this.pipesList.MainView = this.pipesListView;
            this.pipesList.Name = "pipesList";
            this.pipesList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryGridLookUpEditStatus});
            this.pipesList.Size = new System.Drawing.Size(1228, 403);
            this.pipesList.TabIndex = 7;
            this.pipesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipesListView});
            // 
            // pipesListView
            // 
            this.pipesListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeNumberGridColumn,
            this.pipeSizeGridColumn,
            this.pipeStatusGridColumn});
            this.pipesListView.GridControl = this.pipesList;
            this.pipesListView.Name = "pipesListView";
            this.pipesListView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.pipesListView.OptionsBehavior.Editable = false;
            this.pipesListView.OptionsBehavior.FocusLeaveOnTab = true;
            this.pipesListView.OptionsBehavior.ReadOnly = true;
            this.pipesListView.OptionsNavigation.UseTabKey = false;
            this.pipesListView.OptionsView.ShowGroupPanel = false;
            // 
            // pipeNumberGridColumn
            // 
            this.pipeNumberGridColumn.Caption = "Номер трубы";
            this.pipeNumberGridColumn.FieldName = "Number";
            this.pipeNumberGridColumn.Name = "pipeNumberGridColumn";
            this.pipeNumberGridColumn.Visible = true;
            this.pipeNumberGridColumn.VisibleIndex = 0;
            // 
            // pipeSizeGridColumn
            // 
            this.pipeSizeGridColumn.Caption = "Типоразмер трубы";
            this.pipeSizeGridColumn.FieldName = "Type.Type";
            this.pipeSizeGridColumn.Name = "pipeSizeGridColumn";
            this.pipeSizeGridColumn.OptionsColumn.AllowEdit = false;
            this.pipeSizeGridColumn.Visible = true;
            this.pipeSizeGridColumn.VisibleIndex = 1;
            // 
            // pipeStatusGridColumn
            // 
            this.pipeStatusGridColumn.Caption = "Статус";
            this.pipeStatusGridColumn.ColumnEdit = this.repositoryGridLookUpEditStatus;
            this.pipeStatusGridColumn.FieldName = "Status";
            this.pipeStatusGridColumn.Name = "pipeStatusGridColumn";
            this.pipeStatusGridColumn.OptionsColumn.AllowEdit = false;
            this.pipeStatusGridColumn.Visible = true;
            this.pipeStatusGridColumn.VisibleIndex = 2;
            // 
            // repositoryGridLookUpEditStatus
            // 
            this.repositoryGridLookUpEditStatus.AutoHeight = false;
            this.repositoryGridLookUpEditStatus.Name = "repositoryGridLookUpEditStatus";
            this.repositoryGridLookUpEditStatus.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.repositoryGridLookUpEditStatus_CustomDisplayText);
            // 
            // unshipButton
            // 
            this.unshipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unshipButton.Image = ((System.Drawing.Image)(resources.GetObject("unshipButton.Image")));
            this.unshipButton.Location = new System.Drawing.Point(1024, 479);
            this.unshipButton.Name = "unshipButton";
            this.unshipButton.Size = new System.Drawing.Size(102, 22);
            this.unshipButton.StyleController = this.generalLayout;
            this.unshipButton.TabIndex = 10;
            this.unshipButton.Text = "Отк&лонить";
            // 
            // generalLayout
            // 
            this.generalLayout.Controls.Add(this.attachmentsButton);
            this.generalLayout.Controls.Add(this.destination);
            this.generalLayout.Controls.Add(this.saveButton);
            this.generalLayout.Controls.Add(this.shipButton);
            this.generalLayout.Controls.Add(this.unshipButton);
            this.generalLayout.Controls.Add(this.removePipe);
            this.generalLayout.Controls.Add(this.addPipeButton);
            this.generalLayout.Controls.Add(this.pipesList);
            this.generalLayout.Controls.Add(this.shippedDate);
            this.generalLayout.Controls.Add(this.certificateNumber);
            this.generalLayout.Controls.Add(this.railcarNumber);
            this.generalLayout.Controls.Add(this.pipeNumberLookUp);
            this.generalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalLayout.Location = new System.Drawing.Point(0, 0);
            this.generalLayout.Name = "generalLayout";
            this.generalLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(5, 278, 250, 350);
            this.generalLayout.OptionsFocus.EnableAutoTabOrder = false;
            this.generalLayout.Root = this.railcarLayoutGroup;
            this.generalLayout.ShowTemplates = true;
            this.generalLayout.Size = new System.Drawing.Size(1275, 510);
            this.generalLayout.TabIndex = 20;
            this.generalLayout.Text = "layoutControl1";
            // 
            // attachmentsButton
            // 
            this.attachmentsButton.Image = ((System.Drawing.Image)(resources.GetObject("attachmentsButton.Image")));
            this.attachmentsButton.Location = new System.Drawing.Point(20, 479);
            this.attachmentsButton.Name = "attachmentsButton";
            this.attachmentsButton.Size = new System.Drawing.Size(95, 22);
            this.attachmentsButton.StyleController = this.generalLayout;
            this.attachmentsButton.TabIndex = 8;
            this.attachmentsButton.Text = "&Вложения";
            this.attachmentsButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(369, 27);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(216, 20);
            this.destination.StyleController = this.generalLayout;
            this.destination.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(1140, 479);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 22);
            this.saveButton.StyleController = this.generalLayout;
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "&Сохранить";
            // 
            // shipButton
            // 
            this.shipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shipButton.Image = ((System.Drawing.Image)(resources.GetObject("shipButton.Image")));
            this.shipButton.Location = new System.Drawing.Point(900, 479);
            this.shipButton.Name = "shipButton";
            this.shipButton.Size = new System.Drawing.Size(110, 22);
            this.shipButton.StyleController = this.generalLayout;
            this.shipButton.TabIndex = 9;
            this.shipButton.Text = "О&тгрузить";
            // 
            // removePipe
            // 
            this.removePipe.Image = ((System.Drawing.Image)(resources.GetObject("removePipe.Image")));
            this.removePipe.Location = new System.Drawing.Point(1134, 25);
            this.removePipe.Name = "removePipe";
            this.removePipe.Size = new System.Drawing.Size(114, 22);
            this.removePipe.StyleController = this.generalLayout;
            this.removePipe.TabIndex = 6;
            this.removePipe.Text = "&Удалить трубу";
            this.removePipe.Click += new System.EventHandler(this.removePipe_Click);
            // 
            // addPipeButton
            // 
            this.addPipeButton.Image = ((System.Drawing.Image)(resources.GetObject("addPipeButton.Image")));
            this.addPipeButton.Location = new System.Drawing.Point(980, 25);
            this.addPipeButton.Name = "addPipeButton";
            this.addPipeButton.Size = new System.Drawing.Size(120, 22);
            this.addPipeButton.StyleController = this.generalLayout;
            this.addPipeButton.TabIndex = 5;
            this.addPipeButton.Text = "&Добавить трубу";
            this.addPipeButton.Click += new System.EventHandler(this.addPipeButton_Click);
            // 
            // shippedDate
            // 
            this.shippedDate.EditValue = null;
            this.shippedDate.Location = new System.Drawing.Point(234, 27);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.shippedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Properties.Mask.EditMask = "";
            this.shippedDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.shippedDate.Size = new System.Drawing.Size(101, 20);
            this.shippedDate.StyleController = this.generalLayout;
            this.shippedDate.TabIndex = 1;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(619, 27);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(165, 20);
            this.certificateNumber.StyleController = this.generalLayout;
            this.certificateNumber.TabIndex = 3;
            // 
            // railcarNumber
            // 
            this.railcarNumber.Location = new System.Drawing.Point(20, 27);
            this.railcarNumber.Name = "railcarNumber";
            this.railcarNumber.Size = new System.Drawing.Size(180, 20);
            this.railcarNumber.StyleController = this.generalLayout;
            this.railcarNumber.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider.SetValidationRule(this.railcarNumber, conditionValidationRule1);
            // 
            // pipeNumberLookUp
            // 
            this.pipeNumberLookUp.EditValue = "";
            this.pipeNumberLookUp.Location = new System.Drawing.Point(818, 27);
            this.pipeNumberLookUp.Name = "pipeNumberLookUp";
            this.pipeNumberLookUp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.pipeNumberLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeNumberLookUp.Properties.DisplayMember = "Number";
            this.pipeNumberLookUp.Properties.NullText = "";
            this.pipeNumberLookUp.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.FrameResize;
            this.pipeNumberLookUp.Properties.ValueMember = "Id";
            this.pipeNumberLookUp.Properties.View = this.pipeListLookUpView;
            this.pipeNumberLookUp.Size = new System.Drawing.Size(128, 20);
            this.pipeNumberLookUp.StyleController = this.generalLayout;
            this.pipeNumberLookUp.TabIndex = 4;
            // 
            // pipeListLookUpView
            // 
            this.pipeListLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeNumber,
            this.pipeSizeType});
            this.pipeListLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.pipeListLookUpView.Name = "pipeListLookUpView";
            this.pipeListLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.pipeListLookUpView.OptionsView.ShowGroupPanel = false;
            this.pipeListLookUpView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.pipeNumber, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // pipeNumber
            // 
            this.pipeNumber.Caption = "Номер трубы";
            this.pipeNumber.FieldName = "Number";
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Visible = true;
            this.pipeNumber.VisibleIndex = 0;
            // 
            // pipeSizeType
            // 
            this.pipeSizeType.Caption = "Типоразмер";
            this.pipeSizeType.FieldName = "Type";
            this.pipeSizeType.Name = "pipeSizeType";
            this.pipeSizeType.Visible = true;
            this.pipeSizeType.VisibleIndex = 1;
            // 
            // railcarLayoutGroup
            // 
            this.railcarLayoutGroup.CustomizationFormText = "Root";
            this.railcarLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.railcarLayoutGroup.GroupBordersVisible = false;
            this.railcarLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.railcarNumberLayout,
            this.shippedDateLayout,
            this.certificateNumberLayout,
            this.pipeListLayout,
            this.pipeNumberLayout,
            this.addPipeLayoutControl,
            this.removePipeLayoutControl,
            this.unshipButtonLayout,
            this.shipButtonLayout,
            this.buttonsEmptySpace,
            this.saveButtonLayout,
            this.layoutControlDestination,
            this.attachmentsButtonLayout});
            this.railcarLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.railcarLayoutGroup.Name = "Root";
            this.railcarLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.railcarLayoutGroup.Size = new System.Drawing.Size(1275, 510);
            this.railcarLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(16, 8, 0, 0);
            this.railcarLayoutGroup.Text = "Root";
            this.railcarLayoutGroup.TextVisible = false;
            // 
            // railcarNumberLayout
            // 
            this.railcarNumberLayout.Control = this.railcarNumber;
            this.railcarNumberLayout.CustomizationFormText = "Railcar number";
            this.railcarNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.railcarNumberLayout.Name = "railcarNumberLayout";
            this.railcarNumberLayout.Size = new System.Drawing.Size(199, 54);
            this.railcarNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 7);
            this.railcarNumberLayout.Text = "Номер ва&гона";
            this.railcarNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.railcarNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // shippedDateLayout
            // 
            this.shippedDateLayout.Control = this.shippedDate;
            this.shippedDateLayout.CustomizationFormText = "Shipped date";
            this.shippedDateLayout.Location = new System.Drawing.Point(199, 0);
            this.shippedDateLayout.Name = "shippedDateLayout";
            this.shippedDateLayout.Size = new System.Drawing.Size(135, 54);
            this.shippedDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.shippedDateLayout.Text = "Дата отгрузк&и";
            this.shippedDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.shippedDateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // certificateNumberLayout
            // 
            this.certificateNumberLayout.Control = this.certificateNumber;
            this.certificateNumberLayout.CustomizationFormText = "Certificate number";
            this.certificateNumberLayout.Location = new System.Drawing.Point(584, 0);
            this.certificateNumberLayout.Name = "certificateNumberLayout";
            this.certificateNumberLayout.Size = new System.Drawing.Size(199, 54);
            this.certificateNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.certificateNumberLayout.Text = "Номер се&ртификата";
            this.certificateNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // pipeListLayout
            // 
            this.pipeListLayout.Control = this.pipesList;
            this.pipeListLayout.CustomizationFormText = "Список труб";
            this.pipeListLayout.Location = new System.Drawing.Point(0, 54);
            this.pipeListLayout.Name = "pipeListLayout";
            this.pipeListLayout.Size = new System.Drawing.Size(1247, 421);
            this.pipeListLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 7);
            this.pipeListLayout.Text = "Список труб";
            this.pipeListLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeListLayout.TextSize = new System.Drawing.Size(0, 0);
            this.pipeListLayout.TextToControlDistance = 0;
            this.pipeListLayout.TextVisible = false;
            // 
            // pipeNumberLayout
            // 
            this.pipeNumberLayout.Control = this.pipeNumberLookUp;
            this.pipeNumberLayout.CustomizationFormText = "Ном&ер трубы";
            this.pipeNumberLayout.Location = new System.Drawing.Point(783, 0);
            this.pipeNumberLayout.Name = "pipeNumberLayout";
            this.pipeNumberLayout.Size = new System.Drawing.Size(162, 54);
            this.pipeNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.pipeNumberLayout.Text = "Ном&ер трубы";
            this.pipeNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // addPipeLayoutControl
            // 
            this.addPipeLayoutControl.Control = this.addPipeButton;
            this.addPipeLayoutControl.CustomizationFormText = "addPipelayoutControl";
            this.addPipeLayoutControl.Location = new System.Drawing.Point(945, 0);
            this.addPipeLayoutControl.Name = "addPipeLayoutControl";
            this.addPipeLayoutControl.Size = new System.Drawing.Size(154, 54);
            this.addPipeLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 21, 7);
            this.addPipeLayoutControl.Text = "addPipelayoutControl";
            this.addPipeLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.addPipeLayoutControl.TextToControlDistance = 0;
            this.addPipeLayoutControl.TextVisible = false;
            // 
            // removePipeLayoutControl
            // 
            this.removePipeLayoutControl.Control = this.removePipe;
            this.removePipeLayoutControl.CustomizationFormText = "removePipeLayoutControl";
            this.removePipeLayoutControl.Location = new System.Drawing.Point(1099, 0);
            this.removePipeLayoutControl.Name = "removePipeLayoutControl";
            this.removePipeLayoutControl.Size = new System.Drawing.Size(148, 54);
            this.removePipeLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 21, 7);
            this.removePipeLayoutControl.Text = "removePipeLayoutControl";
            this.removePipeLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.removePipeLayoutControl.TextToControlDistance = 0;
            this.removePipeLayoutControl.TextVisible = false;
            // 
            // unshipButtonLayout
            // 
            this.unshipButtonLayout.Control = this.unshipButton;
            this.unshipButtonLayout.CustomizationFormText = "unshipButtonLayout";
            this.unshipButtonLayout.Location = new System.Drawing.Point(999, 475);
            this.unshipButtonLayout.Name = "unshipButtonLayout";
            this.unshipButtonLayout.Size = new System.Drawing.Size(116, 31);
            this.unshipButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 5);
            this.unshipButtonLayout.Text = "unshipButtonLayout";
            this.unshipButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.unshipButtonLayout.TextToControlDistance = 0;
            this.unshipButtonLayout.TextVisible = false;
            // 
            // shipButtonLayout
            // 
            this.shipButtonLayout.Control = this.shipButton;
            this.shipButtonLayout.CustomizationFormText = "shipButtonLayout";
            this.shipButtonLayout.Location = new System.Drawing.Point(872, 475);
            this.shipButtonLayout.Name = "shipButtonLayout";
            this.shipButtonLayout.Size = new System.Drawing.Size(127, 31);
            this.shipButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 5, 0, 5);
            this.shipButtonLayout.Text = "shipButtonLayout";
            this.shipButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.shipButtonLayout.TextToControlDistance = 0;
            this.shipButtonLayout.TextVisible = false;
            // 
            // buttonsEmptySpace
            // 
            this.buttonsEmptySpace.AllowHotTrack = false;
            this.buttonsEmptySpace.CustomizationFormText = "buttonsEmptySpace";
            this.buttonsEmptySpace.Location = new System.Drawing.Point(99, 475);
            this.buttonsEmptySpace.Name = "buttonsEmptySpace";
            this.buttonsEmptySpace.Size = new System.Drawing.Size(773, 31);
            this.buttonsEmptySpace.Text = "buttonsEmptySpace";
            this.buttonsEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // saveButtonLayout
            // 
            this.saveButtonLayout.Control = this.saveButton;
            this.saveButtonLayout.CustomizationFormText = "saveButtonLayout";
            this.saveButtonLayout.Location = new System.Drawing.Point(1115, 475);
            this.saveButtonLayout.Name = "saveButtonLayout";
            this.saveButtonLayout.Size = new System.Drawing.Size(132, 31);
            this.saveButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 15, 0, 5);
            this.saveButtonLayout.Text = "saveButtonLayout";
            this.saveButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayout.TextToControlDistance = 0;
            this.saveButtonLayout.TextVisible = false;
            // 
            // layoutControlDestination
            // 
            this.layoutControlDestination.Control = this.destination;
            this.layoutControlDestination.CustomizationFormText = "&Получатель";
            this.layoutControlDestination.Location = new System.Drawing.Point(334, 0);
            this.layoutControlDestination.Name = "layoutControlDestination";
            this.layoutControlDestination.Size = new System.Drawing.Size(250, 54);
            this.layoutControlDestination.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.layoutControlDestination.Text = "&Получатель";
            this.layoutControlDestination.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlDestination.TextSize = new System.Drawing.Size(101, 13);
            // 
            // attachmentsButtonLayout
            // 
            this.attachmentsButtonLayout.Control = this.attachmentsButton;
            this.attachmentsButtonLayout.CustomizationFormText = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Location = new System.Drawing.Point(0, 475);
            this.attachmentsButtonLayout.Name = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Size = new System.Drawing.Size(99, 31);
            this.attachmentsButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5);
            this.attachmentsButtonLayout.Text = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.attachmentsButtonLayout.TextToControlDistance = 0;
            this.attachmentsButtonLayout.TextVisible = false;
            // 
            // layoutControlItemRailcar
            // 
            this.layoutControlItemRailcar.CustomizationFormText = "layoutControlItemRailcar";
            this.layoutControlItemRailcar.Location = new System.Drawing.Point(0, 445);
            this.layoutControlItemRailcar.Name = "layoutControlItem1";
            this.layoutControlItemRailcar.Size = new System.Drawing.Size(1247, 1);
            this.layoutControlItemRailcar.Text = "layoutControlItemRailcar";
            this.layoutControlItemRailcar.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItemRailcar.TextToControlDistance = 5;
            // 
            // RailcarNewEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 510);
            this.Controls.Add(this.generalLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RailcarNewEditXtraForm";
            this.Text = "Разрешение на отгрузку";
            this.Activated += new System.EventHandler(this.RailcarNewEditXtraForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RailcarNewEditXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.RailcarNewEditXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pipesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryGridLookUpEditStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).EndInit();
            this.generalLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destination.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeListLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeListLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPipeLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removePipeLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unshipButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRailcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl pipesList;
        private DevExpress.XtraGrid.Views.Grid.GridView pipesListView;
        private DevExpress.XtraEditors.SimpleButton unshipButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraGrid.Columns.GridColumn pipeNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pipeStatusGridColumn;
        private DevExpress.XtraLayout.LayoutControl generalLayout;
        private DevExpress.XtraEditors.DateEdit shippedDate;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraLayout.LayoutControlGroup railcarLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem certificateNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem railcarNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem shippedDateLayout;
        private DevExpress.XtraEditors.SimpleButton shipButton;
        private DevExpress.XtraLayout.LayoutControlItem pipeListLayout;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.SimpleButton addPipeButton;
        private DevExpress.XtraLayout.LayoutControlItem pipeNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem addPipeLayoutControl;
        private DevExpress.XtraEditors.SimpleButton removePipe;
        private DevExpress.XtraLayout.LayoutControlItem removePipeLayoutControl;
        private DevExpress.XtraEditors.TextEdit railcarNumber;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem unshipButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem shipButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem buttonsEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRailcar;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryGridLookUpEditStatus;
        private DevExpress.XtraEditors.GridLookUpEdit pipeNumberLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView pipeListLookUpView;
        private DevExpress.XtraGrid.Columns.GridColumn pipeNumber;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeType;
        private DevExpress.XtraEditors.TextEdit destination;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlDestination;
        private DevExpress.XtraEditors.SimpleButton attachmentsButton;
        private DevExpress.XtraLayout.LayoutControlItem attachmentsButtonLayout;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}