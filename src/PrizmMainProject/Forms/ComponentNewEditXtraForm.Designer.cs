namespace PrizmMain.Forms
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
            this.componentNumber = new DevExpress.XtraEditors.TextEdit();
            this.newEditPipeLayout = new DevExpress.XtraLayout.LayoutControl();
            this.type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.rejectedReason = new DevExpress.XtraEditors.TextEdit();
            this.componentParameters = new DevExpress.XtraGrid.GridControl();
            this.componentParametersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.diameterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wallThicknessGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.inspectionDate = new DevExpress.XtraEditors.DateEdit();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.inspector = new DevExpress.XtraEditors.TextEdit();
            this.componentNewLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.InspectionLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspectorLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectionDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.resultLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reasonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.underInspecdtorEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.newComponentLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.componentNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.parametersGridLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.typeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.underTypeEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEditPipeLayout)).BeginInit();
            this.newEditPipeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejectedReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParametersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNewLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underInspecdtorEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newComponentLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersGridLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underTypeEmptySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // componentNumber
            // 
            this.componentNumber.Location = new System.Drawing.Point(52, 71);
            this.componentNumber.Name = "componentNumber";
            this.componentNumber.Size = new System.Drawing.Size(186, 20);
            this.componentNumber.StyleController = this.newEditPipeLayout;
            this.componentNumber.TabIndex = 0;
            // 
            // newEditPipeLayout
            // 
            this.newEditPipeLayout.Controls.Add(this.type);
            this.newEditPipeLayout.Controls.Add(this.rejectedReason);
            this.newEditPipeLayout.Controls.Add(this.componentParameters);
            this.newEditPipeLayout.Controls.Add(this.resultRadioGroup);
            this.newEditPipeLayout.Controls.Add(this.inspectionDate);
            this.newEditPipeLayout.Controls.Add(this.certificateNumber);
            this.newEditPipeLayout.Controls.Add(this.inspector);
            this.newEditPipeLayout.Controls.Add(this.componentNumber);
            this.newEditPipeLayout.Location = new System.Drawing.Point(12, 12);
            this.newEditPipeLayout.Name = "newEditPipeLayout";
            this.newEditPipeLayout.Root = this.componentNewLayoutGroup;
            this.newEditPipeLayout.Size = new System.Drawing.Size(947, 327);
            this.newEditPipeLayout.TabIndex = 8;
            this.newEditPipeLayout.Text = "layoutControl1";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(272, 71);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Size = new System.Drawing.Size(175, 20);
            this.type.StyleController = this.newEditPipeLayout;
            this.type.TabIndex = 6;
            // 
            // rejectedReason
            // 
            this.rejectedReason.Location = new System.Drawing.Point(681, 174);
            this.rejectedReason.Name = "rejectedReason";
            this.rejectedReason.Size = new System.Drawing.Size(214, 20);
            this.rejectedReason.StyleController = this.newEditPipeLayout;
            this.rejectedReason.TabIndex = 7;
            // 
            // componentParameters
            // 
            this.componentParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.componentParameters.Location = new System.Drawing.Point(52, 163);
            this.componentParameters.MainView = this.componentParametersView;
            this.componentParameters.Name = "componentParameters";
            this.componentParameters.Size = new System.Drawing.Size(395, 128);
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
            // resultRadioGroup
            // 
            this.resultRadioGroup.Location = new System.Drawing.Point(531, 174);
            this.resultRadioGroup.Name = "resultRadioGroup";
            this.resultRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.resultRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.resultRadioGroup.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.resultRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "годен"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "ремонт"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "брак")});
            this.resultRadioGroup.Size = new System.Drawing.Size(116, 117);
            this.resultRadioGroup.StyleController = this.newEditPipeLayout;
            this.resultRadioGroup.TabIndex = 6;
            // 
            // inspectionDate
            // 
            this.inspectionDate.EditValue = null;
            this.inspectionDate.Location = new System.Drawing.Point(531, 125);
            this.inspectionDate.Name = "inspectionDate";
            this.inspectionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspectionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspectionDate.Size = new System.Drawing.Size(116, 20);
            this.inspectionDate.StyleController = this.newEditPipeLayout;
            this.inspectionDate.TabIndex = 2;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(52, 125);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(186, 20);
            this.certificateNumber.StyleController = this.newEditPipeLayout;
            this.certificateNumber.TabIndex = 2;
            // 
            // inspector
            // 
            this.inspector.Location = new System.Drawing.Point(531, 71);
            this.inspector.Name = "inspector";
            this.inspector.Size = new System.Drawing.Size(364, 20);
            this.inspector.StyleController = this.newEditPipeLayout;
            this.inspector.TabIndex = 1;
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
            this.componentNewLayoutGroup.Size = new System.Drawing.Size(947, 327);
            this.componentNewLayoutGroup.Text = "componentNewLayoutGroup";
            this.componentNewLayoutGroup.TextVisible = false;
            // 
            // InspectionLayoutGroup
            // 
            this.InspectionLayoutGroup.CustomizationFormText = "Inspection";
            this.InspectionLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectorLayout,
            this.inspectionDateLayout,
            this.resultLayout,
            this.reasonLayout,
            this.underInspecdtorEmptySpace});
            this.InspectionLayoutGroup.Location = new System.Drawing.Point(479, 0);
            this.InspectionLayoutGroup.Name = "InspectionLayoutGroup";
            this.InspectionLayoutGroup.Size = new System.Drawing.Size(448, 307);
            this.InspectionLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.InspectionLayoutGroup.Text = "Входной контроль";
            // 
            // inspectorLayout
            // 
            this.inspectorLayout.Control = this.inspector;
            this.inspectorLayout.CustomizationFormText = "Inspector";
            this.inspectorLayout.Location = new System.Drawing.Point(0, 0);
            this.inspectorLayout.Name = "inspectorLayout";
            this.inspectorLayout.Size = new System.Drawing.Size(398, 54);
            this.inspectorLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.inspectorLayout.Text = "Инспектор";
            this.inspectorLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectorLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // inspectionDateLayout
            // 
            this.inspectionDateLayout.Control = this.inspectionDate;
            this.inspectionDateLayout.CustomizationFormText = "Inspection date";
            this.inspectionDateLayout.Location = new System.Drawing.Point(0, 54);
            this.inspectionDateLayout.MinSize = new System.Drawing.Size(150, 40);
            this.inspectionDateLayout.Name = "inspectionDateLayout";
            this.inspectionDateLayout.Size = new System.Drawing.Size(150, 49);
            this.inspectionDateLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.inspectionDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.inspectionDateLayout.Text = "Дата инспекции";
            this.inspectionDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectionDateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // resultLayout
            // 
            this.resultLayout.Control = this.resultRadioGroup;
            this.resultLayout.CustomizationFormText = "Result";
            this.resultLayout.Location = new System.Drawing.Point(0, 103);
            this.resultLayout.MinSize = new System.Drawing.Size(150, 73);
            this.resultLayout.Name = "resultLayout";
            this.resultLayout.Size = new System.Drawing.Size(150, 151);
            this.resultLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.resultLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.resultLayout.Text = "Результат";
            this.resultLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.resultLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // reasonLayout
            // 
            this.reasonLayout.Control = this.rejectedReason;
            this.reasonLayout.CustomizationFormText = "Reason";
            this.reasonLayout.Location = new System.Drawing.Point(150, 103);
            this.reasonLayout.MinSize = new System.Drawing.Size(150, 40);
            this.reasonLayout.Name = "reasonLayout";
            this.reasonLayout.Size = new System.Drawing.Size(248, 151);
            this.reasonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.reasonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.reasonLayout.Text = "Причина";
            this.reasonLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.reasonLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // underInspecdtorEmptySpace
            // 
            this.underInspecdtorEmptySpace.AllowHotTrack = false;
            this.underInspecdtorEmptySpace.CustomizationFormText = "underInspecdtorEmptySpace";
            this.underInspecdtorEmptySpace.Location = new System.Drawing.Point(150, 54);
            this.underInspecdtorEmptySpace.Name = "underInspecdtorEmptySpace";
            this.underInspecdtorEmptySpace.Size = new System.Drawing.Size(248, 49);
            this.underInspecdtorEmptySpace.Text = "underInspecdtorEmptySpace";
            this.underInspecdtorEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // newComponentLayoutGroup
            // 
            this.newComponentLayoutGroup.CustomizationFormText = "Комплектующее изделие";
            this.newComponentLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.componentNumberLayout,
            this.certificateLayout,
            this.parametersGridLayout,
            this.typeLayout,
            this.underTypeEmptySpace});
            this.newComponentLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.newComponentLayoutGroup.Name = "newComponentLayoutGroup";
            this.newComponentLayoutGroup.Size = new System.Drawing.Size(479, 307);
            this.newComponentLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
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
            this.parametersGridLayout.Size = new System.Drawing.Size(429, 146);
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
            this.typeLayout.Size = new System.Drawing.Size(209, 54);
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
            this.underTypeEmptySpace.Size = new System.Drawing.Size(209, 54);
            this.underTypeEmptySpace.Text = "underTypeEmptySpace";
            this.underTypeEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ComponentNewEditXtraForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 488);
            this.Controls.Add(this.newEditPipeLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentNewEditXtraForm";
            this.Text = "New or Edit Component";
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEditPipeLayout)).EndInit();
            this.newEditPipeLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rejectedReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParametersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNewLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underInspecdtorEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newComponentLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersGridLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underTypeEmptySpace)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit inspectionDate;
        private DevExpress.XtraEditors.TextEdit inspector;
        private DevExpress.XtraEditors.TextEdit rejectedReason;
        private DevExpress.XtraEditors.RadioGroup resultRadioGroup;
        private DevExpress.XtraLayout.LayoutControl newEditPipeLayout;
        private DevExpress.XtraLayout.LayoutControlGroup componentNewLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem parametersGridLayout;
        private DevExpress.XtraLayout.LayoutControlGroup InspectionLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem inspectorLayout;
        private DevExpress.XtraLayout.LayoutControlItem inspectionDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem certificateLayout;
        private DevExpress.XtraLayout.LayoutControlItem typeLayout;
        private DevExpress.XtraLayout.LayoutControlItem componentNumberLayout;
        private DevExpress.XtraLayout.LayoutControlGroup newComponentLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem underInspecdtorEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem underTypeEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem resultLayout;
        private DevExpress.XtraLayout.LayoutControlItem reasonLayout;
    }
}