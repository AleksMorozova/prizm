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
            this.labelControlLogin = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPassword = new DevExpress.XtraEditors.LabelControl();
            this.labelControlConfirmPassword = new DevExpress.XtraEditors.LabelControl();
            this.textEditLogin = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.textEditConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.checkedListBoxControlUserRights = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControlUserRights = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLastName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlFirstName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlMiddleName = new DevExpress.XtraEditors.LabelControl();
            this.textEditLastName = new DevExpress.XtraEditors.TextEdit();
            this.textEditMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.textEditFirstName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlUserRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlLogin
            // 
            this.labelControlLogin.Location = new System.Drawing.Point(15, 104);
            this.labelControlLogin.Name = "labelControlLogin";
            this.labelControlLogin.Size = new System.Drawing.Size(25, 13);
            this.labelControlLogin.TabIndex = 0;
            this.labelControlLogin.Text = "Login";
            // 
            // labelControlPassword
            // 
            this.labelControlPassword.Location = new System.Drawing.Point(15, 130);
            this.labelControlPassword.Name = "labelControlPassword";
            this.labelControlPassword.Size = new System.Drawing.Size(46, 13);
            this.labelControlPassword.TabIndex = 0;
            this.labelControlPassword.Text = "Password";
            // 
            // labelControlConfirmPassword
            // 
            this.labelControlConfirmPassword.Location = new System.Drawing.Point(15, 156);
            this.labelControlConfirmPassword.Name = "labelControlConfirmPassword";
            this.labelControlConfirmPassword.Size = new System.Drawing.Size(86, 13);
            this.labelControlConfirmPassword.TabIndex = 0;
            this.labelControlConfirmPassword.Text = "Confirm Password";
            // 
            // textEditLogin
            // 
            this.textEditLogin.Location = new System.Drawing.Point(107, 101);
            this.textEditLogin.Name = "textEditLogin";
            this.textEditLogin.Size = new System.Drawing.Size(224, 20);
            this.textEditLogin.TabIndex = 4;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(107, 127);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Size = new System.Drawing.Size(224, 20);
            this.textEditPassword.TabIndex = 5;
            // 
            // textEditConfirmPassword
            // 
            this.textEditConfirmPassword.Location = new System.Drawing.Point(107, 153);
            this.textEditConfirmPassword.Name = "textEditConfirmPassword";
            this.textEditConfirmPassword.Size = new System.Drawing.Size(224, 20);
            this.textEditConfirmPassword.TabIndex = 6;
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(174, 294);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSave.TabIndex = 8;
            this.simpleButtonSave.Text = "&Save";
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Location = new System.Drawing.Point(255, 294);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonClose.TabIndex = 9;
            this.simpleButtonClose.Text = "&Close";
            // 
            // checkedListBoxControlUserRights
            // 
            this.checkedListBoxControlUserRights.HorzScrollStep = 3;
            this.checkedListBoxControlUserRights.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Operator in manufacturing"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Operator in construction"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Inspector in manufacturing"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Inspector in construction"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Administrator")});
            this.checkedListBoxControlUserRights.Location = new System.Drawing.Point(14, 211);
            this.checkedListBoxControlUserRights.MultiColumn = true;
            this.checkedListBoxControlUserRights.Name = "checkedListBoxControlUserRights";
            this.checkedListBoxControlUserRights.Size = new System.Drawing.Size(317, 66);
            this.checkedListBoxControlUserRights.TabIndex = 7;
            // 
            // labelControlUserRights
            // 
            this.labelControlUserRights.Location = new System.Drawing.Point(14, 192);
            this.labelControlUserRights.Name = "labelControlUserRights";
            this.labelControlUserRights.Size = new System.Drawing.Size(55, 13);
            this.labelControlUserRights.TabIndex = 8;
            this.labelControlUserRights.Text = "User Rights";
            // 
            // labelControlLastName
            // 
            this.labelControlLastName.Location = new System.Drawing.Point(14, 26);
            this.labelControlLastName.Name = "labelControlLastName";
            this.labelControlLastName.Size = new System.Drawing.Size(50, 13);
            this.labelControlLastName.TabIndex = 0;
            this.labelControlLastName.Text = "Last Name";
            // 
            // labelControlFirstName
            // 
            this.labelControlFirstName.Location = new System.Drawing.Point(14, 52);
            this.labelControlFirstName.Name = "labelControlFirstName";
            this.labelControlFirstName.Size = new System.Drawing.Size(51, 13);
            this.labelControlFirstName.TabIndex = 0;
            this.labelControlFirstName.Text = "First Name";
            // 
            // labelControlMiddleName
            // 
            this.labelControlMiddleName.Location = new System.Drawing.Point(15, 78);
            this.labelControlMiddleName.Name = "labelControlMiddleName";
            this.labelControlMiddleName.Size = new System.Drawing.Size(60, 13);
            this.labelControlMiddleName.TabIndex = 0;
            this.labelControlMiddleName.Text = "Middle Name";
            // 
            // textEditLastName
            // 
            this.textEditLastName.Location = new System.Drawing.Point(106, 23);
            this.textEditLastName.Name = "textEditLastName";
            this.textEditLastName.Size = new System.Drawing.Size(224, 20);
            this.textEditLastName.TabIndex = 1;
            // 
            // textEditMiddleName
            // 
            this.textEditMiddleName.Location = new System.Drawing.Point(107, 75);
            this.textEditMiddleName.Name = "textEditMiddleName";
            this.textEditMiddleName.Size = new System.Drawing.Size(224, 20);
            this.textEditMiddleName.TabIndex = 3;
            // 
            // textEditFirstName
            // 
            this.textEditFirstName.Location = new System.Drawing.Point(106, 49);
            this.textEditFirstName.Name = "textEditFirstName";
            this.textEditFirstName.Size = new System.Drawing.Size(224, 20);
            this.textEditFirstName.TabIndex = 2;
            // 
            // UserInfoXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 329);
            this.Controls.Add(this.textEditFirstName);
            this.Controls.Add(this.textEditMiddleName);
            this.Controls.Add(this.textEditLastName);
            this.Controls.Add(this.labelControlMiddleName);
            this.Controls.Add(this.labelControlFirstName);
            this.Controls.Add(this.labelControlLastName);
            this.Controls.Add(this.labelControlUserRights);
            this.Controls.Add(this.checkedListBoxControlUserRights);
            this.Controls.Add(this.simpleButtonClose);
            this.Controls.Add(this.simpleButtonSave);
            this.Controls.Add(this.textEditConfirmPassword);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditLogin);
            this.Controls.Add(this.labelControlConfirmPassword);
            this.Controls.Add(this.labelControlPassword);
            this.Controls.Add(this.labelControlLogin);
            this.Name = "UserInfoXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEditLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlUserRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlLogin;
        private DevExpress.XtraEditors.LabelControl labelControlPassword;
        private DevExpress.XtraEditors.LabelControl labelControlConfirmPassword;
        private DevExpress.XtraEditors.TextEdit textEditLogin;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.TextEdit textEditConfirmPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControlUserRights;
        private DevExpress.XtraEditors.LabelControl labelControlUserRights;
        private DevExpress.XtraEditors.LabelControl labelControlLastName;
        private DevExpress.XtraEditors.LabelControl labelControlFirstName;
        private DevExpress.XtraEditors.LabelControl labelControlMiddleName;
        private DevExpress.XtraEditors.TextEdit textEditLastName;
        private DevExpress.XtraEditors.TextEdit textEditMiddleName;
        private DevExpress.XtraEditors.TextEdit textEditFirstName;
    }
}