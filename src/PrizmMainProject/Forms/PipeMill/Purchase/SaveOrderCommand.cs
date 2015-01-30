using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.PipeMill.Purchase
{
    public class SaveOrderCommand : ICommand
    {
        IPurchaseOrderRepository repo;
        PurchaseOrderViewModel viewModel;
        IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

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
                notify.ShowError(
                    Program.LanguageManager.GetString(StringResources.PurchaseOrder_ValueRequired),
                     Program.LanguageManager.GetString(StringResources.PurchaseOrder_ErrorHeader)
                     );
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

    }
}
