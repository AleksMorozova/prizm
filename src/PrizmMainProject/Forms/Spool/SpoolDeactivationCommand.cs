using Prizm.Main.Commands;
using Prizm.Main.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Spool
{
    public class SpoolDeactivationCommand : ICommand
    {
        private readonly ISpoolRepositories repo;
        private readonly SpoolViewModel viewModel;
        private readonly IUserNotify notify;
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public SpoolDeactivationCommand(ISpoolRepositories repo, SpoolViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (notify.ShowYesNo(
                  Resources.DLG_SPOOL_DEACTIVATION,
                  Resources.DLG_SPOOL_DEACTIVATION_HEADER))
            { 
            
            }
        }

        public virtual bool IsExecutable { get; set; }

        public bool CanExecute()
        {
            return ctx.HasAccess(global::Domain.Entity.Security.Privileges.DeactivateSpool);
        }


        public event RefreshVisualStateEventHandler RefreshVisualStateEvent;
    }
}
