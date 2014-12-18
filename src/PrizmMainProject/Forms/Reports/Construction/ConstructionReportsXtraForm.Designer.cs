namespace Prizm.Main.Forms.Reports.Construction
{
    partial class ConstructionReportsXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstructionReportsXtraForm));
            this.reportType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.generalLayout = new DevExpress.XtraLayout.LayoutControl();
            this.reportPeriodLabel = new DevExpress.XtraEditors.LabelControl();
            this.countPoints = new DevExpress.XtraEditors.RadioGroup();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.end = new DevExpress.XtraEditors.ComboBoxEdit();
            this.start = new DevExpress.XtraEditors.ComboBoxEdit();
            this.previewReportDocument = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.type = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.generalLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.previewLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.previewLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.createReportaLyoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.typeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.endLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportTypeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportPeriodLabelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportPeriodEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.startLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.countPointsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.previewButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.createButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).BeginInit();
            this.generalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countPoints.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportaLyoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodLabelLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPointsLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportType
            // 
            this.reportType.EditValue = "";
            this.reportType.Location = new System.Drawing.Point(24, 59);
            this.reportType.Name = "reportType";
            this.reportType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reportType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.reportType.Size = new System.Drawing.Size(231, 20);
            this.reportType.StyleController = this.generalLayout;
            this.reportType.TabIndex = 68;
            this.reportType.SelectedIndexChanged += new System.EventHandler(this.reportType_SelectedIndexChanged);
            // 
            // generalLayout
            // 
            this.generalLayout.Controls.Add(this.reportPeriodLabel);
            this.generalLayout.Controls.Add(this.countPoints);
            this.generalLayout.Controls.Add(this.reportType);
            this.generalLayout.Controls.Add(this.createReportButton);
            this.generalLayout.Controls.Add(this.previewButton);
            this.generalLayout.Controls.Add(this.end);
            this.generalLayout.Controls.Add(this.start);
            this.generalLayout.Controls.Add(this.previewReportDocument);
            this.generalLayout.Controls.Add(this.type);
            this.generalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalLayout.Location = new System.Drawing.Point(0, 0);
            this.generalLayout.Name = "generalLayout";
            this.generalLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(251, 263, 250, 350);
            this.generalLayout.Root = this.generalLayoutGroup;
            this.generalLayout.Size = new System.Drawing.Size(940, 450);
            this.generalLayout.TabIndex = 70;
            this.generalLayout.Text = "layoutControl1";
            // 
            // reportPeriodLabel
            // 
            this.reportPeriodLabel.Location = new System.Drawing.Point(279, 43);
            this.reportPeriodLabel.Name = "reportPeriodLabel";
            this.reportPeriodLabel.Size = new System.Drawing.Size(39, 13);
            this.reportPeriodLabel.StyleController = this.generalLayout;
            this.reportPeriodLabel.TabIndex = 70;
            this.reportPeriodLabel.Text = "Пикеты";
            // 
            // countPoints
            // 
            this.countPoints.Location = new System.Drawing.Point(279, 100);
            this.countPoints.Name = "countPoints";
            this.countPoints.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.countPoints.Properties.Appearance.Options.UseBackColor = true;
            this.countPoints.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.countPoints.Properties.Columns = 2;
            this.countPoints.Size = new System.Drawing.Size(125, 22);
            this.countPoints.StyleController = this.generalLayout;
            this.countPoints.TabIndex = 69;
            // 
            // createReportButton
            // 
            this.createReportButton.Image = ((System.Drawing.Image)(resources.GetObject("createReportButton.Image")));
            this.createReportButton.Location = new System.Drawing.Point(563, 58);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(120, 22);
            this.createReportButton.StyleController = this.generalLayout;
            this.createReportButton.TabIndex = 64;
            this.createReportButton.Text = "Соз&дать отчет";
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Image = ((System.Drawing.Image)(resources.GetObject("previewButton.Image")));
            this.previewButton.Location = new System.Drawing.Point(563, 99);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(120, 22);
            this.previewButton.StyleController = this.generalLayout;
            this.previewButton.TabIndex = 65;
            this.previewButton.Text = "&Предпросмотр";
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(426, 60);
            this.end.Name = "end";
            this.end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.end.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.end.Size = new System.Drawing.Size(118, 20);
            this.end.StyleController = this.generalLayout;
            this.end.TabIndex = 62;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(291, 60);
            this.start.Name = "start";
            this.start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.start.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.start.Size = new System.Drawing.Size(113, 20);
            this.start.StyleController = this.generalLayout;
            this.start.TabIndex = 61;
            // 
            // previewReportDocument
            // 
            this.previewReportDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewReportDocument.IsMetric = false;
            this.previewReportDocument.Location = new System.Drawing.Point(24, 169);
            this.previewReportDocument.Name = "previewReportDocument";
            this.previewReportDocument.Size = new System.Drawing.Size(892, 257);
            this.previewReportDocument.TabIndex = 56;
            // 
            // type
            // 
            this.type.EditValue = "";
            this.type.Location = new System.Drawing.Point(24, 99);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Properties.SelectAllItemCaption = "(Выбрать все)";
            this.type.Size = new System.Drawing.Size(231, 20);
            this.type.StyleController = this.generalLayout;
            this.type.TabIndex = 63;
            // 
            // generalLayoutGroup
            // 
            this.generalLayoutGroup.CustomizationFormText = "generalLayoutGroup";
            this.generalLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalLayoutGroup.GroupBordersVisible = false;
            this.generalLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.previewLayoutGroup,
            this.createReportaLyoutGroup});
            this.generalLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalLayoutGroup.Name = "generalLayoutGroup";
            this.generalLayoutGroup.Size = new System.Drawing.Size(940, 450);
            this.generalLayoutGroup.Text = "generalLayoutGroup";
            this.generalLayoutGroup.TextVisible = false;
            // 
            // previewLayoutGroup
            // 
            this.previewLayoutGroup.CustomizationFormText = "Предварительный просмотр отчёта ";
            this.previewLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.previewLayout});
            this.previewLayoutGroup.Location = new System.Drawing.Point(0, 126);
            this.previewLayoutGroup.Name = "previewLayoutGroup";
            this.previewLayoutGroup.Size = new System.Drawing.Size(920, 304);
            this.previewLayoutGroup.Text = "Предварительный просмотр отчёта ";
            // 
            // previewLayout
            // 
            this.previewLayout.Control = this.previewReportDocument;
            this.previewLayout.CustomizationFormText = "previewLayout";
            this.previewLayout.Location = new System.Drawing.Point(0, 0);
            this.previewLayout.Name = "previewLayout";
            this.previewLayout.Size = new System.Drawing.Size(896, 261);
            this.previewLayout.Text = "previewLayout";
            this.previewLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewLayout.TextToControlDistance = 0;
            this.previewLayout.TextVisible = false;
            // 
            // createReportaLyoutGroup
            // 
            this.createReportaLyoutGroup.CustomizationFormText = "Сформировать отчёт";
            this.createReportaLyoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.typeLayout,
            this.endLayout,
            this.reportTypeLayout,
            this.reportPeriodLabelLayout,
            this.reportPeriodEmptySpace,
            this.startLayout,
            this.countPointsLayout,
            this.buttonsEmptySpace,
            this.emptySpaceItem1,
            this.previewButtonLayout,
            this.createButtonLayout});
            this.createReportaLyoutGroup.Location = new System.Drawing.Point(0, 0);
            this.createReportaLyoutGroup.Name = "createReportaLyoutGroup";
            this.createReportaLyoutGroup.Size = new System.Drawing.Size(920, 126);
            this.createReportaLyoutGroup.Text = "Сформировать отчёт";
            // 
            // typeLayout
            // 
            this.typeLayout.Control = this.type;
            this.typeLayout.CustomizationFormText = "Тип изделия";
            this.typeLayout.Location = new System.Drawing.Point(0, 40);
            this.typeLayout.Name = "typeLayout";
            this.typeLayout.Size = new System.Drawing.Size(245, 43);
            this.typeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
            this.typeLayout.Text = "Тип изделия";
            this.typeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.typeLayout.TextSize = new System.Drawing.Size(78, 13);
            // 
            // endLayout
            // 
            this.endLayout.Control = this.end;
            this.endLayout.CustomizationFormText = "По";
            this.endLayout.Location = new System.Drawing.Point(384, 17);
            this.endLayout.Name = "endLayout";
            this.endLayout.Size = new System.Drawing.Size(140, 24);
            this.endLayout.Text = "По";
            this.endLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.endLayout.TextSize = new System.Drawing.Size(13, 13);
            this.endLayout.TextToControlDistance = 5;
            // 
            // reportTypeLayout
            // 
            this.reportTypeLayout.Control = this.reportType;
            this.reportTypeLayout.CustomizationFormText = "Тип отчета";
            this.reportTypeLayout.Location = new System.Drawing.Point(0, 0);
            this.reportTypeLayout.Name = "reportTypeLayout";
            this.reportTypeLayout.Size = new System.Drawing.Size(245, 40);
            this.reportTypeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
            this.reportTypeLayout.Text = "Тип отчета";
            this.reportTypeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.reportTypeLayout.TextSize = new System.Drawing.Size(78, 13);
            // 
            // reportPeriodLabelLayout
            // 
            this.reportPeriodLabelLayout.Control = this.reportPeriodLabel;
            this.reportPeriodLabelLayout.CustomizationFormText = "reportPeriodLabelLayout";
            this.reportPeriodLabelLayout.Location = new System.Drawing.Point(245, 0);
            this.reportPeriodLabelLayout.Name = "reportPeriodLabelLayout";
            this.reportPeriodLabelLayout.Size = new System.Drawing.Size(53, 17);
            this.reportPeriodLabelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.reportPeriodLabelLayout.Text = "reportPeriodLabelLayout";
            this.reportPeriodLabelLayout.TextSize = new System.Drawing.Size(0, 0);
            this.reportPeriodLabelLayout.TextToControlDistance = 0;
            this.reportPeriodLabelLayout.TextVisible = false;
            // 
            // reportPeriodEmptySpace
            // 
            this.reportPeriodEmptySpace.AllowHotTrack = false;
            this.reportPeriodEmptySpace.CustomizationFormText = "reportPeriodEmptySpace";
            this.reportPeriodEmptySpace.Location = new System.Drawing.Point(298, 0);
            this.reportPeriodEmptySpace.Name = "reportPeriodEmptySpace";
            this.reportPeriodEmptySpace.Size = new System.Drawing.Size(226, 17);
            this.reportPeriodEmptySpace.Text = "reportPeriodEmptySpace";
            this.reportPeriodEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // startLayout
            // 
            this.startLayout.Control = this.start;
            this.startLayout.CustomizationFormText = "С";
            this.startLayout.Location = new System.Drawing.Point(245, 17);
            this.startLayout.Name = "startLayout";
            this.startLayout.Size = new System.Drawing.Size(139, 24);
            this.startLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.startLayout.Text = "С";
            this.startLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.startLayout.TextSize = new System.Drawing.Size(7, 13);
            this.startLayout.TextToControlDistance = 5;
            // 
            // countPointsLayout
            // 
            this.countPointsLayout.Control = this.countPoints;
            this.countPointsLayout.CustomizationFormText = "Точки отсчета:";
            this.countPointsLayout.Location = new System.Drawing.Point(245, 41);
            this.countPointsLayout.Name = "countPointsLayout";
            this.countPointsLayout.Size = new System.Drawing.Size(139, 42);
            this.countPointsLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.countPointsLayout.Text = "Точки отсчета:";
            this.countPointsLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.countPointsLayout.TextSize = new System.Drawing.Size(78, 13);
            // 
            // buttonsEmptySpace
            // 
            this.buttonsEmptySpace.AllowHotTrack = false;
            this.buttonsEmptySpace.CustomizationFormText = "buttonsEmptySpace";
            this.buttonsEmptySpace.Location = new System.Drawing.Point(678, 0);
            this.buttonsEmptySpace.Name = "buttonsEmptySpace";
            this.buttonsEmptySpace.Size = new System.Drawing.Size(218, 83);
            this.buttonsEmptySpace.Text = "buttonsEmptySpace";
            this.buttonsEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(384, 41);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(140, 42);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // previewButtonLayout
            // 
            this.previewButtonLayout.Control = this.previewButton;
            this.previewButtonLayout.CustomizationFormText = "previewButtonLayout";
            this.previewButtonLayout.Location = new System.Drawing.Point(524, 41);
            this.previewButtonLayout.Name = "previewButtonLayout";
            this.previewButtonLayout.Size = new System.Drawing.Size(154, 42);
            this.previewButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 1);
            this.previewButtonLayout.Text = "previewButtonLayout";
            this.previewButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewButtonLayout.TextToControlDistance = 0;
            this.previewButtonLayout.TextVisible = false;
            // 
            // createButtonLayout
            // 
            this.createButtonLayout.Control = this.createReportButton;
            this.createButtonLayout.CustomizationFormText = "createButtonLayout";
            this.createButtonLayout.Location = new System.Drawing.Point(524, 0);
            this.createButtonLayout.Name = "createButtonLayout";
            this.createButtonLayout.Size = new System.Drawing.Size(154, 41);
            this.createButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 0);
            this.createButtonLayout.Text = "createButtonLayout";
            this.createButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.createButtonLayout.TextToControlDistance = 0;
            this.createButtonLayout.TextVisible = false;
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            // 
            // ConstructionReportsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.generalLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConstructionReportsXtraForm";
            this.Text = "Строительство - отчет";
            this.Load += new System.EventHandler(this.ConstructionReportsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).EndInit();
            this.generalLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countPoints.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportaLyoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodLabelLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPointsLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit reportType;
        private DevExpress.XtraEditors.ComboBoxEdit end;
        private DevExpress.XtraEditors.ComboBoxEdit start;
        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        private DevExpress.XtraPrinting.Preview.DocumentViewer previewReportDocument;
        private DevExpress.XtraEditors.RadioGroup countPoints;
        private DevExpress.XtraLayout.LayoutControl generalLayout;
        private DevExpress.XtraLayout.LayoutControlGroup generalLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlGroup previewLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem previewLayout;
        private DevExpress.XtraLayout.LayoutControlGroup createReportaLyoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem typeLayout;
        private DevExpress.XtraLayout.LayoutControlItem startLayout;
        private DevExpress.XtraLayout.LayoutControlItem endLayout;
        private DevExpress.XtraLayout.LayoutControlItem reportTypeLayout;
        private DevExpress.XtraLayout.LayoutControlItem previewButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem createButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem countPointsLayout;
        private DevExpress.XtraEditors.LabelControl reportPeriodLabel;
        private DevExpress.XtraLayout.LayoutControlItem reportPeriodLabelLayout;
        private DevExpress.XtraLayout.EmptySpaceItem reportPeriodEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem buttonsEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit type;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}