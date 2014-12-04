using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.Purchase
{
    public class SaveOrderCommand : ICommand
    {
        IPurchaseOrderRepository repo;
        PurchaseOrderViewModel viewModel;
        IUserNotify notify;

        [Inject]
        public SaveOrderCommand(IPurchaseOrderRepository repo, PurchaseOrderViewModel viewModel, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (string.IsNullOrWhiteSpace(viewModel.Order.Number))
            {
                viewModel.IsSaved = false;
                notify.ShowError(Resources.DLG_ORDER_NUMBER_REQUIRED, Resources.DLG_ERROR_HEADER);
            }
            else
            {
                repo.BeginTransaction();
                repo.SaveOrUpdate(viewModel.Order);
                repo.Commit();
                viewModel.IsSaved = true;
            }
            
        }

        public bool CanExecute()
        {
            return true;
        }

        public bool IsExecutable { get; set; }
    }
}
