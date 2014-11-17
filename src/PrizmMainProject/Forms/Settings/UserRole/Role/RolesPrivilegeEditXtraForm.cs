using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PrizmMain.DummyData;

namespace PrizmMain.Forms.Settings.UserRole.Role
{
    public partial class RolesPrivilegeEditXtraForm : XtraForm
    {
        public RolesPrivilegeEditXtraForm()
        {
            InitializeComponent();

            var repo = new RolesDummy();
            Privilege[] allPrivs = repo.GetAllPrivileges().ToArray();

            priveleges.Items.AddRange(allPrivs);
        }

        public RolesPrivilegeEditXtraForm(bool isNew)
        {
            InitializeComponent();
            if (isNew)
            {
                return;
            }

            roleEdit.Properties.ReadOnly = true;
            var repository = new RolesDummy();
            BindingList<Privilege> allPrivileges = repository.GetAllPrivileges();
            DummyData.Role role = repository.GetRole(0);

            var items = new CheckedListBoxItem[allPrivileges.Count];

            for (int i = 0; i < allPrivileges.Count; i++)
            {
                items[i] = new CheckedListBoxItem(allPrivileges[i].Description, (i%2 == 0) ? true : false);
            }

            priveleges.Items.AddRange(items);
            roleEdit.Text = role.Name;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}