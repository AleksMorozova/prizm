namespace PrizmMain.Forms
{
    partial class JointNewEditXtraForm
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
            this.TabControlJoint = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageGeneralParameters = new DevExpress.XtraTab.XtraTabPage();
            this.groupControlWeldig = new DevExpress.XtraEditors.GroupControl();
            this.lblInspectionDate = new DevExpress.XtraEditors.LabelControl();
            this.lblWeldinfDate = new DevExpress.XtraEditors.LabelControl();
            this.lblWelderNo = new DevExpress.XtraEditors.LabelControl();
            this.lblInspector = new DevExpress.XtraEditors.LabelControl();
            this.lblWelder = new DevExpress.XtraEditors.LabelControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.lblPlace = new DevExpress.XtraEditors.LabelControl();
            this.dateEditInspection = new DevExpress.XtraEditors.DateEdit();
            this.dateEditWelding = new DevExpress.XtraEditors.DateEdit();
            this.txtEditWelderNo = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditPlace = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtEdtInspector = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtWelder = new DevExpress.XtraEditors.TextEdit();
            this.gridControlComponentry = new DevExpress.XtraGrid.GridControl();
            this.gridViewJointControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnComponentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlPipes = new DevExpress.XtraGrid.GridControl();
            this.PipesControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPipeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtJointNo = new DevExpress.XtraEditors.TextEdit();
            this.lblJointNo = new DevExpress.XtraEditors.LabelControl();
            this.TabPageInspection = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageTrench = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlJoint)).BeginInit();
            this.TabControlJoint.SuspendLayout();
            this.TabPageGeneralParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlWeldig)).BeginInit();
            this.groupControlWeldig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInspection.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInspection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWelding.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWelding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditWelderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtInspector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtWelder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComponentry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewJointControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipesControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtJointNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlJoint
            // 
            this.TabControlJoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlJoint.Location = new System.Drawing.Point(0, 0);
            this.TabControlJoint.Name = "TabControlJoint";
            this.TabControlJoint.SelectedTabPage = this.TabPageGeneralParameters;
            this.TabControlJoint.Size = new System.Drawing.Size(725, 425);
            this.TabControlJoint.TabIndex = 0;
            this.TabControlJoint.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageGeneralParameters,
            this.TabPageInspection,
            this.xtraTabPageTrench});
            // 
            // TabPageGeneralParameters
            // 
            this.TabPageGeneralParameters.Controls.Add(this.groupControlWeldig);
            this.TabPageGeneralParameters.Controls.Add(this.gridControlComponentry);
            this.TabPageGeneralParameters.Controls.Add(this.gridControlPipes);
            this.TabPageGeneralParameters.Controls.Add(this.labelControl3);
            this.TabPageGeneralParameters.Controls.Add(this.labelControl2);
            this.TabPageGeneralParameters.Controls.Add(this.txtEdtJointNo);
            this.TabPageGeneralParameters.Controls.Add(this.lblJointNo);
            this.TabPageGeneralParameters.Name = "TabPageGeneralParameters";
            this.TabPageGeneralParameters.Size = new System.Drawing.Size(719, 397);
            this.TabPageGeneralParameters.Text = "&General parameters";
            // 
            // groupControlWeldig
            // 
            this.groupControlWeldig.Controls.Add(this.lblInspectionDate);
            this.groupControlWeldig.Controls.Add(this.lblWeldinfDate);
            this.groupControlWeldig.Controls.Add(this.lblWelderNo);
            this.groupControlWeldig.Controls.Add(this.lblInspector);
            this.groupControlWeldig.Controls.Add(this.lblWelder);
            this.groupControlWeldig.Controls.Add(this.lblStatus);
            this.groupControlWeldig.Controls.Add(this.lblPlace);
            this.groupControlWeldig.Controls.Add(this.dateEditInspection);
            this.groupControlWeldig.Controls.Add(this.dateEditWelding);
            this.groupControlWeldig.Controls.Add(this.txtEditWelderNo);
            this.groupControlWeldig.Controls.Add(this.comboBoxStatus);
            this.groupControlWeldig.Controls.Add(this.comboBoxEditPlace);
            this.groupControlWeldig.Controls.Add(this.txtEdtInspector);
            this.groupControlWeldig.Controls.Add(this.txtEdtWelder);
            this.groupControlWeldig.Location = new System.Drawing.Point(11, 253);
            this.groupControlWeldig.Name = "groupControlWeldig";
            this.groupControlWeldig.Size = new System.Drawing.Size(684, 127);
            this.groupControlWeldig.TabIndex = 6;
            this.groupControlWeldig.Text = "Welding";
            // 
            // lblInspectionDate
            // 
            this.lblInspectionDate.Location = new System.Drawing.Point(267, 101);
            this.lblInspectionDate.Name = "lblInspectionDate";
            this.lblInspectionDate.Size = new System.Drawing.Size(75, 13);
            this.lblInspectionDate.TabIndex = 13;
            this.lblInspectionDate.Text = "Inspection date";
            // 
            // lblWeldinfDate
            // 
            this.lblWeldinfDate.Location = new System.Drawing.Point(267, 32);
            this.lblWeldinfDate.Name = "lblWeldinfDate";
            this.lblWeldinfDate.Size = new System.Drawing.Size(63, 13);
            this.lblWeldinfDate.TabIndex = 12;
            this.lblWeldinfDate.Text = "Welding date";
            // 
            // lblWelderNo
            // 
            this.lblWelderNo.Location = new System.Drawing.Point(267, 66);
            this.lblWelderNo.Name = "lblWelderNo";
            this.lblWelderNo.Size = new System.Drawing.Size(73, 13);
            this.lblWelderNo.TabIndex = 11;
            this.lblWelderNo.Text = "Welder number";
            // 
            // lblInspector
            // 
            this.lblInspector.Location = new System.Drawing.Point(18, 101);
            this.lblInspector.Name = "lblInspector";
            this.lblInspector.Size = new System.Drawing.Size(46, 13);
            this.lblInspector.TabIndex = 10;
            this.lblInspector.Text = "Inspector";
            // 
            // lblWelder
            // 
            this.lblWelder.Location = new System.Drawing.Point(18, 70);
            this.lblWelder.Name = "lblWelder";
            this.lblWelder.Size = new System.Drawing.Size(34, 13);
            this.lblWelder.TabIndex = 9;
            this.lblWelder.Text = "Welder";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(483, 32);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(31, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // lblPlace
            // 
            this.lblPlace.Location = new System.Drawing.Point(18, 32);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(25, 13);
            this.lblPlace.TabIndex = 7;
            this.lblPlace.Text = "Place";
            // 
            // dateEditInspection
            // 
            this.dateEditInspection.EditValue = null;
            this.dateEditInspection.Location = new System.Drawing.Point(362, 98);
            this.dateEditInspection.Name = "dateEditInspection";
            this.dateEditInspection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInspection.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInspection.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEditInspection.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEditInspection.Size = new System.Drawing.Size(100, 20);
            this.dateEditInspection.TabIndex = 6;
            // 
            // dateEditWelding
            // 
            this.dateEditWelding.EditValue = null;
            this.dateEditWelding.Location = new System.Drawing.Point(362, 29);
            this.dateEditWelding.Name = "dateEditWelding";
            this.dateEditWelding.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditWelding.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditWelding.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEditWelding.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEditWelding.Size = new System.Drawing.Size(100, 20);
            this.dateEditWelding.TabIndex = 5;
            // 
            // txtEditWelderNo
            // 
            this.txtEditWelderNo.Location = new System.Drawing.Point(362, 63);
            this.txtEditWelderNo.Name = "txtEditWelderNo";
            this.txtEditWelderNo.Size = new System.Drawing.Size(100, 20);
            this.txtEditWelderNo.TabIndex = 4;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Location = new System.Drawing.Point(540, 29);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxStatus.Size = new System.Drawing.Size(128, 20);
            this.comboBoxStatus.TabIndex = 3;
            // 
            // comboBoxEditPlace
            // 
            this.comboBoxEditPlace.Location = new System.Drawing.Point(78, 29);
            this.comboBoxEditPlace.Name = "comboBoxEditPlace";
            this.comboBoxEditPlace.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPlace.Size = new System.Drawing.Size(164, 20);
            this.comboBoxEditPlace.TabIndex = 2;
            // 
            // txtEdtInspector
            // 
            this.txtEdtInspector.Location = new System.Drawing.Point(78, 98);
            this.txtEdtInspector.Name = "txtEdtInspector";
            this.txtEdtInspector.Size = new System.Drawing.Size(164, 20);
            this.txtEdtInspector.TabIndex = 1;
            // 
            // txtEdtWelder
            // 
            this.txtEdtWelder.Location = new System.Drawing.Point(78, 63);
            this.txtEdtWelder.Name = "txtEdtWelder";
            this.txtEdtWelder.Size = new System.Drawing.Size(164, 20);
            this.txtEdtWelder.TabIndex = 0;
            // 
            // gridControlComponentry
            // 
            this.gridControlComponentry.Location = new System.Drawing.Point(345, 69);
            this.gridControlComponentry.MainView = this.gridViewJointControl;
            this.gridControlComponentry.Name = "gridControlComponentry";
            this.gridControlComponentry.Size = new System.Drawing.Size(293, 154);
            this.gridControlComponentry.TabIndex = 5;
            this.gridControlComponentry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewJointControl});
            // 
            // gridViewJointControl
            // 
            this.gridViewJointControl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnComponentNo});
            this.gridViewJointControl.GridControl = this.gridControlComponentry;
            this.gridViewJointControl.Name = "gridViewJointControl";
            this.gridViewJointControl.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnComponentNo
            // 
            this.gridColumnComponentNo.Caption = "Component no";
            this.gridColumnComponentNo.Name = "gridColumnComponentNo";
            this.gridColumnComponentNo.Visible = true;
            this.gridColumnComponentNo.VisibleIndex = 0;
            // 
            // gridControlPipes
            // 
            this.gridControlPipes.Location = new System.Drawing.Point(11, 69);
            this.gridControlPipes.MainView = this.PipesControl;
            this.gridControlPipes.Name = "gridControlPipes";
            this.gridControlPipes.Size = new System.Drawing.Size(293, 154);
            this.gridControlPipes.TabIndex = 4;
            this.gridControlPipes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PipesControl});
            // 
            // PipesControl
            // 
            this.PipesControl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPipeNo});
            this.PipesControl.GridControl = this.gridControlPipes;
            this.PipesControl.Name = "PipesControl";
            this.PipesControl.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnPipeNo
            // 
            this.gridColumnPipeNo.Caption = "Pipe no";
            this.gridColumnPipeNo.Name = "gridColumnPipeNo";
            this.gridColumnPipeNo.Visible = true;
            this.gridColumnPipeNo.VisibleIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(345, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Componentry:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Pipes:";
            // 
            // txtEdtJointNo
            // 
            this.txtEdtJointNo.Location = new System.Drawing.Point(96, 15);
            this.txtEdtJointNo.Name = "txtEdtJointNo";
            this.txtEdtJointNo.Size = new System.Drawing.Size(100, 20);
            this.txtEdtJointNo.TabIndex = 1;
            // 
            // lblJointNo
            // 
            this.lblJointNo.Location = new System.Drawing.Point(18, 18);
            this.lblJointNo.Name = "lblJointNo";
            this.lblJointNo.Size = new System.Drawing.Size(62, 13);
            this.lblJointNo.TabIndex = 0;
            this.lblJointNo.Text = "Joint number";
            // 
            // TabPageInspection
            // 
            this.TabPageInspection.Name = "TabPageInspection";
            this.TabPageInspection.Size = new System.Drawing.Size(719, 397);
            this.TabPageInspection.Text = "&Inspection operations";
            // 
            // xtraTabPageTrench
            // 
            this.xtraTabPageTrench.Name = "xtraTabPageTrench";
            this.xtraTabPageTrench.Size = new System.Drawing.Size(719, 397);
            this.xtraTabPageTrench.Text = "&Trench parameters";
            // 
            // JointNewEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.ControlBox = false;
            this.Controls.Add(this.TabControlJoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JointNewEditXtraForm";
            this.ShowIcon = false;
            this.Text = "JointNewEditXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.TabControlJoint)).EndInit();
            this.TabControlJoint.ResumeLayout(false);
            this.TabPageGeneralParameters.ResumeLayout(false);
            this.TabPageGeneralParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlWeldig)).EndInit();
            this.groupControlWeldig.ResumeLayout(false);
            this.groupControlWeldig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInspection.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInspection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWelding.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWelding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditWelderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtInspector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtWelder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComponentry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewJointControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipesControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtJointNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControlJoint;
        private DevExpress.XtraTab.XtraTabPage TabPageGeneralParameters;
        private DevExpress.XtraTab.XtraTabPage TabPageInspection;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageTrench;
        private DevExpress.XtraEditors.GroupControl groupControlWeldig;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxStatus;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPlace;
        private DevExpress.XtraEditors.TextEdit txtEdtInspector;
        private DevExpress.XtraEditors.TextEdit txtEdtWelder;
        private DevExpress.XtraGrid.GridControl gridControlComponentry;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewJointControl;
        private DevExpress.XtraGrid.GridControl gridControlPipes;
        private DevExpress.XtraGrid.Views.Grid.GridView PipesControl;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEdtJointNo;
        private DevExpress.XtraEditors.LabelControl lblJointNo;
        private DevExpress.XtraEditors.LabelControl lblInspectionDate;
        private DevExpress.XtraEditors.LabelControl lblWeldinfDate;
        private DevExpress.XtraEditors.LabelControl lblWelderNo;
        private DevExpress.XtraEditors.LabelControl lblInspector;
        private DevExpress.XtraEditors.LabelControl lblWelder;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.LabelControl lblPlace;
        private DevExpress.XtraEditors.DateEdit dateEditInspection;
        private DevExpress.XtraEditors.DateEdit dateEditWelding;
        private DevExpress.XtraEditors.TextEdit txtEditWelderNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComponentNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPipeNo;
    }
}