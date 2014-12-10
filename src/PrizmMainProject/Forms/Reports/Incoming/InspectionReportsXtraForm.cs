using DevExpress.XtraEditors;

using PrizmMain.Forms.MainChildForm;
using System;

namespace PrizmMain.Forms.Reports.Incoming
{
    public partial class InspectionReportsXtraForm : ChildForm
    {
        private InspectionReportsViewModel viewModel;

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
            createReportButton.BindCommand(() => viewModel.CreateCommand.Execute(), viewModel.CreateCommand);
            previewButton.BindCommand(() => viewModel.PreviewCommand.Execute(), viewModel.PreviewCommand);
        }

        private void InspectionReportsXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (InspectionReportsViewModel)Program.Kernel.GetService(typeof(InspectionReportsViewModel));
            BindToViewModel();
            BindCommands();
            viewModel.StartDate = DateTime.Now.Date;
            viewModel.EndDate = DateTime.Now.Date;
        }
    }
}