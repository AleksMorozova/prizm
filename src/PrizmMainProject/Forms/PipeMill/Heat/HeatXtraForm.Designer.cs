﻿namespace PrizmMain.Forms.PipeMill.Heat
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
            this.plateManufacturer = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plateMan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.steelGrade = new DevExpress.XtraEditors.TextEdit();
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
            this.numberLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.steelLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.plateManufacturerLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.masterLayoutControl)).BeginInit();
            this.masterLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsLeftEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturerLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // masterLayoutControl
            // 
            this.masterLayoutControl.Controls.Add(this.plateManufacturer);
            this.masterLayoutControl.Controls.Add(this.steelGrade);
            this.masterLayoutControl.Controls.Add(this.saveButton);
            this.masterLayoutControl.Controls.Add(this.cancelButton);
            this.masterLayoutControl.Controls.Add(this.number);
            this.masterLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.masterLayoutControl.Name = "masterLayoutControl";
            this.masterLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(575, 206, 423, 437);
            this.masterLayoutControl.Root = this.rootLayoutGroup;
            this.masterLayoutControl.ShowTemplates = true;
            this.masterLayoutControl.Size = new System.Drawing.Size(472, 173);
            this.masterLayoutControl.TabIndex = 0;
            this.masterLayoutControl.Text = "layoutControl1";
            // 
            // plateManufacturer
            // 
            this.plateManufacturer.Location = new System.Drawing.Point(29, 78);
            this.plateManufacturer.Name = "plateManufacturer";
            this.plateManufacturer.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.plateManufacturer.Properties.Appearance.Options.UseBackColor = true;
            this.plateManufacturer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.plateManufacturer.Properties.DisplayMember = "Name";
            this.plateManufacturer.Properties.NullText = "";
            this.plateManufacturer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.plateManufacturer.Properties.ValueMember = "Name";
            this.plateManufacturer.Properties.View = this.gridView1;
            this.plateManufacturer.Size = new System.Drawing.Size(421, 20);
            this.plateManufacturer.StyleController = this.masterLayoutControl;
            this.plateManufacturer.TabIndex = 9;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.plateMan});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // plateMan
            // 
            this.plateMan.Caption = "производители листа";
            this.plateMan.FieldName = "Name";
            this.plateMan.Name = "plateMan";
            this.plateMan.Visible = true;
            this.plateMan.VisibleIndex = 0;
            // 
            // steelGrade
            // 
            this.steelGrade.Location = new System.Drawing.Point(151, 38);
            this.steelGrade.Name = "steelGrade";
            this.steelGrade.Size = new System.Drawing.Size(292, 20);
            this.steelGrade.StyleController = this.masterLayoutControl;
            this.steelGrade.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(246, 129);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 22);
            this.saveButton.StyleController = this.masterLayoutControl;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(350, 129);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 22);
            this.cancelButton.StyleController = this.masterLayoutControl;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отменить";
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
            this.number.Size = new System.Drawing.Size(111, 20);
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
            this.buttonsLeftEmptySpace,
            this.numberLayoutControl,
            this.steelLayoutControl,
            this.plateManufacturerLayoutControl,
            this.divideButtonEmptySpace});
            this.rootLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutGroup.Name = "Root";
            this.rootLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.rootLayoutGroup.Size = new System.Drawing.Size(472, 173);
            this.rootLayoutGroup.Text = "Root";
            this.rootLayoutGroup.TextVisible = false;
            // 
            // saveLayoutControl
            // 
            this.saveLayoutControl.Control = this.saveButton;
            this.saveLayoutControl.CustomizationFormText = "layoutControlItem2";
            this.saveLayoutControl.Location = new System.Drawing.Point(224, 107);
            this.saveLayoutControl.Name = "saveLayoutControl";
            this.saveLayoutControl.Size = new System.Drawing.Size(104, 26);
            this.saveLayoutControl.Text = "layoutControlItem2";
            this.saveLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.saveLayoutControl.TextToControlDistance = 0;
            this.saveLayoutControl.TextVisible = false;
            // 
            // cancelLayoutControl
            // 
            this.cancelLayoutControl.Control = this.cancelButton;
            this.cancelLayoutControl.CustomizationFormText = "layoutControlItem3";
            this.cancelLayoutControl.Location = new System.Drawing.Point(328, 107);
            this.cancelLayoutControl.Name = "cancelLayoutControl";
            this.cancelLayoutControl.Size = new System.Drawing.Size(104, 26);
            this.cancelLayoutControl.Text = "layoutControlItem3";
            this.cancelLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.cancelLayoutControl.TextToControlDistance = 0;
            this.cancelLayoutControl.TextVisible = false;
            // 
            // divideButtonEmptySpace
            // 
            this.divideButtonEmptySpace.AllowHotTrack = false;
            this.divideButtonEmptySpace.CustomizationFormText = "emptySpaceItem1";
            this.divideButtonEmptySpace.Location = new System.Drawing.Point(0, 80);
            this.divideButtonEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.divideButtonEmptySpace.Name = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.Size = new System.Drawing.Size(432, 27);
            this.divideButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.divideButtonEmptySpace.Text = "emptySpaceItem1";
            this.divideButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // buttonsLeftEmptySpace
            // 
            this.buttonsLeftEmptySpace.AllowHotTrack = false;
            this.buttonsLeftEmptySpace.CustomizationFormText = "emptySpaceItem2";
            this.buttonsLeftEmptySpace.Location = new System.Drawing.Point(0, 107);
            this.buttonsLeftEmptySpace.Name = "buttonsLeftEmptySpace";
            this.buttonsLeftEmptySpace.Size = new System.Drawing.Size(224, 26);
            this.buttonsLeftEmptySpace.Text = "emptySpaceItem2";
            this.buttonsLeftEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // numberLayoutControl
            // 
            this.numberLayoutControl.Control = this.number;
            this.numberLayoutControl.CustomizationFormText = "Номер плавки";
            this.numberLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.numberLayoutControl.Name = "numberLayoutControl";
            this.numberLayoutControl.Size = new System.Drawing.Size(122, 40);
            this.numberLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 7, 0, 0);
            this.numberLayoutControl.Text = "Номер плавки";
            this.numberLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.numberLayoutControl.TextSize = new System.Drawing.Size(111, 13);
            // 
            // steelLayoutControl
            // 
            this.steelLayoutControl.Control = this.steelGrade;
            this.steelLayoutControl.CustomizationFormText = "Марка стали";
            this.steelLayoutControl.Location = new System.Drawing.Point(122, 0);
            this.steelLayoutControl.Name = "steelLayoutControl";
            this.steelLayoutControl.Size = new System.Drawing.Size(310, 40);
            this.steelLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 0, 0);
            this.steelLayoutControl.Text = "Марка стали";
            this.steelLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.steelLayoutControl.TextSize = new System.Drawing.Size(111, 13);
            // 
            // plateManufacturerLayoutControl
            // 
            this.plateManufacturerLayoutControl.Control = this.plateManufacturer;
            this.plateManufacturerLayoutControl.CustomizationFormText = "Производитель листа";
            this.plateManufacturerLayoutControl.Location = new System.Drawing.Point(0, 40);
            this.plateManufacturerLayoutControl.Name = "plateManufacturerLayoutControl";
            this.plateManufacturerLayoutControl.Size = new System.Drawing.Size(432, 40);
            this.plateManufacturerLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 0, 0, 0);
            this.plateManufacturerLayoutControl.Text = "Производитель листа";
            this.plateManufacturerLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateManufacturerLayoutControl.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.number;
            this.layoutControlItem1.CustomizationFormText = "Номер плавки";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "numberLayoutControl";
            this.layoutControlItem1.Size = new System.Drawing.Size(249, 40);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 7, 0, 0);
            this.layoutControlItem1.Text = "Номер плавки";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(150, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // HeatXtraForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(472, 173);
            this.Controls.Add(this.masterLayoutControl);
            this.Name = "HeatXtraForm";
            this.Text = "Завод - плавка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HeatXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.HeatXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterLayoutControl)).EndInit();
            this.masterLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsLeftEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturerLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl masterLayoutControl;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlGroup rootLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem numberLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem saveLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem cancelLayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem divideButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem buttonsLeftEmptySpace;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.TextEdit steelGrade;
        private DevExpress.XtraLayout.LayoutControlItem steelLayoutControl;
        private DevExpress.XtraEditors.GridLookUpEdit number;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn heatNumber;
        private DevExpress.XtraEditors.GridLookUpEdit plateManufacturer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn plateMan;
        private DevExpress.XtraLayout.LayoutControlItem plateManufacturerLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}