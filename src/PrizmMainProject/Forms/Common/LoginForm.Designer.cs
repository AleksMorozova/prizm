namespace PrizmMain.Forms.Common
{
   partial class LoginForm
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
         this.pictureBox = new System.Windows.Forms.PictureBox();
         this.lblLogin = new System.Windows.Forms.Label();
         this.lblPassword = new System.Windows.Forms.Label();
         this.txtLogin = new DevExpress.XtraEditors.TextEdit();
         this.txtPassword = new DevExpress.XtraEditors.TextEdit();
         this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
         this.btnExit = new DevExpress.XtraEditors.SimpleButton();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox
         // 
         this.pictureBox.Image = global::PrizmMain.Properties.Resources.password_logo;
         this.pictureBox.Location = new System.Drawing.Point(12, 12);
         this.pictureBox.Name = "pictureBox";
         this.pictureBox.Size = new System.Drawing.Size(128, 128);
         this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox.TabIndex = 0;
         this.pictureBox.TabStop = false;
         // 
         // lblLogin
         // 
         this.lblLogin.AutoSize = true;
         this.lblLogin.Location = new System.Drawing.Point(162, 13);
         this.lblLogin.Name = "lblLogin";
         this.lblLogin.Size = new System.Drawing.Size(37, 13);
         this.lblLogin.TabIndex = 1;
         this.lblLogin.Text = "Логин";
         // 
         // lblPassword
         // 
         this.lblPassword.AutoSize = true;
         this.lblPassword.Location = new System.Drawing.Point(162, 62);
         this.lblPassword.Name = "lblPassword";
         this.lblPassword.Size = new System.Drawing.Size(44, 13);
         this.lblPassword.TabIndex = 2;
         this.lblPassword.Text = "Пароль";
         // 
         // txtLogin
         // 
         this.txtLogin.Location = new System.Drawing.Point(165, 30);
         this.txtLogin.Name = "txtLogin";
         this.txtLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
         this.txtLogin.Properties.Appearance.Options.UseFont = true;
         this.txtLogin.Size = new System.Drawing.Size(325, 24);
         this.txtLogin.TabIndex = 3;
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(165, 78);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
         this.txtPassword.Properties.Appearance.Options.UseFont = true;
         this.txtPassword.Properties.PasswordChar = '*';
         this.txtPassword.Size = new System.Drawing.Size(325, 24);
         this.txtPassword.TabIndex = 4;
         // 
         // btnLogin
         // 
         this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
         this.btnLogin.Appearance.Options.UseFont = true;
         this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnLogin.Location = new System.Drawing.Point(249, 146);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(152, 31);
         this.btnLogin.TabIndex = 5;
         this.btnLogin.Text = "Вход";
         // 
         // btnExit
         // 
         this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnExit.Location = new System.Drawing.Point(407, 146);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(84, 31);
         this.btnExit.TabIndex = 6;
         this.btnExit.Text = "Отмена";
         // 
         // LoginForm
         // 
         this.AcceptButton = this.btnLogin;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnExit;
         this.ClientSize = new System.Drawing.Size(502, 185);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.btnLogin);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtLogin);
         this.Controls.Add(this.lblPassword);
         this.Controls.Add(this.lblLogin);
         this.Controls.Add(this.pictureBox);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "LoginForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "PRIZMA";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox;
      private System.Windows.Forms.Label lblLogin;
      private System.Windows.Forms.Label lblPassword;
      private DevExpress.XtraEditors.TextEdit txtLogin;
      private DevExpress.XtraEditors.TextEdit txtPassword;
      private DevExpress.XtraEditors.SimpleButton btnLogin;
      private DevExpress.XtraEditors.SimpleButton btnExit;
   }
}