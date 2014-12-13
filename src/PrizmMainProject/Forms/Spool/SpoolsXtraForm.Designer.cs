namespace PrizmMain.Forms.Spool
{
    partial class SpoolsXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpoolsXtraForm));
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.inspectionHistory = new DevExpress.XtraGrid.GridControl();
            this.inspectionHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectionDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionResultGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reasonGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spoolLength = new DevExpress.XtraEditors.TextEdit();
            this.cutButton = new DevExpress.XtraEditors.SimpleButton();
            this.pipeLength = new DevExpress.XtraEditors.TextEdit();
            this.spoolNumber = new DevExpress.XtraEditors.TextEdit();
            this.pipeNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutRootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipeSearchayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.upperSearchEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.searchLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeNumberLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.incomingInspectionLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspectionHistoryLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.spoolLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.spoolNumberLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutlengthGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipelengthLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.spoonlengthLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cutLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.SpoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutRootGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSearchayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperSearchEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingInspectionLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumberLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutlengthGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelengthLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonlengthLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpoolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(270, 70);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(67, 22);
            this.searchButton.StyleController = this.mainLayoutControl;
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "&Поиск";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.inspectionHistory);
            this.mainLayoutControl.Controls.Add(this.spoolLength);
            this.mainLayoutControl.Controls.Add(this.cutButton);
            this.mainLayoutControl.Controls.Add(this.pipeLength);
            this.mainLayoutControl.Controls.Add(this.spoolNumber);
            this.mainLayoutControl.Controls.Add(this.searchButton);
            this.mainLayoutControl.Controls.Add(this.pipeNumber);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(340, 129, 250, 350);
            this.mainLayoutControl.Root = this.layoutRootGroup;
            this.mainLayoutControl.Size = new System.Drawing.Size(940, 450);
            this.mainLayoutControl.TabIndex = 44;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // inspectionHistory
            // 
            this.inspectionHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspectionHistory.Location = new System.Drawing.Point(386, 58);
            this.inspectionHistory.MainView = this.inspectionHistoryGridView;
            this.inspectionHistory.Name = "inspectionHistory";
            this.inspectionHistory.Size = new System.Drawing.Size(510, 353);
            this.inspectionHistory.TabIndex = 44;
            this.inspectionHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionHistoryGridView});
            // 
            // inspectionHistoryGridView
            // 
            this.inspectionHistoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectionDateGridColumn,
            this.inspectionResultGridColumn,
            this.inspectorsGridColumn,
            this.reasonGridColumn});
            this.inspectionHistoryGridView.GridControl = this.inspectionHistory;
            this.inspectionHistoryGridView.Name = "inspectionHistoryGridView";
            this.inspectionHistoryGridView.OptionsView.ShowGroupPanel = false;
            // 
            // inspectionDateGridColumn
            // 
            this.inspectionDateGridColumn.Caption = "Дата";
            this.inspectionDateGridColumn.Name = "inspectionDateGridColumn";
            this.inspectionDateGridColumn.Visible = true;
            this.inspectionDateGridColumn.VisibleIndex = 0;
            // 
            // inspectionResultGridColumn
            // 
            this.inspectionResultGridColumn.Caption = "Результат";
            this.inspectionResultGridColumn.Name = "inspectionResultGridColumn";
            this.inspectionResultGridColumn.Visible = true;
            this.inspectionResultGridColumn.VisibleIndex = 1;
            // 
            // inspectorsGridColumn
            // 
            this.inspectorsGridColumn.Caption = "Инспектор";
            this.inspectorsGridColumn.Name = "inspectorsGridColumn";
            this.inspectorsGridColumn.Visible = true;
            this.inspectorsGridColumn.VisibleIndex = 2;
            // 
            // reasonGridColumn
            // 
            this.reasonGridColumn.Caption = "Причина";
            this.reasonGridColumn.Name = "reasonGridColumn";
            this.reasonGridColumn.Visible = true;
            this.reasonGridColumn.VisibleIndex = 3;
            // 
            // spoolLength
            // 
            this.spoolLength.Location = new System.Drawing.Point(205, 254);
            this.spoolLength.Name = "spoolLength";
            this.spoolLength.Size = new System.Drawing.Size(115, 20);
            this.spoolLength.StyleController = this.mainLayoutControl;
            this.spoolLength.TabIndex = 16;
            // 
            // cutButton
            // 
            this.cutButton.Image = ((System.Drawing.Image)(resources.GetObject("cutButton.Image")));
            this.cutButton.Location = new System.Drawing.Point(234, 288);
            this.cutButton.MaximumSize = new System.Drawing.Size(100, 0);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(86, 22);
            this.cutButton.StyleController = this.mainLayoutControl;
            this.cutButton.TabIndex = 43;
            this.cutButton.Text = "&Отрезать";
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // pipeLength
            // 
            this.pipeLength.Location = new System.Drawing.Point(63, 254);
            this.pipeLength.Name = "pipeLength";
            this.pipeLength.Properties.ReadOnly = true;
            this.pipeLength.Size = new System.Drawing.Size(121, 20);
            this.pipeLength.StyleController = this.mainLayoutControl;
            this.pipeLength.TabIndex = 13;
            // 
            // spoolNumber
            // 
            this.spoolNumber.Location = new System.Drawing.Point(47, 170);
            this.spoolNumber.Name = "spoolNumber";
            this.spoolNumber.Size = new System.Drawing.Size(205, 20);
            this.spoolNumber.StyleController = this.mainLayoutControl;
            this.spoolNumber.TabIndex = 41;
            // 
            // pipeNumber
            // 
            this.pipeNumber.Location = new System.Drawing.Point(45, 72);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeNumber.Size = new System.Drawing.Size(207, 20);
            this.pipeNumber.StyleController = this.mainLayoutControl;
            this.pipeNumber.TabIndex = 38;
            // 
            // layoutRootGroup
            // 
            this.layoutRootGroup.CustomizationFormText = "Root";
            this.layoutRootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutRootGroup.GroupBordersVisible = false;
            this.layoutRootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipeSearchayoutGroup,
            this.incomingInspectionLayoutGroup,
            this.spoolLayoutGroup});
            this.layoutRootGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutRootGroup.Name = "layoutRootGroup";
            this.layoutRootGroup.Size = new System.Drawing.Size(940, 450);
            this.layoutRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 15, 15);
            this.layoutRootGroup.Text = "layoutRootGroup";
            this.layoutRootGroup.TextVisible = false;
            // 
            // pipeSearchayoutGroup
            // 
            this.pipeSearchayoutGroup.CustomizationFormText = "Поиск трубы";
            this.pipeSearchayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.upperSearchEmptySpace,
            this.searchLayoutControlItem,
            this.pipeNumberLabel,
            this.emptySpaceItem4});
            this.pipeSearchayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.pipeSearchayoutGroup.Name = "pipeSearchayoutGroup";
            this.pipeSearchayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 9);
            this.pipeSearchayoutGroup.Size = new System.Drawing.Size(329, 93);
            this.pipeSearchayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 7);
            this.pipeSearchayoutGroup.Text = "Поиск трубы";
            // 
            // upperSearchEmptySpace
            // 
            this.upperSearchEmptySpace.AllowHotTrack = false;
            this.upperSearchEmptySpace.CustomizationFormText = "upperSearchEmptySpace";
            this.upperSearchEmptySpace.Location = new System.Drawing.Point(228, 0);
            this.upperSearchEmptySpace.Name = "upperSearchEmptySpace";
            this.upperSearchEmptySpace.Size = new System.Drawing.Size(95, 14);
            this.upperSearchEmptySpace.Text = "upperSearchEmptySpace";
            this.upperSearchEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // searchLayoutControlItem
            // 
            this.searchLayoutControlItem.Control = this.searchButton;
            this.searchLayoutControlItem.CustomizationFormText = "searchLayoutControlItem";
            this.searchLayoutControlItem.Location = new System.Drawing.Point(228, 14);
            this.searchLayoutControlItem.Name = "searchLayoutControlItem";
            this.searchLayoutControlItem.Size = new System.Drawing.Size(85, 40);
            this.searchLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 7, 7);
            this.searchLayoutControlItem.Text = "searchLayoutControlItem";
            this.searchLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.searchLayoutControlItem.TextToControlDistance = 0;
            this.searchLayoutControlItem.TextVisible = false;
            // 
            // pipeNumberLabel
            // 
            this.pipeNumberLabel.Control = this.pipeNumber;
            this.pipeNumberLabel.CustomizationFormText = "Номер трубы";
            this.pipeNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.pipeNumberLabel.Name = "pipeNumberLabel";
            this.pipeNumberLabel.Size = new System.Drawing.Size(228, 54);
            this.pipeNumberLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 7, 7, 7);
            this.pipeNumberLabel.Text = "Номер трубы";
            this.pipeNumberLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeNumberLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(313, 14);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 40);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // incomingInspectionLayoutGroup
            // 
            this.incomingInspectionLayoutGroup.CustomizationFormText = "Входной контроль";
            this.incomingInspectionLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectionHistoryLayout});
            this.incomingInspectionLayoutGroup.Location = new System.Drawing.Point(329, 0);
            this.incomingInspectionLayoutGroup.Name = "incomingInspectionLayoutGroup";
            this.incomingInspectionLayoutGroup.Size = new System.Drawing.Size(551, 400);
            this.incomingInspectionLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 2, 2, 2);
            this.incomingInspectionLayoutGroup.Text = "Входной контроль";
            // 
            // inspectionHistoryLayout
            // 
            this.inspectionHistoryLayout.Control = this.inspectionHistory;
            this.inspectionHistoryLayout.CustomizationFormText = "inspectionHistoryLayout";
            this.inspectionHistoryLayout.Location = new System.Drawing.Point(0, 0);
            this.inspectionHistoryLayout.Name = "inspectionHistoryLayout";
            this.inspectionHistoryLayout.Size = new System.Drawing.Size(514, 357);
            this.inspectionHistoryLayout.Text = "inspectionHistoryLayout";
            this.inspectionHistoryLayout.TextSize = new System.Drawing.Size(0, 0);
            this.inspectionHistoryLayout.TextToControlDistance = 0;
            this.inspectionHistoryLayout.TextVisible = false;
            // 
            // spoolLayoutGroup
            // 
            this.spoolLayoutGroup.CustomizationFormText = "Создание катушки";
            this.spoolLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.spoolNumberLabel,
            this.layoutlengthGroup,
            this.emptySpaceItem1,
            this.emptySpaceItem3});
            this.spoolLayoutGroup.Location = new System.Drawing.Point(0, 93);
            this.spoolLayoutGroup.Name = "spoolLayoutGroup";
            this.spoolLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 9, 0, 9);
            this.spoolLayoutGroup.Size = new System.Drawing.Size(329, 307);
            this.spoolLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 7, 2);
            this.spoolLayoutGroup.Text = "Создание катушки";
            // 
            // spoolNumberLabel
            // 
            this.spoolNumberLabel.Control = this.spoolNumber;
            this.spoolNumberLabel.CustomizationFormText = "Номер катушки";
            this.spoolNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.spoolNumberLabel.Name = "spoolNumberLabel";
            this.spoolNumberLabel.Size = new System.Drawing.Size(236, 62);
            this.spoolNumberLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 15, 7, 15);
            this.spoolNumberLabel.Text = "Номер катушки";
            this.spoolNumberLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.spoolNumberLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutlengthGroup
            // 
            this.layoutlengthGroup.CustomizationFormText = "Длинна";
            this.layoutlengthGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipelengthLabel,
            this.spoonlengthLabel,
            this.emptySpaceItem2,
            this.cutLayoutControlItem});
            this.layoutlengthGroup.Location = new System.Drawing.Point(0, 62);
            this.layoutlengthGroup.Name = "layoutlengthGroup";
            this.layoutlengthGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutlengthGroup.Size = new System.Drawing.Size(314, 136);
            this.layoutlengthGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 7, 0, 15);
            this.layoutlengthGroup.Text = "Длина";
            // 
            // pipelengthLabel
            // 
            this.pipelengthLabel.Control = this.pipeLength;
            this.pipelengthLabel.CustomizationFormText = "Труба";
            this.pipelengthLabel.Location = new System.Drawing.Point(0, 0);
            this.pipelengthLabel.Name = "pipelengthLabel";
            this.pipelengthLabel.Size = new System.Drawing.Size(142, 54);
            this.pipelengthLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 7, 7, 7);
            this.pipelengthLabel.Text = "Труба";
            this.pipelengthLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipelengthLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // spoonlengthLabel
            // 
            this.spoonlengthLabel.Control = this.spoolLength;
            this.spoonlengthLabel.CustomizationFormText = "Катушка";
            this.spoonlengthLabel.Location = new System.Drawing.Point(142, 0);
            this.spoonlengthLabel.MinSize = new System.Drawing.Size(82, 41);
            this.spoonlengthLabel.Name = "spoonlengthLabel";
            this.spoonlengthLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0);
            this.spoonlengthLabel.Size = new System.Drawing.Size(144, 54);
            this.spoonlengthLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.spoonlengthLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 15, 7, 15);
            this.spoonlengthLabel.Text = "Катушка";
            this.spoonlengthLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.spoonlengthLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 54);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(101, 42);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cutLayoutControlItem
            // 
            this.cutLayoutControlItem.Control = this.cutButton;
            this.cutLayoutControlItem.CustomizationFormText = "cutLayoutControlItem";
            this.cutLayoutControlItem.Location = new System.Drawing.Point(101, 54);
            this.cutLayoutControlItem.Name = "cutLayoutControlItem";
            this.cutLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0);
            this.cutLayoutControlItem.Size = new System.Drawing.Size(185, 42);
            this.cutLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(80, 15, 3, 15);
            this.cutLayoutControlItem.Text = "cutLayoutControlItem";
            this.cutLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cutLayoutControlItem.TextToControlDistance = 0;
            this.cutLayoutControlItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(236, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(78, 62);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 198);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(314, 70);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SpoolsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.mainLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpoolsXtraForm";
            this.Text = "Создание катушки";
            this.Load += new System.EventHandler(this.SpoolsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutRootGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSearchayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperSearchEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingInspectionLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumberLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutlengthGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelengthLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonlengthLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpoolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.ComboBoxEdit pipeNumber;
        private DevExpress.XtraEditors.TextEdit pipeLength;
        private DevExpress.XtraEditors.TextEdit spoolNumber;
        private DevExpress.XtraEditors.SimpleButton cutButton;
        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutRootGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipeNumberLabel;
        private DevExpress.XtraLayout.LayoutControlItem spoolNumberLabel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutlengthGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipelengthLabel;
        private DevExpress.XtraLayout.LayoutControlItem searchLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem cutLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem upperSearchEmptySpace;
        private DevExpress.XtraLayout.LayoutControlGroup pipeSearchayoutGroup;
        private DevExpress.XtraLayout.LayoutControlGroup spoolLayoutGroup;
        private DevExpress.XtraGrid.GridControl inspectionHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionHistoryGridView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionResultGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorsGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn reasonGridColumn;
        private DevExpress.XtraLayout.LayoutControlGroup incomingInspectionLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem inspectionHistoryLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.TextEdit spoolLength;
        private DevExpress.XtraLayout.LayoutControlItem spoonlengthLabel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource SpoolBindingSource;
    }
}