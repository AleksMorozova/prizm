using Data.DAL.Setup;
using Data.DAL;
using Data.DAL.Mill;
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
    public class SaveSettingsCommand : ICommand
    {
        readonly IMillPipeSizeTypeRepository repo;
        readonly SettingsViewModel viewModel;
        readonly IProjectRepository projectRepo;
        readonly IPlateManufacturerRepository manufacturerRepo;

        public SaveSettingsCommand(SettingsViewModel viewModel, IMillPipeSizeTypeRepository repo, IProjectRepository projectRepo, IPlateManufacturerRepository manufacturerRepo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.projectRepo = projectRepo;
            this.manufacturerRepo = manufacturerRepo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            try
            {
                foreach (PipeMillSizeType t in viewModel.PipeMillSizeType)
                {
                    repo.BeginTransaction();
                    repo.SaveOrUpdate(t);
                    repo.Commit();
                    repo.Evict(t);
                }

                foreach (Domain.Entity.Mill.PlateManufacturer manufacturer in viewModel.PlateManufacturers)
                {
                    manufacturerRepo.BeginTransaction();
                    manufacturerRepo.SaveOrUpdate(manufacturer);
                    manufacturerRepo.Commit();
                    manufacturerRepo.Evict(manufacturer);
                }
                projectRepo.BeginTransaction();
                projectRepo.SaveOrUpdate(viewModel.CurrentProjectSettings);
                projectRepo.Commit();
                projectRepo.Evict(viewModel.CurrentProjectSettings);
            }
            catch (Exception)
            {
                throw new Exception("Извините, проблемы с сохранением настроек в базу данных");
            }
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
