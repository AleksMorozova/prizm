namespace Prizm.Main.Forms.Joint.Search
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
            this.extraJointButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.searchLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.activity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControlSerchResult = new DevExpress.XtraGrid.GridControl();
            this.resultView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jointNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.joinStatusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusLocalizedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numberKPCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loweringDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gpsLatCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gpsLongCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gpsHeightCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weldingDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.weldingDateTo = new DevExpress.XtraEditors.DateEdit();
            this.pegNumber = new DevExpress.XtraEditors.TextEdit();
            this.weldingDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.jointNumber = new DevExpress.XtraEditors.TextEdit();
            this.controlState = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.generalLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchResultLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchResultLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.KMlayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.jointNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldingDateFromLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldingDateToLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.eldingDateLabelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.controlStateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.activityLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSource = new System.Windows.Forms.BindingSource();
            this.statusLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.extraJointButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControl)).BeginInit();
            this.searchLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMlayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFromLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateToLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eldingDateLabelLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlStateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // extraJointButton
            // 
            this.extraJointButton.AutoHeight = false;
            this.extraJointButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("extraJointButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.extraJointButton.LookAndFeel.SkinName = "Office 2013";
            this.extraJointButton.Name = "extraJointButton";
            this.extraJointButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // searchLayoutControl
            // 
            this.searchLayoutControl.Controls.Add(this.activity);
            this.searchLayoutControl.Controls.Add(this.gridControlSerchResult);
            this.searchLayoutControl.Controls.Add(this.weldingDateLabel);
            this.searchLayoutControl.Controls.Add(this.weldingDateTo);
            this.searchLayoutControl.Controls.Add(this.pegNumber);
            this.searchLayoutControl.Controls.Add(this.weldingDateFrom);
            this.searchLayoutControl.Controls.Add(this.searchButton);
            this.searchLayoutControl.Controls.Add(this.jointNumber);
            this.searchLayoutControl.Controls.Add(this.controlState);
            this.searchLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLayoutControl.Location = new System.Drawing.Point(2, 2);
            this.searchLayoutControl.Margin = new System.Windows.Forms.Padding(11);
            this.searchLayoutControl.Name = "searchLayoutControl";
            this.searchLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(344, 245, 250, 350);
            this.searchLayoutControl.OptionsView.UseDefaultDragAndDropRendering = false;
            this.searchLayoutControl.Root = this.generalLayoutGroup;
            this.searchLayoutControl.Size = new System.Drawing.Size(1271, 546);
            this.searchLayoutControl.TabIndex = 59;
            this.searchLayoutControl.Text = "layoutControl1";
            // 
            // activity
            // 
            this.activity.Location = new System.Drawing.Point(951, 54);
            this.activity.Name = "activity";
            this.activity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.activity.Size = new System.Drawing.Size(174, 20);
            this.activity.StyleController = this.searchLayoutControl;
            this.activity.TabIndex = 66;
            this.activity.SelectedIndexChanged += new System.EventHandler(this.activity_SelectedIndexChanged);
            // 
            // gridControlSerchResult
            // 
            this.gridControlSerchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSerchResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlSerchResult.Location = new System.Drawing.Point(14, 133);
            this.gridControlSerchResult.MainView = this.resultView;
            this.gridControlSerchResult.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.gridControlSerchResult.Name = "gridControlSerchResult";
            this.gridControlSerchResult.Size = new System.Drawing.Size(1243, 399);
            this.gridControlSerchResult.TabIndex = 33;
            this.gridControlSerchResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.resultView});
            // 
            // resultView
            // 
            this.resultView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCol,
            this.jointNumberGridColumn,
            this.joinStatusGridColumn,
            this.statusLocalizedCol,
            this.numberKPCol,
            this.loweringDateCol,
            this.gpsLatCol,
            this.gpsLongCol,
            this.gpsHeightCol});
            this.resultView.GridControl = this.gridControlSerchResult;
            this.resultView.Name = "resultView";
            this.resultView.OptionsBehavior.Editable = false;
            this.resultView.OptionsBehavior.FocusLeaveOnTab = true;
            this.resultView.OptionsNavigation.UseTabKey = false;
            this.resultView.OptionsView.ShowGroupPanel = false;
            this.resultView.OptionsView.ShowIndicator = false;
            this.resultView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.resultView_RowCellStyle);
            this.resultView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.resultView_CustomUnboundColumnData);
            this.resultView.DoubleClick += new System.EventHandler(this.resultView_DoubleClick);
            // 
            // idCol
            // 
            this.idCol.Caption = "#";
            this.idCol.FieldName = "Id";
            this.idCol.Name = "idCol";
            // 
            // jointNumberGridColumn
            // 
            this.jointNumberGridColumn.Caption = "Номер стыка";
            this.jointNumberGridColumn.FieldName = "Number";
            this.jointNumberGridColumn.Name = "jointNumberGridColumn";
            this.jointNumberGridColumn.Visible = true;
            this.jointNumberGridColumn.VisibleIndex = 0;
            this.jointNumberGridColumn.Width = 250;
            // 
            // joinStatusGridColumn
            // 
            this.joinStatusGridColumn.Caption = "Статус";
            this.joinStatusGridColumn.FieldName = "Status";
            this.joinStatusGridColumn.Name = "joinStatusGridColumn";
            this.joinStatusGridColumn.Width = 250;
            // 
            // statusLocalizedCol
            // 
            this.statusLocalizedCol.Caption = "Статус";
            this.statusLocalizedCol.FieldName = "statusLocalizedCol";
            this.statusLocalizedCol.Name = "statusLocalizedCol";
            this.statusLocalizedCol.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.statusLocalizedCol.Visible = true;
            this.statusLocalizedCol.VisibleIndex = 1;
            // 
            // numberKPCol
            // 
            this.numberKPCol.Caption = "Номер пикета";
            this.numberKPCol.FieldName = "NumberKP";
            this.numberKPCol.Name = "numberKPCol";
            this.numberKPCol.Visible = true;
            this.numberKPCol.VisibleIndex = 2;
            // 
            // loweringDateCol
            // 
            this.loweringDateCol.Caption = "Дата укладки";
            this.loweringDateCol.FieldName = "LoweringDate";
            this.loweringDateCol.Name = "loweringDateCol";
            this.loweringDateCol.Visible = true;
            this.loweringDateCol.VisibleIndex = 3;
            // 
            // gpsLatCol
            // 
            this.gpsLatCol.Caption = "Широта";
            this.gpsLatCol.FieldName = "GpsLatitude";
            this.gpsLatCol.Name = "gpsLatCol";
            this.gpsLatCol.Visible = true;
            this.gpsLatCol.VisibleIndex = 4;
            // 
            // gpsLongCol
            // 
            this.gpsLongCol.Caption = "Долгота";
            this.gpsLongCol.FieldName = "GpsLongitude";
            this.gpsLongCol.Name = "gpsLongCol";
            this.gpsLongCol.Visible = true;
            this.gpsLongCol.VisibleIndex = 5;
            // 
            // gpsHeightCol
            // 
            this.gpsHeightCol.Caption = "Высота";
            this.gpsHeightCol.FieldName = "GpsHeight";
            this.gpsHeightCol.Name = "gpsHeightCol";
            this.gpsHeightCol.Visible = true;
            this.gpsHeightCol.VisibleIndex = 6;
            // 
            // weldingDateLabel
            // 
            this.weldingDateLabel.Location = new System.Drawing.Point(427, 58);
            this.weldingDateLabel.Name = "weldingDateLabel";
            this.weldingDateLabel.Size = new System.Drawing.Size(84, 18);
            this.weldingDateLabel.StyleController = this.searchLayoutControl;
            this.weldingDateLabel.TabIndex = 65;
            this.weldingDateLabel.Text = "Дата сварки";
            // 
            // weldingDateTo
            // 
            this.weldingDateTo.EditValue = null;
            this.weldingDateTo.Location = new System.Drawing.Point(664, 54);
            this.weldingDateTo.Name = "weldingDateTo";
            this.weldingDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDateTo.Size = new System.Drawing.Size(109, 20);
            this.weldingDateTo.StyleController = this.searchLayoutControl;
            this.weldingDateTo.TabIndex = 4;
            // 
            // pegNumber
            // 
            this.pegNumber.Location = new System.Drawing.Point(801, 54);
            this.pegNumber.Name = "pegNumber";
            this.pegNumber.Properties.Mask.EditMask = "n0";
            this.pegNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.pegNumber.Size = new System.Drawing.Size(122, 20);
            this.pegNumber.StyleController = this.searchLayoutControl;
            this.pegNumber.TabIndex = 5;
            // 
            // weldingDateFrom
            // 
            this.weldingDateFrom.EditValue = null;
            this.weldingDateFrom.Location = new System.Drawing.Point(527, 54);
            this.weldingDateFrom.Name = "weldingDateFrom";
            this.weldingDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDateFrom.Size = new System.Drawing.Size(109, 20);
            this.weldingDateFrom.StyleController = this.searchLayoutControl;
            this.weldingDateFrom.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(1156, 53);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 21);
            this.searchButton.StyleController = this.searchLayoutControl;
            this.searchButton.TabIndex = 60;
            this.searchButton.Text = "&Поиск";
            // 
            // jointNumber
            // 
            this.jointNumber.EditValue = "";
            this.jointNumber.Location = new System.Drawing.Point(20, 54);
            this.jointNumber.Margin = new System.Windows.Forms.Padding(15);
            this.jointNumber.Name = "jointNumber";
            this.jointNumber.Size = new System.Drawing.Size(179, 20);
            this.jointNumber.StyleController = this.searchLayoutControl;
            this.jointNumber.TabIndex = 1;
            // 
            // controlState
            // 
            this.controlState.Location = new System.Drawing.Point(227, 54);
            this.controlState.Name = "controlState";
            this.controlState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlState.Size = new System.Drawing.Size(172, 20);
            this.controlState.StyleController = this.searchLayoutControl;
            this.controlState.TabIndex = 2;
            this.controlState.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.controlState_CloseUp);
            // 
            // generalLayoutGroup
            // 
            this.generalLayoutGroup.CustomizationFormText = "Root";
            this.generalLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalLayoutGroup.GroupBordersVisible = false;
            this.generalLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchResultLayoutGroup,
            this.searchLayoutGroup});
            this.generalLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalLayoutGroup.Name = "generalLayoutGroup";
            this.generalLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.generalLayoutGroup.Size = new System.Drawing.Size(1271, 546);
            this.generalLayoutGroup.Text = "generalLayoutGroup";
            this.generalLayoutGroup.TextVisible = false;
            // 
            // searchResultLayoutGroup
            // 
            this.searchResultLayoutGroup.CustomizationFormText = "Результаты поиска";
            this.searchResultLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchResultLayout});
            this.searchResultLayoutGroup.Location = new System.Drawing.Point(0, 100);
            this.searchResultLayoutGroup.Name = "searchResultLayoutGroup";
            this.searchResultLayoutGroup.Size = new System.Drawing.Size(1271, 446);
            this.searchResultLayoutGroup.Text = "Резул&ьтаты поиска";
            // 
            // searchResultLayout
            // 
            this.searchResultLayout.Control = this.gridControlSerchResult;
            this.searchResultLayout.CustomizationFormText = "Резул&ьтат поиска";
            this.searchResultLayout.Location = new System.Drawing.Point(0, 0);
            this.searchResultLayout.Name = "searchResultLayout";
            this.searchResultLayout.Size = new System.Drawing.Size(1247, 403);
            this.searchResultLayout.Text = "Резул&ьтат поиска";
            this.searchResultLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchResultLayout.TextVisible = false;
            // 
            // searchLayoutGroup
            // 
            this.searchLayoutGroup.CustomizationFormText = "Параметры поиска";
            this.searchLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.KMlayout,
            this.jointNumberLayout,
            this.weldingDateFromLayout,
            this.weldingDateToLayout,
            this.eldingDateLabelLayout,
            this.controlStateLayout,
            this.searchButtonLayout,
            this.activityLayout});
            this.searchLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.searchLayoutGroup.Name = "searchLayoutGroup";
            this.searchLayoutGroup.Size = new System.Drawing.Size(1271, 100);
            this.searchLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 7, 7);
            this.searchLayoutGroup.Text = "Параметры поиска";
            // 
            // KMlayout
            // 
            this.KMlayout.Control = this.pegNumber;
            this.KMlayout.CustomizationFormText = "Íîìåð ïèêåòà";
            this.KMlayout.Location = new System.Drawing.Point(774, 0);
            this.KMlayout.MinSize = new System.Drawing.Size(119, 47);
            this.KMlayout.Name = "KMlayout";
            this.KMlayout.Size = new System.Drawing.Size(150, 47);
            this.KMlayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.KMlayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 7);
            this.KMlayout.Text = "Номер п&икета";
            this.KMlayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.KMlayout.TextSize = new System.Drawing.Size(88, 13);
            // 
            // jointNumberLayout
            // 
            this.jointNumberLayout.Control = this.jointNumber;
            this.jointNumberLayout.CustomizationFormText = "Íîìåð";
            this.jointNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.jointNumberLayout.MinSize = new System.Drawing.Size(119, 47);
            this.jointNumberLayout.Name = "jointNumberLayout";
            this.jointNumberLayout.Size = new System.Drawing.Size(200, 47);
            this.jointNumberLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.jointNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 12, 0, 5);
            this.jointNumberLayout.Text = "Ном&ер стыка";
            this.jointNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.jointNumberLayout.TextSize = new System.Drawing.Size(88, 13);
            // 
            // weldingDateFromLayout
            // 
            this.weldingDateFromLayout.Control = this.weldingDateFrom;
            this.weldingDateFromLayout.CustomizationFormText = "ñ";
            this.weldingDateFromLayout.Location = new System.Drawing.Point(500, 0);
            this.weldingDateFromLayout.MaxSize = new System.Drawing.Size(137, 47);
            this.weldingDateFromLayout.MinSize = new System.Drawing.Size(137, 47);
            this.weldingDateFromLayout.Name = "weldingDateFromLayout";
            this.weldingDateFromLayout.Size = new System.Drawing.Size(137, 47);
            this.weldingDateFromLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.weldingDateFromLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 5);
            this.weldingDateFromLayout.Text = "с";
            this.weldingDateFromLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weldingDateFromLayout.TextSize = new System.Drawing.Size(88, 13);
            // 
            // weldingDateToLayout
            // 
            this.weldingDateToLayout.Control = this.weldingDateTo;
            this.weldingDateToLayout.CustomizationFormText = "ïî";
            this.weldingDateToLayout.Location = new System.Drawing.Point(637, 0);
            this.weldingDateToLayout.MaxSize = new System.Drawing.Size(137, 47);
            this.weldingDateToLayout.MinSize = new System.Drawing.Size(137, 47);
            this.weldingDateToLayout.Name = "weldingDateToLayout";
            this.weldingDateToLayout.Size = new System.Drawing.Size(137, 47);
            this.weldingDateToLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.weldingDateToLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 5);
            this.weldingDateToLayout.Text = "по";
            this.weldingDateToLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weldingDateToLayout.TextSize = new System.Drawing.Size(88, 13);
            // 
            // eldingDateLabelLayout
            // 
            this.eldingDateLabelLayout.Control = this.weldingDateLabel;
            this.eldingDateLabelLayout.CustomizationFormText = "eldingDateLabelLayout";
            this.eldingDateLabelLayout.Location = new System.Drawing.Point(400, 0);
            this.eldingDateLabelLayout.MinSize = new System.Drawing.Size(80, 42);
            this.eldingDateLabelLayout.Name = "eldingDateLabelLayout";
            this.eldingDateLabelLayout.Size = new System.Drawing.Size(100, 47);
            this.eldingDateLabelLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.eldingDateLabelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 0, 20, 5);
            this.eldingDateLabelLayout.Text = "eldingDateLabelLayout";
            this.eldingDateLabelLayout.TextSize = new System.Drawing.Size(0, 0);
            this.eldingDateLabelLayout.TextVisible = false;
            // 
            // controlStateLayout
            // 
            this.controlStateLayout.Control = this.controlState;
            this.controlStateLayout.CustomizationFormText = "Ñòàòóñ";
            this.controlStateLayout.Location = new System.Drawing.Point(200, 0);
            this.controlStateLayout.MinSize = new System.Drawing.Size(50, 25);
            this.controlStateLayout.Name = "controlStateLayout";
            this.controlStateLayout.Size = new System.Drawing.Size(200, 47);
            this.controlStateLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.controlStateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 5);
            this.controlStateLayout.Text = "С&татус";
            this.controlStateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.controlStateLayout.TextSize = new System.Drawing.Size(88, 13);
            // 
            // searchButtonLayout
            // 
            this.searchButtonLayout.Control = this.searchButton;
            this.searchButtonLayout.CustomizationFormText = "searchButtonLayout";
            this.searchButtonLayout.Location = new System.Drawing.Point(1126, 0);
            this.searchButtonLayout.MaxSize = new System.Drawing.Size(119, 0);
            this.searchButtonLayout.MinSize = new System.Drawing.Size(119, 47);
            this.searchButtonLayout.Name = "searchButtonLayout";
            this.searchButtonLayout.Size = new System.Drawing.Size(119, 47);
            this.searchButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.searchButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 0, 15, 7);
            this.searchButtonLayout.Text = "searchButtonLayout";
            this.searchButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchButtonLayout.TextVisible = false;
            // 
            // activityLayout
            // 
            this.activityLayout.Control = this.activity;
            this.activityLayout.CustomizationFormText = "layoutControlItem1";
            this.activityLayout.Location = new System.Drawing.Point(924, 0);
            this.activityLayout.Name = "activityLayout";
            this.activityLayout.Size = new System.Drawing.Size(202, 47);
            this.activityLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 5);
            this.activityLayout.Text = "Состояние стыка";
            this.activityLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.activityLayout.TextSize = new System.Drawing.Size(88, 13);
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(79, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(31, 13);
            this.statusLabel.TabIndex = 36;
            this.statusLabel.Text = "Status";
            // 
            // JointSearchXtraForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 550);
            this.Controls.Add(this.searchLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JointSearchXtraForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Поиск стыков";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JointSearchXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.JointSearchXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.extraJointButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControl)).EndInit();
            this.searchLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMlayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateFromLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateToLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eldingDateLabelLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlStateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl statusLabel;
        private DevExpress.XtraGrid.GridControl gridControlSerchResult;
        private DevExpress.XtraGrid.Views.Grid.GridView resultView;
        private DevExpress.XtraGrid.Columns.GridColumn jointNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn joinStatusGridColumn;
        private DevExpress.XtraEditors.TextEdit pegNumber;
        private DevExpress.XtraLayout.LayoutControl searchLayoutControl;
        private DevExpress.XtraEditors.TextEdit jointNumber;
        private DevExpress.XtraLayout.LayoutControlGroup generalLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem jointNumberLayout;
        private DevExpress.XtraEditors.DateEdit weldingDateFrom;
        private DevExpress.XtraLayout.LayoutControlItem weldingDateFromLayout;
        private DevExpress.XtraLayout.LayoutControlItem controlStateLayout;
        private DevExpress.XtraLayout.LayoutControlItem KMlayout;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraLayout.LayoutControlItem searchButtonLayout;
        private DevExpress.XtraEditors.LabelControl weldingDateLabel;
        private DevExpress.XtraEditors.DateEdit weldingDateTo;
        private DevExpress.XtraLayout.LayoutControlItem weldingDateToLayout;
        private DevExpress.XtraLayout.LayoutControlItem eldingDateLabelLayout;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit extraJointButton;
        private DevExpress.XtraLayout.LayoutControlGroup searchResultLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem searchResultLayout;
        private DevExpress.XtraLayout.LayoutControlGroup searchLayoutGroup;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.CheckedComboBoxEdit controlState;
        private DevExpress.XtraGrid.Columns.GridColumn numberKPCol;
        private DevExpress.XtraGrid.Columns.GridColumn loweringDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn gpsLatCol;
        private DevExpress.XtraGrid.Columns.GridColumn gpsLongCol;
        private DevExpress.XtraGrid.Columns.GridColumn gpsHeightCol;
        private DevExpress.XtraGrid.Columns.GridColumn idCol;
        private DevExpress.XtraGrid.Columns.GridColumn statusLocalizedCol;
        private DevExpress.XtraEditors.ComboBoxEdit activity;
        private DevExpress.XtraLayout.LayoutControlItem activityLayout;

    }
}