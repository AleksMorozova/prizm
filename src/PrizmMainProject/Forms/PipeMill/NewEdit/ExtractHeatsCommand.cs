using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using NHibernate.Criterion;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class ExtractHeatsCommand : ICommand
    {
        readonly IHeatRepository repo;
        readonly MillPipeNewEditViewModel viewModel;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ExtractHeatsCommand));
        IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public ExtractHeatsCommand(MillPipeNewEditViewModel viewModel, IHeatRepository repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }


        [Command(UseCommandManager = false)]
        public void Execute()
        {
            try
            {
                viewModel.Heats = repo.GetAll();
                if(viewModel.Heats == null)
                {
                    viewModel.Heats = new List<Prizm.Domain.Entity.Mill.Heat>();
                }
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
