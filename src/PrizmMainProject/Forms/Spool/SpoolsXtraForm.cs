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
using System.Text;
using Prizm.Main.Security;
using Prizm.Main.Languages;
using Prizm.Main.Common;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

namespace Prizm.Main.Forms.Spool
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class SpoolsXtraForm : ChildForm, INewEditEntityForm
    {
        private SpoolViewModel viewModel;
        private ExternalFilesXtraForm filesForm = null;
        ICommandManager commandManager = new CommandManager();
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();
        private List<string> localizedAllInspectionStatus = new List<string>();
        private InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();

        public bool IsMatchedByGuid(Guid id) { return this.Id == id; }

        public SpoolsXtraForm(Guid id, string number)
        {
            this.Id = id;

            InitializeComponent();
            SetControlsTextLength();
            viewModel = (SpoolViewModel)Program.Kernel.Get<SpoolViewModel>(new ConstructorArgument("id", id));
            viewModel.ModifiableView = this;
            pipeNumber.SetAsLookUpIdentifier();
            spoolNumber.SetAsLookUpIdentifier();
            if(number != string.Empty)
            {
                viewModel.SpoolNumber = number;
            }
            SetAlwaysReadOnly(pipeLength);
            if(id == Guid.Empty)
            {
                SetAlwaysEditable(pipeNumber);
            }
            else
            {
                this.Text = Program.LanguageManager.GetString(StringResources.Spool_EditDocumentHeader);
                SetAlwaysReadOnly(pipeNumber);
            }
            IsEditMode = true;//do not remove until IsEditMode logic is changed
            IsEditMode = ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditSpool);

            CannotOpenForViewing = id == Guid.Empty;

            viewModel.editableForm = this;
            spoolLength.SetMask(Constants.PositiveDigitMask);
            spoolLength.Properties.MinValue = Constants.MinSpoolCut;
            spoolLength.Properties.MaxValue = viewModel.InitPipeLenght - Constants.MinSpoolCut;
        }

        public SpoolsXtraForm() : this(Guid.Empty, string.Empty) { }
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
                "Checked", SpoolBindingSource, "SpoolIsActive"));

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
            foreach(var item in EnumWrapper<PartInspectionStatus>.EnumerateItems(skip0: true))
            {
                localizedAllInspectionStatus.Add(item.Item2);
            }
            BindToViewModel();

            attachmentsButton.Enabled =
                (!viewModel.IsNew || viewModel.SpoolNumber != String.Empty);

            viewModel.PropertyChanged += (s, eve) => IsModified = true;
            IsEditMode = ((this.Id != Guid.Empty || viewModel.SpoolNumber != String.Empty) && viewModel.SpoolIsActive);
            BindCommands();

            inspectionDateEdit.SetLimits();
            spoolNumber.SetAsIdentifier();

            inspectorsGridColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;

            inspectorsPopupContainerEdit.SetSize();
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(pipeNumberLabel, "Spool_PipeNumberLabel"),
                new LocalizedItem(spoolNumberLabel, "Spool_SpoolNumberLabel"),
                new LocalizedItem(pipeNumberLabel, "Spool_PipeNumberLabel"),
                new LocalizedItem(pipelengthLabel, "Spool_PipeLengthLabel"),
                new LocalizedItem(spoonlengthLabel, "Spool_SpoolLengthLabel"),
                
                new LocalizedItem(pipeSearchayoutGroup, "Spool_PipeSearchGroup"),
                new LocalizedItem(spoolLayoutGroup, "Spool_SpoolGroup"),
                new LocalizedItem(layoutlengthGroup, "Spool_LenghtGroup"),
                new LocalizedItem(incomingInspectionLayoutGroup, "Spool_IncomingInspectionGroup"),

                new LocalizedItem(inspectionDateGridColumn, "Spool_InspectionDateColumn"),
                new LocalizedItem(inspectionResultGridColumn, "Spool_InspectionResultColumn"),
                new LocalizedItem(inspectorsGridColumn, "Spool_InspectionInspectorsColumn"),
                new LocalizedItem(reasonGridColumn, "Spool_InspectionReasonColumn"),
                new LocalizedItem(orderGridColumn, "Spool_InspectionOrderColumn"),

                new LocalizedItem(searchButton, "Spool_SearchButton"),
                new LocalizedItem(attachmentsButton, "Spool_AttachButton"),
                new LocalizedItem(saveButton, "Spool_SaveButton"),

                new LocalizedItem(deactivated, "Spool_DeactivatedCheckBox"),
                new LocalizedItem(resultLookUpEdit, localizedAllInspectionStatus,new string []
                                                                                      {
                                                                                        StringResources.PartInspectionStatus_Pending.Id,
                                                                                        StringResources.PartInspectionStatus_Hold.Id,
                                                                                        StringResources.PartInspectionStatus_Rejected.Id,
                                                                                        StringResources.PartInspectionStatus_Accepted.Id
                                                                                      }),
                new LocalizedItem(this, localizedHeader, new string[] {StringResources.SpoolsXtraForm_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void attachmentsButton_Click(object sender, System.EventArgs e)
        {
            if(filesForm == null)
            {
                filesForm = new ExternalFilesXtraForm();
                viewModel.FilesFormViewModel = filesForm.ViewModel;
            }
            viewModel.FilesFormViewModel.RefreshFiles(viewModel.Spool.Id);
            filesForm.SetData(IsEditMode);
            filesForm.ShowDialog();
        }

        private void inspectionHistoryGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            InspectionTestResult inspectionTestResult
                = v.GetRow(e.RowHandle) as InspectionTestResult;

            inspectionTestResult.IsActive = true;
            inspectionTestResult.Part = viewModel.Spool;
            inspectionTestResult.Status = PartInspectionStatus.Pending;

            //set order
            inspectionTestResult.Order = viewModel.InspectionTestResultsMaxOrder() + 1;
        }

        private void resultLookUpEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;

            if(lookup.ItemIndex != -1)
            {
                lookup.EditValue = (PartInspectionStatus)lookup.ItemIndex + 1;
            }
        }

        private void resultLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
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

        private void inspectorsPopupContainerEdit_Popup(object sender, System.EventArgs e)
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
                    Program.LanguageManager.GetString(StringResources.FirstEnterDate));
                e.Cancel = true;
            }
            else
            {
                inspectorSelectionControl.inspectionDate = inspectionTestResult.Date;
            }
        }

        private void inspectorsPopupContainerEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
                e.DisplayText = string.Empty;

            IList<Inspector> inspectors = e.Value as IList<Inspector>;
            e.DisplayText = viewModel.FormatInspectorList(inspectors);
        }

        private void pipeLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            attachmentsButton.Enabled = true;
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

        private void SetControlsTextLength()
        {
            spoolNumber.Properties.MaxLength = LengthLimit.SpoolNumber;

        }

        private void ValidateInspection(GridView view, string NameColumn, ValidateRowEventArgs e)
        {
            string Name = (string)view.GetRowCellValue(e.RowHandle, NameColumn);

            view.ClearColumnErrors();

            if(String.IsNullOrEmpty(Name))
            {
                view.SetColumnError(inspectorsGridColumn,
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
                ValidateInspection(inspectionHistoryGridView, inspectorsGridColumn.Name.ToString(), e);
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
            }

            view.RefreshData();
        }

        private void HandleInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
    }
}