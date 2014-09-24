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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlJoint)).BeginInit();
            this.TabControlJoint.SuspendLayout();
            this.TabPageGeneralParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComponentry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewJointControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipesControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtJointNo.Properties)).BeginInit();
            this.TabPageInspection.SuspendLayout();
            this.xtraTabPageTrench.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.TabPageGeneralParameters.Controls.Add(this.gridControl2);
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
            // gridControlComponentry
            // 
            this.gridControlComponentry.Location = new System.Drawing.Point(306, 110);
            this.gridControlComponentry.MainView = this.gridViewJointControl;
            this.gridControlComponentry.Name = "gridControlComponentry";
            this.gridControlComponentry.Size = new System.Drawing.Size(256, 100);
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
            this.gridControlPipes.Location = new System.Drawing.Point(12, 110);
            this.gridControlPipes.MainView = this.PipesControl;
            this.gridControlPipes.Name = "gridControlPipes";
            this.gridControlPipes.Size = new System.Drawing.Size(256, 100);
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
            this.labelControl3.Location = new System.Drawing.Point(306, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Componentry:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Pipes:";
            // 
            // txtEdtJointNo
            // 
            this.txtEdtJointNo.Location = new System.Drawing.Point(12, 31);
            this.txtEdtJointNo.Name = "txtEdtJointNo";
            this.txtEdtJointNo.Size = new System.Drawing.Size(100, 20);
            this.txtEdtJointNo.TabIndex = 1;
            // 
            // lblJointNo
            // 
            this.lblJointNo.Location = new System.Drawing.Point(12, 12);
            this.lblJointNo.Name = "lblJointNo";
            this.lblJointNo.Size = new System.Drawing.Size(62, 13);
            this.lblJointNo.TabIndex = 0;
            this.lblJointNo.Text = "Joint number";
            // 
            // TabPageInspection
            // 
            this.TabPageInspection.Controls.Add(this.gridControl1);
            this.TabPageInspection.Controls.Add(this.labelControl1);
            this.TabPageInspection.Controls.Add(this.labelControl4);
            this.TabPageInspection.Controls.Add(this.dateEdit1);
            this.TabPageInspection.Controls.Add(this.textEdit1);
            this.TabPageInspection.Name = "TabPageInspection";
            this.TabPageInspection.Size = new System.Drawing.Size(719, 397);
            this.TabPageInspection.Text = "&Inspection operations";
            // 
            // xtraTabPageTrench
            // 
            this.xtraTabPageTrench.Controls.Add(this.groupControl1);
            this.xtraTabPageTrench.Name = "xtraTabPageTrench";
            this.xtraTabPageTrench.Size = new System.Drawing.Size(719, 397);
            this.xtraTabPageTrench.Text = "&Trench parameters";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(271, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Inspection date";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Inspector";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(366, 16);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEdit1.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 15;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(82, 16);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(164, 20);
            this.textEdit1.TabIndex = 14;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(22, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(677, 232);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.dateEdit2);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.comboBoxEdit1);
            this.groupControl1.Controls.Add(this.comboBoxEdit2);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Location = new System.Drawing.Point(17, 150);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(684, 97);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Welding";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(267, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Weld date";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(267, 66);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Welder number";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(18, 70);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Welder";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(483, 32);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Status";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(18, 32);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(25, 13);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Place";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(362, 29);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEdit2.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 5;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(362, 63);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 4;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(540, 29);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(128, 20);
            this.comboBoxEdit1.TabIndex = 3;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(78, 29);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(164, 20);
            this.comboBoxEdit2.TabIndex = 2;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(78, 63);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(164, 20);
            this.textEdit3.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(12, 240);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(683, 126);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Place";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Date";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Welder";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Welder no";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Status";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComponentry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewJointControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipesControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtJointNo.Properties)).EndInit();
            this.TabPageInspection.ResumeLayout(false);
            this.TabPageInspection.PerformLayout();
            this.xtraTabPageTrench.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControlJoint;
        private DevExpress.XtraTab.XtraTabPage TabPageGeneralParameters;
        private DevExpress.XtraTab.XtraTabPage TabPageInspection;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageTrench;
        private DevExpress.XtraGrid.GridControl gridControlComponentry;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewJointControl;
        private DevExpress.XtraGrid.GridControl gridControlPipes;
        private DevExpress.XtraGrid.Views.Grid.GridView PipesControl;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEdtJointNo;
        private DevExpress.XtraEditors.LabelControl lblJointNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComponentNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPipeNo;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
    }
}