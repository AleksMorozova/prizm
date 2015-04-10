using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Common;
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
    public class SaveOrderCommand : BaseCommand
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
        public override void Execute()
        {
            if(!viewModel.Date.IsValid())
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.WrongDate),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                log.Warn("Date limits not valid!");
                return;
            }

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
                    viewModel.Order.Number = viewModel.Order.Number.ToUpper();
                    repo.BeginTransaction();
                    repo.SaveOrUpdate(viewModel.Order);
                    repo.Commit();
                    viewModel.IsSaved = true;

                    log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.",
                        viewModel.Order.Number,
                        viewModel.Order.Id));
                }
                catch (RepositoryException ex)
                {
                    log.Error(ex.Message);
                }
            }
            
        }

        public override bool CanExecute()
        {
            return true;
        }

    }
}
