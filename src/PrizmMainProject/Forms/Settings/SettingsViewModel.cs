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

        readonly SaveSettingsCommand saveCommand;
        readonly IMillPipeSizeTypeRepository sizeRepo;

        [Inject]
        public SettingsViewModel(IMillPipeSizeTypeRepository sizeRepo)
        {
            NewPipeMillSizeType();
            this.sizeRepo = sizeRepo;
            saveCommand = ViewModelSource.Create<SaveSettingsCommand>(() => new SaveSettingsCommand(this, sizeRepo));
            GetAllPipeMillSizeType();
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

        public void Dispose()
        {
            sizeRepo.Dispose();
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
