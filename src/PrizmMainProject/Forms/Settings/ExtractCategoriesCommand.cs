using DevExpress.Mvvm.DataAnnotations;
using Domain.Entity.Mill;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings
{
    public class ExtractCategoriesCommand : ICommand
    {
        readonly ISettingsRepositories repos;
        readonly SettingsViewModel viewModel;
        readonly IUserNotify notify;

        public ExtractCategoriesCommand(
            SettingsViewModel viewModel, 
            ISettingsRepositories repos, 
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.CategoryTypes
                = new BindingList<Category>(repos.СategoryRepo.GetAll());
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
