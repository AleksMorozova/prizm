namespace PrizmMain.Forms
{
    partial class InspectionPipeSearchEditXtraForm
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
            this.unloadedDate = new DevExpress.XtraEditors.DateEdit();
            this.unloadedDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.inspection = new DevExpress.XtraEditors.GroupControl();
            this.inspectionResult = new DevExpress.XtraEditors.RadioGroup();
            this.holdReason = new DevExpress.XtraEditors.TextEdit();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.certificateNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.pipeNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pipeNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeParameters = new DevExpress.XtraEditors.GroupControl();
            this.millHeatNumber = new DevExpress.XtraEditors.TextEdit();
            this.inspectionDiameter = new DevExpress.XtraEditors.TextEdit();
            this.millDiameter = new DevExpress.XtraEditors.TextEdit();
            this.diameterLabel = new DevExpress.XtraEditors.LabelControl();
            this.millGeometricParamLabel = new DevExpress.XtraEditors.LabelControl();
            this.heatNumberLbel = new DevExpress.XtraEditors.LabelControl();
            this.inspectionHeatNumber = new DevExpress.XtraEditors.TextEdit();
            this.weightLabel = new DevExpress.XtraEditors.LabelControl();
            this.millWeight = new DevExpress.XtraEditors.TextEdit();
            this.thicknessLabel = new DevExpress.XtraEditors.LabelControl();
            this.inspectionThickness = new DevExpress.XtraEditors.TextEdit();
            this.millThickness = new DevExpress.XtraEditors.TextEdit();
            this.lengthLabel = new DevExpress.XtraEditors.LabelControl();
            this.millLength = new DevExpress.XtraEditors.TextEdit();
            this.inspectionGeometricParamLabel = new DevExpress.XtraEditors.LabelControl();
            this.inspectionWeight = new DevExpress.XtraEditors.TextEdit();
            this.inspectionLength = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.unloadedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unloadedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspection)).BeginInit();
            this.inspection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeParameters)).BeginInit();
            this.pipeParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.millHeatNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDiameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millDiameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHeatNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionLength.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // unloadedDate
            // 
            this.unloadedDate.EditValue = null;
            this.unloadedDate.Location = new System.Drawing.Point(373, 111);
            this.unloadedDate.Name = "unloadedDate";
            this.unloadedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unloadedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unloadedDate.Size = new System.Drawing.Size(136, 20);
            this.unloadedDate.TabIndex = 42;
            // 
            // unloadedDateLabel
            // 
            this.unloadedDateLabel.Location = new System.Drawing.Point(373, 92);
            this.unloadedDateLabel.Name = "unloadedDateLabel";
            this.unloadedDateLabel.Size = new System.Drawing.Size(70, 13);
            this.unloadedDateLabel.TabIndex = 41;
            this.unloadedDateLabel.Text = "Unloaded date";
            // 
            // inspection
            // 
            this.inspection.Controls.Add(this.inspectionResult);
            this.inspection.Controls.Add(this.holdReason);
            this.inspection.Location = new System.Drawing.Point(373, 156);
            this.inspection.Name = "inspection";
            this.inspection.Size = new System.Drawing.Size(270, 115);
            this.inspection.TabIndex = 40;
            this.inspection.Text = "Incoming inspection";
            // 
            // inspectionResult
            // 
            this.inspectionResult.Location = new System.Drawing.Point(5, 24);
            this.inspectionResult.Name = "inspectionResult";
            this.inspectionResult.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.inspectionResult.Properties.Appearance.Options.UseBackColor = true;
            this.inspectionResult.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.inspectionResult.Size = new System.Drawing.Size(80, 86);
            this.inspectionResult.TabIndex = 44;
            // 
            // holdReason
            // 
            this.holdReason.Location = new System.Drawing.Point(91, 59);
            this.holdReason.Name = "holdReason";
            this.holdReason.Size = new System.Drawing.Size(174, 20);
            this.holdReason.TabIndex = 3;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(27, 111);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(279, 20);
            this.certificateNumber.TabIndex = 39;
            // 
            // certificateNumberLabel
            // 
            this.certificateNumberLabel.Location = new System.Drawing.Point(27, 92);
            this.certificateNumberLabel.Name = "certificateNumberLabel";
            this.certificateNumberLabel.Size = new System.Drawing.Size(89, 13);
            this.certificateNumberLabel.TabIndex = 38;
            this.certificateNumberLabel.Text = "Certificate number";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(232, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 36;
            this.searchButton.Text = "Search";
            // 
            // pipeNumber
            // 
            this.pipeNumber.Location = new System.Drawing.Point(27, 46);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeNumber.Size = new System.Drawing.Size(141, 20);
            this.pipeNumber.TabIndex = 35;
            // 
            // pipeNumberLabel
            // 
            this.pipeNumberLabel.Location = new System.Drawing.Point(27, 27);
            this.pipeNumberLabel.Name = "pipeNumberLabel";
            this.pipeNumberLabel.Size = new System.Drawing.Size(59, 13);
            this.pipeNumberLabel.TabIndex = 34;
            this.pipeNumberLabel.Text = "Pipe number";
            // 
            // pipeParameters
            // 
            this.pipeParameters.Controls.Add(this.millHeatNumber);
            this.pipeParameters.Controls.Add(this.inspectionDiameter);
            this.pipeParameters.Controls.Add(this.millDiameter);
            this.pipeParameters.Controls.Add(this.diameterLabel);
            this.pipeParameters.Controls.Add(this.millGeometricParamLabel);
            this.pipeParameters.Controls.Add(this.heatNumberLbel);
            this.pipeParameters.Controls.Add(this.inspectionHeatNumber);
            this.pipeParameters.Controls.Add(this.weightLabel);
            this.pipeParameters.Controls.Add(this.millWeight);
            this.pipeParameters.Controls.Add(this.thicknessLabel);
            this.pipeParameters.Controls.Add(this.inspectionThickness);
            this.pipeParameters.Controls.Add(this.millThickness);
            this.pipeParameters.Controls.Add(this.lengthLabel);
            this.pipeParameters.Controls.Add(this.millLength);
            this.pipeParameters.Controls.Add(this.inspectionGeometricParamLabel);
            this.pipeParameters.Controls.Add(this.inspectionWeight);
            this.pipeParameters.Controls.Add(this.inspectionLength);
            this.pipeParameters.Location = new System.Drawing.Point(27, 156);
            this.pipeParameters.Name = "pipeParameters";
            this.pipeParameters.Size = new System.Drawing.Size(308, 198);
            this.pipeParameters.TabIndex = 43;
            this.pipeParameters.Text = "Inspection pipe parameters";
            // 
            // millHeatNumber
            // 
            this.millHeatNumber.Location = new System.Drawing.Point(221, 166);
            this.millHeatNumber.Name = "millHeatNumber";
            this.millHeatNumber.Properties.ReadOnly = true;
            this.millHeatNumber.Size = new System.Drawing.Size(73, 20);
            this.millHeatNumber.TabIndex = 30;
            // 
            // inspectionDiameter
            // 
            this.inspectionDiameter.Location = new System.Drawing.Point(98, 110);
            this.inspectionDiameter.Name = "inspectionDiameter";
            this.inspectionDiameter.Size = new System.Drawing.Size(73, 20);
            this.inspectionDiameter.TabIndex = 25;
            // 
            // millDiameter
            // 
            this.millDiameter.Location = new System.Drawing.Point(221, 110);
            this.millDiameter.Name = "millDiameter";
            this.millDiameter.Properties.ReadOnly = true;
            this.millDiameter.Size = new System.Drawing.Size(73, 20);
            this.millDiameter.TabIndex = 25;
            // 
            // diameterLabel
            // 
            this.diameterLabel.Location = new System.Drawing.Point(10, 113);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(58, 13);
            this.diameterLabel.TabIndex = 24;
            this.diameterLabel.Text = "Diameter, m";
            // 
            // millGeometricParamLabel
            // 
            this.millGeometricParamLabel.Location = new System.Drawing.Point(221, 24);
            this.millGeometricParamLabel.Name = "millGeometricParamLabel";
            this.millGeometricParamLabel.Size = new System.Drawing.Size(14, 13);
            this.millGeometricParamLabel.TabIndex = 19;
            this.millGeometricParamLabel.Text = "Mill";
            // 
            // heatNumberLbel
            // 
            this.heatNumberLbel.Location = new System.Drawing.Point(10, 169);
            this.heatNumberLbel.Name = "heatNumberLbel";
            this.heatNumberLbel.Size = new System.Drawing.Size(62, 13);
            this.heatNumberLbel.TabIndex = 27;
            this.heatNumberLbel.Text = "Heat number";
            // 
            // inspectionHeatNumber
            // 
            this.inspectionHeatNumber.Location = new System.Drawing.Point(98, 166);
            this.inspectionHeatNumber.Name = "inspectionHeatNumber";
            this.inspectionHeatNumber.Size = new System.Drawing.Size(73, 20);
            this.inspectionHeatNumber.TabIndex = 29;
            // 
            // weightLabel
            // 
            this.weightLabel.Location = new System.Drawing.Point(10, 143);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(52, 13);
            this.weightLabel.TabIndex = 23;
            this.weightLabel.Text = "Weight, kg";
            // 
            // millWeight
            // 
            this.millWeight.Location = new System.Drawing.Point(221, 140);
            this.millWeight.Name = "millWeight";
            this.millWeight.Properties.ReadOnly = true;
            this.millWeight.Size = new System.Drawing.Size(73, 20);
            this.millWeight.TabIndex = 15;
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.Location = new System.Drawing.Point(10, 82);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(61, 13);
            this.thicknessLabel.TabIndex = 22;
            this.thicknessLabel.Text = "Thickness, m";
            // 
            // inspectionThickness
            // 
            this.inspectionThickness.Location = new System.Drawing.Point(98, 79);
            this.inspectionThickness.Name = "inspectionThickness";
            this.inspectionThickness.Size = new System.Drawing.Size(73, 20);
            this.inspectionThickness.TabIndex = 17;
            // 
            // millThickness
            // 
            this.millThickness.Location = new System.Drawing.Point(221, 79);
            this.millThickness.Name = "millThickness";
            this.millThickness.Properties.ReadOnly = true;
            this.millThickness.Size = new System.Drawing.Size(73, 20);
            this.millThickness.TabIndex = 14;
            // 
            // lengthLabel
            // 
            this.lengthLabel.Location = new System.Drawing.Point(10, 50);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(48, 13);
            this.lengthLabel.TabIndex = 21;
            this.lengthLabel.Text = "Length, m";
            // 
            // millLength
            // 
            this.millLength.Location = new System.Drawing.Point(221, 47);
            this.millLength.Name = "millLength";
            this.millLength.Properties.ReadOnly = true;
            this.millLength.Size = new System.Drawing.Size(73, 20);
            this.millLength.TabIndex = 13;
            // 
            // inspectionGeometricParamLabel
            // 
            this.inspectionGeometricParamLabel.Location = new System.Drawing.Point(98, 24);
            this.inspectionGeometricParamLabel.Name = "inspectionGeometricParamLabel";
            this.inspectionGeometricParamLabel.Size = new System.Drawing.Size(102, 13);
            this.inspectionGeometricParamLabel.TabIndex = 20;
            this.inspectionGeometricParamLabel.Text = "Incomming inspection";
            // 
            // inspectionWeight
            // 
            this.inspectionWeight.Location = new System.Drawing.Point(98, 140);
            this.inspectionWeight.Name = "inspectionWeight";
            this.inspectionWeight.Size = new System.Drawing.Size(73, 20);
            this.inspectionWeight.TabIndex = 18;
            // 
            // inspectionLength
            // 
            this.inspectionLength.Location = new System.Drawing.Point(98, 47);
            this.inspectionLength.Name = "inspectionLength";
            this.inspectionLength.Size = new System.Drawing.Size(73, 20);
            this.inspectionLength.TabIndex = 16;
            // 
            // InspectionPipeSearchEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.pipeParameters);
            this.Controls.Add(this.unloadedDate);
            this.Controls.Add(this.unloadedDateLabel);
            this.Controls.Add(this.inspection);
            this.Controls.Add(this.certificateNumber);
            this.Controls.Add(this.certificateNumberLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pipeNumber);
            this.Controls.Add(this.pipeNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InspectionPipeSearchEditXtraForm";
            this.Text = "Inspection - Find or Edit pipe";
            ((System.ComponentModel.ISupportInitialize)(this.unloadedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unloadedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspection)).EndInit();
            this.inspection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeParameters)).EndInit();
            this.pipeParameters.ResumeLayout(false);
            this.pipeParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.millHeatNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDiameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millDiameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHeatNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionLength.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit unloadedDate;
        private DevExpress.XtraEditors.LabelControl unloadedDateLabel;
        private DevExpress.XtraEditors.GroupControl inspection;
        private DevExpress.XtraEditors.TextEdit holdReason;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraEditors.LabelControl certificateNumberLabel;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.ComboBoxEdit pipeNumber;
        private DevExpress.XtraEditors.LabelControl pipeNumberLabel;
        private DevExpress.XtraEditors.GroupControl pipeParameters;
        private DevExpress.XtraEditors.TextEdit millHeatNumber;
        private DevExpress.XtraEditors.TextEdit inspectionDiameter;
        private DevExpress.XtraEditors.TextEdit millDiameter;
        private DevExpress.XtraEditors.LabelControl diameterLabel;
        private DevExpress.XtraEditors.LabelControl millGeometricParamLabel;
        private DevExpress.XtraEditors.LabelControl heatNumberLbel;
        private DevExpress.XtraEditors.TextEdit inspectionHeatNumber;
        private DevExpress.XtraEditors.LabelControl weightLabel;
        private DevExpress.XtraEditors.TextEdit millWeight;
        private DevExpress.XtraEditors.LabelControl thicknessLabel;
        private DevExpress.XtraEditors.TextEdit inspectionThickness;
        private DevExpress.XtraEditors.TextEdit millThickness;
        private DevExpress.XtraEditors.LabelControl lengthLabel;
        private DevExpress.XtraEditors.TextEdit millLength;
        private DevExpress.XtraEditors.LabelControl inspectionGeometricParamLabel;
        private DevExpress.XtraEditors.TextEdit inspectionWeight;
        private DevExpress.XtraEditors.TextEdit inspectionLength;
        private DevExpress.XtraEditors.RadioGroup inspectionResult;
    }
}