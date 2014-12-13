using System;
using System.ComponentModel;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using Ninject;
using Ninject.Parameters;

using Domain.Entity.Setup;

using PrizmMain.Forms.Settings.Dictionary;
using PrizmMain.Forms.Settings.UserRole.Role;
using PrizmMain.Forms.Settings.UserRole.User;
using PrizmMain.Forms.MainChildForm;

using PrizmMain.Properties;
using System.Collections.Generic;
using Domain.Entity;
using PrizmMain.Forms.Settings.ViewTypes;
using PrizmMain.Common;
using DevExpress.XtraLayout.Customization;
using Domain.Entity.Security;
using Domain.Entity.Mill;

namespace PrizmMain.Forms.Settings
{
    [System.ComponentModel.DesignerCategory("Form")] 
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
            inspectorCertificateGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            plateManufacturersListView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            jointsOperationsGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
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

            RefreshUserRoles(0);
            RefreshRolePermissions(0);
        }

        private void BindToViewModel()
        {
            #region Data Source
            pipeMillSizeTypeBindingSource.DataSource = viewModel;

            inspectorBindingSource.DataSource = viewModel.Inspectors;
            inspectorCertificateBindingSource.DataSource = inspectorBindingSource;
            inspectorCertificateBindingSource.DataMember = "Certificates";

            gridControlWelders.DataSource = viewModel.Welders;

            gridControlInspectors.DataSource = inspectorBindingSource;
            gridControlInspectorsCertificates.DataSource = inspectorCertificateBindingSource;

            plateManufacturersList.DataSource = viewModel.PlateManufacturers;

            controlTypeItems.DataSource = viewModel.ControlType;
            resultTypeItems.DataSource = viewModel.ResultType;

            inspectionOperation.DataSource = viewModel.PipeTests;

            repositoryItemsСategory.DataSource = viewModel.CategoryTypes;
            categoriesGrid.DataSource = viewModel.CategoryTypes;

            rolesBindingSource.DataSource = viewModel.Roles;
            rolesBindingSource.ListChanged += (s, e) => IsModified = true;

            permissionsBindingSource.DataSource = viewModel.Permissions;

            usersBindingSource.DataSource = viewModel.Users;

            gridControlRoles.DataSource = rolesBindingSource;

            jointOperationsBindingSource.DataSource = viewModel.JointOperations;
            #endregion

            #region Data Bindings

            jointOperations.DataBindings.Add("DataSource", pipeMillSizeTypeBindingSource, "JointOperations");

            pipesSizeList.DataBindings.Add("DataSource", pipeMillSizeTypeBindingSource, "PipeMillSizeType");

            client.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "Client");

            millName.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "MillName");

            pipeNumberMask.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "MillPipeNumberMask");

            externalDocumentSize.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "DocumentSizeLimit");
            #endregion
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

        private void inspectorCertificateGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {

            if (inspectorCertificateGridView.IsValidRowHandle(inspectorCertificateGridView.FocusedRowHandle))
            {
                ValidateCertificate(inspectorCertificateGridView, inspectorCertificateNumberCol, inspectorCertificateExpirationCol, e);    
            }
            
        } 

        void ValidateCertificate(GridView view, GridColumn certNameColumn, GridColumn expDateColumn, ValidateRowEventArgs e)
        {
            string certName = (string)view.GetRowCellValue(e.RowHandle, certNameColumn);
            DateTime? certExpDate = (DateTime?)view.GetRowCellValue(e.RowHandle, expDateColumn);

            view.ClearColumnErrors();

            if (string.IsNullOrWhiteSpace(certName))
            {
                view.SetColumnError(certNameColumn, Resources.VALUE_REQUIRED);
                e.Valid = false;
            }

            if (certExpDate < DateTime.Now)
            {
                view.SetColumnError(expDateColumn, Resources.DATA_EXPIRED);
                e.Valid = false;
            }
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

        private void inspectionView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<PipeTest>(e, viewModel.PipeTests, (_) => _.IsNew());
        }

        private void pipesSizeListGridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<PipeMillSizeType>(e, viewModel.PipeMillSizeType, (_) => _.IsNew());
        }

        private void plateManufacturersList_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<PlateManufacturer>(e, viewModel.PlateManufacturers, (_) => _.IsNew());
        }

        private void inspectorCertificateGridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            GridView view = sender as GridView;
            var insp = gridViewInspectors.GetFocusedRow() as InspectorViewType; // inspector from InspectorGrid
            view.RemoveSelectedItem<InspectorCertificate>(e, insp.Certificates, (_) => _.IsNew());
            inspectorCertificateGridView.RefreshData();
        }

        private void SetControlsTextLength()
        {
            client.Properties.MaxLength = LengthLimit.MaxProjectClient;
            millName.Properties.MaxLength = LengthLimit.MaxProjectMillName;
            pipeNumberMask.Properties.MaxLength = LengthLimit.MaxPipeNumber;
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
            typeRepositoryTextEdit.MaxLength = LengthLimit.MaxPipeMillSizeType;
            codeRepositoryTextEdit.MaxLength = LengthLimit.MaxPipeTestCode;
            controlNameRepositoryTextEdit.MaxLength = LengthLimit.MaxPipeTestName;
            subjectRepositoryItemEdit.MaxLength = LengthLimit.MaxPipeTestSubject;
            controlTypeItems.MaxLength = LengthLimit.MaxPipeTestControlType;
            resultTypeItems.MaxLength = LengthLimit.MaxPipetestResultType;
            categoryRepositoryTextEdit.MaxLength = LengthLimit.MaxCategoryName;

        }

        private void gridControlInspectors_Click(object sender, EventArgs e)
        {

        }

        private void inspectorCertificateGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as GridView; //cert Grid

            if (view.IsValidRowHandle(e.RowHandle))
            {
                var insp = gridViewInspectors.GetFocusedRow() as InspectorViewType; // inspector from InspectorGrid
                InspectorCertificate cert = view.GetRow(e.RowHandle) as InspectorCertificate; //certif from certif grid 
                if (cert != null)
                {
                    cert.Inspector = insp.Inspector;
                    cert.IsActive = true;
                    cert.Certificate = new Certificate { ExpirationDate = DateTime.Now };
                }
            }
        }

        private void gridViewInspectors_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
        }

