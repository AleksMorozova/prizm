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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JointSearchXtraForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.controlState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.searchLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.pegNumber = new DevExpress.XtraEditors.TextEdit();
            this.seaLevel = new DevExpress.XtraEditors.TextEdit();
            this.weldingDate = new DevExpress.XtraEditors.DateEdit();
            this.GPSLong = new DevExpress.XtraEditors.TextEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.jointNumber = new DevExpress.XtraEditors.TextEdit();
            this.GPSLat = new DevExpress.XtraEditors.TextEdit();
            this.searchLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.jointNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldingDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.controlStateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.GPSLatLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.GPSLonglayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.elevationLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.KMlayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLabel = new DevExpress.XtraEditors.LabelControl();
            this.gridControlSerchResult = new DevExpress.XtraGrid.GridControl();
            this.resultView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.jointNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.joinStatusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jointWeldingDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repairGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.extraGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.extraJointButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.controlState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControl)).BeginInit();
            this.searchLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlStateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLatLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLonglayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevationLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMlayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraJointButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlState
            // 
            this.controlState.Location = new System.Drawing.Point(236, 18);
            this.controlState.Name = "controlState";
            this.controlState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlState.Size = new System.Drawing.Size(457, 20);
            this.controlState.StyleController = this.searchLayoutControl;
            this.controlState.TabIndex = 38;
            // 
            // searchLayoutControl
            // 
            this.searchLayoutControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLayoutControl.Controls.Add(this.pegNumber);
            this.searchLayoutControl.Controls.Add(this.seaLevel);
            this.searchLayoutControl.Controls.Add(this.weldingDate);
            this.searchLayoutControl.Controls.Add(this.GPSLong);
            this.searchLayoutControl.Controls.Add(this.searchButton);
            this.searchLayoutControl.Controls.Add(this.jointNumber);
            this.searchLayoutControl.Controls.Add(this.GPSLat);
            this.searchLayoutControl.Controls.Add(this.controlState);
            this.searchLayoutControl.Location = new System.Drawing.Point(20, 20);
            this.searchLayoutControl.Margin = new System.Windows.Forms.Padding(11);
            this.searchLayoutControl.Name = "searchLayoutControl";
            this.searchLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(86, 161, 250, 350);
            this.searchLayoutControl.OptionsView.UseDefaultDragAndDropRendering = false;
            this.searchLayoutControl.Root = this.searchLayoutGroup;
            this.searchLayoutControl.Size = new System.Drawing.Size(888, 98);
            this.searchLayoutControl.TabIndex = 59;
            this.searchLayoutControl.Text = "layoutControl1";
            // 
            // pegNumber
            // 
            this.pegNumber.Location = new System.Drawing.Point(725, 18);
            this.pegNumber.Name = "pegNumber";
            this.pegNumber.Size = new System.Drawing.Size(161, 20);
            this.pegNumber.StyleController = this.searchLayoutControl;
            this.pegNumber.TabIndex = 52;
            // 
            // seaLevel
            // 
            this.seaLevel.Location = new System.Drawing.Point(562, 71);
            this.seaLevel.Name = "seaLevel";
            this.seaLevel.Size = new System.Drawing.Size(131, 20);
            this.seaLevel.StyleController = this.searchLayoutControl;
            this.seaLevel.TabIndex = 55;
            // 
            // weldingDate
            // 
            this.weldingDate.EditValue = null;
            this.weldingDate.Location = new System.Drawing.Point(0, 71);
            this.weldingDate.Name = "weldingDate";
            this.weldingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Size = new System.Drawing.Size(206, 20);
            this.weldingDate.StyleController = this.searchLayoutControl;
            this.weldingDate.TabIndex = 63;
            // 
            // GPSLong
            // 
            this.GPSLong.Location = new System.Drawing.Point(399, 71);
            this.GPSLong.Name = "GPSLong";
            this.GPSLong.Size = new System.Drawing.Size(131, 20);
            this.GPSLong.StyleController = this.searchLayoutControl;
            this.GPSLong.TabIndex = 54;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(725, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(161, 22);
            this.searchButton.StyleController = this.searchLayoutControl;
            this.searchButton.TabIndex = 60;
            this.searchButton.Text = "Search";
            // 
            // jointNumber
            // 
            this.jointNumber.EditValue = "";
            this.jointNumber.Location = new System.Drawing.Point(2, 18);
            this.jointNumber.Margin = new System.Windows.Forms.Padding(15);
            this.jointNumber.Name = "jointNumber";
            this.jointNumber.Size = new System.Drawing.Size(202, 20);
            this.jointNumber.StyleController = this.searchLayoutControl;
            this.jointNumber.TabIndex = 61;
            // 
            // GPSLat
            // 
            this.GPSLat.Location = new System.Drawing.Point(236, 71);
            this.GPSLat.Name = "GPSLat";
            this.GPSLat.Size = new System.Drawing.Size(131, 20);
            this.GPSLat.StyleController = this.searchLayoutControl;
            this.GPSLat.TabIndex = 53;
            // 
            // searchLayoutGroup
            // 
            this.searchLayoutGroup.CustomizationFormText = "Root";
            this.searchLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.searchLayoutGroup.GroupBordersVisible = false;
            this.searchLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.jointNumberLayout,
            this.weldingDateLayout,
            this.controlStateLayout,
            this.GPSLatLayout,
            this.GPSLonglayout,
            this.elevationLayout,
            this.KMlayout,
            this.searchButtonLayout});
            this.searchLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.searchLayoutGroup.Name = "searchLayoutGroup";
            this.searchLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.searchLayoutGroup.Size = new System.Drawing.Size(888, 98);
            this.searchLayoutGroup.Text = "searchLayoutGroup";
            this.searchLayoutGroup.TextVisible = false;
            // 
            // jointNumberLayout
            // 
            this.jointNumberLayout.Control = this.jointNumber;
            this.jointNumberLayout.CustomizationFormText = "Номер";
            this.jointNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.jointNumberLayout.Name = "jointNumberLayout";
            this.jointNumberLayout.Size = new System.Drawing.Size(206, 40);
            this.jointNumberLayout.Text = "Номер";
            this.jointNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.jointNumberLayout.TextSize = new System.Drawing.Size(131, 13);
            // 
            // weldingDateLayout
            // 
            this.weldingDateLayout.Control = this.weldingDate;
            this.weldingDateLayout.CustomizationFormText = "Дата сварки";
            this.weldingDateLayout.Location = new System.Drawing.Point(0, 40);
            this.weldingDateLayout.Name = "weldingDateLayout";
            this.weldingDateLayout.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 15, 0);
            this.weldingDateLayout.Size = new System.Drawing.Size(206, 58);
            this.weldingDateLayout.Text = "Дата сварки";
            this.weldingDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weldingDateLayout.TextSize = new System.Drawing.Size(131, 13);
            // 
            // controlStateLayout
            // 
            this.controlStateLayout.Control = this.controlState;
            this.controlStateLayout.CustomizationFormText = "Статус";
            this.controlStateLayout.Location = new System.Drawing.Point(206, 0);
            this.controlStateLayout.Name = "controlStateLayout";
            this.controlStateLayout.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 2, 2);
            this.controlStateLayout.Size = new System.Drawing.Size(489, 40);
            this.controlStateLayout.Text = "Статус";
            this.controlStateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.controlStateLayout.TextSize = new System.Drawing.Size(131, 13);
            // 
            // GPSLatLayout
            // 
            this.GPSLatLayout.Control = this.GPSLat;
            this.GPSLatLayout.CustomizationFormText = "Широта";
            this.GPSLatLayout.Location = new System.Drawing.Point(206, 40);
            this.GPSLatLayout.Name = "GPSLatLayout";
            this.GPSLatLayout.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 15, 2);
            this.GPSLatLayout.Size = new System.Drawing.Size(163, 58);
            this.GPSLatLayout.Text = "Широта";
            this.GPSLatLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.GPSLatLayout.TextSize = new System.Drawing.Size(131, 13);
            // 
            // GPSLonglayout
            // 
            this.GPSLonglayout.Control = this.GPSLong;
            this.GPSLonglayout.CustomizationFormText = "Долгота";
            this.GPSLonglayout.Location = new System.Drawing.Point(369, 40);
            this.GPSLonglayout.Name = "GPSLonglayout";
            this.GPSLonglayout.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 15, 2);
            this.GPSLonglayout.Size = new System.Drawing.Size(163, 58);
            this.GPSLonglayout.Text = "Долгота";
            this.GPSLonglayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.GPSLonglayout.TextSize = new System.Drawing.Size(131, 13);
            // 
            // elevationLayout
            // 
            this.elevationLayout.Control = this.seaLevel;
            this.elevationLayout.CustomizationFormText = "Высота над уровнем моря";
            this.elevationLayout.Location = new System.Drawing.Point(532, 40);
            this.elevationLayout.Name = "elevationLayout";
            this.elevationLayout.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 15, 2);
            this.elevationLayout.Size = new System.Drawing.Size(163, 58);
            this.elevationLayout.Text = "Высота над уровнем моря";
            this.elevationLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.elevationLayout.TextSize = new System.Drawing.Size(131, 13);
            // 
            // KMlayout
            // 
            this.KMlayout.Control = this.pegNumber;
            this.KMlayout.CustomizationFormText = "Номер пикета";
            this.KMlayout.Location = new System.Drawing.Point(695, 0);
            this.KMlayout.Name = "KMlayout";
            this.KMlayout.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 2, 2);
            this.KMlayout.Size = new System.Drawing.Size(193, 40);
            this.KMlayout.Text = "Номер пикета";
            this.KMlayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.KMlayout.TextSize = new System.Drawing.Size(131, 13);
            // 
            // searchButtonLayout
            // 
            this.searchButtonLayout.Control = this.searchButton;
            this.searchButtonLayout.CustomizationFormText = "searchButtonLayout";
            this.searchButtonLayout.Location = new System.Drawing.Point(695, 40);
            this.searchButtonLayout.Name = "searchButtonLayout";
            this.searchButtonLayout.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 28, 2);
            this.searchButtonLayout.Size = new System.Drawing.Size(193, 58);
            this.searchButtonLayout.Text = "searchButtonLayout";
            this.searchButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchButtonLayout.TextToControlDistance = 0;
            this.searchButtonLayout.TextVisible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(79, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(31, 13);
            this.statusLabel.TabIndex = 36;
            this.statusLabel.Text = "Status";
            // 
            // gridControlSerchResult
            // 
            this.gridControlSerchResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSerchResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlSerchResult.Location = new System.Drawing.Point(20, 140);
            this.gridControlSerchResult.MainView = this.resultView;
            this.gridControlSerchResult.Margin = new System.Windows.Forms.Padding(11);
            this.gridControlSerchResult.Name = "gridControlSerchResult";
            this.gridControlSerchResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.extraJointButton});
            this.gridControlSerchResult.Size = new System.Drawing.Size(888, 290);
            this.gridControlSerchResult.TabIndex = 33;
            this.gridControlSerchResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.resultView});
            // 
            // resultView
            // 
            this.resultView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.jointNumberGridColumn,
            this.joinStatusGridColumn,
            this.jointWeldingDateColumn,
            this.repairGridColumn,
            this.extraGridColumn});
            this.resultView.GridControl = this.gridControlSerchResult;
            this.resultView.Name = "resultView";
            this.resultView.OptionsView.ShowGroupPanel = false;
            // 
            // jointNumberGridColumn
            // 
            this.jointNumberGridColumn.Caption = "№";
            this.jointNumberGridColumn.FieldName = "Id";
            this.jointNumberGridColumn.Name = "jointNumberGridColumn";
            this.jointNumberGridColumn.Visible = true;
            this.jointNumberGridColumn.VisibleIndex = 0;
            this.jointNumberGridColumn.Width = 125;
            // 
            // joinStatusGridColumn
            // 
            this.joinStatusGridColumn.Caption = "Статус";
            this.joinStatusGridColumn.FieldName = "Status";
            this.joinStatusGridColumn.Name = "joinStatusGridColumn";
            this.joinStatusGridColumn.Visible = true;
            this.joinStatusGridColumn.VisibleIndex = 1;
            this.joinStatusGridColumn.Width = 125;
            // 
            // jointWeldingDateColumn
            // 
            this.jointWeldingDateColumn.Caption = "Дата сварки";
            this.jointWeldingDateColumn.FieldName = "ControlDate";
            this.jointWeldingDateColumn.Name = "jointWeldingDateColumn";
            this.jointWeldingDateColumn.Visible = true;
            this.jointWeldingDateColumn.VisibleIndex = 2;
            // 
            // repairGridColumn
            // 
            this.repairGridColumn.Caption = "В ремонте";
            this.repairGridColumn.FieldName = "Repair";
            this.repairGridColumn.Name = "repairGridColumn";
            this.repairGridColumn.Visible = true;
            this.repairGridColumn.VisibleIndex = 3;
            this.repairGridColumn.Width = 125;
            // 
            // extraGridColumn
            // 
            this.extraGridColumn.ColumnEdit = this.extraJointButton;
            this.extraGridColumn.FieldName = "extraGridColumn";
            this.extraGridColumn.Name = "extraGridColumn";
            this.extraGridColumn.Visible = true;
            this.extraGridColumn.VisibleIndex = 4;
            this.extraGridColumn.Width = 60;
            // 
            // extraJointButton
            // 
            this.extraJointButton.AutoHeight = false;
            this.extraJointButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("extraJointButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.extraJointButton.Name = "extraJointButton";
            this.extraJointButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // JointSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.searchLayoutControl);
            this.Controls.Add(this.gridControlSerchResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JointSearchXtraForm";
            this.Text = "Поиск стыка";
            ((System.ComponentModel.ISupportInitialize)(this.controlState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControl)).EndInit();
            this.searchLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlStateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLatLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLonglayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevationLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMlayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraJointButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit controlState;
        private DevExpress.XtraEditors.LabelControl statusLabel;
        private DevExpress.XtraGrid.GridControl gridControlSerchResult;
        private DevExpress.XtraGrid.Views.Grid.GridView resultView;
        private DevExpress.XtraGrid.Columns.GridColumn jointNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn joinStatusGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn repairGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn extraGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit extraJointButton;
        private DevExpress.XtraEditors.TextEdit pegNumber;
        private DevExpress.XtraEditors.TextEdit GPSLat;
        private DevExpress.XtraEditors.TextEdit GPSLong;
        private DevExpress.XtraEditors.TextEdit seaLevel;
        private DevExpress.XtraLayout.LayoutControl searchLayoutControl;
        private DevExpress.XtraEditors.TextEdit jointNumber;
        private DevExpress.XtraLayout.LayoutControlGroup searchLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem jointNumberLayout;
        private DevExpress.XtraEditors.DateEdit weldingDate;
        private DevExpress.XtraLayout.LayoutControlItem weldingDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem controlStateLayout;
        private DevExpress.XtraLayout.LayoutControlItem GPSLatLayout;
        private DevExpress.XtraLayout.LayoutControlItem GPSLonglayout;
        private DevExpress.XtraLayout.LayoutControlItem elevationLayout;
        private DevExpress.XtraLayout.LayoutControlItem KMlayout;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraLayout.LayoutControlItem searchButtonLayout;
        private DevExpress.XtraGrid.Columns.GridColumn jointWeldingDateColumn;

    }
}