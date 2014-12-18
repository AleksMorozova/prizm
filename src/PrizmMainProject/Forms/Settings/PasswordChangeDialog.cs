using DevExpress.XtraEditors;
using Prizm.Main.Forms.Common;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Forms.Settings
{
   public partial class PasswordChangeDialog : XtraForm
   {
      string passwordHash = string.Empty;

      public PasswordChangeDialog()
      {
         InitializeComponent();
      }

      public DialogResult ShowPasswordDialog(string passwordHash)
      { 
         this.passwordHash = passwordHash;
         if (String.IsNullOrEmpty(this.passwordHash))
         {
            txtOldPass.Enabled = false;
         }
         return ShowDialog();
      }

      public string NewPasswordHash { get; set; }
   

      private void btnOk_Click(object sender, EventArgs e)
      {
         string oldPasswordHash = PasswordEncryptor.EncryptPassword(txtOldPass.Text);
         string newPasswordHash = PasswordEncryptor.EncryptPassword(txtNewPass.Text);
         string confirmPasswordHash = PasswordEncryptor.EncryptPassword(txtConfirm.Text);

         if (txtOldPass.Enabled)
         {
            if (oldPasswordHash != passwordHash)
            {
               MessageBox.Show(Resources.InvalidOldPassword);
               DialogResult = System.Windows.Forms.DialogResult.None;
               return;
            }
         }

         if (newPasswordHash != confirmPasswordHash)
         {
            MessageBox.Show(Resources.PasswordsNotMatch);
            DialogResult = System.Windows.Forms.DialogResult.None;
            return;
         }

         NewPasswordHash = newPasswordHash;
         DialogResult = System.Windows.Forms.DialogResult.OK;
      }
   }
}
