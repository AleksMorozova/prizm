using System;
using System.ComponentModel;

using Ninject.Parameters;
using Ninject;

using DevExpress.XtraEditors;

using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.MainChildForm;

using PrizmMain.DummyData;

namespace PrizmMain.Forms.PipeMill.Search
{
    public partial class MillPipeSearchXtraForm : ChildForm
    {
        private MillPipeSearchViewModel viewModel;

        public MillPipeSearchXtraForm()
        {
            InitializeComponent();
        }

        private void BindToViewModel()
        {
            MillPipeSearchBindingSource.DataSource = viewModel;

            pipesSearchResult.DataBindings
                .Add("DataSource", MillPipeSearchBindingSource, "Pipes");
            pipeNumber.DataBindings
                .Add("EditValue", MillPipeSearchBindingSource, "PipeNumber");
            pipeMillStatus.DataBindings
                .Add("EditValue", MillPipeSearchBindingSource, "PipeMillStatus");
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

        private void pipeRepositoryButtonEdit_Click(object sender, System.EventArgs e)
        {

            int selectedPipe = pipesSearchResultView
                .GetFocusedDataSourceRowIndex();

            var parent = this.MdiParent as PrizmApplicationXtraForm;

            parent.CreateChildForm(
                    typeof(MillPipeNewEditXtraForm),
                    new ConstructorArgument(
                        "pipeId",
                        viewModel.Pipes[selectedPipe].Id));

        }



    }
}