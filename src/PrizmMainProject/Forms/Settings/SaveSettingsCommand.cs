using Data.DAL.Mill;
using Data.DAL.Setup;
using Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Domain.Entity.Setup;
using PrizmMain.Commands;
using PrizmMain.Forms.Settings.ViewTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrizmMain.Properties;
using PrizmMain.Documents;

namespace PrizmMain.Forms.Settings
{
    public class SaveSettingsCommand : ICommand
    {
        readonly ISettingsRepositories repos;
        readonly SettingsViewModel viewModel;
        readonly IUserNotify notify;

        public SaveSettingsCommand(SettingsViewModel viewModel, ISettingsRepositories repos, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            repos.BeginTransaction();
            SaveWelders();
            SaveInspectors();
            SaveMillSizeTypes();
            SavePlateManufacturers();
            repos.ProjectRepo.SaveOrUpdate(viewModel.CurrentProjectSettings);
            repos.Commit();
            EvictMillSizeTypes();
            EvictWelders();
            EvictInspectors();
            EvictPlateManufacturers();
            repos.ProjectRepo.Evict(viewModel.CurrentProjectSettings);
            viewModel.ModifiableView.IsModified = false;

            notify.ShowNotify(
                Resources.DLG_SETUP_SAVED,
                Resources.DLG_SETUP_SAVED_HEADER);
        }

        private void EvictWelders()
        {
            if (viewModel.Welders != null)
            {
                viewModel.Welders.ForEach<WelderViewType>(_ => repos.WelderRepo.Evict(_.Welder));
            }
        }

        private void EvictMillSizeTypes()
        {
            foreach (PipeMillSizeType t in viewModel.PipeMillSizeType)
            {
                repos.PipeSizeTypeRepo.Evict(t);
            }
        }

        private void EvictPlateManufacturers()
        {
            foreach (Domain.Entity.Mill.PlateManufacturer manufacturer in viewModel.PlateManufacturers)
            {
                repos.PlateManufacturerRepo.Evict(manufacturer);
            }
        }

        public bool CanExecute()
        {
            return true;
        }

        void SaveMillSizeTypes()
        {
            foreach (PipeMillSizeType t in viewModel.PipeMillSizeType)
            {
                repos.PipeSizeTypeRepo.SaveOrUpdate(t);
            }
        }

        void SaveWelders()
        {
            if (viewModel.Welders != null)
            {
                viewModel.Welders.ForEach<WelderViewType>(_ => repos.WelderRepo.SaveOrUpdate(_.Welder));
           }
        }

        void SaveInspectors()
        {
           if (viewModel.Inspectors != null)
           {
              viewModel.Inspectors.ForEach<InspectorViewType>(_ => repos.InspectorRepo.SaveOrUpdate(_.Inspector));
           }
        }

        void EvictInspectors()
        {
           if (viewModel.Inspectors != null)
           {
              viewModel.Inspectors.ForEach<InspectorViewType>(_ => repos.InspectorRepo.Evict(_.Inspector));
            }
        }

        void SavePlateManufacturers()
        {
            foreach (Domain.Entity.Mill.PlateManufacturer manufacturer in viewModel.PlateManufacturers)
            {
                repos.PlateManufacturerRepo.SaveOrUpdate(manufacturer);
            }
        }
        public virtual bool IsExecutable { get; set; }
    }
}
