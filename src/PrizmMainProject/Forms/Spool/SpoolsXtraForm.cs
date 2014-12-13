using DevExpress.XtraEditors;
using Domain.Entity.Mill;
using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.Spool
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class SpoolsXtraForm : ChildForm
    {         
        private SpoolViewModel viewModel;

        public SpoolsXtraForm()
        {
            InitializeComponent();
        }

        private void BindToViewModel()
        {
            SpoolBindingSource.DataSource = viewModel;
            pipeNumber.DataBindings
                .Add("EditValue", SpoolBindingSource, "PipeNumber");

           pipeLength.DataBindings
                .Add("EditValue", SpoolBindingSource, "PipeLength");

            spoolNumber.DataBindings
                .Add("EditValue", SpoolBindingSource, "SpoolNumber");


            spoolLength.DataBindings
                .Add("EditValue", SpoolBindingSource, "SpoolLength");

        }

        private void BindCommands()
        {
            searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
            cutButton.BindCommand(() => viewModel.CutCommand.Execute(), viewModel.CutCommand);
        }

        private void SpoolsXtraForm_Load(object sender, System.EventArgs e)
        {
            viewModel = (SpoolViewModel)Program.Kernel.GetService(typeof(SpoolViewModel));
            BindCommands();
            BindToViewModel();
        }

        private void cutButton_Click(object sender, System.EventArgs e)
        {
            Domain.Entity.Construction.Spool s = viewModel.Spool;
            Pipe p = viewModel.Pipe;
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            Pipe p = viewModel.Pipe;
        }
    }
}