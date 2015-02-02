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
using Prizm.Data.DAL;

namespace Prizm.Main.Forms.PipeMill.Purchase
{
    public class SaveOrderCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveOrderCommand));

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
                try
                {
                    repo.BeginTransaction();
                    repo.SaveOrUpdate(viewModel.Order);
                    repo.Commit();
                    viewModel.IsSaved = true;
                }
                catch (RepositoryException ex)
                {
                    log.Error(ex.Message);
                }
            }
            
        }

        public bool CanExecute()
        {
            return true;
        }

    }
}
