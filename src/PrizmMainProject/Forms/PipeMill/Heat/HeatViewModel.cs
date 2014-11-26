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
                NewHeat(heatNumber);
            }
            else
            {
                var answer = repo.HeatRepo.GetByNumber(heatNumber);
                if (answer == null)
                {
                    NewHeat(heatNumber);
                }
                else
                {
                    Heat = answer;
                }
            }
            GetAllHeat();
        }

        private Domain.Entity.Mill.Heat heat;
        public Domain.Entity.Mill.Heat Heat 
        { 
            get {return heat;}
            set 
            {
                if (heat != value)
                {
                    heat = value;
                    RaisePropertyChanged("Heat");
                }
            }
        }

        public string Number
        {
            get { return Heat.Number; }
            set
            {
                if (value != Heat.Number)
                {
                    Heat.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public string Steel
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

        public IList<ChemicalComposition> ChemicalCompositions
        {
            get { return Heat.ChemicalComposition; }
            set
            {
                if (value != Heat.ChemicalComposition)
                {
                    Heat.ChemicalComposition = value;
                    RaisePropertyChanged("ChemicalComposition");
                }
            }
        }

        public IList<PhysicalParameters> PhysicalParameters
        {
            get { return Heat.PhysicalParameters; }
            set
            {
                if (value != Heat.PhysicalParameters)
                {
                    Heat.PhysicalParameters = value;
                    RaisePropertyChanged("PhysicalParameters");
                }
            }
        }

        private IList<Domain.Entity.Mill.Heat> allHeats;
        public IList<Domain.Entity.Mill.Heat> AllHeats { get { return allHeats; } }

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

        private void GetAllHeat()
        {
            allHeats = new List<Domain.Entity.Mill.Heat>(repo.HeatRepo.GetAll().ToList());
        }


        internal void GetHeatByNumber(string number)
        {
            Heat = repo.HeatRepo.GetByNumber(number);
        }
    }
}
