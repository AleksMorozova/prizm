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
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Spool
{
    public class SpoolDeactivationCommand : ICommand
    {
        private readonly ISpoolRepositories repo;
        private readonly SpoolViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SpoolDeactivationCommand(ISpoolRepositories repo, SpoolViewModel viewModel, IUserNotify notify, ISecurityContext ctx)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (notify.ShowYesNo(
                  Program.LanguageManager.GetString(StringResources.Spool_DeactivationQuestion),
                  Program.LanguageManager.GetString(StringResources.Spool_DeactivationQuestionHeader)))
            {
                viewModel.PipeLength = viewModel.PipeLength + viewModel.SpoolLength;       
                viewModel.Spool.IsActive = false;
                viewModel.SaveCommand.Execute();
                viewModel.ModifiableView.IsEditMode = false;
            }
            RefreshVisualStateEvent();
        }


        public bool CanExecute()
        {
            return viewModel.SpoolIsActive
                && !viewModel.IsNew
                && viewModel.ModifiableView.IsEditMode
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.DeactivateSpool);
        }
    }
}
