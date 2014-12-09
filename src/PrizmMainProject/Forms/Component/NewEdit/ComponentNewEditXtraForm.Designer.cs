namespace PrizmMain.Forms.Component.NewEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentNewEditXtraForm));
            this.componentNumber = new DevExpress.XtraEditors.TextEdit();
            this.newEditPipeLayout = new DevExpress.XtraLayout.LayoutControl();
            this.attachmentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.inspectionHistoryGrid = new DevExpress.XtraGrid.GridControl();
            this.inspectionHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectionDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reasonColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.type = new DevExpress.XtraEditors.ComboBoxEdit();
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
            this.typeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.underTypeEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.attachmentsButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.attachmentsButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEditPipeLayout)).BeginInit();
            this.newEditPipeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underTypeEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonEmptySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // componentNumber
            // 
            this.componentNumber.Location = new System.Drawing.Point(44, 71);
            this.componentNumber.Name = "componentNumber";
            this.componentNumber.Size = new System.Drawing.Size(186, 20);
            this.componentNumber.StyleController = this.newEditPipeLayout;
            this.componentNumber.TabIndex = 0;
            // 
            // newEditPipeLayout
            // 
            this.newEditPipeLayout.Controls.Add(this.attachmentsButton);
            this.newEditPipeLayout.Controls.Add(this.inspectionHistoryGrid);
            this.newEditPipeLayout.Controls.Add(this.type);
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
            // attachmentsButton
            // 
            this.attachmentsButton.Image = ((System.Drawing.Image)(resources.GetObject("attachmentsButton.Image")));
            this.attachmentsButton.Location = new System.Drawing.Point(44, 427);
            this.attachmentsButton.Name = "attachmentsButton";
            this.attachmentsButton.Size = new System.Drawing.Size(133, 22);
            this.attachmentsButton.StyleController = this.newEditPipeLayout;
            this.attachmentsButton.TabIndex = 12;
            this.attachmentsButton.Text = "Вложения";
            this.attachmentsButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // inspectionHistoryGrid
            // 
            this.inspectionHistoryGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspectionHistoryGrid.Location = new System.Drawing.Point(425, 51);
            this.inspectionHistoryGrid.MainView = this.inspectionHistoryGridView;
            this.inspectionHistoryGrid.Name = "inspectionHistoryGrid";
            this.inspectionHistoryGrid.Size = new System.Drawing.Size(552, 402);
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
            this.inspectionHistoryGridView.OptionsView.ShowGroupPanel = false;
            // 
            // inspectionDateColumn
            // 
            this.inspectionDateColumn.Caption = "Дата инспекции";
            this.inspectionDateColumn.Name = "inspectionDateColumn";
            this.inspectionDateColumn.Visible = true;
            this.inspectionDateColumn.VisibleIndex = 0;
            this.inspectionDateColumn.Width = 100;
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
            this.resultColumn.Name = "resultColumn";
            this.resultColumn.Visible = true;
            this.resultColumn.VisibleIndex = 2;
            this.resultColumn.Width = 100;
            // 
            // reasonColumn
            // 
            this.reasonColumn.Caption = "Причина";
            this.reasonColumn.Name = "reasonColumn";
            this.reasonColumn.Visible = true;
            this.reasonColumn.VisibleIndex = 3;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(264, 71);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Size = new System.Drawing.Size(105, 20);
            this.type.StyleController = this.newEditPipeLayout;
            this.type.TabIndex = 6;
            // 
            // componentParameters
            // 
            this.componentParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.componentParameters.Location = new System.Drawing.Point(44, 163);
            this.componentParameters.MainView = this.componentParametersView;
            this.componentParameters.Name = "componentParameters";
            this.componentParameters.Size = new System.Drawing.Size(325, 246);
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
            this.diameterGridColumn.Name = "diameterGridColumn";
            this.diameterGridColumn.Visible = true;
            this.diameterGridColumn.VisibleIndex = 0;
            // 
            // wallThicknessGridColumn
            // 
            this.wallThicknessGridColumn.Caption = "Толщина стенки";
            this.wallThicknessGridColumn.Name = "wallThicknessGridColumn";
            this.wallThicknessGridColumn.Visible = true;
            this.wallThicknessGridColumn.VisibleIndex = 1;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(44, 125);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(186, 20);
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
            this.newComponentLayoutGroup});
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
            this.InspectionLayoutGroup.Size = new System.Drawing.Size(596, 465);
            this.InspectionLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.InspectionLayoutGroup.Text = "Входной контроль";
            // 
            // inspectionHistoryGridLayout
            // 
            this.inspectionHistoryGridLayout.Control = this.inspectionHistoryGrid;
            this.inspectionHistoryGridLayout.CustomizationFormText = "inspectionHistoryGridLayout";
            this.inspectionHistoryGridLayout.Location = new System.Drawing.Point(0, 0);
            this.inspectionHistoryGridLayout.Name = "inspectionHistoryGridLayout";
            this.inspectionHistoryGridLayout.Size = new System.Drawing.Size(556, 406);
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
            this.typeLayout,
            this.underTypeEmptySpace,
            this.attachmentsButtonLayout,
            this.attachmentsButtonEmptySpace});
            this.newComponentLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.newComponentLayoutGroup.Name = "newComponentLayoutGroup";
            this.newComponentLayoutGroup.Size = new System.Drawing.Size(393, 465);
            this.newComponentLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 7, 7);
            this.newComponentLayoutGroup.Text = "Комплектующее изделие";
            // 
            // componentNumberLayout
            // 
            this.componentNumberLayout.Control = this.componentNumber;
            this.componentNumberLayout.CustomizationFormText = "Component number";
            this.componentNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.componentNumberLayout.Name = "componentNumberLayout";
            this.componentNumberLayout.Size = new System.Drawing.Size(220, 54);
            this.componentNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.componentNumberLayout.Text = "Номер изделия";
            this.componentNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.componentNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // certificateLayout
            // 
            this.certificateLayout.Control = this.certificateNumber;
            this.certificateLayout.CustomizationFormText = "Certificate number";
            this.certificateLayout.Location = new System.Drawing.Point(0, 54);
            this.certificateLayout.Name = "certificateLayout";
            this.certificateLayout.Size = new System.Drawing.Size(220, 54);
            this.certificateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.certificateLayout.Text = "Номер сертификата";
            this.certificateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // parametersGridLayout
            // 
            this.parametersGridLayout.Control = this.componentParameters;
            this.parametersGridLayout.CustomizationFormText = "parametersGridLayout";
            this.parametersGridLayout.Location = new System.Drawing.Point(0, 108);
            this.parametersGridLayout.Name = "parametersGridLayout";
            this.parametersGridLayout.Size = new System.Drawing.Size(359, 264);
            this.parametersGridLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.parametersGridLayout.Text = "parametersGridLayout";
            this.parametersGridLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.parametersGridLayout.TextSize = new System.Drawing.Size(0, 0);
            this.parametersGridLayout.TextToControlDistance = 0;
            this.parametersGridLayout.TextVisible = false;
            // 
            // typeLayout
            // 
            this.typeLayout.Control = this.type;
            this.typeLayout.CustomizationFormText = "Type";
            this.typeLayout.Location = new System.Drawing.Point(220, 0);
            this.typeLayout.Name = "typeLayout";
            this.typeLayout.Size = new System.Drawing.Size(139, 54);
            this.typeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.typeLayout.Text = "Тип изделия";
            this.typeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.typeLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // underTypeEmptySpace
            // 
            this.underTypeEmptySpace.AllowHotTrack = false;
            this.underTypeEmptySpace.CustomizationFormText = "underTypeEmptySpace";
            this.underTypeEmptySpace.Location = new System.Drawing.Point(220, 54);
            this.underTypeEmptySpace.Name = "underTypeEmptySpace";
            this.underTypeEmptySpace.Size = new System.Drawing.Size(139, 54);
            this.underTypeEmptySpace.Text = "underTypeEmptySpace";
            this.underTypeEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // attachmentsButtonLayout
            // 
            this.attachmentsButtonLayout.Control = this.attachmentsButton;
            this.attachmentsButtonLayout.CustomizationFormText = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Location = new System.Drawing.Point(0, 372);
            this.attachmentsButtonLayout.Name = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Size = new System.Drawing.Size(157, 40);
            this.attachmentsButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 5, 7, 7);
            this.attachmentsButtonLayout.Text = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.attachmentsButtonLayout.TextToControlDistance = 0;
            this.attachmentsButtonLayout.TextVisible = false;
            // 
            // attachmentsButtonEmptySpace
            // 
            this.attachmentsButtonEmptySpace.AllowHotTrack = false;
            this.attachmentsButtonEmptySpace.CustomizationFormText = "attachmentsButtonEmptySpace";
            this.attachmentsButtonEmptySpace.Location = new System.Drawing.Point(157, 372);
            this.attachmentsButtonEmptySpace.Name = "attachmentsButtonEmptySpace";
            this.attachmentsButtonEmptySpace.Size = new System.Drawing.Size(202, 40);
            this.attachmentsButtonEmptySpace.Text = "attachmentsButtonEmptySpace";
            this.attachmentsButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
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
            this.Text = "Входной контроль - комлектующее изделие";
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEditPipeLayout)).EndInit();
            this.newEditPipeLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underTypeEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonEmptySpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit componentNumber;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraGrid.GridControl componentParameters;
        private DevExpress.XtraGrid.Views.Grid.GridView componentParametersView;
        private DevExpress.XtraGrid.Columns.GridColumn diameterGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn wallThicknessGridColumn;
        private DevExpress.XtraEditors.ComboBoxEdit type;
        private DevExpress.XtraLayout.LayoutControl newEditPipeLayout;
        private DevExpress.XtraLayout.LayoutControlGroup componentNewLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem parametersGridLayout;
        private DevExpress.XtraLayout.LayoutControlGroup InspectionLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem certificateLayout;
        private DevExpress.XtraLayout.LayoutControlItem typeLayout;
        private DevExpress.XtraLayout.LayoutControlItem componentNumberLayout;
        private DevExpress.XtraLayout.LayoutControlGroup newComponentLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem underTypeEmptySpace;
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
    }
}