using Data.DAL.Mill;
using DevExpress.Mvvm.POCO;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Mvvm;
using Domain.Entity.Mill;


namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class MillPipeNewEditViewModel: ViewModelBase, IDisposable
    {

        private readonly IPipeRepository repo;
        private readonly MillPipeNewEditCommand newEditCommand;

        public Pipe Pipe { get; set; }

        [Inject]
        public MillPipeNewEditViewModel(IPipeRepository repo, string pipeNumber)
        {
            this.repo = repo;
            newEditCommand = ViewModelSource.Create(() => new MillPipeNewEditCommand(this, repo));

            if (string.IsNullOrWhiteSpace(pipeNumber))
            {
                NewPipe();
            }
            else
            {
                Pipe = repo.GetByNumber(pipeNumber);
            }
        }


        


        public string Number
        {
            get { return Pipe.Number; }
            set
            {
                if (value != Pipe.Number)
                {
                    Pipe.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public int Diameter
        {
            get { return Pipe.Diameter; }
            set
            {
                if (value != Pipe.Diameter)
                {
                    Pipe.Diameter = value;
                    RaisePropertyChanged("Diameter");
                }
            }
        }

        public int Length
        {
            get { return Pipe.Length; }
            set
            {
                if (value != Pipe.Length)
                {
                    Pipe.Length = value;
                    RaisePropertyChanged("Length");
                }
            }
        }

        public int Weight
        {
            get { return Pipe.Weight; }
            set
            {
                if (value != Pipe.Weight)
                {
                    Pipe.Weight = value;
                    RaisePropertyChanged("Weight");
                }
            }
        }

        public int WallThickness
        {
            get { return Pipe.WallThickness; }
            set
            {
                if (value != Pipe.WallThickness)
                {
                    Pipe.WallThickness = value;
                    RaisePropertyChanged("WallThickness");
                }
            }
        }

        public string Mill
        {
            get { return Pipe.Mill; }
            set
            {
                if (value != Pipe.Mill)
                {
                    Pipe.Mill = value;
                    RaisePropertyChanged("Mill");
                }
            }
        }

        public Plate Plate
        {
            get { return Pipe.Plate; }
            set
            {
                if (value != Pipe.Plate)
                {
                    Pipe.Plate = value;
                    RaisePropertyChanged("Plate");
                }
            }
        }
        public Domain.Entity.Mill.Heat Heat
        {
            get { return Pipe.Plate.Heat; }
            set
            {
                if (value != Pipe.Plate.Heat)
                {
                    Pipe.Plate.Heat = value;
                    RaisePropertyChanged("Heat");
                }
            }
        }

        public ICommand NewEditCommand
        {
            get { return newEditCommand; }
        }

        public void Dispose()
        {
            repo.Dispose();
        }


        public void NewPipe()
        {
            if (Pipe == null)
            {
                Pipe = new Pipe();
            }

            NewPlate();

            Number = string.Empty;
            Mill = string.Empty;
            WallThickness = 0;
            Weight = 0;
            Length = 0;
            Diameter = 0;
        }

        public void NewPlate()
        {
            if (Plate == null)
            {
                Plate = new Plate();
            }

            NewHeat();

        }

        public void NewHeat()
        {
            if (Heat == null)
            {
                Heat = new Domain.Entity.Mill.Heat();
            }
        }
    }
}
