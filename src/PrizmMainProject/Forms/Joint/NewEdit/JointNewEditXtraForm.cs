using System.ComponentModel;
using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Common;
using System;
using Ninject;
using Ninject.Parameters;
using DevExpress.XtraEditors.Controls;
using Prizm.Main.Properties;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Controls;
using System.Windows.Forms;
using System.Collections.Generic;
using Prizm.Domain.Entity;
using Prizm.Main.Common;
using System.Data;
using Prizm.Main.Commands;
using System.Reflection;
using System.Resources;
using System.Collections;
using System.Threading;
using System.Linq;
using Prizm.Main.Documents;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Security;
using DevExpress.XtraGrid.Views.Base;
using Prizm.Main.Languages;
using System.Drawing;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class JointNewEditXtraForm : ChildForm, IValidatable, INewEditEntityForm
    {
        private Guid id;
        private JointNewEditViewModel viewModel;
        private JointTestResult currentJointTestResult;
        private JointWeldResult currentJointWeldResult;
        InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();
        WeldersSelectionControl weldersSelectionControl = new WeldersSelectionControl();
        BindingList<EnumWrapper<JointTestResultStatus>> availableResults = new BindingList<EnumWrapper<JointTestResultStatus>>();
        ICommandManager commandManager = new CommandManager();
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();
        private ExternalFilesXtraForm filesForm = null;
        public bool IsMatchedByGuid(Guid id) { return this.id == id; }
        private List<string> localizedAllJointStatus = new List<string>();
        private void UpdateTextEdit()
        {
            jointNewEditBindingSoure.CancelEdit();
        }

        public JointNewEditXtraForm(Guid id)
        {
            this.id = id;

            InitializeComponent();

            Bitmap bmp = Resources.joint_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            SetControlsTextLength();
            viewModel = (JointNewEditViewModel)Program
               .Kernel
               .Get<JointNewEditViewModel>(
               new ConstructorArgument("id", id));
            viewModel.ModifiableView = this;
            viewModel.ValidatableView = this;
            loweringDate.Properties.NullText = String.Empty;
            loweringDate.Properties.NullDate = DateTime.MinValue;

            #region --- Colouring of required controls, IsEditMode, uppercasing ---
            jointNumber.SetRequiredText();
            SetAlwaysReadOnly(jointStatus);
            firstJointElement.SetRequiredText();
            secondJointElement.SetRequiredText();
            IsEditMode = ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditJoint);
            jointNumber.SetAsIdentifier();
            firstJointElement.SetAsIdentifier();
            secondJointElement.SetAsIdentifier();
            attachmentsButton.Enabled = true;
            #endregion
        }

        public JointNewEditXtraForm() : this(Guid.Empty) { }

        private void extraFiles_Click(object sender, System.EventArgs e)
        {
            if(filesForm == null)
            {
                filesForm = new ExternalFilesXtraForm();
                viewModel.FilesFormViewModel = filesForm.ViewModel;
                viewModel.FilesFormViewModel.RefreshFiles(viewModel.Joint.Id);
            }
            filesForm.SetData(IsEditMode);
            filesForm.ShowDialog();
        }

        private void BindToViewModel()
        {
            jointNewEditBindingSoure.DataSource = viewModel;

            jointNumber.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "Number");

            deactivated.DataBindings
                .Add(BindingHelper.CreateCheckEditInverseBinding(
                        "Checked", jointNewEditBindingSoure, "JointIsActive"));

            loweringDate.DataBindings
               .Add("EditValue", jointNewEditBindingSoure, "LoweringDate");
            GPSLat.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "GpsLatitude");
            GPSLong.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "GpsLongitude");
            seaLevel.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "GpsHeight");
            PKNumber.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "NumberKP");
            distanceFromPK.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "DistanceFromKP");
            controlOperations.DataBindings
               .Add("DataSource", jointNewEditBindingSoure, "JointTestResults");
            repairOperations.DataBindings
               .Add("DataSource", jointNewEditBindingSoure, "JointWeldResults");

            Binding bind = new Binding("EditValue", jointNewEditBindingSoure, "JointConstructionStatus");
            bind.FormattingEnabled = true;
            bind.Format += (sender, e) => { e.Value = (string)localizedAllJointStatus[(int)e.Value]; };
            jointStatus.DataBindings.Add(bind);



            pipelinePiecesBindingSource.DataSource = viewModel.PartDataList;

            SetLookup(firstJointElement);
            SetLookup(secondJointElement);

            firstJointElement.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "FirstElementId");
            secondJointElement.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "SecondElementId");



            ControlOperationLookUpEdit.DataSource = viewModel.ControlOperations;
            repairOperationsLookUpEdit.DataSource = viewModel.RepairOperations;

            inspectorsDataSource.DataSource = viewModel.Inspectors;
            inspectorsDataSource.ListChanged += (s, eve) => IsModified = true;
            inspectorSelectionControl.DataSource = inspectorsDataSource;
            var inspectorsPopup = new PopupContainerControl();
            inspectorsPopup.Controls.Add(inspectorSelectionControl);
            inspectorSelectionControl.Dock = DockStyle.Fill;
            inspectorsPopupContainerEdit.PopupControl = inspectorsPopup;
            inspectorsPopupContainerEdit.PopupControl.MaximumSize = inspectorsPopup.MaximumSize;

            weldersDataSource.DataSource = viewModel.Welders;
            weldersDataSource.ListChanged += (s, eve) => IsModified = true;
            weldersSelectionControl.DataSource = weldersDataSource;
            var weldersPopup = new PopupContainerControl();
            weldersPopup.Controls.Add(weldersSelectionControl);
            weldersSelectionControl.Dock = DockStyle.Fill;
            weldersPopupContainerEdit.PopupControl = weldersPopup;
            weldersPopupContainerEdit.PopupControl.MaximumSize = weldersPopup.MaximumSize;

        }

        /// <summary>
        /// Grid columns lookup setup
        /// </summary>
        private void SetLookup(LookUpEdit lookup)
        {
            lookup.Properties.DataSource = pipelinePiecesBindingSource;
            lookup.Properties.ValueMember = "Id";
            lookup.Properties.DisplayMember = "Number";
        }

        private void BindCommands()
        {
            commandManager["Save"].Executor(viewModel.SaveJointCommand).AttachTo(saveButton);
            commandManager["SaveAndNew"].Executor(viewModel.NewSaveJointCommand).AttachTo(saveAndCreateButton);
            commandManager["Deactivate"].Executor(viewModel.JointDeactivationCommand).AttachTo(deactivated);

            SaveCommand = viewModel.SaveJointCommand;

            viewModel.SaveJointCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.NewSaveJointCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.JointDeactivationCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;

            commandManager.RefreshVisualState();
        }

        private void JointNewEditXtraForm_Load(object sender, EventArgs e)
        {
            foreach(var item in EnumWrapper<JointStatus>.EnumerateItems())
            {
                localizedAllJointStatus.Add(item.Item2);
            }
            BindCommands();
            BindToViewModel();
            viewModel.PropertyChanged += (s, eve) => IsModified = true;
            IsEditMode = viewModel.JointIsActive;
            IsModified = false;

            if(viewModel.Joint.Status == JointStatus.Withdrawn)
            {
                DisableControlUnderWithdrawn();
            }

            loweringDate.SetLimits();
            repairDateEdit.SetLimits();
            operationDateEdit.SetLimits();
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(jointNumberLayout, StringResources.JointNew_JointNumberLayout.Id),
                new LocalizedItem(jointStatusLayout, StringResources.JointNew_JointStatusLayout.Id),
                new LocalizedItem(firstJointElementLayout, StringResources.JointNew_FirstJointElementLayout.Id),
                new LocalizedItem(secondJointElementLayout, StringResources.JointNew_SecondJointElementLayout.Id),
                new LocalizedItem(jointParametersLayoutGroup, StringResources.JointNew_JointParametersLayoutGroup.Id),
                
                new LocalizedItem(loweringLayoutGroup, StringResources.JointNew_LoweringLayoutGroup.Id),
                new LocalizedItem(loweringDateLayout, StringResources.JointNew_LoweringDateLayout.Id),
                new LocalizedItem(PKLabelLayout, StringResources.JointNew_PKLabelLayout.Id),
                new LocalizedItem(PKNumberLayout, StringResources.JointNew_PKNumberLayout.Id),
                new LocalizedItem(distanceFromPKLayout, StringResources.JointNew_DistanceFromPKLayout.Id),
                new LocalizedItem(GPSLabelLayout, StringResources.JointNew_GPSLabelLayout.Id),
                new LocalizedItem(GPSLatLayout, StringResources.JointNew_GPSLatLayout.Id),
                new LocalizedItem(GPSLongLayout, StringResources.JointNew_GPSLongLayout.Id),
                new LocalizedItem(elevationLayout, StringResources.JointNew_ElevationLayout.Id),      
         
                new LocalizedItem(inspectionLayoutGroup, StringResources.JointNew_InspectionLayoutGroup.Id),
                new LocalizedItem(repairOperationLayout, StringResources.JointNew_RepairOperationLayout.Id),    
                new LocalizedItem(controlOperationsLayout, StringResources.JointNew_ControlOperationsLayout.Id),

                new LocalizedItem(saveButton, StringResources.JointNew_SaveButton.Id),    
                new LocalizedItem(saveAndCreateButton, StringResources.JointNew_SaveAndCreateButton.Id), 
                new LocalizedItem(attachmentsButton, StringResources.JointNew_ExtraFiles.Id),
                new LocalizedItem(deactivated, StringResources.JointNew_Deactivated.Id),
                
                new LocalizedItem(repairTypeGridColumn, StringResources.JointNew_RepairTypeGridColumn.Id),
                new LocalizedItem(repairDateGridColumn, StringResources.JointNew_RepairDateGridColumn.Id),
                new LocalizedItem(completedGridColumn, StringResources.JointNew_CompletedGridColumn.Id),
                new LocalizedItem(weldersGridColumn, StringResources.JointNew_WeldersGridColumn.Id),

                new LocalizedItem(controlTypeGridColumn, StringResources.JointNew_ControlTypeGridColumn.Id),
                new LocalizedItem(resultGridColumn, StringResources.JointNew_ResultGridColumn.Id),
                new LocalizedItem(controlDateGridColumn, StringResources.JointNew_ControlDateGridColumn.Id),
                new LocalizedItem(inspectorsGridColumn, StringResources.JointNew_InspectorsGridColumn.Id),
                new LocalizedItem(valueGridColumn, StringResources.JointNew_ValueGridColumn.Id),

                new LocalizedItem(UpdateTextEdit, localizedAllJointStatus,
                        new string [] { StringResources.JointNewEdit_JointStatus_Undefined.Id,
                            StringResources.JointSearch_JointStatus_Welded.Id, 
                            StringResources.JointSearch_JointStatus_Lowered.Id, 
                            StringResources.JointSearch_JointStatus_Withdrawn.Id} ),

                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.JointNewXtraForm_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void jointNumber_EditValueChanged(object sender, EventArgs e)
        {
            this.headerNumberPart = jointNumber.Text;
            viewModel.Number = jointNumber.Text;
            commandManager["Save"].RefreshState();
            commandManager["SaveAndNew"].RefreshState();
        }

        private void controlOperationsView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if(view.IsValidRowHandle(e.RowHandle))
            {
                currentJointTestResult = view.GetRow(e.RowHandle) as JointTestResult;
                currentJointTestResult.IsActive = true;
                currentJointTestResult.Joint = viewModel.Joint;
                viewModel.Joint.JointTestResults.Add(currentJointTestResult);
            }
        }

        private void ControlOperationLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit q = sender as LookUpEdit;
            object row = q.Properties.GetDataSourceRowByKeyValue(q.EditValue);
            JointOperation selectedOperation = q.Properties.GetDataSourceRowByKeyValue(q.EditValue) as JointOperation;
            if(selectedOperation != null)
                currentJointTestResult.Operation = selectedOperation;

        }

        private void inspectorsPopupContainerEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            if(controlOperationsView.IsValidRowHandle(controlOperationsView.FocusedRowHandle))
            {
                IList<Inspector> selectedInspectors = inspectorSelectionControl.SelectedInspectors;
                JointTestResult jointTestResult = controlOperationsView.GetRow(controlOperationsView.FocusedRowHandle) as JointTestResult;
                if(jointTestResult != null)
                {
                    jointTestResult.Inspectors.Clear();
                    foreach(Inspector i in selectedInspectors)
                    {
                        jointTestResult.Inspectors.Add(i);
                    }
                }
            }
        }

        private void inspectorsPopupContainerEdit_Popup(object sender, EventArgs e)
        {
            controlOperationsView.ClearSelection();
            if(controlOperationsView.IsValidRowHandle(controlOperationsView.FocusedRowHandle))
            {
                JointTestResult jointTestResult = controlOperationsView.GetRow(controlOperationsView.FocusedRowHandle) as JointTestResult;
                if(jointTestResult != null)
                {
                    inspectorSelectionControl.SelectInspectors(jointTestResult.Inspectors);
                }
            }
        }

        private void inspectorsPopupContainerEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
                e.DisplayText = string.Empty;

            IList<Inspector> inspectors = e.Value as IList<Inspector>;
            e.DisplayText = viewModel.FormatInspectorList(inspectors);
        }

        private void resultStatusLookUpEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
            {
                e.DisplayText = string.Empty;
            }
            if(controlOperationsView.IsValidRowHandle(controlOperationsView.FocusedRowHandle))
            {
                JointTestResult jointTestResult = controlOperationsView.GetRow(controlOperationsView.FocusedRowHandle) as JointTestResult;
                if(jointTestResult != null && jointTestResult.Operation != null)
                {
                    availableResults.Clear();

                    if(jointTestResult.Operation.TestHasAccepted)
                        availableResults.Add(new EnumWrapper<JointTestResultStatus>(JointTestResultStatus.Accepted));

                    if(jointTestResult.Operation.TestHasToRepair)
                        availableResults.Add(new EnumWrapper<JointTestResultStatus>(JointTestResultStatus.Repair));

                    if(jointTestResult.Operation.TestHasToWithdraw)
                        availableResults.Add(new EnumWrapper<JointTestResultStatus>(JointTestResultStatus.Withdraw));

                    resultStatusLookUpEdit.DataSource = availableResults;
                }
            }
        }

        private void repairOperationsView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if(view.IsValidRowHandle(e.RowHandle))
            {
                currentJointWeldResult = view.GetRow(e.RowHandle) as JointWeldResult;
                currentJointWeldResult.IsActive = true;
                currentJointWeldResult.Joint = viewModel.Joint;
                viewModel.Joint.JointWeldResults.Add(currentJointWeldResult);
            }
        }

        /// <summary>
        /// Assigns to current ActionWeldResult selected operation. If operation is not Weld,  ActionWeldResult is created with empty Welders list
        /// </summary>
        private void RepairOperationsLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit q = sender as LookUpEdit;
            object row = q.Properties.GetDataSourceRowByKeyValue(q.EditValue);
            JointOperation selectedOperationWeld = q.Properties.GetDataSourceRowByKeyValue(q.EditValue) as JointOperation;
            if(selectedOperationWeld != null)
            {
                currentJointWeldResult.Operation = selectedOperationWeld;
                if(selectedOperationWeld.Type != JointOperationType.Weld)
                {
                    currentJointWeldResult.Welders = new BindingList<Welder>();
                }
            }
        }

        private void weldersPopupContainerEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            if(repairOperationsView.IsValidRowHandle(repairOperationsView.FocusedRowHandle))
            {
                IList<Welder> selectedWelders = weldersSelectionControl.SelectedWelders;
                JointWeldResult jointWeldResult = repairOperationsView.GetRow(repairOperationsView.FocusedRowHandle) as JointWeldResult;

                if(jointWeldResult != null)
                {
                    jointWeldResult.Welders.Clear();
                    foreach(Welder w in selectedWelders)
                    {
                        jointWeldResult.Welders.Add(w);
                    }
                }
            }
        }

        private void weldersPopupContainerEdit_Popup(object sender, EventArgs e)
        {
            repairOperationsView.ClearSelection();

            if(repairOperationsView.IsValidRowHandle(repairOperationsView.FocusedRowHandle))
            {
                JointWeldResult jointWeldResult = repairOperationsView.GetRow(repairOperationsView.FocusedRowHandle) as JointWeldResult;
                if(jointWeldResult != null)
                {
                    weldersSelectionControl.SelectWelders(jointWeldResult.Welders);
                }
            }
        }

        private void weldersPopupContainerEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
                e.DisplayText = string.Empty;

            IList<Welder> welders = e.Value as IList<Welder>;
            e.DisplayText = viewModel.FormatWelderList(welders);
        }

        /// <summary>
        /// Disables the ability to edit welders list when not Welding operation is selected
        /// </summary>
        private void repairOperationsView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            JointOperation selectedOperation = repairOperationsLookUpEdit.GetDataSourceRowByDisplayValue(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Operation.Name"])) as JointOperation;
            if(selectedOperation != null
                && selectedOperation.Type != JointOperationType.Weld
                && selectedOperation.Type != JointOperationType.Withdraw
                && view.FocusedColumn.Name == weldersGridColumn.Name)
            {
                e.Cancel = true;
            }
        }

        private void SetControlsTextLength()
        {
            jointNumber.Properties.MaxLength = LengthLimit.MaxJointNumber;
            ResultValueTextEdit.MaxLength = LengthLimit.MaxJointTestResultValue;
        }

        private void firstJointElement_EditValueChanged(object sender, EventArgs e)
        {
            viewModel.FirstElementId = (Guid)firstJointElement.EditValue;
            commandManager["Save"].RefreshState();
            commandManager["SaveAndNew"].RefreshState();
        }

        private void secondJointElement_EditValueChanged(object sender, EventArgs e)
        {
            viewModel.SecondElementId = (Guid)secondJointElement.EditValue;
            commandManager["Save"].RefreshState();
            commandManager["SaveAndNew"].RefreshState();
        }

        private void JointNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void controlOperationsView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView gv = sender as GridView;
            JointTestResult jointTestResult = gv.GetRow(e.RowHandle) as JointTestResult;
            if(jointTestResult.Operation == null)
            {
                gv.SetColumnError(controlTypeGridColumn, Program.LanguageManager.GetString(StringResources.Validation_ValueRequired));
                e.Valid = false;
            }
            if(jointTestResult.Date == null)
            {
                gv.SetColumnError(controlDateGridColumn, Program.LanguageManager.GetString(StringResources.Validation_ValueRequired));
                e.Valid = false;
            }
            if(jointTestResult.Inspectors.Count == 0)
            {
                gv.SetColumnError(inspectorsGridColumn, Program.LanguageManager.GetString(StringResources.Validation_ValueRequired));
                e.Valid = false;
            }
            if(jointTestResult.Status == 0)
            {
                gv.SetColumnError(resultGridColumn, Program.LanguageManager.GetString(StringResources.Validation_ValueRequired));
                e.Valid = false;
            }
        }

        private void repairOperationsView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView gv = sender as GridView;
            JointWeldResult jointWeldResult = gv.GetRow(e.RowHandle) as JointWeldResult;
            if(jointWeldResult.Operation == null)
            {
                gv.SetColumnError(repairTypeGridColumn, Program.LanguageManager.GetString(StringResources.Validation_ValueRequired));
                e.Valid = false;
            }
            if(jointWeldResult.Date == null)
            {
                gv.SetColumnError(repairDateGridColumn, Program.LanguageManager.GetString(StringResources.Validation_ValueRequired));
                e.Valid = false;
            }
            if(jointWeldResult.Operation.Type == JointOperationType.Weld && jointWeldResult.Welders.Count == 0)
            {
                gv.SetColumnError(weldersGridColumn, Program.LanguageManager.GetString(StringResources.Validation_ValueRequired));
                e.Valid = false;
            }
            jointStatus.EditValue = viewModel.JointConstructionStatus;
        }

        #region IValidatable Members

        bool IValidatable.Validate()
        {
            // validation for required weld operation
            if(viewModel.JointWeldResults.Count > 0)
            {
                repairOperationsView_ValidateRow(
                               repairOperationsView,
                               new DevExpress.XtraGrid.Views.Base
                                   .ValidateRowEventArgs(0, repairOperationsView.GetDataRow(0)));
            }
            return dxValidationProvider.Validate();
        }

        #endregion

        private void inspectorsPopupContainerEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            JointTestResult jointTestResult
               = controlOperationsView
               .GetRow(controlOperationsView.FocusedRowHandle) as JointTestResult;

            if(jointTestResult == null || (jointTestResult != null && jointTestResult.Date == null))
            {
                controlOperationsView.SetColumnError(
                    inspectionsGridView.VisibleColumns[2],
                    Program.LanguageManager.GetString(StringResources.DateFirst));
                e.Cancel = true;
            }
            else
            {
                inspectorSelectionControl.inspectionDate = jointTestResult.Date;
            }
        }

        private void weldersPopupContainerEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            JointWeldResult weld =
                repairOperationsView.GetRow(repairOperationsView.FocusedRowHandle) as JointWeldResult;

            if(weld == null || (weld != null && weld.Date == null))
            {
                repairOperationsView.SetColumnError(
                    repairOperationsView.VisibleColumns[1],
                    Program.LanguageManager.GetString(StringResources.DateFirst));

                e.Cancel = true;
            }
            else
            {
                weldersSelectionControl.weldDate = weld.Date ?? DateTime.Now.Date;
            }
        }

        private void JointNewEditXtraForm_Activated(object sender, EventArgs e)
        {
            viewModel.RefreshJointComponents();
            pipelinePiecesBindingSource.DataSource = viewModel.PartDataList;
            firstJointElement.Refresh();
            secondJointElement.Refresh();
        }

        private void HandleInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }



        private void DisableControlUnderWithdrawn()
        {
            repairOperationsView.OptionsBehavior.Editable = false;
            SetAlwaysReadOnly(repairOperations);
            firstJointElement.Enabled = false;
            secondJointElement.Enabled = false;
        }

        private void CompletedCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit checkEdit = sender as CheckEdit;

            if(checkEdit.Checked)
            {
                int selectedIndex = repairOperationsView.GetFocusedDataSourceRowIndex();

                if(selectedIndex >= 0 &&
                    viewModel.JointWeldResults[selectedIndex].Operation != null &&
                    viewModel.JointWeldResults[selectedIndex].Operation.Type == JointOperationType.Withdraw)
                {
                    viewModel.JointWeldResults[selectedIndex].IsCompleted = true;
                    viewModel.JointCut();

                    if(viewModel.Joint.Status == JointStatus.Withdrawn)
                    {
                        DisableControlUnderWithdrawn();
                        checkEdit.Checked = true;
                    }
                    else
                    {
                        viewModel.JointWeldResults[selectedIndex].IsCompleted = false;
                        checkEdit.Checked = false;
                    }
                }
            }
        }
    }
}