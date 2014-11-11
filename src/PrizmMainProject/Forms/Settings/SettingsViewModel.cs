using Data.DAL.Setup;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Domain.Entity.Setup;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings
{
    public class SettingsViewModel : ViewModelBase, IDisposable
    {
        public PipeMillSizeType PipeMillSizeType { get; set; }
        readonly SaveSettingsCommand saveCommand;
        readonly ISettingsRepository repo;
        
        [Inject]
        public SettingsViewModel(ISettingsRepository repo)
        {
            this.repo = repo;
            saveCommand = ViewModelSource.Create<SaveSettingsCommand>(() => new SaveSettingsCommand(this, repo));
            NewPipeMillSizeType();
        }

        public string Name
        {
            get
            {
                return PipeMillSizeType.Name;
            }
            set
            {
                if (value != PipeMillSizeType.Name)
                {
                    PipeMillSizeType.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public ICollection<PipeTest> Tests
        {
            get
            {
                return PipeMillSizeType.PipeTests;
            }
            set
            {
                if (value != PipeMillSizeType.PipeTests)
                {
                    PipeMillSizeType.PipeTests = value;
                    RaisePropertyChanged("Tests");
                }
            }
        }

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        public void NewPipeMillSizeType()
        {
            if (PipeMillSizeType == null)
            { 
                PipeMillSizeType = new PipeMillSizeType() { IsActive = true };
            }

            Name = string.Empty;
            Tests = null;

        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
