namespace Prizm.Main.Forms.PipeMill.Heat
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
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.number = new DevExpress.XtraEditors.ComboBoxEdit();
            this.plateManufacturer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.rootLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.saveLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsLeftEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.numberLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.steelLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.plateManufacturerLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.divideButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.masterLayoutControl)).BeginInit();
            this.masterLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.steelGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsLeftEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturerLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // masterLayoutControl
            // 
            this.masterLayoutControl.Controls.Add(this.steelGrade);
            this.masterLayoutControl.Controls.Add(this.saveButton);
            this.masterLayoutControl.Controls.Add(this.cancelButton);
            this.masterLayoutControl.Controls.Add(this.number);
            this.masterLayoutControl.Controls.Add(this.plateManufacturer);
            this.masterLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.masterLayoutControl.Name = "masterLayoutControl";
            this.masterLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(580, 118, 423, 437);
            this.masterLayoutControl.Root = this.rootLayoutGroup;
            this.masterLayoutControl.Size = new System.Drawing.Size(472, 202);
            this.masterLayoutControl.TabIndex = 0;
            this.masterLayoutControl.Text = "layoutControl1";
            // 
            // steelGrade
            // 
            this.steelGrade.Location = new System.Drawing.Point(233, 43);
            this.steelGrade.Name = "steelGrade";
            this.steelGrade.Size = new System.Drawing.Size(212, 20);
            this.steelGrade.StyleController = this.masterLayoutControl;
            this.steelGrade.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(233, 158);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 22);
            this.saveButton.StyleController = this.masterLayoutControl;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "&Сохранить";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(343, 158);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 22);
            this.cancelButton.StyleController = this.masterLayoutControl;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "О&тменить";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(27, 43);
            this.number.Name = "number";
            this.number.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.number.Properties.Appearance.Options.UseBackColor = true;
            this.number.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.number.Properties.PopupSizeable = true;
            this.number.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.number.Size = new System.Drawing.Size(192, 20);
            this.number.StyleController = this.masterLayoutControl;
            this.number.TabIndex = 4;
            // 
            // plateManufacturer
            // 
            this.plateManufacturer.Location = new System.Drawing.Point(27, 93);
            this.plateManufacturer.Name = "plateManufacturer";
            this.plateManufacturer.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.plateManufacturer.Properties.Appearance.Options.UseBackColor = true;
            this.plateManufacturer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.plateManufacturer.Properties.PopupSizeable = true;
            this.plateManufacturer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.plateManufacturer.Size = new System.Drawing.Size(418, 20);
            this.plateManufacturer.StyleController = this.masterLayoutControl;
            this.plateManufacturer.TabIndex = 9;
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
            this.rootLayoutGroup.Size = new System.Drawing.Size(472, 202);
            this.rootLayoutGroup.Text = "Root";
            this.rootLayoutGroup.TextVisible = false;
            // 
            // saveLayoutControl
            // 
            this.saveLayoutControl.Control = this.saveButton;
            this.saveLayoutControl.CustomizationFormText = "saveLayoutControl";
            this.saveLayoutControl.Location = new System.Drawing.Point(211, 136);
            this.saveLayoutControl.Name = "saveLayoutControl";
            this.saveLayoutControl.Size = new System.Drawing.Size(110, 26);
            this.saveLayoutControl.Text = "saveLayoutControl";
            this.saveLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.saveLayoutControl.TextVisible = false;
            // 
            // cancelLayoutControl
            // 
            this.cancelLayoutControl.Control = this.cancelButton;
            this.cancelLayoutControl.CustomizationFormText = "cancelLayoutControl";
            this.cancelLayoutControl.Location = new System.Drawing.Point(321, 136);
            this.cancelLayoutControl.Name = "cancelLayoutControl";
            this.cancelLayoutControl.Size = new System.Drawing.Size(111, 26);
            this.cancelLayoutControl.Text = "cancelLayoutControl";
            this.cancelLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.cancelLayoutControl.TextVisible = false;
            // 
            // buttonsLeftEmptySpace
            // 
            this.buttonsLeftEmptySpace.AllowHotTrack = false;
            this.buttonsLeftEmptySpace.CustomizationFormText = "buttonsLeftEmptySpace";
            this.buttonsLeftEmptySpace.Location = new System.Drawing.Point(0, 136);
            this.buttonsLeftEmptySpace.Name = "buttonsLeftEmptySpace";
            this.buttonsLeftEmptySpace.Size = new System.Drawing.Size(211, 26);
            this.buttonsLeftEmptySpace.Text = "buttonsLeftEmptySpace";
            this.buttonsLeftEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // numberLayoutControl
            // 
            this.numberLayoutControl.Control = this.number;
            this.numberLayoutControl.CustomizationFormText = "Номер плавки";
            this.numberLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.numberLayoutControl.Name = "numberLayoutControl";
            this.numberLayoutControl.Size = new System.Drawing.Size(206, 50);
            this.numberLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.numberLayoutControl.Text = "Ном&ер плавки";
            this.numberLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.numberLayoutControl.TextSize = new System.Drawing.Size(111, 13);
            // 
            // steelLayoutControl
            // 
            this.steelLayoutControl.Control = this.steelGrade;
            this.steelLayoutControl.CustomizationFormText = "Марка стали";
            this.steelLayoutControl.Location = new System.Drawing.Point(206, 0);
            this.steelLayoutControl.Name = "steelLayoutControl";
            this.steelLayoutControl.Size = new System.Drawing.Size(226, 50);
            this.steelLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.steelLayoutControl.Text = "&Марка стали";
            this.steelLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.steelLayoutControl.TextSize = new System.Drawing.Size(111, 13);
            // 
            // plateManufacturerLayoutControl
            // 
            this.plateManufacturerLayoutControl.Control = this.plateManufacturer;
            this.plateManufacturerLayoutControl.CustomizationFormText = "Производитель листа";
            this.plateManufacturerLayoutControl.Location = new System.Drawing.Point(0, 50);
            this.plateManufacturerLayoutControl.Name = "plateManufacturerLayoutControl";
            this.plateManufacturerLayoutControl.Size = new System.Drawing.Size(432, 50);
            this.plateManufacturerLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.plateManufacturerLayoutControl.Text = "&Производитель листа";
            this.plateManufacturerLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateManufacturerLayoutControl.TextSize = new System.Drawing.Size(111, 13);
            // 
            // divideButtonEmptySpace
            // 
            this.divideButtonEmptySpace.AllowHotTrack = false;
            this.divideButtonEmptySpace.CustomizationFormText = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.Location = new System.Drawing.Point(0, 100);
            this.divideButtonEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.divideButtonEmptySpace.Name = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.Size = new System.Drawing.Size(432, 36);
            this.divideButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.divideButtonEmptySpace.Text = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // HeatXtraForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(472, 202);
            this.Controls.Add(this.masterLayoutControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeatXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Плавка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HeatXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.HeatXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterLayoutControl)).EndInit();
            this.masterLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.steelGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsLeftEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturerLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlItem plateManufacturerLayoutControl;
        private DevExpress.XtraEditors.ComboBoxEdit number;
        private DevExpress.XtraEditors.ComboBoxEdit plateManufacturer;
    }
}