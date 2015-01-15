﻿using DevExpress.XtraEditors;
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
using System.Text;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.Spool
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class SpoolsXtraForm : ChildForm, INewEditEntityForm
    {
        private Guid id;
        private SpoolViewModel viewModel;
        private Dictionary<PartInspectionStatus, string> inspectionStatusDict
           = new Dictionary<PartInspectionStatus, string>();
        ICommandManager commandManager = new CommandManager();
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        private InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();

        public bool IsMatchedByGuid(Guid id) { return this.id == id; }


        public SpoolsXtraForm(Guid id, string number)
        {
            this.id = id;

            InitializeComponent();
            viewModel = (SpoolViewModel)Program.Kernel.Get<SpoolViewModel>(new ConstructorArgument("id", id));
            viewModel.ModifiableView = this;
            if (number != string.Empty)
            {
                viewModel.SpoolNumber = number;
            }
            SetAlwaysReadOnly(pipeLength);
            if (id == Guid.Empty)
            {
                SetAlwaysEditable(pipeNumber);
            }
            else
            {
                this.Text = Resources.SPOOL_EDIT_FORM_TEXT;
                SetAlwaysReadOnly(pipeNumber); 
            }
            IsEditMode = true;

        }

        public SpoolsXtraForm() : this(Guid.Empty, string.Empty) {  }
        public SpoolsXtraForm(Guid id) : this(id, string.Empty) { }
        public SpoolsXtraForm(string number) : this(Guid.Empty, number) { }

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

            deactivated.DataBindings
                .Add(BindingHelper.CreateCheckEditInverseBinding(
                "EditValue", SpoolBindingSource, "SpoolIsActive"));

            inspectionStatusDict.Clear();
            inspectionStatusDict.Add(PartInspectionStatus.Accepted, Resources.PartInspectionStatus_Accepted);
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
            commandManager["Deactivate"].Executor(viewModel.DeactivateCommand).AttachTo(deactivated);          
            SaveCommand = viewModel.SaveCommand;

            viewModel.DeactivateCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.SaveCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.SearchCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;

            commandManager.RefreshVisualState();
        }

        private void SpoolsXtraForm_Load(object sender, System.EventArgs e)
        {
            BindToViewModel();

            attachmentsButton.Enabled = 
                (!viewModel.IsNew || viewModel.SpoolNumber != String.Empty) 
                &&  ctx.HasAccess(global::Domain.Entity.Security.Privileges.AddAttachments);

            viewModel.PropertyChanged += (s, eve) => IsModified = true;
            IsEditMode =((!viewModel.IsNew || viewModel.SpoolNumber != String.Empty) && viewModel.SpoolIsActive) ;
            BindCommands();
        }

        private void attachmentsButton_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm filesForm = new ExternalFilesXtraForm(viewModel.Spool.Id);
            if (viewModel.FilesFormViewModel == null)
            {
                viewModel.FilesFormViewModel = filesForm.ViewModel;
            }
            else
            {
                filesForm.ViewModel = viewModel.FilesFormViewModel;
            }
            filesForm.ShowDialog();
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

            if (inspectionTestResult == null || (inspectionTestResult != null && inspectionTestResult.Date == null))
            {
                inspectionHistoryGridView.SetColumnError(inspectionHistoryGridView.VisibleColumns[0], Resources.DateFirst);
                e.Cancel = true;
            }
            else
            {
                inspectorSelectionControl.inspectionDate = inspectionTestResult.Date;
            }
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
            spoolLength.Properties.MaxLength = viewModel.Pipe.Length.ToString().Length;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {          
            attachmentsButton.Enabled = ctx.HasAccess(global::Domain.Entity.Security.Privileges.AddAttachments);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            attachmentsButton.Enabled = false;
        }

        private void SpoolsXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }
    }
}