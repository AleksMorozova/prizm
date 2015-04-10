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
using Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Component.NewEdit
{
    public class ComponentDeactivationCommand: BaseCommand
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
        public override void Execute()
        {
            if (!IsComponentsConnected(viewModel.Component))
            {
                if (notify.ShowYesNo(
                    Program.LanguageManager.GetString(StringResources.Message_ComponentDeactivationQuestion),
                    Program.LanguageManager.GetString(StringResources.Message_ComponentDeactivationQuestionHeader)))
                {
                    try
                    {
                        viewModel.ComponentIsActive = false;

                        repos.BeginTransaction();
                        repos.ComponentRepo.SaveOrUpdate(viewModel.Component);
                        repos.Commit();

                        repos.ComponentRepo.Evict(viewModel.Component);

                        viewModel.ModifiableView.IsModified = false;
                        viewModel.ModifiableView.IsEditMode = false;
                        viewModel.ModifiableView.UpdateState();

                        notify.ShowSuccess(
                                    string.Concat(Program.LanguageManager.GetString(
                                        StringResources.ComponentNewEdit_DeactivatedAction), viewModel.Number),
                                    Program.LanguageManager.GetString(
                                        StringResources.ComponentNewEdit_DeactivatedActionHeader));

                        log.Info(string.Format("The entity #{0}, id:{1} has been deactivated.",
                            viewModel.Component.Number, viewModel.Component.Id));
                    }
                    catch (RepositoryException ex)
                    {
                        log.Error(ex.Message);
                        notify.ShowFailure(ex.InnerException.Message, ex.Message);
                    }
                }
                else
                {
                    //Refresh property so that binded control become unchecked
                    viewModel.ComponentIsActive = false;
                    viewModel.ComponentIsActive = true;
                }
            }
            else
            {
                notify.ShowInfo(
                    Program.LanguageManager.GetString(StringResources.Message_DeactivationConnectedComponent),
                    Program.LanguageManager.GetString(StringResources.Message_DeactivationConnectedComponentHeader));

                //Refresh property so that binded control become unchecked
                viewModel.ComponentIsActive = false;
                viewModel.ComponentIsActive = true;
            }
            RefreshVisualStateEvent();
        }


        private bool IsComponentsConnected(Prizm.Domain.Entity.Construction.Component component)
        {
            return 
                component
                .Connectors
                .Any<Connector>(x => x.Joint != null && x.Joint.Id != Guid.Empty);
        }

        public override bool CanExecute()
        {
            return 
                viewModel.Component.IsActive &&
                !viewModel.IsNew &&
                ctx.HasAccess(global::Domain.Entity.Security.Privileges.DeactivateComponent);
        }
    }
}
