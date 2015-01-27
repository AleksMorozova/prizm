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
            
            controlType.Properties.DataSource = viewModel.ControlTypes;
            controlType.Properties.DisplayMember = "Name";
            controlType.Properties.ValueMember = "Value";
            controlType.DataBindings.Add("EditValue", bindingSource, "PipeTestControlType");

            resultType.Properties.DataSource = viewModel.ResultTypes;
            resultType.Properties.DisplayMember = "Name";
            resultType.Properties.ValueMember = "Value";
            resultType.DataBindings.Add("EditValue", bindingSource, "ResultType");

            category.Properties.DataSource = viewModel.CategoryTypes;
            category.DataBindings.Add("EditValue", bindingSource, "Category");
            category.Properties.DisplayMember = "Name";

            boolExpected.DataBindings.Add("EditValue", bindingSource, "BoolExpected");
            minExpected.DataBindings.Add("EditValue", bindingSource, "MinExpected");
            maxExpected.DataBindings.Add("EditValue", bindingSource, "MaxExpected");
        }

        private void ChangeExpected()
        {
            
            boolExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            rangeExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            switch (viewModel.ResultType)
            {
                case PipeTestResultType.Boolean:
                    boolExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case PipeTestResultType.Diapason:
                    rangeExpectedGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case PipeTestResultType.String:
                case PipeTestResultType.Undef:
                    break;
                default:
                    break;
            }
        }

        private void resultType_EditValueChanged(object sender, EventArgs e)
        {
            viewModel.ResultType = (PipeTestResultType)resultType.EditValue;
            ChangeExpected();
        }

        private void ChangeFrequency()
        {
            frequencyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            if (!viewModel.IsRequired)
                frequencyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
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
                //new LocalizedItem(pipeNumberLayout, "NewEditPipe_PipeNumberLabel"),
            };
        }

        #endregion // --- Localization ---
    }
}