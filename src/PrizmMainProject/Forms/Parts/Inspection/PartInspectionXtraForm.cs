using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Commands;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Properties;
using Prizm.Main.Controls;
using Prizm.Domain.Entity;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Main.Languages;
using Prizm.Main.Documents;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.Parts.Inspection
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class PartInspectionXtraForm : ChildForm
    {
        private PartInspectionViewModel viewModel;
        ICommandManager commandManager = new CommandManager();
        private InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();
        private List<string> localizedAllPartTypes = new List<string>();
        private List<string> localizedAllInspectionStatus = new List<string>();
        private PartType originalPart = PartType.Undefined;
        private void UpdateTextEdit()
        {
            bindingSource.CancelEdit(); // http://stackoverflow.com/questions/14941537/better-way-to-update-bound-controls-when-changing-the-datasource 
        }

        public PartInspectionXtraForm()
        {
            InitializeComponent();
            SetAlwaysEditable(searchNumber);
            SetAlwaysReadOnly(elementNumber);
            SetAlwaysReadOnly(elementType);
            searchNumber.SetAsIdentifier();
            IsEditMode = true;
        }

        private void PartInspectionXtraForm_Load(object sender, EventArgs e)
        {
            foreach (var item in EnumWrapper<PartType>.EnumerateItems())
            {
                localizedAllPartTypes.Add(item.Item2);
            }
            foreach (var item in EnumWrapper<PartInspectionStatus>.EnumerateItems(skip0:true))
            {
                localizedAllInspectionStatus.Add(item.Item2);
            }
            viewModel = (PartInspectionViewModel)Program.Kernel.GetService(typeof(PartInspectionViewModel));
            viewModel.CurrentForm = this;
            viewModel.ModifiableView = this;
            BindCommands();
            BindToViewModel();
            IsEditMode = false;

            repositoryInspectionDateEdit.SetLimits();
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
            commandManager["Save"].Executor(viewModel.SaveInspectionTestResultsCommand).AttachTo(saveButton);
            commandManager["SavaAndClear"].Executor(viewModel.SaveAndClearTestResultsCommand).AttachTo(saveAndClearButton);
            commandManager["Save"].RefreshState();
            commandManager["SavaAndClear"].RefreshState();

            viewModel.SaveInspectionTestResultsCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.SaveAndClearTestResultsCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            searchNumber.DataBindings.Add("Editvalue", bindingSource, "SearchNumber");
            elementNumber.DataBindings.Add("Text", bindingSource, "ElementNumber");

            elementType.DataBindings.Add(
                BindingHelper.CreateOneWayReadToString("Text", bindingSource, "ElementType",
                (value) =>
                {
                    return (string)localizedAllPartTypes[(int)value];
                }));

            inspections.DataBindings.Add("DataSource", bindingSource, "InspectionTestResults");

            inspectorsDataSource.DataSource = viewModel.Inspectors;
            inspectorsDataSource.ListChanged += (s, eve) => IsModified = true;
            inspectorSelectionControl.DataSource = inspectorsDataSource;
            var inspectorsPopup = new PopupContainerControl();
            inspectorsPopup.Controls.Add(inspectorSelectionControl);
            inspectorSelectionControl.Dock = DockStyle.Fill;
            inspectorsPopupContainerEdit.PopupControl = inspectorsPopup;
            inspectorsPopupContainerEdit.PopupControl.MaximumSize = inspectorsPopup.MaximumSize;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(searchNumberLayout, StringResources.PartInspection_SearchNumberLabel.Id),
                new LocalizedItem(elementNumberLayout, StringResources.PartInspection_ElementNumberLabel.Id),
                new LocalizedItem(elementTypeLayout, StringResources.PartInspection_ElementTypeLabel.Id),

                // controls
                new LocalizedItem(searchButton, StringResources.PartInspection_SearchButton.Id),
                new LocalizedItem(saveButton, StringResources.PartInspection_SaveButton.Id),
                new LocalizedItem(saveAndClearButton, StringResources.PartInspection_SaveAndClearButton.Id),

                // grid column headers
                new LocalizedItem(colDate, StringResources.PartInspection_DateColumnHeader.Id),
                new LocalizedItem(colResult, StringResources.PartInspection_ResultColumnHeader.Id),
                new LocalizedItem(colInspector, StringResources.PartInspection_InspectorColumnHeader.Id),
                new LocalizedItem(colReason, StringResources.PartInspection_ReasonColumnHeader.Id),

                // layout control groups
                new LocalizedItem(searchElementGroup, StringResources.PartInspection_SearchGroup.Id),
                new LocalizedItem(inspectionControlGroup, StringResources.PartInspection_IncomingInspectionGroup.Id),

                 // one-way text edit for part types. See data binding for appropriate text edit, to understand the connection.
                    new LocalizedItem(UpdateTextEdit, localizedAllPartTypes,
                        new string [] {StringResources.PartTypeUndefined.Id, StringResources.PartTypePipe.Id, StringResources.PartTypeSpool.Id, StringResources.PartTypeComponent.Id} ),

                new LocalizedItem(resultStatusLookUpEdit, localizedAllInspectionStatus,new string []
                                                                                      {
                                                                                        StringResources.PartInspectionStatus_Pending.Id,
                                                                                        StringResources.PartInspectionStatus_Hold.Id,
                                                                                        StringResources.PartInspectionStatus_Rejected.Id,
                                                                                        StringResources.PartInspectionStatus_Accepted.Id
                                                                                      }),

                
                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.PartInspection_Title.Id} )

            };
        }

        #endregion // --- Localization ---

        private void resultStatusLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                PartInspectionStatus result;
                if (Enum.TryParse<PartInspectionStatus>(e.Value.ToString(), out result))
                {
                    e.DisplayText = (result == PartInspectionStatus.Undefined) ? "" : localizedAllInspectionStatus[(int)result-1];
                }
            }
        }

        private void resultStatusLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {            
            LookUpEdit lookup = sender as LookUpEdit;
            if (lookup.ItemIndex != -1)
            {
                lookup.EditValue = (PartInspectionStatus)lookup.ItemIndex + 1;
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
            inspectionsView.ClearSelection();
            if (inspectionsView.IsValidRowHandle(inspectionsView.FocusedRowHandle))
            {
                InspectionTestResult inspectionTestResult
                    = inspectionsView.GetRow(inspectionsView.FocusedRowHandle) as InspectionTestResult;

                if (inspectionTestResult != null)
                {
                    inspectorSelectionControl.SelectInspectors(inspectionTestResult.Inspectors);
                }
            }
        }

        private void inspectorsPopupContainerEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (inspectionsView.IsValidRowHandle(inspectionsView.FocusedRowHandle))
            {
                IList<Inspector> selectedInspectors = inspectorSelectionControl.SelectedInspectors;
                InspectionTestResult inspectionTestResult
                    = inspectionsView.GetRow(inspectionsView.FocusedRowHandle) as InspectionTestResult;

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

        private void inspectorsPopupContainerEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            InspectionTestResult inspectionTestResult
                = inspectionsView
                .GetRow(inspectionsView.FocusedRowHandle) as InspectionTestResult;

            if (inspectionTestResult == null || (inspectionTestResult != null && inspectionTestResult.Date == null))
            {
                inspectionsView.SetColumnError(inspectionsView.VisibleColumns[0], Program.LanguageManager.GetString(StringResources.DateFirst));
                e.Cancel = true;
            }
            else
            {
                inspectorSelectionControl.inspectionDate = inspectionTestResult.Date;
            }
        }

        private void inspectionsView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            InspectionTestResult inspectionTestResult
                = v.GetRow(e.RowHandle) as InspectionTestResult;

            inspectionTestResult.IsActive = true;
            inspectionTestResult.Status = PartInspectionStatus.Pending;
            inspectionTestResult.Part = viewModel.ConvertedPart;
        }

        private void elementNumber_EditValueChanged(object sender, EventArgs e)
        {
            commandManager["Save"].RefreshState();
            commandManager["SavaAndClear"].RefreshState();
        }

        private void inspectionsView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var gv = sender as GridView;
            var inspResult = gv.GetRow(e.RowHandle) as InspectionTestResult;

            if (inspResult.Inspectors == null || inspResult.Inspectors.Count <= 0)
            {
                gv.SetColumnError(colInspector, Program.LanguageManager.GetString(StringResources.Value_Required));
                e.Valid = false;
            }
        }

    }
}