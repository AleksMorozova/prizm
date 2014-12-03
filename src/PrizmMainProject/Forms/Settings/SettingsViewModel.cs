using Data.DAL.Mill;
using Data.DAL.Setup;
using Data.DAL;
using Domain.Entity.Mill;
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
using PrizmMain.Properties;
using PrizmMain.Documents;

namespace PrizmMain.Forms.Settings
{
    public class SettingsViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        public IList<PipeMillSizeType> PipeMillSizeType { get; set; }
        public Project CurrentProjectSettings { get; set; }
        public BindingList<WelderViewType> Welders { get; set; }
        public BindingList<InspectorViewType> Inspectors { get; set; }
        public BindingList<PipeTestControlTypeWrapper> ControlType { get; set; }
        public BindingList<PipeTestResultTypeWrapper> ResultType { get; set; }
        readonly SaveSettingsCommand saveCommand;
        readonly ISettingsRepositories repos;
        private IList<PlateManufacturer> plateManufacturers;
        private IModifiable modifiable;

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
           GetAllInspectors();
           GetProjectSettings();
           GetAllManufacturers();
           ControlType = new BindingList<PipeTestControlTypeWrapper>();
           ResultType = new BindingList<PipeTestResultTypeWrapper>();

           foreach (string controlTypeName in Enum.GetNames(typeof(PipeTestControlType)))
           {
               if (controlTypeName != Enum.GetName(typeof(PipeTestControlType), PipeTestControlType.Undef))
               ControlType.Add(new PipeTestControlTypeWrapper()
               {
                   Value = (PipeTestControlType)Enum.Parse(typeof(PipeTestControlType), controlTypeName),
                   Text = Resources.ResourceManager.GetString("InspectionControlType_" + controlTypeName)
               }
               );
           }

           foreach (string resultTypeName in Enum.GetNames(typeof(PipeTestResultType)))
           {
               if (resultTypeName != Enum.GetName(typeof(PipeTestResultType), PipeTestResultType.Undef))
               ResultType.Add(new PipeTestResultTypeWrapper()
               {
                   Value = (PipeTestResultType)Enum.Parse(typeof(PipeTestResultType), resultTypeName),
                   Text = Resources.ResourceManager.GetString("InspectionResultType_" + resultTypeName)
               }
               );
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

        public string MillName
        {
            get 
            {
                return CurrentProjectSettings.MillName;
            }
            set
            {
                if (value != CurrentProjectSettings.MillName)
                {
                    CurrentProjectSettings.MillName = value;
                    RaisePropertyChanged("MillName");
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

        public string MillPipeNumberMask
        {
            get
            {
                return CurrentProjectSettings.MillPipeNumberMask;
            }
            set
            {
                if (value != CurrentProjectSettings.MillPipeNumberMask)
                {
                    CurrentProjectSettings.MillPipeNumberMask = value;
                    StringBuilder mask = new StringBuilder();
                    foreach (char ch in CurrentProjectSettings.MillPipeNumberMask)
                    {
                        string convertedToRegex = "";
                        switch (ch)
                        { 
                            case '#': convertedToRegex = @"\d";break;
                            case '@': convertedToRegex = @"\p{L}"; break;
                            case '%': convertedToRegex = @"(\d|\p{L})"; break;
                            case '&': convertedToRegex = @"\w"; break;
                            default: convertedToRegex = ch.ToString(); break;

                        }
                        mask.Append(convertedToRegex);
                    }
                    CurrentProjectSettings.MillPipeNumberMaskRegexp = mask.ToString();
                    RaisePropertiesChanged("MillPipeNumberMask");
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

           Welders.ListChanged += (s, e) => ModifiableView.IsModified = true;
        }

        void GetAllInspectors()
        {
           if (Inspectors == null)
              Inspectors = new BindingList<InspectorViewType>();

           var foundInspectors = repos.InspectorRepo.GetAll();
           if (foundInspectors != null)
           {
              foreach (Inspector i in foundInspectors)
              {
                 Inspectors.Add(new InspectorViewType(i));
              }
           }

           Inspectors.ListChanged += (s, e) => ModifiableView.IsModified = true;
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

            CurrentProjectSettings = repos.ProjectRepo.GetSingle();
        }

        private void GetAllManufacturers()
        {
           var  foundPlateManufacturers = repos.PlateManufacturerRepo.GetAll().ToList();
           PlateManufacturers = new BindingList<PlateManufacturer>(foundPlateManufacturers);
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
            repos.Dispose();
            ModifiableView = null;
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

        public IModifiable ModifiableView
        {
           get
           {
              return modifiable;
           }
           set
           {
              modifiable = value;
           }
        }
        
    }
}
