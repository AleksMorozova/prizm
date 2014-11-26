namespace PrizmMain.Forms.PipeMill.Heat
{
    partial class HeatXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeatXtraForm));
            this.masterLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.steelGrade = new DevExpress.XtraEditors.TextEdit();
            this.phisicalGrid = new DevExpress.XtraGrid.GridControl();
            this.phisicalGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tensileParameter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tensileValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chemicalGrid = new DevExpress.XtraGrid.GridControl();
            this.chemicalGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chemElement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chemHeatValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chemPlateValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chemPipeValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.number = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.heatNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rootLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.saveLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.divideButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.buttonsLeftEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.phisicalLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.chemicalLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.numberLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.steelLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.masterLayoutControl)).BeginInit();
            this.masterLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.steelGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsLeftEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // masterLayoutControl
            // 
            this.masterLayoutControl.Controls.Add(this.steelGrade);
            this.masterLayoutControl.Controls.Add(this.phisicalGrid);
            this.masterLayoutControl.Controls.Add(this.chemicalGrid);
            this.masterLayoutControl.Controls.Add(this.saveButton);
            this.masterLayoutControl.Controls.Add(this.cancelButton);
            this.masterLayoutControl.Controls.Add(this.number);
            this.masterLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.masterLayoutControl.Name = "masterLayoutControl";
            this.masterLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(196, 267, 423, 437);
            this.masterLayoutControl.Root = this.rootLayoutGroup;
            this.masterLayoutControl.ShowTemplates = true;
            this.masterLayoutControl.Size = new System.Drawing.Size(1084, 563);
            this.masterLayoutControl.TabIndex = 0;
            this.masterLayoutControl.Text = "layoutControl1";
            // 
            // steelGrade
            // 
            this.steelGrade.Location = new System.Drawing.Point(278, 38);
            this.steelGrade.Name = "steelGrade";
            this.steelGrade.Size = new System.Drawing.Size(254, 20);
            this.steelGrade.StyleController = this.masterLayoutControl;
            this.steelGrade.TabIndex = 8;
            // 
            // phisicalGrid
            // 
            this.phisicalGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.phisicalGrid.Location = new System.Drawing.Point(550, 93);
            this.phisicalGrid.MainView = this.phisicalGridView;
            this.phisicalGrid.Name = "phisicalGrid";
            this.phisicalGrid.Size = new System.Drawing.Size(512, 421);
            this.phisicalGrid.TabIndex = 7;
            this.phisicalGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.phisicalGridView});
            // 
            // phisicalGridView
            // 
            this.phisicalGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tensileParameter,
            this.tensileValue});
            this.phisicalGridView.GridControl = this.phisicalGrid;
            this.phisicalGridView.Name = "phisicalGridView";
            this.phisicalGridView.OptionsView.ShowGroupPanel = false;
            // 
            // tensileParameter
            // 
            this.tensileParameter.Caption = "Параметр";
            this.tensileParameter.Name = "tensileParameter";
            this.tensileParameter.Visible = true;
            this.tensileParameter.VisibleIndex = 0;
            // 
            // tensileValue
            // 
            this.tensileValue.Caption = "Значение";
            this.tensileValue.Name = "tensileValue";
            this.tensileValue.Visible = true;
            this.tensileValue.VisibleIndex = 1;
            // 
            // chemicalGrid
            // 
            this.chemicalGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.chemicalGrid.Location = new System.Drawing.Point(22, 93);
            this.chemicalGrid.MainView = this.chemicalGridView;
            this.chemicalGrid.Name = "chemicalGrid";
            this.chemicalGrid.Size = new System.Drawing.Size(510, 421);
            this.chemicalGrid.TabIndex = 6;
            this.chemicalGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.chemicalGridView});
            // 
            // chemicalGridView
            // 
            this.chemicalGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.chemElement,
            this.chemHeatValue,
            this.chemPlateValue,
            this.chemPipeValue});
            this.chemicalGridView.GridControl = this.chemicalGrid;
            this.chemicalGridView.Name = "chemicalGridView";
            this.chemicalGridView.OptionsView.ShowGroupPanel = false;
            // 
            // chemElement
            // 
            this.chemElement.Caption = "Элемент";
            this.chemElement.FieldName = "Parameter";
            this.chemElement.Name = "chemElement";
            this.chemElement.Visible = true;
            this.chemElement.VisibleIndex = 0;
            // 
            // chemHeatValue
            // 
            this.chemHeatValue.Caption = "Плавка, %";
            this.chemHeatValue.FieldName = "HeatValue";
            this.chemHeatValue.Name = "chemHeatValue";
            this.chemHeatValue.Visible = true;
            this.chemHeatValue.VisibleIndex = 1;
            // 
            // chemPlateValue
            // 
            this.chemPlateValue.Caption = "Лист, %";
            this.chemPlateValue.FieldName = "PlateValue";
            this.chemPlateValue.Name = "chemPlateValue";
            this.chemPlateValue.Visible = true;
            this.chemPlateValue.VisibleIndex = 2;
            // 
            // chemPipeValue
            // 
            this.chemPipeValue.Caption = "Труба, %";
            this.chemPipeValue.FieldName = "PipeValue";
            this.chemPipeValue.Name = "chemPipeValue";
            this.chemPipeValue.Visible = true;
            this.chemPipeValue.VisibleIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(848, 518);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.StyleController = this.masterLayoutControl;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(962, 518);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.StyleController = this.masterLayoutControl;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(22, 38);
            this.number.Name = "number";
            this.number.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.number.Properties.Appearance.Options.UseBackColor = true;
            this.number.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.number.Properties.NullText = "";
            this.number.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.number.Properties.View = this.gridLookUpEdit1View;
            this.number.Size = new System.Drawing.Size(238, 20);
            this.number.StyleController = this.masterLayoutControl;
            this.number.TabIndex = 4;
            this.number.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.heatNumber});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // heatNumber
            // 
            this.heatNumber.Caption = "Номер плавки";
            this.heatNumber.FieldName = "Number";
            this.heatNumber.Name = "heatNumber";
            this.heatNumber.Visible = true;
            this.heatNumber.VisibleIndex = 0;
            // 
            // rootLayoutGroup
            // 
            this.rootLayoutGroup.CustomizationFormText = "Root";
            this.rootLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.rootLayoutGroup.GroupBordersVisible = false;
            this.rootLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.saveLayoutControl,
            this.cancelLayoutControl,
            this.divideButtonEmptySpace,
            this.buttonsLeftEmptySpace,
            this.phisicalLayoutControl,
            this.chemicalLayoutControl,
            this.numberLayoutControl,
            this.steelLayoutControl,
            this.emptySpaceItem1});
            this.rootLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutGroup.Name = "Root";
            this.rootLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.rootLayoutGroup.Size = new System.Drawing.Size(1084, 563);
            this.rootLayoutGroup.Text = "Root";
            this.rootLayoutGroup.TextVisible = false;
            // 
            // saveLayoutControl
            // 
            this.saveLayoutControl.Control = this.saveButton;
            this.saveLayoutControl.CustomizationFormText = "layoutControlItem2";
            this.saveLayoutControl.Location = new System.Drawing.Point(826, 496);
            this.saveLayoutControl.MaxSize = new System.Drawing.Size(104, 27);
            this.saveLayoutControl.MinSize = new System.Drawing.Size(104, 27);
            this.saveLayoutControl.Name = "saveLayoutControl";
            this.saveLayoutControl.Size = new System.Drawing.Size(104, 27);
            this.saveLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.saveLayoutControl.Text = "layoutControlItem2";
            this.saveLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.saveLayoutControl.TextToControlDistance = 0;
            this.saveLayoutControl.TextVisible = false;
            // 
            // cancelLayoutControl
            // 
            this.cancelLayoutControl.Control = this.cancelButton;
            this.cancelLayoutControl.CustomizationFormText = "layoutControlItem3";
            this.cancelLayoutControl.Location = new System.Drawing.Point(940, 496);
            this.cancelLayoutControl.MaxSize = new System.Drawing.Size(104, 27);
            this.cancelLayoutControl.MinSize = new System.Drawing.Size(104, 27);
            this.cancelLayoutControl.Name = "cancelLayoutControl";
            this.cancelLayoutControl.Size = new System.Drawing.Size(104, 27);
            this.cancelLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.cancelLayoutControl.Text = "layoutControlItem3";
            this.cancelLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.cancelLayoutControl.TextToControlDistance = 0;
            this.cancelLayoutControl.TextVisible = false;
            // 
            // divideButtonEmptySpace
            // 
            this.divideButtonEmptySpace.AllowHotTrack = false;
            this.divideButtonEmptySpace.CustomizationFormText = "emptySpaceItem1";
            this.divideButtonEmptySpace.Location = new System.Drawing.Point(930, 496);
            this.divideButtonEmptySpace.MaxSize = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.MinSize = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.Name = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.Size = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.divideButtonEmptySpace.Text = "emptySpaceItem1";
            this.divideButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // buttonsLeftEmptySpace
            // 
            this.buttonsLeftEmptySpace.AllowHotTrack = false;
            this.buttonsLeftEmptySpace.CustomizationFormText = "emptySpaceItem2";
            this.buttonsLeftEmptySpace.Location = new System.Drawing.Point(0, 496);
            this.buttonsLeftEmptySpace.Name = "buttonsLeftEmptySpace";
            this.buttonsLeftEmptySpace.Size = new System.Drawing.Size(826, 27);
            this.buttonsLeftEmptySpace.Text = "emptySpaceItem2";
            this.buttonsLeftEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // phisicalLayoutControl
            // 
            this.phisicalLayoutControl.Control = this.phisicalGrid;
            this.phisicalLayoutControl.CustomizationFormText = "Механические свойства";
            this.phisicalLayoutControl.Location = new System.Drawing.Point(521, 40);
            this.phisicalLayoutControl.Name = "phisicalLayoutControl";
            this.phisicalLayoutControl.Size = new System.Drawing.Size(523, 456);
            this.phisicalLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 0, 15, 0);
            this.phisicalLayoutControl.Text = "Механические испытания";
            this.phisicalLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.phisicalLayoutControl.TextSize = new System.Drawing.Size(150, 13);
            // 
            // chemicalLayoutControl
            // 
            this.chemicalLayoutControl.Control = this.chemicalGrid;
            this.chemicalLayoutControl.CustomizationFormText = "Ковшовой химический состав";
            this.chemicalLayoutControl.Location = new System.Drawing.Point(0, 40);
            this.chemicalLayoutControl.Name = "chemicalLayoutControl";
            this.chemicalLayoutControl.Size = new System.Drawing.Size(521, 456);
            this.chemicalLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 7, 15, 0);
            this.chemicalLayoutControl.Text = "Ковшовой химический состав";
            this.chemicalLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.chemicalLayoutControl.TextSize = new System.Drawing.Size(150, 13);
            // 
            // numberLayoutControl
            // 
            this.numberLayoutControl.Control = this.number;
            this.numberLayoutControl.CustomizationFormText = "Номер плавки";
            this.numberLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.numberLayoutControl.Name = "numberLayoutControl";
            this.numberLayoutControl.Size = new System.Drawing.Size(249, 40);
            this.numberLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 7, 0, 0);
            this.numberLayoutControl.Text = "Номер плавки";
            this.numberLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.numberLayoutControl.TextSize = new System.Drawing.Size(150, 13);
            // 
            // steelLayoutControl
            // 
            this.steelLayoutControl.Control = this.steelGrade;
            this.steelLayoutControl.CustomizationFormText = "Марка стали";
            this.steelLayoutControl.Location = new System.Drawing.Point(249, 0);
            this.steelLayoutControl.Name = "steelLayoutControl";
            this.steelLayoutControl.Size = new System.Drawing.Size(272, 40);
            this.steelLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 0, 0);
            this.steelLayoutControl.Text = "Марка стали";
            this.steelLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.steelLayoutControl.TextSize = new System.Drawing.Size(150, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(521, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(523, 40);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // HeatXtraForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1084, 563);
            this.Controls.Add(this.masterLayoutControl);
            this.Name = "HeatXtraForm";
            this.Text = "Завод - плавка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HeatXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.HeatXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterLayoutControl)).EndInit();
            this.masterLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.steelGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsLeftEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl masterLayoutControl;
        private DevExpress.XtraGrid.GridControl phisicalGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView phisicalGridView;
        private DevExpress.XtraGrid.GridControl chemicalGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView chemicalGridView;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlGroup rootLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem numberLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem chemicalLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem phisicalLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem saveLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem cancelLayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem divideButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem buttonsLeftEmptySpace;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.TextEdit steelGrade;
        private DevExpress.XtraGrid.Columns.GridColumn chemElement;
        private DevExpress.XtraGrid.Columns.GridColumn chemHeatValue;
        private DevExpress.XtraGrid.Columns.GridColumn chemPlateValue;
        private DevExpress.XtraGrid.Columns.GridColumn chemPipeValue;
        private DevExpress.XtraLayout.LayoutControlItem steelLayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn tensileParameter;
        private DevExpress.XtraGrid.Columns.GridColumn tensileValue;
        private DevExpress.XtraEditors.GridLookUpEdit number;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn heatNumber;
    }
}