namespace PrizmMain.Forms.Reports.Construction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstructionReportsXtraForm));
            this.reportType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.generalLayout = new DevExpress.XtraLayout.LayoutControl();
            this.reportPeriodLabel = new DevExpress.XtraEditors.LabelControl();
            this.countPoints = new DevExpress.XtraEditors.RadioGroup();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.endDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.startDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.previewReportDocument = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.generalLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.previewLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.previewLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.createReportaLyoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.typeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.endDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportTypeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportPeriodLabelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportPeriodEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.startDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.previewButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.createButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.countPointsEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.countPointsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.reportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).BeginInit();
            this.generalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countPoints.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportaLyoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodLabelLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPointsEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPointsLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // reportType
            // 
            this.reportType.EditValue = "Использованные изделия";
            this.reportType.Location = new System.Drawing.Point(24, 59);
            this.reportType.Name = "reportType";
            this.reportType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reportType.Size = new System.Drawing.Size(171, 20);
            this.reportType.StyleController = this.generalLayout;
            this.reportType.TabIndex = 68;
            // 
            // generalLayout
            // 
            this.generalLayout.Controls.Add(this.reportPeriodLabel);
            this.generalLayout.Controls.Add(this.countPoints);
            this.generalLayout.Controls.Add(this.reportType);
            this.generalLayout.Controls.Add(this.createReportButton);
            this.generalLayout.Controls.Add(this.previewButton);
            this.generalLayout.Controls.Add(this.endDate);
            this.generalLayout.Controls.Add(this.startDate);
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
            this.reportPeriodLabel.Location = new System.Drawing.Point(219, 43);
            this.reportPeriodLabel.Name = "reportPeriodLabel";
            this.reportPeriodLabel.Size = new System.Drawing.Size(52, 13);
            this.reportPeriodLabel.StyleController = this.generalLayout;
            this.reportPeriodLabel.TabIndex = 70;
            this.reportPeriodLabel.Text = "За период";
            // 
            // countPoints
            // 
            this.countPoints.Location = new System.Drawing.Point(460, 59);
            this.countPoints.Name = "countPoints";
            this.countPoints.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.countPoints.Properties.Appearance.Options.UseBackColor = true;
            this.countPoints.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.countPoints.Size = new System.Drawing.Size(184, 60);
            this.countPoints.StyleController = this.generalLayout;
            this.countPoints.TabIndex = 69;
            // 
            // createReportButton
            // 
            this.createReportButton.Image = ((System.Drawing.Image)(resources.GetObject("createReportButton.Image")));
            this.createReportButton.Location = new System.Drawing.Point(798, 48);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(113, 22);
            this.createReportButton.StyleController = this.generalLayout;
            this.createReportButton.TabIndex = 64;
            this.createReportButton.Text = "Соз&дать отчет";
            // 
            // previewButton
            // 
            this.previewButton.Image = ((System.Drawing.Image)(resources.GetObject("previewButton.Image")));
            this.previewButton.Location = new System.Drawing.Point(798, 84);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(113, 22);
            this.previewButton.StyleController = this.generalLayout;
            this.previewButton.TabIndex = 65;
            this.previewButton.Text = "&Предпросмотр";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(338, 60);
            this.endDate.Name = "endDate";
            this.endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Size = new System.Drawing.Size(98, 20);
            this.endDate.StyleController = this.generalLayout;
            this.endDate.TabIndex = 62;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(231, 60);
            this.startDate.Name = "startDate";
            this.startDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDate.Size = new System.Drawing.Size(85, 20);
            this.startDate.StyleController = this.generalLayout;
            this.startDate.TabIndex = 61;
            // 
            // previewReportDocument
            // 
            this.previewReportDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewReportDocument.IsMetric = false;
            this.previewReportDocument.Location = new System.Drawing.Point(24, 166);
            this.previewReportDocument.Name = "previewReportDocument";
            this.previewReportDocument.Size = new System.Drawing.Size(892, 260);
            this.previewReportDocument.TabIndex = 56;
            // 
            // type
            // 
            this.type.EditValue = "Все";
            this.type.Location = new System.Drawing.Point(24, 99);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Size = new System.Drawing.Size(171, 20);
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
            this.previewLayoutGroup.CustomizationFormText = "previewLayoutGroup";
            this.previewLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.previewLayout});
            this.previewLayoutGroup.Location = new System.Drawing.Point(0, 123);
            this.previewLayoutGroup.Name = "previewLayoutGroup";
            this.previewLayoutGroup.Size = new System.Drawing.Size(920, 307);
            this.previewLayoutGroup.Text = "previewLayoutGroup";
            // 
            // previewLayout
            // 
            this.previewLayout.Control = this.previewReportDocument;
            this.previewLayout.CustomizationFormText = "previewLayout";
            this.previewLayout.Location = new System.Drawing.Point(0, 0);
            this.previewLayout.Name = "previewLayout";
            this.previewLayout.Size = new System.Drawing.Size(896, 264);
            this.previewLayout.Text = "previewLayout";
            this.previewLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewLayout.TextToControlDistance = 0;
            this.previewLayout.TextVisible = false;
            // 
            // createReportaLyoutGroup
            // 
            this.createReportaLyoutGroup.CustomizationFormText = "createReportaLyoutGroup";
            this.createReportaLyoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.typeLayout,
            this.endDateLayout,
            this.reportTypeLayout,
            this.reportPeriodLabelLayout,
            this.reportPeriodEmptySpace,
            this.startDateLayout,
            this.previewButtonLayout,
            this.createButtonLayout,
            this.buttonsEmptySpace,
            this.countPointsEmptySpace,
            this.countPointsLayout});
            this.createReportaLyoutGroup.Location = new System.Drawing.Point(0, 0);
            this.createReportaLyoutGroup.Name = "createReportaLyoutGroup";
            this.createReportaLyoutGroup.Size = new System.Drawing.Size(920, 123);
            this.createReportaLyoutGroup.Text = "createReportaLyoutGroup";
            // 
            // typeLayout
            // 
            this.typeLayout.Control = this.type;
            this.typeLayout.CustomizationFormText = "Тип изделия";
            this.typeLayout.Location = new System.Drawing.Point(0, 40);
            this.typeLayout.Name = "typeLayout";
            this.typeLayout.Size = new System.Drawing.Size(185, 40);
            this.typeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
            this.typeLayout.Text = "Тип изделия";
            this.typeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.typeLayout.TextSize = new System.Drawing.Size(78, 13);
            // 
            // endDateLayout
            // 
            this.endDateLayout.Control = this.endDate;
            this.endDateLayout.CustomizationFormText = "По";
            this.endDateLayout.Location = new System.Drawing.Point(296, 17);
            this.endDateLayout.Name = "endDateLayout";
            this.endDateLayout.Size = new System.Drawing.Size(120, 63);
            this.endDateLayout.Text = "По";
            this.endDateLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.endDateLayout.TextSize = new System.Drawing.Size(13, 13);
            this.endDateLayout.TextToControlDistance = 5;
            // 
            // reportTypeLayout
            // 
            this.reportTypeLayout.Control = this.reportType;
            this.reportTypeLayout.CustomizationFormText = "Тип отчета";
            this.reportTypeLayout.Location = new System.Drawing.Point(0, 0);
            this.reportTypeLayout.Name = "reportTypeLayout";
            this.reportTypeLayout.Size = new System.Drawing.Size(185, 40);
            this.reportTypeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 10, 0, 0);
            this.reportTypeLayout.Text = "Тип отчета";
            this.reportTypeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.reportTypeLayout.TextSize = new System.Drawing.Size(78, 13);
            // 
            // reportPeriodLabelLayout
            // 
            this.reportPeriodLabelLayout.Control = this.reportPeriodLabel;
            this.reportPeriodLabelLayout.CustomizationFormText = "reportPeriodLabelLayout";
            this.reportPeriodLabelLayout.Location = new System.Drawing.Point(185, 0);
            this.reportPeriodLabelLayout.Name = "reportPeriodLabelLayout";
            this.reportPeriodLabelLayout.Size = new System.Drawing.Size(66, 17);
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
            this.reportPeriodEmptySpace.Location = new System.Drawing.Point(251, 0);
            this.reportPeriodEmptySpace.Name = "reportPeriodEmptySpace";
            this.reportPeriodEmptySpace.Size = new System.Drawing.Size(165, 17);
            this.reportPeriodEmptySpace.Text = "reportPeriodEmptySpace";
            this.reportPeriodEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // startDateLayout
            // 
            this.startDateLayout.Control = this.startDate;
            this.startDateLayout.CustomizationFormText = "С";
            this.startDateLayout.Location = new System.Drawing.Point(185, 17);
            this.startDateLayout.Name = "startDateLayout";
            this.startDateLayout.Size = new System.Drawing.Size(111, 63);
            this.startDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.startDateLayout.Text = "С";
            this.startDateLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.startDateLayout.TextSize = new System.Drawing.Size(7, 13);
            this.startDateLayout.TextToControlDistance = 5;
            // 
            // previewButtonLayout
            // 
            this.previewButtonLayout.Control = this.previewButton;
            this.previewButtonLayout.CustomizationFormText = "previewButtonLayout";
            this.previewButtonLayout.Location = new System.Drawing.Point(767, 36);
            this.previewButtonLayout.Name = "previewButtonLayout";
            this.previewButtonLayout.Size = new System.Drawing.Size(129, 44);
            this.previewButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 5, 5, 5);
            this.previewButtonLayout.Text = "previewButtonLayout";
            this.previewButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewButtonLayout.TextToControlDistance = 0;
            this.previewButtonLayout.TextVisible = false;
            // 
            // createButtonLayout
            // 
            this.createButtonLayout.Control = this.createReportButton;
            this.createButtonLayout.CustomizationFormText = "createButtonLayout";
            this.createButtonLayout.Location = new System.Drawing.Point(767, 0);
            this.createButtonLayout.Name = "createButtonLayout";
            this.createButtonLayout.Size = new System.Drawing.Size(129, 36);
            this.createButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 5, 5, 5);
            this.createButtonLayout.Text = "createButtonLayout";
            this.createButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.createButtonLayout.TextToControlDistance = 0;
            this.createButtonLayout.TextVisible = false;
            // 
            // buttonsEmptySpace
            // 
            this.buttonsEmptySpace.AllowHotTrack = false;
            this.buttonsEmptySpace.CustomizationFormText = "buttonsEmptySpace";
            this.buttonsEmptySpace.Location = new System.Drawing.Point(624, 0);
            this.buttonsEmptySpace.Name = "buttonsEmptySpace";
            this.buttonsEmptySpace.Size = new System.Drawing.Size(143, 80);
            this.buttonsEmptySpace.Text = "buttonsEmptySpace";
            this.buttonsEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // countPointsEmptySpace
            // 
            this.countPointsEmptySpace.AllowHotTrack = false;
            this.countPointsEmptySpace.CustomizationFormText = "countPointsEmptySpace";
            this.countPointsEmptySpace.Location = new System.Drawing.Point(416, 0);
            this.countPointsEmptySpace.Name = "countPointsEmptySpace";
            this.countPointsEmptySpace.Size = new System.Drawing.Size(10, 80);
            this.countPointsEmptySpace.Text = "countPointsEmptySpace";
            this.countPointsEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // countPointsLayout
            // 
            this.countPointsLayout.Control = this.countPoints;
            this.countPointsLayout.CustomizationFormText = "Точки отсчета:";
            this.countPointsLayout.Location = new System.Drawing.Point(426, 0);
            this.countPointsLayout.Name = "countPointsLayout";
            this.countPointsLayout.Size = new System.Drawing.Size(198, 80);
            this.countPointsLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.countPointsLayout.Text = "Точки отсчета:";
            this.countPointsLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.countPointsLayout.TextSize = new System.Drawing.Size(78, 13);
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
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportaLyoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodLabelLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPointsEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPointsLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit reportType;
        private DevExpress.XtraEditors.ComboBoxEdit endDate;
        private DevExpress.XtraEditors.ComboBoxEdit startDate;
        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.ComboBoxEdit type;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        private DevExpress.XtraPrinting.Preview.DocumentViewer previewReportDocument;
        private DevExpress.XtraEditors.RadioGroup countPoints;
        private DevExpress.XtraLayout.LayoutControl generalLayout;
        private DevExpress.XtraLayout.LayoutControlGroup generalLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlGroup previewLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem previewLayout;
        private DevExpress.XtraLayout.LayoutControlGroup createReportaLyoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem typeLayout;
        private DevExpress.XtraLayout.LayoutControlItem startDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem endDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem reportTypeLayout;
        private DevExpress.XtraLayout.LayoutControlItem previewButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem createButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem countPointsLayout;
        private DevExpress.XtraEditors.LabelControl reportPeriodLabel;
        private DevExpress.XtraLayout.LayoutControlItem reportPeriodLabelLayout;
        private DevExpress.XtraLayout.EmptySpaceItem reportPeriodEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem buttonsEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem countPointsEmptySpace;
    }
}