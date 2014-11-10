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
            this.lastName = new DevExpress.XtraEditors.TextEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstName = new DevExpress.XtraEditors.TextEdit();
            this.middleName = new DevExpress.XtraEditors.TextEdit();
            this.login = new DevExpress.XtraEditors.TextEdit();
            this.password = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.role = new DevExpress.XtraEditors.ComboBoxEdit();
            this.rootLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.mainGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemForRole = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForMiddleName = new DevExpress.XtraLayout.LayoutControlItem();
            this.divideLoginEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.upButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.itemForSaveButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForCancelButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.divideButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.leftButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayout)).BeginInit();
            this.rootLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.role.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForMiddleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideLoginEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForSaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonEmptySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            this.rootLayout.Controls.Add(this.lastName);
            this.rootLayout.Controls.Add(this.firstName);
            this.rootLayout.Controls.Add(this.middleName);
            this.rootLayout.Controls.Add(this.login);
            this.rootLayout.Controls.Add(this.password);
            this.rootLayout.Controls.Add(this.saveButton);
            this.rootLayout.Controls.Add(this.cancelButton);
            this.rootLayout.Controls.Add(this.role);
            this.rootLayout.DataSource = this.userBindingSource;
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Location = new System.Drawing.Point(0, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(402, 135, 496, 350);
            this.rootLayout.Root = this.rootLayoutControlGroup;
            this.rootLayout.ShowTemplates = true;
            this.rootLayout.Size = new System.Drawing.Size(539, 516);
            this.rootLayout.TabIndex = 0;
            this.rootLayout.Text = "dataLayoutControl1";
            // 
            // lastName
            // 
            this.lastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "LastName", true));
            this.lastName.Location = new System.Drawing.Point(47, 55);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(445, 20);
            this.lastName.StyleController = this.rootLayout;
            this.lastName.TabIndex = 5;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(PrizmMain.DummyData.User);
            // 
            // firstName
            // 
            this.firstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "FirstName", true));
            this.firstName.Location = new System.Drawing.Point(47, 109);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(205, 20);
            this.firstName.StyleController = this.rootLayout;
            this.firstName.TabIndex = 6;
            // 
            // middleName
            // 
            this.middleName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "MiddleName", true));
            this.middleName.Location = new System.Drawing.Point(286, 109);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(206, 20);
            this.middleName.StyleController = this.rootLayout;
            this.middleName.TabIndex = 7;
            // 
            // login
            // 
            this.login.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Login", true));
            this.login.Location = new System.Drawing.Point(47, 237);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(205, 20);
            this.login.StyleController = this.rootLayout;
            this.login.TabIndex = 8;
            // 
            // password
            // 
            this.password.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Password", true));
            this.password.Location = new System.Drawing.Point(286, 237);
            this.password.Name = "password";
            this.password.Properties.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(206, 20);
            this.password.StyleController = this.rootLayout;
            this.password.TabIndex = 9;
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
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // role
            // 
            this.role.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Role", true));
            this.role.Location = new System.Drawing.Point(47, 291);
            this.role.Name = "role";
            this.role.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.role.Size = new System.Drawing.Size(445, 20);
            this.role.StyleController = this.rootLayout;
            this.role.TabIndex = 11;
            // 
            // rootLayoutControlGroup
            // 
            this.rootLayoutControlGroup.CustomizationFormText = "Root";
            this.rootLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.rootLayoutControlGroup.GroupBordersVisible = false;
            this.rootLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.mainGroup,
            this.upButtonEmptySpace,
            this.itemForSaveButton,
            this.itemForCancelButton,
            this.divideButtonEmptySpace,
            this.leftButtonEmptySpace});
            this.rootLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutControlGroup.Name = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.Size = new System.Drawing.Size(539, 516);
            this.rootLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.rootLayoutControlGroup.Text = "rootLayoutControlGroup";
            this.rootLayoutControlGroup.TextVisible = false;
            // 
            // mainGroup
            // 
            this.mainGroup.AllowDrawBackground = false;
            this.mainGroup.CustomizationFormText = "autoGeneratedGroup0";
            this.mainGroup.GroupBordersVisible = false;
            this.mainGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemForRole,
            this.itemForLastName,
            this.itemForFirstName,
            this.itemForLogin,
            this.itemForPassword,
            this.itemForMiddleName,
            this.divideLoginEmptySpace});
            this.mainGroup.Location = new System.Drawing.Point(0, 0);
            this.mainGroup.Name = "mainGroup";
            this.mainGroup.Size = new System.Drawing.Size(479, 290);
            this.mainGroup.Text = "mainGroup";
            // 
            // itemForRole
            // 
            this.itemForRole.Control = this.role;
            this.itemForRole.CustomizationFormText = "Role";
            this.itemForRole.Location = new System.Drawing.Point(0, 236);
            this.itemForRole.Name = "itemForRole";
            this.itemForRole.Size = new System.Drawing.Size(479, 54);
            this.itemForRole.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.itemForRole.Text = "Роль позователя";
            this.itemForRole.TextLocation = DevExpress.Utils.Locations.Top;
            this.itemForRole.TextSize = new System.Drawing.Size(86, 13);
            // 
            // itemForLastName
            // 
            this.itemForLastName.Control = this.lastName;
            this.itemForLastName.CustomizationFormText = "Last Name";
            this.itemForLastName.Location = new System.Drawing.Point(0, 0);
            this.itemForLastName.Name = "itemForLastName";
            this.itemForLastName.Size = new System.Drawing.Size(479, 54);
            this.itemForLastName.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.itemForLastName.Text = "Фамилия";
            this.itemForLastName.TextLocation = DevExpress.Utils.Locations.Top;
            this.itemForLastName.TextSize = new System.Drawing.Size(86, 13);
            // 
            // itemForFirstName
            // 
            this.itemForFirstName.Control = this.firstName;
            this.itemForFirstName.CustomizationFormText = "First Name";
            this.itemForFirstName.Location = new System.Drawing.Point(0, 54);
            this.itemForFirstName.Name = "itemForFirstName";
            this.itemForFirstName.Size = new System.Drawing.Size(239, 54);
            this.itemForFirstName.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.itemForFirstName.Text = "Имя";
            this.itemForFirstName.TextLocation = DevExpress.Utils.Locations.Top;
            this.itemForFirstName.TextSize = new System.Drawing.Size(86, 13);
            // 
            // itemForLogin
            // 
            this.itemForLogin.Control = this.login;
            this.itemForLogin.CustomizationFormText = "Login";
            this.itemForLogin.Location = new System.Drawing.Point(0, 182);
            this.itemForLogin.Name = "itemForLogin";
            this.itemForLogin.Size = new System.Drawing.Size(239, 54);
            this.itemForLogin.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.itemForLogin.Text = "Логин";
            this.itemForLogin.TextLocation = DevExpress.Utils.Locations.Top;
            this.itemForLogin.TextSize = new System.Drawing.Size(86, 13);
            // 
            // itemForPassword
            // 
            this.itemForPassword.Control = this.password;
            this.itemForPassword.CustomizationFormText = "Password";
            this.itemForPassword.Location = new System.Drawing.Point(239, 182);
            this.itemForPassword.Name = "itemForPassword";
            this.itemForPassword.Size = new System.Drawing.Size(240, 54);
            this.itemForPassword.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.itemForPassword.Text = "Пароль";
            this.itemForPassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.itemForPassword.TextSize = new System.Drawing.Size(86, 13);
            // 
            // itemForMiddleName
            // 
            this.itemForMiddleName.Control = this.middleName;
            this.itemForMiddleName.CustomizationFormText = "Middle Name";
            this.itemForMiddleName.Location = new System.Drawing.Point(239, 54);
            this.itemForMiddleName.Name = "itemForMiddleName";
            this.itemForMiddleName.Size = new System.Drawing.Size(240, 54);
            this.itemForMiddleName.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.itemForMiddleName.Text = "Отчество";
            this.itemForMiddleName.TextLocation = DevExpress.Utils.Locations.Top;
            this.itemForMiddleName.TextSize = new System.Drawing.Size(86, 13);
            // 
            // divideLoginEmptySpace
            // 
            this.divideLoginEmptySpace.AllowHotTrack = false;
            this.divideLoginEmptySpace.CustomizationFormText = "divideLoginEmptySpace";
            this.divideLoginEmptySpace.Location = new System.Drawing.Point(0, 108);
            this.divideLoginEmptySpace.Name = "divideLoginEmptySpace";
            this.divideLoginEmptySpace.Size = new System.Drawing.Size(479, 74);
            this.divideLoginEmptySpace.Text = "divideLoginEmptySpace";
            this.divideLoginEmptySpace.TextSize = new System.Drawing.Size(0, 0);
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
            // itemForSaveButton
            // 
            this.itemForSaveButton.Control = this.saveButton;
            this.itemForSaveButton.CustomizationFormText = "itemForSaveButton";
            this.itemForSaveButton.Location = new System.Drawing.Point(269, 429);
            this.itemForSaveButton.MaxSize = new System.Drawing.Size(100, 27);
            this.itemForSaveButton.MinSize = new System.Drawing.Size(100, 27);
            this.itemForSaveButton.Name = "itemForSaveButton";
            this.itemForSaveButton.Size = new System.Drawing.Size(100, 27);
            this.itemForSaveButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.itemForSaveButton.Text = "itemForSaveButton";
            this.itemForSaveButton.TextSize = new System.Drawing.Size(0, 0);
            this.itemForSaveButton.TextToControlDistance = 0;
            this.itemForSaveButton.TextVisible = false;
            // 
            // itemForCancelButton
            // 
            this.itemForCancelButton.Control = this.cancelButton;
            this.itemForCancelButton.CustomizationFormText = "itemForCancelButton";
            this.itemForCancelButton.Location = new System.Drawing.Point(379, 429);
            this.itemForCancelButton.MaxSize = new System.Drawing.Size(100, 27);
            this.itemForCancelButton.MinSize = new System.Drawing.Size(100, 27);
            this.itemForCancelButton.Name = "itemForCancelButton";
            this.itemForCancelButton.Size = new System.Drawing.Size(100, 27);
            this.itemForCancelButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.itemForCancelButton.Text = "itemForCancelButton";
            this.itemForCancelButton.TextSize = new System.Drawing.Size(0, 0);
            this.itemForCancelButton.TextToControlDistance = 0;
            this.itemForCancelButton.TextVisible = false;
            // 
            // divideButtonEmptySpace
            // 
            this.divideButtonEmptySpace.AllowHotTrack = false;
            this.divideButtonEmptySpace.CustomizationFormText = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.Location = new System.Drawing.Point(369, 429);
            this.divideButtonEmptySpace.MaxSize = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.MinSize = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.Name = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.Size = new System.Drawing.Size(10, 27);
            this.divideButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.divideButtonEmptySpace.Text = "divideButtonEmptySpace";
            this.divideButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // leftButtonEmptySpace
            // 
            this.leftButtonEmptySpace.AllowHotTrack = false;
            this.leftButtonEmptySpace.CustomizationFormText = "leftButtonEmptySpace";
            this.leftButtonEmptySpace.Location = new System.Drawing.Point(0, 429);
            this.leftButtonEmptySpace.Name = "leftButtonEmptySpace";
            this.leftButtonEmptySpace.Size = new System.Drawing.Size(269, 27);
            this.leftButtonEmptySpace.Text = "leftButtonEmptySpace";
            this.leftButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.lastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.role.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForMiddleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideLoginEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForSaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonEmptySpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl rootLayout;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.TextEdit lastName;
        private DevExpress.XtraEditors.TextEdit firstName;
        private DevExpress.XtraEditors.TextEdit middleName;
        private DevExpress.XtraEditors.TextEdit login;
        private DevExpress.XtraEditors.TextEdit password;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraLayout.LayoutControlGroup rootLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup mainGroup;
        private DevExpress.XtraLayout.EmptySpaceItem upButtonEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem itemForSaveButton;
        private DevExpress.XtraLayout.LayoutControlItem itemForCancelButton;
        private DevExpress.XtraLayout.EmptySpaceItem divideButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem leftButtonEmptySpace;
        private DevExpress.XtraEditors.ComboBoxEdit role;
        private DevExpress.XtraLayout.LayoutControlItem itemForRole;
        private DevExpress.XtraLayout.LayoutControlItem itemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem itemForFirstName;
        private DevExpress.XtraLayout.LayoutControlItem itemForLogin;
        private DevExpress.XtraLayout.LayoutControlItem itemForPassword;
        private DevExpress.XtraLayout.LayoutControlItem itemForMiddleName;
        private DevExpress.XtraLayout.EmptySpaceItem divideLoginEmptySpace;

    }
}