namespace PrizmMain.Forms.Reports.Mill
{
    partial class MillReportsXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MillReportsXtraForm));
            this.previewReportDocument = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.generalReportLayout = new DevExpress.XtraLayout.LayoutControl();
            this.generalReportTypes = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.startDate = new DevExpress.XtraEditors.DateEdit();
            this.reportPeriodLabel = new DevExpress.XtraEditors.LabelControl();
            this.reportTypes = new DevExpress.XtraEditors.RadioGroup();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.generalReportLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.createReportaLyoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.startDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.finalDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.createReportButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.previewButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportPeriodLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportTypesLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.cheneralReportTypesLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.previewButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.createReportButtonEmptySpaceI = new DevExpress.XtraLayout.EmptySpaceItem();
            this.reportTypesEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.reportPeriodEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cheneralReportTypesEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.previewLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.previewLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.millReportsBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.generalReportLayout)).BeginInit();
            this.generalReportLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalReportTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalReportLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportaLyoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypesLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheneralReportTypesLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportButtonEmptySpaceI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypesEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheneralReportTypesEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millReportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // previewReportDocument
            // 
            this.previewReportDocument.AutoScroll = true;
            this.previewReportDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewReportDocument.IsMetric = false;
            this.previewReportDocument.Location = new System.Drawing.Point(29, 201);
            this.previewReportDocument.Name = "previewReportDocument";
            this.previewReportDocument.Size = new System.Drawing.Size(882, 220);
            this.previewReportDocument.TabIndex = 78;
            // 
            // previewButton
            // 
            this.previewButton.Image = ((System.Drawing.Image)(resources.GetObject("previewButton.Image")));
            this.previewButton.Location = new System.Drawing.Point(798, 94);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(113, 22);
            this.previewButton.StyleController = this.generalReportLayout;
            this.previewButton.TabIndex = 76;
            this.previewButton.Text = "&Предпросмотр";
            // 
            // generalReportLayout
            // 
            this.generalReportLayout.Controls.Add(this.generalReportTypes);
            this.generalReportLayout.Controls.Add(this.endDate);
            this.generalReportLayout.Controls.Add(this.startDate);
            this.generalReportLayout.Controls.Add(this.reportPeriodLabel);
            this.generalReportLayout.Controls.Add(this.reportTypes);
            this.generalReportLayout.Controls.Add(this.createReportButton);
            this.generalReportLayout.Controls.Add(this.previewButton);
            this.generalReportLayout.Controls.Add(this.previewReportDocument);
            this.generalReportLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalReportLayout.Location = new System.Drawing.Point(0, 0);
            this.generalReportLayout.Name = "generalReportLayout";
            this.generalReportLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(237, 320, 250, 350);
            this.generalReportLayout.Root = this.generalReportLayoutGroup;
            this.generalReportLayout.Size = new System.Drawing.Size(940, 450);
            this.generalReportLayout.TabIndex = 79;
            this.generalReportLayout.Text = "layoutControl1";
            // 
            // generalReportTypes
            // 
            this.generalReportTypes.Location = new System.Drawing.Point(384, 59);
            this.generalReportTypes.MultiColumn = true;
            this.generalReportTypes.Name = "generalReportTypes";
            this.generalReportTypes.Size = new System.Drawing.Size(350, 82);
            this.generalReportTypes.StyleController = this.generalReportLayout;
            this.generalReportTypes.TabIndex = 83;
            this.generalReportTypes.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.generalReportTypes_ItemCheck);
            // 
            // endDate
            // 
            this.endDate.EditValue = null;
            this.endDate.Location = new System.Drawing.Point(290, 60);
            this.endDate.Name = "endDate";
            this.endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Size = new System.Drawing.Size(75, 20);
            this.endDate.StyleController = this.generalReportLayout;
            this.endDate.TabIndex = 82;
            // 
            // startDate
            // 
            this.startDate.EditValue = null;
            this.startDate.Location = new System.Drawing.Point(192, 60);
            this.startDate.Name = "startDate";
            this.startDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDate.Size = new System.Drawing.Size(71, 20);
            this.startDate.StyleController = this.generalReportLayout;
            this.startDate.TabIndex = 81;
            // 
            // reportPeriodLabel
            // 
            this.reportPeriodLabel.Location = new System.Drawing.Point(180, 43);
            this.reportPeriodLabel.Name = "reportPeriodLabel";
            this.reportPeriodLabel.Size = new System.Drawing.Size(52, 13);
            this.reportPeriodLabel.StyleController = this.generalReportLayout;
            this.reportPeriodLabel.TabIndex = 80;
            this.reportPeriodLabel.Text = "За период";
            // 
            // reportTypes
            // 
            this.reportTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportTypes.Location = new System.Drawing.Point(26, 59);
            this.reportTypes.Name = "reportTypes";
            this.reportTypes.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.reportTypes.Properties.Appearance.Options.UseBackColor = true;
            this.reportTypes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.reportTypes.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Общий"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "По отгрузке")});
            this.reportTypes.Size = new System.Drawing.Size(140, 48);
            this.reportTypes.StyleController = this.generalReportLayout;
            this.reportTypes.TabIndex = 79;
            // 
            // createReportButton
            // 
            this.createReportButton.Image = ((System.Drawing.Image)(resources.GetObject("createReportButton.Image")));
            this.createReportButton.Location = new System.Drawing.Point(798, 58);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(113, 22);
            this.createReportButton.StyleController = this.generalReportLayout;
            this.createReportButton.TabIndex = 75;
            this.createReportButton.Text = "Соз&дать отчёт";
            // 
            // generalReportLayoutGroup
            // 
            this.generalReportLayoutGroup.CustomizationFormText = "generalReportLayoutGroup";
            this.generalReportLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalReportLayoutGroup.GroupBordersVisible = false;
            this.generalReportLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.createReportaLyoutGroup,
            this.previewLayoutGroup});
            this.generalReportLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalReportLayoutGroup.Name = "generalReportLayoutGroup";
            this.generalReportLayoutGroup.Size = new System.Drawing.Size(940, 450);
            this.generalReportLayoutGroup.Text = "generalReportLayoutGroup";
            this.generalReportLayoutGroup.TextVisible = false;
            // 
            // createReportaLyoutGroup
            // 
            this.createReportaLyoutGroup.CustomizationFormText = "Сформировать отчет";
            this.createReportaLyoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.startDateLayout,
            this.finalDateLayout,
            this.createReportButtonLayout,
            this.previewButtonLayout,
            this.reportPeriodLayout,
            this.reportTypesLayout,
            this.cheneralReportTypesLayout,
            this.buttonsEmptySpace,
            this.previewButtonEmptySpace,
            this.createReportButtonEmptySpaceI,
            this.reportTypesEmptySpace,
            this.reportPeriodEmptySpace,
            this.cheneralReportTypesEmptySpace});
            this.createReportaLyoutGroup.Location = new System.Drawing.Point(0, 0);
            this.createReportaLyoutGroup.Name = "createReportaLyoutGroup";
            this.createReportaLyoutGroup.Size = new System.Drawing.Size(920, 145);
            this.createReportaLyoutGroup.Text = "Сформировать отчёт";
            // 
            // startDateLayout
            // 
            this.startDateLayout.Control = this.startDate;
            this.startDateLayout.CustomizationFormText = "С";
            this.startDateLayout.Location = new System.Drawing.Point(146, 17);
            this.startDateLayout.Name = "startDateLayout";
            this.startDateLayout.Size = new System.Drawing.Size(97, 85);
            this.startDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.startDateLayout.Text = "С";
            this.startDateLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.startDateLayout.TextSize = new System.Drawing.Size(7, 13);
            this.startDateLayout.TextToControlDistance = 5;
            // 
            // finalDateLayout
            // 
            this.finalDateLayout.Control = this.endDate;
            this.finalDateLayout.CustomizationFormText = "По";
            this.finalDateLayout.Location = new System.Drawing.Point(243, 17);
            this.finalDateLayout.Name = "finalDateLayout";
            this.finalDateLayout.Size = new System.Drawing.Size(117, 85);
            this.finalDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 15, 0, 0);
            this.finalDateLayout.Text = "По";
            this.finalDateLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.finalDateLayout.TextSize = new System.Drawing.Size(13, 13);
            this.finalDateLayout.TextToControlDistance = 5;
            // 
            // createReportButtonLayout
            // 
            this.createReportButtonLayout.Control = this.createReportButton;
            this.createReportButtonLayout.CustomizationFormText = "createReportButtonLayout";
            this.createReportButtonLayout.Location = new System.Drawing.Point(767, 10);
            this.createReportButtonLayout.Name = "createReportButtonLayout";
            this.createReportButtonLayout.Size = new System.Drawing.Size(129, 36);
            this.createReportButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 5, 5, 5);
            this.createReportButtonLayout.Text = "createReportButtonLayout";
            this.createReportButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.createReportButtonLayout.TextToControlDistance = 0;
            this.createReportButtonLayout.TextVisible = false;
            // 
            // previewButtonLayout
            // 
            this.previewButtonLayout.Control = this.previewButton;
            this.previewButtonLayout.CustomizationFormText = "previewButtonLayout";
            this.previewButtonLayout.Location = new System.Drawing.Point(767, 46);
            this.previewButtonLayout.Name = "previewButtonLayout";
            this.previewButtonLayout.Size = new System.Drawing.Size(129, 36);
            this.previewButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 5, 5, 5);
            this.previewButtonLayout.Text = "previewButtonLayout";
            this.previewButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewButtonLayout.TextToControlDistance = 0;
            this.previewButtonLayout.TextVisible = false;
            // 
            // reportPeriodLayout
            // 
            this.reportPeriodLayout.Control = this.reportPeriodLabel;
            this.reportPeriodLayout.CustomizationFormText = "reportPeriodLayout";
            this.reportPeriodLayout.Location = new System.Drawing.Point(146, 0);
            this.reportPeriodLayout.Name = "reportPeriodLayout";
            this.reportPeriodLayout.Size = new System.Drawing.Size(66, 17);
            this.reportPeriodLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.reportPeriodLayout.Text = "reportPeriodLayout";
            this.reportPeriodLayout.TextSize = new System.Drawing.Size(0, 0);
            this.reportPeriodLayout.TextToControlDistance = 0;
            this.reportPeriodLayout.TextVisible = false;
            // 
            // reportTypesLayout
            // 
            this.reportTypesLayout.Control = this.reportTypes;
            this.reportTypesLayout.CustomizationFormText = "Выбор типа отчета";
            this.reportTypesLayout.Location = new System.Drawing.Point(0, 0);
            this.reportTypesLayout.Name = "reportTypesLayout";
            this.reportTypesLayout.Size = new System.Drawing.Size(146, 68);
            this.reportTypesLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 0, 0, 0);
            this.reportTypesLayout.Text = "Выбор типа";
            this.reportTypesLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.reportTypesLayout.TextSize = new System.Drawing.Size(59, 13);
            // 
            // cheneralReportTypesLayout
            // 
            this.cheneralReportTypesLayout.Control = this.generalReportTypes;
            this.cheneralReportTypesLayout.CustomizationFormText = "Включить";
            this.cheneralReportTypesLayout.Location = new System.Drawing.Point(360, 0);
            this.cheneralReportTypesLayout.Name = "cheneralReportTypesLayout";
            this.cheneralReportTypesLayout.Size = new System.Drawing.Size(354, 102);
            this.cheneralReportTypesLayout.Text = "Включить";
            this.cheneralReportTypesLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.cheneralReportTypesLayout.TextSize = new System.Drawing.Size(59, 13);
            // 
            // buttonsEmptySpace
            // 
            this.buttonsEmptySpace.AllowHotTrack = false;
            this.buttonsEmptySpace.CustomizationFormText = "buttonsEmptySpace";
            this.buttonsEmptySpace.Location = new System.Drawing.Point(767, 92);
            this.buttonsEmptySpace.Name = "buttonsEmptySpace";
            this.buttonsEmptySpace.Size = new System.Drawing.Size(129, 10);
            this.buttonsEmptySpace.Text = "buttonsEmptySpace";
            this.buttonsEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // previewButtonEmptySpace
            // 
            this.previewButtonEmptySpace.AllowHotTrack = false;
            this.previewButtonEmptySpace.CustomizationFormText = "previewButtonEmptySpace";
            this.previewButtonEmptySpace.Location = new System.Drawing.Point(767, 82);
            this.previewButtonEmptySpace.Name = "previewButtonEmptySpace";
            this.previewButtonEmptySpace.Size = new System.Drawing.Size(129, 10);
            this.previewButtonEmptySpace.Text = "previewButtonEmptySpace";
            this.previewButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // createReportButtonEmptySpaceI
            // 
            this.createReportButtonEmptySpaceI.AllowHotTrack = false;
            this.createReportButtonEmptySpaceI.CustomizationFormText = "createReportButtonEmptySpaceI";
            this.createReportButtonEmptySpaceI.Location = new System.Drawing.Point(767, 0);
            this.createReportButtonEmptySpaceI.Name = "createReportButtonEmptySpaceI";
            this.createReportButtonEmptySpaceI.Size = new System.Drawing.Size(129, 10);
            this.createReportButtonEmptySpaceI.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 2);
            this.createReportButtonEmptySpaceI.Text = "createReportButtonEmptySpaceI";
            this.createReportButtonEmptySpaceI.TextSize = new System.Drawing.Size(0, 0);
            // 
            // reportTypesEmptySpace
            // 
            this.reportTypesEmptySpace.AllowHotTrack = false;
            this.reportTypesEmptySpace.CustomizationFormText = "reportTypesEmptySpace";
            this.reportTypesEmptySpace.Location = new System.Drawing.Point(0, 68);
            this.reportTypesEmptySpace.Name = "reportTypesEmptySpace";
            this.reportTypesEmptySpace.Size = new System.Drawing.Size(146, 34);
            this.reportTypesEmptySpace.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 0, 0, 0);
            this.reportTypesEmptySpace.Text = "reportTypesEmptySpace";
            this.reportTypesEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // reportPeriodEmptySpace
            // 
            this.reportPeriodEmptySpace.AllowHotTrack = false;
            this.reportPeriodEmptySpace.CustomizationFormText = "reportPeriodEmptySpace";
            this.reportPeriodEmptySpace.Location = new System.Drawing.Point(212, 0);
            this.reportPeriodEmptySpace.Name = "reportPeriodEmptySpace";
            this.reportPeriodEmptySpace.Size = new System.Drawing.Size(148, 17);
            this.reportPeriodEmptySpace.Text = "reportPeriodEmptySpace";
            this.reportPeriodEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cheneralReportTypesEmptySpace
            // 
            this.cheneralReportTypesEmptySpace.AllowHotTrack = false;
            this.cheneralReportTypesEmptySpace.CustomizationFormText = "cheneralReportTypesEmptySpace";
            this.cheneralReportTypesEmptySpace.Location = new System.Drawing.Point(714, 0);
            this.cheneralReportTypesEmptySpace.Name = "cheneralReportTypesEmptySpace";
            this.cheneralReportTypesEmptySpace.Size = new System.Drawing.Size(53, 102);
            this.cheneralReportTypesEmptySpace.Text = "cheneralReportTypesEmptySpace";
            this.cheneralReportTypesEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // previewLayoutGroup
            // 
            this.previewLayoutGroup.CustomizationFormText = "Предворительный просмотр отчета:";
            this.previewLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.previewLayout});
            this.previewLayoutGroup.Location = new System.Drawing.Point(0, 145);
            this.previewLayoutGroup.Name = "previewLayoutGroup";
            this.previewLayoutGroup.Size = new System.Drawing.Size(920, 285);
            this.previewLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.previewLayoutGroup.Text = "Предворительный просмотр отчёта";
            // 
            // previewLayout
            // 
            this.previewLayout.Control = this.previewReportDocument;
            this.previewLayout.CustomizationFormText = "previewLayout";
            this.previewLayout.Location = new System.Drawing.Point(0, 0);
            this.previewLayout.Name = "previewLayout";
            this.previewLayout.Size = new System.Drawing.Size(896, 234);
            this.previewLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.previewLayout.Text = "previewLayout";
            this.previewLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewLayout.TextToControlDistance = 0;
            this.previewLayout.TextVisible = false;
            // 
            // MillReportsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.generalReportLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MillReportsXtraForm";
            this.Text = "Завод - отчет";
            this.Load += new System.EventHandler(this.MillReportsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generalReportLayout)).EndInit();
            this.generalReportLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generalReportTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalReportLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportaLyoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypesLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheneralReportTypesLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportButtonEmptySpaceI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypesEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPeriodEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheneralReportTypesEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millReportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        public DevExpress.XtraPrinting.Preview.DocumentViewer previewReportDocument;
        private DevExpress.XtraLayout.LayoutControl generalReportLayout;
        private DevExpress.XtraLayout.LayoutControlGroup generalReportLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem previewLayout;
        private DevExpress.XtraLayout.LayoutControlItem createReportButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem previewButtonLayout;
        private DevExpress.XtraEditors.RadioGroup reportTypes;
        private DevExpress.XtraLayout.LayoutControlItem reportTypesLayout;
        private DevExpress.XtraEditors.DateEdit endDate;
        private DevExpress.XtraEditors.DateEdit startDate;
        private DevExpress.XtraEditors.LabelControl reportPeriodLabel;
        private DevExpress.XtraLayout.LayoutControlItem reportPeriodLayout;
        private DevExpress.XtraLayout.LayoutControlItem startDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem finalDateLayout;
        private DevExpress.XtraEditors.CheckedListBoxControl generalReportTypes;
        private DevExpress.XtraLayout.LayoutControlItem cheneralReportTypesLayout;
        private DevExpress.XtraLayout.LayoutControlGroup createReportaLyoutGroup;
        private DevExpress.XtraLayout.LayoutControlGroup previewLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem buttonsEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem previewButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem createReportButtonEmptySpaceI;
        private DevExpress.XtraLayout.EmptySpaceItem reportTypesEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem reportPeriodEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem cheneralReportTypesEmptySpace;
        private System.Windows.Forms.BindingSource millReportsBindingSource;
    }
}