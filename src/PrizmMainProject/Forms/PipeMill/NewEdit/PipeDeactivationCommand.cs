using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Properties;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Security;
using Ninject;


namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class PipeDeactivationCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public PipeDeactivationCommand(
            MillPipeNewEditViewModel viewModel, 
            IMillRepository repo,
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (viewModel.Pipe.Railcar == null)
            {
                if (notify.ShowYesNo(
                    Resources.DLG_PIPE_DEACTIVATION,
                    Resources.DLG_PIPE_DEACTIVATION_HEDER))
                {
                    viewModel.SavePipeCommand.Execute();
                }
                else
                {
                    viewModel.IsNotActive = false;
                }
            }
            else if (viewModel.PipeStatus.Value == PipeMillStatus.Shipped)
            {
                notify.ShowInfo(
                    Resources.DLG_PIPE_IS_SHIPPED,
                    Resources.DLG_PIPE_IS_SHIPPED_HEDER);

                viewModel.IsNotActive = false;
            }
            else
            {
                notify.ShowInfo(
                    Resources.DLG_PIPE_IN_RAILCAR,
                    Resources.DLG_PIPE_IN_RAILCAR_HEDER);

                viewModel.IsNotActive = false;
            }
        }

        public virtual bool IsExecutable { get; set; }

        protected virtual void OnIsExecutableChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Execute());
        }

        public bool CanExecute()
        {
            return
                viewModel.Pipe.Status != PipeMillStatus.Shipped &&
                viewModel.Pipe.IsActive &&
                ctx.HasAccess(global::Domain.Entity.Security.Privileges.DeactivatePipe);
        }
    }
}
