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
        private PipeTest pipeTest;

        public SettingsXtraForm()
        {
            InitializeComponent();
            
            pipesSizeListGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
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
            BindToViewModel();
            BindCommands();
        }

        private void BindToViewModel()
        {
            pipeMillSizeTypeBindingSource.DataSource = viewModel;
            pipesSizeList.DataBindings.Add("DataSource", pipeMillSizeTypeBindingSource, "PipeMillSizeType");
            inspectionOperation.DataSource = viewModel.PipeTests;
            client.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "Client");
            design.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "Designer");
            externalDocumentSize.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "DocumentSizeLimit");
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
            
            GridView v = sender as GridView;
            object sizeType = v.GetRow(e.FocusedRowHandle);

            if (sizeType != null)
            {
                viewModel.UpdatePipeTests(sizeType);
            }

            else 
            {
                viewModel.CurrentPipeMillSizeType.PipeTests = new BindingList<PipeTest>();
            }

            viewModel.CurrentPipeMillSizeType = sizeType as PipeMillSizeType;
        }

        private void inspectionView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            pipeTest = (PipeTest)v.GetRow(e.RowHandle);
            pipeTest.pipeType = viewModel.CurrentPipeMillSizeType;
            viewModel.CurrentPipeMillSizeType.PipeTests.Add(pipeTest); 
        }
    }
}