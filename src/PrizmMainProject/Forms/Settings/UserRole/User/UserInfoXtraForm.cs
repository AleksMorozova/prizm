using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms
{
    public partial class UserInfoXtraForm : DevExpress.XtraEditors.XtraForm
    {

        public UserInfoXtraForm()
        {
            InitializeComponent();
            var repo = new RolesDummy();
            BindingList<Role> roles =  repo.GetRoles();
            role.Properties.Items.AddRange(roles);
        

        }

        public UserInfoXtraForm(bool isNew)
        {
            InitializeComponent();

            var repo = new UsersDummy();
            var user = repo.GetUser(1);
            userBindingSource.DataSource = user;
            role.Properties.ReadOnly = true;
      
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

    }
}