using DevExpress.XtraReports.UI;
using Prizm.Data.DAL;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    public class CreateRepoCommand: ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CreateRepoCommand));

        readonly IMillReportsRepository repo;
        readonly WeldDateReportViewModel viewModel;
        readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public CreateRepoCommand(
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
            if (viewModel.Data == null || viewModel.Data.Rows.Count <= 0)
                log.Warn( "Construction report: Data Table for Weld by Date report is NULL or empty" );

            var report = new WeldDateXtraReport();

            report.DataSource = viewModel.WeldDateReportDataList;
            var tool = new ReportPrintTool(report);
            tool.AutoShowParametersPanel = false;
            tool.ShowPreview();

            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
