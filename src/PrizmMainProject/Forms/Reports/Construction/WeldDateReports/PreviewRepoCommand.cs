using Prizm.Data.DAL;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    public class PreviewRepoCommand: ICommand
    {
        readonly IMillReportsRepository repo;
        readonly WeldDateReportViewModel viewModel;
        readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public PreviewRepoCommand(
            WeldDateReportViewModel viewModel, 
            IMillReportsRepository repo, 
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            viewModel.Data = repo.GetPipelineElements(viewModel.WeldDateFrom, viewModel.WeldDateTo);

            var report = new WeldDateXtraReport();

            report.DataSource = viewModel.WeldDateReportDataList;
            report.CreateDocument();
            viewModel.PreviewSource = report;

            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
