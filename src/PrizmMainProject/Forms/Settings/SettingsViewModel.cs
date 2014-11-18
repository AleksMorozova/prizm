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
        public PipeMillSizeType CurrentPipeMillSizeType { get; set; }
        public Project CurrentProjectSettings { get; set; }
       // public IList<PlateManufacturer> PlateManufacturers { get; set; }

        readonly SaveSettingsCommand saveCommand;
        readonly IMillPipeSizeTypeRepository repo;
        readonly IPipeTestRepository testRepo;
        readonly IProjectRepository projectRepo;
        readonly IPlateManufacturerRepository manufacturerRepo;

        [Inject]
        public SettingsViewModel(IMillPipeSizeTypeRepository repo, IPipeTestRepository testRepo, IProjectRepository projectRepo, IPlateManufacturerRepository manufacturerRepo)
        {
            NewPipeMillSizeType();
            this.repo = repo;
            this.testRepo = testRepo;
            this.projectRepo = projectRepo;
            this.manufacturerRepo = manufacturerRepo;
            saveCommand = ViewModelSource.Create<SaveSettingsCommand>(() => new SaveSettingsCommand(this, repo, projectRepo));
            GetAllPipeMillSizeType();
            GetAllPipeTest();
            GetProjectSettings();
        }

        // for Current Mill Pipe SizeType
        public string Type
        {
            get
            {
                return CurrentPipeMillSizeType.Type;
            }
            set
            {
                if (value != CurrentPipeMillSizeType.Type)
                {
                    CurrentPipeMillSizeType.Type = value;
                    RaisePropertyChanged("Type");
                }
            }
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


        // for Current Mill Pipe SizeType
        public BindingList<PipeTest> Tests
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
                    RaisePropertyChanged("Tests");
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
        private BindingList<PlateManufacturer> plateManufacturers = new BindingList<PlateManufacturer>();
        public BindingList<PlateManufacturer> PlateManufacturers
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
                    RaisePropertyChanged("manufacturers");
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
            var allSizeType = repo.GetAll().ToList();
            PipeMillSizeType = new BindingList<PipeMillSizeType>(allSizeType);
        }

        private void GetAllPipeTest()
        {
            var allTests = testRepo.GetAll().ToList();
            PipeTests = new BindingList<PipeTest>(allTests);
        }

        public void NewPipeMillSizeType()
        {
            if (CurrentPipeMillSizeType == null)
            {
                CurrentPipeMillSizeType = new PipeMillSizeType() { IsActive = true };
                CurrentPipeMillSizeType.PipeTests = new BindingList<PipeTest>();
            }
            Type = string.Empty;
            Tests = new BindingList<PipeTest>();; 
        }

        private void GetProjectSettings()
        {
            CurrentProjectSettings = projectRepo.GetSingle();
        }

        public void Dispose()
        {
            repo.Dispose();
            projectRepo.Dispose();
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
