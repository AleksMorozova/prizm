using Data.DAL.Setup;
using DevExpress.Mvvm.DataAnnotations;
using Domain.Entity.Setup;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings
{
    public class SaveSettingsCommand: ICommand 
    {
        readonly IMillPipeSizeTypeRepository repo;
        readonly SettingsViewModel viewModel;

        public SaveSettingsCommand(SettingsViewModel viewModel, IMillPipeSizeTypeRepository repo) 
        {
            this.viewModel = viewModel; 
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            foreach (PipeMillSizeType t in viewModel.PipeMillSizeType)
            {
                repo.BeginTransaction();
                repo.SaveOrUpdate(t);
                repo.Commit();
                repo.Evict(t);
            }
        }

        public bool CanExecute()
        {
         return true;
        }
    }
}
