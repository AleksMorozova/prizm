using System;
using Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using PrizmMain.Commands;
using System.ComponentModel;
using Domain.Entity.Mill;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using PrizmMain.Properties;
using System.Windows.Forms;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public class RailcarViewModel : ViewModelBase, IDisposable
    {
        private readonly IRailcarRepositories repos;
        private readonly SaveRailcarCommand saveCommand;
        private readonly ShipRailcarCommand shipCommand;
        private readonly UnshipRailcarCommand unshipCommand;
        private List<Pipe> allPipes;

        [Inject]
        public RailcarViewModel(IRailcarRepositories repos, string railcarNumber)
        {
            this.repos = repos;

            GetStoredPipes();

            saveCommand = ViewModelSource.Create(() => new SaveRailcarCommand(this, repos));
            shipCommand = ViewModelSource.Create(() => new ShipRailcarCommand(this, repos));
            unshipCommand = ViewModelSource.Create(() => new UnshipRailcarCommand(this, repos));

            if (string.IsNullOrWhiteSpace(railcarNumber))
            {
                NewRailcar();
            }
            else
            {
                Railcar = repos.RailcarRepo.GetByNumber(railcarNumber);
                if (!Railcar.ShippingDate.HasValue)
                {
                    Railcar.ShippingDate = DateTime.MinValue;
                }
            }
            
        }

        public List<Pipe> AllPipes
        {
            get { return allPipes; }
        }

        public Domain.Entity.Mill.Railcar Railcar { get; set; }

        public string Number
        {
            get { return Railcar.Number; }
            set
            {
                if (value != Railcar.Number)
                {
                    Railcar.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public string Certificate
        {
            get { return Railcar.Certificate; }
            set
            {
                if (value != Railcar.Certificate)
                {
                    Railcar.Certificate = value;
                    RaisePropertyChanged("Certificate");
                }
            }
        }

        public string Destination
        {
            get { return Railcar.Destination; }
            set
            {
                if (value != Railcar.Destination)
                {
                    Railcar.Destination = value;
                    RaisePropertyChanged("Destination");
                }
            }
        }

        public DateTime ShippingDate
        {
            get 
            {
                if (Railcar.ShippingDate.HasValue)
                {
                    return Railcar.ShippingDate.Value;
                }
                else
                {
                    return DateTime.MinValue;
                }
            
            }
            set
            {
                if (value != Railcar.ShippingDate)
                {
                    Railcar.ShippingDate = value;
                    RaisePropertyChanged("ShippingDate");
                }
            }
        }

        public IList<Pipe> Pipes
        {
            get { return Railcar.Pipes; }
            set 
            {
                if (value != Railcar.Pipes)
                {
                    Railcar.Pipes = value;
                    RaisePropertyChanged("Pipes");
                }
            }
        }

        #region Commands
        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        public ICommand ShipCommand
        {
            get { return shipCommand; }
        }

        public ICommand UnshipCommand
        {
            get { return unshipCommand; }
        } 
        #endregion

        public void Dispose()
        {
            repos.Dispose();
        }

        public void AddPipe(Guid id)
        {
            foreach (var pipe in Pipes)
	        {
                if (pipe.Id == id)
	            {
		        return;
	            }
	        }
            GetStoredPipes();

            var pipeToAdd = allPipes.Find(_ => _.Id.Equals(id));

            if (!(pipeToAdd.Railcar == null))
            {
                XtraMessageBox.Show(Resources.DLG_RAILCAR_PIPE_IN_OTHER_CAR_ERROR + pipeToAdd.Railcar.Number,
                    Resources.DLG_ERROR_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pipes.Add(pipeToAdd);
            }

            
        }

        public void RemovePipe(string number)
        {
            if (Railcar.ShippingDate != DateTime.MinValue)
            {
                XtraMessageBox.Show(Resources.DLG_RAILCAR_UNSHIP_FIRST, Resources.DLG_ERROR_HEADER,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var pipe in Pipes)
            {
                if (pipe.Number == number)
                {
                    Pipes.Remove(pipe);
                    pipe.Railcar = null;
                    repos.PipeRepo.Merge(pipe);
                    break;
                }
            }
        }

        public void NewRailcar()
        {
            if (Railcar == null)
            {
                Railcar = new Domain.Entity.Mill.Railcar {IsActive = true};
            }
            Number = string.Empty;
            Destination = string.Empty;
            ShippingDate = DateTime.MinValue;
            Certificate = string.Empty;
            Pipes = new List<Pipe>();
        }

        private void GetStoredPipes()
        {
            allPipes = new List<Pipe>(repos.PipeRepo.GetStored());
        }

        
    }
}