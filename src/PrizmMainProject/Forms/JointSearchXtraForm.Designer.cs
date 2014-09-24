namespace PrizmMain.Forms
{
    partial class JointSearchXtraForm
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
            this.lblGPS = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtMinutes = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtGPSdegrees = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtGPSseconds = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditControl = new DevExpress.XtraEditors.DateEdit();
            this.lblControlDate = new DevExpress.XtraEditors.LabelControl();
            this.dateEditWeld = new DevExpress.XtraEditors.DateEdit();
            this.lblWeldDate = new DevExpress.XtraEditors.LabelControl();
            this.lblControlState = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxControlState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtJointNo = new DevExpress.XtraEditors.TextEdit();
            this.lblJointNo = new DevExpress.XtraEditors.LabelControl();
            this.gridControlSerchResult = new DevExpress.XtraGrid.GridControl();
            this.gridViewResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnJointNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnJoinStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnWeldDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRepair = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnControlState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnControlDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExtraJoint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMinutes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtGPSdegrees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtGPSseconds.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditControl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeld.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxControlState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtJointNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExtraJoint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGPS
            // 
            this.lblGPS.Location = new System.Drawing.Point(240, 57);
            this.lblGPS.Name = "lblGPS";
            this.lblGPS.Size = new System.Drawing.Size(19, 13);
            this.lblGPS.TabIndex = 48;
            this.lblGPS.Text = "GPS";
            // 
            // txtEdtMinutes
            // 
            this.txtEdtMinutes.Location = new System.Drawing.Point(293, 78);
            this.txtEdtMinutes.Name = "txtEdtMinutes";
            this.txtEdtMinutes.Size = new System.Drawing.Size(47, 20);
            this.txtEdtMinutes.TabIndex = 47;
            // 
            // txtEdtGPSdegrees
            // 
            this.txtEdtGPSdegrees.Location = new System.Drawing.Point(240, 78);
            this.txtEdtGPSdegrees.Name = "txtEdtGPSdegrees";
            this.txtEdtGPSdegrees.Size = new System.Drawing.Size(47, 20);
            this.txtEdtGPSdegrees.TabIndex = 46;
            // 
            // txtEdtGPSseconds
            // 
            this.txtEdtGPSseconds.Location = new System.Drawing.Point(346, 78);
            this.txtEdtGPSseconds.Name = "txtEdtGPSseconds";
            this.txtEdtGPSseconds.Size = new System.Drawing.Size(47, 20);
            this.txtEdtGPSseconds.TabIndex = 45;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(636, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search";
            // 
            // dateEditControl
            // 
            this.dateEditControl.EditValue = null;
            this.dateEditControl.Location = new System.Drawing.Point(591, 29);
            this.dateEditControl.Name = "dateEditControl";
            this.dateEditControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditControl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditControl.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEditControl.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEditControl.Size = new System.Drawing.Size(120, 20);
            this.dateEditControl.TabIndex = 43;
            // 
            // lblControlDate
            // 
            this.lblControlDate.Location = new System.Drawing.Point(591, 6);
            this.lblControlDate.Name = "lblControlDate";
            this.lblControlDate.Size = new System.Drawing.Size(60, 13);
            this.lblControlDate.TabIndex = 42;
            this.lblControlDate.Text = "Control date";
            // 
            // dateEditWeld
            // 
            this.dateEditWeld.EditValue = null;
            this.dateEditWeld.Location = new System.Drawing.Point(10, 78);
            this.dateEditWeld.Name = "dateEditWeld";
            this.dateEditWeld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditWeld.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditWeld.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEditWeld.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEditWeld.Size = new System.Drawing.Size(120, 20);
            this.dateEditWeld.TabIndex = 41;
            // 
            // lblWeldDate
            // 
            this.lblWeldDate.Location = new System.Drawing.Point(10, 57);
            this.lblWeldDate.Name = "lblWeldDate";
            this.lblWeldDate.Size = new System.Drawing.Size(49, 13);
            this.lblWeldDate.TabIndex = 40;
            this.lblWeldDate.Text = "Weld date";
            // 
            // lblControlState
            // 
            this.lblControlState.Location = new System.Drawing.Point(396, 8);
            this.lblControlState.Name = "lblControlState";
            this.lblControlState.Size = new System.Drawing.Size(63, 13);
            this.lblControlState.TabIndex = 39;
            this.lblControlState.Text = "Control state";
            // 
            // comboBoxControlState
            // 
            this.comboBoxControlState.Location = new System.Drawing.Point(396, 31);
            this.comboBoxControlState.Name = "comboBoxControlState";
            this.comboBoxControlState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxControlState.Size = new System.Drawing.Size(125, 20);
            this.comboBoxControlState.TabIndex = 38;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Location = new System.Drawing.Point(221, 28);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxStatus.Size = new System.Drawing.Size(108, 20);
            this.comboBoxStatus.TabIndex = 37;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(221, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(31, 13);
            this.lblStatus.TabIndex = 36;
            this.lblStatus.Text = "Status";
            // 
            // txtEdtJointNo
            // 
            this.txtEdtJointNo.Location = new System.Drawing.Point(10, 28);
            this.txtEdtJointNo.Name = "txtEdtJointNo";
            this.txtEdtJointNo.Size = new System.Drawing.Size(119, 20);
            this.txtEdtJointNo.TabIndex = 35;
            // 
            // lblJointNo
            // 
            this.lblJointNo.Location = new System.Drawing.Point(10, 9);
            this.lblJointNo.Name = "lblJointNo";
            this.lblJointNo.Size = new System.Drawing.Size(62, 13);
            this.lblJointNo.TabIndex = 34;
            this.lblJointNo.Text = "Joint number";
            // 
            // gridControlSerchResult
            // 
            this.gridControlSerchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSerchResult.Location = new System.Drawing.Point(10, 108);
            this.gridControlSerchResult.MainView = this.gridViewResult;
            this.gridControlSerchResult.Name = "gridControlSerchResult";
            this.gridControlSerchResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnExtraJoint});
            this.gridControlSerchResult.Size = new System.Drawing.Size(703, 305);
            this.gridControlSerchResult.TabIndex = 33;
            this.gridControlSerchResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResult});
            // 
            // gridViewResult
            // 
            this.gridViewResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnJointNo,
            this.gridColumnJoinStatus,
            this.gridColumnWeldDate,
            this.gridColumnRepair,
            this.gridColumnControlState,
            this.gridColumnControlDate,
            this.gridColumnExtra});
            this.gridViewResult.GridControl = this.gridControlSerchResult;
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnJointNo
            // 
            this.gridColumnJointNo.Caption = "Joint no";
            this.gridColumnJointNo.Name = "gridColumnJointNo";
            this.gridColumnJointNo.Visible = true;
            this.gridColumnJointNo.VisibleIndex = 0;
            // 
            // gridColumnJoinStatus
            // 
            this.gridColumnJoinStatus.Caption = "Status";
            this.gridColumnJoinStatus.Name = "gridColumnJoinStatus";
            this.gridColumnJoinStatus.Visible = true;
            this.gridColumnJoinStatus.VisibleIndex = 1;
            // 
            // gridColumnWeldDate
            // 
            this.gridColumnWeldDate.Caption = "Weld Date";
            this.gridColumnWeldDate.Name = "gridColumnWeldDate";
            this.gridColumnWeldDate.Visible = true;
            this.gridColumnWeldDate.VisibleIndex = 3;
            // 
            // gridColumnRepair
            // 
            this.gridColumnRepair.Caption = "Repair";
            this.gridColumnRepair.Name = "gridColumnRepair";
            this.gridColumnRepair.Visible = true;
            this.gridColumnRepair.VisibleIndex = 4;
            // 
            // gridColumnControlState
            // 
            this.gridColumnControlState.Caption = "Control State";
            this.gridColumnControlState.Name = "gridColumnControlState";
            this.gridColumnControlState.Visible = true;
            this.gridColumnControlState.VisibleIndex = 2;
            // 
            // gridColumnControlDate
            // 
            this.gridColumnControlDate.Caption = "Control Date";
            this.gridColumnControlDate.Name = "gridColumnControlDate";
            this.gridColumnControlDate.Visible = true;
            this.gridColumnControlDate.VisibleIndex = 5;
            // 
            // gridColumnExtra
            // 
            this.gridColumnExtra.Caption = "Extra";
            this.gridColumnExtra.ColumnEdit = this.btnExtraJoint;
            this.gridColumnExtra.Name = "gridColumnExtra";
            this.gridColumnExtra.Visible = true;
            this.gridColumnExtra.VisibleIndex = 6;
            // 
            // btnExtraJoint
            // 
            this.btnExtraJoint.AutoHeight = false;
            this.btnExtraJoint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnExtraJoint.Name = "btnExtraJoint";
            this.btnExtraJoint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // JointSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.ControlBox = false;
            this.Controls.Add(this.lblGPS);
            this.Controls.Add(this.txtEdtMinutes);
            this.Controls.Add(this.txtEdtGPSdegrees);
            this.Controls.Add(this.txtEdtGPSseconds);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateEditControl);
            this.Controls.Add(this.lblControlDate);
            this.Controls.Add(this.dateEditWeld);
            this.Controls.Add(this.lblWeldDate);
            this.Controls.Add(this.lblControlState);
            this.Controls.Add(this.comboBoxControlState);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtEdtJointNo);
            this.Controls.Add(this.lblJointNo);
            this.Controls.Add(this.gridControlSerchResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JointSearchXtraForm";
            this.Text = "JointSearchXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMinutes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtGPSdegrees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtGPSseconds.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditControl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeld.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxControlState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtJointNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExtraJoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblGPS;
        private DevExpress.XtraEditors.TextEdit txtEdtMinutes;
        private DevExpress.XtraEditors.TextEdit txtEdtGPSdegrees;
        private DevExpress.XtraEditors.TextEdit txtEdtGPSseconds;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit dateEditControl;
        private DevExpress.XtraEditors.LabelControl lblControlDate;
        private DevExpress.XtraEditors.DateEdit dateEditWeld;
        private DevExpress.XtraEditors.LabelControl lblWeldDate;
        private DevExpress.XtraEditors.LabelControl lblControlState;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxControlState;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxStatus;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.TextEdit txtEdtJointNo;
        private DevExpress.XtraEditors.LabelControl lblJointNo;
        private DevExpress.XtraGrid.GridControl gridControlSerchResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResult;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnJointNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnJoinStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnWeldDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRepair;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnControlState;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnControlDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnExtra;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnExtraJoint;

    }
}