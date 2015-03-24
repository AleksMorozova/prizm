using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Mvvm.POCO;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.Component.NewEdit
{
    public class NewSaveComponentCommand: ICommand
    {
        private readonly IComponentRepositories repos;
        private readonly ComponentNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public NewSaveComponentCommand(
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
            viewModel.SaveCommand.Execute();

            if (viewModel.Number != string.Empty &&
                viewModel.ValidatableView.Validate())
            {
                viewModel.NewComponent();
                viewModel.ModifiableView.Id = viewModel.Component.Id;
                viewModel.ModifiableView.IsModified = false;
            }
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return 
                viewModel.SaveCommand.CanExecute() 
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditComponent)
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.CreateComponent);
        }
    }
}
