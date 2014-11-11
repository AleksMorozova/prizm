using System;
using Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using PrizmMain.Commands;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public class RailcarViewModel : ViewModelBase, IDisposable
    {
        private readonly IRailcarRepository repo;
        private readonly SaveRailcarCommand saveCommand;

        [Inject]
        public RailcarViewModel(IRailcarRepository repo)
        {
            this.repo = repo;
            saveCommand = ViewModelSource.Create(() => new SaveRailcarCommand(this, repo));
            NewRailcar();
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
            get { return Railcar.ShippingDate; }
            set
            {
                if (value != Railcar.ShippingDate)
                {
                    Railcar.ShippingDate = value;
                    RaisePropertyChanged("ShippingDate");
                }
            }
        }

        public DateTime DeliveryDate
        {
            get { return Railcar.DeliveryDate; }
            set
            {
                if (value != Railcar.DeliveryDate)
                {
                    Railcar.DeliveryDate = value;
                    RaisePropertyChanged("DeliveryDate");
                }
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

        public void NewRailcar()
        {
            if (Railcar == null)
            {
                Railcar = new Domain.Entity.Mill.Railcar {IsActive = true};
            }
            Number = string.Empty;
            Destination = string.Empty;
            ShippingDate = DateTime.Now;
            Certificate = string.Empty;
        }
    }
}