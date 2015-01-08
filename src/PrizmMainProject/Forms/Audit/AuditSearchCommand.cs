using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Prizm.Main.Forms.Audit
{
    public class AuditSearchCommand : ICommand
    {
        readonly IMillReportsRepository repo;
        readonly AuditViewModel viewModel;

        public AuditSearchCommand(AuditViewModel viewModel, IMillReportsRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            viewModel.AuditResults = repo.GetAuditResults(viewModel.StartDate, viewModel.EndDate, viewModel.SelectedUser);
            stopWatch.Stop();
            viewModel.TS = stopWatch.Elapsed;
        }
        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
