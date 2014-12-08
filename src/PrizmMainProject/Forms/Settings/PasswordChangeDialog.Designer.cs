namespace PrizmMain.Forms.Settings
{
   partial class PasswordChangeDialog
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
         this.lblOldPass = new System.Windows.Forms.Label();
         this.lblPass = new System.Windows.Forms.Label();
         this.lblConfirm = new System.Windows.Forms.Label();
         this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
         this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
         this.txtConfirm = new DevExpress.XtraEditors.TextEdit();
         this.btnOk = new DevExpress.XtraEditors.SimpleButton();
         this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
         ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // lblOldPass
         // 
         this.lblOldPass.AutoSize = true;
         this.lblOldPass.Location = new System.Drawing.Point(13, 18);
         this.lblOldPass.Name = "lblOldPass";
         this.lblOldPass.Size = new System.Drawing.Size(89, 13);
         this.lblOldPass.TabIndex = 0;
         this.lblOldPass.Text = "Старый пароль:";
         // 
         // lblPass
         // 
         this.lblPass.AutoSize = true;
         this.lblPass.Location = new System.Drawing.Point(54, 44);
         this.lblPass.Name = "lblPass";
         this.lblPass.Size = new System.Drawing.Size(48, 13);
         this.lblPass.TabIndex = 1;
         this.lblPass.Text = "Пароль:";
         // 
         // lblConfirm
         // 
         this.lblConfirm.AutoSize = true;
         this.lblConfirm.Location = new System.Drawing.Point(8, 70);
         this.lblConfirm.Name = "lblConfirm";
         this.lblConfirm.Size = new System.Drawing.Size(94, 13);
         this.lblConfirm.TabIndex = 2;
         this.lblConfirm.Text = "Подтверждение:";
         // 
         // txtOldPass
         // 
         this.txtOldPass.Location = new System.Drawing.Point(108, 15);
         this.txtOldPass.Name = "txtOldPass";
         this.txtOldPass.Properties.PasswordChar = '*';
         this.txtOldPass.Size = new System.Drawing.Size(233, 20);
         this.txtOldPass.TabIndex = 3;
         // 
         // txtNewPass
         // 
         this.txtNewPass.Location = new System.Drawing.Point(108, 41);
         this.txtNewPass.Name = "txtNewPass";
         this.txtNewPass.Properties.PasswordChar = '*';
         this.txtNewPass.Size = new System.Drawing.Size(233, 20);
         this.txtNewPass.TabIndex = 4;
         // 
         // txtConfirm
         // 
         this.txtConfirm.Location = new System.Drawing.Point(108, 67);
         this.txtConfirm.Name = "txtConfirm";
         this.txtConfirm.Properties.PasswordChar = '*';
         this.txtConfirm.Size = new System.Drawing.Size(233, 20);
         this.txtConfirm.TabIndex = 5;
         // 
         // btnOk
         // 
         this.btnOk.Location = new System.Drawing.Point(185, 100);
         this.btnOk.Name = "btnOk";
         this.btnOk.Size = new System.Drawing.Size(75, 23);
         this.btnOk.TabIndex = 6;
         this.btnOk.Text = "&OK";
         this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(266, 100);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 7;
         this.btnCancel.Text = "&Отмена";
         // 
         // PasswordChangeDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(353, 135);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOk);
         this.Controls.Add(this.txtConfirm);
         this.Controls.Add(this.txtNewPass);
         this.Controls.Add(this.txtOldPass);
         this.Controls.Add(this.lblConfirm);
         this.Controls.Add(this.lblPass);
         this.Controls.Add(this.lblOldPass);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "PasswordChangeDialog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "PasswordChangeDialog";
         ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblOldPass;
      private System.Windows.Forms.Label lblPass;
      private System.Windows.Forms.Label lblConfirm;
      private DevExpress.XtraEditors.TextEdit txtOldPass;
      private DevExpress.XtraEditors.TextEdit txtNewPass;
      private DevExpress.XtraEditors.TextEdit txtConfirm;
      private DevExpress.XtraEditors.SimpleButton btnOk;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
   }
}