using Data.DAL.Setup;
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
        public IList<PipeTest> PipeTest { get; set; }
        public PipeMillSizeType CurrentPipeMillSizeType { get; set; }

        readonly SaveSettingsCommand saveCommand;
        readonly IMillPipeSizeTypeRepository repo;
        readonly IPipeTestRepository testRepo;

        [Inject]
        public SettingsViewModel(IMillPipeSizeTypeRepository repo, IPipeTestRepository testRepo, PipeMillSizeType CurrentPipeMillSizeType )
        {
            this.repo = repo;
            this.testRepo = testRepo;
            saveCommand = ViewModelSource.Create<SaveSettingsCommand>(() => new SaveSettingsCommand(this, repo));
                        
            NewPipeMillSizeType();
            GetAllPipeMillSizeType();
            GetAllPipeTest(CurrentPipeMillSizeType.Id);
            
        }

        public string Name
        {
            get
            {
                return CurrentPipeMillSizeType.Name;
            }
            set
            {
                if (value != CurrentPipeMillSizeType.Name)
                {
                    CurrentPipeMillSizeType.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public IList<PipeTest> Tests
        {
            get
            {
                return CurrentPipeMillSizeType.PipeTests;
            }
            set
            {
                if (value != CurrentPipeMillSizeType.PipeTests)
                {
                    CurrentPipeMillSizeType.PipeTests = value;
                    RaisePropertyChanged("Tests");
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

        private BindingList<PipeMillSizeType> pipeMilSizeType = new BindingList<PipeMillSizeType>();
        public BindingList<PipeMillSizeType> PipeMilSizeType
        {
            get
            {
                return pipeMilSizeType;
            }
            set
            {
                if (value != pipeMilSizeType)
                {
                    pipeMilSizeType = value;
                    RaisePropertyChanged("pipeMilSizeType");
                }
            }
        }

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        private void GetAllPipeMillSizeType()
        {
            var allSizeType = repo.GetAll().ToList();
            PipeMillSizeType = new BindingList<PipeMillSizeType>(allSizeType);
        }

        private void GetAllPipeTest(Guid CurrentPipeMillSizeType)
        {
            var allTests = testRepo.GetAll().ToList();//.GetByPipeSizeID(CurrentPipeMillSizeType).ToList();
            PipeTest = new BindingList<PipeTest>(allTests);
        }

        public void NewPipeMillSizeType()
        {
            if (PipeMillSizeType == null)
            {
                CurrentPipeMillSizeType = new PipeMillSizeType() { IsActive = true };
                CurrentPipeMillSizeType.PipeTests = new BindingList<PipeTest>(); 
            }
            Name = string.Empty;
            Tests = new BindingList<PipeTest>(); 

        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
