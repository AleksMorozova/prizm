using Prizm.Data.DAL;
using Prizm.Main.Commands;
using Prizm.Main.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    public class PreviewRepoCommand: BaseCommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PreviewRepoCommand));

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

        public override void Execute()
        {
            if (Prizm.Main.Common.DateExtension.CheckDiapason(viewModel.WeldDateFrom, viewModel.WeldDateTo))
            {
                viewModel.Data = repo.GetPipelineElements(viewModel.WeldDateFrom, viewModel.WeldDateTo);
                if (viewModel.Data == null || viewModel.Data.Rows.Count <= 0)
                    log.Warn("Construction report: Data Table for Weld by Date report is NULL or empty");

                var report = new WeldDateXtraReport();

                report.DataSource = viewModel.WeldDateReportDataList;
                report.FootersVisibility = viewModel.IsFooterVisible;
                report.CreateDocument();
                viewModel.PreviewSource = report;

                RefreshVisualStateEvent();
            }
            else
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.Message_FailureReportDate),
                    Program.LanguageManager.GetString(StringResources.Message_FailureReportDateHeader));
                log.Warn("Date limits not valid!" + "Diapason: start date= "
                    + viewModel.WeldDateFrom.ToString() + " end date= " + viewModel.WeldDateTo.ToString());
            }
        }

        public override bool CanExecute()
        {
            return true;
        }
    }
}
