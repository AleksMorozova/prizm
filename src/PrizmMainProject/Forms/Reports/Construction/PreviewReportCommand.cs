using Data.DAL;
using DevExpress.XtraReports.UI;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Reports.Construction
{
    public class PreviewReportCommand : ICommand
    {
        readonly IMillReportsRepository repo;
        readonly ConstructionReportViewModel viewModel;
        readonly IUserNotify notify;
        DataSet data;
        BindingList<string> selectedTypes;

        public PreviewReportCommand(ConstructionReportViewModel viewModel, IMillReportsRepository repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            try
            {
                data = repo.GetUsedProducts(viewModel.StartPK, viewModel.EndPK, selectedTypes);
                viewModel.report.DataSource = data;
                viewModel.report.CreateDocument();
                viewModel.PreviewSource = viewModel.report;
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
        { get; set; }
    }
}
