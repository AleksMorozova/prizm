namespace PrizmMain.Forms
{
    partial class UserInfoXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoXtraForm));
            this.rootLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.LastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MiddleNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LoginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.RoleComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.mainGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForRole = new DevExpress.XtraLayout.LayoutControlItem();
            this.upButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForSaveButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCancelButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.divideButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.leftButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMiddleName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.divideLoginEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rootLayout)).BeginInit();
            this.rootLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMiddleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideLoginEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            this.rootLayout.Controls.Add(this.LastNameTextEdit);
            this.rootLayout.Controls.Add(this.FirstNameTextEdit);
            this.rootLayout.Controls.Add(this.MiddleNameTextEdit);
            this.rootLayout.Controls.Add(this.LoginTextEdit);
            this.rootLayout.Controls.Add(this.PasswordTextEdit);
            this.rootLayout.Controls.Add(this.saveButton);
            this.rootLayout.Controls.Add(this.cancelButton);
            this.rootLayout.Controls.Add(this.RoleComboBoxEdit);
            this.rootLayout.DataSource = this.userBindingSource;
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Location = new System.Drawing.Point(0, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(402, 135, 496, 350);
            this.rootLayout.Root = this.layoutControlGroup1;
            this.rootLayout.ShowTemplates = true;
            this.rootLayout.Size = new System.Drawing.Size(539, 516);
            this.rootLayout.TabIndex = 0;
            this.rootLayout.Text = "dataLayoutControl1";
            // 
            // LastNameTextEdit
            // 
            this.LastNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "LastName", true));
            this.LastNameTextEdit.Location = new System.Drawing.Point(47, 55);
            this.LastNameTextEdit.Name = "LastNameTextEdit";
            this.LastNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.LastNameTextEdit.Size = new System.Drawing.Size(445, 26);
            this.LastNameTextEdit.StyleController = this.rootLayout;
            this.LastNameTextEdit.TabIndex = 5;
            // 
            // FirstNameTextEdit
            // 
            this.FirstNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "FirstName", true));
            this.FirstNameTextEdit.Location = new System.Drawing.Point(47, 115);
            this.FirstNameTextEdit.Name = "FirstNameTextEdit";
            this.FirstNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.FirstNameTextEdit.Size = new System.Drawing.Size(205, 26);
            this.FirstNameTextEdit.StyleController = this.rootLayout;
            this.FirstNameTextEdit.TabIndex = 6;
            // 
            // MiddleNameTextEdit
            // 
            this.MiddleNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "MiddleName", true));
            this.MiddleNameTextEdit.Location = new System.Drawing.Point(286, 115);
            this.MiddleNameTextEdit.Name = "MiddleNameTextEdit";
            this.MiddleNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.MiddleNameTextEdit.Size = new System.Drawing.Size(206, 26);
            this.MiddleNameTextEdit.StyleController = this.rootLayout;
            this.MiddleNameTextEdit.TabIndex = 7;
            // 
            // LoginTextEdit
            // 
            this.LoginTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Login", true));
            this.LoginTextEdit.Location = new System.Drawing.Point(47, 225);
            this.LoginTextEdit.Name = "LoginTextEdit";
            this.LoginTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextEdit.Properties.Appearance.Options.UseFont = true;
            this.LoginTextEdit.Size = new System.Drawing.Size(205, 26);
            this.LoginTextEdit.StyleController = this.rootLayout;
            this.LoginTextEdit.TabIndex = 8;
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Password", true));
            this.PasswordTextEdit.Location = new System.Drawing.Point(286, 225);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextEdit.Properties.Appearance.Options.UseFont = true;
            this.PasswordTextEdit.Properties.PasswordChar = '*';
            this.PasswordTextEdit.Size = new System.Drawing.Size(206, 26);
            this.PasswordTextEdit.StyleController = this.rootLayout;
            this.PasswordTextEdit.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(301, 461);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 23);
            this.saveButton.StyleController = this.rootLayout;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(411, 461);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 23);
            this.cancelButton.StyleController = this.rootLayout;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // RoleComboBoxEdit
            // 
            this.RoleComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Role", true));
            this.RoleComboBoxEdit.Location = new System.Drawing.Point(47, 285);
            this.RoleComboBoxEdit.Name = "RoleComboBoxEdit";
            this.RoleComboBoxEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleComboBoxEdit.Properties.Appearance.Options.UseFont = true;
            this.RoleComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RoleComboBoxEdit.Size = new System.Drawing.Size(445, 26);
            this.RoleComboBoxEdit.StyleController = this.rootLayout;
            this.RoleComboBoxEdit.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.mainGroup,
            this.upButtonEmptySpace,
            this.ItemForSaveButton,
            this.ItemForCancelButton,
            this.divideButtonEmptySpace,
            this.leftButtonEmptySpace});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(539, 516);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // mainGroup
            // 
            this.mainGroup.AllowDrawBackground = false;
            this.mainGroup.CustomizationFormText = "autoGeneratedGroup0";
            this.mainGroup.GroupBordersVisible = false;
            this.mainGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForRole,
            this.ItemForLastName,
            this.ItemForFirstName,
            this.ItemForLogin,
            this.ItemForPassword,
            this.ItemForMiddleName,
            this.divideLoginEmptySpace});
            this.mainGroup.Location = new System.Drawing.Point(0, 0);
            this.mainGroup.Name = "mainGroup";
            this.mainGroup.Size = new System.Drawing.Size(479, 290);
            this.mainGroup.Text = "mainGroup";
            // 
            // ItemForRole
            // 
            this.ItemForRole.Control = this.RoleComboBoxEdit;
            this.ItemForRole.CustomizationFormText = "Role";
            this.ItemForRole.Location = new System.Drawing.Point(0, 230);
            this.ItemForRole.Name = "ItemForRole";
            this.ItemForRole.Size = new System.Drawing.Size(479, 60);
            this.ItemForRole.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.ItemForRole.Text = "Роль позователя";
            this.ItemForRole.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForRole.TextSize = new System.Drawing.Size(86, 13);
            // 
            // upButtonEmptySpace
            // 
            this.upButtonEmptySpace.AllowHotTrack = false;
            this.upButtonEmptySpace.CustomizationFormText = "upButtonEmptySpace";
            this.upButtonEmptySpace.Location = new System.Drawing.Point(0, 290);
            this.upButtonEmptySpace.Name = "upButtonEmptySpace";
            this.upButtonEmptySpace.Size = new System.Drawing.Size(479, 139);
            this.upButtonEmptySpace.Text = "upButtonEmptySpace";
            this.upButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForSaveButton
            // 
            this.ItemForSaveButton.Control = this.saveButton;
            this.ItemForSaveButton.CustomizationFormText = "layoutControlItem2";
            this.ItemForSaveButton.Location = new System.Drawing.Point(269, 429);
            this.ItemForSaveButton.MaxSize = new System.Drawing.Size(100, 27);
            this.ItemForSaveButton.MinSize = new System.Drawing.Size(100, 27);
            this.ItemForSaveButton.Name = "ItemForSaveButton";
            this.ItemForSaveButton.Size = new System.Drawing.Size(100, 27);
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
            this.ItemForCancelButton.Location = new System.Drawing.Point(379, 429);
            this.ItemForCancelButton.MaxSize = new System.Drawing.Size(100, 27);
            this.ItemForCancelButton.MinSize = new System.Drawing.Size(100, 27);
            this.ItemForCancelButton.Name = "ItemForCancelButton";
            this.ItemForCancelButton.Size = new System.Drawing.Size(100, 27);
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
            this.divideButtonEmptySpace.Location = new System.Drawing.Point(369, 429);
            this.divideButtonEmptySpace.MaxSize = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.MinSize = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.Name = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.Size = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.divideButtonEmptySpace.Text = "emptySpaceItem1";
            this.divideButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // leftButtonEmptySpace
            // 
            this.leftButtonEmptySpace.AllowHotTrack = false;
            this.leftButtonEmptySpace.CustomizationFormText = "emptySpaceItem2";
            this.leftButtonEmptySpace.Location = new System.Drawing.Point(0, 429);
            this.leftButtonEmptySpace.Name = "leftButtonEmptySpace";
            this.leftButtonEmptySpace.Size = new System.Drawing.Size(269, 27);
            this.leftButtonEmptySpace.Text = "emptySpaceItem2";
            this.leftButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForLastName
            // 
            this.ItemForLastName.Control = this.LastNameTextEdit;
            this.ItemForLastName.CustomizationFormText = "Last Name";
            this.ItemForLastName.Location = new System.Drawing.Point(0, 0);
            this.ItemForLastName.Name = "ItemForLastName";
            this.ItemForLastName.Size = new System.Drawing.Size(479, 60);
            this.ItemForLastName.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.ItemForLastName.Text = "Фамилия";
            this.ItemForLastName.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForLastName.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForFirstName
            // 
            this.ItemForFirstName.Control = this.FirstNameTextEdit;
            this.ItemForFirstName.CustomizationFormText = "First Name";
            this.ItemForFirstName.Location = new System.Drawing.Point(0, 60);
            this.ItemForFirstName.Name = "ItemForFirstName";
            this.ItemForFirstName.Size = new System.Drawing.Size(239, 60);
            this.ItemForFirstName.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.ItemForFirstName.Text = "Имя";
            this.ItemForFirstName.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForFirstName.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForMiddleName
            // 
            this.ItemForMiddleName.Control = this.MiddleNameTextEdit;
            this.ItemForMiddleName.CustomizationFormText = "Middle Name";
            this.ItemForMiddleName.Location = new System.Drawing.Point(239, 60);
            this.ItemForMiddleName.Name = "ItemForMiddleName";
            this.ItemForMiddleName.Size = new System.Drawing.Size(240, 60);
            this.ItemForMiddleName.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.ItemForMiddleName.Text = "Отчество";
            this.ItemForMiddleName.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForMiddleName.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForLogin
            // 
            this.ItemForLogin.Control = this.LoginTextEdit;
            this.ItemForLogin.CustomizationFormText = "Login";
            this.ItemForLogin.Location = new System.Drawing.Point(0, 170);
            this.ItemForLogin.Name = "ItemForLogin";
            this.ItemForLogin.Size = new System.Drawing.Size(239, 60);
            this.ItemForLogin.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.ItemForLogin.Text = "Логин";
            this.ItemForLogin.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForLogin.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForPassword
            // 
            this.ItemForPassword.Control = this.PasswordTextEdit;
            this.ItemForPassword.CustomizationFormText = "Password";
            this.ItemForPassword.Location = new System.Drawing.Point(239, 170);
            this.ItemForPassword.Name = "ItemForPassword";
            this.ItemForPassword.Size = new System.Drawing.Size(240, 60);
            this.ItemForPassword.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.ItemForPassword.Text = "Пароль";
            this.ItemForPassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForPassword.TextSize = new System.Drawing.Size(86, 13);
            // 
            // divideLoginEmptySpace
            // 
            this.divideLoginEmptySpace.AllowHotTrack = false;
            this.divideLoginEmptySpace.CustomizationFormText = "divideLoginEmptySpace";
            this.divideLoginEmptySpace.Location = new System.Drawing.Point(0, 120);
            this.divideLoginEmptySpace.Name = "divideLoginEmptySpace";
            this.divideLoginEmptySpace.Size = new System.Drawing.Size(479, 50);
            this.divideLoginEmptySpace.Text = "divideLoginEmptySpace";
            this.divideLoginEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(PrizmMain.DummyData.User);
            // 
            // UserInfoXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 516);
            this.Controls.Add(this.rootLayout);
            this.Name = "UserInfoXtraForm";
            this.Text = "Edit User";
            ((System.ComponentModel.ISupportInitialize)(this.rootLayout)).EndInit();
            this.rootLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMiddleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideLoginEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl rootLayout;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.TextEdit LastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit MiddleNameTextEdit;
        private DevExpress.XtraEditors.TextEdit LoginTextEdit;
        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup mainGroup;
        private DevExpress.XtraLayout.EmptySpaceItem upButtonEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSaveButton;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCancelButton;
        private DevExpress.XtraLayout.EmptySpaceItem divideButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem leftButtonEmptySpace;
        private DevExpress.XtraEditors.ComboBoxEdit RoleComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRole;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLogin;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPassword;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMiddleName;
        private DevExpress.XtraLayout.EmptySpaceItem divideLoginEmptySpace;

    }
}