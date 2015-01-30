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

namespace Prizm.Main.Forms.Settings.Inspections
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class MillInspectionXtraForm : PrizmForm
    {
        public MillInspectionViewModel viewModel;
        public MillInspectionXtraForm(PipeTest current, BindingList<Category> categoryTypes)
        {
            InitializeComponent();
            viewModel = new MillInspectionViewModel(current, categoryTypes);
            SetControlsTextLength();
            ChangeExpected();
            ChangeFrequency();
            if (current != null)
            {
                this.Text = current.Name;
            }
        }

        private void boolExpected_CheckedChanged(object sender, EventArgs e)
        {
            if (boolExpected.Checked)
            {
                boolExpected.Text = " [ "+ Resources.YES +" ] ";
            }
            else
            {
                boolExpected.Text = " [ " + Resources.NO + " ] ";
            }
        }

        private void MillInspectionXtraForm_Load(object sender, EventArgs e)
        {
            foreach (var item in EnumWrapper<PipeTestResultType>.EnumerateItems(skip0: true))
            {
                resultType.Properties.Items.Add(item.Item2);
            }
            foreach (var item in EnumWrapper<PipeTestControlType>.EnumerateItems(skip0: true))
            {
                controlType.Properties.Items.Add(item.Item2);
            }
            foreach (var item in EnumWrapper<FrequencyMeasure>.EnumerateItems(skip0: true))
            {
                frequencyMeasure.Properties.Items.Add(item.Item2);
            }
            BindToViewModel();
            boolExpected_CheckedChanged(null, null);
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            code.DataBindings.Add("EditValue", bindingSource, "Code");
            operationName.DataBindings.Add("EditValue", bindingSource, "Name");
            isRequired.DataBindings.Add("EditValue", bindingSource, "IsRequired");
            isActive.DataBindings.Add("EditValue", bindingSource, "IsActive");

            controlType.DataBindings.Add("SelectedIndex", bindingSource, "ControlTypeIndex");
            resultType.DataBindings.Add("SelectedIndex", bindingSource, "ResultTypeIndex");
            frequencyMeasure.DataBindings.Add("SelectedIndex", bindingSource, "FrequencyMeasureIndex");

            category.Properties.DataSource = viewModel.CategoryTypes;
            category.DataBindings.Add("EditValue", bindingSource, "Category");
            category.Properties.DisplayMember = "Name";

            boolExpected.DataBindings.Add("EditValue", bindingSource, "BoolExpected");
            minExpected.DataBindings.Add("EditValue", bindingSource, "MinExpected");
            maxExpected.DataBindings.Add("EditValue", bindingSource, "MaxExpected");
            frequency.DataBindings.Add("EditValue", bindingSource, "FrequencyQuantaty");
      
        }

        private void ChangeExpected()
        {
            
            boolExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            rangeExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            switch ((PipeTestResultType)resultType.SelectedIndex+1)
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

        private void ChangeFrequency()
        {
            frequencyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            if (!viewModel.IsRequired)
            {
                frequencyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                if (viewModel.PipeTest.Frequency == null)
                    viewModel.PipeTest.Frequency = new PipeTestFrequency();
            }
            else
            {
                viewModel.PipeTest.Frequency = null;
            }
        }

        private void isRequired_CheckedChanged(object sender, EventArgs e)
        {
            viewModel.IsRequired = isRequired.Checked;
            ChangeFrequency();
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
                  new LocalizedItem(saveButton, StringResources.MillInspection_SaveButton.Id),
                  new LocalizedItem(cancelButton, StringResources.MillInspection_CancelButton.Id),
                  new LocalizedItem(isRequired, StringResources.MillInspection_IsRequiredCheckbox.Id),
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

                   // layout control groups
                   new LocalizedItem(rangeExpectedGroup, StringResources.MillInspection_RangeControlValueGroup.Id),
                   new LocalizedItem(boolExpectedGroup, StringResources.MillInspection_BoolControlValueGroup.Id),
                   new LocalizedItem(frequencyGroup, StringResources.MillInspection_FrequencyGroup.Id),
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
    }
}