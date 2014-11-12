using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;
using PrizmMain.Forms.Settings.Dictionary;
using PrizmMain.Forms.Settings.UserRole.Role;
using PrizmMain.Forms.Settings.UserRole.User;
using DevExpress.XtraGrid.Views.Grid;

namespace PrizmMain.Forms.Settings
{
    public partial class SettingsXtraForm : XtraForm
    {
        private SettingsViewModel viewModel;

        public SettingsXtraForm()
        {
            InitializeComponent();
            //pipesSizeListGridView.AddNewRow();
            //pipesSizeListGridView.OptionsBehavior.Editable = true;
            pipesSizeListGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;

            //inspectionView.AddNewRow();
            //inspectionView.OptionsBehavior.Editable = true;
            inspectionView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;

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

        private void SettingsXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (SettingsViewModel)Program.Kernel.GetService(typeof(SettingsViewModel));
            pipeMillSizeTypeBindingSource.DataSource = viewModel;
            BindToViewModel();
            BindCommands();
        }

        private void BindToViewModel()
        {
            
            pipesSizeList.DataBindings.Add("DataSource", pipeMillSizeTypeBindingSource, "pipeMillSizeType");
            inspectionOperation.DataBindings.Add("DataSource", pipeMillSizeTypeBindingSource, "pipeMillSizeType.PipeTests");
        }

        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
        }

        private void SettingsXtraForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }

        private void pipesSizeListGridView_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

            inspectionOperation.RefreshDataSource();
        }
    }
}