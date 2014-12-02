using System;
using System.ComponentModel;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using Ninject;
using Ninject.Parameters;

using Domain.Entity.Setup;

using PrizmMain.DummyData;
using PrizmMain.Forms.Settings.Dictionary;
using PrizmMain.Forms.Settings.UserRole.Role;
using PrizmMain.Forms.Settings.UserRole.User;
using PrizmMain.Forms.MainChildForm;

using PrizmMain.Properties;
using System.Collections.Generic;
using Domain.Entity;
using PrizmMain.Forms.Settings.ViewTypes;
using PrizmMain.Common;

namespace PrizmMain.Forms.Settings
{
    public partial class SettingsXtraForm : ChildForm
    {
        private SettingsViewModel viewModel;
        private PipeMillSizeType CurrentPipeMillSizeType;

        public SettingsXtraForm()
        {
            InitializeComponent();
            SetControlsTextLength();

            pipesSizeListGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            inspectionView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            plateManufacturersListView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
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
            viewModel.ModifiableView = this;
            viewModel.PropertyChanged += (s, eve) => IsModified = true; 

            viewModel.LoadData();
            BindToViewModel();

            IsModified = false;
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
            controlTypeItems.DataSource = viewModel.ControlType;
            resultTypeItems.DataSource = viewModel.ResultType;
            client.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "Client");
            design.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "Designer");
            externalDocumentSize.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "DocumentSizeLimit");
            plateManufacturersList.DataSource =  viewModel.PlateManufacturers;
        }
       
        private void BindCommands()
        {
           saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
           SaveCommand = viewModel.SaveCommand;
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
            pipeTest.IsActive = true;
            pipeTest.pipeType = CurrentPipeMillSizeType;
            CurrentPipeMillSizeType.PipeTests.Add(pipeTest); 
        }

        private void pipesSizeListGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            CurrentPipeMillSizeType = v.GetRow(e.RowHandle) as PipeMillSizeType;
            CurrentPipeMillSizeType.IsActive = true;
            if (CurrentPipeMillSizeType != null)
            {
                viewModel.UpdatePipeTests(CurrentPipeMillSizeType);
            }
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
              view.SetColumnError(firstNameColumn, Resources.VALUE_REQUIRED);
              e.Valid = false;
           }

           if (String.IsNullOrEmpty(lastName))
           {
              view.SetColumnError(lastNameColumn, Resources.VALUE_REQUIRED);
              e.Valid = false;
           }
        }

        private void gridViewWelders_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           GridView view = sender as GridView;
           view.RemoveSelectedItem<WelderViewType>(e, viewModel.Welders, (_) => _.Welder.IsNew());
        }

        private void gridViewInspectors_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           GridView view = sender as GridView;
           view.RemoveSelectedItem<InspectorViewType>(e, viewModel.Inspectors, (_) => _.Inspector.IsNew());
        }

        private void SetControlsTextLength()
        {
            client.Properties.MaxLength = LengthLimit.MaxProjectClient;
            design.Properties.MaxLength = LengthLimit.MaxProjectDesigner;
            manufacturerRepositoryTextEdit.MaxLength = LengthLimit.MaxPlateManufacturerName;
            typeRepositoryTextEdit.MaxLength = LengthLimit.MaxPipetestResultType;
            codeRepositoryTextEdit.MaxLength = LengthLimit.MaxPipeTestCode;
            controlNameRepositoryTextEdit.MaxLength = LengthLimit.MaxPipeTestName;
            subjectRepositoryItemEdit.MaxLength = LengthLimit.MaxPipeTestSubject;
            welderFNRepositoryTextEdit.MaxLength = LengthLimit.MaxWelderFirstName;
            welderLNRepositoryTextEdit.MaxLength = LengthLimit.MaxWelderLastName;
            welderMNRepositoryTextEdit.MaxLength = LengthLimit.MaxWelderMiddleName;
            welderCertificateTextEdit.MaxLength = LengthLimit.MaxWelderCertificate;
            stampRepositoryTextEdit.MaxLength = LengthLimit.MaxWelderStamp;
            inspectorFNRepositoryTextEdit.MaxLength = LengthLimit.MaxInspectorFirstName;
            inspectorLNRepositoryTextEdit.MaxLength = LengthLimit.MaxInspectorLastName;
            inspectorMNRepositoryTextEdit.MaxLength = LengthLimit.MaxInspectorMiddleName;
            inspectorCertificateTextEdit.MaxLength = LengthLimit.MaxInspectorCertificate;
        }

        private void gridControlInspectors_Click(object sender, EventArgs e)
        {

        }
        
    }

}