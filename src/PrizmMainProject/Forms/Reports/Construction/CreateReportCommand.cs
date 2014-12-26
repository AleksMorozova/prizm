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
                StringBuilder GetAllUsedProducts = new StringBuilder();
                GetAllUsedProducts.Append(" ");
                foreach (var item in viewModel.Types)
                {
                    switch (item)
                    {
                        case PartType.Undefined:
                            break;
                        case PartType.Pipe:
                            GetAllUsedProducts.Append(SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllUsedPipe).ToString());
                            GetAllUsedProducts.Append(" ");
                            break;
                        case PartType.Spool:
                            GetAllUsedProducts.Append(SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllUsedSpool).ToString());
                            GetAllUsedProducts.Append(" ");
                            break;
                        case PartType.Component:
                            GetAllUsedProducts.Append(" ");
                            GetAllUsedProducts.Append(SQLProvider.GetQuery(SQLProvider.SQLStatic.GetAllUsedComponent).ToString());
                            break;
                        default:
                            break;
                    }
                }

                data = repo.GetUsedProducts(viewModel.StartPK, viewModel.EndPK, GetAllUsedProducts.ToString());
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
