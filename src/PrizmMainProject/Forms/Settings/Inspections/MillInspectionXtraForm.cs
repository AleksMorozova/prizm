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
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Common;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Properties;
using Prizm.Main.Documents;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Prizm.Main.Forms.Settings.Inspections
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class MillInspectionXtraForm : PrizmForm, IValidatable
    {
        public MillInspectionViewModel viewModel;
        IReadOnlyList<PipeTest> pipeTestList;

        public MillInspectionXtraForm(PipeTest current, BindingList<Category> categoryTypes, IReadOnlyList<PipeTest> pipeTestList)
        {
            InitializeComponent();
            this.SetupForm(current, categoryTypes, pipeTestList);
        }

        private MillInspectionViewModel GetInspectionViewModel(PipeTest current, BindingList<Category> categoryTypes)
        {
            if(viewModel == null)
            {
                viewModel = new MillInspectionViewModel(current, categoryTypes, pipeTestList);
            }
            else
            {
                viewModel.SetupViewModel(current, categoryTypes, pipeTestList);
            }

            return viewModel;
        }
        public void SetupForm(PipeTest current, BindingList<Category> categoryTypes, IReadOnlyList<PipeTest> pipeTestList)
        {
            this.pipeTestList = pipeTestList;
            viewModel = this.GetInspectionViewModel(current, categoryTypes);
            SetControlsTextLength();
            ChangeExpected();
            ChangeFrequency();
            if(current != null)
            {
                this.Text = current.Name;
            }
        }

        private void boolExpected_CheckedChanged(object sender, EventArgs e)
        {
            if(boolExpected.Checked)
            {
                boolExpected.Text = " [ " + Program.LanguageManager.GetString(StringResources.Yes) + " ] ";
            }
            else
            {
                boolExpected.Text = " [ " + Program.LanguageManager.GetString(StringResources.No) + " ] ";
            }
        }

        private void MillInspectionXtraForm_Load(object sender, EventArgs e)
        {
            resultType.Properties.Items.Clear();
            controlType.Properties.Items.Clear();
            frequencyMeasure.Properties.Items.Clear();
            frequencyType.Properties.Items.Clear();
            resultType.SelectedIndex = -1;
            controlType.SelectedIndex = -1;

            EnumWrapper<PipeTestResultType>.LoadItems(resultType.Properties.Items, skip0: true);
            EnumWrapper<PipeTestControlType>.LoadItems(controlType.Properties.Items, skip0: true);
            EnumWrapper<FrequencyMeasure>.LoadItems(frequencyMeasure.Properties.Items, skip0: true);
            EnumWrapper<InspectionFrequencyType>.LoadItems(frequencyType.Properties.Items);

            BindToViewModel();
            boolExpected_CheckedChanged(null, null);

            code.SetAsIdentifier();
            code.SetRequiredText();
            operationName.SetRequiredText();
            controlType.SetRequiredCombo();
            frequencyMeasure.SetRequiredCombo();
            resultType.SetRequiredCombo();
            percentOfSelect.SetRequiredText();


            CheckFixedResultType(viewModel.Category);
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            code.DataBindings.Add("EditValue", bindingSource, "Code");
            operationName.DataBindings.Add("EditValue", bindingSource, "Name");
            isActive.DataBindings.Add("EditValue", bindingSource, "IsActive");
            percentOfSelect.DataBindings.Add("EditValue", bindingSource, "SelectivePercent");
            controlType.DataBindings.Add("SelectedIndex", bindingSource, "ControlTypeIndex");
            resultType.DataBindings.Add("SelectedIndex", bindingSource, "ResultTypeIndex");
            frequencyMeasure.DataBindings.Add("SelectedIndex", bindingSource, "FrequencyMeasureIndex");
            frequencyType.DataBindings.Add("SelectedIndex", bindingSource, "FrequencyTypeIndex");

            category.Properties.DataSource = viewModel.CategoryTypes;
            category.DataBindings.Add("EditValue", bindingSource, "Category");
            category.Properties.DisplayMember = "Name";

            boolExpected.DataBindings.Add("EditValue", bindingSource, "BoolExpected");
            minExpected.DataBindings.Add("EditValue", bindingSource, "MinExpected");
            maxExpected.DataBindings.Add("EditValue", bindingSource, "MaxExpected");
            frequency.DataBindings.Add("EditValue", bindingSource, "FrequencyQuantaty");

            repeatedInspectionsLookUp.Properties
                .DataSource = pipeTestList.Where<PipeTest>(x => 
                    x.IsActive
                    && x.IsReadyToUse);

            repeatedOperationsGrid.DataSource = viewModel.PipeTest.RepeatedInspections;
        }

        private void ChangeExpected()
        {

            boolExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            rangeExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            switch((PipeTestResultType)resultType.SelectedIndex + 1)
            {
                case PipeTestResultType.Boolean:
                    boolExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case PipeTestResultType.Diapason:
                    rangeExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case PipeTestResultType.String:
                    break;
                default:
                    break;
            }
        }


        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                //controls
                // TODO: care about data binding by Text (grids)
                  new LocalizedItem(resultType, new  string [] {StringResources.TestResultTypeBoolean.Id, StringResources.TestResultTypeRange.Id, StringResources.TestResultTypeString.Id }),
                  new LocalizedItem(controlType, new  string [] {StringResources.ControlTypeWitness.Id, StringResources.ControlTypeReview.Id, StringResources.ControlTypeMonitor.Id, StringResources.ControlTypeHold.Id }),
                  new LocalizedItem(frequencyMeasure, new  string [] {StringResources.MillInspection_FrequencyMeasureMeters.Id, StringResources.MillInspection_FrequencyMeasureTons.Id, StringResources.MillInspection_FrequencyMeasurePipes.Id }),
                  new LocalizedItem(frequencyType, new string [] {StringResources.InspectionFrequencyType_Required.Id, StringResources.InspectionFrequencyType_Recurring.Id, StringResources.InspectionFrequencyType_Selective.Id}),
                  new LocalizedItem(saveButton, StringResources.MillInspection_SaveButton.Id),
                  new LocalizedItem(cancelButton, StringResources.MillInspection_CancelButton.Id),
                  new LocalizedItem(isActive, StringResources.MillInspection_IsActiveCheckbox.Id),
                  new LocalizedItem(boolExpected, StringResources.MillInspection_YesNoExpectedCheckbox.Id),

                  //layouts
                  new LocalizedItem(codeLayout, StringResources.MillInspection_CodeLabel.Id),
                  new LocalizedItem(operationNameLayout, StringResources.MillInspection_NameLabel.Id),
                  new LocalizedItem(categoryLayout, StringResources.MillInspection_CategoryLabel.Id),
                  new LocalizedItem(resultTypeLayout, StringResources.MillInspection_ResultTypeLabel.Id),
                  new LocalizedItem(controlTypeLayout, StringResources.MillInspection_ControlTypeLabel.Id),
                  new LocalizedItem(minExpectedLayout, StringResources.MillInspection_FromLabel.Id),
                  new LocalizedItem(maxExpectedLayout, StringResources.MillInspection_ToLabel.Id),
                  new LocalizedItem(frequencyLayout, StringResources.MillInspection_FrequencyLabel.Id),
                  new LocalizedItem(frequencyMeasureLayout, StringResources.MillInspection_FrequencyMeasureLabel.Id),
                  new LocalizedItem(frequencyTypeLayout, StringResources.MillInspection_FrequencyTypeLayout.Id),
                  new LocalizedItem(percentOfSelectLayout, StringResources.MillInspection_PercentOfSelectLayout.Id),

                  //grid columns
                  new LocalizedItem(inspectionCodeGridColumn, StringResources.MillInspection_CodeGridColumn.Id),
                  new LocalizedItem(inspectionNameGridColumn, StringResources.MillInspection_NameGridColumn.Id),

                   // layout control groups
                   new LocalizedItem(rangeExpectedGroup, StringResources.MillInspection_RangeControlValueGroup.Id),
                   new LocalizedItem(boolExpectedGroup, StringResources.MillInspection_BoolControlValueGroup.Id),
                   new LocalizedItem(frequencyGroup, StringResources.MillInspection_FrequencyGroup.Id),
                   new LocalizedItem(operationFrequencyGroup,StringResources.MillInspection_OperationFrequencyGroup.Id),
                   new LocalizedItem(selectiveFrequencyGroup, StringResources.MillInspection_SelectiveFrequencyGroup.Id),
                   new LocalizedItem(repeatedInspectionsLayoutControlGroup, StringResources.MillInspection_RepeatedOperationsLabel.Id),

                   //btn
                   new LocalizedItem(btnAdd, StringResources.MillInspection_BtnAdd.Id),
                   new LocalizedItem(btnRemove, StringResources.MillInspection_BtnRemove.Id),


                   new LocalizedItem(this, localizedHeader, new string[] {StringResources.MillInspection_Title.Id} )
            };
        }
        #endregion // --- Localization ---

        private void resultType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeExpected();
        }

        private void SetControlsTextLength()
        {
            code.Properties.MaxLength = LengthLimit.MaxPipeTestCode;
            operationName.Properties.MaxLength = LengthLimit.MaxPipeTestName;
        }

        private void MillInspectionXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            code.DataBindings.Clear();
            operationName.DataBindings.Clear();
            isActive.DataBindings.Clear();

            controlType.DataBindings.Clear();
            resultType.DataBindings.Clear();
            frequencyMeasure.DataBindings.Clear();
            frequencyType.DataBindings.Clear();
            percentOfSelect.DataBindings.Clear();
            category.DataBindings.Clear();

            boolExpected.DataBindings.Clear();
            minExpected.DataBindings.Clear();
            maxExpected.DataBindings.Clear();
            frequency.DataBindings.Clear();
        }


        private void MillInspectionXtraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (!((IValidatable)this).Validate())
                {
                   e.Cancel = true;
                }
            }
        }

        bool IValidatable.Validate()
        {
            bool validated = true;
            if (pipeTestList.Where(g => g.Code == viewModel.Code && g.Id != viewModel.PipeTest.Id).Count() >= 1)
            {
                string msg = string.Concat(Program.LanguageManager.GetString(StringResources.Inspection_ExistingCodeError), viewModel.Code);
                string header = Program.LanguageManager.GetString(StringResources.Inspection_ExistingCodeErrorHeader);
                Program.MainForm.ShowError(msg, header);
                validated = false;
            }
            return validated && dxValidationProvider.Validate();
        }


        private ValidationRuleBase savedRecurringRule = null;
        private ValidationRuleBase savedSelectiveRule = null;

        private ValidationRuleBase CheckCreateNotBlankRule(ValidationRuleBase rule)
        {
            if (rule == null)
            {
                ConditionValidationRule newRule = new ConditionValidationRule();
                newRule.ConditionOperator = ConditionOperator.IsNotBlank;
                newRule.ErrorText = Program.LanguageManager.GetString(StringResources.Validation_ValueRequired);
                newRule.ErrorType = ErrorType.Critical;
                rule = newRule;
            }
            return rule;
        }

        private void ChangeFrequency()
        {
            frequencyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            selectiveFrequencyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            dxValidationProvider.SetValidationRule(frequencyMeasure, null);
            dxValidationProvider.SetValidationRule(percentOfSelect, null);

            InspectionFrequencyType selectedFrequency = (InspectionFrequencyType)frequencyType.SelectedIndex;

            switch (selectedFrequency)
            {
                case InspectionFrequencyType.R:
                    viewModel.PipeTest.Frequency = null;
                    break;
                case InspectionFrequencyType.S:
                    selectiveFrequencyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    savedSelectiveRule = CheckCreateNotBlankRule(savedSelectiveRule);
                    dxValidationProvider.SetValidationRule(percentOfSelect, savedSelectiveRule);
                    break;
                case InspectionFrequencyType.U:
                    frequencyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    if (viewModel.PipeTest.Frequency == null)
                        viewModel.PipeTest.Frequency = new PipeTestFrequency();

                    savedRecurringRule = CheckCreateNotBlankRule(savedRecurringRule);
                    dxValidationProvider.SetValidationRule(frequencyMeasure, savedRecurringRule);
                    break;
                default: 
                    break;
            }
        }

        private void frequencyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFrequency();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var pipeTest = repeatedInspectionsLookUp.EditValue as PipeTest;

            if (pipeTest != null && !viewModel.PipeTest.RepeatedInspections.Contains(pipeTest))
            {
                viewModel.PipeTest.RepeatedInspections.Add(pipeTest);
                repeatedOperationsGrid.RefreshDataSource();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var pipeTest = repeatedOperationsView.GetFocusedRow() as PipeTest;

            if (pipeTest != null)
            {
                viewModel.PipeTest.RepeatedInspections.Remove(pipeTest);
                repeatedOperationsGrid.RefreshDataSource();
            }
        }

        private void repeatedOperationsView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var view = sender as GridView;

            var pipeTest = view.GetRow(e.RowHandle) as PipeTest;

            if (pipeTest != null && !pipeTest.IsActive)
            {
                e.Appearance.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Result type should be disabled and of appropriate value for some categories
        /// </summary>
        private void CheckFixedResultType(Category c)
        {
            if (c != null && c.Fixed && c.Type == FixedCategory.Length)
            {
                viewModel.ResultType = PipeTestResultType.Diapason;
                resultType.ReadOnly = true;
            }
            else
            {
                resultType.ReadOnly = false;
            }
        }

        /// <summary>
        /// After category has been chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void category_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            Category c = e.Value as Category;
            CheckFixedResultType(c);
        }

    }
}