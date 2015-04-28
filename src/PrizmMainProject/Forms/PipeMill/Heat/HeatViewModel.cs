using Prizm.Data.DAL.Mill;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prizm.Domain.Entity.Mill;
using Prizm.Main.Commands;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel;
using System.Windows.Forms;
using Prizm.Main.Properties;
using Prizm.Domain.Entity;
using Prizm.Data.DAL;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.PipeMill.Heat
{
    public class HeatViewModel : ViewModelBase, IDisposable
    {
        private readonly IHeatRepositories repo;
        private readonly SaveHeatCommand saveCommand;
        IUserNotify notify;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(HeatViewModel));

        public bool IsNew { get { return this.Heat.IsNew(); } }

        [Inject]
        public HeatViewModel(IHeatRepositories heatRepository, string heatNumber)
        {
            this.repo = heatRepository;
            saveCommand = ViewModelSource.Create(() => new SaveHeatCommand(this, repo));

            var heat = GetHeatByNumber(heatNumber);
            if(heat != null)
            {
                Heat = heat;
                SetupManufacturers();
                heats = new List<Prizm.Domain.Entity.Mill.Heat>() { heat };
            }

        }

        #region Property
        Prizm.Domain.Entity.Mill.Heat heat;
        public Prizm.Domain.Entity.Mill.Heat Heat
        {
            get { return heat; }
            set
            {
                if(value != heat)
                {
                    heat = value;
                    RaisePropertyChanged("Heat");
                }
            }
        }

        public PlateManufacturer PlateManufacturer
        {
            get
            {
                if(heat.PlateManufacturer != null)
                {
                    return heat.PlateManufacturer;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(value != heat.PlateManufacturer)
                {
                    heat.PlateManufacturer = value;
                    RaisePropertyChanged("PlateManufacturer");
                }
            }
        }

        public string SteelGrade
        {
            get { return Heat.SteelGrade; }
            set
            {
                if(value != Heat.SteelGrade)
                {
                    Heat.SteelGrade = value;
                    RaisePropertyChanged("SteelGrade");
                }
            }
        }

        IList<Prizm.Domain.Entity.Mill.Heat> heats;
        public IList<Prizm.Domain.Entity.Mill.Heat> Heats
        {
            get { return heats; }
        }

        IList<PlateManufacturer> manufacrurers;
        public IList<PlateManufacturer> Manufacrurers
        {
            get { return manufacrurers; }
        }

        #endregion

        private void HeatsList()
        {
            SetupHeats();
            SetupManufacturers();
            heat = heats[0];

        }

        private void SetupHeats()
        {
            try
            {
            heats = new List<Prizm.Domain.Entity.Mill.Heat>(repo.HeatRepo.GetAll().ToList());
            }
            catch(RepositoryException ex)
            {
                log.Warn(this.GetType().Name + " | " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        private void SetupManufacturers()
        {
            try
            {
            manufacrurers = new List<PlateManufacturer>(repo.PlateManRepo.GetAll().ToList());
            }
            catch(RepositoryException ex)
            {
                log.Warn(this.GetType().Name + " | " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }


        public void Dispose()
        {
            repo.Dispose();
        }

        public void NewHeat(string number)
        {
            var heatFromDb = GetHeatByNumber(number);
            if(heatFromDb != null)
            {
                HeatsList();
                return;
            }
            SetupManufacturers();
            Heat = new Prizm.Domain.Entity.Mill.Heat()
            {
                IsActive = true,
                Number = number,
                SteelGrade = string.Empty,
                PlateManufacturer = (manufacrurers.Count == 0)? null : manufacrurers[0],
                Plates = new List<Plate>()
            };


            heats = new List<Prizm.Domain.Entity.Mill.Heat>() { Heat };

        }

        internal Prizm.Domain.Entity.Mill.Heat GetHeatByNumber(string number)
        {
            return repo.HeatRepo.GetByNumber(number);
        }

        internal void GetHeatById(Guid id)
        {
            Heat = repo.HeatRepo.Get(id);
        }

        internal void SetHeat(Guid guid)
        {
            Heat = heats.Where(x => x.Id == guid).FirstOrDefault();
        }
    }
}
