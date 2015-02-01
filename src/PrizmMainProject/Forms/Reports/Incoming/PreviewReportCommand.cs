using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Reports.Incoming
{
    public class PreviewReportCommand: ICommand
    {
        readonly IMillReportsRepository repo;
        readonly InspectionReportsViewModel viewModel;
        readonly IUserNotify notify;
        DataSet data;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public PreviewReportCommand(InspectionReportsViewModel viewModel, IMillReportsRepository repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            if (viewModel.StartDate > viewModel.EndDate)
            {
                notify.ShowNotify(Program.LanguageManager.GetString(StringResources.Message_FailureReportDate), 
                    Program.LanguageManager.GetString(StringResources.Message_FailureReportDateHeader));
            }
            try
            {
                data = repo.GetPipesFromInspection(viewModel.StartDate, viewModel.EndDate);
                IncomingReportsXtraReport report = new IncomingReportsXtraReport();
                report.DataSource = data;
                report.CreateDocument();
                viewModel.PreviewSource = report;
            }
            catch (RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }

        }

        public bool CanExecute()
        {
            return true;
        }

    }
}
