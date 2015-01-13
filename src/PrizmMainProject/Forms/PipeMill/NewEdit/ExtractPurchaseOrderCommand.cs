using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class ExtractPurchaseOrderCommand : ICommand
    {

        readonly IPurchaseOrderRepository repo;
        readonly MillPipeNewEditViewModel viewModel;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

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
    }
}
