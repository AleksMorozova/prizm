using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms
{
    public partial class SettingsXtraForm : XtraForm
    {
        public SettingsXtraForm()
        {
            InitializeComponent();

            var inspectionDs = new InspectionDummy();
            BindingList<Inspection> inspectionData = inspectionDs.GetDummyInspection();
            inspectionOperation.DataSource = inspectionData;

            #region User & Role Setting

            var userDs = new UsersDummy();
            BindingList<User> userData = userDs.GetDummyUsers();
            users.DataSource = userData;

            var roleDs = new RolesDummy();
            BindingList<Role> roleData = roleDs.GetRoles();
            roles.DataSource = roleData;

            #endregion

            #region Dictionary Grid

            dictionaries.DataSource = DictionaryDummy.GetDictionaries();

            #endregion
        }

        #region Role Setting

        private void editRoleButton_Click(object sender, EventArgs e)
        {
            //TODO: change for normal logic
            var editForm = new RolesPrivilegeEditXtraForm(false);
            editForm.ShowDialog();
        }

        private void roleAddButton_Click(object sender, EventArgs e)
        {
            //TODO: change for normal logic
            var editForm = new RolesPrivilegeEditXtraForm();
            editForm.ShowDialog();
        }

        #endregion

        #region User setting

        private void userEditButton_Click(object sender, EventArgs e)
        {
            //TODO: change for normal logic
            var editUser = new UserInfoXtraForm(false);
            editUser.ShowDialog();
        }

        #endregion

        private void editItem_Click(object sender, EventArgs e)
        {
            //TODO: change for normal logic
            var editDictionary = new SettingsEditDictionaryXtraForm();
            editDictionary.ShowDialog();
        }
    }
}