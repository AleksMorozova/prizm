using Prizm.Data.DAL;
using Prizm.Main.Commands;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class JointCutCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(JointCutCommand));

        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public JointCutCommand(
            IConstructionRepository repo, 
            JointNewEditViewModel viewModel, 
            IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        public void Execute()
        {
            if (notify.ShowYesNo(
                   Program.LanguageManager.GetString(StringResources.Joint_WithdrawQuestion),
                   Program.LanguageManager.GetString(StringResources.Joint_WithdrawQuestionHeader)))
            {
                try
                {
                    viewModel.JointDisconnection();

                    viewModel.FirstElement = null;
                    viewModel.SecondElement = null;

                    viewModel.Joint.FirstElement = null;
                    viewModel.Joint.SecondElement = null;

                    viewModel.JointConstructionStatus = Domain.Entity.Construction.JointStatus.Withdrawn;

                    repo.BeginTransaction();
                    repo.RepoJoint.SaveOrUpdate(viewModel.Joint);
                    repo.Commit();
                    repo.RepoJoint.Evict(viewModel.Joint);

                    viewModel.ModifiableView.IsModified = false;
                }
                catch (RepositoryException ex)
                {
                    log.Error(ex.Message);
                    notify.ShowFailure(ex.InnerException.Message, ex.Message);
                }
            }
        }


        public bool CanExecute()
        {
            return true;
        }
    }
}
