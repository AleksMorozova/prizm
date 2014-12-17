using DevExpress.XtraEditors;
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
   public partial class LoginForm : XtraForm
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
   }
}
