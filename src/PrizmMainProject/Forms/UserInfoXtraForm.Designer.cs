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
            this.loginLabel = new DevExpress.XtraEditors.LabelControl();
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            this.confirmPasswordLabel = new DevExpress.XtraEditors.LabelControl();
            this.login = new DevExpress.XtraEditors.TextEdit();
            this.password = new DevExpress.XtraEditors.TextEdit();
            this.confirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.userRights = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.userRightsLabel = new DevExpress.XtraEditors.LabelControl();
            this.lastNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.firstNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.middleNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.lastName = new DevExpress.XtraEditors.TextEdit();
            this.middleName = new DevExpress.XtraEditors.TextEdit();
            this.firstName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.login.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Location = new System.Drawing.Point(15, 104);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(25, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(15, 130);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(46, 13);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Location = new System.Drawing.Point(15, 156);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(86, 13);
            this.confirmPasswordLabel.TabIndex = 0;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(107, 101);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(224, 20);
            this.login.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(107, 127);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(224, 20);
            this.password.TabIndex = 5;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(107, 153);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(224, 20);
            this.confirmPassword.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(174, 294);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "&Save";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(255, 294);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "&Close";
            // 
            // userRights
            // 
            this.userRights.HorzScrollStep = 3;
            this.userRights.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Operator in manufacturing"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Operator in construction"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Inspector in manufacturing"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Inspector in construction"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Administrator")});
            this.userRights.Location = new System.Drawing.Point(14, 211);
            this.userRights.MultiColumn = true;
            this.userRights.Name = "userRights";
            this.userRights.Size = new System.Drawing.Size(317, 66);
            this.userRights.TabIndex = 7;
            // 
            // userRightsLabel
            // 
            this.userRightsLabel.Location = new System.Drawing.Point(14, 192);
            this.userRightsLabel.Name = "userRightsLabel";
            this.userRightsLabel.Size = new System.Drawing.Size(55, 13);
            this.userRightsLabel.TabIndex = 8;
            this.userRightsLabel.Text = "User Rights";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(14, 26);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(50, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(14, 52);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(51, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.Location = new System.Drawing.Point(15, 78);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(60, 13);
            this.middleNameLabel.TabIndex = 0;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(106, 23);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(224, 20);
            this.lastName.TabIndex = 1;
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(107, 75);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(224, 20);
            this.middleName.TabIndex = 3;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(106, 49);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(224, 20);
            this.firstName.TabIndex = 2;
            // 
            // UserInfoXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 329);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.userRightsLabel);
            this.Controls.Add(this.userRights);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "UserInfoXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.login.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl loginLabel;
        private DevExpress.XtraEditors.LabelControl passwordLabel;
        private DevExpress.XtraEditors.LabelControl confirmPasswordLabel;
        private DevExpress.XtraEditors.TextEdit login;
        private DevExpress.XtraEditors.TextEdit password;
        private DevExpress.XtraEditors.TextEdit confirmPassword;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.CheckedListBoxControl userRights;
        private DevExpress.XtraEditors.LabelControl userRightsLabel;
        private DevExpress.XtraEditors.LabelControl lastNameLabel;
        private DevExpress.XtraEditors.LabelControl firstNameLabel;
        private DevExpress.XtraEditors.LabelControl middleNameLabel;
        private DevExpress.XtraEditors.TextEdit lastName;
        private DevExpress.XtraEditors.TextEdit middleName;
        private DevExpress.XtraEditors.TextEdit firstName;
    }
}