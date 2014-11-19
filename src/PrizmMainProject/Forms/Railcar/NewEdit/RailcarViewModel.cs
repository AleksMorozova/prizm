using System;
using Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using PrizmMain.Commands;
using System.ComponentModel;
using Domain.Entity.Mill;
using System.Collections.Generic;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public class RailcarViewModel : ViewModelBase, IDisposable
    {
        private readonly IRailcarRepository railcarRepo;
        private readonly IPipeRepository pipeRepo;
        private readonly SaveRailcarCommand saveCommand;
        private List<Pipe> allPipes;

        [Inject]
        public RailcarViewModel(IRailcarRepository repo,IPipeRepository pipeRepo, string railcarNumber)
        {
            this.railcarRepo = repo;
            this.pipeRepo = pipeRepo;

            allPipes = new List<Pipe>(pipeRepo.GetAll());

            saveCommand = ViewModelSource.Create(() => new SaveRailcarCommand(this, repo));

            if (string.IsNullOrWhiteSpace(railcarNumber))
            {
                NewRailcar();
            }
            else
            {
                Railcar = repo.GetByNumber(railcarNumber);
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

        public DateTime? ShippingDate
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

        // removed by client?
        //public DateTime DeliveryDate
        //{
        //    get { return Railcar.DeliveryDate; }
        //    set
        //    {
        //        if (value != Railcar.DeliveryDate)
        //        {
        //            Railcar.DeliveryDate = value;
        //            RaisePropertyChanged("DeliveryDate");
        //        }
        //    }
        //}

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

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        public void Dispose()
        {
            railcarRepo.Dispose();
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

            Pipes.Add(allPipes.Find(_ => _.Id.Equals(id)));
        }

        public void RemovePipe(string number)
        {
            foreach (var pipe in Pipes)
            {
                if (pipe.Number == number)
                {
                    Pipes.Remove(pipe);
                    pipe.Railcar = null;
                    pipeRepo.Merge(pipe);
                    return;
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
            ShippingDate = DateTime.Now;
            Certificate = string.Empty;
            Pipes = new List<Pipe>();
        }

        
    }
}