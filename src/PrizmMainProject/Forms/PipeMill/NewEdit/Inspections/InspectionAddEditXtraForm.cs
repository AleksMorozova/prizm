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

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public partial class InspectionAddEditXtraForm : XtraForm
    {
        InspectionAddEditViewModel viewModel;

        public InspectionAddEditXtraForm(IList<PipeTest> tests, IList<Inspector> inspectors, PipeTest current)
        {
            InitializeComponent();

            viewModel = new InspectionAddEditViewModel(tests, inspectors, current);
        }

        private void InspectionAddEditXtraForm_Load(object sender, EventArgs e)
        {
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            testsBindingSource.DataSource = viewModel.Tests;
            inspectorsBindingSource.DataSource = viewModel.Inspectors;

            inspectors.DataSource = inspectorsBindingSource;
            code.Properties.DataSource = testsBindingSource;
            category.DataBindings.Add("EditValue", bindingSource, "Category");
            name.DataBindings.Add("EditValue", bindingSource, "Name");
        }

        private void code_EditValueChanged(object sender, EventArgs e)
        {
            var look = sender as GridLookUpEdit;
            var item = look.EditValue as PipeTest;
            viewModel.Test = item;
        }
    }
}