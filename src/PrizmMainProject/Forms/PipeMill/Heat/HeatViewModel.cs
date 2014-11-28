using Data.DAL.Mill;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entity.Mill;
using PrizmMain.Commands;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public class HeatViewModel : ViewModelBase, IDisposable
    {
        private readonly IHeatRepositories repo;
        private readonly SaveHeatCommand saveCommand;

        [Inject]
        public HeatViewModel(IHeatRepositories heatRepository, string heatNumber)
        {
            this.repo = heatRepository;
            saveCommand = ViewModelSource.Create(() => new SaveHeatCommand(this, repo));

            if (string.IsNullOrWhiteSpace(heatNumber))
            {
                HeatsList();
            }
            else
            {
                var heat = GetHeatByNumber(heatNumber);
                if (heat != null)
                {
                    Heat = heat;
                }
                else
                {
                    HeatsList();
                }
            }
         
        }

        #region Property
        Domain.Entity.Mill.Heat heat;
        public Domain.Entity.Mill.Heat Heat
        {
            get { return heat; }
            set
            {
                if (value != heat)
                {
                    heat = value;
                    RaisePropertyChanged("Heat");
                }
            }
        }

        IList<Domain.Entity.Mill.Heat> heats;
        public IList<Domain.Entity.Mill.Heat> Heats
        {
            get { return heats; }
        }
        
        public string SteelGrade
        {
            get { return Heat.SteelGrade; }
            set
            {
                if (value != Heat.SteelGrade)
                {
                    Heat.SteelGrade = value;
                    RaisePropertyChanged("SteelGrade");
                }
            }
        }

        public PlateManufacturer PlateManufacturer
        {
            get
            {
                if (Heat.PlateManufacturer != null)
                {
                    return Heat.PlateManufacturer;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value != Heat.PlateManufacturer)
                {
                    Heat.PlateManufacturer = value;
                    RaisePropertyChanged("PlateManufacturer");
                }
            }
        }

        IList<PlateManufacturer> manufacrurers;
        public IList<PlateManufacturer> Manufacrurers
        {
            get { return manufacrurers; }
        }

        #endregion

        private void HeatsList()
        {
            heats = new List<Domain.Entity.Mill.Heat>(repo.HeatRepo.GetAll().ToList());
            heat = heats[0];
            manufacrurers = new List<PlateManufacturer>(repo.PlateManRepo.GetAll().ToList());
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
            Heat = new Domain.Entity.Mill.Heat()
            {
                
            };
        }

        internal Domain.Entity.Mill.Heat GetHeatByNumber(string number)
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
