using Prizm.Data.DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Mill
{
    public class CreateReportCommand: ICommand 
    {

        readonly IMillReportsRepository repo;
        readonly MillReportsViewModel viewModel;
        readonly IUserNotify notify;
        DataSet data;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };
        
        public CreateReportCommand(MillReportsViewModel viewModel, IMillReportsRepository repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            if (viewModel.StartDate > viewModel.EndDate)
            {
                notify.ShowNotify(Resources.AlertFailureReportDate, Resources.AlertFailureReportDateHeader);
            }
            try
            {
                data = repo.GetPipes(viewModel.StartDate, viewModel.EndDate);
                //data = repo.GetPipesByStatus(viewModel.StartDate, viewModel.EndDate, viewModel.SearchIds, viewModel.SelectedReportType, viewModel.SearchStatuses);
                //MillReportsXtraReport report = new MillReportsXtraReport();
                additionToTheReport report = new additionToTheReport();
                report.DataSource = data;
               
                //report.CalculatedFields[0].DataSource = repo.CountPipeInformation(viewModel.StartDate, viewModel.EndDate);
                report.CreateDocument();
                var tool = new ReportPrintTool(report);
                tool.AutoShowParametersPanel = false;
                tool.ShowPreview();
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
