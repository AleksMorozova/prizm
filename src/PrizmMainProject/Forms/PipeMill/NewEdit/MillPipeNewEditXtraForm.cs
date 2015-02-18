using System;
using System.ComponentModel;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ninject;
using Ninject.Parameters;
using System.Collections.Generic;
using System.Linq;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Main.Controls;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.DummyData;
using Prizm.Main.Forms.PipeMill.Heat;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Properties;
using System.Collections;
using System.Drawing;

using Prizm.Main.Common;
using DevExpress.XtraGrid.Columns;
using System.Text.RegularExpressions;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Commands;
using DevExpress.XtraGrid;
using Prizm.Main.Documents;
using Prizm.Main.Security;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.DXErrorProvider;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class MillPipeNewEditXtraForm : ChildForm, IValidatable, INewEditEntityForm
    {
        private InspectionAddEditXtraForm inspectionForm;
        private Guid id;
        ICommandManager commandManager = new CommandManager();
        MillPipeNewEditViewModel viewModel;
        WeldersSelectionControl weldersSelectionControl = new WeldersSelectionControl();
        InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();
        Dictionary<CoatingType, string> coatingTypeDict = new Dictionary<CoatingType, string>();
        private PipeTestResult currentTestResult;
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();
        private ExternalFilesXtraForm filesForm = null;
        // do NOT re-create it because reference passed to localization item. Clean it instead.
        private List<string> localizedAllPipeMillStatus = new List<string>();
        private List<string> localizedAllPipeTestResultStatus= new List<string>();
        private PipeMillStatus originalStatus = PipeMillStatus.Undefined;
        private void UpdateTextEdit()
        {
            pipeNewEditBindingSource.CancelEdit(); // http://stackoverflow.com/questions/14941537/better-way-to-update-bound-controls-when-changing-the-datasource 
        }

        public bool IsMatchedByGuid(Guid id) { return this.id == id; }

        public MillPipeNewEditXtraForm(Guid id)
        {
            this.id = id;

            InitializeComponent();
            Bitmap bmp = Resources.mill_pipe_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            SetControlsTextLength();
            viewModel = (MillPipeNewEditViewModel)Program
                .Kernel
                .Get<MillPipeNewEditViewModel>(
                new ConstructorArgument("id", id));
            viewModel.ModifiableView = this;
            viewModel.ValidatableView = this;


            pipeCreationDate.Properties.NullDate = DateTime.MinValue;
            pipeCreationDate.Properties.NullText = string.Empty;

            #region --- Colouring of required controls ---
            pipeNumber.SetRequiredText();
            pipeSize.SetRequiredCombo();
            pipeCreationDate.SetRequiredText();
            heatsLookUp.SetRequiredGridLookUp();
            ordersLookUp.SetRequiredText();
            plateNumber.SetRequiredText();
            #endregion //--- Colouring of required controls ---

            #region --- Read-only controls and edit mode ---
            SetAlwaysReadOnly(plateManufacturer);
            SetAlwaysReadOnly(purchaseOrderDate);
            SetAlwaysReadOnly(railcarNumber);
            SetAlwaysReadOnly(releaseNoteNumber);
            SetAlwaysReadOnly(releaseNoteDate);
            SetAlwaysReadOnly(certificateNumber);
            SetAlwaysReadOnly(destination);
            SetAlwaysReadOnly(steelGrade);
            SetAlwaysReadOnly(weight);
            SetAlwaysReadOnly(length);
            SetAlwaysReadOnly(pipeLength);
            SetAlwaysReadOnly(diameter);
            SetAlwaysReadOnly(thickness);
            SetAlwaysReadOnly(millStatus);
            IsEditMode = ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditPipe);
            attachmentsButton.Enabled = true;
            #endregion //--- Read-only controls ---

            #region --- Set Properties.CharacterCasing to Upper ---
            pipeNumber.SetAsIdentifier();
            plateNumber.SetAsIdentifier();
            heatsLookUp.SetAsIdentifier();
            ordersLookUp.SetAsIdentifier();
            certificateNumber.SetAsIdentifier();
            #endregion //--- Set Properties.CharacterCasing to Upper ---

            heatsLookUp.ButtonSetup();
            ordersLookUp.ButtonSetup();

            // Allow change focus or close while heatsLookUp or ordersLookUp validation error
            AutoValidate = AutoValidate.EnableAllowFocusChange;

            IsEditMode = true;

            // Select tab depending on is new pipe or existed
            tabbedControlGroup.SelectedTabPage = (id == Guid.Empty) ?
                pipeTabLayoutControlGroup : inspectionsTabLayoutControlGroup;

            CannotOpenForViewing = id == Guid.Empty;
        }

        public MillPipeNewEditXtraForm() : this(Guid.Empty) { }

        private void MillPipeNewEditXtraForm_Load(object sender, EventArgs e)
        {
            foreach(var item in EnumWrapper<PipeMillStatus>.EnumerateItems())
            {
                localizedAllPipeTestResultStatus.Add(item.Item2);
            }
            foreach (var item in EnumWrapper<PipeTestResultStatus>.EnumerateItems(skip0:true))
            {
                localizedAllPipeMillStatus.Add(item.Item2);
            }
            BindCommands();
            BindToViewModel();
            viewModel.PropertyChanged += (s, eve) => IsModified = true;

            IsEditMode = viewModel.PipeIsActive && !(viewModel.Pipe.Status == PipeMillStatus.Shipped);

            pipeNumber.SetMask(viewModel.Project.MillPipeNumberMaskRegexp);

            IsModified = false;
            pipeNumber.ToolTip = Program.LanguageManager.GetString(StringResources.MillPipeNumber_Mask_Hint)
                + viewModel.Project.MillPipeNumberMask;

            pipeCreationDate.SetLimits();
            repositoryCoatingDate.SetLimits();
            repositoryWeldingDate.SetLimits();
        }

        private void BindToViewModel()
        {
            pipeNewEditBindingSource.DataSource = viewModel;

            #region ComboBox filling

            foreach(var t in viewModel.PipeTypes)
            {
                if(t.IsActive)
                {
                    pipeSize.Properties.Items.Add(t);
                }
            }
            #endregion

            #region DataBindings

            ordersLookUp.Properties.DataSource = viewModel.PurchaseOrders;
            heatsLookUp.Properties.DataSource = viewModel.Heats;

            pipeNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Number");
            length.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Length");
            weight.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Weight");
            diameter.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Diameter");
            thickness.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "WallThickness");
            pipeLength.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PipeLength");

            deactivated.DataBindings
                .Add(BindingHelper.CreateCheckEditInverseBinding(
                        "Checked", pipeNewEditBindingSource, "PipeIsActive"));

            plateThickness.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PlateThickness");
            pipeCreationDate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "ProductionDate");

            steelGrade.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "SteelGrade");

            plateManufacturer.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PlateManufacturer");

            pipeSize.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PipeMillSizeType");

            purchaseOrderDate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PurchaseOrderDate");
            
            
            releaseNoteNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "ReleaseNoteNumber");
            releaseNoteDate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "ReleaseNoteDate");


            railcarNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarNumber");

            certificateNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarCertificate");
            destination.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarDestination");

            plateNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PlateNumber", true, DataSourceUpdateMode.OnPropertyChanged);


            inspections.DataBindings
                .Add("DataSource", pipeNewEditBindingSource, "PipeTestResults");


            coatingHistory.DataBindings
                .Add("DataSource", pipeNewEditBindingSource, "Coats");
            weldingHistory.DataBindings
                .Add("DataSource", pipeNewEditBindingSource, "Welds");


            resultStatusLookUpEdit.DataSource = viewModel.TestResultStatuses;

            millStatus.DataBindings.Add(
                BindingHelper.CreateOneWayReadToString("Text", pipeNewEditBindingSource, "PipeStatus",
                (value) =>
                {
                    return (string)localizedAllPipeMillStatus[(int)value];
                }));

            ordersLookUp.DataBindings.Add("EditValue", pipeNewEditBindingSource, "PipePurchaseOrder");

            heatsLookUp.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Heat");

            inspectionCodeLookUpEdit.DataSource = viewModel.AvailableTests;
            #endregion


            weldBindingSource.DataSource = viewModel.Pipe;
            weldBindingSource.DataMember = "Welds";
            weldBindingSource.ListChanged += (s, eve) => IsModified = true;
            weldersDataSource.DataSource = viewModel.Welders;

            weldersSelectionControl.DataSource = weldersDataSource;
            var weldersPopup = new PopupContainerControl();
            weldersPopup.Controls.Add(weldersSelectionControl);
            weldersSelectionControl.Dock = DockStyle.Fill;
            repositoryItemPopupWelders.PopupControl = weldersPopup;
            repositoryItemPopupWelders.PopupControl.MaximumSize = weldersPopup.MaximumSize;

            inspectorsDataSource.DataSource = viewModel.Inspectors;
            inspectorsDataSource.ListChanged += (s, eve) => IsModified = true;
            inspectorSelectionControl.DataSource = inspectorsDataSource;
            var inspectorsPopup = new PopupContainerControl();
            inspectorsPopup.Controls.Add(inspectorSelectionControl);
            inspectorSelectionControl.Dock = DockStyle.Fill;
            inspectorsPopupContainerEdit.PopupControl = inspectorsPopup;
            inspectorsPopupContainerEdit.PopupControl.MaximumSize = inspectorsPopup.MaximumSize;

            coatingTypeDict.Clear();
            coatingTypeDict.Add(CoatingType.Internal, Program.LanguageManager.GetString(StringResources.MillPipe_CoatInternal));
            coatingTypeDict.Add(CoatingType.External, Program.LanguageManager.GetString(StringResources.MillPipe_CoatExternal));

            repositoryItemLookUpEditCoatType.DataSource = coatingTypeDict;

            coatDataSource.ListChanged += (s, eve) => IsModified = true;

            coatDataSource.DataSource = viewModel.Pipe;

        }

        private void BindCommands()
        {
            commandManager["SaveAndNew"].Executor(viewModel.NewSavePipeCommand).AttachTo(saveAndNewButton);
            commandManager["Save"].Executor(viewModel.SavePipeCommand).AttachTo(saveButton);
            commandManager["Deactivate"].Executor(viewModel.PipeDeactivationCommand).AttachTo(deactivated);

            SaveCommand = viewModel.SavePipeCommand;

            viewModel.SavePipeCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.NewSavePipeCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.PipeDeactivationCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;

            commandManager.RefreshVisualState();
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>() 
                { 
                    // layout items
                    new LocalizedItem(pipeNumberLayout, StringResources.NewEditPipe_PipeNumberLabel.Id),
                    new LocalizedItem(pipeSizeLayout, StringResources.NewEditPipe_PipeSizeLabel.Id),
                    new LocalizedItem(heatsLayout, StringResources.NewEditPipe_HeatsComboLabel.Id),
                    new LocalizedItem(ordersLayout, StringResources.NewEditPipe_PurchaseOrdersComboLabel.Id),
                    new LocalizedItem(purchaseOrderDateLayoutControl, StringResources.NewEditPipe_PurchaseOrederDateLabel.Id),
                    new LocalizedItem(creationDateLayout, StringResources.NewEditPipe_PipeCreationLabel.Id),
                    new LocalizedItem(statusLayout, StringResources.NewEditPipe_PipeStatusLabel.Id),

                    new LocalizedItem(plateNumberLayoutControlItem, StringResources.NewEditPipe_PlateNumberLabel.Id),
                    new LocalizedItem(plateThicknessLayoutControlItem, StringResources.NewEditPipe_PlateThicknessLabel.Id),
                    new LocalizedItem(plateManufacturerLayoutControlItem, StringResources.NewEditPipe_PlateManufacturerLabel.Id),
                    new LocalizedItem(steelGradeLayoutControlItem, StringResources.NewEditPipe_PlateSteelGradeLabel.Id),
                    
                    new LocalizedItem(pipeLengthLayout, StringResources.NewEditPipe_PipeLengthLabel.Id),
                    new LocalizedItem(weightLayoutControlItem, StringResources.NewEditPipe_PipeWeightLabel.Id),

                    new LocalizedItem(lengthLayoutControlItem, StringResources.NewEditPipe_TypeSizeLengthLabel.Id),
                    new LocalizedItem(diameterLayoutControlItem, StringResources.NewEditPipe_TypeSizeDiameterLabel.Id),
                    new LocalizedItem(thicknessLayoutControlItem, StringResources.NewEditPipe_TypeSizeThicknessLabel.Id),

                    new LocalizedItem(railcarLayoutControlItem, StringResources.NewEditPipe_RailcarNumber_Label.Id),
                    new LocalizedItem(certificateLayoutControlItem, StringResources.NewEditPipe_RailcarCertificate_Label.Id),
                    new LocalizedItem(releaseNoteDateLayoutControlItem, StringResources.NewEditPipe_ReleaseNoteDate_Label.Id),
                    new LocalizedItem(releaseNoteNumberLayout, StringResources.NewEditPipe_ReleaseNoteNumber_Label.Id),
                    new LocalizedItem(destinationLayoutControlItem, StringResources.NewEditPipe_RailcarDestination_Label.Id),

                    // controls
                    new LocalizedItem(attachmentsButton, StringResources.NewEditPipe_AttachmentsButton.Id),
                    new LocalizedItem(deactivated, StringResources.NewEditPipe_DeactivatedCheckBox.Id),
                    new LocalizedItem(saveButton, StringResources.NewEditPipe_SaveButton.Id),
                    new LocalizedItem(saveAndNewButton, StringResources.NewEditPipe_SaveAndNewButton.Id),

                    new LocalizedItem(addInspectionButton, StringResources.NewEditPipe_InspectionsAddButton.Id),
                    new LocalizedItem(editInspectionButton, StringResources.NewEditPipe_InspectionsEditsButton.Id),

                    // grid column headers
                    new LocalizedItem(weldersGridColumn, StringResources.NewEditPipe_WeldersColumnHeader.Id),
                    new LocalizedItem(weldingDateGridColumn, StringResources.NewEditPipe_WeldingDateColumnHeader.Id),
                    
                    new LocalizedItem(coatingDateGridColumn, StringResources.NewEditPipe_CoatingDateColumnHeader.Id),
                    new LocalizedItem(coatingTypeGridColumn, StringResources.NewEditPipe_CoatingTypeColumnHeader.Id),

                    new LocalizedItem(inspectionCodeGridColumn, StringResources.NewEditPipe_InspectionCodeColumnHeader.Id),
                    new LocalizedItem(inspectionNameGridColumn, StringResources.NewEditPipe_InspectionNameColumnHeader.Id),
                    new LocalizedItem(categoryGridColumn, StringResources.NewEditPipe_InspectionCategoryColumnHeader.Id),
                    new LocalizedItem(expectedResultGridColumn, StringResources.NewEditPipe_InspectionExpectedResultColumnHeader.Id),
                    new LocalizedItem(valueGridColumn, StringResources.NewEditPipe_InspectionValueColumnHeader.Id),
                    new LocalizedItem(inspectionResultGridColumn, StringResources.NewEditPipe_InspectionResultColumnHeader.Id),
                    new LocalizedItem(controlDateGridColumn, StringResources.NewEditPipe_InspectionDateColumnHeader.Id),
                    new LocalizedItem(inspectorsGridColumn, StringResources.NewEditPipe_InspectorsCodeColumnHeader.Id),

                    // layout control groups
                    new LocalizedItem(plateLayoutControlGroup, StringResources.NewEditPipe_PlateGroup.Id),
                    new LocalizedItem(factSizeLayoutControlGroup, StringResources.NewEditPipe_FactSizeGroup.Id),
                    new LocalizedItem(typeSizeaParametersLyoutGroup, StringResources.NewEditPipe_TypeSizeGroup.Id),
                    new LocalizedItem(shippingLayoutControlGroup, StringResources.NewEditPipe_ShippingGroup.Id),
                    new LocalizedItem(coverLayoutControlGroup, StringResources.NewEditPipe_CoverGroup.Id),
                    new LocalizedItem(weldsLayoutControlGroup, StringResources.NewEditPipe_WeldsGroup.Id),
                    new LocalizedItem(pipeTabLayoutControlGroup, StringResources.NewEditPipe_PipeTabGroup.Id),
                    new LocalizedItem(inspectionsTabLayoutControlGroup, StringResources.NewEditPipe_InspectionsTabGroup.Id),


                    // one-way text edit for statuses. See data binding for appropriate text edit, to understand the connection.
                    new LocalizedItem(UpdateTextEdit, localizedAllPipeMillStatus,
                        new string [] {StringResources.NewEditPipe_PipeStatusUndefined.Id, 
                            StringResources.NewEditPipe_PipeStatusProduced.Id, 
                            StringResources.NewEditPipe_PipeStatusStocked.Id, 
                            StringResources.NewEditPipe_PipeStatusShipped.Id} ),

                    //grid enums
                    new LocalizedItem (inspectionsGridView, localizedAllPipeTestResultStatus, new string [] { StringResources.PipeTestResultStatus_Scheduled.Id,
                                                                                                              StringResources.PipeTestResultStatus_Passed.Id,
                                                                                                              StringResources.PipeTestResultStatus_Failed.Id,
                                                                                                              StringResources.PipeTestResultStatus_Repair.Id}),
                    // header
                    new LocalizedItem(this, localizedHeader, new string[] {StringResources.MillPipeNewEditXtraForm_Title.Id} )
                };
        }

        #endregion // --- Localization ---

        private void repositoryItemPopupWelders_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if(weldingHistoryGridView.IsValidRowHandle(weldingHistoryGridView.FocusedRowHandle))
            {
                IList<Welder> selectedWelders = weldersSelectionControl.SelectedWelders;
                Weld weld = weldingHistoryGridView.GetRow(weldingHistoryGridView.FocusedRowHandle) as Weld;
                if(weld != null)
                {
                    weld.Welders.Clear();
                    foreach(Welder w in selectedWelders)
                    {
                        weld.Welders.Add(w);
                        w.Welds.Add(weld);
                    }
                }
            }

        }

        private void repositoryItemPopupWelders_Popup(object sender, EventArgs e)
        {
            weldingHistoryGridView.ClearSelection();
            if(weldingHistoryGridView.IsValidRowHandle(weldingHistoryGridView.FocusedRowHandle))
            {
                Weld weld = weldingHistoryGridView.GetRow(weldingHistoryGridView.FocusedRowHandle) as Weld;
                if(weld != null)
                {
                    weldersSelectionControl.SelectWelders(weld.Welders);
                }


            }
        }

        private void repositoryItemPopupWelders_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
                e.DisplayText = string.Empty;

            IList<Welder> welders = e.Value as IList<Welder>;
            if(viewModel != null)
            {
                e.DisplayText = viewModel.FormatWeldersList(welders);
            }
        }

        private void repositoryItemPopupWelders_QueryPopUp(object sender, CancelEventArgs e)
        {
            Weld weld = weldingHistoryGridView.GetRow(weldingHistoryGridView.FocusedRowHandle) as Weld;
            if(weld == null || (weld != null && weld.Date == null))
            {
                weldingHistoryGridView.SetColumnError(weldingHistoryGridView.VisibleColumns[0], 
                    Program.LanguageManager.GetString(StringResources.DateFirst));
                e.Cancel = true;
            }
            else
            {
                weldersSelectionControl.weldDate = weld.Date;
            }
        }

        private void pipeNumber_EditValueChanged(object sender, EventArgs e)
        {
            this.headerNumberPart = pipeNumber.Text;  // BEFORE set to viewModel
            viewModel.Number = pipeNumber.Text;

            commandManager.RefreshVisualState();
        }

        private void pipeCreationDate_EditValueChanged(object sender, EventArgs e)
        {
            viewModel.ProductionDate = pipeCreationDate.DateTime;

            commandManager.RefreshVisualState();
        }

        private void weldingHistoryGridView_KeyDown(object sender, KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<Weld>(e, viewModel.Pipe.Welds, (_) => _.IsNew());
        }

        private void repositoryItemLookUpEditCoatType_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;

            if(!(lookup.EditValue is CoatingType))
            {
                KeyValuePair<CoatingType, string> val = (KeyValuePair<CoatingType, string>)lookup.EditValue;
                lookup.EditValue = val.Key;
            }
        }

        private void repositoryItemLookUpEditCoatType_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value is CoatingType)
            {
                e.DisplayText = coatingTypeDict[(CoatingType)e.Value];
            }
        }

        private void coatingHistoryGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if(view.IsValidRowHandle(e.RowHandle))
            {
                Coat coat = view.GetRow(e.RowHandle) as Coat;
                coat.Pipe = viewModel.Pipe;
                coat.Type = CoatingType.Internal;
                coat.Date = DateTime.Now;
            }
        }

        private void inspectorsPopupContainerEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if(inspectionsGridView.IsValidRowHandle(inspectionsGridView.FocusedRowHandle))
            {
                IList<Inspector> selectedInspectors = inspectorSelectionControl.SelectedInspectors;
                PipeTestResult pipeTestResult = inspectionsGridView.GetRow(inspectionsGridView.FocusedRowHandle) as PipeTestResult;
                if(pipeTestResult == null)
                    return;

                pipeTestResult.Inspectors.Clear();
                foreach(Inspector i in selectedInspectors)
                {
                    pipeTestResult.Inspectors.Add(i);
                }
            }
        }

        private void inspectorsPopupContainerEdit_Popup(object sender, EventArgs e)
        {
            inspectionsGridView.ClearSelection();
            if(inspectionsGridView.IsValidRowHandle(inspectionsGridView.FocusedRowHandle))
            {
                PipeTestResult pipeTestResult = inspectionsGridView.GetRow(inspectionsGridView.FocusedRowHandle) as PipeTestResult;
                if(pipeTestResult != null)
                {
                    inspectorSelectionControl.SelectInspectors(pipeTestResult.Inspectors);
                }
            }
        }

        private void inspectorsPopupContainerEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
                e.DisplayText = string.Empty;

            IList<Inspector> inspectors = e.Value as IList<Inspector>;
            if(viewModel != null)
            {
                e.DisplayText = viewModel.FormatInspectorList(inspectors);
            }
        }

        private void coatingHistoryGridView_KeyDown(object sender, KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<Coat>(e, viewModel.Pipe.Coats, (_) => _.IsNew());
        }

        private void weldingHistoryGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if(view.IsValidRowHandle(e.RowHandle))
            {
                Weld weld = view.GetRow(e.RowHandle) as Weld;
                weld.Pipe = viewModel.Pipe;
                weld.Date = DateTime.Now;
            }
        }

        private void SetControlsTextLength()
        {
            pipeNumber.Properties.MaxLength = LengthLimit.MaxPipeNumber;
            plateNumber.Properties.MaxLength = LengthLimit.MaxPlateNumber;
            testResultValue.MaxLength = LengthLimit.MaxPipeTestResultValue;
            testResultValue.MaxLength = LengthLimit.MaxPipeTestResultValue;
        }

        private void inspectionCodeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit q = sender as LookUpEdit;
            object row = q.Properties.GetDataSourceRowByKeyValue(q.EditValue);
            PipeTest selectedTest = q.Properties.GetDataSourceRowByKeyValue(q.EditValue) as PipeTest;
            if(selectedTest != null)
                currentTestResult.Operation = selectedTest;
        }

        private void inspectionsGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if(view.IsValidRowHandle(e.RowHandle))
            {
                currentTestResult = view.GetRow(e.RowHandle) as PipeTestResult;
                currentTestResult.IsActive = true;
                currentTestResult.Pipe = viewModel.Pipe;
                currentTestResult.Order = viewModel.PipeTestResults.Max(test => test.Order) + 1;
                viewModel.Pipe.PipeTestResult = viewModel.PipeTestResults;
            }
        }

        /// <summary>
        /// Check if it possible to change size type if yes refreshes list of required pipe test results if size type was changed
        /// </summary>
        private void pipeSize_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            PipeMillSizeType currentPipeType;
            if(pipeSize.SelectedIndex >= 0)
            {
                currentPipeType = (PipeMillSizeType)e.NewValue;
                if(currentPipeType != null && viewModel.Pipe.Type != currentPipeType)
                {
                    if(viewModel.IsAnyInspectionResult() > 0)
                    {
                        if(viewModel.IsNew == true)
                        {
                            if(this.MdiParent.ShowYesNo(
                                    Program.LanguageManager.GetString(StringResources.MillPipe_ChangeTypesizeConfirmation),
                                    Program.LanguageManager.GetString(StringResources.MillPipe_PipeSizeChangeHeader))
                                != true)
                            {
                                e.Cancel = true;
                            }
                        }
                        else
                        {
                            this.MdiParent.ShowNotify(
                                Program.LanguageManager.GetString(StringResources.MillPipe_NotAllowedToChangeTypesize),
                                Program.LanguageManager.GetString(StringResources.MillPipe_PipeSizeChangeHeader));
                            e.Cancel = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///Refreshes list of required pipe test 
        /// </summary>
        private void RefreshPipeTest(PipeMillSizeType currentPipeType)
        {
            if(currentPipeType != null && viewModel.Pipe.Type != currentPipeType)
            {
                viewModel.PipeMillSizeType = currentPipeType;
                viewModel.PipeTestResults = viewModel.GetRequired(currentPipeType);
                viewModel.Pipe.PipeTestResult = viewModel.PipeTestResults;
                inspectionCodeLookUpEdit.DataSource = viewModel.AvailableTests;
                inspections.RefreshDataSource();
            }

            viewModel.PipeMillSizeType = pipeSize.SelectedItem as PipeMillSizeType;

            commandManager.RefreshVisualState();
        }

        private void pipeSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cb = sender as ComboBoxEdit;
            Prizm.Domain.Entity.Setup.PipeMillSizeType currentPipeType
                = cb.SelectedItem as Prizm.Domain.Entity.Setup.PipeMillSizeType;
            RefreshPipeTest(currentPipeType);

            if(currentPipeType != null)
            {
                viewModel.CurrentType = currentPipeType;
            }
        }

        private void inspectionsGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView gv = sender as GridView;

            PipeTestResultStatus result = (PipeTestResultStatus)gv.GetRowCellValue(e.RowHandle, inspectionResultGridColumn);
            DateTime? date = (DateTime?)gv.GetRowCellValue(e.RowHandle, controlDateGridColumn);
            var op = (string)gv.GetRowCellValue(e.RowHandle, inspectionCodeGridColumn);
            if(string.IsNullOrWhiteSpace(op))
            {
                gv.SetColumnError(inspectionCodeGridColumn, 
                    Program.LanguageManager.GetString(StringResources.Validation_ValueRequired));
                e.Valid = false;
            }

            switch(result)
            {
                case PipeTestResultStatus.Passed:
                case PipeTestResultStatus.Failed:
                case PipeTestResultStatus.Repair:
                    if(date == null || date > DateTime.Now)
                    {
                        gv.SetColumnError(controlDateGridColumn, 
                            Program.LanguageManager.GetString(StringResources.MillPipe_ErrorEmptyOrFutureDate));
                        e.Valid = false;
                    }

                    break;
                default:
                    break;
            }
        }

        private void pipeNumber_Validating(object sender, CancelEventArgs e)
        {
            if(!Regex.IsMatch(pipeNumber.EditValue.ToString(), pipeNumber.Properties.Mask.EditMask, RegexOptions.IgnoreCase))
            {
                pipeNumber.ErrorText = Program.LanguageManager.GetString(StringResources.MillPipe_ValueDoesNotMatchMask);
                e.Cancel = true;
            }
        }

        private void attachmentsButton_Click(object sender, EventArgs e)
        {
            if (filesForm == null)
            {
                filesForm = new ExternalFilesXtraForm();
                viewModel.FilesFormViewModel = filesForm.ViewModel;
            }
            viewModel.FilesFormViewModel.RefreshFiles(viewModel.Pipe.Id);
            filesForm.SetData(IsEditMode);
            filesForm.ShowDialog();
        }

        private void ShowHeatDialog(string number)
        {
            using(new HeatXtraForm(number))
            {

            }
        }

        private void heatsLookUp_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var number = ((GridLookUpEdit)sender).Text;
                ShowHeatDialog(number);
            }
        }

        private void heatsLookUp_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(e.DisplayValue.ToString()))
            {
                if(MessageBox.Show(
                        string.Format(Program.LanguageManager.GetString(StringResources.MillPipe_NewHeatQuestion), e.DisplayValue.ToString()),
                        Program.LanguageManager.GetString(StringResources.MillPipe_NewHeadQuestionHeader),
                        MessageBoxButtons.YesNo) 
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    ShowHeatDialog(e.DisplayValue.ToString());
                }
            }
            e.Handled = true;
        }

        private void heatsLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            viewModel.ExtractHeatsCommand.Execute();
            heatsLookUp.Properties.DataSource = null;
            heatsLookUp.Properties.DataSource = viewModel.Heats;
        }

        private void ShowOrderDialog(string number)
        {
            var dlg = new PurchaseOrderXtraForm(number);
            dlg.ShowDialog();
        }

        private void ordersLookUp_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var number = ((GridLookUpEdit)sender).Text;
                ShowOrderDialog(number);
            }
        }

        private void ordersLookUp_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(e.DisplayValue.ToString()))
            {
                if(MessageBox.Show(
                        string.Format(Program.LanguageManager.GetString(StringResources.MillPipe_NewPurchaseOrderQuestion), e.DisplayValue.ToString()),
                        Program.LanguageManager.GetString(StringResources.MillPipe_NewPurchaseOrderQuestionHeader), 
                        MessageBoxButtons.YesNo) 
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    ShowOrderDialog(e.DisplayValue.ToString());
                }
            }
            e.Handled = true;
        }

        private void ordersLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            viewModel.ExtractPurchaseOrderCommand.Execute();
            ordersLookUp.Properties.DataSource = null;
            ordersLookUp.Properties.DataSource = viewModel.PurchaseOrders;
        }

        private void MillPipeNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            if(viewModel != null)
            {
                viewModel.Dispose();
                viewModel = null;
            }
        }

        #region IValidatable Members

        bool IValidatable.Validate()
        {
            return dxValidationProvider.Validate() && this.ValidateChildren();
        }

        #endregion

        private void inspectorsPopupContainerEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            PipeTestResult pipeTestResult = inspectionsGridView.GetRow(inspectionsGridView.FocusedRowHandle) as PipeTestResult;
            if(pipeTestResult == null || (pipeTestResult != null && pipeTestResult.Date == null))
            {
                inspectionsGridView.SetColumnError(inspectionsGridView.VisibleColumns[6], 
                    Program.LanguageManager.GetString(StringResources.DateFirst));
                e.Cancel = true;
            }
            else
            {
                inspectorSelectionControl.inspectionDate = pipeTestResult.Date;
            }
        }

        private void heatsLookUp_Validated(object sender, EventArgs e)
        {
            commandManager.RefreshVisualState();
        }

        private void ordersLookUp_Validated(object sender, EventArgs e)
        {
            commandManager.RefreshVisualState();
        }

        private void addInspectionButton_Click(object sender, EventArgs e)
        {
            if(viewModel.AvailableTests.Count > 0)
            {
                AddInspection(viewModel.AvailableTests, viewModel.Inspectors, viewModel.TestResultStatuses);
            }
        }

        private void editInspectionButton_Click(object sender, EventArgs e)
        {
            if(viewModel.AvailableTests.Count > 0)
            {
                int rowHandler = inspectionsGridView.FocusedRowHandle;
                if(rowHandler != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                {
                    var row = (PipeTestResult)inspectionsGridView.GetRow(rowHandler);
                    EditInspections(viewModel.AvailableTests, row, viewModel.Inspectors, viewModel.TestResultStatuses);
                }
            }
        }

        private void AddInspection(BindingList<PipeTest> tests, IList<Inspector> inspectors, IList<EnumWrapper<PipeTestResultStatus>> statuses)
        {
            if (IsEditMode)
            {
                var addForm = GetInspectionForm(tests, inspectors, null, statuses);

                if (addForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    addForm.viewModel.TestResult.Pipe = viewModel.Pipe;
                    viewModel.PipeTestResults.Add(addForm.viewModel.TestResult);
                    IsModified = true;
                    inspections.RefreshDataSource();
                    viewModel.GetLengthFromOperation();
                    pipeLength.Refresh();
                    weight.Refresh();
                }
            }
        }

        private void EditInspections(BindingList<PipeTest> tests, PipeTestResult row, IList<Inspector> insp, BindingList<EnumWrapper<PipeTestResultStatus>> status)
        {
            if (IsEditMode)
            {
                var editForm = GetInspectionForm(tests, insp, row, status);

                editForm.ShowDialog();
                IsModified = true;
                inspections.RefreshDataSource();
                viewModel.GetLengthFromOperation();
                pipeLength.Refresh();
                weight.Refresh();
            }
        }

        private void inspectionsGridView_DoubleClick(object sender, EventArgs e)
        {
            if(viewModel.AvailableTests.Count > 0)
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                var row = DoRowDoubleClick(view, pt);
                EditInspections(viewModel.AvailableTests, row, viewModel.Inspectors, viewModel.TestResultStatuses);
            }
        }

        private PipeTestResult DoRowDoubleClick(GridView view, Point pt)
        {
            PipeTestResult row = null;
            GridHitInfo info = view.CalcHitInfo(pt);
            if(info.InRow || info.InRowCell)
            {
                row = (PipeTestResult)view.GetRow(info.RowHandle);
            }
            return row;
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

        private void pipeTabLayoutControlGroup_Shown(object sender, EventArgs e)
        {
            #region fields validation only afrer project tab is shown
            ConditionValidationRule notBlankValidationRule = new ConditionValidationRule();
            notBlankValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notBlankValidationRule.ErrorText = Program.LanguageManager.GetString(StringResources.Validation_ValueRequired);
            notBlankValidationRule.ErrorType = ErrorType.Critical;

            dxValidationProvider.SetValidationRule(pipeCreationDate, notBlankValidationRule);
            dxValidationProvider.SetValidationRule(pipeNumber, notBlankValidationRule);
            dxValidationProvider.SetValidationRule(plateNumber, notBlankValidationRule);
            #endregion
        }

        private InspectionAddEditXtraForm GetInspectionForm(
            BindingList<PipeTest> tests, 
            IList<Inspector> inspectors, 
            PipeTestResult row, 
            IList<EnumWrapper<PipeTestResultStatus>> statuses)
        {
            if (inspectionForm == null)
            {
                inspectionForm = new InspectionAddEditXtraForm(tests, inspectors, row, statuses);
            }
            else
            {
                inspectionForm.SetupForm(tests, inspectors, row, statuses);
            }

            return inspectionForm;
        }

        private void inspectionsGridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == inspectionResultGridColumn.Name && e.Value != null)
            {
                PipeTestResultStatus result;
                if (Enum.TryParse<PipeTestResultStatus>(e.Value.ToString(), out result))
                {
                    e.DisplayText = (result == PipeTestResultStatus.Undefined) ? "" :localizedAllPipeTestResultStatus[(int)result - 1]; //-1 because we skip 0
                }
            }

            if (e.Column.Name == expectedResultGridColumn.Name)
            {
                PipeTestResult pipeTestResult = inspectionsGridView.GetRow(e.ListSourceRowIndex) as PipeTestResult;
                if (pipeTestResult != null
                    && pipeTestResult.Operation.ResultType == PipeTestResultType.Boolean)
                {
                    if (pipeTestResult.Operation.BoolExpected)
                    {
                        e.DisplayText = Program.LanguageManager.GetString(StringResources.Yes);
                    }
                    else
                    {
                        e.DisplayText = Program.LanguageManager.GetString(StringResources.No);
                    }
                }
            }

            if (e.Column.Name == valueGridColumn.Name)
            {
                bool tmpResult;

                PipeTestResult pipeTestResult = inspectionsGridView.GetRow(e.ListSourceRowIndex) as PipeTestResult;
                
                if (pipeTestResult != null 
                    && bool.TryParse(e.DisplayText, out tmpResult)
                    && pipeTestResult.Operation.ResultType == PipeTestResultType.Boolean)
                {
                    if (tmpResult)
                    {
                        e.DisplayText = Program.LanguageManager.GetString(StringResources.Yes);
                    }
                    else
                    {
                        e.DisplayText = Program.LanguageManager.GetString(StringResources.No);
                    }
                }
            }
        }

        private void plateNumber_TextChanged(object sender, EventArgs e)
        {
            commandManager.RefreshVisualState();
        }
    }
}

