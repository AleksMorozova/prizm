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
using Prizm.Main.Languages;


namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class PipeDeactivationCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public PipeDeactivationCommand(
            MillPipeNewEditViewModel viewModel, 
            IMillRepository repo,
            IUserNotify notify,
            ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (viewModel.Pipe.Railcar == null)
            {
                if (notify.ShowYesNo(
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeQuestion),
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeQuestionHeader)))
                {
                    viewModel.Pipe.IsActive = false;
                    viewModel.SavePipeCommand.Execute();
                    viewModel.ModifiableView.IsEditMode = false;
                }
            }
            else if (viewModel.PipeStatus == PipeMillStatus.Shipped)
            {
                notify.ShowInfo(
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeShippedError),
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeShippedErrorHeader));
            }
            else
            {
                notify.ShowInfo(
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeInRailcarError),
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeInRailcarErrorHeader));
            }
            RefreshVisualStateEvent();
        }


        public bool CanExecute()
        {
            return
                viewModel.Pipe.Status != PipeMillStatus.Shipped
                && viewModel.Pipe.IsActive
                && !viewModel.IsNew
                && viewModel.ModifiableView.IsEditMode
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.DeactivatePipe);
        }
    }
}
