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
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class InspectionAddEditXtraForm : PrizmForm
    {
        public InspectionAddEditViewModel viewModel;

        private InspectionAddEditViewModel GetInspectionViewModel(
            IList<PipeTest> tests,
            IList<Inspector> inspectors,
            PipeTestResult current,
            IList<EnumWrapper<PipeTestResultStatus>> statuses)
        {
            if(viewModel == null)
            {
                viewModel = new InspectionAddEditViewModel(tests, inspectors, current, statuses);
            }
            else
            {
                viewModel.SetupViewModelState(tests, inspectors, current, statuses);
            }

            return viewModel;
        }

        public InspectionAddEditXtraForm(IList<PipeTest> tests, IList<Inspector> inspectors, PipeTestResult current, IList<EnumWrapper<PipeTestResultStatus>> statuses)
        {
            InitializeComponent();
            
            this.SetupForm(tests, inspectors, current, statuses);
        }

        public void SetupForm(
            IList<PipeTest> tests,
            IList<Inspector> inspectors,
            PipeTestResult current,
            IList<EnumWrapper<PipeTestResultStatus>> statuses)
        {

            GetInspectionViewModel(tests, inspectors, current, statuses);

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
                code.Properties.ReadOnly = false;
                code.Properties.Items.Clear();
                foreach(var item in viewModel.Tests)
                {
                    code.Properties.Items.Add(item.Code);
                }

                this.Text = "Добавление контрольной операции";
            }
        }


        private void InspectionAddEditXtraForm_Load(object sender, EventArgs e)
        {
            status.Properties.Items.Clear();
            EnumWrapper<PipeTestResultStatus>.LoadItems(status.Properties.Items, skip0: true);

            BindToViewModel();
            inspectors.InspectionDate = viewModel.Date;
            factBool_CheckedChanged(null, null);

            date.SetLimits();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            inspectorsBindingSource.DataSource = viewModel.Inspectors;

            inspectors.DataSource = inspectorsBindingSource;
            inspectors.SelectInspectors(viewModel.SelectInspectors());

            factString.Properties.DataSource = viewModel.CannedMessages;

            code.DataBindings.Add("EditValue", bindingSource, "Code");
            category.DataBindings.Add("EditValue", bindingSource, "Category");
            name.DataBindings.Add("EditValue", bindingSource, "Name");
            expected.DataBindings.Add("EditValue", bindingSource, "Expected");

            status.DataBindings.Add("SelectedIndex", bindingSource, "StatusIndex");
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
                new LocalizedItem(codeLayoutControlItem, StringResources.InspectionAddEdit_CodeLabel.Id),
                new LocalizedItem(categoryLayoutControlItem, StringResources.InspectionAddEdit_CategoryLabel.Id),
                new LocalizedItem(nameLayoutControlItem, StringResources.InspectionAddEdit_NameLabel.Id),
                new LocalizedItem(expectedLayoutControlItem, StringResources.InspectionAddEdit_ExpectedResultLabel.Id),
                new LocalizedItem(factStringLayout, StringResources.InspectionAddEdit_FactStringResultLabel.Id),
                new LocalizedItem(factLimitLayout, StringResources.InspectionAddEdit_FactLimitResultLabel.Id),
                new LocalizedItem(dateLayoutControlItem, StringResources.InspectionAddEdit_DateLabel.Id),
                new LocalizedItem(statusLayoutControlItem, StringResources.InspectionAddEdit_StatusLabel.Id),
                new LocalizedItem(inspectorsLayoutControlItem, StringResources.InspectionAddEdit_InspectorsLabel.Id),

                new LocalizedItem(operationLayoutControlGroup, StringResources.InspectionAddEdit_OperationGroup.Id),
                new LocalizedItem(resultLayoutControlGroup, StringResources.InspectionAddEdit_ResultGroup.Id),
                new LocalizedItem(factStringLayoutControlGroup, StringResources.InspectionAddEdit_FactStringGroup.Id),
                new LocalizedItem(factBoolLayoutControlGroup, StringResources.InspectionAddEdit_FactBoolGroup.Id),
                new LocalizedItem(factDiapasonLayoutControlGroup, StringResources.InspectionAddEdit_FactLimitGroup.Id),

                new LocalizedItem(saveButton, StringResources.InspectionAddEdit_SaveButton.Id),
                new LocalizedItem(cancelButton, StringResources.InspectionAddEdit_CancelButton.Id),

                new LocalizedItem(status, new string [] {StringResources.PipeTestResultStatus_Scheduled.Id, 
                                                         StringResources.PipeTestResultStatus_Accepted.Id,
                                                         StringResources.PipeTestResultStatus_Rejected.Id,
                                                         StringResources.PipeTestResultStatus_Repair.Id}),

                new LocalizedItem(this, localizedHeader, new string[] {StringResources.InspectionAddEdit_Title.Id} )
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
                case PipeTestResultType.Undefined:
                    break;
                default:
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(viewModel.Status != PipeTestResultStatus.Scheduled && inspectors.SelectedInspectors.Count <= 0)
            {
                this.DialogResult = DialogResult.None;
                Program.MainForm.ShowError
                    (Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResult),
                    Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResultHeader)
                    );
            }
            else if(viewModel.Status == PipeTestResultStatus.Accepted
                && viewModel.Operation.Category.Type == FixedCategory.Length
                && string.IsNullOrEmpty(viewModel.FactLimit))
            {
                this.DialogResult = DialogResult.None;
                Program.MainForm.ShowError
                    (Program.LanguageManager.GetString(StringResources.FixedCategoryLengthPassed),
                    Program.LanguageManager.GetString(StringResources.FixedCategoryLengthPassedHeader)
                    );
            }
            else
            {
                SaveInspection();
            }
        }

        private void SaveInspection()
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
                case PipeTestResultType.Undefined:
                    break;
                default:
                    break;
            }
        }

        private void factBool_CheckedChanged(object sender, EventArgs e)
        {
            if(factBool.Checked)
            {
                factBool.Text = " [ " + Program.LanguageManager.GetString(StringResources.Yes) + "] ";
            }
            else
            {
                factBool.Text = " [ " + Program.LanguageManager.GetString(StringResources.No) + " ] ";
            }
        }

        private void InspectionAddEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            code.DataBindings.Clear();
            category.DataBindings.Clear();
            name.DataBindings.Clear();
            expected.DataBindings.Clear();
            status.DataBindings.Clear();
            date.DataBindings.Clear();
            factBool.DataBindings.Clear();
            factString.DataBindings.Clear();
            factLimit.DataBindings.Clear();
        }

        private void InspectionAddEditXtraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult == DialogResult.None)
                e.Cancel = true;
        }

        private void factString_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            var newFactString = factString.Text;
            viewModel.CannedMessages.Add(newFactString);
            factString.EditValue = viewModel.FactString = newFactString;
            e.Handled = true;
        }

        private void date_EditValueChanged(object sender, EventArgs e)
        {
            inspectors.InspectionDate = date.DateTime;
            inspectors.Refresh();
        }
    }
}