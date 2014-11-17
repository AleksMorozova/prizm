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
            this.reportType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.reportTypeLabel = new DevExpress.XtraEditors.LabelControl();
            this.typeLabel = new DevExpress.XtraEditors.LabelControl();
            this.to = new DevExpress.XtraEditors.ComboBoxEdit();
            this.from = new DevExpress.XtraEditors.ComboBoxEdit();
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.fromLabel = new DevExpress.XtraEditors.LabelControl();
            this.toLabel = new DevExpress.XtraEditors.LabelControl();
            this.previewReportDocument = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.countPoints = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.reportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.from.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPoints.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // reportType
            // 
            this.reportType.EditValue = "Used products";
            this.reportType.Location = new System.Drawing.Point(107, 5);
            this.reportType.Name = "reportType";
            this.reportType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reportType.Size = new System.Drawing.Size(154, 20);
            this.reportType.TabIndex = 68;
            // 
            // reportTypeLabel
            // 
            this.reportTypeLabel.Location = new System.Drawing.Point(23, 8);
            this.reportTypeLabel.Name = "reportTypeLabel";
            this.reportTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.reportTypeLabel.TabIndex = 67;
            this.reportTypeLabel.Text = "Report type";
            // 
            // typeLabel
            // 
            this.typeLabel.Location = new System.Drawing.Point(23, 42);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(24, 13);
            this.typeLabel.TabIndex = 66;
            this.typeLabel.Text = "Type";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(447, 5);
            this.to.Name = "to";
            this.to.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.to.Size = new System.Drawing.Size(99, 20);
            this.to.TabIndex = 62;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(315, 5);
            this.from.Name = "from";
            this.from.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.from.Size = new System.Drawing.Size(99, 20);
            this.from.TabIndex = 61;
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(553, 37);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(73, 23);
            this.previewButton.TabIndex = 65;
            this.previewButton.Text = "Preview";
            // 
            // type
            // 
            this.type.EditValue = "All";
            this.type.Location = new System.Drawing.Point(70, 39);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Size = new System.Drawing.Size(99, 20);
            this.type.TabIndex = 63;
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(648, 37);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(75, 23);
            this.createReportButton.TabIndex = 64;
            this.createReportButton.Text = "Create report";
            // 
            // fromLabel
            // 
            this.fromLabel.Location = new System.Drawing.Point(285, 8);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(24, 13);
            this.fromLabel.TabIndex = 57;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.Location = new System.Drawing.Point(429, 8);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(10, 13);
            this.toLabel.TabIndex = 58;
            this.toLabel.Text = "to";
            // 
            // previewReportDocument
            // 
            this.previewReportDocument.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previewReportDocument.IsMetric = false;
            this.previewReportDocument.Location = new System.Drawing.Point(0, 71);
            this.previewReportDocument.Name = "previewReportDocument";
            this.previewReportDocument.Size = new System.Drawing.Size(940, 379);
            this.previewReportDocument.TabIndex = 56;
            // 
            // countPoints
            // 
            this.countPoints.Location = new System.Drawing.Point(209, 35);
            this.countPoints.Name = "countPoints";
            this.countPoints.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.countPoints.Properties.Appearance.Options.UseBackColor = true;
            this.countPoints.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.countPoints.Size = new System.Drawing.Size(132, 30);
            this.countPoints.TabIndex = 69;
            // 
            // ConstructionReportsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.countPoints);
            this.Controls.Add(this.reportType);
            this.Controls.Add(this.reportTypeLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.type);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.previewReportDocument);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConstructionReportsXtraForm";
            this.Text = "Construction reports";
            this.Load += new System.EventHandler(this.ConstructionReportsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.from.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPoints.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit reportType;
        private DevExpress.XtraEditors.LabelControl reportTypeLabel;
        private DevExpress.XtraEditors.LabelControl typeLabel;
        private DevExpress.XtraEditors.ComboBoxEdit to;
        private DevExpress.XtraEditors.ComboBoxEdit from;
        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.ComboBoxEdit type;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        private DevExpress.XtraEditors.LabelControl fromLabel;
        private DevExpress.XtraEditors.LabelControl toLabel;
        private DevExpress.XtraPrinting.Preview.DocumentViewer previewReportDocument;
        private DevExpress.XtraEditors.RadioGroup countPoints;
    }
}