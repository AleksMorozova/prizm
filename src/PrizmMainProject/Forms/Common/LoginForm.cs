using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prizm.Main.Forms.Common
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class LoginForm : PrizmForm
   {
      public LoginForm()
      {
         InitializeComponent();
      }

      public string Login
      {
         get { return txtLogin.Text; }
      }

      public string Password
      {
         get { return txtPassword.Text; }
      }

      #region --- Localization ---

      protected override List<LocalizedItem> CreateLocalizedItems()
      {
          return new List<LocalizedItem>()
          {
              new LocalizedItem(lblLogin, "Login_LoginLabel"),
              new LocalizedItem(lblPassword, "Login_PasswordLabel"),
              new LocalizedItem(btnLogin, "Login_LoginButton"),
              new LocalizedItem(btnExit, "Login_ExitButton")
          };
      }

      #endregion // --- Localization ---
   }
}
