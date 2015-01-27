using DevExpress.XtraEditors;
using Prizm.Main.Forms.Common;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
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
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class PasswordChangeDialog : PrizmForm
    {
        string passwordHash = string.Empty;

        public PasswordChangeDialog()
        {
            InitializeComponent();
        }

        public DialogResult ShowPasswordDialog(string passwordHash)
        {
            this.passwordHash = passwordHash;
            if(String.IsNullOrEmpty(this.passwordHash))
            {
                txtOldPass.Enabled = false;
            }
            return ShowDialog();
        }

        public string NewPasswordHash { get; set; }


        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
          {
              new LocalizedItem(lblOldPass, "PassChange_OldPassLabel"),
              new LocalizedItem(lblPass, "PassChange_PassLabel"),
              new LocalizedItem(lblConfirm, "PassChange_ConfirmPassLabel"),

              new LocalizedItem(btnOk, "PassChange_OKButton"),
              new LocalizedItem(btnCancel, "PassChange_CancelButton"),
          };
        }

        #endregion // --- Localization ---

        private void btnOk_Click(object sender, EventArgs e)
        {
            string oldPasswordHash = PasswordEncryptor.EncryptPassword(txtOldPass.Text);
            string newPasswordHash = PasswordEncryptor.EncryptPassword(txtNewPass.Text);
            string confirmPasswordHash = PasswordEncryptor.EncryptPassword(txtConfirm.Text);

            if(txtOldPass.Enabled)
            {
                if(oldPasswordHash != passwordHash)
                {
                    MessageBox.Show(Resources.InvalidOldPassword);
                    DialogResult = System.Windows.Forms.DialogResult.None;
                    return;
                }
            }

            if(newPasswordHash != confirmPasswordHash)
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
