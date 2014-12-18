namespace Prizm.Main.Forms.Reports.Incoming
{
    partial class InspectionReportsXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectionReportsXtraForm));
            this.generalLayout = new DevExpress.XtraLayout.LayoutControl();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.incomingInspectionDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.previewReportDocument = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.startDate = new DevExpress.XtraEditors.DateEdit();
            this.generalLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.createReportLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.startDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.incomingInspectionDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.endDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.createButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.previewButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.DateEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.previewReportLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.previewLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectionReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).BeginInit();
            this.generalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingInspectionDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelEmptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewReportLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionReportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // generalLayout
            // 
            this.generalLayout.Controls.Add(this.endDate);
            this.generalLayout.Controls.Add(this.createReportButton);
            this.generalLayout.Controls.Add(this.previewButton);
            this.generalLayout.Controls.Add(this.incomingInspectionDateLabel);
            this.generalLayout.Controls.Add(this.previewReportDocument);
            this.generalLayout.Controls.Add(this.startDate);
            this.generalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalLayout.Location = new System.Drawing.Point(0, 0);
            this.generalLayout.Name = "generalLayout";
            this.generalLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(340, 194, 250, 350);
            this.generalLayout.Root = this.generalLayoutGroup;
            this.generalLayout.Size = new System.Drawing.Size(940, 450);
            this.generalLayout.TabIndex = 58;
            this.generalLayout.Text = "layoutControl1";
            // 
            // endDate
            // 
            this.endDate.EditValue = null;
            this.endDate.Location = new System.Drawing.Point(138, 60);
            this.endDate.Name = "endDate";
            this.endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Size = new System.Drawing.Size(79, 20);
            this.endDate.StyleController = this.generalLayout;
            this.endDate.TabIndex = 54;
            // 
            // createReportButton
            // 
            this.createReportButton.Image = ((System.Drawing.Image)(resources.GetObject("createReportButton.Image")));
            this.createReportButton.Location = new System.Drawing.Point(354, 58);
            this.createReportButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(110, 22);
            this.createReportButton.StyleController = this.generalLayout;
            this.createReportButton.TabIndex = 55;
            this.createReportButton.Text = "Соз&дать отчет";
            // 
            // previewButton
            // 
            this.previewButton.Image = ((System.Drawing.Image)(resources.GetObject("previewButton.Image")));
            this.previewButton.Location = new System.Drawing.Point(228, 58);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(110, 22);
            this.previewButton.StyleController = this.generalLayout;
            this.previewButton.TabIndex = 56;
            this.previewButton.Text = "&Предпросмотр";
            // 
            // incomingInspectionDateLabel
            // 
            this.incomingInspectionDateLabel.Location = new System.Drawing.Point(24, 43);
            this.incomingInspectionDateLabel.Name = "incomingInspectionDateLabel";
            this.incomingInspectionDateLabel.Size = new System.Drawing.Size(132, 13);
            this.incomingInspectionDateLabel.StyleController = this.generalLayout;
            this.incomingInspectionDateLabel.TabIndex = 57;
            this.incomingInspectionDateLabel.Text = "Дата входного контроля:";
            // 
            // previewReportDocument
            // 
            this.previewReportDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewReportDocument.IsMetric = false;
            this.previewReportDocument.Location = new System.Drawing.Point(29, 140);
            this.previewReportDocument.Name = "previewReportDocument";
            this.previewReportDocument.Size = new System.Drawing.Size(882, 281);
            this.previewReportDocument.TabIndex = 50;
            // 
            // startDate
            // 
            this.startDate.EditValue = null;
            this.startDate.Location = new System.Drawing.Point(36, 60);
            this.startDate.Name = "startDate";
            this.startDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDate.Size = new System.Drawing.Size(82, 20);
            this.startDate.StyleController = this.generalLayout;
            this.startDate.TabIndex = 53;
            // 
            // generalLayoutGroup
            // 
            this.generalLayoutGroup.CustomizationFormText = "generalLayoutGroup";
            this.generalLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalLayoutGroup.GroupBordersVisible = false;
            this.generalLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.createReportLayoutGroup,
            this.previewReportLayoutGroup});
            this.generalLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalLayoutGroup.Name = "generalLayoutGroup";
            this.generalLayoutGroup.Size = new System.Drawing.Size(940, 450);
            this.generalLayoutGroup.Text = "generalLayoutGroup";
            this.generalLayoutGroup.TextVisible = false;
            // 
            // createReportLayoutGroup
            // 
            this.createReportLayoutGroup.CustomizationFormText = "Сформировать отчёт";
            this.createReportLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.startDateLayout,
            this.incomingInspectionDateLayout,
            this.endDateLayout,
            this.createButtonLayout,
            this.labelEmptySpaceItem,
            this.previewButtonLayout,
            this.DateEmptySpace});
            this.createReportLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.createReportLayoutGroup.Name = "createReportLayoutGroup";
            this.createReportLayoutGroup.Size = new System.Drawing.Size(920, 84);
            this.createReportLayoutGroup.Text = "Сформировать отчёт";
            // 
            // startDateLayout
            // 
            this.startDateLayout.Control = this.startDate;
            this.startDateLayout.CustomizationFormText = "С";
            this.startDateLayout.Location = new System.Drawing.Point(0, 17);
            this.startDateLayout.Name = "startDateLayout";
            this.startDateLayout.Size = new System.Drawing.Size(98, 24);
            this.startDateLayout.Text = "С";
            this.startDateLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.startDateLayout.TextSize = new System.Drawing.Size(7, 13);
            this.startDateLayout.TextToControlDistance = 5;
            // 
            // incomingInspectionDateLayout
            // 
            this.incomingInspectionDateLayout.Control = this.incomingInspectionDateLabel;
            this.incomingInspectionDateLayout.CustomizationFormText = "incomingInspectionDateLayout";
            this.incomingInspectionDateLayout.Location = new System.Drawing.Point(0, 0);
            this.incomingInspectionDateLayout.Name = "incomingInspectionDateLayout";
            this.incomingInspectionDateLayout.Size = new System.Drawing.Size(136, 17);
            this.incomingInspectionDateLayout.Text = "incomingInspectionDateLayout";
            this.incomingInspectionDateLayout.TextSize = new System.Drawing.Size(0, 0);
            this.incomingInspectionDateLayout.TextToControlDistance = 0;
            this.incomingInspectionDateLayout.TextVisible = false;
            // 
            // endDateLayout
            // 
            this.endDateLayout.Control = this.endDate;
            this.endDateLayout.CustomizationFormText = "По";
            this.endDateLayout.Location = new System.Drawing.Point(98, 17);
            this.endDateLayout.Name = "endDateLayout";
            this.endDateLayout.Size = new System.Drawing.Size(99, 24);
            this.endDateLayout.Text = "По";
            this.endDateLayout.TextSize = new System.Drawing.Size(13, 13);
            // 
            // createButtonLayout
            // 
            this.createButtonLayout.Control = this.createReportButton;
            this.createButtonLayout.CustomizationFormText = "createButtonLayout";
            this.createButtonLayout.Location = new System.Drawing.Point(323, 0);
            this.createButtonLayout.MinSize = new System.Drawing.Size(110, 36);
            this.createButtonLayout.Name = "createButtonLayout";
            this.createButtonLayout.Size = new System.Drawing.Size(126, 41);
            this.createButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.createButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 5, 15, 0);
            this.createButtonLayout.Text = "createButtonLayout";
            this.createButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.createButtonLayout.TextToControlDistance = 0;
            this.createButtonLayout.TextVisible = false;
            // 
            // labelEmptySpaceItem
            // 
            this.labelEmptySpaceItem.AllowHotTrack = false;
            this.labelEmptySpaceItem.CustomizationFormText = "labelEmptySpaceItem";
            this.labelEmptySpaceItem.Location = new System.Drawing.Point(136, 0);
            this.labelEmptySpaceItem.Name = "labelEmptySpaceItem";
            this.labelEmptySpaceItem.Size = new System.Drawing.Size(61, 17);
            this.labelEmptySpaceItem.Text = "labelEmptySpaceItem";
            this.labelEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // previewButtonLayout
            // 
            this.previewButtonLayout.Control = this.previewButton;
            this.previewButtonLayout.CustomizationFormText = "previewButtonLayout";
            this.previewButtonLayout.Location = new System.Drawing.Point(197, 0);
            this.previewButtonLayout.MinSize = new System.Drawing.Size(126, 36);
            this.previewButtonLayout.Name = "previewButtonLayout";
            this.previewButtonLayout.Size = new System.Drawing.Size(126, 41);
            this.previewButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.previewButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 5, 15, 0);
            this.previewButtonLayout.Text = "previewButtonLayout";
            this.previewButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewButtonLayout.TextToControlDistance = 0;
            this.previewButtonLayout.TextVisible = false;
            // 
            // DateEmptySpace
            // 
            this.DateEmptySpace.AllowHotTrack = false;
            this.DateEmptySpace.CustomizationFormText = "DateEmptySpace";
            this.DateEmptySpace.Location = new System.Drawing.Point(449, 0);
            this.DateEmptySpace.Name = "DateEmptySpace";
            this.DateEmptySpace.Size = new System.Drawing.Size(447, 41);
            this.DateEmptySpace.Text = "DateEmptySpace";
            this.DateEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // previewReportLayoutGroup
            // 
            this.previewReportLayoutGroup.CustomizationFormText = "Предворительный просмотр отчёта";
            this.previewReportLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.previewLayout});
            this.previewReportLayoutGroup.Location = new System.Drawing.Point(0, 84);
            this.previewReportLayoutGroup.Name = "previewReportLayoutGroup";
            this.previewReportLayoutGroup.Size = new System.Drawing.Size(920, 346);
            this.previewReportLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.previewReportLayoutGroup.Text = "Предварительный просмотр отчёта ";
            // 
            // previewLayout
            // 
            this.previewLayout.Control = this.previewReportDocument;
            this.previewLayout.CustomizationFormText = "previewLayout";
            this.previewLayout.Location = new System.Drawing.Point(0, 0);
            this.previewLayout.Name = "previewLayout";
            this.previewLayout.Size = new System.Drawing.Size(896, 295);
            this.previewLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.previewLayout.Text = "previewLayout";
            this.previewLayout.TextSize = new System.Drawing.Size(0, 0);
            this.previewLayout.TextToControlDistance = 0;
            this.previewLayout.TextVisible = false;
            // 
            // InspectionReportsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.generalLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InspectionReportsXtraForm";
            this.Text = "Отчет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InspectionReportsXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.InspectionReportsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).EndInit();
            this.generalLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createReportLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingInspectionDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelEmptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewReportLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionReportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        private DevExpress.XtraEditors.DateEdit endDate;
        private DevExpress.XtraEditors.DateEdit startDate;
        private DevExpress.XtraPrinting.Preview.DocumentViewer previewReportDocument;
        private DevExpress.XtraEditors.LabelControl incomingInspectionDateLabel;
        private DevExpress.XtraLayout.LayoutControl generalLayout;
        private DevExpress.XtraLayout.LayoutControlGroup generalLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem previewLayout;
        private DevExpress.XtraLayout.LayoutControlGroup createReportLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem startDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem incomingInspectionDateLayout;
        private DevExpress.XtraLayout.LayoutControlGroup previewReportLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem endDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem previewButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem createButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem DateEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem labelEmptySpaceItem;
        private System.Windows.Forms.BindingSource inspectionReportsBindingSource;
    }
}