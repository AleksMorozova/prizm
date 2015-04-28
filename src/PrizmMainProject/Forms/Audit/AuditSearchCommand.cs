using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Prizm.Domain.Entity;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Audit
{
    public class AuditSearchCommand : ICommand
    {
        readonly IAuditLogRepository repo;
        readonly AuditViewModel viewModel;
        private readonly IUserNotify notify;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(AuditSearchCommand));

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public AuditSearchCommand(AuditViewModel viewModel, IAuditLogRepository repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (Prizm.Main.Common.DateExtension.CheckDiapason(viewModel.StartDate, viewModel.EndDate))
            {
                if (viewModel.TracingMode == TracingModeEnum.TracingByNumber)
                {
                    IList<AuditLog> results = new List<AuditLog>();
                    try
                    {
                        results = repo.GetRecordsByNumber(viewModel.Number, viewModel.StartDate, viewModel.EndDate, viewModel.OperationTypes);
                    }
                    catch(RepositoryException ex)
                    {
                        log.Warn("AuditSearchCommandExecute " + ex.ToString());
                        notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
                    Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
                    }
                    
                    viewModel.AuditResults = new BindingList<AuditLog>(results);
                }
                else if (viewModel.TracingMode == TracingModeEnum.TracingByUser)
                {
                    IList<AuditLog> results = new List<AuditLog>();
                    try
                    {
                        results = repo.GetRecordsByUser(viewModel.SelectedUser, viewModel.StartDate, viewModel.EndDate, viewModel.OperationTypes);
                    }
                    catch(RepositoryException ex)
                    {
                        log.Warn("AuditSearchCommandExecute " + ex.ToString());
                        notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
                    Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
                    }
                    
                    viewModel.AuditResults = new BindingList<AuditLog>(results);
                }
            }
            else
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.WrongDate),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                log.Warn("Date limits not valid!" + "Diapason: start date= "
                    + viewModel.StartDate.ToString() + " end date= " + viewModel.EndDate.ToString());
            }

        }
        public bool CanExecute()
        {
            return viewModel.OperationTypes.Count > 0;
        }

    }
}
