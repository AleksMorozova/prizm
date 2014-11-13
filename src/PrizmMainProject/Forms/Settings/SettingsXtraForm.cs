using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;
using PrizmMain.Forms.Settings.Dictionary;
using PrizmMain.Forms.Settings.UserRole.Role;
using PrizmMain.Forms.Settings.UserRole.User;
using DevExpress.XtraGrid.Views.Grid;
using Domain.Entity.Setup;
using Ninject;
using Ninject.Parameters;

namespace PrizmMain.Forms.Settings
{
    public partial class SettingsXtraForm : XtraForm
    {
        private SettingsViewModel viewModel;
 
        public SettingsXtraForm()//: this(Guid.NewGuid())
        {
            InitializeComponent();
            pipesSizeListGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            inspectionView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;

        }

        //public SettingsXtraForm(Guid CurrentPipeMillSizeTypeId) 
        //{
        //    InitializeComponent();
        //    viewModel = (SettingsViewModel)Program.Kernel.Get<SettingsViewModel>(new ConstructorArgument("CurrentPipeMillSizeType", CurrentPipeMillSizeTypeId)); 
        //}

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
            BindToViewModel();
            BindCommands();
        }

        private void BindToViewModel()
        {
            pipeMillSizeTypeBindingSource.DataSource = viewModel;
            //GridView gridView = pipesSizeList.FocusedView as GridView;
            //viewModel.CurrentPipeMillSizeType = (PipeMillSizeType)gridView.GetRow(gridView.FocusedRowHandle);
            pipesSizeList.DataBindings.Add("DataSource", pipeMillSizeTypeBindingSource, "PipeMillSizeType");
            inspectionOperation.DataBindings.Add("DataSource", pipeMillSizeTypeBindingSource, "PipeTest");
            
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

        private void pipesSizeListGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            inspectionOperation.RefreshDataSource();
            
        }
    }
}