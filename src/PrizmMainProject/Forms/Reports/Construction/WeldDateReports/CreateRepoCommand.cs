using DevExpress.XtraReports.UI;
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
    public class CreateRepoCommand : ICommand
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
            try
            {
                if(Prizm.Main.Common.DateExtension.CheckDiapason(viewModel.WeldDateFrom, viewModel.WeldDateTo))
                {
                    viewModel.Data = repo.GetPipelineElements(viewModel.WeldDateFrom, viewModel.WeldDateTo);
                    if(viewModel.Data == null || viewModel.Data.Rows.Count <= 0)
                        log.Warn("Construction report: Data Table for Weld by Date report is NULL or empty");

                    var report = new WeldDateXtraReport();

                    report.DataSource = viewModel.WeldDateReportDataList;
                    report.FootersVisibility = viewModel.IsFooterVisible;
                    var tool = new ReportPrintTool(report);
                    tool.AutoShowParametersPanel = false;
                    tool.ShowPreview();

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
            catch(RepositoryException ex)
            {
                log.Warn(this.GetType().Name + " | " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
