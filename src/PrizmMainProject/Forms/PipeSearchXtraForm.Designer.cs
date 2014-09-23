namespace PrizmMain.Forms
{
    partial class PipeSearchXtraForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditOuterCoating = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxSizeGrade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEditWeld = new DevExpress.XtraEditors.DateEdit();
            this.lblWeldDate = new DevExpress.XtraEditors.LabelControl();
            this.lblOuterCoating = new DevExpress.XtraEditors.LabelControl();
            this.dateEditInnerCoating = new DevExpress.XtraEditors.DateEdit();
            this.lblInnerCoating = new DevExpress.XtraEditors.LabelControl();
            this.lblSizeGrade = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtPipeLocation = new DevExpress.XtraEditors.TextEdit();
            this.lblLocation = new DevExpress.XtraEditors.LabelControl();
            this.txtEditPipeStatus = new DevExpress.XtraEditors.TextEdit();
            this.lblPipeStatus = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtPipeNo = new DevExpress.XtraEditors.TextEdit();
            this.lblPipeNo = new DevExpress.XtraEditors.LabelControl();
            this.grdControlPipesSearchReselt = new DevExpress.XtraGrid.GridControl();
            this.gridViewResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPipeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCertificate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnHeatNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnWeldDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnInnerCoatingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnOuterCoatingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditOuterCoating.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditOuterCoating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSizeGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeld.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInnerCoating.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInnerCoating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtPipeLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditPipeStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtPipeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlPipesSearchReselt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(566, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            // 
            // dateEditOuterCoating
            // 
            this.dateEditOuterCoating.EditValue = null;
            this.dateEditOuterCoating.Location = new System.Drawing.Point(346, 85);
            this.dateEditOuterCoating.Name = "dateEditOuterCoating";
            this.dateEditOuterCoating.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditOuterCoating.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditOuterCoating.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEditOuterCoating.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEditOuterCoating.Size = new System.Drawing.Size(126, 20);
            this.dateEditOuterCoating.TabIndex = 47;
            // 
            // comboBoxSizeGrade
            // 
            this.comboBoxSizeGrade.Location = new System.Drawing.Point(522, 29);
            this.comboBoxSizeGrade.Name = "comboBoxSizeGrade";
            this.comboBoxSizeGrade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxSizeGrade.Size = new System.Drawing.Size(119, 20);
            this.comboBoxSizeGrade.TabIndex = 46;
            // 
            // dateEditWeld
            // 
            this.dateEditWeld.EditValue = null;
            this.dateEditWeld.Location = new System.Drawing.Point(13, 85);
            this.dateEditWeld.Name = "dateEditWeld";
            this.dateEditWeld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditWeld.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditWeld.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEditWeld.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEditWeld.Size = new System.Drawing.Size(100, 20);
            this.dateEditWeld.TabIndex = 45;
            // 
            // lblWeldDate
            // 
            this.lblWeldDate.Location = new System.Drawing.Point(12, 66);
            this.lblWeldDate.Name = "lblWeldDate";
            this.lblWeldDate.Size = new System.Drawing.Size(49, 13);
            this.lblWeldDate.TabIndex = 44;
            this.lblWeldDate.Text = "Weld date";
            // 
            // lblOuterCoating
            // 
            this.lblOuterCoating.Location = new System.Drawing.Point(346, 66);
            this.lblOuterCoating.Name = "lblOuterCoating";
            this.lblOuterCoating.Size = new System.Drawing.Size(91, 13);
            this.lblOuterCoating.TabIndex = 43;
            this.lblOuterCoating.Text = "Outer coating date";
            // 
            // dateEditInnerCoating
            // 
            this.dateEditInnerCoating.EditValue = null;
            this.dateEditInnerCoating.Location = new System.Drawing.Point(172, 85);
            this.dateEditInnerCoating.Name = "dateEditInnerCoating";
            this.dateEditInnerCoating.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInnerCoating.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInnerCoating.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEditInnerCoating.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEditInnerCoating.Size = new System.Drawing.Size(126, 20);
            this.dateEditInnerCoating.TabIndex = 42;
            // 
            // lblInnerCoating
            // 
            this.lblInnerCoating.Location = new System.Drawing.Point(172, 66);
            this.lblInnerCoating.Name = "lblInnerCoating";
            this.lblInnerCoating.Size = new System.Drawing.Size(89, 13);
            this.lblInnerCoating.TabIndex = 41;
            this.lblInnerCoating.Text = "Inner coating date";
            // 
            // lblSizeGrade
            // 
            this.lblSizeGrade.Location = new System.Drawing.Point(522, 10);
            this.lblSizeGrade.Name = "lblSizeGrade";
            this.lblSizeGrade.Size = new System.Drawing.Size(50, 13);
            this.lblSizeGrade.TabIndex = 40;
            this.lblSizeGrade.Text = "Size grade";
            // 
            // txtEdtPipeLocation
            // 
            this.txtEdtPipeLocation.Location = new System.Drawing.Point(345, 29);
            this.txtEdtPipeLocation.Name = "txtEdtPipeLocation";
            this.txtEdtPipeLocation.Size = new System.Drawing.Size(110, 20);
            this.txtEdtPipeLocation.TabIndex = 39;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(345, 10);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(40, 13);
            this.lblLocation.TabIndex = 38;
            this.lblLocation.Text = "Location";
            // 
            // txtEditPipeStatus
            // 
            this.txtEditPipeStatus.Location = new System.Drawing.Point(171, 29);
            this.txtEditPipeStatus.Name = "txtEditPipeStatus";
            this.txtEditPipeStatus.Size = new System.Drawing.Size(102, 20);
            this.txtEditPipeStatus.TabIndex = 37;
            // 
            // lblPipeStatus
            // 
            this.lblPipeStatus.Location = new System.Drawing.Point(171, 10);
            this.lblPipeStatus.Name = "lblPipeStatus";
            this.lblPipeStatus.Size = new System.Drawing.Size(31, 13);
            this.lblPipeStatus.TabIndex = 36;
            this.lblPipeStatus.Text = "Status";
            // 
            // txtEdtPipeNo
            // 
            this.txtEdtPipeNo.Location = new System.Drawing.Point(11, 29);
            this.txtEdtPipeNo.Name = "txtEdtPipeNo";
            this.txtEdtPipeNo.Size = new System.Drawing.Size(99, 20);
            this.txtEdtPipeNo.TabIndex = 35;
            // 
            // lblPipeNo
            // 
            this.lblPipeNo.Location = new System.Drawing.Point(11, 10);
            this.lblPipeNo.Name = "lblPipeNo";
            this.lblPipeNo.Size = new System.Drawing.Size(35, 13);
            this.lblPipeNo.TabIndex = 34;
            this.lblPipeNo.Text = "Pipe no";
            // 
            // grdControlPipesSearchReselt
            // 
            this.grdControlPipesSearchReselt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdControlPipesSearchReselt.Location = new System.Drawing.Point(11, 121);
            this.grdControlPipesSearchReselt.MainView = this.gridViewResult;
            this.grdControlPipesSearchReselt.Name = "grdControlPipesSearchReselt";
            this.grdControlPipesSearchReselt.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.grdControlPipesSearchReselt.Size = new System.Drawing.Size(702, 293);
            this.grdControlPipesSearchReselt.TabIndex = 33;
            this.grdControlPipesSearchReselt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResult});
            // 
            // gridViewResult
            // 
            this.gridViewResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPipeNo,
            this.gridColumnCertificate,
            this.gridColumnHeatNo,
            this.gridColumnStatus,
            this.gridColumnLocation,
            this.gridColumnWeldDate,
            this.gridColumnInnerCoatingDate,
            this.gridColumnOuterCoatingDate,
            this.gridColumnExtra});
            this.gridViewResult.GridControl = this.grdControlPipesSearchReselt;
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnPipeNo
            // 
            this.gridColumnPipeNo.Caption = "Pipe no";
            this.gridColumnPipeNo.Name = "gridColumnPipeNo";
            this.gridColumnPipeNo.Visible = true;
            this.gridColumnPipeNo.VisibleIndex = 0;
            // 
            // gridColumnCertificate
            // 
            this.gridColumnCertificate.Caption = "Certificate no";
            this.gridColumnCertificate.Name = "gridColumnCertificate";
            this.gridColumnCertificate.Visible = true;
            this.gridColumnCertificate.VisibleIndex = 1;
            // 
            // gridColumnHeatNo
            // 
            this.gridColumnHeatNo.Caption = "Heat no";
            this.gridColumnHeatNo.Name = "gridColumnHeatNo";
            this.gridColumnHeatNo.Visible = true;
            this.gridColumnHeatNo.VisibleIndex = 2;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.VisibleIndex = 3;
            // 
            // gridColumnLocation
            // 
            this.gridColumnLocation.Caption = "Location";
            this.gridColumnLocation.Name = "gridColumnLocation";
            this.gridColumnLocation.Visible = true;
            this.gridColumnLocation.VisibleIndex = 4;
            // 
            // gridColumnWeldDate
            // 
            this.gridColumnWeldDate.Caption = "Weld date";
            this.gridColumnWeldDate.Name = "gridColumnWeldDate";
            this.gridColumnWeldDate.Visible = true;
            this.gridColumnWeldDate.VisibleIndex = 5;
            // 
            // gridColumnInnerCoatingDate
            // 
            this.gridColumnInnerCoatingDate.Caption = "Inner coating date";
            this.gridColumnInnerCoatingDate.Name = "gridColumnInnerCoatingDate";
            this.gridColumnInnerCoatingDate.Visible = true;
            this.gridColumnInnerCoatingDate.VisibleIndex = 6;
            // 
            // gridColumnOuterCoatingDate
            // 
            this.gridColumnOuterCoatingDate.Caption = "Outer coating date";
            this.gridColumnOuterCoatingDate.Name = "gridColumnOuterCoatingDate";
            this.gridColumnOuterCoatingDate.Visible = true;
            this.gridColumnOuterCoatingDate.VisibleIndex = 7;
            // 
            // gridColumnExtra
            // 
            this.gridColumnExtra.Caption = "Extra";
            this.gridColumnExtra.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumnExtra.Name = "gridColumnExtra";
            this.gridColumnExtra.Visible = true;
            this.gridColumnExtra.VisibleIndex = 8;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "extra inf", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // PipeSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateEditOuterCoating);
            this.Controls.Add(this.comboBoxSizeGrade);
            this.Controls.Add(this.dateEditWeld);
            this.Controls.Add(this.lblWeldDate);
            this.Controls.Add(this.lblOuterCoating);
            this.Controls.Add(this.dateEditInnerCoating);
            this.Controls.Add(this.lblInnerCoating);
            this.Controls.Add(this.lblSizeGrade);
            this.Controls.Add(this.txtEdtPipeLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtEditPipeStatus);
            this.Controls.Add(this.lblPipeStatus);
            this.Controls.Add(this.txtEdtPipeNo);
            this.Controls.Add(this.lblPipeNo);
            this.Controls.Add(this.grdControlPipesSearchReselt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PipeSearchXtraForm";
            this.Text = "PipeSearchXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.dateEditOuterCoating.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditOuterCoating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSizeGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeld.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInnerCoating.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInnerCoating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtPipeLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditPipeStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtPipeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlPipesSearchReselt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit dateEditOuterCoating;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxSizeGrade;
        private DevExpress.XtraEditors.DateEdit dateEditWeld;
        private DevExpress.XtraEditors.LabelControl lblWeldDate;
        private DevExpress.XtraEditors.LabelControl lblOuterCoating;
        private DevExpress.XtraEditors.DateEdit dateEditInnerCoating;
        private DevExpress.XtraEditors.LabelControl lblInnerCoating;
        private DevExpress.XtraEditors.LabelControl lblSizeGrade;
        private DevExpress.XtraEditors.TextEdit txtEdtPipeLocation;
        private DevExpress.XtraEditors.LabelControl lblLocation;
        private DevExpress.XtraEditors.TextEdit txtEditPipeStatus;
        private DevExpress.XtraEditors.LabelControl lblPipeStatus;
        private DevExpress.XtraEditors.TextEdit txtEdtPipeNo;
        private DevExpress.XtraEditors.LabelControl lblPipeNo;
        private DevExpress.XtraGrid.GridControl grdControlPipesSearchReselt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResult;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPipeNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCertificate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnHeatNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLocation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnWeldDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnInnerCoatingDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnOuterCoatingDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnExtra;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;


    }
}