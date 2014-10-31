namespace PrizmMain.Forms
{
    partial class RailcarNewEditXtraForm
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
            this.pipesList = new DevExpress.XtraGrid.GridControl();
            this.pipesListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeSizeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeStatusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unshipButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.generalLayout = new DevExpress.XtraLayout.LayoutControl();
            this.shippedDate = new DevExpress.XtraEditors.DateEdit();
            this.railcarNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.destination = new DevExpress.XtraEditors.ComboBoxEdit();
            this.railcarLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.railcarNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.shippedDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.destinationLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeListLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.shipButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pipesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).BeginInit();
            this.generalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destination.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeListLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // pipesList
            // 
            this.pipesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pipesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipesList.Location = new System.Drawing.Point(20, 65);
            this.pipesList.MainView = this.pipesListView;
            this.pipesList.Name = "pipesList";
            this.pipesList.Size = new System.Drawing.Size(1228, 374);
            this.pipesList.TabIndex = 8;
            this.pipesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipesListView});
            // 
            // pipesListView
            // 
            this.pipesListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeNumberGridColumn,
            this.pipeSizeGridColumn,
            this.pipeStatusGridColumn});
            this.pipesListView.GridControl = this.pipesList;
            this.pipesListView.Name = "pipesListView";
            this.pipesListView.OptionsView.ShowGroupPanel = false;
            // 
            // pipeNumberGridColumn
            // 
            this.pipeNumberGridColumn.Caption = "Номер вагона";
            this.pipeNumberGridColumn.FieldName = "PipeNumber";
            this.pipeNumberGridColumn.Name = "pipeNumberGridColumn";
            this.pipeNumberGridColumn.Visible = true;
            this.pipeNumberGridColumn.VisibleIndex = 0;
            // 
            // pipeSizeGridColumn
            // 
            this.pipeSizeGridColumn.Caption = "Размер трубы";
            this.pipeSizeGridColumn.FieldName = "Size";
            this.pipeSizeGridColumn.Name = "pipeSizeGridColumn";
            this.pipeSizeGridColumn.Visible = true;
            this.pipeSizeGridColumn.VisibleIndex = 1;
            // 
            // pipeStatusGridColumn
            // 
            this.pipeStatusGridColumn.Caption = "Статус";
            this.pipeStatusGridColumn.FieldName = "Status";
            this.pipeStatusGridColumn.Name = "pipeStatusGridColumn";
            this.pipeStatusGridColumn.Visible = true;
            this.pipeStatusGridColumn.VisibleIndex = 2;
            // 
            // unshipButton
            // 
            this.unshipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unshipButton.Location = new System.Drawing.Point(1087, 472);
            this.unshipButton.Name = "unshipButton";
            this.unshipButton.Size = new System.Drawing.Size(75, 23);
            this.unshipButton.TabIndex = 15;
            this.unshipButton.Text = "Отклонить";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(1188, 472);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            // 
            // generalLayout
            // 
            this.generalLayout.Controls.Add(this.pipesList);
            this.generalLayout.Controls.Add(this.shippedDate);
            this.generalLayout.Controls.Add(this.railcarNumber);
            this.generalLayout.Controls.Add(this.certificateNumber);
            this.generalLayout.Controls.Add(this.destination);
            this.generalLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalLayout.Location = new System.Drawing.Point(0, 0);
            this.generalLayout.Name = "generalLayout";
            this.generalLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(340, 277, 250, 350);
            this.generalLayout.Root = this.railcarLayoutGroup;
            this.generalLayout.ShowTemplates = true;
            this.generalLayout.Size = new System.Drawing.Size(1275, 450);
            this.generalLayout.TabIndex = 20;
            this.generalLayout.Text = "layoutControl1";
            // 
            // shippedDate
            // 
            this.shippedDate.EditValue = null;
            this.shippedDate.Location = new System.Drawing.Point(235, 27);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Size = new System.Drawing.Size(101, 20);
            this.shippedDate.StyleController = this.generalLayout;
            this.shippedDate.TabIndex = 12;
            // 
            // railcarNumber
            // 
            this.railcarNumber.Location = new System.Drawing.Point(18, 25);
            this.railcarNumber.Name = "railcarNumber";
            this.railcarNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.railcarNumber.Size = new System.Drawing.Size(185, 20);
            this.railcarNumber.StyleController = this.generalLayout;
            this.railcarNumber.TabIndex = 7;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(620, 27);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(166, 20);
            this.certificateNumber.StyleController = this.generalLayout;
            this.certificateNumber.TabIndex = 14;
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(370, 27);
            this.destination.Name = "destination";
            this.destination.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.destination.Size = new System.Drawing.Size(216, 20);
            this.destination.StyleController = this.generalLayout;
            this.destination.TabIndex = 3;
            // 
            // railcarLayoutGroup
            // 
            this.railcarLayoutGroup.CustomizationFormText = "railcarLayoutGroup";
            this.railcarLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.railcarLayoutGroup.GroupBordersVisible = false;
            this.railcarLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.railcarNumberLayout,
            this.shippedDateLayout,
            this.destinationLayout,
            this.certificateNumberLayout,
            this.pipeListLayout,
            this.emptySpaceItem1});
            this.railcarLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.railcarLayoutGroup.Name = "railcarLayoutGroup";
            this.railcarLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.railcarLayoutGroup.Size = new System.Drawing.Size(1275, 450);
            this.railcarLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(16, 8, 0, 0);
            this.railcarLayoutGroup.Text = "railcarLayoutGroup";
            this.railcarLayoutGroup.TextVisible = false;
            // 
            // railcarNumberLayout
            // 
            this.railcarNumberLayout.Control = this.railcarNumber;
            this.railcarNumberLayout.CustomizationFormText = "Railcar number";
            this.railcarNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.railcarNumberLayout.Name = "railcarNumberLayout";
            this.railcarNumberLayout.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.railcarNumberLayout.Size = new System.Drawing.Size(200, 54);
            this.railcarNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 7);
            this.railcarNumberLayout.Text = "&Номер вагона";
            this.railcarNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.railcarNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // shippedDateLayout
            // 
            this.shippedDateLayout.Control = this.shippedDate;
            this.shippedDateLayout.CustomizationFormText = "Shipped date";
            this.shippedDateLayout.Location = new System.Drawing.Point(200, 0);
            this.shippedDateLayout.Name = "shippedDateLayout";
            this.shippedDateLayout.Size = new System.Drawing.Size(135, 54);
            this.shippedDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.shippedDateLayout.Text = "&Дата отгрузки";
            this.shippedDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.shippedDateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // destinationLayout
            // 
            this.destinationLayout.Control = this.destination;
            this.destinationLayout.CustomizationFormText = "Destination";
            this.destinationLayout.Location = new System.Drawing.Point(335, 0);
            this.destinationLayout.Name = "destinationLayout";
            this.destinationLayout.Size = new System.Drawing.Size(250, 54);
            this.destinationLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.destinationLayout.Text = "&Получатель";
            this.destinationLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.destinationLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // certificateNumberLayout
            // 
            this.certificateNumberLayout.Control = this.certificateNumber;
            this.certificateNumberLayout.CustomizationFormText = "Certificate number";
            this.certificateNumberLayout.Location = new System.Drawing.Point(585, 0);
            this.certificateNumberLayout.Name = "certificateNumberLayout";
            this.certificateNumberLayout.Size = new System.Drawing.Size(200, 54);
            this.certificateNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.certificateNumberLayout.Text = "Номер &сертификата";
            this.certificateNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // pipeListLayout
            // 
            this.pipeListLayout.Control = this.pipesList;
            this.pipeListLayout.CustomizationFormText = "Список труб";
            this.pipeListLayout.Location = new System.Drawing.Point(0, 54);
            this.pipeListLayout.Name = "pipeListLayout";
            this.pipeListLayout.Size = new System.Drawing.Size(1247, 392);
            this.pipeListLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 7);
            this.pipeListLayout.Text = "Список труб";
            this.pipeListLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeListLayout.TextSize = new System.Drawing.Size(0, 0);
            this.pipeListLayout.TextToControlDistance = 0;
            this.pipeListLayout.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(785, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(462, 54);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // shipButton
            // 
            this.shipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shipButton.Location = new System.Drawing.Point(987, 472);
            this.shipButton.Name = "shipButton";
            this.shipButton.Size = new System.Drawing.Size(75, 23);
            this.shipButton.TabIndex = 21;
            this.shipButton.Text = "Отгрузить";
            // 
            // RailcarNewEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 510);
            this.Controls.Add(this.generalLayout);
            this.Controls.Add(this.shipButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.unshipButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RailcarNewEditXtraForm";
            this.Text = "New or Edit railcar";
            ((System.ComponentModel.ISupportInitialize)(this.pipesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayout)).EndInit();
            this.generalLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destination.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeListLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl pipesList;
        private DevExpress.XtraGrid.Views.Grid.GridView pipesListView;
        private DevExpress.XtraEditors.SimpleButton unshipButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraGrid.Columns.GridColumn pipeNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pipeStatusGridColumn;
        private DevExpress.XtraLayout.LayoutControl generalLayout;
        private DevExpress.XtraEditors.DateEdit shippedDate;
        private DevExpress.XtraEditors.ComboBoxEdit railcarNumber;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraEditors.ComboBoxEdit destination;
        private DevExpress.XtraLayout.LayoutControlGroup railcarLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem certificateNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem railcarNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem destinationLayout;
        private DevExpress.XtraLayout.LayoutControlItem shippedDateLayout;
        private DevExpress.XtraEditors.SimpleButton shipButton;
        private DevExpress.XtraLayout.LayoutControlItem pipeListLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}