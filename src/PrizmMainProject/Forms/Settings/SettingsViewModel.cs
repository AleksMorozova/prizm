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
        public PipeMillSizeType CurrentPipeMillSizeType { get; set; }

        readonly SaveSettingsCommand saveCommand;
        readonly IMillPipeSizeTypeRepository repo;
        readonly IPipeTestRepository testRepo;

        [Inject]
        public SettingsViewModel(IMillPipeSizeTypeRepository repo, IPipeTestRepository testRepo, PipeMillSizeType CurrentPipeMillSizeType )
        {
            NewPipeMillSizeType();
            this.repo = repo;
            this.testRepo = testRepo;
            saveCommand = ViewModelSource.Create<SaveSettingsCommand>(() => new SaveSettingsCommand(this, repo));
            GetAllPipeMillSizeType();
            GetAllPipeTest();
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

        public void Dispose()
        {
            repo.Dispose();
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
