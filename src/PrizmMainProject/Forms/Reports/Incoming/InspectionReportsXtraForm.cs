using DevExpress.XtraEditors;
using Prizm.Main.Commands;
using Prizm.Main.Forms.MainChildForm;
using System;

namespace Prizm.Main.Forms.Reports.Incoming
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class InspectionReportsXtraForm : ChildForm
    {
        private InspectionReportsViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();

        public InspectionReportsXtraForm()
        {
            InitializeComponent();
        }
        private void BindToViewModel()
        {
            inspectionReportsBindingSource.DataSource = viewModel;
            startDate.DataBindings.Add("EditValue", inspectionReportsBindingSource, "StartDate");
            endDate.DataBindings.Add("EditValue", inspectionReportsBindingSource, "EndDate");
            previewReportDocument.DataBindings.Add("DocumentSource", inspectionReportsBindingSource, "PreviewSource");
        }

        private void BindCommands()
        {
           commandManager["CreateReport"].Executor(viewModel.CreateCommand).AttachTo(createReportButton);
           commandManager["PreviewReport"].Executor(viewModel.PreviewCommand).AttachTo(previewButton);
        }

        private void InspectionReportsXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (InspectionReportsViewModel)Program.Kernel.GetService(typeof(InspectionReportsViewModel));
            BindToViewModel();
            BindCommands();
            viewModel.StartDate = DateTime.Now.Date;
            viewModel.EndDate = DateTime.Now.Date;
        }

        private void InspectionReportsXtraForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel = null;
        }
    }
}