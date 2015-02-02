namespace Prizm.Main.Forms.Audit
{
    partial class AuditXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditXtraForm));
            this.searchGroupLayout = new DevExpress.XtraLayout.LayoutControl();
            this.number = new DevExpress.XtraEditors.TextEdit();
            this.radioPeriodUser = new DevExpress.XtraEditors.RadioGroup();
            this.search = new DevExpress.XtraEditors.SimpleButton();
            this.user = new DevExpress.XtraEditors.ComboBoxEdit();
            this.periodLabel = new DevExpress.XtraEditors.LabelControl();
            this.auditResults = new DevExpress.XtraGrid.GridControl();
            this.auditResultsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.userGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.entityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.oldValueGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.newValueGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fieldGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endDate = new DevExpress.XtraEditors.DateEdit();
            this.startDate = new DevExpress.XtraEditors.DateEdit();
            this.generalAuditLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.userLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.searchButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.periodLabelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.endDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.startDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.numberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.auditResultsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.searchGroupLayout)).BeginInit();
            this.searchGroupLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioPeriodUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditResultsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalAuditLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodLabelLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditResultsLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGroupLayout
            // 
            this.searchGroupLayout.Controls.Add(this.number);
            this.searchGroupLayout.Controls.Add(this.radioPeriodUser);
            this.searchGroupLayout.Controls.Add(this.search);
            this.searchGroupLayout.Controls.Add(this.user);
            this.searchGroupLayout.Controls.Add(this.periodLabel);
            this.searchGroupLayout.Controls.Add(this.auditResults);
            this.searchGroupLayout.Controls.Add(this.endDate);
            this.searchGroupLayout.Controls.Add(this.startDate);
            this.searchGroupLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGroupLayout.Location = new System.Drawing.Point(0, 0);
            this.searchGroupLayout.Name = "searchGroupLayout";
            this.searchGroupLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(217, 323, 250, 350);
            this.searchGroupLayout.OptionsView.UseDefaultDragAndDropRendering = false;
            this.searchGroupLayout.Root = this.generalAuditLayoutGroup;
            this.searchGroupLayout.Size = new System.Drawing.Size(796, 436);
            this.searchGroupLayout.TabIndex = 0;
            this.searchGroupLayout.Text = "layoutControl1";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(146, 59);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(200, 20);
            this.number.StyleController = this.searchGroupLayout;
            this.number.TabIndex = 11;
            // 
            // radioPeriodUser
            // 
            this.radioPeriodUser.Location = new System.Drawing.Point(24, 43);
            this.radioPeriodUser.Name = "radioPeriodUser";
            this.radioPeriodUser.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioPeriodUser.Properties.Appearance.Options.UseBackColor = true;
            this.radioPeriodUser.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Номер элемента"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Пользователь")});
            this.radioPeriodUser.Size = new System.Drawing.Size(118, 76);
            this.radioPeriodUser.StyleController = this.searchGroupLayout;
            this.radioPeriodUser.TabIndex = 10;
            this.radioPeriodUser.SelectedIndexChanged += new System.EventHandler(this.tracingModeRadioGroup_SelectedIndexChanged);
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(350, 84);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 22);
            this.search.StyleController = this.searchGroupLayout;
            this.search.TabIndex = 9;
            this.search.Text = "&Поиск";
            // 
            // user
            // 
            this.user.Enabled = false;
            this.user.Location = new System.Drawing.Point(146, 99);
            this.user.Name = "user";
            this.user.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.user.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.user.Size = new System.Drawing.Size(185, 20);
            this.user.StyleController = this.searchGroupLayout;
            this.user.TabIndex = 8;
            // 
            // periodLabel
            // 
            this.periodLabel.Location = new System.Drawing.Point(464, 43);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(152, 13);
            this.periodLabel.StyleController = this.searchGroupLayout;
            this.periodLabel.TabIndex = 7;
            // 
            // auditResults
            // 
            this.auditResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.auditResults.Location = new System.Drawing.Point(12, 135);
            this.auditResults.MainView = this.auditResultsView;
            this.auditResults.Name = "auditResults";
            this.auditResults.Size = new System.Drawing.Size(772, 289);
            this.auditResults.TabIndex = 6;
            this.auditResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.auditResultsView});
            // 
            // auditResultsView
            // 
            this.auditResultsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.userGridColumn,
            this.dateGridColumn,
            this.entityGridColumn,
            this.oldValueGridColumn,
            this.newValueGridColumn,
            this.fieldGridColumn,
            this.numberColumn});
            this.auditResultsView.GridControl = this.auditResults;
            this.auditResultsView.GroupCount = 2;
            this.auditResultsView.Name = "auditResultsView";
            this.auditResultsView.OptionsBehavior.Editable = false;
            this.auditResultsView.OptionsBehavior.FocusLeaveOnTab = true;
            this.auditResultsView.OptionsNavigation.UseTabKey = false;
            this.auditResultsView.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.False;
            this.auditResultsView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.userGridColumn, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.dateGridColumn, DevExpress.Data.ColumnSortOrder.Descending)});
            this.auditResultsView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.auditResultsView_CustomColumnDisplayText);
            // 
            // userGridColumn
            // 
            this.userGridColumn.Caption = "Пользователь";
            this.userGridColumn.FieldName = "User";
            this.userGridColumn.Name = "userGridColumn";
            this.userGridColumn.Visible = true;
            this.userGridColumn.VisibleIndex = 0;
            this.userGridColumn.Width = 125;
            // 
            // dateGridColumn
            // 
            this.dateGridColumn.Caption = "Дата";
            this.dateGridColumn.DisplayFormat.FormatString = "g";
            this.dateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGridColumn.FieldName = "AuditDate";
            this.dateGridColumn.Name = "dateGridColumn";
            this.dateGridColumn.Visible = true;
            this.dateGridColumn.VisibleIndex = 0;
            this.dateGridColumn.Width = 70;
            // 
            // entityGridColumn
            // 
            this.entityGridColumn.Caption = "Изменяемый объект";
            this.entityGridColumn.FieldName = "TableName";
            this.entityGridColumn.Name = "entityGridColumn";
            this.entityGridColumn.Visible = true;
            this.entityGridColumn.VisibleIndex = 0;
            this.entityGridColumn.Width = 137;
            // 
            // oldValueGridColumn
            // 
            this.oldValueGridColumn.Caption = "Старое значение";
            this.oldValueGridColumn.FieldName = "OldValue";
            this.oldValueGridColumn.Name = "oldValueGridColumn";
            this.oldValueGridColumn.Visible = true;
            this.oldValueGridColumn.VisibleIndex = 2;
            this.oldValueGridColumn.Width = 137;
            // 
            // newValueGridColumn
            // 
            this.newValueGridColumn.Caption = "Новое значение";
            this.newValueGridColumn.FieldName = "NewValue";
            this.newValueGridColumn.Name = "newValueGridColumn";
            this.newValueGridColumn.Visible = true;
            this.newValueGridColumn.VisibleIndex = 3;
            this.newValueGridColumn.Width = 148;
            // 
            // fieldGridColumn
            // 
            this.fieldGridColumn.Caption = "Поле";
            this.fieldGridColumn.FieldName = "FieldName";
            this.fieldGridColumn.Name = "fieldGridColumn";
            this.fieldGridColumn.Visible = true;
            this.fieldGridColumn.VisibleIndex = 1;
            this.fieldGridColumn.Width = 137;
            // 
            // numberColumn
            // 
            this.numberColumn.Caption = "Номер элемента";
            this.numberColumn.FieldName = "Number";
            this.numberColumn.Name = "numberColumn";
            this.numberColumn.Visible = true;
            this.numberColumn.VisibleIndex = 4;
            // 
            // endDate
            // 
            this.endDate.EditValue = null;
            this.endDate.Location = new System.Drawing.Point(491, 60);
            this.endDate.Name = "endDate";
            this.endDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDate.Size = new System.Drawing.Size(100, 20);
            this.endDate.StyleController = this.searchGroupLayout;
            this.endDate.TabIndex = 5;
            // 
            // startDate
            // 
            this.startDate.EditValue = null;
            this.startDate.Location = new System.Drawing.Point(364, 60);
            this.startDate.Name = "startDate";
            this.startDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDate.Size = new System.Drawing.Size(100, 20);
            this.startDate.StyleController = this.searchGroupLayout;
            this.startDate.TabIndex = 4;
            // 
            // generalAuditLayoutGroup
            // 
            this.generalAuditLayoutGroup.CustomizationFormText = "Root";
            this.generalAuditLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalAuditLayoutGroup.GroupBordersVisible = false;
            this.generalAuditLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchParametersLayoutGroup,
            this.auditResultsLayout});
            this.generalAuditLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalAuditLayoutGroup.Name = "Root";
            this.generalAuditLayoutGroup.Size = new System.Drawing.Size(796, 436);
            this.generalAuditLayoutGroup.TextVisible = false;
            // 
            // searchParametersLayoutGroup
            // 
            this.searchParametersLayoutGroup.CustomizationFormText = "Параметры поиска";
            this.searchParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.userLayout,
            this.searchEmptySpace,
            this.searchButtonLayout,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.periodLabelLayout,
            this.startDateLayout,
            this.endDateLayout,
            this.numberLayout});
            this.searchParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.searchParametersLayoutGroup.Name = "searchParametersLayoutGroup";
            this.searchParametersLayoutGroup.Size = new System.Drawing.Size(776, 123);
            this.searchParametersLayoutGroup.Text = "Параметры поиска";
            // 
            // userLayout
            // 
            this.userLayout.Control = this.user;
            this.userLayout.CustomizationFormText = "По&льзователь";
            this.userLayout.Location = new System.Drawing.Point(122, 40);
            this.userLayout.MinSize = new System.Drawing.Size(204, 40);
            this.userLayout.Name = "userLayout";
            this.userLayout.Size = new System.Drawing.Size(204, 40);
            this.userLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.userLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 0);
            this.userLayout.Text = "Пользователь";
            this.userLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.userLayout.TextSize = new System.Drawing.Size(81, 13);
            // 
            // searchEmptySpace
            // 
            this.searchEmptySpace.AllowHotTrack = false;
            this.searchEmptySpace.CustomizationFormText = "searchEmptySpace";
            this.searchEmptySpace.Location = new System.Drawing.Point(596, 0);
            this.searchEmptySpace.Name = "searchEmptySpace";
            this.searchEmptySpace.Size = new System.Drawing.Size(156, 80);
            this.searchEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // searchButtonLayout
            // 
            this.searchButtonLayout.Control = this.search;
            this.searchButtonLayout.CustomizationFormText = "searchButtonLayout";
            this.searchButtonLayout.Location = new System.Drawing.Point(326, 41);
            this.searchButtonLayout.MaxSize = new System.Drawing.Size(104, 26);
            this.searchButtonLayout.MinSize = new System.Drawing.Size(104, 26);
            this.searchButtonLayout.Name = "searchButtonLayout";
            this.searchButtonLayout.Size = new System.Drawing.Size(270, 39);
            this.searchButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.searchButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchButtonLayout.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(586, 17);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // periodLabelLayout
            // 
            this.periodLabelLayout.Control = this.periodLabel;
            this.periodLabelLayout.CustomizationFormText = "periodLabelLayout";
            this.periodLabelLayout.Location = new System.Drawing.Point(326, 0);
            this.periodLabelLayout.Name = "periodLabelLayout";
            this.periodLabelLayout.Size = new System.Drawing.Size(270, 17);
            this.periodLabelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(30, 0, 0, 0);
            this.periodLabelLayout.Text = "За период";
            this.periodLabelLayout.TextSize = new System.Drawing.Size(81, 13);
            // 
            // endDateLayout
            // 
            this.endDateLayout.Control = this.endDate;
            this.endDateLayout.CustomizationFormText = "По";
            this.endDateLayout.Location = new System.Drawing.Point(444, 17);
            this.endDateLayout.MaxSize = new System.Drawing.Size(142, 24);
            this.endDateLayout.MinSize = new System.Drawing.Size(142, 24);
            this.endDateLayout.Name = "endDateLayout";
            this.endDateLayout.Size = new System.Drawing.Size(142, 24);
            this.endDateLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.endDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 15, 0, 0);
            this.endDateLayout.Text = "По";
            this.endDateLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.endDateLayout.TextSize = new System.Drawing.Size(13, 13);
            this.endDateLayout.TextToControlDistance = 5;
            // 
            // startDateLayout
            // 
            this.startDateLayout.Control = this.startDate;
            this.startDateLayout.CustomizationFormText = "&С";
            this.startDateLayout.Location = new System.Drawing.Point(326, 17);
            this.startDateLayout.MaxSize = new System.Drawing.Size(118, 24);
            this.startDateLayout.MinSize = new System.Drawing.Size(118, 24);
            this.startDateLayout.Name = "startDateLayout";
            this.startDateLayout.Size = new System.Drawing.Size(118, 24);
            this.startDateLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.startDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 0, 0, 0);
            this.startDateLayout.Text = "С";
            this.startDateLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.startDateLayout.TextSize = new System.Drawing.Size(7, 13);
            this.startDateLayout.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radioPeriodUser;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(122, 80);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // numberLayout
            // 
            this.numberLayout.Control = this.number;
            this.numberLayout.CustomizationFormText = "Номер элемента";
            this.numberLayout.Location = new System.Drawing.Point(122, 0);
            this.numberLayout.Name = "numberLayout";
            this.numberLayout.Size = new System.Drawing.Size(204, 40);
            this.numberLayout.Text = "Номер элемента";
            this.numberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.numberLayout.TextSize = new System.Drawing.Size(81, 13);
            // 
            // auditResultsLayout
            // 
            this.auditResultsLayout.Control = this.auditResults;
            this.auditResultsLayout.CustomizationFormText = "auditResultsLayout";
            this.auditResultsLayout.Location = new System.Drawing.Point(0, 123);
            this.auditResultsLayout.Name = "auditResultsLayout";
            this.auditResultsLayout.Size = new System.Drawing.Size(776, 293);
            this.auditResultsLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.auditResultsLayout.TextSize = new System.Drawing.Size(0, 0);
            this.auditResultsLayout.TextVisible = false;
            // 
            // AuditXtraForm
            // 
            this.AcceptButton = this.search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 436);
            this.Controls.Add(this.searchGroupLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuditXtraForm";
            this.Text = "Аудит";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuditXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.AuditXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchGroupLayout)).EndInit();
            this.searchGroupLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioPeriodUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditResultsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalAuditLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodLabelLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditResultsLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl searchGroupLayout;
        private DevExpress.XtraLayout.LayoutControlGroup generalAuditLayoutGroup;
        private DevExpress.XtraEditors.DateEdit startDate;
        private DevExpress.XtraLayout.LayoutControlItem startDateLayout;
        private DevExpress.XtraGrid.GridControl auditResults;
        private DevExpress.XtraGrid.Views.Grid.GridView auditResultsView;
        private DevExpress.XtraEditors.DateEdit endDate;
        private DevExpress.XtraLayout.LayoutControlGroup searchParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem endDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem auditResultsLayout;
        private DevExpress.XtraEditors.LabelControl periodLabel;
        private DevExpress.XtraLayout.LayoutControlItem periodLabelLayout;
        private DevExpress.XtraEditors.ComboBoxEdit user;
        private DevExpress.XtraLayout.LayoutControlItem userLayout;
        private DevExpress.XtraLayout.EmptySpaceItem searchEmptySpace;
        private DevExpress.XtraEditors.SimpleButton search;
        private DevExpress.XtraLayout.LayoutControlItem searchButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn userGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn dateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn oldValueGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn newValueGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn entityGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn fieldGridColumn;
        private DevExpress.XtraEditors.RadioGroup radioPeriodUser;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem numberLayout;
        private DevExpress.XtraGrid.Columns.GridColumn numberColumn;
        private DevExpress.XtraEditors.TextEdit number;
    }
}