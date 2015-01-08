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

using construct = Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Reports.Construction
{
    public class PreviewReportCommand : ICommand
    {
        readonly IMillReportsRepository repo;
        readonly ConstructionReportViewModel viewModel;
        readonly IUserNotify notify;

        public PreviewReportCommand(
            ConstructionReportViewModel viewModel, 
            IMillReportsRepository repo, 
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            viewModel.ReportCommand.Execute();

            viewModel.report.CreateDocument();
            viewModel.PreviewSource = viewModel.report;
        }

    
        public bool CanExecute()
        {
            return viewModel.ReportCommand.CanExecute();
        }

        public bool IsExecutable
        { get; set; }
    }
}
