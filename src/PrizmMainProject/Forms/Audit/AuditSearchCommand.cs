using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Prizm.Domain.Entity;

namespace Prizm.Main.Forms.Audit
{
    public class AuditSearchCommand : ICommand
    {
        readonly IAuditLogRepository repo;
        readonly AuditViewModel viewModel;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public AuditSearchCommand(AuditViewModel viewModel, IAuditLogRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {

            if (viewModel.TracingMode == TracingModeEnum.TracingByPeriod)
            {
                var results = repo.GetRecordsByNumber("труба - 1", viewModel.StartDate, viewModel.EndDate);
                viewModel.AuditResults = new BindingList<AuditLog>(results);
            }
            else if (viewModel.TracingMode == TracingModeEnum.TracingByUser)
            {
                var results = repo.GetRecords(viewModel.EntityID, viewModel.SelectedUser);
                viewModel.AuditResults = new BindingList<AuditLog>(results);
            }

        }
        public bool CanExecute()
        {
            return true;
        }

    }
}
