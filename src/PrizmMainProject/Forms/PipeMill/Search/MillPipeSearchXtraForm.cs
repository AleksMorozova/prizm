using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;

namespace PrizmMain.Forms.PipeMill.Search
{
    public partial class MillPipeSearchXtraForm : XtraForm
    {
        private MillPipeSearchViewModel viewModel;

        public MillPipeSearchXtraForm()
        {
            InitializeComponent();
        }

        private void BindToViewModel()
        {
            MillPipeSearchBindingSource.DataSource = viewModel;
            pipesSearchResult.DataBindings.Add("DataSource", MillPipeSearchBindingSource, "Pipes");

            pipeNumber.DataBindings.Add("EditValue", MillPipeSearchBindingSource, "PipeNumber");

            pipeSize.DataBindings.Add("EditValue", MillPipeSearchBindingSource, "PipeSize");

        }

        private void BindCommands()
        {
            searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
        }

        private void MillPipeSearchXtraForm_Load(object sender, System.EventArgs e)
        {
            viewModel = (MillPipeSearchViewModel)Program.Kernel.GetService(typeof(MillPipeSearchViewModel));

            BindCommands();
            BindToViewModel();
        }




    }
}