private void categoryGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            Domain.Entity.Mill.Category category
                = v.GetRow(e.RowHandle) as Domain.Entity.Mill.Category;

            category.IsActive = true;
        }

        private void categoryGridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<Domain.Entity.Mill.Category>(
                e,
                viewModel.CategoryTypes,
                (_) => _.IsNew());
        }

        private void gridViewRole_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as GridView;

            if (view.IsValidRowHandle(e.RowHandle))
            {
                Role role = view.GetRow(e.RowHandle) as Role;

            }
        }

        private void gridViewRole_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var view = sender as GridView;
            view.ClearColumnErrors();
            Role role = e.Row as Role;
            if (role != null)
            {
                if (String.IsNullOrEmpty(role.Name))
                {
                    e.Valid = false;
                    view.SetColumnError(colRoleSetupName, Resources.VALUE_REQUIRED);
                }
            }
        }

        private void gridViewRole_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        void RefreshRolePermissions(int rowIndex)
        {
            var view = gridViewRole;

            if (view.IsValidRowHandle(rowIndex))
            {
                gridViewPermissions.ClearSelection();
                var role = view.GetRow(rowIndex) as Role;
                if (role != null)
                {
                    for (int rowHandle = 0; rowHandle < gridViewPermissions.RowCount; rowHandle++)
                    {
                        var perm = gridViewPermissions.GetRow(rowHandle) as Permission;
                        if (viewModel.RoleHasPermission(role, perm))
                        {
                            gridViewPermissions.SelectRow(rowHandle);
                        }
                    }
                }
            }
        }

        private void gridViewRole_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            RefreshRolePermissions(e.FocusedRowHandle);
        }

        private void gridViewPermissions_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var view = sender as GridView;
            var role = gridViewRole.GetFocusedRow() as Role;

            if (role == null)
                return;

            Permission p = view.GetRow(e.ControllerRow) as Permission;

            switch (e.Action)
            {
                case CollectionChangeAction.Add:
                    viewModel.AddPermissionToRole(role, p);
                    break;
                case CollectionChangeAction.Remove:
                    viewModel.RemovePermissionFromRole(role, p);
                    break;
            }
        }

        private void gridViewUsers_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var view = sender as GridView;

            if (view.IsValidRowHandle(e.RowHandle))
            {
                view.ClearColumnErrors();
                User user = view.GetRow(e.RowHandle) as User;
                if (String.IsNullOrEmpty(user.Login))
                {
                    view.SetColumnError(colLogin, Resources.VALUE_REQUIRED);
                    e.Valid = false;
                    return;
                }
                if (String.IsNullOrEmpty(user.PasswordHash))
                {
                    view.SetColumnError(colUserPass, Resources.VALUE_REQUIRED);
                    e.Valid = false;
                    return;
                }
            }
        }

        private void gridViewUsers_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gridViewUsers_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as GridView;
            if (view.IsValidRowHandle(e.RowHandle))
            {
                User user = view.GetRow(e.RowHandle) as User;
                if (user != null)
                {
                    user.IsActive = true;
                }
            }
        }

        private void repositoryItemButtonUserPass_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var view = gridViewUsers;
            if (view.IsValidRowHandle(view.FocusedRowHandle))
            {
                User user = view.GetRow(view.FocusedRowHandle) as User;
                if(user != null)
                {
                    PasswordChangeDialog dlg = new PasswordChangeDialog();
                    if(dlg.ShowPasswordDialog(user.PasswordHash) == System.Windows.Forms.DialogResult.OK)
                    {
                        user.PasswordHash = dlg.NewPasswordHash;
                        IsModified = true;
                    }
                }
                
            }
        }

        private void gridViewUsers_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            var view = sender as GridView;
            view.RemoveSelectedItem(e, viewModel.Users, (_) => _.IsNew());
        }

        private void gridViewRoles_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var view = sender as GridView;
            var user = gridViewUsers.GetRow(gridViewUsers.FocusedRowHandle) as User;

            if (user != null)
            {
                var role = view.GetRow(e.ControllerRow) as Role;
                if (role != null)
                {
                    switch (e.Action)
                    {
                        case CollectionChangeAction.Add:
                            viewModel.AddRoleToUser(role, user);
                            break;
                        case CollectionChangeAction.Remove:
                            viewModel.RemoveRoleFromUser(role, user);
                            break;
                    }
                }
            }
        }

        void RefreshUserRoles(int currentRow)
        {
            var view = gridViewUsers;

            if (view.IsValidRowHandle(currentRow))
            {
                gridViewRoles.ClearSelection();
                var user = view.GetRow(currentRow) as User;
                if (user != null)
                {
                    for (int rowHandle = 0; rowHandle < gridViewRoles.RowCount; rowHandle++)
                    {
                        var role = gridViewRoles.GetRow(rowHandle) as Role;
                        if (role != null && viewModel.UserHasRole(user, role))
                        {
                            gridViewRoles.SelectRow(rowHandle);
                        }
                    }
                }
            }
        }

        private void gridViewUsers_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            RefreshUserRoles(e.FocusedRowHandle);
        }

        private void jointsOperationsGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            JointOperation jointOperation = v.GetRow(e.RowHandle) as JointOperation;
            jointOperation.IsActive = true;
        }

    }

}