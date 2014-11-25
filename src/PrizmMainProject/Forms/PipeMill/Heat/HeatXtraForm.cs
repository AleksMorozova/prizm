using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ninject;
using Ninject.Parameters;
using PrizmMain.Forms.MainChildForm;
using System.Linq;

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
            number.Properties.DataSource = viewModel.AllHeats;
            //number.DataBindings.Add("EditValue", bindingSource, "Heat");
            steelGrade.DataBindings.Add("EditValue", bindingSource, "Steel");

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

        private void number_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (viewModel.AllHeats.Where(x => x.Number.Equals(number.Text)) != null)
            {
                viewModel.GetHeatByNumber(number.Text);
            }
            else
            {
                viewModel.NewHeat(number.Text);
            }
        }

        private void number_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
                viewModel.NewHeat(number.Text);
        }
    }
}