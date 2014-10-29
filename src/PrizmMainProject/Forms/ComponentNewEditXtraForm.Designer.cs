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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
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
            this.parametersGridLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.InspectionLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspectorLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectionDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.resultLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reasonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.typeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.componentNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.parametersGridLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumberLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // componentNumber
            // 
            this.componentNumber.Location = new System.Drawing.Point(12, 28);
            this.componentNumber.Name = "componentNumber";
            this.componentNumber.Size = new System.Drawing.Size(304, 20);
            this.componentNumber.StyleController = this.layoutControl1;
            this.componentNumber.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.type);
            this.layoutControl1.Controls.Add(this.rejectedReason);
            this.layoutControl1.Controls.Add(this.componentParameters);
            this.layoutControl1.Controls.Add(this.resultRadioGroup);
            this.layoutControl1.Controls.Add(this.inspectionDate);
            this.layoutControl1.Controls.Add(this.certificateNumber);
            this.layoutControl1.Controls.Add(this.inspector);
            this.layoutControl1.Controls.Add(this.componentNumber);
            this.layoutControl1.Location = new System.Drawing.Point(13, 13);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.componentNewLayoutGroup;
            this.layoutControl1.Size = new System.Drawing.Size(652, 264);
            this.layoutControl1.TabIndex = 8;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(12, 68);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Size = new System.Drawing.Size(304, 20);
            this.type.StyleController = this.layoutControl1;
            this.type.TabIndex = 6;
            // 
            // rejectedReason
            // 
            this.rejectedReason.Location = new System.Drawing.Point(482, 139);
            this.rejectedReason.Name = "rejectedReason";
            this.rejectedReason.Size = new System.Drawing.Size(146, 20);
            this.rejectedReason.StyleController = this.layoutControl1;
            this.rejectedReason.TabIndex = 7;
            // 
            // componentParameters
            // 
            this.componentParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.componentParameters.Location = new System.Drawing.Point(12, 132);
            this.componentParameters.MainView = this.componentParametersView;
            this.componentParameters.Name = "componentParameters";
            this.componentParameters.Size = new System.Drawing.Size(304, 120);
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
            this.resultRadioGroup.Location = new System.Drawing.Point(332, 139);
            this.resultRadioGroup.Name = "resultRadioGroup";
            this.resultRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.resultRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.resultRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.resultRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "принято"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "задержано"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "отклонено")});
            this.resultRadioGroup.Size = new System.Drawing.Size(146, 101);
            this.resultRadioGroup.StyleController = this.layoutControl1;
            this.resultRadioGroup.TabIndex = 6;
            // 
            // inspectionDate
            // 
            this.inspectionDate.EditValue = null;
            this.inspectionDate.Location = new System.Drawing.Point(332, 99);
            this.inspectionDate.Name = "inspectionDate";
            this.inspectionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspectionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspectionDate.Size = new System.Drawing.Size(296, 20);
            this.inspectionDate.StyleController = this.layoutControl1;
            this.inspectionDate.TabIndex = 2;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(12, 108);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(304, 20);
            this.certificateNumber.StyleController = this.layoutControl1;
            this.certificateNumber.TabIndex = 2;
            // 
            // inspector
            // 
            this.inspector.Location = new System.Drawing.Point(332, 59);
            this.inspector.Name = "inspector";
            this.inspector.Size = new System.Drawing.Size(296, 20);
            this.inspector.StyleController = this.layoutControl1;
            this.inspector.TabIndex = 1;
            // 
            // componentNewLayoutGroup
            // 
            this.componentNewLayoutGroup.CustomizationFormText = "componentNewLayoutGroup";
            this.componentNewLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.componentNewLayoutGroup.GroupBordersVisible = false;
            this.componentNewLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.parametersGridLayout,
            this.InspectionLayoutGroup,
            this.certificateLayout,
            this.typeLayout,
            this.componentNumberLayout});
            this.componentNewLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.componentNewLayoutGroup.Name = "componentNewLayoutGroup";
            this.componentNewLayoutGroup.Size = new System.Drawing.Size(652, 264);
            this.componentNewLayoutGroup.Text = "componentNewLayoutGroup";
            this.componentNewLayoutGroup.TextVisible = false;
            // 
            // parametersGridLayout
            // 
            this.parametersGridLayout.Control = this.componentParameters;
            this.parametersGridLayout.CustomizationFormText = "parametersGridLayout";
            this.parametersGridLayout.Location = new System.Drawing.Point(0, 120);
            this.parametersGridLayout.Name = "parametersGridLayout";
            this.parametersGridLayout.Size = new System.Drawing.Size(308, 124);
            this.parametersGridLayout.Text = "parametersGridLayout";
            this.parametersGridLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.parametersGridLayout.TextSize = new System.Drawing.Size(0, 0);
            this.parametersGridLayout.TextToControlDistance = 0;
            this.parametersGridLayout.TextVisible = false;
            // 
            // InspectionLayoutGroup
            // 
            this.InspectionLayoutGroup.CustomizationFormText = "Inspection";
            this.InspectionLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectorLayout,
            this.inspectionDateLayout,
            this.resultLayout,
            this.reasonLayout});
            this.InspectionLayoutGroup.Location = new System.Drawing.Point(308, 0);
            this.InspectionLayoutGroup.Name = "InspectionLayoutGroup";
            this.InspectionLayoutGroup.Size = new System.Drawing.Size(324, 244);
            this.InspectionLayoutGroup.Text = "Входной контроль";
            // 
            // inspectorLayout
            // 
            this.inspectorLayout.Control = this.inspector;
            this.inspectorLayout.CustomizationFormText = "Inspector";
            this.inspectorLayout.Location = new System.Drawing.Point(0, 0);
            this.inspectorLayout.Name = "inspectorLayout";
            this.inspectorLayout.Size = new System.Drawing.Size(300, 40);
            this.inspectorLayout.Text = "Инспектор";
            this.inspectorLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectorLayout.TextSize = new System.Drawing.Size(168, 13);
            // 
            // inspectionDateLayout
            // 
            this.inspectionDateLayout.Control = this.inspectionDate;
            this.inspectionDateLayout.CustomizationFormText = "Inspection date";
            this.inspectionDateLayout.Location = new System.Drawing.Point(0, 40);
            this.inspectionDateLayout.MinSize = new System.Drawing.Size(150, 40);
            this.inspectionDateLayout.Name = "inspectionDateLayout";
            this.inspectionDateLayout.Size = new System.Drawing.Size(300, 40);
            this.inspectionDateLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.inspectionDateLayout.Text = "Дата проведения инспекции";
            this.inspectionDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectionDateLayout.TextSize = new System.Drawing.Size(168, 13);
            // 
            // resultLayout
            // 
            this.resultLayout.Control = this.resultRadioGroup;
            this.resultLayout.CustomizationFormText = "Result";
            this.resultLayout.Location = new System.Drawing.Point(0, 80);
            this.resultLayout.MinSize = new System.Drawing.Size(150, 73);
            this.resultLayout.Name = "resultLayout";
            this.resultLayout.Size = new System.Drawing.Size(150, 121);
            this.resultLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.resultLayout.Text = "Результат";
            this.resultLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.resultLayout.TextSize = new System.Drawing.Size(168, 13);
            // 
            // reasonLayout
            // 
            this.reasonLayout.Control = this.rejectedReason;
            this.reasonLayout.CustomizationFormText = "Reason";
            this.reasonLayout.Location = new System.Drawing.Point(150, 80);
            this.reasonLayout.MinSize = new System.Drawing.Size(150, 40);
            this.reasonLayout.Name = "reasonLayout";
            this.reasonLayout.Size = new System.Drawing.Size(150, 121);
            this.reasonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.reasonLayout.Text = "Причина";
            this.reasonLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.reasonLayout.TextSize = new System.Drawing.Size(168, 13);
            // 
            // certificateLayout
            // 
            this.certificateLayout.Control = this.certificateNumber;
            this.certificateLayout.CustomizationFormText = "Certificate number";
            this.certificateLayout.Location = new System.Drawing.Point(0, 80);
            this.certificateLayout.Name = "certificateLayout";
            this.certificateLayout.Size = new System.Drawing.Size(308, 40);
            this.certificateLayout.Text = "Номер сертификата";
            this.certificateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateLayout.TextSize = new System.Drawing.Size(168, 13);
            // 
            // typeLayout
            // 
            this.typeLayout.Control = this.type;
            this.typeLayout.CustomizationFormText = "Type";
            this.typeLayout.Location = new System.Drawing.Point(0, 40);
            this.typeLayout.Name = "typeLayout";
            this.typeLayout.Size = new System.Drawing.Size(308, 40);
            this.typeLayout.Text = "Тип изделия";
            this.typeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.typeLayout.TextSize = new System.Drawing.Size(168, 13);
            // 
            // componentNumberLayout
            // 
            this.componentNumberLayout.Control = this.componentNumber;
            this.componentNumberLayout.CustomizationFormText = "Component number";
            this.componentNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.componentNumberLayout.Name = "componentNumberLayout";
            this.componentNumberLayout.Size = new System.Drawing.Size(308, 40);
            this.componentNumberLayout.Text = "Номер комплектующего изделия";
            this.componentNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.componentNumberLayout.TextSize = new System.Drawing.Size(168, 13);
            // 
            // ComponentNewEditXtraForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 488);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentNewEditXtraForm";
            this.Text = "New or Edit Component";
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.parametersGridLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumberLayout)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup componentNewLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem parametersGridLayout;
        private DevExpress.XtraLayout.LayoutControlGroup InspectionLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem inspectorLayout;
        private DevExpress.XtraLayout.LayoutControlItem inspectionDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem resultLayout;
        private DevExpress.XtraLayout.LayoutControlItem reasonLayout;
        private DevExpress.XtraLayout.LayoutControlItem certificateLayout;
        private DevExpress.XtraLayout.LayoutControlItem typeLayout;
        private DevExpress.XtraLayout.LayoutControlItem componentNumberLayout;
    }
}