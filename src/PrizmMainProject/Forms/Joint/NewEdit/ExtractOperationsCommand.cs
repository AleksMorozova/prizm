using DevExpress.Mvvm.DataAnnotations;
using Prizm.Data.DAL;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Commands;
using Prizm.Main.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class ExtractOperationsCommand : ICommand
    {
        readonly IConstructionRepository repo;
        readonly JointNewEditViewModel viewModel;
        IUserNotify notify;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ExtractOperationsCommand));

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public ExtractOperationsCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            try
            {
                var controlOperations = repo.RepoJointOperation.GetControlOperations();
                viewModel.ControlOperations = new BindingList<JointOperation>(controlOperations);
                var repairOperations = repo.RepoJointOperation.GetRepairOperations();
                viewModel.RepairOperations = new BindingList<JointOperation>(repairOperations);
            }
            catch(RepositoryException ex)
            {
                log.Warn("ExtractOperationsCommand " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }

        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
