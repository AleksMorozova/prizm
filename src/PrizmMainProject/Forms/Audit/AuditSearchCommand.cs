using Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Audit
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
            viewModel.AuditResults = repo.GetAuditResults(viewModel.StartDate, viewModel.EndDate, viewModel.SelectedUser);
        }
        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
