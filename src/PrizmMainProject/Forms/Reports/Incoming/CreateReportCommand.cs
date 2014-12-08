using Data.DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using PrizmMain.Commands;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Reports.Incoming
{
    public class CreateReportCommand : ICommand
    {

        readonly IMillReportsRepository repo;
        readonly InspectionReportsViewModel viewModel;
        readonly IUserNotify notify;
        DataSet data;

        public CreateReportCommand(InspectionReportsViewModel viewModel, IMillReportsRepository repo, IUserNotify notify)
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
                data = repo.GetPipesFromInspection(viewModel.StartDate, viewModel.EndDate);
                InspectionReportsXtraReport report = new InspectionReportsXtraReport();
                report.DataSource = data;
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

        public bool IsExecutable
        {
            get;
            set;
        }
    }
}
