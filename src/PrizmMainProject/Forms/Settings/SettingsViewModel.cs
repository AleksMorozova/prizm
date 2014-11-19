using Data.DAL.Mill;
using Data.DAL.Setup;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Domain.Entity;
using Domain.Entity.Setup;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Forms.Settings.ViewTypes;
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
        public BindingList<WelderViewType> Welders { get; set; }
        readonly SaveSettingsCommand saveCommand;
        readonly ISettingsRepositories repos;
        

        [Inject]
        public SettingsViewModel(ISettingsRepositories repos)
        {
            NewPipeMillSizeType();
            this.repos = repos;
            saveCommand = ViewModelSource.Create<SaveSettingsCommand>(() => new SaveSettingsCommand(this, repos));
        }

        public void LoadData()
        {
           GetAllPipeMillSizeType();
           GetAllWelders();
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
            var allSizeType = repos.PipeSizeTypeRepo.GetAll().ToList();
            PipeMillSizeType = new BindingList<PipeMillSizeType>(allSizeType);
        }

        void GetAllWelders()
        {
           if (Welders == null)
              Welders = new BindingList<WelderViewType>();

           var foundWelders = repos.WelderRepo.GetAll();
           if (foundWelders != null)
           {
              foreach (Welder w in foundWelders)
              {
                 Welders.Add(new WelderViewType(w));
              }
           }
                      
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
            repos.Dispose();
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
