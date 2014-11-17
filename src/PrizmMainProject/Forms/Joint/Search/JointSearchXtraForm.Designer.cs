namespace PrizmMain.Forms.Joint.Search
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.extraJointButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.controlState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.searchLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.weldingDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.weldingDateTo = new DevExpress.XtraEditors.DateEdit();
            this.pegNumber = new DevExpress.XtraEditors.TextEdit();
            this.weldingDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.jointNumber = new DevExpress.XtraEditors.TextEdit();
            this.searchLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.jointNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.controlStateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldingDateFromLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.KMlayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldingDateToLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.eldingDateLabelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLabel = new DevExpress.XtraEditors.LabelControl();
            this.gridControlSerchResult = new DevExpress.XtraGrid.GridControl();
            this.resultView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.jointNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.joinStatusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jointWeldingDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repairGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.extraGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.extraJointButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControl)).BeginInit();
            this.searchLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlStateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFromLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMlayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateToLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eldingDateLabelLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            this.SuspendLayout();
            // 
            // extraJointButton
            // 
            this.extraJointButton.AutoHeight = false;
            this.extraJointButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("extraJointButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.extraJointButton.LookAndFeel.SkinName = "Office 2013";
            this.extraJointButton.Name = "extraJointButton";
            this.extraJointButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // controlState
            // 
            this.controlState.Location = new System.Drawing.Point(136, 18);
            this.controlState.Name = "controlState";
            this.controlState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlState.Size = new System.Drawing.Size(150, 20);
            this.controlState.StyleController = this.searchLayoutControl;
            this.controlState.TabIndex = 2;
            // 
            // searchLayoutControl
            // 
            this.searchLayoutControl.Controls.Add(this.weldingDateLabel);
            this.searchLayoutControl.Controls.Add(this.weldingDateTo);
            this.searchLayoutControl.Controls.Add(this.pegNumber);
            this.searchLayoutControl.Controls.Add(this.weldingDateFrom);
            this.searchLayoutControl.Controls.Add(this.searchButton);
            this.searchLayoutControl.Controls.Add(this.jointNumber);
            this.searchLayoutControl.Controls.Add(this.controlState);
            this.searchLayoutControl.Location = new System.Drawing.Point(20, 20);
            this.searchLayoutControl.Margin = new System.Windows.Forms.Padding(11);
            this.searchLayoutControl.Name = "searchLayoutControl";
            this.searchLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(381, 245, 250, 350);
            this.searchLayoutControl.OptionsView.UseDefaultDragAndDropRendering = false;
            this.searchLayoutControl.Root = this.searchLayoutGroup;
            this.searchLayoutControl.Size = new System.Drawing.Size(899, 48);
            this.searchLayoutControl.TabIndex = 59;
            this.searchLayoutControl.Text = "layoutControl1";
            // 
            // weldingDateLabel
            // 
            this.weldingDateLabel.Location = new System.Drawing.Point(320, 20);
            this.weldingDateLabel.Name = "weldingDateLabel";
            this.weldingDateLabel.Size = new System.Drawing.Size(64, 13);
            this.weldingDateLabel.StyleController = this.searchLayoutControl;
            this.weldingDateLabel.TabIndex = 65;
            this.weldingDateLabel.Text = "Дата сварки";
            // 
            // weldingDateTo
            // 
            this.weldingDateTo.EditValue = null;
            this.weldingDateTo.Location = new System.Drawing.Point(529, 18);
            this.weldingDateTo.Name = "weldingDateTo";
            this.weldingDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDateTo.Size = new System.Drawing.Size(100, 20);
            this.weldingDateTo.StyleController = this.searchLayoutControl;
            this.weldingDateTo.TabIndex = 4;
            // 
            // pegNumber
            // 
            this.pegNumber.Location = new System.Drawing.Point(663, 18);
            this.pegNumber.Name = "pegNumber";
            this.pegNumber.Size = new System.Drawing.Size(100, 20);
            this.pegNumber.StyleController = this.searchLayoutControl;
            this.pegNumber.TabIndex = 5;
            // 
            // weldingDateFrom
            // 
            this.weldingDateFrom.EditValue = null;
            this.weldingDateFrom.Location = new System.Drawing.Point(395, 18);
            this.weldingDateFrom.Name = "weldingDateFrom";
            this.weldingDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDateFrom.Size = new System.Drawing.Size(100, 20);
            this.weldingDateFrom.StyleController = this.searchLayoutControl;
            this.weldingDateFrom.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(797, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 21);
            this.searchButton.StyleController = this.searchLayoutControl;
            this.searchButton.TabIndex = 60;
            this.searchButton.Text = "Поиск";
            // 
            // jointNumber
            // 
            this.jointNumber.EditValue = "";
            this.jointNumber.Location = new System.Drawing.Point(2, 18);
            this.jointNumber.Margin = new System.Windows.Forms.Padding(15);
            this.jointNumber.Name = "jointNumber";
            this.jointNumber.Size = new System.Drawing.Size(100, 20);
            this.jointNumber.StyleController = this.searchLayoutControl;
            this.jointNumber.TabIndex = 1;
            // 
            // searchLayoutGroup
            // 
            this.searchLayoutGroup.CustomizationFormText = "Root";
            this.searchLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.searchLayoutGroup.GroupBordersVisible = false;
            this.searchLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.jointNumberLayout,
            this.controlStateLayout,
            this.weldingDateFromLayout,
            this.searchButtonLayout,
            this.KMlayout,
            this.weldingDateToLayout,
            this.eldingDateLabelLayout});
            this.searchLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.searchLayoutGroup.Name = "searchLayoutGroup";
            this.searchLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.searchLayoutGroup.Size = new System.Drawing.Size(899, 48);
            this.searchLayoutGroup.Text = "searchLayoutGroup";
            this.searchLayoutGroup.TextVisible = false;
            // 
            // jointNumberLayout
            // 
            this.jointNumberLayout.Control = this.jointNumber;
            this.jointNumberLayout.CustomizationFormText = "Номер";
            this.jointNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.jointNumberLayout.MinSize = new System.Drawing.Size(119, 47);
            this.jointNumberLayout.Name = "jointNumberLayout";
            this.jointNumberLayout.Size = new System.Drawing.Size(119, 48);
            this.jointNumberLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.jointNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.jointNumberLayout.Text = "Номер";
            this.jointNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.jointNumberLayout.TextSize = new System.Drawing.Size(70, 13);
            // 
            // controlStateLayout
            // 
            this.controlStateLayout.Control = this.controlState;
            this.controlStateLayout.CustomizationFormText = "Статус";
            this.controlStateLayout.Location = new System.Drawing.Point(119, 0);
            this.controlStateLayout.MinSize = new System.Drawing.Size(184, 47);
            this.controlStateLayout.Name = "controlStateLayout";
            this.controlStateLayout.Size = new System.Drawing.Size(184, 48);
            this.controlStateLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.controlStateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 0, 7);
            this.controlStateLayout.Text = "Статус";
            this.controlStateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.controlStateLayout.TextSize = new System.Drawing.Size(70, 13);
            // 
            // weldingDateFromLayout
            // 
            this.weldingDateFromLayout.Control = this.weldingDateFrom;
            this.weldingDateFromLayout.CustomizationFormText = "с";
            this.weldingDateFromLayout.Location = new System.Drawing.Point(393, 0);
            this.weldingDateFromLayout.MinSize = new System.Drawing.Size(119, 47);
            this.weldingDateFromLayout.Name = "weldingDateFromLayout";
            this.weldingDateFromLayout.Size = new System.Drawing.Size(119, 48);
            this.weldingDateFromLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.weldingDateFromLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.weldingDateFromLayout.Text = "с";
            this.weldingDateFromLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weldingDateFromLayout.TextSize = new System.Drawing.Size(70, 13);
            // 
            // searchButtonLayout
            // 
            this.searchButtonLayout.Control = this.searchButton;
            this.searchButtonLayout.CustomizationFormText = "searchButtonLayout";
            this.searchButtonLayout.Location = new System.Drawing.Point(780, 0);
            this.searchButtonLayout.MaxSize = new System.Drawing.Size(119, 0);
            this.searchButtonLayout.MinSize = new System.Drawing.Size(119, 47);
            this.searchButtonLayout.Name = "searchButtonLayout";
            this.searchButtonLayout.Size = new System.Drawing.Size(119, 48);
            this.searchButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.searchButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 0, 12, 11);
            this.searchButtonLayout.Text = "searchButtonLayout";
            this.searchButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchButtonLayout.TextToControlDistance = 0;
            this.searchButtonLayout.TextVisible = false;
            // 
            // KMlayout
            // 
            this.KMlayout.Control = this.pegNumber;
            this.KMlayout.CustomizationFormText = "Номер пикета";
            this.KMlayout.Location = new System.Drawing.Point(646, 0);
            this.KMlayout.MinSize = new System.Drawing.Size(119, 47);
            this.KMlayout.Name = "KMlayout";
            this.KMlayout.Size = new System.Drawing.Size(134, 48);
            this.KMlayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.KMlayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 0, 7);
            this.KMlayout.Text = "Номер пикета";
            this.KMlayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.KMlayout.TextSize = new System.Drawing.Size(70, 13);
            // 
            // weldingDateToLayout
            // 
            this.weldingDateToLayout.Control = this.weldingDateTo;
            this.weldingDateToLayout.CustomizationFormText = "по";
            this.weldingDateToLayout.Location = new System.Drawing.Point(512, 0);
            this.weldingDateToLayout.MinSize = new System.Drawing.Size(134, 47);
            this.weldingDateToLayout.Name = "weldingDateToLayout";
            this.weldingDateToLayout.Size = new System.Drawing.Size(134, 48);
            this.weldingDateToLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.weldingDateToLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 0, 7);
            this.weldingDateToLayout.Text = "по";
            this.weldingDateToLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weldingDateToLayout.TextSize = new System.Drawing.Size(70, 13);
            // 
            // eldingDateLabelLayout
            // 
            this.eldingDateLabelLayout.Control = this.weldingDateLabel;
            this.eldingDateLabelLayout.CustomizationFormText = "eldingDateLabelLayout";
            this.eldingDateLabelLayout.Location = new System.Drawing.Point(303, 0);
            this.eldingDateLabelLayout.Name = "eldingDateLabelLayout";
            this.eldingDateLabelLayout.Size = new System.Drawing.Size(90, 48);
            this.eldingDateLabelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 7, 18, 7);
            this.eldingDateLabelLayout.Text = "eldingDateLabelLayout";
            this.eldingDateLabelLayout.TextSize = new System.Drawing.Size(0, 0);
            this.eldingDateLabelLayout.TextToControlDistance = 0;
            this.eldingDateLabelLayout.TextVisible = false;
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
            this.gridControlSerchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSerchResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlSerchResult.Location = new System.Drawing.Point(20, 81);
            this.gridControlSerchResult.MainView = this.resultView;
            this.gridControlSerchResult.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.gridControlSerchResult.Name = "gridControlSerchResult";
            this.gridControlSerchResult.Size = new System.Drawing.Size(896, 352);
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
            this.resultView.OptionsBehavior.Editable = false;
            this.resultView.OptionsView.ShowGroupPanel = false;
            this.resultView.OptionsView.ShowIndicator = false;
            // 
            // jointNumberGridColumn
            // 
            this.jointNumberGridColumn.Caption = "№";
            this.jointNumberGridColumn.FieldName = "Id";
            this.jointNumberGridColumn.Name = "jointNumberGridColumn";
            this.jointNumberGridColumn.Visible = true;
            this.jointNumberGridColumn.VisibleIndex = 0;
            this.jointNumberGridColumn.Width = 118;
            // 
            // joinStatusGridColumn
            // 
            this.joinStatusGridColumn.Caption = "Статус";
            this.joinStatusGridColumn.FieldName = "Status";
            this.joinStatusGridColumn.Name = "joinStatusGridColumn";
            this.joinStatusGridColumn.Visible = true;
            this.joinStatusGridColumn.VisibleIndex = 1;
            this.joinStatusGridColumn.Width = 185;
            // 
            // jointWeldingDateColumn
            // 
            this.jointWeldingDateColumn.Caption = "Дата сварки";
            this.jointWeldingDateColumn.FieldName = "ControlDate";
            this.jointWeldingDateColumn.Name = "jointWeldingDateColumn";
            this.jointWeldingDateColumn.Visible = true;
            this.jointWeldingDateColumn.VisibleIndex = 2;
            this.jointWeldingDateColumn.Width = 86;
            // 
            // repairGridColumn
            // 
            this.repairGridColumn.Caption = "В ремонте";
            this.repairGridColumn.FieldName = "Repair";
            this.repairGridColumn.Name = "repairGridColumn";
            this.repairGridColumn.Visible = true;
            this.repairGridColumn.VisibleIndex = 3;
            this.repairGridColumn.Width = 457;
            // 
            // extraGridColumn
            // 
            this.extraGridColumn.ColumnEdit = this.extraJointButton;
            this.extraGridColumn.Name = "extraGridColumn";
            this.extraGridColumn.Visible = true;
            this.extraGridColumn.VisibleIndex = 4;
            this.extraGridColumn.Width = 50;
            // 
            // JointSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 452);
            this.Controls.Add(this.searchLayoutControl);
            this.Controls.Add(this.gridControlSerchResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JointSearchXtraForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Поиск стыка";
            ((System.ComponentModel.ISupportInitialize)(this.extraJointButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControl)).EndInit();
            this.searchLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlStateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFromLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMlayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateToLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eldingDateLabelLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit pegNumber;
        private DevExpress.XtraLayout.LayoutControl searchLayoutControl;
        private DevExpress.XtraEditors.TextEdit jointNumber;
        private DevExpress.XtraLayout.LayoutControlGroup searchLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem jointNumberLayout;
        private DevExpress.XtraEditors.DateEdit weldingDateFrom;
        private DevExpress.XtraLayout.LayoutControlItem weldingDateFromLayout;
        private DevExpress.XtraLayout.LayoutControlItem controlStateLayout;
        private DevExpress.XtraLayout.LayoutControlItem KMlayout;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraLayout.LayoutControlItem searchButtonLayout;
        private DevExpress.XtraGrid.Columns.GridColumn jointWeldingDateColumn;
        private DevExpress.XtraEditors.LabelControl weldingDateLabel;
        private DevExpress.XtraEditors.DateEdit weldingDateTo;
        private DevExpress.XtraLayout.LayoutControlItem weldingDateToLayout;
        private DevExpress.XtraLayout.LayoutControlItem eldingDateLabelLayout;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit extraJointButton;

    }
}