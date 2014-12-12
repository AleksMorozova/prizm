﻿namespace PrizmMain.Forms.Component.NewEdit
{
    partial class ComponentNewEditXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentNewEditXtraForm));
            this.componentNumber = new DevExpress.XtraEditors.TextEdit();
            this.newEditPipeLayout = new DevExpress.XtraLayout.LayoutControl();
            this.componentLength = new DevExpress.XtraEditors.TextEdit();
            this.type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.componentDeactivated = new DevExpress.XtraEditors.CheckEdit();
            this.newSaveComponentButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveComponentButton = new DevExpress.XtraEditors.SimpleButton();
            this.attachmentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.inspectionHistoryGrid = new DevExpress.XtraGrid.GridControl();
            this.inspectionHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectionDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryInspectionDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.inspectorColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryInspectionStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.reasonColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.componentParameters = new DevExpress.XtraGrid.GridControl();
            this.componentParametersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.diameterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wallThicknessGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.componentNewLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.InspectionLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspectionHistoryGridLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.newComponentLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.componentNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.parametersGridLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.attachmentsButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.typeLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceBetweenButtons = new DevExpress.XtraLayout.EmptySpaceItem();
            this.attachmentsButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.newSaveLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlDeactivation = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceUnderButtons = new DevExpress.XtraLayout.EmptySpaceItem();
            this.componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEditPipeLayout)).BeginInit();
            this.newEditPipeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componentLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentDeactivated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInspectionDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInspectionDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInspectionStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParametersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNewLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGridLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newComponentLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersGridLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceBetweenButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSaveLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDeactivation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceUnderButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // componentNumber
            // 
            this.componentNumber.Location = new System.Drawing.Point(44, 71);
            this.componentNumber.Name = "componentNumber";
            this.componentNumber.Size = new System.Drawing.Size(148, 20);
            this.componentNumber.StyleController = this.newEditPipeLayout;
            this.componentNumber.TabIndex = 0;
            this.componentNumber.EditValueChanged += new System.EventHandler(this.componentNumber_EditValueChanged);
            // 
            // newEditPipeLayout
            // 
            this.newEditPipeLayout.Controls.Add(this.componentLength);
            this.newEditPipeLayout.Controls.Add(this.type);
            this.newEditPipeLayout.Controls.Add(this.componentDeactivated);
            this.newEditPipeLayout.Controls.Add(this.newSaveComponentButton);
            this.newEditPipeLayout.Controls.Add(this.saveComponentButton);
            this.newEditPipeLayout.Controls.Add(this.attachmentsButton);
            this.newEditPipeLayout.Controls.Add(this.inspectionHistoryGrid);
            this.newEditPipeLayout.Controls.Add(this.componentParameters);
            this.newEditPipeLayout.Controls.Add(this.certificateNumber);
            this.newEditPipeLayout.Controls.Add(this.componentNumber);
            this.newEditPipeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newEditPipeLayout.Location = new System.Drawing.Point(0, 0);
            this.newEditPipeLayout.Name = "newEditPipeLayout";
            this.newEditPipeLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(295, 163, 250, 350);
            this.newEditPipeLayout.Root = this.componentNewLayoutGroup;
            this.newEditPipeLayout.Size = new System.Drawing.Size(1009, 485);
            this.newEditPipeLayout.TabIndex = 8;
            this.newEditPipeLayout.Text = "layoutControl1";
            // 
            // componentLength
            // 
            this.componentLength.Location = new System.Drawing.Point(226, 125);
            this.componentLength.Name = "componentLength";
            this.componentLength.Size = new System.Drawing.Size(143, 20);
            this.componentLength.StyleController = this.newEditPipeLayout;
            this.componentLength.TabIndex = 18;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(226, 71);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Size = new System.Drawing.Size(143, 20);
            this.type.StyleController = this.newEditPipeLayout;
            this.type.TabIndex = 17;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // componentDeactivated
            // 
            this.componentDeactivated.Location = new System.Drawing.Point(151, 444);
            this.componentDeactivated.Name = "componentDeactivated";
            this.componentDeactivated.Properties.Caption = "Компонент деактивирован";
            this.componentDeactivated.Size = new System.Drawing.Size(287, 19);
            this.componentDeactivated.StyleController = this.newEditPipeLayout;
            this.componentDeactivated.TabIndex = 15;
            this.componentDeactivated.Modified += new System.EventHandler(this.componentDeactivated_Modified);
            // 
            // newSaveComponentButton
            // 
            this.newSaveComponentButton.Image = ((System.Drawing.Image)(resources.GetObject("newSaveComponentButton.Image")));
            this.newSaveComponentButton.Location = new System.Drawing.Point(847, 444);
            this.newSaveComponentButton.Name = "newSaveComponentButton";
            this.newSaveComponentButton.Size = new System.Drawing.Size(145, 22);
            this.newSaveComponentButton.StyleController = this.newEditPipeLayout;
            this.newSaveComponentButton.TabIndex = 14;
            this.newSaveComponentButton.Text = "Сохранить / Создать";
            // 
            // saveComponentButton
            // 
            this.saveComponentButton.Image = ((System.Drawing.Image)(resources.GetObject("saveComponentButton.Image")));
            this.saveComponentButton.Location = new System.Drawing.Point(729, 444);
            this.saveComponentButton.Name = "saveComponentButton";
            this.saveComponentButton.Size = new System.Drawing.Size(94, 22);
            this.saveComponentButton.StyleController = this.newEditPipeLayout;
            this.saveComponentButton.TabIndex = 13;
            this.saveComponentButton.Text = "Сохранить";
            // 
            // attachmentsButton
            // 
            this.attachmentsButton.Image = ((System.Drawing.Image)(resources.GetObject("attachmentsButton.Image")));
            this.attachmentsButton.Location = new System.Drawing.Point(27, 444);
            this.attachmentsButton.Name = "attachmentsButton";
            this.attachmentsButton.Size = new System.Drawing.Size(100, 22);
            this.attachmentsButton.StyleController = this.newEditPipeLayout;
            this.attachmentsButton.TabIndex = 12;
            this.attachmentsButton.Text = "Вложения";
            this.attachmentsButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // inspectionHistoryGrid
            // 
            this.inspectionHistoryGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspectionHistoryGrid.Location = new System.Drawing.Point(422, 48);
            this.inspectionHistoryGrid.MainView = this.inspectionHistoryGridView;
            this.inspectionHistoryGrid.Name = "inspectionHistoryGrid";
            this.inspectionHistoryGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryInspectionDate,
            this.repositoryInspectionStatus});
            this.inspectionHistoryGrid.Size = new System.Drawing.Size(558, 255);
            this.inspectionHistoryGrid.TabIndex = 9;
            this.inspectionHistoryGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionHistoryGridView});
            // 
            // inspectionHistoryGridView
            // 
            this.inspectionHistoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectionDateColumn,
            this.inspectorColumn,
            this.resultColumn,
            this.reasonColumn});
            this.inspectionHistoryGridView.GridControl = this.inspectionHistoryGrid;
            this.inspectionHistoryGridView.Name = "inspectionHistoryGridView";
            this.inspectionHistoryGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.inspectionHistoryGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.inspectionHistoryGridView.OptionsView.ShowGroupPanel = false;
            this.inspectionHistoryGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.inspectionHistoryGridView_InitNewRow);
            // 
            // inspectionDateColumn
            // 
            this.inspectionDateColumn.Caption = "Дата инспекции";
            this.inspectionDateColumn.ColumnEdit = this.repositoryInspectionDate;
            this.inspectionDateColumn.FieldName = "Date";
            this.inspectionDateColumn.Name = "inspectionDateColumn";
            this.inspectionDateColumn.Visible = true;
            this.inspectionDateColumn.VisibleIndex = 0;
            this.inspectionDateColumn.Width = 100;
            // 
            // repositoryInspectionDate
            // 
            this.repositoryInspectionDate.AutoHeight = false;
            this.repositoryInspectionDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryInspectionDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryInspectionDate.Name = "repositoryInspectionDate";
            // 
            // inspectorColumn
            // 
            this.inspectorColumn.Caption = "Инспектор";
            this.inspectorColumn.Name = "inspectorColumn";
            this.inspectorColumn.Visible = true;
            this.inspectorColumn.VisibleIndex = 1;
            // 
            // resultColumn
            // 
            this.resultColumn.Caption = "Результат";
            this.resultColumn.ColumnEdit = this.repositoryInspectionStatus;
            this.resultColumn.FieldName = "Status";
            this.resultColumn.Name = "resultColumn";
            this.resultColumn.Visible = true;
            this.resultColumn.VisibleIndex = 2;
            this.resultColumn.Width = 100;
            // 
            // repositoryInspectionStatus
            // 
            this.repositoryInspectionStatus.AutoHeight = false;
            this.repositoryInspectionStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryInspectionStatus.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value")});
            this.repositoryInspectionStatus.DisplayMember = "Value";
            this.repositoryInspectionStatus.DropDownRows = 5;
            this.repositoryInspectionStatus.Name = "repositoryInspectionStatus";
            this.repositoryInspectionStatus.NullText = "";
            this.repositoryInspectionStatus.ShowHeader = false;
            this.repositoryInspectionStatus.EditValueChanged += new System.EventHandler(this.repositoryInspectionStatus_EditValueChanged);
            this.repositoryInspectionStatus.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.repositoryInspectionStatus_CustomDisplayText);
            // 
            // reasonColumn
            // 
            this.reasonColumn.Caption = "Причина";
            this.reasonColumn.FieldName = "Value";
            this.reasonColumn.Name = "reasonColumn";
            this.reasonColumn.Visible = true;
            this.reasonColumn.VisibleIndex = 3;
            // 
            // componentParameters
            // 
            this.componentParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.componentParameters.Location = new System.Drawing.Point(44, 163);
            this.componentParameters.MainView = this.componentParametersView;
            this.componentParameters.Name = "componentParameters";
            this.componentParameters.Size = new System.Drawing.Size(325, 123);
            this.componentParameters.TabIndex = 4;
            this.componentParameters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.componentParametersView});
            // 
            // componentParametersView
            // 
            this.componentParametersView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.diameterGridColumn,
            this.wallThicknessGridColumn});
            this.componentParametersView.GridControl = this.componentParameters;
            this.componentParametersView.Name = "componentParametersView";
            this.componentParametersView.OptionsView.ShowGroupPanel = false;
            // 
            // diameterGridColumn
            // 
            this.diameterGridColumn.Caption = "Диаметр отверстия";
            this.diameterGridColumn.FieldName = "Diameter";
            this.diameterGridColumn.Name = "diameterGridColumn";
            this.diameterGridColumn.Visible = true;
            this.diameterGridColumn.VisibleIndex = 0;
            // 
            // wallThicknessGridColumn
            // 
            this.wallThicknessGridColumn.Caption = "Толщина стенки";
            this.wallThicknessGridColumn.FieldName = "WallThickness";
            this.wallThicknessGridColumn.Name = "wallThicknessGridColumn";
            this.wallThicknessGridColumn.Visible = true;
            this.wallThicknessGridColumn.VisibleIndex = 1;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(44, 125);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(148, 20);
            this.certificateNumber.StyleController = this.newEditPipeLayout;
            this.certificateNumber.TabIndex = 2;
            // 
            // componentNewLayoutGroup
            // 
            this.componentNewLayoutGroup.CustomizationFormText = "componentNewLayoutGroup";
            this.componentNewLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.componentNewLayoutGroup.GroupBordersVisible = false;
            this.componentNewLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.InspectionLayoutGroup,
            this.newComponentLayoutGroup,
            this.emptySpaceBetweenButtons,
            this.attachmentsButtonLayout,
            this.newSaveLayoutControl,
            this.saveButtonLayoutControl,
            this.layoutControlDeactivation,
            this.emptySpaceUnderButtons});
            this.componentNewLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.componentNewLayoutGroup.Name = "componentNewLayoutGroup";
            this.componentNewLayoutGroup.Size = new System.Drawing.Size(1009, 485);
            this.componentNewLayoutGroup.Text = "componentNewLayoutGroup";
            this.componentNewLayoutGroup.TextVisible = false;
            // 
            // InspectionLayoutGroup
            // 
            this.InspectionLayoutGroup.CustomizationFormText = "Inspection";
            this.InspectionLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectionHistoryGridLayout});
            this.InspectionLayoutGroup.Location = new System.Drawing.Point(393, 0);
            this.InspectionLayoutGroup.Name = "InspectionLayoutGroup";
            this.InspectionLayoutGroup.Size = new System.Drawing.Size(596, 312);
            this.InspectionLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 7, 7);
            this.InspectionLayoutGroup.Text = "Входной контроль";
            // 
            // inspectionHistoryGridLayout
            // 
            this.inspectionHistoryGridLayout.Control = this.inspectionHistoryGrid;
            this.inspectionHistoryGridLayout.CustomizationFormText = "inspectionHistoryGridLayout";
            this.inspectionHistoryGridLayout.Location = new System.Drawing.Point(0, 0);
            this.inspectionHistoryGridLayout.Name = "inspectionHistoryGridLayout";
            this.inspectionHistoryGridLayout.Size = new System.Drawing.Size(562, 259);
            this.inspectionHistoryGridLayout.Text = "inspectionHistoryGridLayout";
            this.inspectionHistoryGridLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectionHistoryGridLayout.TextSize = new System.Drawing.Size(0, 0);
            this.inspectionHistoryGridLayout.TextToControlDistance = 0;
            this.inspectionHistoryGridLayout.TextVisible = false;
            // 
            // newComponentLayoutGroup
            // 
            this.newComponentLayoutGroup.CustomizationFormText = "Комплектующее изделие";
            this.newComponentLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.componentNumberLayout,
            this.certificateLayout,
            this.parametersGridLayout,
            this.attachmentsButtonEmptySpace,
            this.typeLayoutControl,
            this.layoutControlItem1});
            this.newComponentLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.newComponentLayoutGroup.Name = "newComponentLayoutGroup";
            this.newComponentLayoutGroup.Size = new System.Drawing.Size(393, 312);
            this.newComponentLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 7, 7);
            this.newComponentLayoutGroup.Text = "Комплектующее изделие";
            // 
            // componentNumberLayout
            // 
            this.componentNumberLayout.Control = this.componentNumber;
            this.componentNumberLayout.CustomizationFormText = "Component number";
            this.componentNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.componentNumberLayout.Name = "componentNumberLayout";
            this.componentNumberLayout.Size = new System.Drawing.Size(182, 54);
            this.componentNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.componentNumberLayout.Text = "Номер изделия";
            this.componentNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.componentNumberLayout.TextSize = new System.Drawing.Size(143, 13);
            // 
            // certificateLayout
            // 
            this.certificateLayout.Control = this.certificateNumber;
            this.certificateLayout.CustomizationFormText = "Certificate number";
            this.certificateLayout.Location = new System.Drawing.Point(0, 54);
            this.certificateLayout.Name = "certificateLayout";
            this.certificateLayout.Size = new System.Drawing.Size(182, 54);
            this.certificateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.certificateLayout.Text = "Номер сертификата";
            this.certificateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateLayout.TextSize = new System.Drawing.Size(143, 13);
            // 
            // parametersGridLayout
            // 
            this.parametersGridLayout.Control = this.componentParameters;
            this.parametersGridLayout.CustomizationFormText = "parametersGridLayout";
            this.parametersGridLayout.Location = new System.Drawing.Point(0, 108);
            this.parametersGridLayout.Name = "parametersGridLayout";
            this.parametersGridLayout.Size = new System.Drawing.Size(359, 141);
            this.parametersGridLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.parametersGridLayout.Text = "parametersGridLayout";
            this.parametersGridLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.parametersGridLayout.TextSize = new System.Drawing.Size(0, 0);
            this.parametersGridLayout.TextToControlDistance = 0;
            this.parametersGridLayout.TextVisible = false;
            // 
            // attachmentsButtonEmptySpace
            // 
            this.attachmentsButtonEmptySpace.AllowHotTrack = false;
            this.attachmentsButtonEmptySpace.CustomizationFormText = "attachmentsButtonEmptySpace";
            this.attachmentsButtonEmptySpace.Location = new System.Drawing.Point(0, 249);
            this.attachmentsButtonEmptySpace.Name = "attachmentsButtonEmptySpace";
            this.attachmentsButtonEmptySpace.Size = new System.Drawing.Size(359, 10);
            this.attachmentsButtonEmptySpace.Text = "attachmentsButtonEmptySpace";
            this.attachmentsButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // typeLayoutControl
            // 
            this.typeLayoutControl.Control = this.type;
            this.typeLayoutControl.CustomizationFormText = "Type";
            this.typeLayoutControl.Location = new System.Drawing.Point(182, 0);
            this.typeLayoutControl.Name = "typeLayoutControl";
            this.typeLayoutControl.Size = new System.Drawing.Size(177, 54);
            this.typeLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.typeLayoutControl.Text = "Тип изделия";
            this.typeLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.typeLayoutControl.TextSize = new System.Drawing.Size(143, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.componentLength;
            this.layoutControlItem1.CustomizationFormText = "Длина комплектующего, мм";
            this.layoutControlItem1.Location = new System.Drawing.Point(182, 54);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(177, 54);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.layoutControlItem1.Text = "Длина комплектующего, мм";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(143, 13);
            // 
            // emptySpaceBetweenButtons
            // 
            this.emptySpaceBetweenButtons.AllowHotTrack = false;
            this.emptySpaceBetweenButtons.CustomizationFormText = "emptySpaceBetweenButtons";
            this.emptySpaceBetweenButtons.Location = new System.Drawing.Point(435, 425);
            this.emptySpaceBetweenButtons.Name = "emptySpaceBetweenButtons";
            this.emptySpaceBetweenButtons.Size = new System.Drawing.Size(267, 40);
            this.emptySpaceBetweenButtons.Text = "emptySpaceBetweenButtons";
            this.emptySpaceBetweenButtons.TextSize = new System.Drawing.Size(0, 0);
            // 
            // attachmentsButtonLayout
            // 
            this.attachmentsButtonLayout.Control = this.attachmentsButton;
            this.attachmentsButtonLayout.CustomizationFormText = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Location = new System.Drawing.Point(0, 425);
            this.attachmentsButtonLayout.Name = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Size = new System.Drawing.Size(124, 40);
            this.attachmentsButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 5, 7, 7);
            this.attachmentsButtonLayout.Text = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.attachmentsButtonLayout.TextToControlDistance = 0;
            this.attachmentsButtonLayout.TextVisible = false;
            // 
            // newSaveLayoutControl
            // 
            this.newSaveLayoutControl.Control = this.newSaveComponentButton;
            this.newSaveLayoutControl.CustomizationFormText = "newSaveLayoutControl";
            this.newSaveLayoutControl.Location = new System.Drawing.Point(820, 425);
            this.newSaveLayoutControl.Name = "newSaveLayoutControl";
            this.newSaveLayoutControl.Size = new System.Drawing.Size(169, 40);
            this.newSaveLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 5, 7, 7);
            this.newSaveLayoutControl.Text = "newSaveLayoutControl";
            this.newSaveLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.newSaveLayoutControl.TextToControlDistance = 0;
            this.newSaveLayoutControl.TextVisible = false;
            // 
            // saveButtonLayoutControl
            // 
            this.saveButtonLayoutControl.Control = this.saveComponentButton;
            this.saveButtonLayoutControl.CustomizationFormText = "saveButtonLayoutControl";
            this.saveButtonLayoutControl.Location = new System.Drawing.Point(702, 425);
            this.saveButtonLayoutControl.Name = "saveButtonLayoutControl";
            this.saveButtonLayoutControl.Size = new System.Drawing.Size(118, 40);
            this.saveButtonLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 5, 7, 7);
            this.saveButtonLayoutControl.Text = "saveButtonLayoutControl";
            this.saveButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayoutControl.TextToControlDistance = 0;
            this.saveButtonLayoutControl.TextVisible = false;
            // 
            // layoutControlDeactivation
            // 
            this.layoutControlDeactivation.Control = this.componentDeactivated;
            this.layoutControlDeactivation.CustomizationFormText = "layoutControlDeactivation";
            this.layoutControlDeactivation.Location = new System.Drawing.Point(124, 425);
            this.layoutControlDeactivation.Name = "layoutControlDeactivation";
            this.layoutControlDeactivation.Size = new System.Drawing.Size(311, 40);
            this.layoutControlDeactivation.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 5, 7, 7);
            this.layoutControlDeactivation.Text = "layoutControlDeactivation";
            this.layoutControlDeactivation.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlDeactivation.TextToControlDistance = 0;
            this.layoutControlDeactivation.TextVisible = false;
            // 
            // emptySpaceUnderButtons
            // 
            this.emptySpaceUnderButtons.AllowHotTrack = false;
            this.emptySpaceUnderButtons.CustomizationFormText = "emptySpaceUnderButtons";
            this.emptySpaceUnderButtons.Location = new System.Drawing.Point(0, 312);
            this.emptySpaceUnderButtons.Name = "emptySpaceUnderButtons";
            this.emptySpaceUnderButtons.Size = new System.Drawing.Size(989, 113);
            this.emptySpaceUnderButtons.Text = "emptySpaceUnderButtons";
            this.emptySpaceUnderButtons.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ComponentNewEditXtraForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 485);
            this.Controls.Add(this.newEditPipeLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentNewEditXtraForm";
            this.Text = " Комлектующее изделие";
            this.Load += new System.EventHandler(this.ComponentNewEditXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEditPipeLayout)).EndInit();
            this.newEditPipeLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.componentLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentDeactivated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInspectionDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInspectionDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInspectionStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParametersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNewLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGridLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newComponentLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersGridLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceBetweenButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSaveLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDeactivation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceUnderButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit componentNumber;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraGrid.GridControl componentParameters;
        private DevExpress.XtraGrid.Views.Grid.GridView componentParametersView;
        private DevExpress.XtraGrid.Columns.GridColumn diameterGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn wallThicknessGridColumn;
        private DevExpress.XtraLayout.LayoutControl newEditPipeLayout;
        private DevExpress.XtraLayout.LayoutControlGroup componentNewLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem parametersGridLayout;
        private DevExpress.XtraLayout.LayoutControlGroup InspectionLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem certificateLayout;
        private DevExpress.XtraLayout.LayoutControlItem componentNumberLayout;
        private DevExpress.XtraLayout.LayoutControlGroup newComponentLayoutGroup;
        private DevExpress.XtraGrid.GridControl inspectionHistoryGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionHistoryGridView;
        private DevExpress.XtraLayout.LayoutControlItem inspectionHistoryGridLayout;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorColumn;
        private DevExpress.XtraGrid.Columns.GridColumn resultColumn;
        private DevExpress.XtraGrid.Columns.GridColumn reasonColumn;
        private DevExpress.XtraEditors.SimpleButton attachmentsButton;
        private DevExpress.XtraLayout.LayoutControlItem attachmentsButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem attachmentsButtonEmptySpace;
        private DevExpress.XtraEditors.SimpleButton newSaveComponentButton;
        private DevExpress.XtraEditors.SimpleButton saveComponentButton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceBetweenButtons;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceUnderButtons;
        private DevExpress.XtraLayout.LayoutControlItem newSaveLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayoutControl;
        private System.Windows.Forms.BindingSource componentBindingSource;
        private DevExpress.XtraEditors.CheckEdit componentDeactivated;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlDeactivation;
        private DevExpress.XtraEditors.ComboBoxEdit type;
        private DevExpress.XtraLayout.LayoutControlItem typeLayoutControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryInspectionDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryInspectionStatus;
        private DevExpress.XtraEditors.TextEdit componentLength;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}