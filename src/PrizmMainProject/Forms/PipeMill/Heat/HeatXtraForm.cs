using DevExpress.XtraEditors;
using Ninject;
using Ninject.Parameters;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public partial class HeatXtraForm : XtraForm
    {
        private HeatViewModel viewModel;

        public HeatXtraForm(string heatNumber)
        {
            InitializeComponent();
            viewModel = (HeatViewModel)Program.Kernel.Get<HeatViewModel>(new ConstructorArgument("heatNumber", heatNumber));
        }

        private void HeatXtraForm_Load(object sender, System.EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            number.DataBindings.Add("EditValue", bindingSource, "Number");
            steel.DataBindings.Add("EditValue", bindingSource, "SteelGrade");
        }

        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
        }

        private void HeatXtraForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }
    }
}