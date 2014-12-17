using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Domain.Entity.Mill;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class ExtractPurchaseOrderCommand : ICommand
    {

        readonly IPurchaseOrderRepository repo;
        readonly MillPipeNewEditViewModel viewModel;

        public ExtractPurchaseOrderCommand(MillPipeNewEditViewModel viewModel, IPurchaseOrderRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }


        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.PurchaseOrders = repo.GetAll();
            if(viewModel.PurchaseOrders == null)
            {
                viewModel.PurchaseOrders = new List<PurchaseOrder>();
            }
        }

        public bool CanExecute()
        {
            return true;
        }
        public virtual bool IsExecutable { get; set; }
    }
}
