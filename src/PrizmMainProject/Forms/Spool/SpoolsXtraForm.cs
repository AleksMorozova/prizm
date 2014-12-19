using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Ninject.Parameters;
using Prizm.Main.Commands;
using Prizm.Main.Controls;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ninject;

namespace Prizm.Main.Forms.Spool
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class SpoolsXtraForm : ChildForm
    {         
        private SpoolViewModel viewModel;
        private Dictionary<PartInspectionStatus, string> inspectionStatusDict
           = new Dictionary<PartInspectionStatus, string>();
        ICommandManager commandManager = new CommandManager();

        private InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();

        public SpoolsXtraForm(Guid spoolId)
        {
            InitializeComponent();
            viewModel = (SpoolViewModel)Program.Kernel.Get<SpoolViewModel>( new ConstructorArgument("spoolId", spoolId));
            viewModel.ModifiableView = this;
            IsEditMode = false;
            SetAlwaysReadOnly(pipeLength);
        }

        public SpoolsXtraForm () : this(Guid.Empty) { }

        private void BindToViewModel()
        {
            SpoolBindingSource.DataSource = viewModel;

            pipeNumber.DataBindings
                .Add("EditValue", SpoolBindingSource, "PipeNumber");

            pipeLength.DataBindings
                .Add("EditValue", SpoolBindingSource, "PipeLength");

            spoolNumber.DataBindings
                .Add("EditValue", SpoolBindingSource, "SpoolNumber");

            spoolLength.DataBindings
                .Add("EditValue", SpoolBindingSource, "SpoolLength");

            pipeNumber.Properties.DataSource = viewModel.allPipes;

            inspectionHistory.DataBindings
               .Add("DataSource", SpoolBindingSource, "InspectionTestResults");

            inspectionStatusDict.Clear();
            inspectionStatusDict.Add(PartInspectionStatus.Accepted, Resources.Accepted);
            inspectionStatusDict.Add(PartInspectionStatus.Hold, Resources.Hold);
            inspectionStatusDict.Add(PartInspectionStatus.Rejected, Resources.Rejected);
            inspectionStatusDict.Add(PartInspectionStatus.Pending, Resources.Pending);
            resultLookUpEdit.DataSource = inspectionStatusDict;

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
            commandManager["Save"].Executor(viewModel.SaveCommand).AttachTo(saveButton);
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
        }

        private void SpoolsXtraForm_Load(object sender, System.EventArgs e)
        {
            BindCommands();
            BindToViewModel();
            DisableEditModeFalse();
            viewModel.PropertyChanged += (s, eve) => IsModified = true;
            pipeLength.Properties.ReadOnly = true;


        }

        private void cutButton_Click(object sender, System.EventArgs e)
        {
            Prizm.Domain.Entity.Construction.Spool s = viewModel.Spool;
        }

        private void attachmentsButton_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm attachments = new ExternalFilesXtraForm();
            attachments.ShowDialog();
        }

        private void inspectionHistoryGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            InspectionTestResult inspectionTestResult
                = v.GetRow(e.RowHandle) as InspectionTestResult;

            inspectionTestResult.IsActive = true;
            inspectionTestResult.Status = PartInspectionStatus.Pending;
        }

        private void resultLookUpEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;

            if (!(lookup.EditValue is PartInspectionStatus))
            {
                KeyValuePair<PartInspectionStatus, string> val
                    = (KeyValuePair<PartInspectionStatus, string>)lookup.EditValue;
                lookup.EditValue = val.Key;
            }
        }

        private void resultLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value is PartInspectionStatus)
            {
                e.DisplayText = inspectionStatusDict[(PartInspectionStatus)e.Value];
            }
        }

        private void inspectorsPopupContainerEdit_Popup(object sender, System.EventArgs e)
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

        private void inspectorsPopupContainerEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
                e.DisplayText = string.Empty;

            IList<Inspector> inspectors = e.Value as IList<Inspector>;
            e.DisplayText = viewModel.FormatInspectorList(inspectors);
        }

        private void pipeLength_TextChanged(object sender, EventArgs e)
        {
            spoolLength.Properties.MinValue = 1;
            spoolLength.Properties.MaxValue = viewModel.Pipe.Length;
        }

        private void DisableEditModeFalse() 
        {
            spoolNumber.Properties.ReadOnly = true;
            spoolLength.Properties.ReadOnly = true;
            inspectionHistoryGridView.OptionsBehavior.ReadOnly = true;
            saveButton.Enabled = false;
            attachmentsButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            saveButton.Enabled = true;
            attachmentsButton.Enabled = true;
        }
    }
}