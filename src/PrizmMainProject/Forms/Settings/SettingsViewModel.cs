using Data.DAL.Setup;
using Data.DAL;
using Data.DAL.Mill;
using Domain.Entity;
using Domain.Entity.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Domain.Entity.Setup;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings
{
    public class SettingsViewModel : ViewModelBase, IDisposable
    {
        public IList<PipeMillSizeType> PipeMillSizeType { get; set; }
        public Project CurrentProjectSettings { get; set; }
        readonly SaveSettingsCommand saveCommand;
        private IList<PlateManufacturer> plateManufacturers;
        readonly IMillPipeSizeTypeRepository sizeRepo;
        readonly IProjectRepository projectRepo;
        readonly IPlateManufacturerRepository manufacturerRepo;

        [Inject]
        public SettingsViewModel(IMillPipeSizeTypeRepository sizeRepo, IProjectRepository projectRepo, IPlateManufacturerRepository manufacturerRepo)
        {
            NewPipeMillSizeType();  
            this.sizeRepo = sizeRepo;       
            this.projectRepo = projectRepo;
            this.manufacturerRepo = manufacturerRepo;
            saveCommand = ViewModelSource.Create<SaveSettingsCommand>(() => new SaveSettingsCommand(this, sizeRepo, projectRepo, manufacturerRepo));
            GetAllPipeMillSizeType();
            GetProjectSettings();
            GetAllManufacturers();
        }
       
        private BindingList<PipeTest> pipeTests = new BindingList<PipeTest>();
        public BindingList<PipeTest> PipeTests 
        {
            get
            {
                return pipeTests;
            }
            set
            {
                if (value != pipeTests)
                {
                    pipeTests = value;
                    RaisePropertyChanged("pipeTests");
                }
            }
        }

        #region Current Project Settings

        public string Client
        {
            get
            {
                return CurrentProjectSettings.Client;
            }
            set 
            {
                if (value != CurrentProjectSettings.Client)
                {
                    CurrentProjectSettings.Client = value;
                    RaisePropertyChanged("Client");
                }
            }
        }

        public string Designer
        {
            get 
            {
                return CurrentProjectSettings.Designer;
            }
            set
            {
                if (value != CurrentProjectSettings.Designer)
                {
                    CurrentProjectSettings.Designer = value;
                    RaisePropertyChanged("Designer");
                }
            }
        }

        public int DocumentSizeLimit 
        {
            get
            {
                return CurrentProjectSettings.DocumentSizeLimit;
            }
            set
            {
                if (value != CurrentProjectSettings.DocumentSizeLimit)
                {
                    CurrentProjectSettings.DocumentSizeLimit = value;
                    RaisePropertyChanged("DocumentSizeLimit");
                }
            }
        }
        #endregion

        #region Plate Manufacturers
        public IList<PlateManufacturer> PlateManufacturers
        {
            get 
            {
                return plateManufacturers;
            }
            set 
            {
                if (value != plateManufacturers)
                {
                    plateManufacturers = value;
                    RaisePropertyChanged("PlateManufacturers");
                }
            }
        }
        #endregion
        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        private void GetAllPipeMillSizeType()
        {
            var allSizeType = sizeRepo.GetAll().ToList();
            PipeMillSizeType = new BindingList<PipeMillSizeType>(allSizeType);
        }

        public void NewPipeMillSizeType()
        {
            if (PipeMillSizeType == null)
            {
                PipeMillSizeType = new List<PipeMillSizeType>();
            }
        }

        private void GetProjectSettings()
        {
            CurrentProjectSettings = projectRepo.GetSingle();
        }

        private void GetAllManufacturers()
        {
            plateManufacturers = manufacturerRepo.GetAll().ToList();
        }

        public void AddNewManufacturer(string newManufacturerName)
        {
           var existingItem = from p in plateManufacturers where p.Name == newManufacturerName select p;
            if (!existingItem.Any())
            {
                PlateManufacturer newManufacturer = new PlateManufacturer { IsActive = true, Name = newManufacturerName };
                plateManufacturers.Add(newManufacturer);
            }
        }

        public void Dispose()
        {
            sizeRepo.Dispose();
            projectRepo.Dispose();
            manufacturerRepo.Dispose();
        }

        internal void UpdatePipeTests(object sizeType)
        {
            PipeMillSizeType type = sizeType as PipeMillSizeType;
            PipeTests.Clear();
            if (type.PipeTests == null)
                return;
            foreach (PipeTest t in type.PipeTests)
            {
                PipeTests.Add(t);
            }
        }
    }
}
