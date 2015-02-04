using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using Ninject;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Properties;
using Prizm.Main.Security;
using Prizm.Main.Languages;
using Prizm.Data.DAL;

namespace Prizm.Main.Forms.Component.NewEdit
{
    public class ComponentDeactivationCommand: ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ComponentDeactivationCommand));

        private readonly IComponentRepositories repos;
        private readonly ComponentNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public ComponentDeactivationCommand(
            ComponentNewEditViewModel viewModel,
            IComponentRepositories repo, 
            IUserNotify notify,
            ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (notify.ShowYesNo(
                Program.LanguageManager.GetString(StringResources.Message_ComponentDeactivationQuestion),
                Program.LanguageManager.GetString(StringResources.Message_ComponentDeactivationQuestionHeader)))
            {
                try
                {
                    viewModel.ComponentIsActive = false;
                    viewModel.SaveCommand.Execute();
                    viewModel.ModifiableView.IsEditMode = false;
                }
                catch (RepositoryException ex)
                {
                    log.Error(ex.Message);
                    notify.ShowFailure(ex.InnerException.Message, ex.Message);
                }
            }
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return 
                viewModel.Component.IsActive &&
                !viewModel.IsNew &&
                ctx.HasAccess(global::Domain.Entity.Security.Privileges.DeactivateComponent);
        }
    }
}
