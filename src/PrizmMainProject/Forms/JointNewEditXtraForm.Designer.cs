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
            this.joint = new DevExpress.XtraTab.XtraTabControl();
            this.generalParameters = new DevExpress.XtraTab.XtraTabPage();
            this.weldig = new DevExpress.XtraEditors.GroupControl();
            this.inspectionDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.weldingDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.welderNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.inspectorLabel = new DevExpress.XtraEditors.LabelControl();
            this.welderLabel = new DevExpress.XtraEditors.LabelControl();
            this.statusLabel = new DevExpress.XtraEditors.LabelControl();
            this.placeLabel = new DevExpress.XtraEditors.LabelControl();
            this.inspection = new DevExpress.XtraEditors.DateEdit();
            this.weldingDate = new DevExpress.XtraEditors.DateEdit();
            this.welderNumber = new DevExpress.XtraEditors.TextEdit();
            this.status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.place = new DevExpress.XtraEditors.ComboBoxEdit();
            this.inspector = new DevExpress.XtraEditors.TextEdit();
            this.welder = new DevExpress.XtraEditors.TextEdit();
            this.componentry = new DevExpress.XtraGrid.GridControl();
            this.componentryView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.componentNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipes = new DevExpress.XtraGrid.GridControl();
            this.pipesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.componentryLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipesLabel = new DevExpress.XtraEditors.LabelControl();
            this.jointNumber = new DevExpress.XtraEditors.TextEdit();
            this.jointNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.inspectionOperations = new DevExpress.XtraTab.XtraTabPage();
            this.trenchParameters = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.joint)).BeginInit();
            this.joint.SuspendLayout();
            this.generalParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weldig)).BeginInit();
            this.weldig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspection.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.place.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // joint
            // 
            this.joint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joint.Location = new System.Drawing.Point(0, 0);
            this.joint.Name = "joint";
            this.joint.SelectedTabPage = this.generalParameters;
            this.joint.Size = new System.Drawing.Size(725, 425);
            this.joint.TabIndex = 0;
            this.joint.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.generalParameters,
            this.inspectionOperations,
            this.trenchParameters});
            // 
            // generalParameters
            // 
            this.generalParameters.Controls.Add(this.weldig);
            this.generalParameters.Controls.Add(this.componentry);
            this.generalParameters.Controls.Add(this.pipes);
            this.generalParameters.Controls.Add(this.componentryLabel);
            this.generalParameters.Controls.Add(this.pipesLabel);
            this.generalParameters.Controls.Add(this.jointNumber);
            this.generalParameters.Controls.Add(this.jointNumberLabel);
            this.generalParameters.Name = "generalParameters";
            this.generalParameters.Size = new System.Drawing.Size(719, 397);
            this.generalParameters.Text = "&General parameters";
            // 
            // weldig
            // 
            this.weldig.Controls.Add(this.inspectionDateLabel);
            this.weldig.Controls.Add(this.weldingDateLabel);
            this.weldig.Controls.Add(this.welderNumberLabel);
            this.weldig.Controls.Add(this.inspectorLabel);
            this.weldig.Controls.Add(this.welderLabel);
            this.weldig.Controls.Add(this.statusLabel);
            this.weldig.Controls.Add(this.placeLabel);
            this.weldig.Controls.Add(this.inspection);
            this.weldig.Controls.Add(this.weldingDate);
            this.weldig.Controls.Add(this.welderNumber);
            this.weldig.Controls.Add(this.status);
            this.weldig.Controls.Add(this.place);
            this.weldig.Controls.Add(this.inspector);
            this.weldig.Controls.Add(this.welder);
            this.weldig.Location = new System.Drawing.Point(11, 253);
            this.weldig.Name = "weldig";
            this.weldig.Size = new System.Drawing.Size(684, 127);
            this.weldig.TabIndex = 6;
            this.weldig.Text = "Welding";
            // 
            // inspectionDateLabel
            // 
            this.inspectionDateLabel.Location = new System.Drawing.Point(267, 101);
            this.inspectionDateLabel.Name = "inspectionDateLabel";
            this.inspectionDateLabel.Size = new System.Drawing.Size(75, 13);
            this.inspectionDateLabel.TabIndex = 13;
            this.inspectionDateLabel.Text = "Inspection date";
            // 
            // weldingDateLabel
            // 
            this.weldingDateLabel.Location = new System.Drawing.Point(267, 32);
            this.weldingDateLabel.Name = "weldingDateLabel";
            this.weldingDateLabel.Size = new System.Drawing.Size(63, 13);
            this.weldingDateLabel.TabIndex = 12;
            this.weldingDateLabel.Text = "Welding date";
            // 
            // welderNumberLabel
            // 
            this.welderNumberLabel.Location = new System.Drawing.Point(267, 66);
            this.welderNumberLabel.Name = "welderNumberLabel";
            this.welderNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.welderNumberLabel.TabIndex = 11;
            this.welderNumberLabel.Text = "Welder number";
            // 
            // inspectorLabel
            // 
            this.inspectorLabel.Location = new System.Drawing.Point(18, 101);
            this.inspectorLabel.Name = "inspectorLabel";
            this.inspectorLabel.Size = new System.Drawing.Size(46, 13);
            this.inspectorLabel.TabIndex = 10;
            this.inspectorLabel.Text = "Inspector";
            // 
            // welderLabel
            // 
            this.welderLabel.Location = new System.Drawing.Point(18, 70);
            this.welderLabel.Name = "welderLabel";
            this.welderLabel.Size = new System.Drawing.Size(34, 13);
            this.welderLabel.TabIndex = 9;
            this.welderLabel.Text = "Welder";
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(483, 32);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(31, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status";
            // 
            // placeLabel
            // 
            this.placeLabel.Location = new System.Drawing.Point(18, 32);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(25, 13);
            this.placeLabel.TabIndex = 7;
            this.placeLabel.Text = "Place";
            // 
            // inspection
            // 
            this.inspection.EditValue = null;
            this.inspection.Location = new System.Drawing.Point(362, 98);
            this.inspection.Name = "inspection";
            this.inspection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspection.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspection.Size = new System.Drawing.Size(100, 20);
            this.inspection.TabIndex = 6;
            // 
            // weldingDate
            // 
            this.weldingDate.EditValue = null;
            this.weldingDate.Location = new System.Drawing.Point(362, 29);
            this.weldingDate.Name = "weldingDate";
            this.weldingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Size = new System.Drawing.Size(100, 20);
            this.weldingDate.TabIndex = 5;
            // 
            // welderNumber
            // 
            this.welderNumber.Location = new System.Drawing.Point(362, 63);
            this.welderNumber.Name = "welderNumber";
            this.welderNumber.Size = new System.Drawing.Size(100, 20);
            this.welderNumber.TabIndex = 4;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(540, 29);
            this.status.Name = "status";
            this.status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.status.Size = new System.Drawing.Size(128, 20);
            this.status.TabIndex = 3;
            // 
            // place
            // 
            this.place.Location = new System.Drawing.Point(78, 29);
            this.place.Name = "place";
            this.place.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.place.Size = new System.Drawing.Size(164, 20);
            this.place.TabIndex = 2;
            // 
            // inspector
            // 
            this.inspector.Location = new System.Drawing.Point(78, 98);
            this.inspector.Name = "inspector";
            this.inspector.Size = new System.Drawing.Size(164, 20);
            this.inspector.TabIndex = 1;
            // 
            // welder
            // 
            this.welder.Location = new System.Drawing.Point(78, 63);
            this.welder.Name = "welder";
            this.welder.Size = new System.Drawing.Size(164, 20);
            this.welder.TabIndex = 0;
            // 
            // componentry
            // 
            this.componentry.Cursor = System.Windows.Forms.Cursors.Default;
            this.componentry.Location = new System.Drawing.Point(346, 79);
            this.componentry.MainView = this.componentryView;
            this.componentry.Name = "componentry";
            this.componentry.Size = new System.Drawing.Size(293, 154);
            this.componentry.TabIndex = 5;
            this.componentry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.componentryView});
            // 
            // componentryView
            // 
            this.componentryView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.componentNumberGridColumn});
            this.componentryView.GridControl = this.componentry;
            this.componentryView.Name = "componentryView";
            this.componentryView.OptionsView.ShowGroupPanel = false;
            // 
            // componentNumberGridColumn
            // 
            this.componentNumberGridColumn.Caption = "Component number";
            this.componentNumberGridColumn.Name = "componentNumberGridColumn";
            this.componentNumberGridColumn.Visible = true;
            this.componentNumberGridColumn.VisibleIndex = 0;
            // 
            // pipes
            // 
            this.pipes.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipes.Location = new System.Drawing.Point(12, 79);
            this.pipes.MainView = this.pipesView;
            this.pipes.Name = "pipes";
            this.pipes.Size = new System.Drawing.Size(293, 154);
            this.pipes.TabIndex = 4;
            this.pipes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipesView});
            // 
            // pipesView
            // 
            this.pipesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeNumberGridColumn});
            this.pipesView.GridControl = this.pipes;
            this.pipesView.Name = "pipesView";
            this.pipesView.OptionsView.ShowGroupPanel = false;
            // 
            // pipeNumberGridColumn
            // 
            this.pipeNumberGridColumn.Caption = "Pipe number";
            this.pipeNumberGridColumn.Name = "pipeNumberGridColumn";
            this.pipeNumberGridColumn.Visible = true;
            this.pipeNumberGridColumn.VisibleIndex = 0;
            // 
            // componentryLabel
            // 
            this.componentryLabel.Location = new System.Drawing.Point(346, 60);
            this.componentryLabel.Name = "componentryLabel";
            this.componentryLabel.Size = new System.Drawing.Size(69, 13);
            this.componentryLabel.TabIndex = 3;
            this.componentryLabel.Text = "Componentry:";
            // 
            // pipesLabel
            // 
            this.pipesLabel.Location = new System.Drawing.Point(12, 60);
            this.pipesLabel.Name = "pipesLabel";
            this.pipesLabel.Size = new System.Drawing.Size(29, 13);
            this.pipesLabel.TabIndex = 2;
            this.pipesLabel.Text = "Pipes:";
            // 
            // jointNumber
            // 
            this.jointNumber.Location = new System.Drawing.Point(12, 31);
            this.jointNumber.Name = "jointNumber";
            this.jointNumber.Size = new System.Drawing.Size(100, 20);
            this.jointNumber.TabIndex = 1;
            // 
            // jointNumberLabel
            // 
            this.jointNumberLabel.Location = new System.Drawing.Point(12, 12);
            this.jointNumberLabel.Name = "jointNumberLabel";
            this.jointNumberLabel.Size = new System.Drawing.Size(62, 13);
            this.jointNumberLabel.TabIndex = 0;
            this.jointNumberLabel.Text = "Joint number";
            // 
            // inspectionOperations
            // 
            this.inspectionOperations.Name = "inspectionOperations";
            this.inspectionOperations.Size = new System.Drawing.Size(719, 397);
            this.inspectionOperations.Text = "&Inspection operations";
            // 
            // trenchParameters
            // 
            this.trenchParameters.Name = "trenchParameters";
            this.trenchParameters.Size = new System.Drawing.Size(719, 397);
            this.trenchParameters.Text = "&Trench parameters";
            // 
            // JointNewEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.ControlBox = false;
            this.Controls.Add(this.joint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JointNewEditXtraForm";
            this.ShowIcon = false;
            this.Text = "JointNewEditXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.joint)).EndInit();
            this.joint.ResumeLayout(false);
            this.generalParameters.ResumeLayout(false);
            this.generalParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weldig)).EndInit();
            this.weldig.ResumeLayout(false);
            this.weldig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspection.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.place.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl joint;
        private DevExpress.XtraTab.XtraTabPage generalParameters;
        private DevExpress.XtraTab.XtraTabPage inspectionOperations;
        private DevExpress.XtraTab.XtraTabPage trenchParameters;
        private DevExpress.XtraEditors.GroupControl weldig;
        private DevExpress.XtraEditors.ComboBoxEdit status;
        private DevExpress.XtraEditors.ComboBoxEdit place;
        private DevExpress.XtraEditors.TextEdit inspector;
        private DevExpress.XtraEditors.TextEdit welder;
        private DevExpress.XtraGrid.GridControl componentry;
        private DevExpress.XtraGrid.Views.Grid.GridView componentryView;
        private DevExpress.XtraGrid.GridControl pipes;
        private DevExpress.XtraGrid.Views.Grid.GridView pipesView;
        private DevExpress.XtraEditors.LabelControl componentryLabel;
        private DevExpress.XtraEditors.LabelControl pipesLabel;
        private DevExpress.XtraEditors.TextEdit jointNumber;
        private DevExpress.XtraEditors.LabelControl jointNumberLabel;
        private DevExpress.XtraEditors.LabelControl inspectionDateLabel;
        private DevExpress.XtraEditors.LabelControl weldingDateLabel;
        private DevExpress.XtraEditors.LabelControl welderNumberLabel;
        private DevExpress.XtraEditors.LabelControl inspectorLabel;
        private DevExpress.XtraEditors.LabelControl welderLabel;
        private DevExpress.XtraEditors.LabelControl statusLabel;
        private DevExpress.XtraEditors.LabelControl placeLabel;
        private DevExpress.XtraEditors.DateEdit inspection;
        private DevExpress.XtraEditors.DateEdit weldingDate;
        private DevExpress.XtraEditors.TextEdit welderNumber;
        private DevExpress.XtraGrid.Columns.GridColumn componentNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pipeNumberGridColumn;
    }
}