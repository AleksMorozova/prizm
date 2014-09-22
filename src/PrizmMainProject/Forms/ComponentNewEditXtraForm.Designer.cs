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
            this.txtEdtComponentNo = new DevExpress.XtraEditors.TextEdit();
            this.lblComponentNo = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtCertificateNo = new DevExpress.XtraEditors.TextEdit();
            this.lblCertificateNo = new DevExpress.XtraEditors.LabelControl();
            this.gridControlParameters = new DevExpress.XtraGrid.GridControl();
            this.gridViewParameters = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDiameter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnThickness = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControlInspection = new DevExpress.XtraEditors.GroupControl();
            this.lblInspectionDate = new DevExpress.XtraEditors.LabelControl();
            this.lblInspector = new DevExpress.XtraEditors.LabelControl();
            this.lblResult = new DevExpress.XtraEditors.LabelControl();
            this.dateEditInspection = new DevExpress.XtraEditors.DateEdit();
            this.txtEdtInspector = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxResult = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtComponentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtCertificateNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInspection)).BeginInit();
            this.groupControlInspection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInspection.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInspection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtInspector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxResult.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEdtComponentNo
            // 
            this.txtEdtComponentNo.Location = new System.Drawing.Point(129, 38);
            this.txtEdtComponentNo.Name = "txtEdtComponentNo";
            this.txtEdtComponentNo.Size = new System.Drawing.Size(100, 20);
            this.txtEdtComponentNo.TabIndex = 0;
            // 
            // lblComponentNo
            // 
            this.lblComponentNo.Location = new System.Drawing.Point(26, 41);
            this.lblComponentNo.Name = "lblComponentNo";
            this.lblComponentNo.Size = new System.Drawing.Size(94, 13);
            this.lblComponentNo.TabIndex = 1;
            this.lblComponentNo.Text = "Component number";
            // 
            // txtEdtCertificateNo
            // 
            this.txtEdtCertificateNo.Location = new System.Drawing.Point(400, 38);
            this.txtEdtCertificateNo.Name = "txtEdtCertificateNo";
            this.txtEdtCertificateNo.Size = new System.Drawing.Size(100, 20);
            this.txtEdtCertificateNo.TabIndex = 2;
            // 
            // lblCertificateNo
            // 
            this.lblCertificateNo.Location = new System.Drawing.Point(288, 41);
            this.lblCertificateNo.Name = "lblCertificateNo";
            this.lblCertificateNo.Size = new System.Drawing.Size(89, 13);
            this.lblCertificateNo.TabIndex = 3;
            this.lblCertificateNo.Text = "Certificate number";
            // 
            // gridControlParameters
            // 
            this.gridControlParameters.Location = new System.Drawing.Point(26, 110);
            this.gridControlParameters.MainView = this.gridViewParameters;
            this.gridControlParameters.Name = "gridControlParameters";
            this.gridControlParameters.Size = new System.Drawing.Size(400, 129);
            this.gridControlParameters.TabIndex = 4;
            this.gridControlParameters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParameters});
            // 
            // gridViewParameters
            // 
            this.gridViewParameters.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDiameter,
            this.gridColumnThickness});
            this.gridViewParameters.GridControl = this.gridControlParameters;
            this.gridViewParameters.Name = "gridViewParameters";
            this.gridViewParameters.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnDiameter
            // 
            this.gridColumnDiameter.Caption = "Bore diameter";
            this.gridColumnDiameter.Name = "gridColumnDiameter";
            this.gridColumnDiameter.Visible = true;
            this.gridColumnDiameter.VisibleIndex = 0;
            // 
            // gridColumnThickness
            // 
            this.gridColumnThickness.Caption = "Side thickness";
            this.gridColumnThickness.Name = "gridColumnThickness";
            this.gridColumnThickness.Visible = true;
            this.gridColumnThickness.VisibleIndex = 1;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(26, 78);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(24, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type";
            // 
            // comboBoxEditType
            // 
            this.comboBoxEditType.Location = new System.Drawing.Point(129, 75);
            this.comboBoxEditType.Name = "comboBoxEditType";
            this.comboBoxEditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditType.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditType.TabIndex = 6;
            // 
            // groupControlInspection
            // 
            this.groupControlInspection.Controls.Add(this.lblInspectionDate);
            this.groupControlInspection.Controls.Add(this.lblInspector);
            this.groupControlInspection.Controls.Add(this.lblResult);
            this.groupControlInspection.Controls.Add(this.dateEditInspection);
            this.groupControlInspection.Controls.Add(this.txtEdtInspector);
            this.groupControlInspection.Controls.Add(this.comboBoxResult);
            this.groupControlInspection.Location = new System.Drawing.Point(26, 271);
            this.groupControlInspection.Name = "groupControlInspection";
            this.groupControlInspection.Size = new System.Drawing.Size(594, 100);
            this.groupControlInspection.TabIndex = 7;
            this.groupControlInspection.Text = "Inspection";
            // 
            // lblInspectionDate
            // 
            this.lblInspectionDate.Location = new System.Drawing.Point(348, 70);
            this.lblInspectionDate.Name = "lblInspectionDate";
            this.lblInspectionDate.Size = new System.Drawing.Size(75, 13);
            this.lblInspectionDate.TabIndex = 5;
            this.lblInspectionDate.Text = "Inspection date";
            // 
            // lblInspector
            // 
            this.lblInspector.Location = new System.Drawing.Point(14, 70);
            this.lblInspector.Name = "lblInspector";
            this.lblInspector.Size = new System.Drawing.Size(46, 13);
            this.lblInspector.TabIndex = 4;
            this.lblInspector.Text = "Inspector";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(14, 36);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(30, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // dateEditInspection
            // 
            this.dateEditInspection.EditValue = null;
            this.dateEditInspection.Location = new System.Drawing.Point(457, 67);
            this.dateEditInspection.Name = "dateEditInspection";
            this.dateEditInspection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInspection.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInspection.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEditInspection.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEditInspection.Size = new System.Drawing.Size(100, 20);
            this.dateEditInspection.TabIndex = 2;
            // 
            // txtEdtInspector
            // 
            this.txtEdtInspector.Location = new System.Drawing.Point(93, 67);
            this.txtEdtInspector.Name = "txtEdtInspector";
            this.txtEdtInspector.Size = new System.Drawing.Size(209, 20);
            this.txtEdtInspector.TabIndex = 1;
            // 
            // comboBoxResult
            // 
            this.comboBoxResult.Location = new System.Drawing.Point(92, 33);
            this.comboBoxResult.Name = "comboBoxResult";
            this.comboBoxResult.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxResult.Size = new System.Drawing.Size(100, 20);
            this.comboBoxResult.TabIndex = 0;
            // 
            // ComponentNewEditXtraForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 548);
            this.ControlBox = false;
            this.Controls.Add(this.groupControlInspection);
            this.Controls.Add(this.comboBoxEditType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.gridControlParameters);
            this.Controls.Add(this.lblCertificateNo);
            this.Controls.Add(this.txtEdtCertificateNo);
            this.Controls.Add(this.lblComponentNo);
            this.Controls.Add(this.txtEdtComponentNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentNewEditXtraForm";
            this.Text = "ComponentryNewEditXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtComponentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtCertificateNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInspection)).EndInit();
            this.groupControlInspection.ResumeLayout(false);
            this.groupControlInspection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInspection.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInspection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtInspector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxResult.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtEdtComponentNo;
        private DevExpress.XtraEditors.LabelControl lblComponentNo;
        private DevExpress.XtraEditors.TextEdit txtEdtCertificateNo;
        private DevExpress.XtraEditors.LabelControl lblCertificateNo;
        private DevExpress.XtraGrid.GridControl gridControlParameters;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParameters;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiameter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnThickness;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditType;
        private DevExpress.XtraEditors.GroupControl groupControlInspection;
        private DevExpress.XtraEditors.LabelControl lblInspectionDate;
        private DevExpress.XtraEditors.LabelControl lblInspector;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraEditors.DateEdit dateEditInspection;
        private DevExpress.XtraEditors.TextEdit txtEdtInspector;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxResult;
    }
}