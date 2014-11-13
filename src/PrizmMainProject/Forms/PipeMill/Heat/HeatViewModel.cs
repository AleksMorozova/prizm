using Data.DAL.Mill;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Domain.Entity.Mill;
using PrizmMain.Commands;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public class HeatViewModel : ViewModelBase, IDisposable
    {
        private readonly IHeatRepository heatRepo;

        private readonly SaveHeatCommand saveCommand;
        
        [Inject]
        public HeatViewModel(IHeatRepository heatRepository, string heatNumber)
        {
            this.heatRepo = heatRepository;

            if (string.IsNullOrWhiteSpace(heatNumber))
            {
                NewHeat();
            }
            else
            {
                Heat = heatRepo.GetByNumber(heatNumber);
            }
        }

        public void NewHeat()
        {
            if (Heat == null)
            {
                Heat = new Domain.Entity.Mill.Heat(string.Empty, new Domain.Entity.Mill.PhysicalParameters(),
                    new Domain.Entity.Mill.ChemicalComposition()) { IsActive = true };
            }
        }

        public Domain.Entity.Mill.Heat Heat { get; set; }

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

        public ChemicalComposition Chemical
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

        public PhysicalParameters Phisical
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

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }


        public void Dispose()
        {
            heatRepo.Dispose();
        }
    }
}
