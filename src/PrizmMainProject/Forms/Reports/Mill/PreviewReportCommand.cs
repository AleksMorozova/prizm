using Data.DAL;
using PrizmMain.Commands;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Reports.Mill
{
    public class PreviewReportCommand: ICommand
    {
        readonly IMillReportsRepository repo;
        readonly MillReportsViewModel viewModel;
        readonly IUserNotify notify;
        DataSet data;

        public PreviewReportCommand(MillReportsViewModel viewModel, IMillReportsRepository repo, IUserNotify notify)
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
                data = repo.GetPipesByStatus(viewModel.StartDate, viewModel.EndDate);
                MillReportsXtraReport report = new MillReportsXtraReport();
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

        public bool IsExecutable
        { get; set;}
    }
}
