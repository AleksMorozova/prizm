using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity.Mill;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.Railcar.NewEdit
{
    public class UnshipRailcarCommand : ICommand
    {
        private readonly IRailcarRepositories repos;
        private readonly RailcarViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public UnshipRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo, IUserNotify notify, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.Railcar.IsShipped)
            {
                notify.ShowError(Resources.DLG_UNSHIP_UNSHIPPED_RAILCAR, Resources.DLG_ERROR_HEADER);
            }
            else
            {
                foreach(var pipe in viewModel.Railcar.Pipes)
                {
                    pipe.Status = PipeMillStatus.Stocked;
                    pipe.ToExport = false;
                }
               
                viewModel.IsShipped = false;
                notify.ShowSuccess(Resources.AlertUnsipRailcar, Resources.AlertInfoHeader);
                viewModel.SaveCommand.Execute();
            }
            RefreshVisualStateEvent();
        }
        public bool CanExecute()
        {
            return (viewModel.Railcar.IsShipped && ctx.HasAccess(global::Domain.Entity.Security.Privileges.UnshipAtMill));
        }
    }
}
