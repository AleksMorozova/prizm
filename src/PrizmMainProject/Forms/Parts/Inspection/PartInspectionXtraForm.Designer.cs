namespace Prizm.Main.Forms.Parts.Inspection
{
    partial class PartInspectionXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartInspectionXtraForm));
            this.inspectionLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.inspections = new DevExpress.XtraGrid.GridControl();
            this.inspectionsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.elementType = new DevExpress.XtraEditors.TextEdit();
            this.elementNumber = new DevExpress.XtraEditors.TextEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.searchNumber = new DevExpress.XtraEditors.TextEdit();
            this.InspectionLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchElementGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.findElementEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.inspectionControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.elementTypeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.elementNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectionsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionLayoutControl)).BeginInit();
            this.inspectionLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchElementGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findElementEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementTypeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // inspectionLayoutControl
            // 
            this.inspectionLayoutControl.Controls.Add(this.inspections);
            this.inspectionLayoutControl.Controls.Add(this.elementType);
            this.inspectionLayoutControl.Controls.Add(this.elementNumber);
            this.inspectionLayoutControl.Controls.Add(this.searchButton);
            this.inspectionLayoutControl.Controls.Add(this.searchNumber);
            this.inspectionLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.inspectionLayoutControl.Name = "inspectionLayoutControl";
            this.inspectionLayoutControl.OptionsView.UseDefaultDragAndDropRendering = false;
            this.inspectionLayoutControl.Root = this.InspectionLayoutControlGroup;
            this.inspectionLayoutControl.Size = new System.Drawing.Size(901, 493);
            this.inspectionLayoutControl.TabIndex = 0;
            this.inspectionLayoutControl.Text = "layoutControl1";
            // 
            // inspections
            // 
            this.inspections.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspections.Location = new System.Drawing.Point(24, 187);
            this.inspections.MainView = this.inspectionsView;
            this.inspections.Name = "inspections";
            this.inspections.Size = new System.Drawing.Size(853, 282);
            this.inspections.TabIndex = 8;
            this.inspections.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionsView});
            // 
            // inspectionsView
            // 
            this.inspectionsView.GridControl = this.inspections;
            this.inspectionsView.Name = "inspectionsView";
            this.inspectionsView.OptionsView.ShowGroupPanel = false;
            // 
            // elementType
            // 
            this.elementType.Location = new System.Drawing.Point(263, 148);
            this.elementType.Name = "elementType";
            this.elementType.Properties.ReadOnly = true;
            this.elementType.Size = new System.Drawing.Size(100, 20);
            this.elementType.StyleController = this.inspectionLayoutControl;
            this.elementType.TabIndex = 7;
            // 
            // elementNumber
            // 
            this.elementNumber.Location = new System.Drawing.Point(29, 148);
            this.elementNumber.Name = "elementNumber";
            this.elementNumber.Properties.ReadOnly = true;
            this.elementNumber.Size = new System.Drawing.Size(200, 20);
            this.elementNumber.StyleController = this.inspectionLayoutControl;
            this.elementNumber.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(263, 58);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(225, 22);
            this.searchButton.StyleController = this.inspectionLayoutControl;
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Найти и редактировать для контроля";
            // 
            // searchNumber
            // 
            this.searchNumber.Location = new System.Drawing.Point(29, 59);
            this.searchNumber.Name = "searchNumber";
            this.searchNumber.Size = new System.Drawing.Size(200, 20);
            this.searchNumber.StyleController = this.inspectionLayoutControl;
            this.searchNumber.TabIndex = 4;
            // 
            // InspectionLayoutControlGroup
            // 
            this.InspectionLayoutControlGroup.CustomizationFormText = "InspectionLayoutControlGroup";
            this.InspectionLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.InspectionLayoutControlGroup.GroupBordersVisible = false;
            this.InspectionLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchElementGroup,
            this.inspectionControlGroup});
            this.InspectionLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.InspectionLayoutControlGroup.Name = "InspectionLayoutControlGroup";
            this.InspectionLayoutControlGroup.Size = new System.Drawing.Size(901, 493);
            this.InspectionLayoutControlGroup.Text = "InspectionLayoutControlGroup";
            this.InspectionLayoutControlGroup.TextVisible = false;
            // 
            // searchElementGroup
            // 
            this.searchElementGroup.CustomizationFormText = "Поиск элемента";
            this.searchElementGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchButtonLayout,
            this.searchNumberLayout,
            this.findElementEmptySpace});
            this.searchElementGroup.Location = new System.Drawing.Point(0, 0);
            this.searchElementGroup.Name = "searchElementGroup";
            this.searchElementGroup.Size = new System.Drawing.Size(881, 89);
            this.searchElementGroup.Text = "Поиск элемента";
            // 
            // searchButtonLayout
            // 
            this.searchButtonLayout.Control = this.searchButton;
            this.searchButtonLayout.CustomizationFormText = "searchButtonLayout";
            this.searchButtonLayout.Location = new System.Drawing.Point(224, 0);
            this.searchButtonLayout.Name = "searchButtonLayout";
            this.searchButtonLayout.Size = new System.Drawing.Size(259, 46);
            this.searchButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 5);
            this.searchButtonLayout.Text = "searchButtonLayout";
            this.searchButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchButtonLayout.TextToControlDistance = 0;
            this.searchButtonLayout.TextVisible = false;
            // 
            // searchNumberLayout
            // 
            this.searchNumberLayout.Control = this.searchNumber;
            this.searchNumberLayout.CustomizationFormText = "Номер искомого элемента";
            this.searchNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.searchNumberLayout.MinSize = new System.Drawing.Size(224, 45);
            this.searchNumberLayout.Name = "searchNumberLayout";
            this.searchNumberLayout.Size = new System.Drawing.Size(224, 46);
            this.searchNumberLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.searchNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 15, 0, 5);
            this.searchNumberLayout.Text = "Номер искомого элемента";
            this.searchNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.searchNumberLayout.TextSize = new System.Drawing.Size(130, 13);
            // 
            // findElementEmptySpace
            // 
            this.findElementEmptySpace.AllowHotTrack = false;
            this.findElementEmptySpace.CustomizationFormText = "findElementEmptySpace";
            this.findElementEmptySpace.Location = new System.Drawing.Point(483, 0);
            this.findElementEmptySpace.Name = "findElementEmptySpace";
            this.findElementEmptySpace.Size = new System.Drawing.Size(374, 46);
            this.findElementEmptySpace.Text = "findElementEmptySpace";
            this.findElementEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // inspectionControlGroup
            // 
            this.inspectionControlGroup.CustomizationFormText = "layoutControlGroup";
            this.inspectionControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.elementTypeLayout,
            this.elementNumberLayout,
            this.inspectionsLayout,
            this.emptySpaceItem1});
            this.inspectionControlGroup.Location = new System.Drawing.Point(0, 89);
            this.inspectionControlGroup.Name = "inspectionControlGroup";
            this.inspectionControlGroup.Size = new System.Drawing.Size(881, 384);
            this.inspectionControlGroup.Text = "Входной контроль";
            // 
            // elementTypeLayout
            // 
            this.elementTypeLayout.Control = this.elementType;
            this.elementTypeLayout.CustomizationFormText = "Тип элемента";
            this.elementTypeLayout.Location = new System.Drawing.Point(224, 0);
            this.elementTypeLayout.MinSize = new System.Drawing.Size(134, 40);
            this.elementTypeLayout.Name = "elementTypeLayout";
            this.elementTypeLayout.Size = new System.Drawing.Size(134, 40);
            this.elementTypeLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.elementTypeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 0, 0);
            this.elementTypeLayout.Text = "Тип элемента";
            this.elementTypeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.elementTypeLayout.TextSize = new System.Drawing.Size(130, 13);
            // 
            // elementNumberLayout
            // 
            this.elementNumberLayout.Control = this.elementNumber;
            this.elementNumberLayout.CustomizationFormText = "Номер элемента";
            this.elementNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.elementNumberLayout.MinSize = new System.Drawing.Size(224, 40);
            this.elementNumberLayout.Name = "elementNumberLayout";
            this.elementNumberLayout.Size = new System.Drawing.Size(224, 40);
            this.elementNumberLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.elementNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 15, 0, 0);
            this.elementNumberLayout.Text = "Номер элемента";
            this.elementNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.elementNumberLayout.TextSize = new System.Drawing.Size(130, 13);
            // 
            // inspectionsLayout
            // 
            this.inspectionsLayout.Control = this.inspections;
            this.inspectionsLayout.CustomizationFormText = "inspectionsLayout";
            this.inspectionsLayout.Location = new System.Drawing.Point(0, 40);
            this.inspectionsLayout.Name = "inspectionsLayout";
            this.inspectionsLayout.Size = new System.Drawing.Size(857, 301);
            this.inspectionsLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 15, 0);
            this.inspectionsLayout.Text = "inspectionsLayout";
            this.inspectionsLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectionsLayout.TextSize = new System.Drawing.Size(0, 0);
            this.inspectionsLayout.TextToControlDistance = 0;
            this.inspectionsLayout.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(358, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(499, 40);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PartInspectionXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 493);
            this.Controls.Add(this.inspectionLayoutControl);
            this.Name = "PartInspectionXtraForm";
            this.Text = "Входной контроль";
            ((System.ComponentModel.ISupportInitialize)(this.inspectionLayoutControl)).EndInit();
            this.inspectionLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchElementGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findElementEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementTypeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl inspectionLayoutControl;
        private DevExpress.XtraGrid.GridControl inspections;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionsView;
        private DevExpress.XtraEditors.TextEdit elementType;
        private DevExpress.XtraEditors.TextEdit elementNumber;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.TextEdit searchNumber;
        private DevExpress.XtraLayout.LayoutControlGroup InspectionLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup searchElementGroup;
        private DevExpress.XtraLayout.LayoutControlItem searchButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem searchNumberLayout;
        private DevExpress.XtraLayout.LayoutControlGroup inspectionControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem elementTypeLayout;
        private DevExpress.XtraLayout.LayoutControlItem elementNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem inspectionsLayout;
        private DevExpress.XtraLayout.EmptySpaceItem findElementEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}