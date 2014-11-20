namespace PrizmMain.Forms.Reports.Incoming
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
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.toDate = new DevExpress.XtraEditors.DateEdit();
            this.fromDate = new DevExpress.XtraEditors.DateEdit();
            this.toLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromLabel = new DevExpress.XtraEditors.LabelControl();
            this.previewReportDocument = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.incomingInspectionDateLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(420, 36);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(89, 23);
            this.previewButton.TabIndex = 56;
            this.previewButton.Text = "&Предпросмотр";
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(533, 35);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(89, 23);
            this.createReportButton.TabIndex = 55;
            this.createReportButton.Text = "Соз&дать отчет";
            // 
            // toDate
            // 
            this.toDate.EditValue = null;
            this.toDate.Location = new System.Drawing.Point(174, 38);
            this.toDate.Name = "toDate";
            this.toDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDate.Size = new System.Drawing.Size(90, 20);
            this.toDate.TabIndex = 54;
            // 
            // fromDate
            // 
            this.fromDate.EditValue = null;
            this.fromDate.Location = new System.Drawing.Point(40, 38);
            this.fromDate.Name = "fromDate";
            this.fromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDate.Size = new System.Drawing.Size(90, 20);
            this.fromDate.TabIndex = 53;
            // 
            // toLabel
            // 
            this.toLabel.Location = new System.Drawing.Point(158, 41);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(12, 13);
            this.toLabel.TabIndex = 52;
            this.toLabel.Text = "по";
            // 
            // fromLabel
            // 
            this.fromLabel.Location = new System.Drawing.Point(12, 41);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(5, 13);
            this.fromLabel.TabIndex = 51;
            this.fromLabel.Text = "с";
            // 
            // previewReportDocument
            // 
            this.previewReportDocument.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previewReportDocument.IsMetric = false;
            this.previewReportDocument.Location = new System.Drawing.Point(0, 76);
            this.previewReportDocument.Name = "previewReportDocument";
            this.previewReportDocument.Size = new System.Drawing.Size(940, 374);
            this.previewReportDocument.TabIndex = 50;
            // 
            // incomingInspectionDateLabel
            // 
            this.incomingInspectionDateLabel.Location = new System.Drawing.Point(12, 12);
            this.incomingInspectionDateLabel.Name = "incomingInspectionDateLabel";
            this.incomingInspectionDateLabel.Size = new System.Drawing.Size(132, 13);
            this.incomingInspectionDateLabel.TabIndex = 57;
            this.incomingInspectionDateLabel.Text = "Дата входного контроля:";
            // 
            // InspectionReportsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.incomingInspectionDateLabel);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.previewReportDocument);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InspectionReportsXtraForm";
            this.Text = "Входной контроль - отчет";
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        private DevExpress.XtraEditors.DateEdit toDate;
        private DevExpress.XtraEditors.DateEdit fromDate;
        private DevExpress.XtraEditors.LabelControl toLabel;
        private DevExpress.XtraEditors.LabelControl fromLabel;
        private DevExpress.XtraPrinting.Preview.DocumentViewer previewReportDocument;
        private DevExpress.XtraEditors.LabelControl incomingInspectionDateLabel;
    }
}