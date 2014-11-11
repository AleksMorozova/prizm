using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms.Settings.UserRole.User
{
    public partial class UserInfoXtraForm : XtraForm
    {
        public UserInfoXtraForm()
        {
            InitializeComponent();
            var repo = new RolesDummy();
            BindingList<DummyData.Role> roles = repo.GetRoles();
            role.Properties.Items.AddRange(roles);
        }

        public UserInfoXtraForm(bool isNew)
        {
            InitializeComponent();

            var repo = new UsersDummy();
            DummyData.User user = repo.GetUser(1);
            userBindingSource.DataSource = user;
            role.Properties.ReadOnly = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}