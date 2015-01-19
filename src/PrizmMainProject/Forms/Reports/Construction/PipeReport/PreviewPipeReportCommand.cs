using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction.PipeReport
{
    public class PreviewPipeReportCommand : ICommand
    {
        readonly IMillReportsRepository repo;
        readonly PipeConstractionReportViewModel viewModel;
        readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public PreviewPipeReportCommand(
            PipeConstractionReportViewModel viewModel, 
            IMillReportsRepository repo, 
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            viewModel.Data = repo.GetPipesByParameters(
                string.Format(
                SQLProvider.GetQuery(SQLProvider.SQLStatic.GetPipeByParametersPieces).ToString(),
                viewModel.PipeNumber,
                viewModel.Diameter,
                viewModel.WallThickness));

            viewModel.Report = new PipeConstructionXtraReport();

            viewModel.Report.DataSource = viewModel.PipeReportDataList;

            viewModel.Report.CreateDocument();
            viewModel.PreviewSource = viewModel.Report;

            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return true;
        }

    }
}
