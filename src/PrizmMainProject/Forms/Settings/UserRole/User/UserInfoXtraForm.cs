using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms
{
    public partial class UserInfoXtraForm : XtraForm
    {
        public UserInfoXtraForm()
        {
            InitializeComponent();
            var repo = new RolesDummy();
            BindingList<Role> roles = repo.GetRoles();
            role.Properties.Items.AddRange(roles);
        }

        public UserInfoXtraForm(bool isNew)
        {
            InitializeComponent();

            var repo = new UsersDummy();
            User user = repo.GetUser(1);
            userBindingSource.DataSource = user;
            role.Properties.ReadOnly = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}