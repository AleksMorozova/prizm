namespace PrizmMain.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RailcarSearchXtraForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.openRailcarButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.shipButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.unshipButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.railcarList = new DevExpress.XtraGrid.GridControl();
            this.railcarListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.railcarNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shippingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shipGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unshipGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.generalLayout = new DevExpress.XtraLayout.LayoutControl();
            this.shippedDate = new DevExpress.XtraEditors.DateEdit();
            this.railcarNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.destination = new DevExpress.XtraEditors.ComboBoxEdit();
            this.generalLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.railcarNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.destinationLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.shippedDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.resultParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchLayoutGroupEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.searchButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.openRailcarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unshipButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).BeginInit();
            this.generalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destination.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutGroupEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonEmptySpace)).BeginInit();
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
            this.railcarList.Location = new System.Drawing.Point(21, 139);
            this.railcarList.MainView = this.railcarListView;
            this.railcarList.Name = "railcarList";
            this.railcarList.Size = new System.Drawing.Size(1213, 378);
            this.railcarList.TabIndex = 1;
            this.railcarList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.railcarListView});
            // 
            // railcarListView
            // 
            this.railcarListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.railcarNumberGridColumn,
            this.statusGridColumn,
            this.shippingDateGridColumn,
            this.editGridColumn,
            this.shipGridColumn,
            this.unshipGridColumn});
            this.railcarListView.GridControl = this.railcarList;
            this.railcarListView.Name = "railcarListView";
            this.railcarListView.OptionsView.ShowGroupPanel = false;
            // 
            // railcarNumberGridColumn
            // 
            this.railcarNumberGridColumn.Caption = "Номер вагона";
            this.railcarNumberGridColumn.FieldName = "RailcarNumber";
            this.railcarNumberGridColumn.Name = "railcarNumberGridColumn";
            this.railcarNumberGridColumn.Visible = true;
            this.railcarNumberGridColumn.VisibleIndex = 0;
            this.railcarNumberGridColumn.Width = 158;
            // 
            // statusGridColumn
            // 
            this.statusGridColumn.Caption = "Статус";
            this.statusGridColumn.FieldName = "Status";
            this.statusGridColumn.Name = "statusGridColumn";
            this.statusGridColumn.Visible = true;
            this.statusGridColumn.VisibleIndex = 1;
            this.statusGridColumn.Width = 158;
            // 
            // shippingDateGridColumn
            // 
            this.shippingDateGridColumn.Caption = "Дата отгрузки";
            this.shippingDateGridColumn.FieldName = "ShipingDate";
            this.shippingDateGridColumn.Name = "shippingDateGridColumn";
            this.shippingDateGridColumn.Visible = true;
            this.shippingDateGridColumn.VisibleIndex = 2;
            this.shippingDateGridColumn.Width = 158;
            // 
            // editGridColumn
            // 
            this.editGridColumn.ColumnEdit = this.openRailcarButton;
            this.editGridColumn.Name = "editGridColumn";
            this.editGridColumn.Visible = true;
            this.editGridColumn.VisibleIndex = 3;
            this.editGridColumn.Width = 45;
            // 
            // shipGridColumn
            // 
            this.shipGridColumn.ColumnEdit = this.shipButton;
            this.shipGridColumn.Name = "shipGridColumn";
            this.shipGridColumn.Visible = true;
            this.shipGridColumn.VisibleIndex = 4;
            this.shipGridColumn.Width = 45;
            // 
            // unshipGridColumn
            // 
            this.unshipGridColumn.ColumnEdit = this.unshipButton;
            this.unshipGridColumn.Name = "unshipGridColumn";
            this.unshipGridColumn.Visible = true;
            this.unshipGridColumn.VisibleIndex = 5;
            this.unshipGridColumn.Width = 45;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.searchButton.Location = new System.Drawing.Point(786, 56);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 22);
            this.searchButton.StyleController = this.generalLayout;
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Поиск";
            // 
            // generalLayout
            // 
            this.generalLayout.Controls.Add(this.railcarList);
            this.generalLayout.Controls.Add(this.searchButton);
            this.generalLayout.Controls.Add(this.shippedDate);
            this.generalLayout.Controls.Add(this.railcarNumber);
            this.generalLayout.Controls.Add(this.certificateNumber);
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
            this.shippedDate.Location = new System.Drawing.Point(636, 58);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Size = new System.Drawing.Size(116, 20);
            this.shippedDate.StyleController = this.generalLayout;
            this.shippedDate.TabIndex = 12;
            // 
            // railcarNumber
            // 
            this.railcarNumber.Location = new System.Drawing.Point(21, 58);
            this.railcarNumber.Margin = new System.Windows.Forms.Padding(10);
            this.railcarNumber.Name = "railcarNumber";
            this.railcarNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.railcarNumber.Size = new System.Drawing.Size(181, 20);
            this.railcarNumber.StyleController = this.generalLayout;
            this.railcarNumber.TabIndex = 7;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(436, 58);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(166, 20);
            this.certificateNumber.StyleController = this.generalLayout;
            this.certificateNumber.TabIndex = 14;
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(236, 58);
            this.destination.Name = "destination";
            this.destination.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.destination.Size = new System.Drawing.Size(166, 20);
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
            this.generalLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.generalLayoutGroup.Size = new System.Drawing.Size(1265, 540);
            this.generalLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0);
            this.generalLayoutGroup.Text = "generalLayoutGroup";
            this.generalLayoutGroup.TextVisible = false;
            // 
            // railcarNumberLayout
            // 
            this.railcarNumberLayout.Control = this.railcarNumber;
            this.railcarNumberLayout.CustomizationFormText = "Railcar number";
            this.railcarNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.railcarNumberLayout.Name = "railcarNumberLayout";
            this.railcarNumberLayout.Size = new System.Drawing.Size(200, 54);
            this.railcarNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 7);
            this.railcarNumberLayout.Text = "&Номер вагона";
            this.railcarNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.railcarNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // destinationLayout
            // 
            this.destinationLayout.Control = this.destination;
            this.destinationLayout.CustomizationFormText = "Destination";
            this.destinationLayout.Location = new System.Drawing.Point(200, 0);
            this.destinationLayout.Name = "destinationLayout";
            this.destinationLayout.Size = new System.Drawing.Size(200, 54);
            this.destinationLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.destinationLayout.Text = "&Получатель";
            this.destinationLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.destinationLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // searchButtonLayout
            // 
            this.searchButtonLayout.Control = this.searchButton;
            this.searchButtonLayout.ControlAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.searchButtonLayout.CustomizationFormText = "searchButtonLayout";
            this.searchButtonLayout.Location = new System.Drawing.Point(750, 14);
            this.searchButtonLayout.Name = "searchButtonLayout";
            this.searchButtonLayout.Size = new System.Drawing.Size(114, 40);
            this.searchButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.searchButtonLayout.Text = "searchButtonLayout";
            this.searchButtonLayout.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.searchButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchButtonLayout.TextToControlDistance = 0;
            this.searchButtonLayout.TextVisible = false;
            // 
            // certificateNumberLayout
            // 
            this.certificateNumberLayout.Control = this.certificateNumber;
            this.certificateNumberLayout.CustomizationFormText = "Certificate number";
            this.certificateNumberLayout.Location = new System.Drawing.Point(400, 0);
            this.certificateNumberLayout.Name = "certificateNumberLayout";
            this.certificateNumberLayout.Size = new System.Drawing.Size(200, 54);
            this.certificateNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.certificateNumberLayout.Text = "Номер &сертификата";
            this.certificateNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // shippedDateLayout
            // 
            this.shippedDateLayout.Control = this.shippedDate;
            this.shippedDateLayout.CustomizationFormText = "Shipped date";
            this.shippedDateLayout.Location = new System.Drawing.Point(600, 0);
            this.shippedDateLayout.Name = "shippedDateLayout";
            this.shippedDateLayout.Size = new System.Drawing.Size(150, 54);
            this.shippedDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.shippedDateLayout.Text = "&Дата отгрузки";
            this.shippedDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.shippedDateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.railcarList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1232, 396);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 7);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
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
            this.searchButtonEmptySpace,
            this.searchLayoutGroupEmptySpace});
            this.searchParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.searchParametersLayoutGroup.Name = "searchParametersLayoutGroup";
            this.searchParametersLayoutGroup.Size = new System.Drawing.Size(1256, 97);
            this.searchParametersLayoutGroup.Text = "Параметры поиска";
            // 
            // resultParametersLayoutGroup
            // 
            this.resultParametersLayoutGroup.CustomizationFormText = "Результаты поиска";
            this.resultParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.resultParametersLayoutGroup.Location = new System.Drawing.Point(0, 97);
            this.resultParametersLayoutGroup.Name = "resultParametersLayoutGroup";
            this.resultParametersLayoutGroup.Size = new System.Drawing.Size(1256, 439);
            this.resultParametersLayoutGroup.Text = "Результаты поиска";
            // 
            // searchLayoutGroupEmptySpace
            // 
            this.searchLayoutGroupEmptySpace.AllowHotTrack = false;
            this.searchLayoutGroupEmptySpace.CustomizationFormText = "searchLayoutGroupEmptySpace";
            this.searchLayoutGroupEmptySpace.Location = new System.Drawing.Point(864, 0);
            this.searchLayoutGroupEmptySpace.Name = "searchLayoutGroupEmptySpace";
            this.searchLayoutGroupEmptySpace.Size = new System.Drawing.Size(368, 54);
            this.searchLayoutGroupEmptySpace.Text = "searchLayoutGroupEmptySpace";
            this.searchLayoutGroupEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // searchButtonEmptySpace
            // 
            this.searchButtonEmptySpace.AllowHotTrack = false;
            this.searchButtonEmptySpace.CustomizationFormText = "searchButtonEmptySpace";
            this.searchButtonEmptySpace.Location = new System.Drawing.Point(750, 0);
            this.searchButtonEmptySpace.Name = "searchButtonEmptySpace";
            this.searchButtonEmptySpace.Size = new System.Drawing.Size(114, 14);
            this.searchButtonEmptySpace.Text = "searchButtonEmptySpace";
            this.searchButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.openRailcarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unshipButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).EndInit();
            this.generalLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destination.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutGroupEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonEmptySpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl railcarList;
        private DevExpress.XtraGrid.Views.Grid.GridView railcarListView;
        private DevExpress.XtraGrid.Columns.GridColumn railcarNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn statusGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn shippingDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn editGridColumn;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraGrid.Columns.GridColumn shipGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn unshipGridColumn;
        private DevExpress.XtraLayout.LayoutControl generalLayout;
        private DevExpress.XtraEditors.DateEdit shippedDate;
        private DevExpress.XtraEditors.ComboBoxEdit railcarNumber;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraEditors.ComboBoxEdit destination;
        private DevExpress.XtraLayout.LayoutControlGroup generalLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem certificateNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem railcarNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem destinationLayout;
        private DevExpress.XtraLayout.LayoutControlItem shippedDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem searchButtonLayout;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit openRailcarButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit shipButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit unshipButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup searchParametersLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem searchLayoutGroupEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem searchButtonEmptySpace;
        private DevExpress.XtraLayout.LayoutControlGroup resultParametersLayoutGroup;
    }
}