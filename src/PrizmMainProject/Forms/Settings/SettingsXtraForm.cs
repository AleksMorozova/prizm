﻿using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using Ninject;
using Ninject.Parameters;

using Prizm.Domain.Entity.Setup;
using Prizm.Main.Controls;
using Prizm.Main.Forms.MainChildForm;

using Prizm.Main.Properties;
using System.Collections.Generic;
using Prizm.Domain.Entity;
using Prizm.Main.Forms.Settings.ViewTypes;
using Prizm.Main.Common;
using DevExpress.XtraLayout.Customization;
using Prizm.Domain.Entity.Security;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Commands;
using Prizm.Domain.Entity.Construction;
using System.Drawing;
using Prizm.Main.Documents;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Windows.Forms;
using Prizm.Main.Languages;
using Prizm.Main.Forms.Settings.Inspections;

namespace Prizm.Main.Forms.Settings
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class SettingsXtraForm : ChildForm, IValidatable
    {
        private SettingsViewModel viewModel;
        private PipeMillSizeType CurrentPipeMillSizeType;
        private bool newPipeSizeType = false;
        ICommandManager commandManager = new CommandManager();
        private List<string> pipeSizesDuplicates;

        public SettingsXtraForm()
        {
            InitializeComponent();
            Bitmap bmp = Resources.page_setup_16;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            SetControlsTextLength();
            viewModel = (SettingsViewModel)Program.Kernel.GetService(typeof(SettingsViewModel));
            pipesSizeListGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            inspectionView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            inspectorCertificateGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            plateManufacturersListView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            jointsOperationsGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            viewModel.ModifiableView = this;
        }


        private void SettingsXtraForm_Load(object sender, EventArgs e)
        {
            pipeNumberMaskRulesLabel.Text = Resources.Mask_Label;
            viewModel.ModifiableView = this;
            viewModel.validatableView = this;
            viewModel.PropertyChanged += (s, eve) => IsModified = true;
            viewModel.LoadData();
            BindToViewModel();
            IsModified = false;
            BindCommands();

            gridViewWelders.BestFitColumns();
            gridViewInspectors.BestFitColumns();

            RefreshUserRoles(0);
            RefreshRolePermissions(0);

            seamType.SetRequiredCombo();
            pipeLength.SetRequiredText();
            pipeDiameter.SetRequiredText();
            wallThickness.SetRequiredText();
            SetConditional(seamType, delegate(bool editMode)
            {
                return IsEditable(IsEditMode);
            }
                        );
            SetConditional(pipeLength, delegate(bool editMode)
            {
                return IsEditable(IsEditMode);
            }
            );

            SetConditional(pipeDiameter, delegate(bool editMode)
            {
                return IsEditable(IsEditMode);
            }
            );

            SetConditional(wallThickness, delegate(bool editMode)
            {
                return IsEditable(IsEditMode);
            }
            );

            SetConditional(inspectionOperation, delegate(bool editMode)
            {
                return IsEditable(IsEditMode);
            }
            );

            UpdateSeamTypesComboBox();

            IsEditMode = true;


        }

        private void BindToViewModel()
        {
            #region Prizm.Data Source
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

            repositoryLookUpCertificateType.DataSource = viewModel.CertificateTypes;
            certificateTypes.DataSource = viewModel.CertificateTypes;

            seamTypes.DataSource = viewModel.SeamTypes;

            componentryTypeGridControl.DataSource = viewModel.ComponentryTypes;

            rolesBindingSource.DataSource = viewModel.Roles;
            rolesBindingSource.ListChanged += (s, e) => IsModified = true;

            permissionsBindingSource.DataSource = viewModel.Permissions;

            usersBindingSource.DataSource = viewModel.Users;

            gridControlRoles.DataSource = rolesBindingSource;

            jointOperationsBindingSource.DataSource = viewModel.JointOperations;
            #endregion

            #region Prizm.Data Bindings

            projectTitle.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "ProjectTitle");

            jointOperations.DataBindings.Add("DataSource", pipeMillSizeTypeBindingSource, "JointOperations");

            pipesSizeList.DataBindings.Add("DataSource", pipeMillSizeTypeBindingSource, "PipeMillSizeType");

            client.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "Client");

            millName.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "MillName");

            pipeNumberMask.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "MillPipeNumberMask");

            externalDocumentSize.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "DocumentSizeLimit");

            pipeLength.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "Length");

            wallThickness.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "Thickness");

            pipeDiameter.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "Diameter");

            seamType.DataBindings.Add("EditValue", pipeMillSizeTypeBindingSource, "SeamType");

            jointOperationTypeLookUpEdit.DataSource = viewModel.JointOperationTypes;

            #endregion

            projectTitle.Refresh();
        }

        private void BindCommands()
        {
            commandManager["Save"].Executor(viewModel.SaveCommand).AttachTo(saveButton);
            commandManager["Save"].RefreshState();
            SaveCommand = viewModel.SaveCommand;

            viewModel.SaveCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // project page
                new LocalizedItem(projectTitleLayoutControlItem, "SettingsProject_TitleLabel"),
                new LocalizedItem(clientLayoutControlItem, "SettingsProject_ClientLabel"),
                new LocalizedItem(plateManLayoutControlItem, "SettingsProject_PlateManufacturerLabel"),
                new LocalizedItem(extDocumentSizeLayoutControlItem, "SettingsProject_DocumentSizeLabel"),
                new LocalizedItem(millNameLayoutControlItem, "SettingsProject_MillLabel"),
                new LocalizedItem(maskLayoutControlItem, "SettingsProject_MaskEditLabel"),
                new LocalizedItem(maskLabelLayoutControlItem, "SettingsProject_MaskLabel"),
                new LocalizedItem(operationsLayoutControlItem, "SettingsProject_OperationsLabel"),
                new LocalizedItem(seamsLayoutControlItem, "SettingsProject_SeamsLabel"),

                new LocalizedItem(commonParamsLayoutControlGroup, "SettingsProject_CommonGroup"),
                new LocalizedItem(millLayoutControlGroup, "SettingsProject_MillGroup"),

                // plate manufacturer grid
                new LocalizedItem(plateManufacturerGridColumn, "SettingsProject_PlateManColumn"),
                // inspections grid
                new LocalizedItem(categoryNameColumn, "SettingsProject_InspectionsCategoryColumn"),
                new LocalizedItem(isActiveColumn, "SettingsProject_InspectionsIsActiveColumn"),
                // seams grid
                new LocalizedItem(seemTypeColumn, "SettingsProject_SeamTypeColumn"),
                new LocalizedItem(seemTypeIsActiveColumn, "SettingsProject_SeamIsActiveColumn"),

                // pipe page
                new LocalizedItem(sizesLayoutControlItem, "SettingsPipe_SizesLabel"),
                new LocalizedItem(inspectionsLayoutControlItem, "SettingsPipe_InspectionsLabel"),
                new LocalizedItem(diameterLayoutControlItem, "SettingsPipe_DiameterLabel"),
                new LocalizedItem(wallThicknessLayoutControlItem, "SettingsPipe_WallThicknessLabel"),
                new LocalizedItem(pipeLengthLayoutControlItem, "SettingsPipe_LengthLabel"),
                new LocalizedItem(seamTypeLayoutControlItem, "SettingsPipe_SeamTypeLabel"),

                new LocalizedItem(cloneTypeSizeButton, "SettingsPipe_CloneTypeSizeButton"),
                new LocalizedItem(addTestButton, "SettingsPipe_AddTestButton"),
                new LocalizedItem(editTestButton, "SettingsPipe_EditTestButton"),

                new LocalizedItem(pipeSizeGridColumn, "SettingsPipe_SizeGridColumn"),
                new LocalizedItem(isActiveGridColumn, "SettingsPipe_SizeIsActiveGridColumn"),
                
                new LocalizedItem(pipeSizeGridColumn, "SettingsPipe_InspectionsCodeColumn"),
                new LocalizedItem(inspectionNameGridColumn, "SettingsPipe_InspectionsNameColumn"),
                new LocalizedItem(categoryColumn, "SettingsPipe_InspectionsCategoryColumn"),
                new LocalizedItem(controlTypeGridColumn, "SettingsPipe_InspectionsControlTypeColumn"),
                new LocalizedItem(resultTypeGridColumn, "SettingsPipe_InspectionsResultTypeColumn"),
                new LocalizedItem(boolExpectedGridColumn, "SettingsPipe_InspectionsBoolExpectedColumn"),
                new LocalizedItem(minExpectedGridColumn, "SettingsPipe_InspectionsMinExpectedColumn"),
                new LocalizedItem(maxExpectedGridColumn, "SettingsPipe_InspectionsMaxExpectedColumn"),
                new LocalizedItem(isRequiredGridColumn, "SettingsPipe_InspectionsIsReqiredColumn"),
                new LocalizedItem(testIsActiveGridColumn, "SettingsPipe_InspectionsIsActiveColumn"),

                // pipe line page
                new LocalizedItem(lineLayoutControlGroup, "SettingsLine_LineGroup"),

                new LocalizedItem(nameGridColumn, "SettingsLine_NameColumn"),
                new LocalizedItem(isRequiredForJointGridColumn, "SettingsLine_IsReqiredColumn"),
                new LocalizedItem(TestTypeColumn, "SettingsLine_TestTypeColumn"),
                new LocalizedItem(testHasAcceptedGridColumn, "SettingsLine_HasAcceptedColumn"),
                new LocalizedItem(testHasToRepairGridColumn, "SettingsLine_RepairColumn"),
                new LocalizedItem(testHasToWithdrawGridColumn, "SettingsLine_WithdrawColumn"),
                new LocalizedItem(testResultRequiredGridColumn, "SettingsLine_IsReqiredColumn"),
                new LocalizedItem(isActiveJointOperationGridColumn, "SettingsLine_IsActiveColumn"),

                // components page
                new LocalizedItem(partsTypeLayoutControlItem, "SettingsComponent_PartsType"),

                new LocalizedItem(typeColumn, "SettingsComponent_TypeColumn"),
                new LocalizedItem(connectorsNumbersColumn, "SettingsComponent_ConnectorsNumberColumn"),
                new LocalizedItem(isActiveComponentColumn, "SettingsComponent_IsActiveTypeColumn"),

                // welders page
                new LocalizedItem(colWelderLastName, "SettingsWelders_LastNameColumn"),
                new LocalizedItem(colWelderFirstName, "SettingsWelders_FirstNameColumn"),
                new LocalizedItem(colWelderMiddleName, "SettingsWelders_MiddleNameColumn"),
                new LocalizedItem(colWelderCert, "SettingsWelders_CertificateNameColumn"),
                new LocalizedItem(colWelderCertExp, "SettingsWelders_ExpiredColumn"),
                new LocalizedItem(colWelderStamp, "SettingsWelders_StampColumn"),
                new LocalizedItem(colWelderGrade, "SettingsWelders_GradeColumn"),
                new LocalizedItem(colWelderActive, "SettingsWelders_IsActiveColumn"),

                // inspectors page
                new LocalizedItem(inspectorsLayoutControlItem, "SettingsInspectors_InspectorsLabel"),
                new LocalizedItem(certificateLayoutControlItem, "SettingsInspectors_CertificatesLabel"),
                new LocalizedItem(certTypeListLayoutControlItem, "SettingsInspectors_CertificateTypesLabel"),

                new LocalizedItem(inspectorsLayoutControlGroup, "SettingsInspectors_InspectorsGroup"),
                new LocalizedItem(certificateTypeLayoutControlGroup, "SettingsInspectors_CertificatesGroup"),
                // inspectors grid
                new LocalizedItem(colInspectorLastName, "SettingsInspectors_LastNameColumn"),
                new LocalizedItem(colInspectorFirstName, "SettingsInspectors_FirstNameColumn"),
                new LocalizedItem(colInspectorMiddleName, "SettingsInspectors_MiddleNameColumn"),
                // certificates grid
                new LocalizedItem(inspectorCertificateNumberCol, "SettingsInspectors_CertificateNumberColumn"),
                new LocalizedItem(certificateTypeColumn, "SettingsInspectors_CertificateTypeColumn"),
                new LocalizedItem(inspectorCertificateExpirationCol, "SettingsInspectors_CertificateExpirationColumn"),
                // types grid
                new LocalizedItem(certificateNameColumn, "SettingsInspectors_CertificateNameColumn"),
                new LocalizedItem(certificateIsActiveColumn, "SettingsInspectors_CertificateIsActiveColumn"),

                // users page
                // roles page
                // common page

                //new LocalizedItem(, "Settings_Label"),
            };
        }

        #endregion // --- Localization ---

        private void SettingsXtraForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void pipesSizeListGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;
            object sizeType = view.GetRow(view.FocusedRowHandle);

            var eArg = new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(
                             view.FocusedRowHandle,
                              pipesSizeListGridView.GetDataRow(view.FocusedRowHandle)
                       );
            pipesSizeListGridView_ValidateRow(pipesSizeListGridView, eArg);

            if(sizeType != null)
            {
                viewModel.UpdatePipeTests(sizeType);
            }

            CurrentPipeMillSizeType = sizeType as PipeMillSizeType;
            viewModel.CurrentPipeMillSizeType = CurrentPipeMillSizeType;
            viewModel.ModifiableView.UpdateState();
        }

        private void pipesSizeListGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var view = sender as GridView;
            pipeSizesDuplicates = FindDuplicatesInTypeSizesGrid();

            if(pipeSizesDuplicates.Count > 0)
            {
                view.SetColumnError(pipeSizeGridColumn, Resources.UNIQUE_VALUE_REQUIRED);
                e.Valid = false;
            }
            else
            {
                e.Valid = true;
                view.ClearColumnErrors();
            }
        }

        private void pipesSizeListGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if(e.Column.ToString() == "Типоразмер")
            {
                if(pipeSizesDuplicates.Count > 0)
                {
                    foreach(var item in pipeSizesDuplicates)
                    {
                        if((e.CellValue != null) && (item == e.CellValue.ToString()))
                        {
                            e.Appearance.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void cloneTypeSizeButton_Click(object sender, EventArgs e)
        {
            if(CurrentPipeMillSizeType != null)
            {
                viewModel.PipeMillSizeType.Add(CurrentPipeMillSizeType.Clone());
            }
        }

        private void inspectionView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            PipeTest pipeTest = v.GetRow(e.RowHandle) as PipeTest;
            pipeTest.IsActive = true;
            pipeTest.pipeType = CurrentPipeMillSizeType;
            foreach(PipeTest t in CurrentPipeMillSizeType.PipeTests)
            {
                t.pipeType = CurrentPipeMillSizeType;
            }
            CurrentPipeMillSizeType.PipeTests.Add(pipeTest);
        }

        private void pipesSizeListGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            viewModel.ModifiableView.UpdateState();
            GridView v = sender as GridView;
            CurrentPipeMillSizeType = v.GetRow(e.RowHandle) as PipeMillSizeType;
            CurrentPipeMillSizeType.IsActive = true;
            CurrentPipeMillSizeType.SeamType = new SeamType();

            if(CurrentPipeMillSizeType != null)
            {
                viewModel.UpdatePipeTests(CurrentPipeMillSizeType);
            }

            foreach(Prizm.Domain.Entity.Mill.Category c in viewModel.CategoryTypes)
            {
                if(c.Fixed && c.ResultType == "int")
                {
                    CurrentPipeMillSizeType.PipeTests.Add(new PipeTest { Category = c, ResultType = PipeTestResultType.Diapason, pipeType = CurrentPipeMillSizeType, IsRequired = true });
                }
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

            if(inspectorCertificateGridView.IsValidRowHandle(inspectorCertificateGridView.FocusedRowHandle))
            {
                ValidateCertificate(inspectorCertificateGridView, inspectorCertificateNumberCol, inspectorCertificateExpirationCol, e);
            }

        }

        void ValidateCertificate(GridView view, GridColumn certNameColumn, GridColumn expDateColumn, ValidateRowEventArgs e)
        {
            string certName = (string)view.GetRowCellValue(e.RowHandle, certNameColumn);
            DateTime? certExpDate = (DateTime?)view.GetRowCellValue(e.RowHandle, expDateColumn);

            view.ClearColumnErrors();

            if(string.IsNullOrWhiteSpace(certName))
            {
                view.SetColumnError(certNameColumn, Resources.VALUE_REQUIRED);
                e.Valid = false;
            }

            if(certExpDate < DateTime.Now)
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

            if(String.IsNullOrEmpty(firstName))
            {
                view.SetColumnError(firstNameColumn, Resources.VALUE_REQUIRED);
                e.Valid = false;
            }

            if(String.IsNullOrEmpty(lastName))
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
            projectTitle.Properties.MaxLength = LengthLimit.MaxProjectTitle;
            pipeNumberMask.Properties.MaxLength = LengthLimit.MaxPipeNumber;
            manufacturerRepositoryTextEdit.MaxLength = LengthLimit.MaxPlateManufacturerName;

            welderFNRepositoryTextEdit.MaxLength = LengthLimit.MaxWelderFirstName;
            welderLNRepositoryTextEdit.MaxLength = LengthLimit.MaxWelderLastName;
            welderMNRepositoryTextEdit.MaxLength = LengthLimit.MaxWelderMiddleName;
            welderCertificateTextEdit.MaxLength = LengthLimit.MaxWelderCertificate;
            stampRepositoryTextEdit.MaxLength = LengthLimit.MaxWelderStamp;

            inspectorFNRepositoryTextEdit.MaxLength = LengthLimit.MaxInspectorFirstName;
            inspectorLNRepositoryTextEdit.MaxLength = LengthLimit.MaxInspectorLastName;
            inspectorMNRepositoryTextEdit.MaxLength = LengthLimit.MaxInspectorMiddleName;
            //inspectorCertificateTextEdit.MaxLength = LengthLimit.MaxInspectorCertificate;

            typeRepositoryTextEdit.MaxLength = LengthLimit.MaxPipeMillSizeType;
            controlTypeItems.MaxLength = LengthLimit.MaxPipeTestControlType;
            resultTypeItems.MaxLength = LengthLimit.MaxPipetestResultType;

            categoryRepositoryTextEdit.MaxLength = LengthLimit.MaxCategoryName;

            seamTypeRepositoryTextEdit.MaxLength = LengthLimit.MaxSeamTypeName;
            pipelineOperationNameRepositoryItem.MaxLength = LengthLimit.MaxPipelineOperationLength;
            componentTypeNameRepositoryItemTextEdit.MaxLength = LengthLimit.MaxComponentTypeName;
            certificateTypeRepositoryItemTextEdit.MaxLength = LengthLimit.CertificateType;
            inspectorSertificateNumberRepositoryItemTextEdit.MaxLength = LengthLimit.MaxInspectorCertificate;
            userLoginRepositoryItemTextEdit.MaxLength = LengthLimit.UserLogin;
            lastNameRepositoryItemTextEdit.MaxLength = LengthLimit.UserLastName;
            userFirstNameRepositoryItemTextEdit.MaxLength = LengthLimit.UserFirstName;
            userMiddleNameRepositoryItemTextEdit.MaxLength = LengthLimit.UserMiddleName;

            roleNameRepositoryItemTextEdit1.MaxLength = LengthLimit.RoleName;
            roleDescriptionRepositoryItemTextEdit1.MaxLength = LengthLimit.RoleDescription;


        }

        private void gridControlInspectors_Click(object sender, EventArgs e)
        {

        }

        private void inspectorCertificateGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as GridView; //cert Grid

            if(view.IsValidRowHandle(e.RowHandle))
            {
                var insp = gridViewInspectors.GetFocusedRow() as InspectorViewType; // inspector from InspectorGrid
                InspectorCertificate cert = view.GetRow(e.RowHandle) as InspectorCertificate; //certif from certif grid 
                if(cert != null)
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
            Prizm.Domain.Entity.Mill.Category category
                = v.GetRow(e.RowHandle) as Prizm.Domain.Entity.Mill.Category;

            category.IsActive = true;
        }

        private void categoryGridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<Prizm.Domain.Entity.Mill.Category>(
                e,
                viewModel.CategoryTypes,
                (_) => _.IsNew());
        }

        private void gridViewRole_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as GridView;

            if(view.IsValidRowHandle(e.RowHandle))
            {
                Role role = view.GetRow(e.RowHandle) as Role;

            }
        }

        private void gridViewRole_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var view = sender as GridView;
            view.ClearColumnErrors();
            Role role = e.Row as Role;
            if(role != null)
            {
                if(String.IsNullOrEmpty(role.Name))
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

            if(view.IsValidRowHandle(rowIndex))
            {
                gridViewPermissions.ClearSelection();
                var role = view.GetRow(rowIndex) as Role;
                if(role != null)
                {
                    for(int rowHandle = 0; rowHandle < gridViewPermissions.RowCount; rowHandle++)
                    {
                        var perm = gridViewPermissions.GetRow(rowHandle) as Permission;
                        if(viewModel.RoleHasPermission(role, perm))
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

            if(role == null)
                return;

            Permission p = view.GetRow(e.ControllerRow) as Permission;

            switch(e.Action)
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

            if(view.IsValidRowHandle(e.RowHandle))
            {
                view.ClearColumnErrors();
                User user = view.GetRow(e.RowHandle) as User;
                if(String.IsNullOrEmpty(user.Login))
                {
                    view.SetColumnError(colLogin, Resources.VALUE_REQUIRED);
                    e.Valid = false;
                    return;
                }
                if(String.IsNullOrEmpty(user.PasswordHash))
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
            if(view.IsValidRowHandle(e.RowHandle))
            {
                User user = view.GetRow(e.RowHandle) as User;
                if(user != null)
                {
                    user.IsActive = true;
                }
            }
        }

        private void repositoryItemButtonUserPass_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var view = gridViewUsers;
            if(view.IsValidRowHandle(view.FocusedRowHandle))
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

            if(user != null)
            {
                var role = view.GetRow(e.ControllerRow) as Role;
                if(role != null)
                {
                    switch(e.Action)
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

            if(view.IsValidRowHandle(currentRow))
            {
                gridViewRoles.ClearSelection();
                var user = view.GetRow(currentRow) as User;
                if(user != null)
                {
                    for(int rowHandle = 0; rowHandle < gridViewRoles.RowCount; rowHandle++)
                    {
                        var role = gridViewRoles.GetRow(rowHandle) as Role;
                        if(role != null && viewModel.UserHasRole(user, role))
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

        private void repositoryItemsСategoryView_CustomRowFilter(object sender, RowFilterEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            var ct = view.DataSource as BindingList<Prizm.Domain.Entity.Mill.Category>;

            if(ct != null)
            {
                if(!(bool)ct[e.ListSourceRow].IsActive)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
        }

        private void gridViewWelders_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView v = sender as GridView;
            var data = v.GetRow(e.RowHandle) as WelderViewType;
            if(data != null)
            {
                if((e.Column.Name == colInspectorCertExp.Name || e.Column.Name == inspectorCertificateNumberCol.Name)
                    && data.CertificateExpiration.Date < DateTime.Now)
                {
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        private void inspectorCertificateGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView v = sender as GridView;
            var data = v.GetRow(e.RowHandle) as InspectorCertificate;
            if(data != null)
            {
                if(data.Certificate.ExpirationDate < DateTime.Now)
                {
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewUsers_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;

            int selectedUser = gridViewUsers.GetFocusedDataSourceRowIndex();

            if(selectedUser > -1
                && selectedUser < viewModel.Users.Count)
            {
                if(view.FocusedColumn.FieldName == "IsActive" &&
                    viewModel.Users[selectedUser].Undeletable)
                {
                    e.Cancel = true;
                }
            }
        }

        private void componentryTypeGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            ComponentType componentType = v.GetRow(e.RowHandle) as ComponentType;
            componentType.IsActive = true;
            componentType.ConnectorsCount = 2;
        }

        private void componentryTypeGridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<ComponentType>(
                e,
                viewModel.ComponentryTypes,
                (_) => _.IsNew());
        }

        private void certificateTypesView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            InspectorCertificateType certificateType = v.GetRow(e.RowHandle) as InspectorCertificateType;
            certificateType.IsActive = true;
        }

        private void certificateTypesView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<InspectorCertificateType>(
                e,
                viewModel.CertificateTypes,
                (_) => _.IsNew());
        }

        private void repositoryLookUpCertificateTypeView_CustomRowFilter(object sender, RowFilterEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            var certp = view.DataSource as BindingList<InspectorCertificateType>;

            if(certp != null)
            {
                if(!(bool)certp[e.ListSourceRow].IsActive)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
        }

        private void projectPage_Enter(object sender, EventArgs e)
        {
            // Title is required field but his value refreshed only after page enter.
            // This tag is checking on 
            projectTitle.Tag = "visited";
        }

        private void gridViewInspectors_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView v = sender as GridView;
            var data = v.GetRow(e.RowHandle) as InspectorViewType;
            if(data != null)
            {
                foreach(InspectorCertificate c in data.Certificates)
                {
                    if(c.Certificate.ExpirationDate < DateTime.Now)
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    }
                }
            }
        }

        private void seemTypeGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            SeamType seemType = v.GetRow(e.RowHandle) as SeamType;
            seemType.IsActive = true;
        }

        private void seemTypeGridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<SeamType>(
                e,
                viewModel.SeamTypes,
                (_) => _.IsNew());
        }

        private void UpdateSeamTypesComboBox()
        {
            seamType.Properties.Items.Clear();
            foreach(SeamType t in viewModel.SeamTypes)
            {
                if(t.IsActive)
                {
                    seamType.Properties.Items.Add(t);
                }
            }
        }

        private void inspectionView_BeforeLeaveRow(object sender, RowAllowEventArgs e)
        {
            GridView v = sender as GridView;
            PipeTest pipeTest = v.GetRow(e.RowHandle) as PipeTest;
            if(CurrentPipeMillSizeType != null)
            {
                foreach(PipeTest t in CurrentPipeMillSizeType.PipeTests)
                {
                    t.pipeType = CurrentPipeMillSizeType;
                }
            }
        }

        bool IValidatable.Validate()
        {
            bool codeValidate = true;
            bool pipeSizeValidate = true;

            if(pipeLayoutControlGroup.Tag != null)
            {
                codeValidate = CodeValidation();
                pipeSizeValidate = PipeSizeValidation();
            }
            return dxValidationProvider.Validate() && codeValidate && pipeSizeValidate;
        }

        private bool PipeSizeValidation()
        {
            var pipeSizeEventArg = new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(
                                        pipesSizeListGridView.FocusedRowHandle,
                                        pipesSizeListGridView.GetDataRow(pipesSizeListGridView.FocusedRowHandle)
                                   );
            pipesSizeListGridView_ValidateRow(pipesSizeListGridView, pipeSizeEventArg);

            return pipeSizeEventArg.Valid;
        }

        private bool CodeValidation()
        {
            bool codeValidate = false;
            for(int i = 0; i < inspectionView.RowCount; i++)
            {
                if(Convert.ToString(inspectionView.GetRowCellValue(i, "Code")) == null || Convert.ToString(inspectionView.GetRowCellValue(i, "Name")) == null || Convert.ToString(inspectionView.GetRowCellValue(i, "Category")) == null)
                {
                    inspectionView.FocusedRowHandle = i;

                    inspectionView_ValidateRow(
                        inspectionView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, inspectionView.GetDataRow(i)));
                }
            }
            codeValidate = PipeTestsCheck();
            return codeValidate;
        }

        private void inspectionView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView gv = sender as GridView;
            PipeTest pipeTest = gv.GetRow(e.RowHandle) as PipeTest;
            if(pipeTest.Code == null)
            {
                gv.SetColumnError(inspectionCodeGridColumn, Resources.Empty_Operation_Code);
                e.Valid = false;
            }

            if(pipeTest.Name == null)
            {
                gv.SetColumnError(inspectionNameGridColumn, Resources.Empty_Operation_Name);
                e.Valid = false;
            }

            if(pipeTest.Category == null)
            {
                gv.SetColumnError(categoryColumn, Resources.VALUE_REQUIRED);
                e.Valid = false;
            }
        }

        private bool IsEditable(bool editMode)
        {
            return (CurrentPipeMillSizeType != null && editMode);
        }

        private void projectLayoutControlGroup_Shown(object sender, EventArgs e)
        {
            #region project title validation only afrer project tab is shown
            ConditionValidationRule projectTitleValidationRule = new ConditionValidationRule();
            projectTitleValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            projectTitleValidationRule.ErrorText = Resources.VALUE_REQUIRED;
            projectTitleValidationRule.ErrorType = ErrorType.Critical;

            dxValidationProvider.SetValidationRule(projectTitle, projectTitleValidationRule);
            #endregion
        }

        private void pipeLayoutControlGroup_Shown(object sender, EventArgs e)
        {
            pipeLayoutControlGroup.Tag = "Visited";
            #region validation only afrer tab is shown
            ConditionValidationRule diameterValidationRule = new ConditionValidationRule();
            diameterValidationRule.ConditionOperator = ConditionOperator.Greater;
            diameterValidationRule.Value1 = 0;
            diameterValidationRule.ErrorText = Resources.VALUE_REQUIRED;
            diameterValidationRule.ErrorType = ErrorType.Critical;

            ConditionValidationRule wallThicknessValidationRule = new ConditionValidationRule();
            wallThicknessValidationRule.ConditionOperator = ConditionOperator.Greater;
            wallThicknessValidationRule.Value1 = 0;
            wallThicknessValidationRule.ErrorText = Resources.VALUE_REQUIRED;
            wallThicknessValidationRule.ErrorType = ErrorType.Critical;

            ConditionValidationRule pipeLengthValidationRule = new ConditionValidationRule();
            pipeLengthValidationRule.ConditionOperator = ConditionOperator.Greater;
            pipeLengthValidationRule.Value1 = 0;
            pipeLengthValidationRule.ErrorText = Resources.VALUE_REQUIRED;
            pipeLengthValidationRule.ErrorType = ErrorType.Critical;

            ConditionValidationRule seamTypeValidationRule = new ConditionValidationRule();
            seamTypeValidationRule.ConditionOperator = ConditionOperator.NotEquals;
            seamTypeValidationRule.Value1 = seamType.Properties.NullText;
            seamTypeValidationRule.ErrorText = Resources.VALUE_REQUIRED;
            seamTypeValidationRule.ErrorType = ErrorType.Critical;

            dxValidationProvider.SetValidationRule(pipeDiameter, diameterValidationRule);
            dxValidationProvider.SetValidationRule(wallThickness, wallThicknessValidationRule);
            dxValidationProvider.SetValidationRule(pipeLength, pipeLengthValidationRule);
            dxValidationProvider.SetValidationRule(seamType, seamTypeValidationRule);
            #endregion
            if(viewModel.SeamTypes != null)
            {
                UpdateSeamTypesComboBox();
            }
        }
        /// <summary>
        /// Set IsModified for settings after grid data changed. Used not for most grid in settings.
        /// </summary>
        /// <param name="sender">GridView</param>
        /// <param name="e"></param>
        private void CellModifiedGridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            IsModified = true;
        }

        private bool PipeTestsCheck()
        {
            bool codeValidate = true;

            if(viewModel.PipeTests.Count > 0)
            {
                foreach(PipeTest t in viewModel.PipeTests)
                {
                    if(t.Code == null && t.Name == null)
                    {
                        codeValidate = false;
                        inspectionView.SetColumnError(inspectionView.Columns[0], Resources.VALUE_REQUIRED);
                        break;
                    }
                }
            }
            else
            {
                codeValidate = false;
                inspectionView.SetColumnError(inspectionView.Columns[0], Resources.VALUE_REQUIRED);
            }

            return codeValidate;
        }

        private List<string> FindDuplicatesInTypeSizesGrid()
        {
            var pipeSizes = viewModel.PipeMillSizeType;

            return pipeSizes.GroupBy(x => x.Type)
                             .Where(g => g.Count() > 1)
                             .Select(g => g.Key)
                             .ToList();
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            if(IsEditMode)
            {
                using(var addForm = new MillInspectionXtraForm(null, viewModel.ControlType, viewModel.ResultType, viewModel.CategoryTypes))
                {
                    if(addForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        addForm.viewModel.PipeTest.pipeType = viewModel.CurrentPipeMillSizeType;
                        viewModel.CurrentPipeMillSizeType.PipeTests.Add(addForm.viewModel.PipeTest);
                        viewModel.PipeTests.Add(addForm.viewModel.PipeTest);
                        IsModified = true;
                        inspectionOperation.RefreshDataSource();
                    }
                }
            }
        }

        private void editTestButton_Click(object sender, EventArgs e)
        {
            if(inspectionView.IsValidRowHandle(inspectionView.FocusedRowHandle) && IsEditMode)
            {
                var selectedTest = inspectionView.GetRow(inspectionView.FocusedRowHandle) as PipeTest;
                if(selectedTest != null)
                {
                    using(var editForm = new MillInspectionXtraForm(selectedTest, viewModel.ControlType, viewModel.ResultType, viewModel.CategoryTypes))
                    {
                        editForm.ShowDialog();
                    }
                }
            }
        }

        private void inspectionOperation_DoubleClick(object sender, EventArgs e)
        {
            if(inspectionView.IsValidRowHandle(inspectionView.FocusedRowHandle) && IsEditMode)
            {
                var selectedTest = inspectionView.GetRow(inspectionView.FocusedRowHandle) as PipeTest;
                if(selectedTest != null)
                {
                    using(var editForm = new MillInspectionXtraForm(selectedTest, viewModel.ControlType, viewModel.ResultType, viewModel.CategoryTypes))
                    {
                        editForm.ShowDialog();
                    }
                }
            }
        }


    }
}