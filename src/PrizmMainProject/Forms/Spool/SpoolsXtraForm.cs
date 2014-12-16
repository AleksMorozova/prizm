using DevExpress.XtraEditors;
using Domain.Entity.Mill;
using PrizmMain.Forms.ExternalFile;
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
            viewModel = (SpoolViewModel)Program.Kernel.GetService(typeof(SpoolViewModel));
            viewModel.ModifiableView = this;
            IsEditMode = true;
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

            pipeNumber.Properties.DataSource = viewModel.allPipes;

        }

        private void BindCommands()
        {
            searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
            cutButton.BindCommand(() => viewModel.CutCommand.Execute(), viewModel.CutCommand);
            saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
        }

        private void SpoolsXtraForm_Load(object sender, System.EventArgs e)
        {
            BindCommands();
            BindToViewModel();

            viewModel.PropertyChanged += (s, eve) => IsModified = true;
            pipeLength.Properties.ReadOnly = true;
        }

        private void cutButton_Click(object sender, System.EventArgs e)
        {
            Domain.Entity.Construction.Spool s = viewModel.Spool;
        }

        private void attachmentsButton_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm attachments = new ExternalFilesXtraForm();
            attachments.ShowDialog();
        }

    }
}