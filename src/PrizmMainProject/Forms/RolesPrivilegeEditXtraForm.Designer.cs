namespace PrizmMain.Forms
{
    partial class RolesPrivilegeEditXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesPrivilegeEditXtraForm));
            this.rootLayout = new DevExpress.XtraLayout.LayoutControl();
            this.priveleges = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.roleEdit = new DevExpress.XtraEditors.TextEdit();
            this.rootLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.privilege = new DevExpress.XtraLayout.LayoutControlItem();
            this.roleLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.privilegesLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.ItemForSaveButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCancelButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.divideButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.buttonLeftEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayout)).BeginInit();
            this.rootLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priveleges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLeftEmptySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            this.rootLayout.Controls.Add(this.priveleges);
            this.rootLayout.Controls.Add(this.roleEdit);
            this.rootLayout.Controls.Add(this.saveButton);
            this.rootLayout.Controls.Add(this.cancelButton);
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Location = new System.Drawing.Point(0, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(396, 131, 499, 350);
            this.rootLayout.Root = this.rootLayoutControlGroup;
            this.rootLayout.ShowTemplates = true;
            this.rootLayout.Size = new System.Drawing.Size(539, 516);
            this.rootLayout.TabIndex = 0;
            this.rootLayout.Text = "layoutControl1";
            // 
            // priveleges
            // 
            this.priveleges.Location = new System.Drawing.Point(32, 103);
            this.priveleges.Name = "priveleges";
            this.priveleges.Size = new System.Drawing.Size(475, 347);
            this.priveleges.StyleController = this.rootLayout;
            this.priveleges.TabIndex = 5;
            // 
            // roleEdit
            // 
            this.roleEdit.Location = new System.Drawing.Point(32, 48);
            this.roleEdit.Name = "roleEdit";
            this.roleEdit.Size = new System.Drawing.Size(475, 20);
            this.roleEdit.StyleController = this.rootLayout;
            this.roleEdit.TabIndex = 4;
            // 
            // rootLayoutControlGroup
            // 
            this.rootLayoutControlGroup.CustomizationFormText = "Root";
            this.rootLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.rootLayoutControlGroup.GroupBordersVisible = false;
            this.rootLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.privilege,
            this.roleLabel,
            this.privilegesLabel,
            this.ItemForSaveButton,
            this.ItemForCancelButton,
            this.divideButtonEmptySpace,
            this.buttonLeftEmptySpace});
            this.rootLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutControlGroup.Name = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.Size = new System.Drawing.Size(539, 516);
            this.rootLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.rootLayoutControlGroup.Text = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.TextVisible = false;
            // 
            // privilege
            // 
            this.privilege.Control = this.priveleges;
            this.privilege.CustomizationFormText = "privilege";
            this.privilege.Location = new System.Drawing.Point(0, 71);
            this.privilege.Name = "privilege";
            this.privilege.Size = new System.Drawing.Size(479, 358);
            this.privilege.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 7);
            this.privilege.Text = "privilege";
            this.privilege.TextSize = new System.Drawing.Size(0, 0);
            this.privilege.TextToControlDistance = 0;
            this.privilege.TextVisible = false;
            // 
            // roleLabel
            // 
            this.roleLabel.Control = this.roleEdit;
            this.roleLabel.CustomizationFormText = "Role";
            this.roleLabel.Location = new System.Drawing.Point(0, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(479, 47);
            this.roleLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 7);
            this.roleLabel.Text = "Роль пользователя";
            this.roleLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.roleLabel.TextSize = new System.Drawing.Size(172, 13);
            // 
            // privilegesLabel
            // 
            this.privilegesLabel.AllowHotTrack = false;
            this.privilegesLabel.CustomizationFormText = "Список привилегий пользователя";
            this.privilegesLabel.Location = new System.Drawing.Point(0, 47);
            this.privilegesLabel.Name = "privilegesLabel";
            this.privilegesLabel.Size = new System.Drawing.Size(479, 24);
            this.privilegesLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 7, 0);
            this.privilegesLabel.Text = "Список привилегий пользователя";
            this.privilegesLabel.TextSize = new System.Drawing.Size(172, 13);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(293, 461);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.StyleController = this.rootLayout;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(407, 461);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.StyleController = this.rootLayout;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отменить";
            // 
            // ItemForSaveButton
            // 
            this.ItemForSaveButton.Control = this.saveButton;
            this.ItemForSaveButton.CustomizationFormText = "layoutControlItem2";
            this.ItemForSaveButton.Location = new System.Drawing.Point(261, 429);
            this.ItemForSaveButton.MaxSize = new System.Drawing.Size(104, 27);
            this.ItemForSaveButton.MinSize = new System.Drawing.Size(104, 27);
            this.ItemForSaveButton.Name = "ItemForSaveButton";
            this.ItemForSaveButton.Size = new System.Drawing.Size(104, 27);
            this.ItemForSaveButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForSaveButton.Text = "layoutControlItem2";
            this.ItemForSaveButton.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForSaveButton.TextToControlDistance = 0;
            this.ItemForSaveButton.TextVisible = false;
            // 
            // ItemForCancelButton
            // 
            this.ItemForCancelButton.Control = this.cancelButton;
            this.ItemForCancelButton.CustomizationFormText = "layoutControlItem3";
            this.ItemForCancelButton.Location = new System.Drawing.Point(375, 429);
            this.ItemForCancelButton.MaxSize = new System.Drawing.Size(104, 27);
            this.ItemForCancelButton.MinSize = new System.Drawing.Size(104, 27);
            this.ItemForCancelButton.Name = "ItemForCancelButton";
            this.ItemForCancelButton.Size = new System.Drawing.Size(104, 27);
            this.ItemForCancelButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForCancelButton.Text = "layoutControlItem3";
            this.ItemForCancelButton.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForCancelButton.TextToControlDistance = 0;
            this.ItemForCancelButton.TextVisible = false;
            // 
            // divideButtonEmptySpace
            // 
            this.divideButtonEmptySpace.AllowHotTrack = false;
            this.divideButtonEmptySpace.CustomizationFormText = "emptySpaceItem1";
            this.divideButtonEmptySpace.Location = new System.Drawing.Point(365, 429);
            this.divideButtonEmptySpace.MaxSize = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.MinSize = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.Name = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.Size = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.divideButtonEmptySpace.Text = "emptySpaceItem1";
            this.divideButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // buttonLeftEmptySpace
            // 
            this.buttonLeftEmptySpace.AllowHotTrack = false;
            this.buttonLeftEmptySpace.CustomizationFormText = "emptySpaceItem2";
            this.buttonLeftEmptySpace.Location = new System.Drawing.Point(0, 429);
            this.buttonLeftEmptySpace.Name = "buttonLeftEmptySpace";
            this.buttonLeftEmptySpace.Size = new System.Drawing.Size(261, 27);
            this.buttonLeftEmptySpace.Text = "emptySpaceItem2";
            this.buttonLeftEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // RolesPrivilegeEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 516);
            this.Controls.Add(this.rootLayout);
            this.Name = "RolesPrivilegeEditXtraForm";
            this.Text = "Edit roles";
            ((System.ComponentModel.ISupportInitialize)(this.rootLayout)).EndInit();
            this.rootLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priveleges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLeftEmptySpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl rootLayout;
        private DevExpress.XtraEditors.CheckedListBoxControl priveleges;
        private DevExpress.XtraEditors.TextEdit roleEdit;
        private DevExpress.XtraLayout.LayoutControlGroup rootLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem privilege;
        private DevExpress.XtraLayout.LayoutControlItem roleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem privilegesLabel;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSaveButton;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCancelButton;
        private DevExpress.XtraLayout.EmptySpaceItem divideButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem buttonLeftEmptySpace;

    }
}