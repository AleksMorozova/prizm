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

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public partial class InspectionAddEditXtraForm : XtraForm
    {
        InspectionAddEditViewModel viewModel;

        public InspectionAddEditXtraForm(IList<PipeTest> tests, IList<Inspector> inspectors, PipeTestResult current, IList<EnumWrapper<PipeTestResultStatus>> statuses)
        {
            InitializeComponent();
            viewModel = new InspectionAddEditViewModel(tests, inspectors, current, statuses);

            date.Properties.NullDate = DateTime.MinValue;
            date.Properties.NullText = string.Empty;

            if(current != null)
            {
                switch(current.Operation.ResultType)
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

            if(current != null)
            {
                code.Properties.ReadOnly = true;
                code.Text = viewModel.Code;
            }
            else
            {
                foreach(var item in viewModel.Tests)
                {
                    code.Properties.Items.Add(item.Code);
                }
            }
            
        }

        private void InspectionAddEditXtraForm_Load(object sender, EventArgs e)
        {
            BindToViewModel();
            status.Text = string.Empty;
            status.EditValue = viewModel.Status;
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
        }

        private void code_EditValueChanged(object sender, EventArgs e)
        {
            var cd = code.EditValue;
            viewModel.ChangeTest(cd.ToString());
        }
    }
}