using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Commands;
using Prizm.Main.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class QuickSearchCommand : ICommand
    {
        private readonly IJointRepository repo;
        private readonly JointNewEditViewModel viewModel;
        JointSelectDialog dialog = null;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(QuickSearchCommand));
        IUserNotify notify;
        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };
        [Inject]
        public QuickSearchCommand(JointNewEditViewModel vm, IJointRepository repo, IUserNotify notify)
        {
            viewModel = vm;
            this.repo = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            try
            {
            IList<Prizm.Domain.Entity.Construction.Joint> list = repo.QuickSearchByNumber(viewModel.SearchNumber);
            if (dialog == null)
            {
                dialog = new JointSelectDialog(list, viewModel);
            }
            else
            {
                dialog.SetupForm(list, viewModel);
            }

            dialog.ShowDialog();
            }
            catch(RepositoryException ex)
            {
                log.Warn(this.GetType().Name + " | " + ex.ToString());
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
