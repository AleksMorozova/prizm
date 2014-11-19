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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace PrizmMain.Forms.Settings
{
    public partial class SettingsXtraForm : XtraForm
    {
        private SettingsViewModel viewModel;
        private PipeMillSizeType CurrentPipeMillSizeType;
        const string VALUE_REQUIRED = "This value is required."; // TODO: Translate when more languages will be supported.

        public SettingsXtraForm()
        {
            InitializeComponent();

            pipesSizeListGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            inspectionView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
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
            viewModel.LoadData();
            BindToViewModel();
            BindCommands();

            gridViewWelders.BestFitColumns();
            gridViewInspectors.BestFitColumns();
        }

        private void BindToViewModel()
        {
            pipeMillSizeTypeBindingSource.DataSource = viewModel;
            pipesSizeList.DataBindings.Add("DataSource", pipeMillSizeTypeBindingSource, "PipeMillSizeType");
            inspectionOperation.DataSource = viewModel.PipeTests;
            gridControlWelders.DataSource = viewModel.Welders;
            gridControlInspectors.DataSource = viewModel.Inspectors;
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

            CurrentPipeMillSizeType = sizeType as PipeMillSizeType;
        }

        private void inspectionView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            PipeTest pipeTest = v.GetRow(e.RowHandle) as PipeTest;
            pipeTest.pipeType = CurrentPipeMillSizeType;
            CurrentPipeMillSizeType.PipeTests.Add(pipeTest); 
        }

        private void pipesSizeListGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            CurrentPipeMillSizeType = v.GetRow(e.RowHandle) as PipeMillSizeType;
            CurrentPipeMillSizeType.PipeTests = new BindingList<PipeTest>();
        }

        private void gridViewWelders_ValidateRow(object sender, ValidateRowEventArgs e)
        {
           ValidatePersonName(gridViewWelders, colWelderFirstName, colWelderLastName, e);
        }

        private void gridViewInspectors_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
           ValidatePersonName(gridViewInspectors, colInspectorFirstName, colInspectorLastName, e);
        }
       
        private void HandleInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
           e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        void ValidatePersonName(GridView view, GridColumn firstNameColumn, GridColumn lastNameColumn, ValidateRowEventArgs e)
        {
           string firstName = (string)view.GetRowCellValue(e.RowHandle, firstNameColumn);
           string lastName = (string)view.GetRowCellValue(e.RowHandle, lastNameColumn);

           view.ClearColumnErrors();

           if (String.IsNullOrEmpty(firstName))
           {
              view.SetColumnError(firstNameColumn, VALUE_REQUIRED);
              e.Valid = false;
           }

           if (String.IsNullOrEmpty(lastName))
           {
              view.SetColumnError(lastNameColumn, VALUE_REQUIRED);
              e.Valid = false;
           }
        }

        
    }
}