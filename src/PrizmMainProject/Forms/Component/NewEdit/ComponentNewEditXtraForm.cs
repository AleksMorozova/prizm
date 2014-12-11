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

namespace PrizmMain.Forms.Component.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class ComponentNewEditXtraForm : ChildForm
    {
        private ComponentNewEditViewModel viewModel;
        private Dictionary<PieceInspectionStatus, string> inspectionStatusDict 
            = new Dictionary<PieceInspectionStatus, string>();

        public ComponentNewEditXtraForm() : this(Guid.Empty) { }

        public ComponentNewEditXtraForm(Guid componentId)
        {
            InitializeComponent();
            viewModel = (ComponentNewEditViewModel)Program
               .Kernel
               .Get<ComponentNewEditViewModel>(new ConstructorArgument("componentId", componentId));
            viewModel.ModifiableView = this;

            componentNumber.SetRequiredText();

            type.SetRequiredText();
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
            #endregion

            inspectionStatusDict.Clear();
            inspectionStatusDict.Add(PieceInspectionStatus.Accepted, Resources.Accepted);
            inspectionStatusDict.Add(PieceInspectionStatus.Hold, Resources.Hold);
            inspectionStatusDict.Add(PieceInspectionStatus.Rejected, Resources.Rejected);
            inspectionStatusDict.Add(PieceInspectionStatus.Pending, Resources.Pending);
            repositoryInspectionStatus.DataSource = inspectionStatusDict;
            
        }

        private void BindCommands()
        {
            saveComponentButton
                .BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
            
            newSaveComponentButton
                .BindCommand(() => viewModel.NewSaveCommand.Execute(), viewModel.NewSaveCommand);
        }

        private void componentNumber_EditValueChanged(object sender, EventArgs e)
        {
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
            inspectionTestResult.Status = PieceInspectionStatus.Pending;
        }

        private void repositoryInspectionStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value is PieceInspectionStatus)
            {
                e.DisplayText = inspectionStatusDict[(PieceInspectionStatus)e.Value];
            }
        }

        private void repositoryInspectionStatus_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;

            if (!(lookup.EditValue is PieceInspectionStatus))
            {
                KeyValuePair<PieceInspectionStatus, string> val 
                    = (KeyValuePair<PieceInspectionStatus, string>)lookup.EditValue;
                lookup.EditValue = val.Key;
            }
        }

    }
}