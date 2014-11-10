using System.ComponentModel;

namespace PrizmMain.Forms.Railcar.Edit
{
   using DevExpress.Mvvm;
   using DevExpress.Mvvm.DataAnnotations;
   using DevExpress.Mvvm.POCO;
   using Domain.DAL;
   using Domain.DAL.Hibernate;
   using Ninject;
   using PrizmMain.Commands;
   using System;
   using System.Windows.Forms;
   using Railcar = Domain.Entity.Mill.Railcar;

   public class RailcarViewModel : ViewModelBase, IDisposable
   {
      public Railcar Railcar { get; set; }
      readonly SaveRailcarCommand saveCommand;
      readonly IRailcarRepository repo;

      [Inject]
      public RailcarViewModel(IRailcarRepository repo)
      {
         this.repo = repo;
         saveCommand = ViewModelSource.Create<SaveRailcarCommand>(() => new SaveRailcarCommand(this, repo));
         NewRailcar();
      }

      public string Number 
      { 
         get
         {
            return Railcar.Number;
         }
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
         get
         {
            return Railcar.Certificate;
         }
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
         get
         {
            return Railcar.Destination;
         }
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
            return Railcar.ShippingDate;
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

      public DateTime DeliveryDate 
      {
         get
         {
            return Railcar.DeliveryDate;
         }
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

      public void NewRailcar()
      {
         if (Railcar == null)
         {
            Railcar = new Railcar();
         }
         Railcar.Id = Guid.NewGuid();
         Number = string.Empty;
         Destination = string.Empty;
         ShippingDate = DateTime.Now;
         Certificate = string.Empty;
      }

      public void Dispose()
      {
         repo.Dispose();
      }
   }
}
