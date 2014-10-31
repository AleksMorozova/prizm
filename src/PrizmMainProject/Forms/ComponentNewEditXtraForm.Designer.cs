namespace PrizmMain.Forms
{
    partial class ComponentNewEditXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentNewEditXtraForm));
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.isActive = new DevExpress.XtraEditors.CheckEdit();
            this.length = new DevExpress.XtraEditors.TextEdit();
            this.connectorsCount = new DevExpress.XtraEditors.TextEdit();
            this.type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.name = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.certificate = new DevExpress.XtraEditors.TextEdit();
            this.rootLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.nameLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.typeLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lengthLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.connectorsLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.leftDeleteEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.leftButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.isDeletedLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.upperButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.saveButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonDelimiterEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectorsCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectorsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDeleteEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isDeletedLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelimiterEmptySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.isActive);
            this.mainLayoutControl.Controls.Add(this.length);
            this.mainLayoutControl.Controls.Add(this.connectorsCount);
            this.mainLayoutControl.Controls.Add(this.type);
            this.mainLayoutControl.Controls.Add(this.name);
            this.mainLayoutControl.Controls.Add(this.saveButton);
            this.mainLayoutControl.Controls.Add(this.cancelButton);
            this.mainLayoutControl.Controls.Add(this.certificate);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(245, 295, 250, 350);
            this.mainLayoutControl.Root = this.rootLayoutControlGroup;
            this.mainLayoutControl.ShowTemplates = true;
            this.mainLayoutControl.Size = new System.Drawing.Size(940, 450);
            this.mainLayoutControl.TabIndex = 0;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // isActive
            // 
            this.isActive.Location = new System.Drawing.Point(472, 255);
            this.isActive.Name = "isActive";
            this.isActive.Properties.Caption = "Удален";
            this.isActive.Size = new System.Drawing.Size(436, 19);
            this.isActive.StyleController = this.mainLayoutControl;
            this.isActive.TabIndex = 9;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(32, 217);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(876, 20);
            this.length.StyleController = this.mainLayoutControl;
            this.length.TabIndex = 8;
            // 
            // connectorsCount
            // 
            this.connectorsCount.Enabled = false;
            this.connectorsCount.Location = new System.Drawing.Point(487, 163);
            this.connectorsCount.Name = "connectorsCount";
            this.connectorsCount.Size = new System.Drawing.Size(421, 20);
            this.connectorsCount.StyleController = this.mainLayoutControl;
            this.connectorsCount.TabIndex = 7;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(32, 163);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Size = new System.Drawing.Size(421, 20);
            this.type.StyleController = this.mainLayoutControl;
            this.type.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(32, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(876, 20);
            this.name.StyleController = this.mainLayoutControl;
            this.name.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(694, 395);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.StyleController = this.mainLayoutControl;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(808, 395);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.StyleController = this.mainLayoutControl;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            // 
            // certificate
            // 
            this.certificate.Location = new System.Drawing.Point(32, 109);
            this.certificate.Name = "certificate";
            this.certificate.Size = new System.Drawing.Size(876, 20);
            this.certificate.StyleController = this.mainLayoutControl;
            this.certificate.TabIndex = 5;
            // 
            // rootLayoutControlGroup
            // 
            this.rootLayoutControlGroup.CustomizationFormText = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.rootLayoutControlGroup.GroupBordersVisible = false;
            this.rootLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.nameLabel,
            this.typeLabel,
            this.certificateLabel,
            this.lengthLabel,
            this.connectorsLabel,
            this.leftDeleteEmptySpace,
            this.leftButtonEmptySpace,
            this.isDeletedLayoutControl,
            this.upperButtonEmptySpace,
            this.saveButtonLayoutControl,
            this.cancelButtonLayoutControl,
            this.buttonDelimiterEmptySpace});
            this.rootLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutControlGroup.Name = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.Size = new System.Drawing.Size(940, 450);
            this.rootLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.rootLayoutControlGroup.Text = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.TextVisible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Control = this.name;
            this.nameLabel.CustomizationFormText = "Наименование компонента";
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(880, 54);
            this.nameLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 7, 7);
            this.nameLabel.Text = "Наименование компонента";
            this.nameLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.nameLabel.TextSize = new System.Drawing.Size(136, 13);
            // 
            // typeLabel
            // 
            this.typeLabel.Control = this.type;
            this.typeLabel.CustomizationFormText = "Тип компонента";
            this.typeLabel.Location = new System.Drawing.Point(0, 108);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(440, 54);
            this.typeLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 7);
            this.typeLabel.Text = "Тип компонента";
            this.typeLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.typeLabel.TextSize = new System.Drawing.Size(136, 13);
            // 
            // certificateLabel
            // 
            this.certificateLabel.Control = this.certificate;
            this.certificateLabel.CustomizationFormText = "Сертификат";
            this.certificateLabel.Location = new System.Drawing.Point(0, 54);
            this.certificateLabel.Name = "certificateLabel";
            this.certificateLabel.Size = new System.Drawing.Size(880, 54);
            this.certificateLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 7, 7);
            this.certificateLabel.Text = "Сертификат";
            this.certificateLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateLabel.TextSize = new System.Drawing.Size(136, 13);
            // 
            // lengthLabel
            // 
            this.lengthLabel.Control = this.length;
            this.lengthLabel.CustomizationFormText = "Длинна";
            this.lengthLabel.Location = new System.Drawing.Point(0, 162);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(880, 54);
            this.lengthLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 7, 7);
            this.lengthLabel.Text = "Длинна";
            this.lengthLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.lengthLabel.TextSize = new System.Drawing.Size(136, 13);
            // 
            // connectorsLabel
            // 
            this.connectorsLabel.Control = this.connectorsCount;
            this.connectorsLabel.CustomizationFormText = "Количество коннекторов";
            this.connectorsLabel.Location = new System.Drawing.Point(440, 108);
            this.connectorsLabel.Name = "connectorsLabel";
            this.connectorsLabel.Size = new System.Drawing.Size(440, 54);
            this.connectorsLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 0, 7, 7);
            this.connectorsLabel.Text = "Количество коннекторов";
            this.connectorsLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.connectorsLabel.TextSize = new System.Drawing.Size(136, 13);
            // 
            // leftDeleteEmptySpace
            // 
            this.leftDeleteEmptySpace.AllowHotTrack = false;
            this.leftDeleteEmptySpace.CustomizationFormText = "leftDeleteEmptySpace";
            this.leftDeleteEmptySpace.Location = new System.Drawing.Point(0, 216);
            this.leftDeleteEmptySpace.Name = "leftDeleteEmptySpace";
            this.leftDeleteEmptySpace.Size = new System.Drawing.Size(440, 30);
            this.leftDeleteEmptySpace.Text = "leftDeleteEmptySpace";
            this.leftDeleteEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // leftButtonEmptySpace
            // 
            this.leftButtonEmptySpace.AllowHotTrack = false;
            this.leftButtonEmptySpace.CustomizationFormText = "leftButtonEmptySpace";
            this.leftButtonEmptySpace.Location = new System.Drawing.Point(0, 363);
            this.leftButtonEmptySpace.Name = "leftButtonEmptySpace";
            this.leftButtonEmptySpace.Size = new System.Drawing.Size(662, 27);
            this.leftButtonEmptySpace.Text = "leftButtonEmptySpace";
            this.leftButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // isDeletedLayoutControl
            // 
            this.isDeletedLayoutControl.Control = this.isActive;
            this.isDeletedLayoutControl.CustomizationFormText = "isDeletedLayoutControl";
            this.isDeletedLayoutControl.Location = new System.Drawing.Point(440, 216);
            this.isDeletedLayoutControl.Name = "isDeletedLayoutControl";
            this.isDeletedLayoutControl.Size = new System.Drawing.Size(440, 30);
            this.isDeletedLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 7, 0);
            this.isDeletedLayoutControl.Text = "isDeletedLayoutControl";
            this.isDeletedLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.isDeletedLayoutControl.TextToControlDistance = 0;
            this.isDeletedLayoutControl.TextVisible = false;
            // 
            // upperButtonEmptySpace
            // 
            this.upperButtonEmptySpace.AllowHotTrack = false;
            this.upperButtonEmptySpace.CustomizationFormText = "upperButtonEmptySpace";
            this.upperButtonEmptySpace.Location = new System.Drawing.Point(0, 246);
            this.upperButtonEmptySpace.Name = "upperButtonEmptySpace";
            this.upperButtonEmptySpace.Size = new System.Drawing.Size(880, 117);
            this.upperButtonEmptySpace.Text = "upperButtonEmptySpace";
            this.upperButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // saveButtonLayoutControl
            // 
            this.saveButtonLayoutControl.Control = this.saveButton;
            this.saveButtonLayoutControl.CustomizationFormText = "saveButtonLayoutControl";
            this.saveButtonLayoutControl.Location = new System.Drawing.Point(662, 363);
            this.saveButtonLayoutControl.MaxSize = new System.Drawing.Size(104, 27);
            this.saveButtonLayoutControl.MinSize = new System.Drawing.Size(104, 27);
            this.saveButtonLayoutControl.Name = "saveButtonLayoutControl";
            this.saveButtonLayoutControl.Size = new System.Drawing.Size(104, 27);
            this.saveButtonLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.saveButtonLayoutControl.Text = "saveButtonLayoutControl";
            this.saveButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayoutControl.TextToControlDistance = 0;
            this.saveButtonLayoutControl.TextVisible = false;
            // 
            // cancelButtonLayoutControl
            // 
            this.cancelButtonLayoutControl.Control = this.cancelButton;
            this.cancelButtonLayoutControl.CustomizationFormText = "cancelButtonLayoutControl";
            this.cancelButtonLayoutControl.Location = new System.Drawing.Point(776, 363);
            this.cancelButtonLayoutControl.MaxSize = new System.Drawing.Size(104, 27);
            this.cancelButtonLayoutControl.MinSize = new System.Drawing.Size(104, 27);
            this.cancelButtonLayoutControl.Name = "cancelButtonLayoutControl";
            this.cancelButtonLayoutControl.Size = new System.Drawing.Size(104, 27);
            this.cancelButtonLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.cancelButtonLayoutControl.Text = "cancelButtonLayoutControl";
            this.cancelButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.cancelButtonLayoutControl.TextToControlDistance = 0;
            this.cancelButtonLayoutControl.TextVisible = false;
            // 
            // buttonDelimiterEmptySpace
            // 
            this.buttonDelimiterEmptySpace.AllowHotTrack = false;
            this.buttonDelimiterEmptySpace.CustomizationFormText = "buttonDelimiterEmptySpace";
            this.buttonDelimiterEmptySpace.Location = new System.Drawing.Point(766, 363);
            this.buttonDelimiterEmptySpace.MaxSize = new System.Drawing.Size(10, 27);
            this.buttonDelimiterEmptySpace.MinSize = new System.Drawing.Size(10, 27);
            this.buttonDelimiterEmptySpace.Name = "buttonDelimiterEmptySpace";
            this.buttonDelimiterEmptySpace.Size = new System.Drawing.Size(10, 27);
            this.buttonDelimiterEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonDelimiterEmptySpace.Text = "buttonDelimiterEmptySpace";
            this.buttonDelimiterEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ComponentNewEditXtraForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.mainLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentNewEditXtraForm";
            this.Text = "New or Edit Component";
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectorsCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectorsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDeleteEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isDeletedLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelimiterEmptySpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraEditors.CheckEdit isActive;
        private DevExpress.XtraEditors.TextEdit length;
        private DevExpress.XtraEditors.TextEdit connectorsCount;
        private DevExpress.XtraEditors.ComboBoxEdit type;
        private DevExpress.XtraEditors.TextEdit name;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlGroup rootLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem nameLabel;
        private DevExpress.XtraLayout.LayoutControlItem typeLabel;
        private DevExpress.XtraLayout.LayoutControlItem certificateLabel;
        private DevExpress.XtraLayout.LayoutControlItem lengthLabel;
        private DevExpress.XtraLayout.LayoutControlItem connectorsLabel;
        private DevExpress.XtraLayout.EmptySpaceItem leftDeleteEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem leftButtonEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem isDeletedLayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem upperButtonEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem cancelButtonLayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem buttonDelimiterEmptySpace;
        private DevExpress.XtraEditors.TextEdit certificate;

    }
}