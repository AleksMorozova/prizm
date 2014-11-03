﻿namespace PrizmMain.Forms
{
    partial class ComponentSearchXtraForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentSearchXtraForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.diameterThicknessSubGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.diameterColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thicknessColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchResultsGrid = new DevExpress.XtraGrid.GridControl();
            this.searchResultsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionResultColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editButtonColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.searchComponentryButton = new DevExpress.XtraEditors.SimpleButton();
            this.searchComponentLayout = new DevExpress.XtraLayout.LayoutControl();
            this.componentNumber = new DevExpress.XtraEditors.TextEdit();
            this.componentType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.certificate = new DevExpress.XtraEditors.TextEdit();
            this.serchEditLayout = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchGridLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchGridLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.serchParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.componentNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.componentTypeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.underButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.leftButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.diameterThicknessSubGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchComponentLayout)).BeginInit();
            this.searchComponentLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serchEditLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serchParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentTypeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonEmptySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // diameterThicknessSubGrid
            // 
            this.diameterThicknessSubGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.diameterColumn,
            this.thicknessColumn});
            this.diameterThicknessSubGrid.GridControl = this.searchResultsGrid;
            this.diameterThicknessSubGrid.Name = "diameterThicknessSubGrid";
            this.diameterThicknessSubGrid.OptionsView.ShowGroupPanel = false;
            this.diameterThicknessSubGrid.ViewCaption = "Конекторы";
            // 
            // diameterColumn
            // 
            this.diameterColumn.Caption = "Диаметр отверстия";
            this.diameterColumn.FieldName = "Diameter";
            this.diameterColumn.Name = "diameterColumn";
            this.diameterColumn.Visible = true;
            this.diameterColumn.VisibleIndex = 0;
            // 
            // thicknessColumn
            // 
            this.thicknessColumn.Caption = "Толщина стенки";
            this.thicknessColumn.FieldName = "Thickness";
            this.thicknessColumn.Name = "thicknessColumn";
            this.thicknessColumn.Visible = true;
            this.thicknessColumn.VisibleIndex = 1;
            // 
            // searchResultsGrid
            // 
            this.searchResultsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            gridLevelNode1.LevelTemplate = this.diameterThicknessSubGrid;
            gridLevelNode1.RelationName = "Tails";
            this.searchResultsGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.searchResultsGrid.Location = new System.Drawing.Point(25, 155);
            this.searchResultsGrid.MainView = this.searchResultsView;
            this.searchResultsGrid.Name = "searchResultsGrid";
            this.searchResultsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryButtonEdit});
            this.searchResultsGrid.Size = new System.Drawing.Size(862, 241);
            this.searchResultsGrid.TabIndex = 7;
            this.searchResultsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.searchResultsView,
            this.diameterThicknessSubGrid});
            // 
            // searchResultsView
            // 
            this.searchResultsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.numberColumn,
            this.typeColumn,
            this.certificateNumberColumn,
            this.inspectorColumn,
            this.inspectionResultColumn,
            this.inspectionDateColumn,
            this.editButtonColumn});
            this.searchResultsView.GridControl = this.searchResultsGrid;
            this.searchResultsView.Name = "searchResultsView";
            this.searchResultsView.OptionsView.ShowGroupPanel = false;
            // 
            // numberColumn
            // 
            this.numberColumn.Caption = "№";
            this.numberColumn.FieldName = "Number";
            this.numberColumn.Name = "numberColumn";
            this.numberColumn.Visible = true;
            this.numberColumn.VisibleIndex = 0;
            // 
            // typeColumn
            // 
            this.typeColumn.Caption = "Тип";
            this.typeColumn.FieldName = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.Visible = true;
            this.typeColumn.VisibleIndex = 1;
            // 
            // certificateNumberColumn
            // 
            this.certificateNumberColumn.Caption = "Номер сертификата";
            this.certificateNumberColumn.FieldName = "CertificateNumber";
            this.certificateNumberColumn.Name = "certificateNumberColumn";
            this.certificateNumberColumn.Visible = true;
            this.certificateNumberColumn.VisibleIndex = 2;
            // 
            // inspectorColumn
            // 
            this.inspectorColumn.Caption = "Инспектор";
            this.inspectorColumn.FieldName = "Inspector";
            this.inspectorColumn.Name = "inspectorColumn";
            this.inspectorColumn.Visible = true;
            this.inspectorColumn.VisibleIndex = 3;
            // 
            // inspectionResultColumn
            // 
            this.inspectionResultColumn.Caption = "Результат";
            this.inspectionResultColumn.FieldName = "InspectionResult";
            this.inspectionResultColumn.Name = "inspectionResultColumn";
            this.inspectionResultColumn.Visible = true;
            this.inspectionResultColumn.VisibleIndex = 4;
            // 
            // inspectionDateColumn
            // 
            this.inspectionDateColumn.Caption = "Дата инспекции";
            this.inspectionDateColumn.FieldName = "InspectionDate";
            this.inspectionDateColumn.Name = "inspectionDateColumn";
            this.inspectionDateColumn.Visible = true;
            this.inspectionDateColumn.VisibleIndex = 5;
            // 
            // editButtonColumn
            // 
            this.editButtonColumn.Caption = "Редактировать";
            this.editButtonColumn.ColumnEdit = this.repositoryButtonEdit;
            this.editButtonColumn.Name = "editButtonColumn";
            this.editButtonColumn.Visible = true;
            this.editButtonColumn.VisibleIndex = 6;
            // 
            // repositoryButtonEdit
            // 
            this.repositoryButtonEdit.AutoHeight = false;
            this.repositoryButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryButtonEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryButtonEdit.Name = "repositoryButtonEdit";
            this.repositoryButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // searchComponentryButton
            // 
            this.searchComponentryButton.Location = new System.Drawing.Point(810, 69);
            this.searchComponentryButton.Name = "searchComponentryButton";
            this.searchComponentryButton.Size = new System.Drawing.Size(77, 22);
            this.searchComponentryButton.StyleController = this.searchComponentLayout;
            this.searchComponentryButton.TabIndex = 3;
            this.searchComponentryButton.Text = "Поиск";
            // 
            // searchComponentLayout
            // 
            this.searchComponentLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchComponentLayout.Controls.Add(this.searchResultsGrid);
            this.searchComponentLayout.Controls.Add(this.componentNumber);
            this.searchComponentLayout.Controls.Add(this.searchComponentryButton);
            this.searchComponentLayout.Controls.Add(this.componentType);
            this.searchComponentLayout.Controls.Add(this.certificate);
            this.searchComponentLayout.Location = new System.Drawing.Point(13, 13);
            this.searchComponentLayout.Name = "searchComponentLayout";
            this.searchComponentLayout.Root = this.serchEditLayout;
            this.searchComponentLayout.Size = new System.Drawing.Size(912, 425);
            this.searchComponentLayout.TabIndex = 8;
            this.searchComponentLayout.Text = "searchComponentLayout";
            // 
            // componentNumber
            // 
            this.componentNumber.Location = new System.Drawing.Point(40, 71);
            this.componentNumber.Name = "componentNumber";
            this.componentNumber.Size = new System.Drawing.Size(207, 20);
            this.componentNumber.StyleController = this.searchComponentLayout;
            this.componentNumber.TabIndex = 0;
            // 
            // componentType
            // 
            this.componentType.Location = new System.Drawing.Point(281, 71);
            this.componentType.Name = "componentType";
            this.componentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.componentType.Size = new System.Drawing.Size(207, 20);
            this.componentType.StyleController = this.searchComponentLayout;
            this.componentType.TabIndex = 1;
            // 
            // certificate
            // 
            this.certificate.Location = new System.Drawing.Point(522, 71);
            this.certificate.Name = "certificate";
            this.certificate.Size = new System.Drawing.Size(206, 20);
            this.certificate.StyleController = this.searchComponentLayout;
            this.certificate.TabIndex = 2;
            // 
            // serchEditLayout
            // 
            this.serchEditLayout.CustomizationFormText = "serchEditLayout";
            this.serchEditLayout.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.serchEditLayout.GroupBordersVisible = false;
            this.serchEditLayout.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchGridLayoutGroup,
            this.serchParametersLayoutGroup});
            this.serchEditLayout.Location = new System.Drawing.Point(0, 0);
            this.serchEditLayout.Name = "serchEditLayout";
            this.serchEditLayout.Size = new System.Drawing.Size(912, 425);
            this.serchEditLayout.Text = "serchEditLayout";
            this.serchEditLayout.TextVisible = false;
            // 
            // searchGridLayoutGroup
            // 
            this.searchGridLayoutGroup.CustomizationFormText = "Результаты поиска";
            this.searchGridLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchGridLayout});
            this.searchGridLayoutGroup.Location = new System.Drawing.Point(0, 107);
            this.searchGridLayoutGroup.Name = "searchGridLayoutGroup";
            this.searchGridLayoutGroup.Size = new System.Drawing.Size(892, 298);
            this.searchGridLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 7, 7);
            this.searchGridLayoutGroup.Text = "Результаты поиска";
            // 
            // searchGridLayout
            // 
            this.searchGridLayout.Control = this.searchResultsGrid;
            this.searchGridLayout.CustomizationFormText = "searchGridLayout";
            this.searchGridLayout.Location = new System.Drawing.Point(0, 0);
            this.searchGridLayout.Name = "searchGridLayout";
            this.searchGridLayout.Size = new System.Drawing.Size(866, 245);
            this.searchGridLayout.Text = "searchGridLayout";
            this.searchGridLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.searchGridLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchGridLayout.TextToControlDistance = 0;
            this.searchGridLayout.TextVisible = false;
            // 
            // serchParametersLayoutGroup
            // 
            this.serchParametersLayoutGroup.CustomizationFormText = "Параметры поиска";
            this.serchParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.componentNumberLayout,
            this.componentTypeLayout,
            this.certificateLayout,
            this.searchButtonLayout,
            this.underButtonEmptySpace,
            this.leftButtonEmptySpace});
            this.serchParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.serchParametersLayoutGroup.Name = "serchParametersLayoutGroup";
            this.serchParametersLayoutGroup.Size = new System.Drawing.Size(892, 107);
            this.serchParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 7, 7);
            this.serchParametersLayoutGroup.Text = "Параметры поиска";
            // 
            // componentNumberLayout
            // 
            this.componentNumberLayout.Control = this.componentNumber;
            this.componentNumberLayout.CustomizationFormText = "Номер комплектующего";
            this.componentNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.componentNumberLayout.Name = "componentNumberLayout";
            this.componentNumberLayout.Size = new System.Drawing.Size(241, 54);
            this.componentNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.componentNumberLayout.Text = "Номер комплектующего";
            this.componentNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.componentNumberLayout.TextSize = new System.Drawing.Size(123, 13);
            // 
            // componentTypeLayout
            // 
            this.componentTypeLayout.Control = this.componentType;
            this.componentTypeLayout.CustomizationFormText = "Тип";
            this.componentTypeLayout.Location = new System.Drawing.Point(241, 0);
            this.componentTypeLayout.Name = "componentTypeLayout";
            this.componentTypeLayout.Size = new System.Drawing.Size(241, 54);
            this.componentTypeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.componentTypeLayout.Text = "Тип";
            this.componentTypeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.componentTypeLayout.TextSize = new System.Drawing.Size(123, 13);
            // 
            // certificateLayout
            // 
            this.certificateLayout.Control = this.certificate;
            this.certificateLayout.CustomizationFormText = "Сертификат";
            this.certificateLayout.Location = new System.Drawing.Point(482, 0);
            this.certificateLayout.Name = "certificateLayout";
            this.certificateLayout.Size = new System.Drawing.Size(240, 54);
            this.certificateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.certificateLayout.Text = "Сертификат";
            this.certificateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateLayout.TextSize = new System.Drawing.Size(123, 13);
            // 
            // searchButtonLayout
            // 
            this.searchButtonLayout.Control = this.searchComponentryButton;
            this.searchButtonLayout.CustomizationFormText = "searchButtonLayout";
            this.searchButtonLayout.Location = new System.Drawing.Point(755, 14);
            this.searchButtonLayout.MaxSize = new System.Drawing.Size(111, 40);
            this.searchButtonLayout.MinSize = new System.Drawing.Size(111, 40);
            this.searchButtonLayout.Name = "searchButtonLayout";
            this.searchButtonLayout.Size = new System.Drawing.Size(111, 40);
            this.searchButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.searchButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(30, 0, 7, 7);
            this.searchButtonLayout.Text = "searchButtonLayout";
            this.searchButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchButtonLayout.TextToControlDistance = 0;
            this.searchButtonLayout.TextVisible = false;
            this.searchButtonLayout.TrimClientAreaToControl = false;
            // 
            // underButtonEmptySpace
            // 
            this.underButtonEmptySpace.AllowHotTrack = false;
            this.underButtonEmptySpace.CustomizationFormText = "underButtonEmptySpace";
            this.underButtonEmptySpace.Location = new System.Drawing.Point(755, 0);
            this.underButtonEmptySpace.Name = "underButtonEmptySpace";
            this.underButtonEmptySpace.Size = new System.Drawing.Size(111, 14);
            this.underButtonEmptySpace.Text = "underButtonEmptySpace";
            this.underButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // leftButtonEmptySpace
            // 
            this.leftButtonEmptySpace.AllowHotTrack = false;
            this.leftButtonEmptySpace.CustomizationFormText = "leftButtonEmptySpace";
            this.leftButtonEmptySpace.Location = new System.Drawing.Point(722, 0);
            this.leftButtonEmptySpace.Name = "leftButtonEmptySpace";
            this.leftButtonEmptySpace.Size = new System.Drawing.Size(33, 54);
            this.leftButtonEmptySpace.Text = "leftButtonEmptySpace";
            this.leftButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ComponentSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.searchComponentLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentSearchXtraForm";
            this.Text = "Find components";
            ((System.ComponentModel.ISupportInitialize)(this.diameterThicknessSubGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchComponentLayout)).EndInit();
            this.searchComponentLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serchEditLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serchParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentTypeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonEmptySpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton searchComponentryButton;
        private DevExpress.XtraEditors.TextEdit certificate;
        private DevExpress.XtraEditors.ComboBoxEdit componentType;
        private DevExpress.XtraEditors.TextEdit componentNumber;
        private DevExpress.XtraGrid.GridControl searchResultsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView searchResultsView;
        private DevExpress.XtraGrid.Views.Grid.GridView diameterThicknessSubGrid;
        private DevExpress.XtraGrid.Columns.GridColumn diameterColumn;
        private DevExpress.XtraGrid.Columns.GridColumn thicknessColumn;
        private DevExpress.XtraLayout.LayoutControl searchComponentLayout;
        private DevExpress.XtraLayout.LayoutControlGroup serchEditLayout;
        private DevExpress.XtraLayout.LayoutControlGroup searchGridLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem searchGridLayout;
        private DevExpress.XtraLayout.LayoutControlGroup serchParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem componentNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem componentTypeLayout;
        private DevExpress.XtraLayout.LayoutControlItem certificateLayout;
        private DevExpress.XtraLayout.LayoutControlItem searchButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem underButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem leftButtonEmptySpace;
        private DevExpress.XtraGrid.Columns.GridColumn numberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn typeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn certificateNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionResultColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn editButtonColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonEdit;
    }
}