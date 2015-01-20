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
using Prizm.Domain.Entity.Mill;
using System.ComponentModel;

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
                if (viewModel.SelectedReportType == ReportType.ByProducing)
                {
                    data = repo.GetPipes(viewModel.StartDate, viewModel.EndDate);
                    AdditionToTheReport report = new AdditionToTheReport();
                    BindingList<double> counts = repo.CountPipe(viewModel.StartDate, viewModel.EndDate);
                    report.PipesCount = counts[0];
                    report.PipesLength = counts[1];
                    report.PipesWeight = counts[2];
                    report.DataSource = data;
                    report.CreateDocument();
                    var tool = new ReportPrintTool(report);
                    tool.AutoShowParametersPanel = false;
                    tool.ShowPreview();
                }
                else if (viewModel.SelectedReportType == ReportType.General)
                {
                    data = repo.CountWeldInf(viewModel.StartDate, viewModel.EndDate);
                    GeneralInformationXtraReport report = new GeneralInformationXtraReport();
                    report.DataSource = data;
                    report.CreateDocument();
                    var tool = new ReportPrintTool(report);
                    tool.AutoShowParametersPanel = false;
                    tool.ShowPreview();
                }
                else
                {
                    data = repo.GetPipesByStatus(viewModel.StartDate, viewModel.EndDate, viewModel.SearchIds, viewModel.SelectedReportType, viewModel.SearchStatuses);
                    MillReportsXtraReport report = new MillReportsXtraReport();
                    report.DataSource = data;
                    report.CreateDocument();
                    var tool = new ReportPrintTool(report);
                    tool.AutoShowParametersPanel = false;
                    tool.ShowPreview();
                }
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
