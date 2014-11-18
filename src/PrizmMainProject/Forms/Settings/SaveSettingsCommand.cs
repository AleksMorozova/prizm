using Data.DAL.Setup;
using Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
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
        readonly IProjectRepository projectRepo;

        public SaveSettingsCommand(SettingsViewModel viewModel, IMillPipeSizeTypeRepository repo, IProjectRepository projectRepo) 
        {
            this.viewModel = viewModel; 
            this.repo = repo;
            this.projectRepo = projectRepo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
         repo.BeginTransaction();
  
         repo.SaveOrUpdate(viewModel.CurrentPipeMillSizeType);
         repo.Commit();
         repo.Evict(viewModel.CurrentPipeMillSizeType);
         //viewModel.NewPipeMillSizeType();
         try
         {
             projectRepo.BeginTransaction();
             projectRepo.SaveOrUpdate(viewModel.CurrentProjectSettings);
             projectRepo.Commit();
             projectRepo.Evict(viewModel.CurrentProjectSettings);
         }
         catch (Exception)
         {
             throw new Exception ("Sorry, problems with project settings");
         }
        }

        public bool CanExecute()
        {
         return true;
        }
    }
}
