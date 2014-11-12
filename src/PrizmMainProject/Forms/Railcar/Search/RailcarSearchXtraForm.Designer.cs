namespace PrizmMain.Forms.Railcar.Search
{
    partial class RailcarSearchXtraForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RailcarSearchXtraForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.openRailcarButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.shipButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.unshipButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.railcarList = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.railcarListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.editGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shippingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shipGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unshipGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.generalLayout = new DevExpress.XtraLayout.LayoutControl();
            this.shippedDate = new DevExpress.XtraEditors.DateEdit();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.railcarNumber = new DevExpress.XtraEditors.TextEdit();
            this.destination = new DevExpress.XtraEditors.TextEdit();
            this.generalLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.destinationLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.shippedDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.railcarNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchLayoutGroupEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.resultParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.railcarsListLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.openRailcarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unshipButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).BeginInit();
            this.generalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destination.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutGroupEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarsListLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // openRailcarButton
            // 
            this.openRailcarButton.AutoHeight = false;
            this.openRailcarButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "view railcar", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("openRailcarButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.openRailcarButton.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.openRailcarButton.Name = "openRailcarButton";
            this.openRailcarButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // shipButton
            // 
            this.shipButton.AutoHeight = false;
            this.shipButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("shipButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.shipButton.Name = "shipButton";
            this.shipButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // unshipButton
            // 
            this.unshipButton.AutoHeight = false;
            this.unshipButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("unshipButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.unshipButton.Name = "unshipButton";
            this.unshipButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // railcarList
            // 
            this.railcarList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.railcarList.Cursor = System.Windows.Forms.Cursors.Default;
            this.railcarList.DataSource = this.bindingSource;
            this.railcarList.Location = new System.Drawing.Point(27, 148);
            this.railcarList.MainView = this.railcarListView;
            this.railcarList.Name = "railcarList";
            this.railcarList.Size = new System.Drawing.Size(1211, 363);
            this.railcarList.TabIndex = 1;
            this.railcarList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.railcarListView});
            // 
            // railcarListView
            // 
            this.railcarListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.editGridColumn,
            this.number,
            this.dest,
            this.certificate,
            this.shippingDate,
            this.shipGridColumn,
            this.unshipGridColumn});
            this.railcarListView.GridControl = this.railcarList;
            this.railcarListView.Name = "railcarListView";
            this.railcarListView.OptionsBehavior.Editable = false;
            this.railcarListView.OptionsView.ShowGroupPanel = false;
            this.railcarListView.DoubleClick += new System.EventHandler(this.railcarListView_DoubleClick);
            // 
            // editGridColumn
            // 
            this.editGridColumn.ColumnEdit = this.openRailcarButton;
            this.editGridColumn.MaxWidth = 30;
            this.editGridColumn.Name = "editGridColumn";
            this.editGridColumn.Visible = true;
            this.editGridColumn.VisibleIndex = 0;
            this.editGridColumn.Width = 30;
            // 
            // number
            // 
            this.number.Caption = "Номер";
            this.number.FieldName = "Number";
            this.number.Name = "number";
            this.number.Visible = true;
            this.number.VisibleIndex = 1;
            // 
            // certificate
            // 
            this.certificate.Caption = "Сертификат";
            this.certificate.FieldName = "Certificate";
            this.certificate.Name = "certificate";
            this.certificate.Visible = true;
            this.certificate.VisibleIndex = 2;
            // 
            // dest
            // 
            this.dest.Caption = "Назначение";
            this.dest.FieldName = "Destination";
            this.dest.Name = "dest";
            this.dest.Visible = true;
            this.dest.VisibleIndex = 3;
            // 
            // shippingDate
            // 
            this.shippingDate.Caption = "Дата формирования";
            this.shippingDate.FieldName = "ShippingDate";
            this.shippingDate.MaxWidth = 150;
            this.shippingDate.Name = "shippingDate";
            this.shippingDate.Visible = true;
            this.shippingDate.VisibleIndex = 4;
            this.shippingDate.Width = 70;
            // 
            // shipGridColumn
            // 
            this.shipGridColumn.ColumnEdit = this.shipButton;
            this.shipGridColumn.MaxWidth = 30;
            this.shipGridColumn.Name = "shipGridColumn";
            this.shipGridColumn.Visible = true;
            this.shipGridColumn.VisibleIndex = 5;
            this.shipGridColumn.Width = 30;
            // 
            // unshipGridColumn
            // 
            this.unshipGridColumn.ColumnEdit = this.unshipButton;
            this.unshipGridColumn.MaxWidth = 30;
            this.unshipGridColumn.Name = "unshipGridColumn";
            this.unshipGridColumn.Visible = true;
            this.unshipGridColumn.VisibleIndex = 6;
            this.unshipGridColumn.Width = 30;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.searchButton.Location = new System.Drawing.Point(777, 60);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 22);
            this.searchButton.StyleController = this.generalLayout;
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Поиск";
            // 
            // generalLayout
            // 
            this.generalLayout.Controls.Add(this.railcarList);
            this.generalLayout.Controls.Add(this.searchButton);
            this.generalLayout.Controls.Add(this.shippedDate);
            this.generalLayout.Controls.Add(this.certificateNumber);
            this.generalLayout.Controls.Add(this.railcarNumber);
            this.generalLayout.Controls.Add(this.destination);
            this.generalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalLayout.Location = new System.Drawing.Point(5, 5);
            this.generalLayout.Name = "generalLayout";
            this.generalLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(288, 412, 250, 350);
            this.generalLayout.Root = this.generalLayoutGroup;
            this.generalLayout.ShowTemplates = true;
            this.generalLayout.Size = new System.Drawing.Size(1265, 540);
            this.generalLayout.TabIndex = 30;
            this.generalLayout.Text = "layoutControl1";
            // 
            // shippedDate
            // 
            this.shippedDate.EditValue = null;
            this.shippedDate.Location = new System.Drawing.Point(625, 61);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Size = new System.Drawing.Size(136, 20);
            this.shippedDate.StyleController = this.generalLayout;
            this.shippedDate.TabIndex = 12;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(426, 61);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(185, 20);
            this.certificateNumber.StyleController = this.generalLayout;
            this.certificateNumber.TabIndex = 14;
            // 
            // railcarNumber
            // 
            this.railcarNumber.Location = new System.Drawing.Point(27, 61);
            this.railcarNumber.Margin = new System.Windows.Forms.Padding(10);
            this.railcarNumber.Name = "railcarNumber";
            this.railcarNumber.Size = new System.Drawing.Size(136, 20);
            this.railcarNumber.StyleController = this.generalLayout;
            this.railcarNumber.TabIndex = 7;
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(177, 61);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(235, 20);
            this.destination.StyleController = this.generalLayout;
            this.destination.TabIndex = 3;
            // 
            // generalLayoutGroup
            // 
            this.generalLayoutGroup.CustomizationFormText = "generalLayoutGroup";
            this.generalLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalLayoutGroup.GroupBordersVisible = false;
            this.generalLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchParametersLayoutGroup,
            this.resultParametersLayoutGroup});
            this.generalLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalLayoutGroup.Name = "generalLayoutGroup";
            this.generalLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(7, 7, 7, 5);
            this.generalLayoutGroup.Size = new System.Drawing.Size(1265, 540);
            this.generalLayoutGroup.Text = "generalLayoutGroup";
            this.generalLayoutGroup.TextVisible = false;
            // 
            // searchParametersLayoutGroup
            // 
            this.searchParametersLayoutGroup.CustomizationFormText = "Параметры поиска";
            this.searchParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.destinationLayout,
            this.shippedDateLayout,
            this.certificateNumberLayout,
            this.searchButtonLayout,
            this.railcarNumberLayout,
            this.searchLayoutGroupEmptySpace});
            this.searchParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.searchParametersLayoutGroup.Name = "searchParametersLayoutGroup";
            this.searchParametersLayoutGroup.Size = new System.Drawing.Size(1251, 98);
            this.searchParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 7, 7);
            this.searchParametersLayoutGroup.Text = "Параметры поиска";
            // 
            // destinationLayout
            // 
            this.destinationLayout.Control = this.destination;
            this.destinationLayout.CustomizationFormText = "Destination";
            this.destinationLayout.Location = new System.Drawing.Point(150, 0);
            this.destinationLayout.Name = "destinationLayout";
            this.destinationLayout.Size = new System.Drawing.Size(249, 45);
            this.destinationLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 5);
            this.destinationLayout.Text = "&Получатель";
            this.destinationLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.destinationLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // shippedDateLayout
            // 
            this.shippedDateLayout.Control = this.shippedDate;
            this.shippedDateLayout.CustomizationFormText = "Shipped date";
            this.shippedDateLayout.Location = new System.Drawing.Point(598, 0);
            this.shippedDateLayout.Name = "shippedDateLayout";
            this.shippedDateLayout.Size = new System.Drawing.Size(150, 45);
            this.shippedDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 5);
            this.shippedDateLayout.Text = "&Дата отгрузки";
            this.shippedDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.shippedDateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // certificateNumberLayout
            // 
            this.certificateNumberLayout.Control = this.certificateNumber;
            this.certificateNumberLayout.CustomizationFormText = "Certificate number";
            this.certificateNumberLayout.Location = new System.Drawing.Point(399, 0);
            this.certificateNumberLayout.Name = "certificateNumberLayout";
            this.certificateNumberLayout.Size = new System.Drawing.Size(199, 45);
            this.certificateNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 5);
            this.certificateNumberLayout.Text = "Номер &сертификата";
            this.certificateNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // searchButtonLayout
            // 
            this.searchButtonLayout.Control = this.searchButton;
            this.searchButtonLayout.ControlAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.searchButtonLayout.CustomizationFormText = "searchButtonLayout";
            this.searchButtonLayout.Location = new System.Drawing.Point(748, 0);
            this.searchButtonLayout.Name = "searchButtonLayout";
            this.searchButtonLayout.Size = new System.Drawing.Size(113, 45);
            this.searchButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 0, 15, 0);
            this.searchButtonLayout.Text = "searchButtonLayout";
            this.searchButtonLayout.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.searchButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchButtonLayout.TextToControlDistance = 0;
            this.searchButtonLayout.TextVisible = false;
            // 
            // railcarNumberLayout
            // 
            this.railcarNumberLayout.Control = this.railcarNumber;
            this.railcarNumberLayout.CustomizationFormText = "Railcar number";
            this.railcarNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.railcarNumberLayout.Name = "railcarNumberLayout";
            this.railcarNumberLayout.Size = new System.Drawing.Size(150, 45);
            this.railcarNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 5);
            this.railcarNumberLayout.Text = "&Номер вагона";
            this.railcarNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.railcarNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // searchLayoutGroupEmptySpace
            // 
            this.searchLayoutGroupEmptySpace.AllowHotTrack = false;
            this.searchLayoutGroupEmptySpace.CustomizationFormText = "searchLayoutGroupEmptySpace";
            this.searchLayoutGroupEmptySpace.Location = new System.Drawing.Point(861, 0);
            this.searchLayoutGroupEmptySpace.Name = "searchLayoutGroupEmptySpace";
            this.searchLayoutGroupEmptySpace.Size = new System.Drawing.Size(364, 45);
            this.searchLayoutGroupEmptySpace.Text = "searchLayoutGroupEmptySpace";
            this.searchLayoutGroupEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // resultParametersLayoutGroup
            // 
            this.resultParametersLayoutGroup.CustomizationFormText = "Результаты поиска";
            this.resultParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.railcarsListLayout});
            this.resultParametersLayoutGroup.Location = new System.Drawing.Point(0, 98);
            this.resultParametersLayoutGroup.Name = "resultParametersLayoutGroup";
            this.resultParametersLayoutGroup.Size = new System.Drawing.Size(1251, 430);
            this.resultParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 7, 7);
            this.resultParametersLayoutGroup.Text = "Результаты поиска";
            // 
            // railcarsListLayout
            // 
            this.railcarsListLayout.Control = this.railcarList;
            this.railcarsListLayout.CustomizationFormText = "railcarsListLayout";
            this.railcarsListLayout.Location = new System.Drawing.Point(0, 0);
            this.railcarsListLayout.Name = "railcarsListLayout";
            this.railcarsListLayout.Size = new System.Drawing.Size(1225, 377);
            this.railcarsListLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.railcarsListLayout.Text = "railcarsListLayout";
            this.railcarsListLayout.TextSize = new System.Drawing.Size(0, 0);
            this.railcarsListLayout.TextToControlDistance = 0;
            this.railcarsListLayout.TextVisible = false;
            // 
            // RailcarSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 550);
            this.Controls.Add(this.generalLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RailcarSearchXtraForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Find railcars";
            this.Load += new System.EventHandler(this.RailcarSearchXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openRailcarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unshipButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).EndInit();
            this.generalLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destination.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutGroupEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarsListLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl railcarList;
        private DevExpress.XtraGrid.Views.Grid.GridView railcarListView;
        private DevExpress.XtraGrid.Columns.GridColumn editGridColumn;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraGrid.Columns.GridColumn shipGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn unshipGridColumn;
        private DevExpress.XtraLayout.LayoutControl generalLayout;
        private DevExpress.XtraEditors.DateEdit shippedDate;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraLayout.LayoutControlGroup generalLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem certificateNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem railcarNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem destinationLayout;
        private DevExpress.XtraLayout.LayoutControlItem shippedDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem searchButtonLayout;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit openRailcarButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit shipButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit unshipButton;
        private DevExpress.XtraLayout.LayoutControlItem railcarsListLayout;
        private DevExpress.XtraLayout.LayoutControlGroup searchParametersLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem searchLayoutGroupEmptySpace;
        private DevExpress.XtraLayout.LayoutControlGroup resultParametersLayoutGroup;
        private DevExpress.XtraEditors.TextEdit railcarNumber;
        private DevExpress.XtraEditors.TextEdit destination;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn number;
        private DevExpress.XtraGrid.Columns.GridColumn certificate;
        private DevExpress.XtraGrid.Columns.GridColumn dest;
        private DevExpress.XtraGrid.Columns.GridColumn shippingDate;
    }
}