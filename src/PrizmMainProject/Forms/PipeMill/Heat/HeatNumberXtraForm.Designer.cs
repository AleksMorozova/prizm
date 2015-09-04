namespace Prizm.Main.Forms.PipeMill.Heat
{
    partial class HeatNumberXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeatNumberXtraForm));
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.number = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.rootLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.numberLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.okButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonDividerEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.buttonLeftEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDividerEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLeftEmptySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.number);
            this.mainLayoutControl.Controls.Add(this.saveButton);
            this.mainLayoutControl.Controls.Add(this.cancelButton);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(201, 355, 250, 350);
            this.mainLayoutControl.Root = this.rootLayoutControlGroup;
            this.mainLayoutControl.Size = new System.Drawing.Size(358, 105);
            this.mainLayoutControl.TabIndex = 0;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(19, 35);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(327, 20);
            this.number.StyleController = this.mainLayoutControl;
            this.number.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(120, 66);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 23);
            this.saveButton.StyleController = this.mainLayoutControl;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "&Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(240, 66);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 23);
            this.cancelButton.StyleController = this.mainLayoutControl;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "О&тменить";
            // 
            // rootLayoutControlGroup
            // 
            this.rootLayoutControlGroup.CustomizationFormText = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.rootLayoutControlGroup.GroupBordersVisible = false;
            this.rootLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.numberLayoutControl,
            this.okButtonLayoutControl,
            this.cancelButtonLayoutControl,
            this.buttonDividerEmptySpace,
            this.buttonLeftEmptySpace});
            this.rootLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutControlGroup.Name = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.Size = new System.Drawing.Size(358, 105);
            this.rootLayoutControlGroup.Text = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.TextVisible = false;
            // 
            // numberLayoutControl
            // 
            this.numberLayoutControl.Control = this.number;
            this.numberLayoutControl.CustomizationFormText = "Ном&ер плавки";
            this.numberLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.numberLayoutControl.Name = "numberLayoutControl";
            this.numberLayoutControl.Size = new System.Drawing.Size(338, 54);
            this.numberLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 0, 7, 7);
            this.numberLayoutControl.Text = "Номер плавки";
            this.numberLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.numberLayoutControl.TextSize = new System.Drawing.Size(70, 13);
            // 
            // okButtonLayoutControl
            // 
            this.okButtonLayoutControl.Control = this.saveButton;
            this.okButtonLayoutControl.CustomizationFormText = "okButtonLayoutControl";
            this.okButtonLayoutControl.Location = new System.Drawing.Point(108, 54);
            this.okButtonLayoutControl.MaxSize = new System.Drawing.Size(170, 27);
            this.okButtonLayoutControl.MinSize = new System.Drawing.Size(100, 27);
            this.okButtonLayoutControl.Name = "okButtonLayoutControl";
            this.okButtonLayoutControl.Size = new System.Drawing.Size(110, 31);
            this.okButtonLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.okButtonLayoutControl.Text = "okButtonLayoutControl";
            this.okButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.okButtonLayoutControl.TextVisible = false;
            // 
            // cancelButtonLayoutControl
            // 
            this.cancelButtonLayoutControl.Control = this.cancelButton;
            this.cancelButtonLayoutControl.CustomizationFormText = "cancelButtonLayoutControl";
            this.cancelButtonLayoutControl.Location = new System.Drawing.Point(228, 54);
            this.cancelButtonLayoutControl.MaxSize = new System.Drawing.Size(170, 27);
            this.cancelButtonLayoutControl.MinSize = new System.Drawing.Size(100, 27);
            this.cancelButtonLayoutControl.Name = "cancelButtonLayoutControl";
            this.cancelButtonLayoutControl.Size = new System.Drawing.Size(110, 31);
            this.cancelButtonLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.cancelButtonLayoutControl.Text = "cancelButtonLayoutControl";
            this.cancelButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayoutControl.TextVisible = false;
            // 
            // buttonDividerEmptySpace
            // 
            this.buttonDividerEmptySpace.AllowHotTrack = false;
            this.buttonDividerEmptySpace.CustomizationFormText = "buttonDividerEmptySpace";
            this.buttonDividerEmptySpace.Location = new System.Drawing.Point(218, 54);
            this.buttonDividerEmptySpace.MaxSize = new System.Drawing.Size(10, 27);
            this.buttonDividerEmptySpace.MinSize = new System.Drawing.Size(10, 27);
            this.buttonDividerEmptySpace.Name = "buttonDividerEmptySpace";
            this.buttonDividerEmptySpace.Size = new System.Drawing.Size(10, 31);
            this.buttonDividerEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonDividerEmptySpace.Text = "buttonDividerEmptySpace";
            this.buttonDividerEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // buttonLeftEmptySpace
            // 
            this.buttonLeftEmptySpace.AllowHotTrack = false;
            this.buttonLeftEmptySpace.CustomizationFormText = "buttonLeftEmptySpace";
            this.buttonLeftEmptySpace.Location = new System.Drawing.Point(0, 54);
            this.buttonLeftEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.buttonLeftEmptySpace.Name = "buttonLeftEmptySpace";
            this.buttonLeftEmptySpace.Size = new System.Drawing.Size(108, 31);
            this.buttonLeftEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonLeftEmptySpace.Text = "buttonLeftEmptySpace";
            this.buttonLeftEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // HeatNumberXtraForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(358, 105);
            this.Controls.Add(this.mainLayoutControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeatNumberXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление плавки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HeatNumberXtraForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDividerEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLeftEmptySpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup rootLayoutControlGroup;
        private DevExpress.XtraEditors.TextEdit number;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlItem numberLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem okButtonLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem cancelButtonLayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem buttonDividerEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem buttonLeftEmptySpace;
    }
}