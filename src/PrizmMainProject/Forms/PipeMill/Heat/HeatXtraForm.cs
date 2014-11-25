using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ninject;
using Ninject.Parameters;
using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public partial class HeatXtraForm : ChildForm
    {
        private HeatViewModel viewModel;

        public HeatXtraForm() : this("")
        {

        }

        public HeatXtraForm(string heatNumber)
        {
            InitializeComponent();
            viewModel = (HeatViewModel)Program.Kernel.Get<HeatViewModel>(new ConstructorArgument("heatNumber", heatNumber));
        }

        private void HeatXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            //number.DataBindings.Add("EditValue", bindingSource, "Number");

        }

        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
        }

        private void HeatXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }
    }
}