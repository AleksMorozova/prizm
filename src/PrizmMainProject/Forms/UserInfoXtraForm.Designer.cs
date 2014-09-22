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
            this.labelControlFullName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLogin = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPassword = new DevExpress.XtraEditors.LabelControl();
            this.labelControlConfirmPassword = new DevExpress.XtraEditors.LabelControl();
            this.textEditFullName = new DevExpress.XtraEditors.TextEdit();
            this.textEditLogin = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.textEditConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.checkedListBoxControlUserRights = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlUserRights)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlFullName
            // 
            this.labelControlFullName.Location = new System.Drawing.Point(12, 31);
            this.labelControlFullName.Name = "labelControlFullName";
            this.labelControlFullName.Size = new System.Drawing.Size(46, 13);
            this.labelControlFullName.TabIndex = 0;
            this.labelControlFullName.Text = "Full Name";
            // 
            // labelControlLogin
            // 
            this.labelControlLogin.Location = new System.Drawing.Point(12, 57);
            this.labelControlLogin.Name = "labelControlLogin";
            this.labelControlLogin.Size = new System.Drawing.Size(25, 13);
            this.labelControlLogin.TabIndex = 0;
            this.labelControlLogin.Text = "Login";
            // 
            // labelControlPassword
            // 
            this.labelControlPassword.Location = new System.Drawing.Point(12, 83);
            this.labelControlPassword.Name = "labelControlPassword";
            this.labelControlPassword.Size = new System.Drawing.Size(46, 13);
            this.labelControlPassword.TabIndex = 0;
            this.labelControlPassword.Text = "Password";
            // 
            // labelControlConfirmPassword
            // 
            this.labelControlConfirmPassword.Location = new System.Drawing.Point(12, 109);
            this.labelControlConfirmPassword.Name = "labelControlConfirmPassword";
            this.labelControlConfirmPassword.Size = new System.Drawing.Size(86, 13);
            this.labelControlConfirmPassword.TabIndex = 0;
            this.labelControlConfirmPassword.Text = "Confirm Password";
            // 
            // textEditFullName
            // 
            this.textEditFullName.Location = new System.Drawing.Point(104, 28);
            this.textEditFullName.Name = "textEditFullName";
            this.textEditFullName.Size = new System.Drawing.Size(248, 20);
            this.textEditFullName.TabIndex = 1;
            // 
            // textEditLogin
            // 
            this.textEditLogin.Location = new System.Drawing.Point(104, 54);
            this.textEditLogin.Name = "textEditLogin";
            this.textEditLogin.Size = new System.Drawing.Size(165, 20);
            this.textEditLogin.TabIndex = 2;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(104, 80);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Size = new System.Drawing.Size(165, 20);
            this.textEditPassword.TabIndex = 3;
            // 
            // textEditConfirmPassword
            // 
            this.textEditConfirmPassword.Location = new System.Drawing.Point(104, 106);
            this.textEditConfirmPassword.Name = "textEditConfirmPassword";
            this.textEditConfirmPassword.Size = new System.Drawing.Size(165, 20);
            this.textEditConfirmPassword.TabIndex = 4;
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(194, 224);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSave.TabIndex = 6;
            this.simpleButtonSave.Text = "&Save";
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Location = new System.Drawing.Point(277, 224);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonClose.TabIndex = 7;
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
            this.checkedListBoxControlUserRights.Location = new System.Drawing.Point(24, 146);
            this.checkedListBoxControlUserRights.MultiColumn = true;
            this.checkedListBoxControlUserRights.Name = "checkedListBoxControlUserRights";
            this.checkedListBoxControlUserRights.Size = new System.Drawing.Size(316, 66);
            this.checkedListBoxControlUserRights.TabIndex = 5;
            // 
            // UserInfoXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 259);
            this.Controls.Add(this.checkedListBoxControlUserRights);
            this.Controls.Add(this.simpleButtonClose);
            this.Controls.Add(this.simpleButtonSave);
            this.Controls.Add(this.textEditConfirmPassword);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditLogin);
            this.Controls.Add(this.textEditFullName);
            this.Controls.Add(this.labelControlConfirmPassword);
            this.Controls.Add(this.labelControlPassword);
            this.Controls.Add(this.labelControlLogin);
            this.Controls.Add(this.labelControlFullName);
            this.Name = "UserInfoXtraForm";
            this.Text = "UserInfoXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEditFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlUserRights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlFullName;
        private DevExpress.XtraEditors.LabelControl labelControlLogin;
        private DevExpress.XtraEditors.LabelControl labelControlPassword;
        private DevExpress.XtraEditors.LabelControl labelControlConfirmPassword;
        private DevExpress.XtraEditors.TextEdit textEditFullName;
        private DevExpress.XtraEditors.TextEdit textEditLogin;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.TextEdit textEditConfirmPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControlUserRights;
    }
}