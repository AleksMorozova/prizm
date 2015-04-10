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
    public class CreateReportCommand : BaseCommand
    {
        readonly IMillReportsRepository repo;
        readonly ConstructionReportViewModel viewModel;
        readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public CreateReportCommand(ConstructionReportViewModel viewModel, IMillReportsRepository repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public override void Execute()
        {
            viewModel.ReportCommand.Execute();

            if (viewModel.ReportType == ReportType.TracingReport)
            {
                var report = new TracingReport();

                report.DataSource = viewModel.ReportDataSource;
                report.FootersVisibility = viewModel.IsFooterVisible;


                report.PipelineJointCount = viewModel.PipelineJointCount;
                report.PipelinePipeCount = viewModel.PipelinePipeCount;
                report.PipelineSpoolCount = viewModel.PipelineSpoolCount;
                report.PipelineComponentCount = viewModel.PipelineComponentCount;
                report.PipelineLength = viewModel.PipelineLength;

                var tool = new ReportPrintTool(report);
                tool.AutoShowParametersPanel = false;
                tool.ShowPreview();
            }
            else if (viewModel.ReportType == ReportType.UsedProductReport)
            {
                var report = new UsedProductsXtraReport();

                report.DataSource = viewModel.ReportDataSource;
                report.FootersVisibility = viewModel.IsFooterVisible;

                var tool = new ReportPrintTool(report);
                tool.AutoShowParametersPanel = false;
                tool.ShowPreview();
            }
        }

        public override bool CanExecute()
        {
            return viewModel.ReportCommand.CanExecute();
        }

    }
}
