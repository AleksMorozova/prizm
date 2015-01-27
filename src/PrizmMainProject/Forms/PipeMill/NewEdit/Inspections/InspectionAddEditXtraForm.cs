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
using Prizm.Domain.Entity;
using Prizm.Main.Forms.PipeMill.NewEdit.Inspections;
using Prizm.Main.Common;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class InspectionAddEditXtraForm : PrizmForm
    {
        public InspectionAddEditViewModel viewModel;

        public InspectionAddEditXtraForm(IList<PipeTest> tests, IList<Inspector> inspectors, PipeTestResult current, IList<EnumWrapper<PipeTestResultStatus>> statuses)
        {
            InitializeComponent();

            viewModel = new InspectionAddEditViewModel(tests, inspectors, current, statuses);

            date.Properties.NullDate = DateTime.MinValue;
            date.Properties.NullText = string.Empty;

            if(current != null)
            {
                ChangeFact();
                code.Properties.ReadOnly = true;
                code.Text = viewModel.Code;
                this.Text = current.Operation.Code + " - " + current.Operation.Name;
            }
            else
            {
                foreach(var item in viewModel.Tests)
                {
                    code.Properties.Items.Add(item.Code);
                }
                this.Text = "Добавление контрольной операции";
            }

        }

        private void InspectionAddEditXtraForm_Load(object sender, EventArgs e)
        {
            BindToViewModel();
            status.Text = string.Empty;
            status.EditValue = viewModel.Status;

            factBool_CheckedChanged(null, null);
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            inspectorsBindingSource.DataSource = viewModel.Inspectors;

            inspectors.DataSource = inspectorsBindingSource;
            inspectors.SelectInspectors(viewModel.SelectInspectors());

            code.DataBindings.Add("EditValue", bindingSource, "Code");
            category.DataBindings.Add("EditValue", bindingSource, "Category");
            name.DataBindings.Add("EditValue", bindingSource, "Name");
            expected.DataBindings.Add("EditValue", bindingSource, "Expected");

            status.Properties.DataSource = viewModel.statuses;
            status.DataBindings.Add("EditValue", bindingSource, "Status");
            date.DataBindings.Add("EditValue", bindingSource, "Date");

            factBool.DataBindings.Add("Checked", bindingSource, "FactBool");
            factString.DataBindings.Add("EditValue", bindingSource, "FactString");
            factLimit.DataBindings.Add("EditValue", bindingSource, "FactLimit");
        }


        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(codeLayoutControlItem, "InspectionAddEdit_CodeLabel"),
                new LocalizedItem(categoryLayoutControlItem, "InspectionAddEdit_CategoryLabel"),
                new LocalizedItem(nameLayoutControlItem, "InspectionAddEdit_NameLabel"),
                new LocalizedItem(expectedLayoutControlItem, "InspectionAddEdit_ExpectedResultLabel"),
                new LocalizedItem(factStringLayoutControlItem, "InspectionAddEdit_FactStringResultLabel"),
                new LocalizedItem(factBool, "InspectionAddEdit_FactBoolResultLabel"),
                new LocalizedItem(factLimitLayout, "InspectionAddEdit_FactLimitResultLabel"),
                new LocalizedItem(dateLayoutControlItem, "InspectionAddEdit_DateLabel"),
                new LocalizedItem(statusLayoutControlItem, "InspectionAddEdit_StatusLabel"),
                new LocalizedItem(inspectorsLayoutControlItem, "InspectionAddEdit_InspectorsLabel"),

                new LocalizedItem(operationLayoutControlGroup, "InspectionAddEdit_OperationGroup"),
                new LocalizedItem(resultLayoutControlGroup, "InspectionAddEdit_ResultGroup"),
                new LocalizedItem(factStringLayoutControlGroup, "InspectionAddEdit_FactStringGroup"),
                new LocalizedItem(factBoolLayoutControlGroup, "InspectionAddEdit_FactBoolGroup"),
                new LocalizedItem(factDiapasonLayoutControlGroup, "InspectionAddEdit_FactLimitGroup"),

                new LocalizedItem(saveButton, "InspectionAddEdit_SaveButton"),
                new LocalizedItem(cancelButton, "InspectionAddEdit_CancelButton")
            };
        }

        #endregion // --- Localization ---

        private void code_EditValueChanged(object sender, EventArgs e)
        {
            var cd = code.EditValue;
            viewModel.ChangeTest(cd.ToString());
            ChangeFact();
        }

        private void ChangeFact()
        {
            factBoolLayoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            factStringLayoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            factDiapasonLayoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            switch(viewModel.TestResult.Operation.ResultType)
            {
                case PipeTestResultType.Boolean:
                    factBoolLayoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case PipeTestResultType.String:
                    factStringLayoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case PipeTestResultType.Diapason:
                    factDiapasonLayoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case PipeTestResultType.Undef:
                    break;
                default:
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            viewModel.TestResult.Inspectors = inspectors.SelectedInspectors;
            viewModel.TestResult.Status = viewModel.Status;
            if(viewModel.Date != DateTime.MinValue)
            {
                viewModel.TestResult.Date = viewModel.Date;
            }
            switch(viewModel.TestResult.Operation.ResultType)
            {
                case PipeTestResultType.Boolean:
                    viewModel.TestResult.Value = viewModel.FactBool.ToString();
                    break;
                case PipeTestResultType.String:
                    viewModel.TestResult.Value = viewModel.FactString;
                    break;
                case PipeTestResultType.Diapason:
                    viewModel.TestResult.Value = viewModel.FactLimit;
                    break;
                case PipeTestResultType.Undef:
                    break;
                default:
                    break;
            }
        }

        private void factBool_CheckedChanged(object sender, EventArgs e)
        {
            if(factBool.Checked)
            {
                factBool.Text = " [ Да ] ";
            }
            else
            {
                factBool.Text = " [ Нет ] ";
            }
        }
    }
}