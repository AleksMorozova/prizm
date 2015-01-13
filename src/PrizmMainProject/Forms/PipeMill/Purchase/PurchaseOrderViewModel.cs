using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Prizm.Domain.Entity.Mill;
using Ninject;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity;

namespace Prizm.Main.Forms.PipeMill.Purchase
{
    public class PurchaseOrderViewModel : ViewModelBase, IDisposable
    {
        private readonly IPurchaseOrderRepository repo;
        private readonly SaveOrderCommand saveCommand;
        private readonly IUserNotify notify;

        public bool IsSaved = false;

        private PurchaseOrder order;

        public bool IsNew { get { return this.order.IsNew(); } }
        
        [Inject]
        public PurchaseOrderViewModel(IPurchaseOrderRepository repo, string number, IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;
            saveCommand = ViewModelSource.Create(() => new SaveOrderCommand(repo, this, notify));

            if (string.IsNullOrWhiteSpace(number))
            {
                NewOrder(number);
            }
            else 
            {
                var ord = LoadOrder(number);
                if(ord != null)
                {
                    order = ord;
                }
                else
                {
                    NewOrder(number);
                }
            }
        }

        #region BindingFields
        public string Number
        {
            get { return order.Number; }
            set
            {
                if (value != order.Number)
                {
                    order.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public DateTime Date
        {
            get { return order.Date; }
            set
            {
                if (value != order.Date)
                {
                    order.Date = value;
                    RaisePropertyChanged("Date");
                }
            }
        }

        public PurchaseOrder Order
        {
            get { return order; }
            set
            {
                if (value != order)
                {
                    order = value;
                    RaisePropertyChanged("Order");
                }
            }
        }

        #endregion

        public ICommand SaveCommand 
        {
            get { return saveCommand; }
        }

        private PurchaseOrder LoadOrder(string number)
        {
            return repo.GetByNumber(number);
        }

        private void NewOrder(string number)
        {
            order = new PurchaseOrder() { Number = number, Date = DateTime.Now, IsActive = true };
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
