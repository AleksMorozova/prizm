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
    public class CreateReportCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CreateReportCommand));

        readonly IMillReportsRepository repo;
        readonly InspectionReportsViewModel viewModel;
        readonly IUserNotify notify;
        DataSet data;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public CreateReportCommand(InspectionReportsViewModel viewModel, IMillReportsRepository repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            if (Prizm.Main.Common.DateExtension.CheckDiapason(viewModel.StartDate, viewModel.EndDate))
            {
                try
                {
                    data = repo.GetPipesFromInspection(viewModel.StartDate, viewModel.EndDate);
                    IncomingReportsXtraReport report = new IncomingReportsXtraReport();
                    SetDataSortByColumn("number");
                    report.DataSource = data;
                    report.FootersVisibility = viewModel.IsFooterVisible;
                    report.CreateDocument();
                    var tool = new ReportPrintTool(report);
                    tool.AutoShowParametersPanel = false;
                    tool.ShowPreview();
                }
                catch (RepositoryException ex)
                {
                    log.Error(string.Concat(ex.InnerException.Message, ex.Message));
                    notify.ShowFailure(ex.InnerException.Message, ex.Message);
                }
            }
            else
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.Message_FailureReportDate),
                    Program.LanguageManager.GetString(StringResources.Message_FailureReportDateHeader));
                log.Warn("Date limits not valid!" + "Diapason: start date= "
                    + viewModel.StartDate.ToString() + " end date= " + viewModel.EndDate.ToString());
            }
        }

        private void SetDataSortByColumn(string columnName)
        {
            foreach (DataTable t in data.Tables)
            {
                foreach (DataColumn column in ((DataTable)t).Columns)
                {
                    if (column.ColumnName == columnName)
                    {
                        t.DefaultView.Sort = column.ColumnName;
                        break;
                    }
                }
            }
        }

        public bool CanExecute()
        {
            return true;
        }

    }
}
