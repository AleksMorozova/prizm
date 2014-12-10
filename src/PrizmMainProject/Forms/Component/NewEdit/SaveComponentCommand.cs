using Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Mvvm.POCO;
using PrizmMain.Properties;

namespace PrizmMain.Forms.Component.NewEdit
{
    public class SaveComponentCommand: ICommand
    {
        private readonly IComponentRepositories repos;
        private readonly ComponentNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        [Inject]
        public SaveComponentCommand(
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
            try
            {
                repos.BeginTransaction();
                repos.ComponentRepo.SaveOrUpdate(viewModel.Component);
                repos.Commit();
                repos.ComponentRepo.Evict(viewModel.Component);

                viewModel.ModifiableView.IsModified = false;

                notify.ShowSuccess(
                     string.Concat(Resources.DLG_COMPONENT_SAVED, viewModel.Number),
                     Resources.DLG_COMPONENT_SAVED_HEADER);
            }
            catch (RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
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
                !string.IsNullOrEmpty(viewModel.Number) &&
                viewModel.Type != null;
        }
    }
}
