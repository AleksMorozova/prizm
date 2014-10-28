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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.name = new DevExpress.XtraEditors.TextEdit();
            this.namelabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.typeLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.connectorsCount = new DevExpress.XtraEditors.TextEdit();
            this.connectorsLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lenght = new DevExpress.XtraEditors.TextEdit();
            this.lenghtLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.isActive = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.certificate = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namelabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectorsCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectorsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenght.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenghtLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.isActive);
            this.layoutControl1.Controls.Add(this.lenght);
            this.layoutControl1.Controls.Add(this.connectorsCount);
            this.layoutControl1.Controls.Add(this.type);
            this.layoutControl1.Controls.Add(this.name);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.certificate);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(340, 221, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.ShowTemplates = true;
            this.layoutControl1.Size = new System.Drawing.Size(940, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.namelabel,
            this.typeLabel,
            this.certificateLabel,
            this.lenghtLabel,
            this.connectorsLabel,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem4,
            this.emptySpaceItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(940, 450);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(916, 20);
            this.name.StyleController = this.layoutControl1;
            this.name.TabIndex = 4;
            // 
            // namelabel
            // 
            this.namelabel.Control = this.name;
            this.namelabel.CustomizationFormText = "Наименование компонента";
            this.namelabel.Location = new System.Drawing.Point(0, 0);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(920, 40);
            this.namelabel.Text = "Наименование компонента";
            this.namelabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.namelabel.TextSize = new System.Drawing.Size(136, 13);
            // 
            // certificateLabel
            // 
            this.certificateLabel.Control = this.certificate;
            this.certificateLabel.CustomizationFormText = "Сертификат";
            this.certificateLabel.Location = new System.Drawing.Point(0, 40);
            this.certificateLabel.Name = "certificateLabel";
            this.certificateLabel.Size = new System.Drawing.Size(920, 40);
            this.certificateLabel.Text = "Сертификат";
            this.certificateLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateLabel.TextSize = new System.Drawing.Size(136, 13);
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(12, 108);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Size = new System.Drawing.Size(456, 20);
            this.type.StyleController = this.layoutControl1;
            this.type.TabIndex = 6;
            // 
            // typeLabel
            // 
            this.typeLabel.Control = this.type;
            this.typeLabel.CustomizationFormText = "Тип компонента";
            this.typeLabel.Location = new System.Drawing.Point(0, 80);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(460, 40);
            this.typeLabel.Text = "Тип компонента";
            this.typeLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.typeLabel.TextSize = new System.Drawing.Size(136, 13);
            // 
            // connectorsCount
            // 
            this.connectorsCount.Enabled = false;
            this.connectorsCount.Location = new System.Drawing.Point(472, 108);
            this.connectorsCount.Name = "connectorsCount";
            this.connectorsCount.Size = new System.Drawing.Size(456, 20);
            this.connectorsCount.StyleController = this.layoutControl1;
            this.connectorsCount.TabIndex = 7;
            // 
            // connectorsLabel
            // 
            this.connectorsLabel.Control = this.connectorsCount;
            this.connectorsLabel.CustomizationFormText = "Количество коннекторов";
            this.connectorsLabel.Location = new System.Drawing.Point(460, 80);
            this.connectorsLabel.Name = "connectorsLabel";
            this.connectorsLabel.Size = new System.Drawing.Size(460, 40);
            this.connectorsLabel.Text = "Количество коннекторов";
            this.connectorsLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.connectorsLabel.TextSize = new System.Drawing.Size(136, 13);
            // 
            // lenght
            // 
            this.lenght.Location = new System.Drawing.Point(12, 148);
            this.lenght.Name = "lenght";
            this.lenght.Size = new System.Drawing.Size(916, 20);
            this.lenght.StyleController = this.layoutControl1;
            this.lenght.TabIndex = 8;
            // 
            // lenghtLabel
            // 
            this.lenghtLabel.Control = this.lenght;
            this.lenghtLabel.CustomizationFormText = "Длинна";
            this.lenghtLabel.Location = new System.Drawing.Point(0, 120);
            this.lenghtLabel.Name = "lenghtLabel";
            this.lenghtLabel.Size = new System.Drawing.Size(920, 40);
            this.lenghtLabel.Text = "Длинна";
            this.lenghtLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.lenghtLabel.TextSize = new System.Drawing.Size(136, 13);
            // 
            // isActive
            // 
            this.isActive.Location = new System.Drawing.Point(472, 172);
            this.isActive.Name = "isActive";
            this.isActive.Properties.Caption = "Удален";
            this.isActive.Size = new System.Drawing.Size(456, 19);
            this.isActive.StyleController = this.layoutControl1;
            this.isActive.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.isActive;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(460, 160);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(460, 23);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 183);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(920, 220);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 160);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(460, 23);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 403);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(460, 27);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(782, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(66, 23);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(862, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(66, 23);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.saveButton;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem7.Location = new System.Drawing.Point(770, 403);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(70, 27);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(70, 27);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(70, 27);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "layoutControlItem2";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cancelButton;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem8.Location = new System.Drawing.Point(850, 403);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(70, 27);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(70, 27);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(70, 27);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "layoutControlItem3";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem4.Location = new System.Drawing.Point(840, 403);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 27);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.Text = "emptySpaceItem1";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem5.Location = new System.Drawing.Point(460, 403);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(310, 27);
            this.emptySpaceItem5.Text = "emptySpaceItem2";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // certificate
            // 
            this.certificate.Location = new System.Drawing.Point(12, 68);
            this.certificate.Name = "certificate";
            this.certificate.Size = new System.Drawing.Size(916, 20);
            this.certificate.StyleController = this.layoutControl1;
            this.certificate.TabIndex = 5;
            // 
            // ComponentNewEditXtraForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentNewEditXtraForm";
            this.Text = "New or Edit Component";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namelabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectorsCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectorsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenght.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenghtLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit isActive;
        private DevExpress.XtraEditors.TextEdit lenght;
        private DevExpress.XtraEditors.TextEdit connectorsCount;
        private DevExpress.XtraEditors.ComboBoxEdit type;
        private DevExpress.XtraEditors.TextEdit name;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem namelabel;
        private DevExpress.XtraLayout.LayoutControlItem typeLabel;
        private DevExpress.XtraLayout.LayoutControlItem certificateLabel;
        private DevExpress.XtraLayout.LayoutControlItem lenghtLabel;
        private DevExpress.XtraLayout.LayoutControlItem connectorsLabel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.TextEdit certificate;

    }
}