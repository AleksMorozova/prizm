namespace PrizmMain.Forms.InspectionParts.Search
{
    partial class PartsSearchXtraForm
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsSearchXtraForm));
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.search = new DevExpress.XtraEditors.SimpleButton();
            this.type = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.parts = new DevExpress.XtraGrid.GridControl();
            this.partsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.number = new DevExpress.XtraEditors.TextEdit();
            this.rootLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridlayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.numberLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.typeLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.searchBtnLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridlayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtnLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.search);
            this.mainLayoutControl.Controls.Add(this.type);
            this.mainLayoutControl.Controls.Add(this.parts);
            this.mainLayoutControl.Controls.Add(this.number);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(21, 313, 250, 350);
            this.mainLayoutControl.Root = this.rootLayoutControlGroup;
            this.mainLayoutControl.Size = new System.Drawing.Size(1259, 511);
            this.mainLayoutControl.TabIndex = 0;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(540, 63);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(81, 22);
            this.search.StyleController = this.mainLayoutControl;
            this.search.TabIndex = 7;
            this.search.Text = "Поиск";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(280, 64);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Size = new System.Drawing.Size(226, 20);
            this.type.StyleController = this.mainLayoutControl;
            this.type.TabIndex = 6;
            // 
            // parts
            // 
            this.parts.Cursor = System.Windows.Forms.Cursors.Default;
            this.parts.Location = new System.Drawing.Point(12, 126);
            this.parts.MainView = this.partsView;
            this.parts.Name = "parts";
            this.parts.Size = new System.Drawing.Size(1235, 373);
            this.parts.TabIndex = 5;
            this.parts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.partsView});
            // 
            // partsView
            // 
            this.partsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCol,
            this.numberCol,
            this.typeCol});
            this.partsView.GridControl = this.parts;
            this.partsView.Name = "partsView";
            this.partsView.OptionsCustomization.AllowFilter = false;
            this.partsView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.partsView.OptionsView.ShowAutoFilterRow = true;
            this.partsView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.partsView.OptionsView.ShowGroupPanel = false;
            // 
            // idCol
            // 
            this.idCol.Caption = "#";
            this.idCol.FieldName = "Id";
            this.idCol.Name = "idCol";
            this.idCol.Visible = true;
            this.idCol.VisibleIndex = 2;
            // 
            // numberCol
            // 
            this.numberCol.Caption = "Номер";
            this.numberCol.FieldName = "Number";
            this.numberCol.Name = "numberCol";
            this.numberCol.Visible = true;
            this.numberCol.VisibleIndex = 0;
            // 
            // typeCol
            // 
            this.typeCol.Caption = "Тип";
            this.typeCol.FieldName = "Type";
            this.typeCol.Name = "typeCol";
            this.typeCol.Visible = true;
            this.typeCol.VisibleIndex = 1;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(30, 64);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(226, 20);
            this.number.StyleController = this.mainLayoutControl;
            this.number.TabIndex = 4;
            // 
            // rootLayoutControlGroup
            // 
            this.rootLayoutControlGroup.CustomizationFormText = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.rootLayoutControlGroup.GroupBordersVisible = false;
            this.rootLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.gridlayoutControl,
            this.searchLayoutControlGroup});
            this.rootLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutControlGroup.Name = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.Size = new System.Drawing.Size(1259, 511);
            this.rootLayoutControlGroup.Text = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.TextVisible = false;
            // 
            // gridlayoutControl
            // 
            this.gridlayoutControl.Control = this.parts;
            this.gridlayoutControl.CustomizationFormText = "Компоненты";
            this.gridlayoutControl.Location = new System.Drawing.Point(0, 98);
            this.gridlayoutControl.Name = "gridlayoutControl";
            this.gridlayoutControl.Size = new System.Drawing.Size(1239, 393);
            this.gridlayoutControl.Text = "Компоненты";
            this.gridlayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.gridlayoutControl.TextSize = new System.Drawing.Size(63, 13);
            // 
            // searchLayoutControlGroup
            // 
            this.searchLayoutControlGroup.CustomizationFormText = "Поиск";
            this.searchLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.numberLayoutControl,
            this.typeLayoutControl,
            this.emptySpaceItem1,
            this.searchBtnLayoutControl});
            this.searchLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.searchLayoutControlGroup.Name = "searchLayoutControlGroup";
            this.searchLayoutControlGroup.Size = new System.Drawing.Size(1239, 98);
            this.searchLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 7, 7);
            this.searchLayoutControlGroup.Text = "Поиск";
            // 
            // numberLayoutControl
            // 
            this.numberLayoutControl.Control = this.number;
            this.numberLayoutControl.CustomizationFormText = "Номер";
            this.numberLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.numberLayoutControl.Name = "numberLayoutControl";
            this.numberLayoutControl.Size = new System.Drawing.Size(250, 45);
            this.numberLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 15, 0, 5);
            this.numberLayoutControl.Text = "Номер";
            this.numberLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.numberLayoutControl.TextSize = new System.Drawing.Size(63, 13);
            // 
            // typeLayoutControl
            // 
            this.typeLayoutControl.Control = this.type;
            this.typeLayoutControl.CustomizationFormText = "Тип";
            this.typeLayoutControl.Location = new System.Drawing.Point(250, 0);
            this.typeLayoutControl.Name = "typeLayoutControl";
            this.typeLayoutControl.Size = new System.Drawing.Size(250, 45);
            this.typeLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 15, 0, 5);
            this.typeLayoutControl.Text = "Тип";
            this.typeLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.typeLayoutControl.TextSize = new System.Drawing.Size(63, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(600, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(613, 45);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // searchBtnLayoutControl
            // 
            this.searchBtnLayoutControl.Control = this.search;
            this.searchBtnLayoutControl.CustomizationFormText = "searchBtnLayoutControl";
            this.searchBtnLayoutControl.Location = new System.Drawing.Point(500, 0);
            this.searchBtnLayoutControl.Name = "searchBtnLayoutControl";
            this.searchBtnLayoutControl.Size = new System.Drawing.Size(100, 45);
            this.searchBtnLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 0, 15, 0);
            this.searchBtnLayoutControl.Text = "searchBtnLayoutControl";
            this.searchBtnLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.searchBtnLayoutControl.TextToControlDistance = 0;
            this.searchBtnLayoutControl.TextVisible = false;
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            // 
            // PartsSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 511);
            this.Controls.Add(this.mainLayoutControl);
            this.Name = "PartsSearchXtraForm";
            this.Text = "Входной контроль - поиск компонентов";
            this.Load += new System.EventHandler(this.PartsSearchXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridlayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtnLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup rootLayoutControlGroup;
        private DevExpress.XtraEditors.SimpleButton search;
        private DevExpress.XtraEditors.CheckedComboBoxEdit type;
        private DevExpress.XtraGrid.GridControl parts;
        private DevExpress.XtraGrid.Views.Grid.GridView partsView;
        private DevExpress.XtraEditors.TextEdit number;
        private DevExpress.XtraLayout.LayoutControlItem gridlayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup searchLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem numberLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem typeLayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem searchBtnLayoutControl;
        private DevExpress.XtraGrid.Columns.GridColumn idCol;
        private DevExpress.XtraGrid.Columns.GridColumn numberCol;
        private DevExpress.XtraGrid.Columns.GridColumn typeCol;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}