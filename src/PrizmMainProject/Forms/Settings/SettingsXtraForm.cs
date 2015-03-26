using System;
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
using Domain.Entity.Security;
using Prizm.Main.Security;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data;

namespace Prizm.Main.Forms.Settings
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class SettingsXtraForm : ChildEditableForm, IValidatable
    {
        private Dictionary<GridView, DuplicatesList> findDuplicateList;
        private SettingsViewModel viewModel;
        private PipeMillSizeType CurrentPipeMillSizeType;
        bool controlOerationValidate = true;
        ICommandManager commandManager = new CommandManager();
        private List<string> localizedPipeTestControlTypes = new List<string>();
        private List<string> localizedPipeTestResultTypes = new List<string>();
        private List<string> localizedJointOperationTypes = new List<string>();
        private MillInspectionXtraForm inspectionForm = null;
        private bool plateManufacturersValidate = true;
        private bool categoriesValidate = true;
        private bool seamTypesValidate = true;
        private bool pipesSizeValidate = true;
        private bool componentryTypeValidate = true;
        private bool jointsOperationsValidate = true;
        private bool weldersValidate = true;
        private bool inspectorsValidate = true;
        private bool inspectorsCertificateValidate = true;
        private bool inspectorsCertificateTypeValidate = true;
        private bool usersValidate = true;
        private bool roleValidate = true;
        public SettingsXtraForm()
        {
            InitializeComponent();
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
            EnumWrapper<PipeTestControlType>.LoadItems(localizedPipeTestControlTypes, skip0: true);
            EnumWrapper<PipeTestResultType>.LoadItems(localizedPipeTestResultTypes, skip0: true);
            EnumWrapper<JointOperationType>.LoadItems(localizedJointOperationTypes, skip0: true);

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
            // TODO: rewrite switch Editable for inspectors certificate grid
            //SetConditional(gridControlInspectorsCertificates, delegate(bool editMode)
            //{
            //    return IsEditableCrtificate(IsEditMode);
            //}
            //);
            SetWorkstationReadonlyFields();
            UpdateSeamTypesComboBox();
            ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();
            IsEditMode = true;//do not remove until IsEditMode logic is changed
            IsEditMode = ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditSettings);

            repositoryWelderCertDateEdit.SetLimits();
            repositoryInspectorCertDateEdit.SetLimits();
            repositoryPassExpiredDateEdit.SetLimits();
            // TODO: pipeLayoutControlGroup.Tag always has value  because method pipeLayoutControlGroup_Shown is always call
            findDuplicateList = new Dictionary<GridView, DuplicatesList>();
            CreateDuplicateList();

            externalDocumentSize.SetMask(Constants.PositiveDigitMask);
            pipeLength.SetMask(Constants.PositiveDigitMask);

            categoryColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            certificateTypeColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;

            inspectionCodeGridColumn.SortOrder = ColumnSortOrder.Ascending;
            
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

            gridControlPermission.DataSource = viewModel.Permissions;

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
                new LocalizedItem(projectTitleLayoutControlItem, StringResources.SettingsProject_TitleLabel.Id),
                new LocalizedItem(clientLayoutControlItem, StringResources.SettingsProject_ClientLabel.Id),
                new LocalizedItem(plateManLayoutControlItem, StringResources.SettingsProject_PlateManufacturerLabel.Id),
                new LocalizedItem(extDocumentSizeLayoutControlItem, StringResources.SettingsProject_DocumentSizeLabel.Id),
                new LocalizedItem(millNameLayoutControlItem, StringResources.SettingsProject_MillLabel.Id),
                new LocalizedItem(maskLayoutControlItem, StringResources.SettingsProject_MaskEditLabel.Id),
                new LocalizedItem(pipeNumberMaskRulesLabel, StringResources.Mask_Label.Id),
                new LocalizedItem(operationsLayoutControlItem, StringResources.SettingsProject_OperationsLabel.Id),
                new LocalizedItem(seamsLayoutControlItem, StringResources.SettingsProject_SeamsLabel.Id),

                new LocalizedItem(commonParamsLayoutControlGroup, StringResources.SettingsProject_CommonGroup.Id),
                new LocalizedItem(millLayoutControlGroup, StringResources.SettingsProject_MillGroup.Id),
                new LocalizedItem(techParamsLayoutControlGroup, StringResources.SettingsProject_TechParametersGroup.Id),

                // plate manufacturer grid
                new LocalizedItem(plateManufacturerGridColumn, StringResources.SettingsProject_PlateManColumn.Id),
                new LocalizedItem(millNamegridColumn, StringResources.Settings_MillNameGridColumn.Id),
                // inspections grid
                new LocalizedItem(categoryNameColumn, StringResources.SettingsProject_InspectionsCategoryColumn.Id),
                new LocalizedItem(isActiveColumn, StringResources.SettingsProject_InspectionsIsActiveColumn.Id),
                // seams grid
                new LocalizedItem(seamTypeColumn, StringResources.SettingsProject_SeamTypeColumn.Id),
                new LocalizedItem(seemTypeIsActiveColumn, StringResources.SettingsProject_SeamIsActiveColumn.Id),
                new LocalizedItem(millNameColumn, StringResources.Settings_MillNameGridColumn.Id),

                // pipe page
                new LocalizedItem(sizesLayoutControlItem, StringResources.SettingsPipe_SizesLabel.Id),
                new LocalizedItem(inspectionsLayoutControlItem, StringResources.SettingsPipe_InspectionsLabel.Id),
                new LocalizedItem(diameterLayoutControlItem, StringResources.SettingsPipe_DiameterLabel.Id),
                new LocalizedItem(wallThicknessLayoutControlItem, StringResources.SettingsPipe_WallThicknessLabel.Id),
                new LocalizedItem(pipeLengthLayoutControlItem, StringResources.SettingsPipe_LengthLabel.Id),
                new LocalizedItem(seamTypeLayoutControlItem, StringResources.SettingsPipe_SeamTypeLabel.Id),

                new LocalizedItem(cloneTypeSizeButton, StringResources.SettingsPipe_CloneTypeSizeButton.Id),
                new LocalizedItem(addTestButton, StringResources.SettingsPipe_AddTestButton.Id),
                new LocalizedItem(editTestButton, StringResources.SettingsPipe_EditTestButton.Id),

                new LocalizedItem(pipeSizeGridColumn, StringResources.SettingsPipe_SizeGridColumn.Id),
                new LocalizedItem(isActiveGridColumn, StringResources.SettingsPipe_SizeIsActiveGridColumn.Id),
                new LocalizedItem(millGridColumn, StringResources.Settings_MillNameGridColumn.Id),
                
                new LocalizedItem(inspectionCodeGridColumn, StringResources.SettingsPipe_InspectionsCodeColumn.Id),
                new LocalizedItem(inspectionNameGridColumn, StringResources.SettingsPipe_InspectionsNameColumn.Id),
                new LocalizedItem(categoryColumn,StringResources.SettingsPipe_InspectionsCategoryColumn.Id),
                new LocalizedItem(controlTypeGridColumn, StringResources.SettingsPipe_InspectionsControlTypeColumn.Id),
                new LocalizedItem(resultTypeGridColumn, StringResources.SettingsPipe_InspectionsResultTypeColumn.Id),
                new LocalizedItem(boolExpectedGridColumn, StringResources.SettingsPipe_InspectionsBoolExpectedColumn.Id),
                new LocalizedItem(minExpectedGridColumn, StringResources.SettingsPipe_InspectionsMinExpectedColumn.Id),
                new LocalizedItem(maxExpectedGridColumn, StringResources.SettingsPipe_InspectionsMaxExpectedColumn.Id),
                new LocalizedItem(isRequiredGridColumn, StringResources.SettingsPipe_InspectionsIsReqiredColumn.Id),
                new LocalizedItem(testIsActiveGridColumn, StringResources.SettingsPipe_InspectionsIsActiveColumn.Id),
                new LocalizedItem(sizeParamsLayoutControlGroup, StringResources.SettingsPipe_sizeParamsLayoutControlGroup.Id),

                // pipe line page
                new LocalizedItem(lineLayoutControlGroup, StringResources.SettingsLine_LineGroup.Id),

                new LocalizedItem(nameGridColumn, StringResources.SettingsLine_NameColumn.Id),
                new LocalizedItem(isRequiredForJointGridColumn, StringResources.SettingsLine_IsReqiredColumn.Id),
                new LocalizedItem(TestTypeColumn, StringResources.SettingsLine_TestTypeColumn.Id),
                new LocalizedItem(testHasAcceptedGridColumn, StringResources.SettingsLine_HasAcceptedColumn.Id),
                new LocalizedItem(testHasToRepairGridColumn, StringResources.SettingsLine_RepairColumn.Id),
                new LocalizedItem(testHasToWithdrawGridColumn, StringResources.SettingsLine_WithdrawColumn.Id),
                new LocalizedItem(testResultRequiredGridColumn, StringResources.SettingsLine_IsReqiredResultColumn.Id),
                new LocalizedItem(isActiveJointOperationGridColumn, StringResources.SettingsLine_IsActiveColumn.Id),
                new LocalizedItem(jointOperationLayoutControlItem, StringResources.SettingsLine_JointOperationLayoutControlItem.Id),

                // components page
                new LocalizedItem(partsTypeLayoutControlItem, StringResources.SettingsComponent_PartsType.Id),

                new LocalizedItem(typeColumn, StringResources.SettingsComponent_TypeColumn.Id),
                new LocalizedItem(connectorsNumbersColumn, StringResources.SettingsComponent_ConnectorsNumberColumn.Id),
                new LocalizedItem(isActiveComponentColumn, StringResources.SettingsComponent_IsActiveTypeColumn.Id),
                new LocalizedItem(constructionSiteColumn, StringResources.SettingsComponent_ConstructionNameColumn.Id),


                // welders page
                new LocalizedItem(colWelderLastName, StringResources.SettingsWelders_LastNameColumn.Id),
                new LocalizedItem(colWelderFirstName, StringResources.SettingsWelders_FirstNameColumn.Id),
                new LocalizedItem(colWelderMiddleName, StringResources.SettingsWelders_MiddleNameColumn.Id),
                new LocalizedItem(colWelderCert, StringResources.SettingsWelders_CertificateNameColumn.Id),
                new LocalizedItem(colWelderCertExp, StringResources.SettingsWelders_ExpiredColumn.Id),
                new LocalizedItem(colWelderStamp, StringResources.SettingsWelders_StampColumn.Id),
                new LocalizedItem(colWelderGrade, StringResources.SettingsWelders_GradeColumn.Id),
                new LocalizedItem(colWelderActive, StringResources.SettingsWelders_IsActiveColumn.Id),

                // inspectors page
                new LocalizedItem(inspectorsLayoutControlItem, StringResources.SettingsInspectors_InspectorsLabel.Id),
                new LocalizedItem(certificateLayoutControlItem, StringResources.SettingsInspectors_CertificatesLabel.Id),
                new LocalizedItem(certTypeListLayoutControlItem, StringResources.SettingsInspectors_CertificateTypesLabel.Id),
                new LocalizedItem(inspectorLayoutControlGroup, StringResources.SettingsInspectors_InspectorsGroup.Id),
                new LocalizedItem(certificateTypeLayoutControlGroup, StringResources.SettingsInspectors_CertificatesGroup.Id),
                // inspectors grid
                new LocalizedItem(colInspectorLastName, StringResources.SettingsInspectors_LastNameColumn.Id),
                new LocalizedItem(colInspectorFirstName, StringResources.SettingsInspectors_FirstNameColumn.Id),
                new LocalizedItem(colInspectorMiddleName, StringResources.SettingsInspectors_MiddleNameColumn.Id),
                new LocalizedItem(colInspectorActive, StringResources.SettingsInspectors_IsActive.Id),
                // certificates grid
                new LocalizedItem(inspectorCertificateNumberCol, "SettingsInspectors_CertificateNumberColumn"),
                new LocalizedItem(certificateTypeColumn, "SettingsInspectors_CertificateTypeColumn"),
                new LocalizedItem(inspectorCertificateExpirationCol, "SettingsInspectors_CertificateExpirationColumn"),
                new LocalizedItem(colGrade, StringResources.SettingsInspectors_InspectorGrade.Id),
                // types grid
                new LocalizedItem(certificateNameColumn, "SettingsInspectors_CertificateNameColumn"),
                new LocalizedItem(certificateIsActiveColumn, "SettingsInspectors_CertificateIsActiveColumn"),

                // users page
                new LocalizedItem(userLayoutControlItem, "SettingsUser_UsersLabel"),
                new LocalizedItem(roleLayoutControlItem, StringResources.SettingsUser_RolesLabel.Id),

                new LocalizedItem(colLogin, "SettingsUser_LoginColumn"),
                new LocalizedItem(colLastName, "SettingsUser_LastNameColumn"),
                new LocalizedItem(colMiddleName, "SettingsUser_MiddleNameColumn"),
                new LocalizedItem(colFirstName, "SettingsUser_FirstNameColumn"),
                new LocalizedItem(colPasswordExpires, "SettingsUser_PassExpiredColumn"),
                new LocalizedItem(colActive, "SettingsUser_IsActiveColumn"),
                new LocalizedItem(colUserPass, "SettingsUser_PassColumn"),

                // roles page
                new LocalizedItem(rolesTabLayoutControlItem, "SettingsRoles_Label"),
                new LocalizedItem(permissionLayoutControlItem, "SettingsRoles_PermissionLabel"),

                new LocalizedItem(colRoleSetupName, "SettingsRole_NameColumn"),
                new LocalizedItem(colDesc, "SettingsRole_DescriptionColumn"),
                // common pages
                new LocalizedItem(projectLayoutControlGroup, "Settings_ProjectTab"),
                new LocalizedItem(pipeLayoutControlGroup, "Settings_PipeTab"),
                new LocalizedItem(lineLayoutControlGroup, "Settings_LineTab"),
                new LocalizedItem(partsLayoutControlGroup, "Settings_PartsTab"),
                new LocalizedItem(weldersLayoutControlGroup, "Settings_WeldersTab"),
                new LocalizedItem(inspectorsLayoutControlGroup, "Settings_InspectorsTab"),
                new LocalizedItem(usersLayoutControlGroup, "Settings_UsersTab"),
                new LocalizedItem(rolesLayoutControlGroup, "Settings_RolesTab"),

                new LocalizedItem(saveButton, "Settings_SaveButton"),
                new LocalizedItem(closeButton, "Settings_CloseButton"),
                
                //grid columns with enums
                new LocalizedItem(inspectionView, localizedPipeTestControlTypes, new string [] {StringResources.ControlTypeWitness.Id,
                                                                                         StringResources.ControlTypeReview.Id,
                                                                                         StringResources.ControlTypeMonitor.Id,
                                                                                         StringResources.ControlTypeHold.Id}),
                new LocalizedItem (inspectionView, localizedPipeTestResultTypes, new string [] {StringResources.TestResultTypeBoolean.Id,
                                                                                                  StringResources.TestResultTypeRange.Id,
                                                                                                  StringResources.TestResultTypeString.Id }),
                //repository lookup edit
                new LocalizedItem(jointOperationTypeLookUpEdit, localizedJointOperationTypes, new string[] {StringResources.JointOperationType_Test.Id,
                                                                                                            StringResources.JointOperationType_Action.Id,
                                                                                                            StringResources.JointOperationType_Weld.Id,
                                                                                                            StringResources.JointOperationType_Withdraw.Id}),
                
                new LocalizedItem(this, localizedHeader, new string[] {StringResources.Settings_Title.Id} )
                                                                                         
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
            //save previous IsModified state
            bool wasModified = IsModified;
            GridView view = sender as GridView;
            object sizeType = view.GetRow(view.FocusedRowHandle);

            var eArg = new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(
                             view.FocusedRowHandle,
                              pipesSizeListGridView.GetDataRow(view.FocusedRowHandle)
                       );
            pipesSizeListGridView_ValidateRow(pipesSizeListGridView, eArg);

            if (sizeType != null)
            {
                viewModel.UpdatePipeTests(sizeType);
            }

            CurrentPipeMillSizeType = sizeType as PipeMillSizeType;
            viewModel.CurrentPipeMillSizeType = CurrentPipeMillSizeType;
            viewModel.ModifiableView.UpdateState();
            // IsModified state depends on previous state despite all properties were changed (prevent *)
            IsModified = (wasModified) ? true : false;
        }

        private void pipesSizeListGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();

            pipesSizeListGridView.ValidateNotEmpty(pipeSizeGridColumn, e);

            if (viewModel.CurrentProjectSettings != null && viewModel.IsMill)
            {
                DuplicatesList l = findDuplicateList[pipesSizeListGridView];
                List<string> pipeSizesDuplicates = l.Method(pipesSizeListGridView);
                pipesSizeListGridView.ValidateDuplicate(pipeSizeGridColumn, pipeSizesDuplicates, e);
            }

            pipesSizeValidate = e.Valid;
        }

        private void pipesSizeListGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (viewModel.CurrentProjectSettings != null && viewModel.IsMill)
            {
                DuplicatesList l = findDuplicateList[pipesSizeListGridView];
                List<string> pipeSizesDuplicates = l.Method(pipesSizeListGridView);
                pipesSizeListGridView.ColorGrid(pipeSizeGridColumn, pipeSizesDuplicates, e);
            }
        }

        private void cloneTypeSizeButton_Click(object sender, EventArgs e)
        {
            if (CurrentPipeMillSizeType != null &&
                IsEditMode)
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
            foreach (PipeTest t in CurrentPipeMillSizeType.PipeTests)
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
            CurrentPipeMillSizeType.IsNative = true;
            CurrentPipeMillSizeType.Project = viewModel.CurrentProjectSettings;
            CurrentPipeMillSizeType.SeamType = new SeamType() { IsNative = true, Project = viewModel.CurrentProjectSettings };

            if (CurrentPipeMillSizeType != null)
            {
                viewModel.UpdatePipeTests(CurrentPipeMillSizeType);
            }

            foreach (Prizm.Domain.Entity.Mill.Category c in viewModel.CategoryTypes)
            {
                if (c.Fixed && c.ResultType == "int")
                {
                    CurrentPipeMillSizeType.PipeTests.Add(new PipeTest { Category = c, ResultType = PipeTestResultType.Diapason, pipeType = CurrentPipeMillSizeType, IsRequired = true });
                }
            }
        }

        private void gridViewWelders_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();

            gridViewWelders.ValidatePersonName(colWelderFirstName, colWelderLastName, e);

            gridViewWelders.ValidateCertificate(colWelderCert, colWelderCertExp, e);

            weldersValidate = e.Valid;
        }

        private void gridViewInspectors_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();

            gridViewInspectors.ValidatePersonName(colInspectorFirstName, colInspectorLastName, e);

            inspectorsValidate = e.Valid;
        }

        private void HandleInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void inspectorCertificateGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();

            inspectorCertificateGridView.ValidateCertificate(inspectorCertificateNumberCol, inspectorCertificateExpirationCol, e);

            inspectorsCertificateValidate = e.Valid;
        }

        void ValidateCertificate(GridView view, GridColumn certNameColumn, GridColumn expDateColumn, ValidateRowEventArgs e)
        {
            string certName = (string)view.GetRowCellValue(e.RowHandle, certNameColumn);
            DateTime? certExpDate = (DateTime?)view.GetRowCellValue(e.RowHandle, expDateColumn);

            view.ClearColumnErrors();

            if (string.IsNullOrWhiteSpace(certName))
            {
                view.SetColumnError(certNameColumn, Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
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
                view.SetColumnError(firstNameColumn,
                    Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
                e.Valid = false;
            }

            if (String.IsNullOrEmpty(lastName))
            {
                view.SetColumnError(lastNameColumn,
                   Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
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
            if (insp != null)
            {
                view.RemoveSelectedItem<InspectorCertificate>(e, insp.Certificates, (_) => _.IsNew());
            }
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
            var inspc = gridViewInspectors.GetFocusedRow() as InspectorViewType;
            var view = sender as GridView; //cert Grid
            if (inspc != null)
            {
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
            else
            {

                inspectorCertificateGridView.SetColumnError(inspectorCertificateGridView.Columns[0],
                    Program.LanguageManager.GetString(StringResources.Settings_ValidateInspectorSertificate));

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

            if (view.IsValidRowHandle(e.RowHandle))
            {
                Role role = view.GetRow(e.RowHandle) as Role;

            }
        }

        private void gridViewRole_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var view = sender as GridView;
            view.ClearColumnErrors();

            gridViewRole.ValidateNotEmpty(colRoleSetupName, e);

            roleValidate = e.Valid;
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
                        if (viewModel.RoleHasPermission(role, perm)
                            && Prizm.Main.Security.SecurityContext.PrivilegeBelongsToCurrentWorkstation(perm))
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

        private bool handleGridViewPermissionsSelectionChanged = true;
        private void gridViewPermissions_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var view = sender as GridView;
            var role = gridViewRole.GetFocusedRow() as Role;

            if (role == null)
                return;

            Permission p = view.GetRow(e.ControllerRow) as Permission;
            if (!view.IsFocusedView || IsEditMode)
            {
                switch (e.Action)
                {
                    case CollectionChangeAction.Add:
                        if (!Prizm.Main.Security.SecurityContext.PrivilegeBelongsToCurrentWorkstation(p))
                        {
                            view.UnselectRow(e.ControllerRow);
                        }
                        else
                        {
                            viewModel.AddPermissionToRole(role, p);
                        }
                        break;
                    case CollectionChangeAction.Remove:
                        viewModel.RemovePermissionFromRole(role, p);
                        break;
                }
            }
            else if (handleGridViewPermissionsSelectionChanged)
            {
                handleGridViewPermissionsSelectionChanged = false;
                switch (e.Action)
                {
                    case CollectionChangeAction.Add:
                        view.UnselectRow(e.ControllerRow);
                        break;
                    case CollectionChangeAction.Remove:
                        view.SelectRow(e.ControllerRow);
                        break;
                }
            }

            handleGridViewPermissionsSelectionChanged = true;
        }

        private void gridViewUsers_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();
            gridViewUsers.ValidatePersonName(colFirstName, colLastName, e);

            if (view.IsValidRowHandle(e.RowHandle))
            {
                User user = view.GetRow(e.RowHandle) as User;
                if (String.IsNullOrWhiteSpace(user.Login))
                {
                    view.SetColumnError(colLogin,
                        Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
                    e.Valid = false;
                    return;
                }
                if (String.IsNullOrWhiteSpace(user.PasswordHash))
                {
                    view.SetColumnError(colUserPass,
                   Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
                    e.Valid = false;
                    return;
                }
            }

            DuplicatesList l = findDuplicateList[gridViewUsers];
            List<string> loginDuplicates = l.Method(gridViewUsers);
            gridViewUsers.ValidateDuplicate(colLogin, loginDuplicates, e);
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
                if (user != null)
                {
                    PasswordChangeDialog dlg = new PasswordChangeDialog();
                    if (dlg.ShowPasswordDialog(user.PasswordHash) == System.Windows.Forms.DialogResult.OK)
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

        private bool handleGridViewRolesSelectionChanged = true;
        private void gridViewRoles_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var view = sender as GridView;
            var user = gridViewUsers.GetRow(gridViewUsers.FocusedRowHandle) as User;

            if (user != null)
            {
                var role = view.GetRow(e.ControllerRow) as Role;
                if (role != null)
                {
                    if (!view.IsFocusedView || IsEditMode)
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
                    else if (handleGridViewRolesSelectionChanged)
                    {
                        handleGridViewRolesSelectionChanged = false;
                        switch (e.Action)
                        {
                            case CollectionChangeAction.Add:
                                view.UnselectRow(e.ControllerRow);
                                break;
                            case CollectionChangeAction.Remove:
                                view.SelectRow(e.ControllerRow);
                                break;
                        }
                    }

                    handleGridViewRolesSelectionChanged = true;
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

        private void repositoryItemsСategoryView_CustomRowFilter(object sender, RowFilterEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            var ct = view.DataSource as BindingList<Prizm.Domain.Entity.Mill.Category>;

            if (ct != null)
            {
                if (!(bool)ct[e.ListSourceRow].IsActive)
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
            if (data != null)
            {
                if ((e.Column.Name == colWelderCert.Name || e.Column.Name == colWelderCertExp.Name)
                    && data.CertificateExpiration.Date < DateTime.Now)
                {
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        private void inspectorCertificateGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            var inspc = gridViewInspectors.GetFocusedRow() as InspectorViewType;
            if (inspc != null)
            {
                GridView v = sender as GridView;
                var data = v.GetRow(e.RowHandle) as InspectorCertificate;
                if (data != null)
                {
                    if (data.Certificate.ExpirationDate < DateTime.Now)
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    }
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

            if (selectedUser > -1
                && selectedUser < viewModel.Users.Count)
            {
                if (view.FocusedColumn.FieldName == "IsActive" &&
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
            componentType.IsNative = true;
            componentType.Project = viewModel.CurrentProjectSettings;
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

            if (certp != null)
            {
                if (!(bool)certp[e.ListSourceRow].IsActive)
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
            if (data != null)
            {
                foreach (InspectorCertificate c in data.Certificates)
                {
                    if (c.Certificate.ExpirationDate < DateTime.Now)
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
            seemType.IsNative = true;
            seemType.Project = viewModel.CurrentProjectSettings;
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
            foreach (SeamType t in viewModel.SeamTypes)
            {
                if (t.IsActive)
                {
                    seamType.Properties.Items.Add(t);
                }
            }
        }

        private void inspectionView_BeforeLeaveRow(object sender, RowAllowEventArgs e)
        {
            GridView v = sender as GridView;
            PipeTest pipeTest = v.GetRow(e.RowHandle) as PipeTest;
            if (CurrentPipeMillSizeType != null)
            {
                foreach (PipeTest t in CurrentPipeMillSizeType.PipeTests)
                {
                    t.pipeType = CurrentPipeMillSizeType;
                }
            }
        }

        bool IValidatable.Validate()
        {
            bool administratorCanEditSettingsValidation =
                    AdministatorCanEditSettingsValidation();
            // gridValidation
            plateManufacturersValidate = plateManufacturersValidation(); 
            categoriesValidate = categoriesValidation();
            seamTypesValidate = seamTypeValidation();
            pipesSizeValidate = pipesSizeValidation();
            controlOerationValidate = pipeControlOperationValidation();
            jointsOperationsValidate = jointsOperationValidation();
            componentryTypeValidate = componentryTypeValidation();
            weldersValidate = weldersValidation();
            inspectorsValidate = inspectorsValidation();
            inspectorsCertificateValidate = certificateValidation();
            inspectorsCertificateTypeValidate = certificateTypeValidation();
            usersValidate = userValidation();
            roleValidate = roleValidation();

            // TODO: pipeLayoutControlGroup.Tag always has value  because method pipeLayoutControlGroup_Shown is always call
            if (pipeLayoutControlGroup.Tag != null)
            {
                controlOerationValidate = pipeControlOperationValidation();
            }

            return dxValidationProvider.Validate() && controlOerationValidate && pipesSizeValidate
                && administratorCanEditSettingsValidation
                && plateManufacturersValidate && seamTypesValidate && categoriesValidate
                && jointsOperationsValidate
                && componentryTypeValidate
                && inspectorsValidate && inspectorsCertificateTypeValidate && inspectorsCertificateValidate 
                && weldersValidate
                && usersValidate && roleValidate;
        }

        private bool pipeControlOperationValidation()
        {
            controlOerationValidate = true;
            for (int i = 0; i < inspectionView.RowCount - 1; i++)
            {
                if (Convert.ToString(inspectionView.GetRowCellValue(i, inspectionCodeGridColumn.Name)) == string.Empty ||
                    Convert.ToString(inspectionView.GetRowCellValue(i, inspectionNameGridColumn.Name)) == string.Empty ||
                    Convert.ToString(inspectionView.GetRowCellValue(i, categoryColumn.Name)) == null)
                {
                    inspectionView.FocusedRowHandle = i;

                    inspectionView_ValidateRow(
                        inspectionView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, inspectionView.GetDataRow(i)));
                    if (!controlOerationValidate)
                    {
                        controlOerationValidate = false;
                        break;
                    }
                }
            }
            return controlOerationValidate;
        }

        /// <summary>
        /// Checks whether user that was created
        /// in initial settings has edit settings permission
        /// or not
        /// </summary>
        private bool AdministatorCanEditSettingsValidation()
        {
            bool administatorCanEditSettings = true;
            for (int userRowHandle = 0; userRowHandle < gridViewUsers.RowCount; userRowHandle++)
            {
                var user = gridViewUsers.GetRow(userRowHandle) as User;

                if (user != null &&
                    user.Undeletable == true)
                {
                    administatorCanEditSettings = user.Roles
                        .Any(x => x.Permissions
                            .Any(y => (Privileges)Enum.Parse(typeof(Privileges), y.Name) == Privileges.EditSettings));

                    if (administatorCanEditSettings)
                        break;
                }
            }
            return administatorCanEditSettings;
        }

        private void inspectionView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView gv = sender as GridView;
            gv.ClearColumnErrors();
            PipeTest pipeTest = gv.GetRow(e.RowHandle) as PipeTest;
            if (pipeTest.Code == null || pipeTest.Name == null || pipeTest.Category == null)
            {
                controlOerationValidate = false;
                e.Valid = false;

                if (pipeTest.Code == null)
                {
                    gv.SetColumnError(inspectionCodeGridColumn,
                    Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
                }
                else if (pipeTest.Name == null)
                {
                    gv.SetColumnError(inspectionNameGridColumn,
                        Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
                }
                else if (pipeTest.Category == null)
                {
                    gv.SetColumnError(categoryColumn,
                        Program.LanguageManager.GetString(StringResources.Settings_ValueRequired));
                }
            }

            else
            {
                controlOerationValidate = true;
            }

        }

        private bool IsEditable(bool editMode)
        {
            return (CurrentPipeMillSizeType != null && editMode);
        }

        private bool IsEditableCrtificate(bool editMode)
        {
            var inspc = gridViewInspectors.GetFocusedRow() as InspectorViewType;
            return (inspc != null && editMode);
        }

        private bool IsEditableRole(bool editMode)
        {
            var user = gridViewUsers.GetFocusedRow() as User;
            return (user != null && editMode);
        }

        private void projectLayoutControlGroup_Shown(object sender, EventArgs e)
        {
            #region project title validation only afrer project tab is shown
            ConditionValidationRule projectTitleValidationRule = new ConditionValidationRule();
            projectTitleValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            projectTitleValidationRule.ErrorText = Program.LanguageManager.GetString(StringResources.Settings_ValueRequired);
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
            diameterValidationRule.ErrorText = Program.LanguageManager.GetString(StringResources.Settings_ValueRequired);
            diameterValidationRule.ErrorType = ErrorType.Critical;

            ConditionValidationRule wallThicknessValidationRule = new ConditionValidationRule();
            wallThicknessValidationRule.ConditionOperator = ConditionOperator.Greater;
            wallThicknessValidationRule.Value1 = 0;
            wallThicknessValidationRule.ErrorText = Program.LanguageManager.GetString(StringResources.Settings_ValueRequired);
            wallThicknessValidationRule.ErrorType = ErrorType.Critical;

            ConditionValidationRule pipeLengthValidationRule = new ConditionValidationRule();
            pipeLengthValidationRule.ConditionOperator = ConditionOperator.Greater;
            pipeLengthValidationRule.Value1 = 0;
            pipeLengthValidationRule.ErrorText = Program.LanguageManager.GetString(StringResources.Settings_ValueRequired);
            pipeLengthValidationRule.ErrorType = ErrorType.Critical;

            ConditionValidationRule seamTypeValidationRule = new ConditionValidationRule();
            seamTypeValidationRule.ConditionOperator = ConditionOperator.NotEquals;
            seamTypeValidationRule.Value1 = seamType.Properties.NullText;
            seamTypeValidationRule.ErrorText = Program.LanguageManager.GetString(StringResources.Settings_ValueRequired);
            seamTypeValidationRule.ErrorType = ErrorType.Critical;

            dxValidationProvider.SetValidationRule(pipeDiameter, diameterValidationRule);
            dxValidationProvider.SetValidationRule(wallThickness, wallThicknessValidationRule);
            dxValidationProvider.SetValidationRule(pipeLength, pipeLengthValidationRule);
            dxValidationProvider.SetValidationRule(seamType, seamTypeValidationRule);
            #endregion
            if (viewModel.SeamTypes != null)
            {
                UpdateSeamTypesComboBox();
            }
            // TODO: pipeLayoutControlGroup.Tag always has value  because method pipeLayoutControlGroup_Shown is always call
            findDuplicateList = new Dictionary<GridView, DuplicatesList>();
            CreateDuplicateList();
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

        private void CreateDuplicateList()
        {
            DuplicatesList pipeSize = new DuplicatesList();
            pipeSize.Duplicates = null;
            pipeSize.Method = delegate(GridView pipesSizeListGridView)
            {
                var pipeSizes = viewModel.PipeMillSizeType;
                return pipeSizes.GroupBy(x => x.Type)
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Key)
                                 .ToList();
            };

            DuplicatesList plateManufacturer = new DuplicatesList();
            plateManufacturer.Duplicates = null;
            plateManufacturer.Method = delegate(GridView plateManufacturersListView)
            {
                var plateManufacturers = viewModel.PlateManufacturers;
                return plateManufacturers.GroupBy(x => x.Name)
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Key)
                                 .ToList();
            };

            DuplicatesList category = new DuplicatesList();
            category.Duplicates = null;
            category.Method = delegate(GridView categoriesGridView)
            {
                var categories = viewModel.CategoryTypes;
                return categories.GroupBy(x => x.Name)
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Key)
                                 .ToList();
            };

            DuplicatesList componentType = new DuplicatesList();
            componentType.Duplicates = null;
            componentType.Method = delegate(GridView componentryTypeGridView)
            {
                var componentTypes = viewModel.ComponentryTypes;
                return componentTypes.GroupBy(x => x.Name)
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Key)
                                 .ToList();
            };

            DuplicatesList seamType = new DuplicatesList();
            seamType.Duplicates = null;
            seamType.Method = delegate(GridView seemTypeGridView)
            {
                var seamTypes = viewModel.SeamTypes;
                return seamTypes.GroupBy(x => x.Name)
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Key)
                                 .ToList();
            };

            DuplicatesList login = new DuplicatesList();
            login.Duplicates = null;
            login.Method = delegate(GridView gridViewUsers)
            {
                var logins = viewModel.Users;
                return logins.GroupBy(x => x.Login)
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Key)
                                 .ToList();
            };

            DuplicatesList certificateType = new DuplicatesList();
            certificateType.Duplicates = null;
            certificateType.Method = delegate(GridView certificateTypesView)
            {
                var certificates = viewModel.CertificateTypes;
                return certificates.GroupBy(x => x.Name)
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Key)
                                 .ToList();
            };

            findDuplicateList.Add(this.pipesSizeListGridView, pipeSize);
            findDuplicateList.Add(this.plateManufacturersListView, plateManufacturer);
            findDuplicateList.Add(this.categoriesGridView, category);
            findDuplicateList.Add(this.componentryTypeGridView, componentType);
            findDuplicateList.Add(this.seamTypeGridView, seamType);
            findDuplicateList.Add(this.gridViewUsers, login);
            findDuplicateList.Add(this.certificateTypesView, certificateType);

        }

        private MillInspectionXtraForm GetInspectionForm(PipeTest selectedTest,
                 BindingList<Prizm.Domain.Entity.Mill.Category> categoryTypes)
        {
            if (inspectionForm == null)
            {
                inspectionForm = new MillInspectionXtraForm(selectedTest, categoryTypes, viewModel.PipeTests);
            }
            else
            {
                inspectionForm.SetupForm(selectedTest, categoryTypes, viewModel.PipeTests);
            }

            return inspectionForm;
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            if (IsEditMode && IsEditable(IsEditMode))
            {
                var inspectionForm = GetInspectionForm(null, viewModel.CategoryTypes);
                inspectionForm.viewModel.PipeTest.pipeType = viewModel.CurrentPipeMillSizeType;

                if (inspectionForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    viewModel.CurrentPipeMillSizeType.PipeTests.Add(inspectionForm.viewModel.PipeTest);
                    viewModel.PipeTests.Add(inspectionForm.viewModel.PipeTest);
                    IsModified = true;
                    inspectionOperation.RefreshDataSource();
                }

            }
        }

        private void editTestButton_Click(object sender, EventArgs e)
        {
            if (inspectionView.IsValidRowHandle(inspectionView.FocusedRowHandle) && IsEditMode)
            {
                var selectedTest = inspectionView.GetRow(inspectionView.FocusedRowHandle) as PipeTest;
                if (selectedTest != null)
                {
                    var inspectionForm = GetInspectionForm(selectedTest, viewModel.CategoryTypes);

                    if (inspectionForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        ((IList<PipeTest>)inspectionView.DataSource)[inspectionView.GetFocusedDataSourceRowIndex()]
                            .CustomShallowCopy(inspectionForm.viewModel.PipeTest);
                        
                        IsModified = true;
                        inspectionOperation.RefreshDataSource();
                    }
                    

                }
            }
        }

        private void inspectionOperation_DoubleClick(object sender, EventArgs e)
        {
            if (inspectionView.IsValidRowHandle(inspectionView.FocusedRowHandle) && IsEditMode)
            {
                var selectedTest = inspectionView.GetRow(inspectionView.FocusedRowHandle) as PipeTest;
                if (selectedTest != null)
                {
                    if (inspectionForm == null)
                    {

                        inspectionForm = new MillInspectionXtraForm(selectedTest, viewModel.CategoryTypes, viewModel.PipeTests);
                    }
                    else
                    {
                        inspectionForm.SetupForm(selectedTest, viewModel.CategoryTypes, viewModel.PipeTests);
                    }

                    if (inspectionForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        ((IList<PipeTest>)inspectionView.DataSource)[inspectionView.GetFocusedDataSourceRowIndex()]
                            .CustomShallowCopy(inspectionForm.viewModel.PipeTest);

                        IsModified = true;
                        inspectionOperation.RefreshDataSource();
                    }
                   
                }
            }
        }

        private void gridViewPermissions_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            var view = sender as GridView;

            Permission p = view.GetRow(e.RowHandle) as Permission;

            if (!Prizm.Main.Security.SecurityContext.PrivilegeBelongsToCurrentWorkstation(p))
            {
                e.Appearance.ForeColor = Color.Gray;
            }
        }

        private void plateManufacturersListView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();

            plateManufacturersListView.ValidateNotEmpty(plateManufacturerGridColumn, e);
            if (viewModel.CurrentProjectSettings != null && viewModel.IsMill)
            {
                DuplicatesList l = findDuplicateList[plateManufacturersListView];
                List<string> plateManufacturersDuplicates = l.Method(plateManufacturersListView);
                plateManufacturersListView.ValidateDuplicate(plateManufacturerGridColumn, plateManufacturersDuplicates, e);
            }

            plateManufacturersValidate = e.Valid;
        }

        private void categoriesGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();

            categoriesGridView.ValidateNotEmpty(categoryNameColumn, e);

            DuplicatesList l = findDuplicateList[categoriesGridView];
            List<string> categoriesDuplicates = l.Method(categoriesGridView);
            categoriesGridView.ValidateDuplicate(categoryNameColumn, categoriesDuplicates, e);

            categoriesValidate = e.Valid;
        }

        private void seamTypeGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();

            seamTypeGridView.ValidateNotEmpty(seamTypeColumn, e);

            if (viewModel.CurrentProjectSettings != null && viewModel.IsMill)
            {
                DuplicatesList l = findDuplicateList[seamTypeGridView];
                List<string> seemTypeDuplicates = l.Method(seamTypeGridView);
                seamTypeGridView.ValidateDuplicate(seamTypeColumn, seemTypeDuplicates, e);
            }

            seamTypesValidate = e.Valid;
        }

        private void componentryTypeGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();

            componentryTypeGridView.ValidateNotEmpty(typeColumn, e);

            if (viewModel.CurrentProjectSettings != null && viewModel.IsMill)
            {
                DuplicatesList l = findDuplicateList[componentryTypeGridView];
                List<string> componentryTypeDuplicates = l.Method(componentryTypeGridView);
                componentryTypeGridView.ValidateDuplicate(typeColumn, componentryTypeDuplicates, e);
            }

            componentryTypeValidate = e.Valid;
        }

        private void jointsOperationsGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();
            jointsOperationsGridView.ValidateNotEmpty(nameGridColumn, e);

            jointsOperationsValidate = e.Valid;
        }

        private void certificateTypesView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();

            certificateTypesView.ValidateNotEmpty(certificateNameColumn, e);

            DuplicatesList l = findDuplicateList[certificateTypesView];
            List<string> certificateDuplicate = l.Method(certificateTypesView);
            certificateTypesView.ValidateDuplicate(certificateNameColumn, certificateDuplicate, e);

            inspectorsCertificateTypeValidate = e.Valid;
        }

        private void inspectionView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == controlTypeGridColumn.Name && e.Value != null)
            {
                PipeTestControlType result;
                if (Enum.TryParse<PipeTestControlType>(e.Value.ToString(), out result))
                {
                    e.DisplayText = (result == PipeTestControlType.Undefined) ? "" : localizedPipeTestControlTypes[(int)result - 1]; //-1 because we skip 0
                }
            }
            if (e.Column.Name == resultTypeGridColumn.Name && e.Value != null)
            {
                PipeTestResultType result;
                if (Enum.TryParse<PipeTestResultType>(e.Value.ToString(), out result))
                {
                    e.DisplayText = (result == PipeTestResultType.Undefined) ? "" : localizedPipeTestResultTypes[(int)result - 1]; //-1 because we skip 0
                }
            }
        }

        private void jointOperationTypeLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                JointOperationType result;
                if (Enum.TryParse<JointOperationType>(e.Value.ToString(), out result))
                {
                    e.DisplayText = (result == JointOperationType.Undefined) ? "" : localizedJointOperationTypes[(int)result - 1];
                }
            }
        }

        private void jointOperationTypeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;
            if (lookup.ItemIndex != -1)
            {
                lookup.EditValue = (JointOperationType)lookup.ItemIndex + 1;
            }
        }

        private void plateManufacturersListView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void categoriesGridView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void seemTypeGridView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void pipesSizeListGridView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void componentryTypeGridView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void inspectorCertificateGridView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void componentryTypeGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (viewModel.CurrentProjectSettings != null && viewModel.IsMill)
            {
                DuplicatesList l = findDuplicateList[componentryTypeGridView];
                List<string> componentryDuplicate = l.Method(componentryTypeGridView);
                componentryTypeGridView.ColorGrid(typeColumn, componentryDuplicate, e);
            }
        }

        private void plateManufacturersListView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (viewModel.CurrentProjectSettings != null && viewModel.IsMill)
            {
                DuplicatesList l = findDuplicateList[plateManufacturersListView];
                List<string> plateManufacturersDuplicate = l.Method(plateManufacturersListView);
                plateManufacturersListView.ColorGrid(plateManufacturerGridColumn, plateManufacturersDuplicate, e);
            }
        }

        private void categoriesGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            DuplicatesList l = findDuplicateList[categoriesGridView];
            List<string> categoriesDuplicate = l.Method(categoriesGridView);
            categoriesGridView.ColorGrid(categoryNameColumn, categoriesDuplicate, e);
        }

        private void seemTypeGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (viewModel.CurrentProjectSettings != null && viewModel.IsMill)
            {
                DuplicatesList l = findDuplicateList[seamTypeGridView];
                List<string> seemTypeDuplicate = l.Method(seamTypeGridView);
                seamTypeGridView.ColorGrid(seamTypeColumn, seemTypeDuplicate, e);
            }
        }
        private void inspectorCertificateGridView_GotFocus(object sender, EventArgs e)
        {
            inspectorCertificateGridView.OptionsBehavior.Editable = IsEditableCrtificate(IsEditMode);
        }
        private void gridViewUsers_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewUsers.FocusedColumn.Name == colLogin.Name)
            {
                foreach (User user in viewModel.Users)
                {
                    if (user.Login == e.Value.ToString())
                    {
                        e.Valid = false;
                        e.ErrorText = Program.LanguageManager.GetString(StringResources.Settings_UniqueLogin);
                    }
                }
            }
        }

        private void gridViewRoles_GotFocus(object sender, EventArgs e)
        {
            gridViewRoles.OptionsBehavior.Editable = IsEditableRole(IsEditMode);
        }
        private bool plateManufacturersValidation()
        {
            plateManufacturersValidate = true;
            for (int i = 0; i < plateManufacturersListView.RowCount - 1; i++)
            {

                if (String.IsNullOrWhiteSpace(Convert.ToString(inspectionView.GetRowCellValue(i, plateManufacturerGridColumn.Name))))
                {
                    plateManufacturersListView.FocusedRowHandle = i;

                    plateManufacturersListView_ValidateRow(
                        inspectionView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, plateManufacturersListView.GetDataRow(i)));
                    if (!plateManufacturersValidate)
                    {
                        plateManufacturersValidate = false;
                        break;
                    }
                }
            }
            return plateManufacturersValidate;
        }

        private bool seamTypeValidation()
        {
            seamTypesValidate = true;
            for (int i = 0; i < seamTypeGridView.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(seamTypeGridView.GetRowCellValue(i, seamTypeColumn))))
                {
                    seamTypeGridView.FocusedRowHandle = i;

                    seamTypeGridView_ValidateRow(
                        seamTypeGridView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, seamTypeGridView.GetDataRow(i)));
                    if (!seamTypesValidate)
                    {
                        seamTypesValidate = false;
                        break;
                    }
                }
            }
            return seamTypesValidate;
        }

        private bool categoriesValidation()
        {
            categoriesValidate = true;
            for (int i = 0; i < categoriesGridView.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(categoriesGridView.GetRowCellValue(i, categoryNameColumn.Name))))
                {
                    categoriesGridView.FocusedRowHandle = i;

                    categoriesGridView_ValidateRow(
                        categoriesGridView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, categoriesGridView.GetDataRow(i)));
                    if (!categoriesValidate)
                    {
                        categoriesValidate = false;
                        break;
                    }
                }
            }
            return categoriesValidate;
        }

        private bool pipesSizeValidation()
        {
            pipesSizeValidate = true;
            for (int i = 0; i < pipesSizeListGridView.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(pipesSizeListGridView.GetRowCellValue(i, pipeSizeGridColumn.Name))))
                {
                    pipesSizeListGridView.FocusedRowHandle = i;

                    pipesSizeListGridView_ValidateRow(
                        pipesSizeListGridView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, pipesSizeListGridView.GetDataRow(i)));
                    if (!pipesSizeValidate)
                    {
                        pipesSizeValidate = false;
                        break;
                    }
                }
            }
            return pipesSizeValidate;
        }

        private bool componentryTypeValidation()
        {
            componentryTypeValidate = true;
            for (int i = 0; i < componentryTypeGridView.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(componentryTypeGridView.GetRowCellValue(i, typeColumn.Name))))
                {
                    componentryTypeGridView.FocusedRowHandle = i;

                    componentryTypeGridView_ValidateRow(
                        componentryTypeGridView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, componentryTypeGridView.GetDataRow(i)));
                    if (!componentryTypeValidate)
                    {
                        componentryTypeValidate = false;
                        break;
                    }
                }
            }
            return componentryTypeValidate;
        }

        private bool weldersValidation()
        {
            weldersValidate = true;
            for (int i = 0; i < gridViewWelders.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(gridViewWelders.GetRowCellValue(i, colWelderLastName.Name))) ||
                   String.IsNullOrWhiteSpace(Convert.ToString(gridViewWelders.GetRowCellValue(i, colWelderFirstName.Name))) ||
                  String.IsNullOrWhiteSpace(Convert.ToString(gridViewWelders.GetRowCellValue(i, colWelderCert.Name))))
                {
                    gridViewWelders.FocusedRowHandle = i;

                    gridViewWelders_ValidateRow(
                        gridViewWelders,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, gridViewWelders.GetDataRow(i)));
                    if (!weldersValidate)
                    {
                        weldersValidate = false;
                        break;
                    }
                }
            }
            return weldersValidate;
        }

        private bool inspectorsValidation()
        {
            inspectorsValidate = true;
            for (int i = 0; i < gridViewInspectors.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(gridViewInspectors.GetRowCellValue(i, colInspectorLastName.Name))) ||
                    String.IsNullOrWhiteSpace(Convert.ToString(gridViewInspectors.GetRowCellValue(i, colInspectorFirstName.Name))))
                {
                    gridViewInspectors.FocusedRowHandle = i;

                    gridViewInspectors_ValidateRow(
                        gridViewInspectors,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, gridViewInspectors.GetDataRow(i)));
                    if (!inspectorsValidate)
                    {
                        inspectorsValidate = false;
                        break;
                    }
                }
            }
            return inspectorsValidate;
        }

        private bool certificateTypeValidation()
        {
            inspectorsCertificateTypeValidate = true;
            for (int i = 0; i < certificateTypesView.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(certificateTypesView.GetRowCellValue(i, certificateNameColumn.Name))))//(Convert.ToString(certificateTypesView.GetRowCellValue(i, certificateNameColumn.Name)) == string.Empty)
                {
                    certificateTypesView.FocusedRowHandle = i;

                    certificateTypesView_ValidateRow(
                        certificateTypesView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, certificateTypesView.GetDataRow(i)));
                    if (!inspectorsCertificateTypeValidate)
                    {
                        inspectorsCertificateTypeValidate = false;
                        break;
                    }
                }
            }
            return inspectorsCertificateTypeValidate;
        }

        private bool certificateValidation()
        {
            inspectorsCertificateValidate = true;
            for (int i = 0; i < inspectorCertificateGridView.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(certificateTypesView.GetRowCellValue(i, inspectorCertificateNumberCol.Name)))
                    || String.IsNullOrWhiteSpace(Convert.ToString(certificateTypesView.GetRowCellValue(i, inspectorCertificateExpirationCol.Name))))
                {
                    inspectorCertificateGridView.FocusedRowHandle = i;

                    inspectorCertificateGridView_ValidateRow(
                        inspectorCertificateGridView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, certificateTypesView.GetDataRow(i)));
                    if (!inspectorsCertificateValidate)
                    {
                        inspectorsCertificateValidate = false;
                        break;
                    }
                }
            }
            return inspectorsCertificateValidate;
        }

        private bool roleValidation()
        {
            roleValidate = true;
            for (int i = 0; i < gridViewRole.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(gridViewRole.GetRowCellValue(i, colRoleSetupName.Name))))
                {
                    gridViewRole.FocusedRowHandle = i;

                    gridViewRole_ValidateRow(
                        gridViewRole,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, gridViewRole.GetDataRow(i)));
                    if (!roleValidate)
                    {
                        roleValidate = false;
                        break;
                    }
                }
            }
            return roleValidate;
        }
        private bool userValidation()
        {
            usersValidate = true;
            for (int i = 0; i < gridViewUsers.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(gridViewUsers.GetRowCellValue(i, colFirstName.Name)))
                    || String.IsNullOrWhiteSpace(Convert.ToString(gridViewUsers.GetRowCellValue(i, colLastName.Name)))
                    || String.IsNullOrWhiteSpace(Convert.ToString(gridViewUsers.GetRowCellValue(i, colLogin.Name))))
                {
                    gridViewRole.FocusedRowHandle = i;

                    gridViewUsers_ValidateRow(
                        gridViewUsers,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, gridViewUsers.GetDataRow(i)));
                    if (!usersValidate)
                    {
                        usersValidate = false;
                        break;
                    }
                }
            }
            return usersValidate;
        }

        private bool jointsOperationValidation()
        {
            jointsOperationsValidate = true;
            for (int i = 0; i < jointsOperationsGridView.RowCount - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(Convert.ToString(gridViewUsers.GetRowCellValue(i, nameGridColumn.Name))))
                {
                    jointsOperationsGridView.FocusedRowHandle = i;

                    jointsOperationsGridView_ValidateRow(
                        jointsOperationsGridView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, jointsOperationsGridView.GetDataRow(i)));
                    if (!jointsOperationsValidate)
                    {
                        jointsOperationsValidate = false;
                        break;
                    }
                }
            }
            return jointsOperationsValidate;
        }

        private void certificateTypesView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            DuplicatesList l = findDuplicateList[certificateTypesView];
            List<string> certificateTypeDuplicates = l.Method(certificateTypesView);
            certificateTypesView.ColorGrid(certificateNameColumn, certificateTypeDuplicates, e);
        }

        private void certificateTypesView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void plateManufacturersListView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView gv = sender as GridView;
            PlateManufacturer plateManufacturer
                = gv.GetRow(e.RowHandle) as PlateManufacturer;

            plateManufacturer.IsActive = true;
            plateManufacturer.IsNative = true;
            plateManufacturer.Project = viewModel.CurrentProjectSettings;
        }

        private void SetWorkstationReadonlyFields()
        {
            if (viewModel.IsMaster)
            {
                plateManufacturersListView.Columns["Project.MillName"].Visible = true;
                seamTypeGridView.Columns["Project.MillName"].Visible = true;
                pipesSizeListGridView.Columns["Project.MillName"].Visible = true;
                componentryTypeGridView.Columns["Project.MillName"].Visible = true;
                addTestButtonLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                editTestButtonLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cloneButtonLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                sizesLayoutControlItem.Width = 600;
                SetAlwaysReadOnly(plateManufacturersList);
                SetAlwaysReadOnly(millName);
                SetAlwaysReadOnly(pipeNumberMask);
                SetAlwaysReadOnly(categoriesGrid);
                SetAlwaysReadOnly(seamTypes);
                SetAlwaysReadOnly(pipesSizeList);
                SetAlwaysReadOnly(jointOperations);
                SetAlwaysReadOnly(componentryTypeGridControl);
                SetAlwaysReadOnly(gridControlWelders);
                SetAlwaysReadOnly(gridControlInspectors);
                SetAlwaysReadOnly(gridControlInspectorsCertificates);
                SetAlwaysReadOnly(certificateTypes);

            }
            if (viewModel.IsMill)
            {
                SetAlwaysReadOnly(jointOperations);
                SetAlwaysReadOnly(componentryTypeGridControl);
            }
            if (viewModel.IsConstruction)
            {
                plateManufacturersListView.Columns["Project.MillName"].Visible = true;
                seamTypeGridView.Columns["Project.MillName"].Visible = true;
                pipesSizeListGridView.Columns["Project.MillName"].Visible = true;
                addTestButtonLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                editTestButtonLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cloneButtonLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                SetAlwaysReadOnly(plateManufacturersList);
                SetAlwaysReadOnly(millName);
                SetAlwaysReadOnly(pipeNumberMask);
                SetAlwaysReadOnly(categoriesGrid);
                SetAlwaysReadOnly(seamTypes);
                SetAlwaysReadOnly(pipesSizeList);
            }
        }
    }
}