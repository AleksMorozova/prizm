using DevExpress.XtraEditors;
using Ninject.Parameters;
using Ninject;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Forms.MainChildForm;
using System;
using Prizm.Main.Common;
using Prizm.Domain.Entity.Construction;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using Prizm.Main.Properties;
using Prizm.Main.Controls;
using System.Windows.Forms;
using Prizm.Domain.Entity;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using System.Linq;
using Prizm.Main.Security;
using DevExpress.XtraGrid.Views.Base;
using Prizm.Main.Languages;
using System.Drawing;
using DevExpress.XtraGrid.Columns;

namespace Prizm.Main.Forms.Component.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class ComponentNewEditXtraForm : ChildEditableForm, IValidatable
    {
        private ComponentNewEditViewModel viewModel;
        private InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();
        private List<string> localizedAllInspectionStatus = new List<string>();
        private ICommandManager commandManager = new CommandManager();
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public bool IsMatchedByGuid(Guid id) { return this.Id == id; }

        public ComponentNewEditXtraForm(Guid id) : this(id, string.Empty) { }
        public ComponentNewEditXtraForm(string number) : this(Guid.Empty, number) { }
        public ComponentNewEditXtraForm() : this(Guid.Empty, string.Empty) { }
        private ExternalFilesXtraForm filesForm = null;

        public ComponentNewEditXtraForm(Guid id, string number)
        {
            this.Id = id;

            InitializeComponent();

            SetControlsTextLength();

            viewModel = (ComponentNewEditViewModel)Program
               .Kernel
               .Get<ComponentNewEditViewModel>(new ConstructorArgument("id", id));

            viewModel.ModifiableView = this;
            viewModel.ValidatableView = this;
            if (string.IsNullOrWhiteSpace(viewModel.Component.Number))
            {
                viewModel.Number = number;
            }
            attachmentsButton.Enabled = true;
            CannotOpenForViewing = id == Guid.Empty;

            #region --- Colouring of required controls ---
            componentNumber.SetRequiredText();
            type.SetRequiredText();
            #endregion //--- Colouring of required controls ---

            #region --- Set Properties.CharacterCasing to Upper ---
            componentNumber.SetAsIdentifier();
            certificateNumber.SetAsIdentifier();
            #endregion //--- Set Properties.CharacterCasing to Upper ---

            positiveFloat.SetFloatMask(Constants.DigitsBeforeDecimalPoint);
        }

        private void SetControlsTextLength()
        {
            componentNumber.Properties.MaxLength = LengthLimit.ComponentNumber;
            certificateNumber.Properties.MaxLength = LengthLimit.ComponentCertificate;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(newComponentLayoutGroup, StringResources.ComponentNewEdit_NewComponentLayoutGroup.Id),
                new LocalizedItem(componentNumberLayout, StringResources.ComponentNewEdit_ComponentNumberLayout.Id),
                new LocalizedItem(typeLayoutControl, StringResources.ComponentNewEdit_TypeLayoutControl.Id),
                new LocalizedItem(certificateLayout, StringResources.ComponentNewEdit_CertificateLayout.Id),
                new LocalizedItem(componentLengthLayout, StringResources.ComponentNewEdit_ComponentLengthLayout.Id),
                new LocalizedItem(InspectionLayoutGroup, StringResources.ComponentNewEdit_InspectionLayoutGroup.Id),
                
                new LocalizedItem(attachmentsButton, StringResources.ComponentNewEdit_AttachmentsButton.Id),
                new LocalizedItem(deactivated, StringResources.ComponentNewEdit_Deactivated.Id),
                new LocalizedItem(newSaveComponentButton, StringResources.ComponentNewEdit_NewSaveComponentButton.Id),
                new LocalizedItem(saveComponentButton, StringResources.ComponentNewEdit_SaveComponentButton.Id),

                new LocalizedItem(inspectionDateColumn, StringResources.ComponentNewEdit_InspectionDateColumn.Id),
                new LocalizedItem(inspectorColumn, StringResources.ComponentNewEdit_InspectorColumn.Id),
                new LocalizedItem(resultColumn, StringResources.ComponentNewEdit_ResultColumn.Id),
                new LocalizedItem(reasonColumn, StringResources.ComponentNewEdit_ReasonColumn.Id),
                new LocalizedItem(orderColumn, StringResources.ComponentNewEdit_OrderColumn.Id),
                new LocalizedItem(isConnectedGridColumn,StringResources.ComponentNewEdit_IsConnectedGridColumn.Id),

                new LocalizedItem(diameterGridColumn, StringResources.ComponentNewEdit_DiameterGridColumn.Id),
                new LocalizedItem(wallThicknessGridColumn, StringResources.ComponentNewEdit_WallThicknessGridColumn.Id),

                new LocalizedItem(repositoryInspectionStatus, localizedAllInspectionStatus,new string []
                                                                                      {
                                                                                        StringResources.PartInspectionStatus_Pending.Id,
                                                                                        StringResources.PartInspectionStatus_Hold.Id,
                                                                                        StringResources.PartInspectionStatus_Rejected.Id,
                                                                                        StringResources.PartInspectionStatus_Accepted.Id
                                                                                      }),
                
                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.ComponentNewEdit_Title.Id} )

            };
        }

        #endregion // --- Localization ---

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            if(filesForm == null)
            {
                filesForm = new ExternalFilesXtraForm();
                viewModel.FilesFormViewModel = filesForm.ViewModel;
            }
            viewModel.FilesFormViewModel.RefreshFiles(viewModel.Component.Id);
            filesForm.SetData(IsEditMode);
            filesForm.ShowDialog();

        }

        private void ComponentNewEditXtraForm_Load(object sender, EventArgs e)
        {
            EnumWrapper<PartInspectionStatus>.LoadItems(localizedAllInspectionStatus, skip0: true);
            BindCommands();
            BindToViewModel();

            viewModel.PropertyChanged += (s, eve) => IsModified = true;

            viewModel.PropertyChanged += (s, eve) =>
            {
                if (eve.PropertyName == "ComponentIsActive" && viewModel.ComponentIsActive)
                {
                    deactivated.Reset();
                }
            };
            IsEditMode &= viewModel.ComponentIsActive;
          

            IsModified = false;

            repositoryInspectionDate.SetLimits();
            componentLength.SetMask(Constants.PositiveDigitMask);

            inspectorColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;

            inspectorsPopupContainerEdit.SetSize();
            type.ReadOnly = !IsEditMode || viewModel.HasConnectedConnectors;
            inspectionHistoryGridView.OptionsBehavior.Editable = !type.ReadOnly;
        }

        private void BindToViewModel()
        {
            componentBindingSource.DataSource = viewModel;

            foreach(var t in viewModel.ComponentTypes)
            {
                if(t.IsActive)
                {
                    type.Properties.Items.Add(t);
                }
            }

            #region   ---- Prizm.Data Bindings ----
            componentNumber.DataBindings
                .Add("EditValue", componentBindingSource, "Number");

            certificateNumber.DataBindings
                .Add("EditValue", componentBindingSource, "Certificate");

            componentParameters.DataBindings
              .Add("DataSource", componentBindingSource, "Connectors");

            type.DataBindings
                .Add("EditValue", componentBindingSource, "Type");

            deactivated.DataBindings
                .Add(BindingHelper.CreateCheckEditInverseBinding(
                        "Checked", componentBindingSource, "ComponentIsActive"));

            inspectionHistoryGrid.DataBindings
                .Add("DataSource", componentBindingSource, "InspectionTestResults");

            componentLength.DataBindings
                .Add("EditValue", componentBindingSource, "Length");
            #endregion

            inspectorsDataSource.DataSource = viewModel.Inspectors;
            inspectorsDataSource.ListChanged += (s, eve) => IsModified = true;
            inspectorSelectionControl.DataSource = inspectorsDataSource;
            var inspectorsPopup = new PopupContainerControl();
            inspectorsPopup.Controls.Add(inspectorSelectionControl);
            inspectorSelectionControl.Dock = DockStyle.Fill;
            inspectorsPopupContainerEdit.PopupControl = inspectorsPopup;
            inspectorsPopupContainerEdit.PopupControl.MaximumSize = inspectorsPopup.MaximumSize;

        }

        private void BindCommands()
        {
            var form = this;
            commandManager["Save"].Executor(viewModel.SaveCommand).AttachTo(saveComponentButton).Modifier(form);
            commandManager["NewSave"].Executor(viewModel.NewSaveCommand).AttachTo(newSaveComponentButton);
            commandManager["Deactivate"].Executor(viewModel.DeactivationCommand).AttachTo(deactivated);

            SaveCommand = viewModel.SaveCommand;

            viewModel.SaveCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.NewSaveCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.DeactivationCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;

            commandManager.RefreshVisualState();
        }

        private void componentNumber_EditValueChanged(object sender, EventArgs e)
        {
            this.headerNumberPart = componentNumber.Text;
            viewModel.Number = componentNumber.Text;

            commandManager["NewSave"].RefreshState();
            commandManager["Save"].RefreshState();
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.Type = type.SelectedItem as ComponentType;
            componentParameters.RefreshDataSource();

            commandManager["NewSave"].RefreshState();
            commandManager["Save"].RefreshState();
        }

        private void inspectionHistoryGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            InspectionTestResult inspectionTestResult
                = v.GetRow(e.RowHandle) as InspectionTestResult;

            inspectionTestResult.IsActive = true;
            inspectionTestResult.Part = viewModel.Component;
            inspectionTestResult.Status = PartInspectionStatus.Pending;

            //set order
            inspectionTestResult.Order = viewModel.InspectionTestResultsMaxOrder() + 1;
        }

        private void repositoryInspectionStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value != null)
            {
                PartInspectionStatus result;
                if(Enum.TryParse<PartInspectionStatus>(e.Value.ToString(), out result))
                {
                    e.DisplayText = (result == PartInspectionStatus.Undefined) ? "" : localizedAllInspectionStatus[(int)result - 1];
                }
            }
        }

        private void repositoryInspectionStatus_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;

            if(lookup.ItemIndex != -1)
            {
                lookup.EditValue = (PartInspectionStatus)lookup.ItemIndex + 1;
            }
        }

        private void inspectorsPopupContainerEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
                e.DisplayText = string.Empty;

            IList<Inspector> inspectors = e.Value as IList<Inspector>;
            e.DisplayText = viewModel.FormatInspectorList(inspectors);
        }

        private void inspectorsPopupContainerEdit_Popup(object sender, EventArgs e)
        {
            inspectionHistoryGridView.ClearSelection();
            if(inspectionHistoryGridView.IsValidRowHandle(inspectionHistoryGridView.FocusedRowHandle))
            {
                InspectionTestResult inspectionTestResult
                    = inspectionHistoryGridView.GetRow(inspectionHistoryGridView.FocusedRowHandle) as InspectionTestResult;

                if(inspectionTestResult != null)
                {
                    inspectorSelectionControl.SelectInspectors(inspectionTestResult.Inspectors);
                }
            }
        }

        private void inspectorsPopupContainerEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if(inspectionHistoryGridView.IsValidRowHandle(inspectionHistoryGridView.FocusedRowHandle))
            {
                IList<Inspector> selectedInspectors = inspectorSelectionControl.SelectedInspectors;
                InspectionTestResult inspectionTestResult
                    = inspectionHistoryGridView.GetRow(inspectionHistoryGridView.FocusedRowHandle) as InspectionTestResult;

                if(inspectionTestResult != null)
                {
                    inspectionTestResult.Inspectors.Clear();
                    foreach(Inspector i in selectedInspectors)
                    {
                        inspectionTestResult.Inspectors.Add(i);
                    }
                }
            }
        }

        private void inspectorsPopupContainerEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {

            InspectionTestResult inspectionTestResult
               = inspectionHistoryGridView
               .GetRow(inspectionHistoryGridView.FocusedRowHandle) as InspectionTestResult;

            if(inspectionTestResult == null || (inspectionTestResult != null && inspectionTestResult.Date == null))
            {
                inspectionHistoryGridView.SetColumnError(inspectionHistoryGridView.VisibleColumns[0],
                    Program.LanguageManager.GetString(StringResources.DateFirst));
                e.Cancel = true;
            }
            else
            {
                inspectorSelectionControl.inspectionDate = inspectionTestResult.Date;
            }
        }

        private void inspectionHistoryGridView_KeyDown(object sender, KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<InspectionTestResult>(e, viewModel.InspectionTestResults, (_) => _.IsNew());

            //recalculate order
            if(e.KeyCode == System.Windows.Forms.Keys.Delete && view.IsValidRowHandle(view.FocusedRowHandle))
            {
                viewModel.RecalculateInspectionTestResultsOrder();
                view.RefreshData();
            }

            
        }

        private void ComponentNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        #region IValidatable Members
        bool IValidatable.Validate()
        {
            bool isValidComponent = true;
            for(int i = 0; i < componentParametersView.RowCount; i++)
            {
                if(Convert.ToDecimal(componentParametersView.GetRowCellValue(i, "Diameter")) <= 0)
                {
                    componentParametersView.FocusedRowHandle = i;

                    isValidComponent = componentValidateRow(
                        componentParametersView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, componentParametersView.GetDataRow(i)));
                }
            }

            return dxValidationProvider.Validate() &&
                isValidComponent &&
                viewModel.Component.Connectors
                .Where<Connector>(x => x.Diameter <= 0)
                .Count<Connector>() <= 0;
        }

        #endregion

        private void componentParametersView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            componentValidateRow(sender, e);
        }

        private bool componentValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView gv = sender as GridView;

            var diameter = (float)gv.GetRowCellValue(e.RowHandle, diameterGridColumn);

            if(diameter <= 0)
            {
                gv.SetColumnError(diameterGridColumn,
                    Program.LanguageManager.GetString(StringResources.ComponentNewEdit_DiameterValueValidation));
                e.Valid = false;
            }

            return e.Valid;

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
        private void ValidateInspection(GridView view, string NameColumn, ValidateRowEventArgs e)
        {
            string Name = (string)view.GetRowCellValue(e.RowHandle, NameColumn);

            view.ClearColumnErrors();

            if(String.IsNullOrEmpty(Name))
            {
                view.SetColumnError(inspectorColumn,
                   Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResult));
                e.Valid = false;
            }
        }
        private void inspectionHistoryGridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            InspectionTestResult inspection = view.GetRow(view.FocusedRowHandle) as InspectionTestResult;
            if(inspection.Status != PartInspectionStatus.Pending && inspection.Inspectors.Count <= 0)
            {
                ValidateInspection(inspectionHistoryGridView, inspectorColumn.Name.ToString(), e);
            }
        }

        private void HandleInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void componentParametersView_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if ((view.FocusedColumn.Name == diameterGridColumn.Name || view.FocusedColumn.Name == wallThicknessGridColumn.Name)
                && IsConnected(view, view.FocusedRowHandle))
            {
                e.Cancel = true;
            }
        }

        private bool IsConnected (GridView view, int row)
        {
            GridColumn col = view.Columns["IsConnected"];
            return Convert.ToBoolean(view.GetRowCellValue(row, col));
        }

        private void positiveFloat_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            BindingHelper.CorrectDecimalSeparator(sender, e);
        }
    }
}