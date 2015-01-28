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
        public MillInspectionXtraForm(PipeTest current, IList<EnumWrapper<PipeTestControlType>> controlTypes, IList<EnumWrapper<PipeTestResultType>> resultTypes, BindingList<Category> categoryTypes)
        {
            InitializeComponent();
            viewModel = new MillInspectionViewModel(current, controlTypes, resultTypes, categoryTypes);
            
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
            switch (resultType.SelectedIndex)
            {
                case 0: //PipeTestResultType.Boolean 
                    boolExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case 1: //PipeTestResultType.Diapason
                    rangeExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case 2: //PipeTestResultType.String
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
                  new LocalizedItem(resultType, new  string [] {"MillInspection_ResultTypeBoolean","MillInspection_ResultTypeString", "MillInspection_ResultTypeRange" }),
                  new LocalizedItem(controlType, new  string [] {"MillInspection_ControlTypeWitness","MillInspection_ControlTypeReview", "MillInspection_ControlTypeMonitor", "MillInspection_ControlTypeHold" }),
                  new LocalizedItem(frequencyMeasure, new  string [] {"MillInspection_FrequencyMeasureMeters","MillInspection_FrequencyMeasureTons", "MillInspection_FrequencyMeasurePipes" }),
                  new LocalizedItem(saveButton, "MillInspection_SaveButton"),
                  new LocalizedItem(cancelButton, "MillInspection_CancelButton"),
                  new LocalizedItem(isRequired, "MillInspection_IsRequiredCheckbox"),
                  new LocalizedItem(isActive, "MillInspection_IsActiveCheckbox"),
                  new LocalizedItem(boolExpected, "MillInspection_YesNoExpectedCheckbox"),

                  //layouts
                  new LocalizedItem(codeLayout, "MillInspection_CodeLabel"),
                  new LocalizedItem(operationNameLayout, "MillInspection_NameLabel"),
                  new LocalizedItem(categoryLayout, "MillInspection_CategoryLabel"),
                  new LocalizedItem(resultTypeLayout, "MillInspection_ResultTypeLabel"),
                  new LocalizedItem(controlTypeLayout, "MillInspection_ControlTypeLabel"),
                  new LocalizedItem(minExpectedLayout, "MillInspection_FromLabel"),
                  new LocalizedItem(maxExpectedLayout, "MillInspection_ToLabel"),
                  new LocalizedItem(frequencyLayout, "MillInspection_FrequencyLabel"),
                  new LocalizedItem(frequencyMeasureLayout, "MillInspection_FrequencyMeasureLabel"),

                   // layout control groups
                   new LocalizedItem(rangeExpectedGroup, "MillInspection_RangeControlValueGroup"),
                   new LocalizedItem(boolExpectedGroup, "MillInspection_BoolControlValueGroup"),
                   new LocalizedItem(frequencyGroup, "MillInspection_FrequencyGroup"),
            };
        }
        #endregion // --- Localization ---

        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void resultType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeExpected();
        }
    }
}