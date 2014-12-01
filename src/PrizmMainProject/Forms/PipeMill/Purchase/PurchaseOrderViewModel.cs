using Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Domain.Entity.Mill;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.Purchase
{
    public class PurchaseOrderViewModel : ViewModelBase, IDisposable
    {
        private readonly IPurchaseOrderRepository repo;
        private readonly SaveOrderCommand saveCommand;

        private PurchaseOrder order;

        [Inject]
        public PurchaseOrderViewModel(IPurchaseOrderRepository repo, Guid id)
        {
            this.repo = repo;
            saveCommand = ViewModelSource.Create(() => new SaveOrderCommand(repo, this));

            if (id == Guid.Empty)
            {
                NewOrder();
            }
            else
            {
                LoadOrder(id);
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

        private void LoadOrder(Guid id)
        {
            order = repo.Get(id);
        }

        private void NewOrder()
        {
            order = new PurchaseOrder() { Number = string.Empty, Date = DateTime.Now, IsActive = true };
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
