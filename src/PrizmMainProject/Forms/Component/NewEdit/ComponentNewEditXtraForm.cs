using DevExpress.XtraEditors;
using Ninject.Parameters;
using Ninject;
using PrizmMain.Forms.ExternalFile;
using PrizmMain.Forms.MainChildForm;
using System;
using PrizmMain.Common;
using Domain.Entity.Construction;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using PrizmMain.Properties;
using PrizmMain.Controls;
using System.Windows.Forms;
using Domain.Entity;

namespace PrizmMain.Forms.Component.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class ComponentNewEditXtraForm : ChildForm
    {
        private ComponentNewEditViewModel viewModel;
        private InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();
        private Dictionary<PartInspectionStatus, string> inspectionStatusDict 
            = new Dictionary<PartInspectionStatus, string>();

        public ComponentNewEditXtraForm() : this(Guid.Empty) { }

        public ComponentNewEditXtraForm(Guid componentId)
        {
            InitializeComponent();
            viewModel = (ComponentNewEditViewModel)Program
               .Kernel
               .Get<ComponentNewEditViewModel>(new ConstructorArgument("componentId", componentId));

            viewModel.ModifiableView = this;
            IsEditMode = true;

            #region --- Colouring of required controls ---
            componentNumber.SetRequiredText();
            type.SetRequiredText();
            #endregion //--- Colouring of required controls ---

            #region --- Set Properties.CharacterCasing to Upper ---
            componentNumber.SetAsIdentifier();
            certificateNumber.SetAsIdentifier();
            #endregion //--- Set Properties.CharacterCasing to Upper ---
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm attachments = new ExternalFilesXtraForm();
            attachments.ShowDialog();
        }

        private void ComponentNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();

            viewModel.PropertyChanged += (s, eve) => IsModified = true;

            IsEditMode = !viewModel.IsNotActive;

            IsModified = false;
        }

        private void BindToViewModel()
        {
            componentBindingSource.DataSource = viewModel;

            foreach(var t in viewModel.ComponentTypes)
            {
                type.Properties.Items.Add(t);
            }

            #region   ---- Data Bindings ----
            componentNumber.DataBindings
                .Add("EditValue", componentBindingSource, "Number");

            certificateNumber.DataBindings
                .Add("EditValue", componentBindingSource, "Certificate");

            componentParameters.DataBindings
                .Add("DataSource", componentBindingSource, "Connectors");

            type.DataBindings
                .Add("EditValue", componentBindingSource, "Type");

            componentDeactivated.DataBindings
                .Add("EditValue", componentBindingSource, "IsNotActive");

            componentDeactivated.DataBindings
                .Add("Enabled", componentBindingSource, "CanDeactivateComponent");

            inspectionHistoryGrid.DataBindings
                .Add("DataSource", componentBindingSource, "InspectionTestResults");

            componentLength.DataBindings
                .Add("EditValue", componentBindingSource, "Length");
            #endregion

            inspectionStatusDict.Clear();
            inspectionStatusDict.Add(PartInspectionStatus.Accepted, Resources.Accepted);
            inspectionStatusDict.Add(PartInspectionStatus.Hold, Resources.Hold);
            inspectionStatusDict.Add(PartInspectionStatus.Rejected, Resources.Rejected);
            inspectionStatusDict.Add(PartInspectionStatus.Pending, Resources.Pending);
            repositoryInspectionStatus.DataSource = inspectionStatusDict;

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
            saveComponentButton
                .BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
            
            newSaveComponentButton
                .BindCommand(() => viewModel.NewSaveCommand.Execute(), viewModel.NewSaveCommand);

            SaveCommand = viewModel.SaveCommand;
        }

        private void componentNumber_EditValueChanged(object sender, EventArgs e)
        {
            this.headerNumberPart = componentNumber.Text;
            viewModel.Number = componentNumber.Text;
            viewModel.SaveCommand.IsExecutable ^= true;
            viewModel.NewSaveCommand.IsExecutable ^= true;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.Type = type.SelectedItem as ComponentType;
            viewModel.SaveCommand.IsExecutable ^= true;
            viewModel.NewSaveCommand.IsExecutable ^= true;
            componentParameters.RefreshDataSource();
        }

        private void componentDeactivated_Modified(object sender, EventArgs e)
        {
            viewModel.IsNotActive = (bool)componentDeactivated.EditValue;

            if (viewModel.IsNotActive)
            {
                viewModel.DeactivationCommand.Execute();
                IsEditMode = false;
            }
        }

        private void inspectionHistoryGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            InspectionTestResult inspectionTestResult
                = v.GetRow(e.RowHandle) as InspectionTestResult;

            inspectionTestResult.IsActive = true;
            inspectionTestResult.Status = PartInspectionStatus.Pending;
        }

        private void repositoryInspectionStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value is PartInspectionStatus)
            {
                e.DisplayText = inspectionStatusDict[(PartInspectionStatus)e.Value];
            }
        }

        private void repositoryInspectionStatus_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;

            if (!(lookup.EditValue is PartInspectionStatus))
            {
                KeyValuePair<PartInspectionStatus, string> val 
                    = (KeyValuePair<PartInspectionStatus, string>)lookup.EditValue;
                lookup.EditValue = val.Key;
            }
        }

        private void inspectorsPopupContainerEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
                e.DisplayText = string.Empty;

            IList<Inspector> inspectors = e.Value as IList<Inspector>;
            e.DisplayText = viewModel.FormatInspectorList(inspectors);
        }

        private void inspectorsPopupContainerEdit_Popup(object sender, EventArgs e)
        {
            inspectionHistoryGridView.ClearSelection();
            if (inspectionHistoryGridView.IsValidRowHandle(inspectionHistoryGridView.FocusedRowHandle))
            {
                InspectionTestResult inspectionTestResult
                    = inspectionHistoryGridView.GetRow(inspectionHistoryGridView.FocusedRowHandle) as InspectionTestResult;

                if (inspectionTestResult != null)
                {
                    inspectorSelectionControl.SelectInspectors(inspectionTestResult.Inspectors);
                }
            }
        }

        private void inspectorsPopupContainerEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (inspectionHistoryGridView.IsValidRowHandle(inspectionHistoryGridView.FocusedRowHandle))
            {
                IList<Inspector> selectedInspectors = inspectorSelectionControl.SelectedInspectors;
                InspectionTestResult inspectionTestResult 
                    = inspectionHistoryGridView.GetRow(inspectionHistoryGridView.FocusedRowHandle) as InspectionTestResult;

                if (inspectionTestResult != null)
                {
                    inspectionTestResult.Inspectors.Clear();
                    foreach (Inspector i in selectedInspectors)
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

            if (inspectionTestResult == null)
                e.Cancel = true;
        }
    }
}