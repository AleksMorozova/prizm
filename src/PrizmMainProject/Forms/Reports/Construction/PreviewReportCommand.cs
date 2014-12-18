using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
using DevExpress.XtraReports.UI;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction
{
    public class PreviewReportCommand : ICommand
    {
        readonly IMillReportsRepository repo;
        readonly ConstructionReportViewModel viewModel;
        readonly IUserNotify notify;
        DataSet data;

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
                StringBuilder GetAllUsedProducts = new StringBuilder();
                foreach (var item in viewModel.Types)
                {
                    switch (item)
                    {
                        case PartType.Undefined:
                            GetAllUsedProducts.Append(" ");
                            break;
                        case PartType.Pipe:
                            GetAllUsedProducts.Append(SQLQueryString.GetAllUsedPipe);
                            GetAllUsedProducts.Append(" ");
                            break;
                        case PartType.Spool:
                            GetAllUsedProducts.Append(SQLQueryString.GetAllUsedSpool);
                            GetAllUsedProducts.Append(" ");
                            break;
                        case PartType.Component:
                            GetAllUsedProducts.Append(" ");
                            GetAllUsedProducts.Append(SQLQueryString.GetAllUsedComponent);
                            break;
                        default:
                            GetAllUsedProducts.Append(" ");
                            break;
                    }
                }

                data = repo.GetUsedProducts(viewModel.StartPK, viewModel.EndPK, GetAllUsedProducts.ToString());
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
