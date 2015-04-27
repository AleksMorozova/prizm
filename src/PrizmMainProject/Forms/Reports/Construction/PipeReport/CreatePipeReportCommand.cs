using DevExpress.XtraReports.UI;
using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction.PipeReport
{
    public class CreatePipeReportCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CreatePipeReportCommand));

        readonly IMillReportsRepository repo;
        readonly PipeConstractionReportViewModel viewModel;
        readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public CreatePipeReportCommand(
            PipeConstractionReportViewModel viewModel,
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
                viewModel.Data = repo.GetPipelineElements(
                    viewModel.PipeNumber,
                    viewModel.CheckedPipeTypes.Select<PipeMillSizeType, string>(x => x.Type).ToArray<string>());

                if(viewModel.Data == null || viewModel.Data.Rows.Count <= 0)
                    log.Warn(string.Format("Data Table for Pipe Report (pipe #{0}) report is NULL or empty", viewModel.PipeNumber));

                var report = new PipeConstructionXtraReport();

                report.DataSource = viewModel.PipeReportDataList;
                report.FootersVisibility = viewModel.IsFooterVisible;
                var tool = new ReportPrintTool(report);
                tool.AutoShowParametersPanel = false;
                tool.ShowPreview();

                RefreshVisualStateEvent();
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
