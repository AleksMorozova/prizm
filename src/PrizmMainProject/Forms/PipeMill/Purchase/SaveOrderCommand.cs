using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using PrizmMain.Commands;
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

        [Inject]
        public SaveOrderCommand(IPurchaseOrderRepository repo, PurchaseOrderViewModel viewModel)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (string.IsNullOrWhiteSpace(viewModel.Order.Number))
            {
                //notify
                return;
            }
            repo.BeginTransaction();
            repo.SaveOrUpdate(viewModel.Order);
            repo.Commit();
        }

        public bool CanExecute()
        {
            return true;
        }

        public bool IsExecutable { get; set; }
    }
}
