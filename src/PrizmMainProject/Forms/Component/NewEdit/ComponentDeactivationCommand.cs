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

namespace Prizm.Main.Forms.Component.NewEdit
{
    public class ComponentDeactivationCommand: ICommand
    {
        private readonly IComponentRepositories repos;
        private readonly ComponentNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        [Inject]
        public ComponentDeactivationCommand(
            ComponentNewEditViewModel viewModel,
            IComponentRepositories repo, 
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (notify.ShowYesNo(
                Resources.DLG_COMPONENT_DEACTIVATION,
                Resources.DLG_COMPONENT_DEACTIVATION_HEDER))
            {
                viewModel.SaveCommand.Execute();
            }
            else
            {
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
                viewModel.Component.IsActive;
        }
    }
}
