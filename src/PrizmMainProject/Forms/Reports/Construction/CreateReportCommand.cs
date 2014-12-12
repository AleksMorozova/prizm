using Data.DAL;
using DevExpress.XtraReports.UI;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Reports.Construction
{
    public class CreateReportCommand : ICommand
    {
        readonly IMillReportsRepository repo;
        readonly ConstructionReportViewModel viewModel;
        readonly IUserNotify notify;
        DataSet data;

        public CreateReportCommand(ConstructionReportViewModel viewModel, IMillReportsRepository repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            try
            {
                data = repo.GetUsedProducts(viewModel.StartPK, viewModel.EndPK);
                viewModel.report.DataSource = data;
                viewModel.report.CreateDocument();
                var tool = new ReportPrintTool(viewModel.report);
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

        public bool IsExecutable { get; set; }
    }
}
