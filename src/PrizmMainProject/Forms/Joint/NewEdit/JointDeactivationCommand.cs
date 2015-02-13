using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Security;
using Ninject;
using Prizm.Main.Languages;
using Prizm.Data.DAL;


namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class JointDeactivationCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(JointDeactivationCommand));

        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public JointDeactivationCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify, ISecurityContext ctx)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (notify.ShowYesNo(
                   Program.LanguageManager.GetString(StringResources.Joint_DeactivationQuestion),
                   Program.LanguageManager.GetString(StringResources.Joint_DeactivationQuestionHeader)))
            {
                try
                {
                    viewModel.JointDisconnection();
                    viewModel.JointIsActive = false;

                    repo.BeginTransaction();
                    repo.RepoJoint.Save(viewModel.Joint);
                    repo.Commit();

                    repo.RepoJoint.Evict(viewModel.Joint);

                    viewModel.ModifiableView.IsEditMode = false;
                    viewModel.ModifiableView.IsModified = false;
                    viewModel.ModifiableView.UpdateState();

                    notify.ShowSuccess(
                        string.Concat(Program.LanguageManager.GetString(
                            StringResources.Joint_Deactivated), viewModel.Number),
                        Program.LanguageManager.GetString(
                            StringResources.Joint_DeactivatedHeader));

                    log.Info(string.Format("The Joint #{0}, id:{1} has been deactivated.",
                        viewModel.Joint.Number, viewModel.Joint.Id));
                }
                catch (RepositoryException ex)
                {
                    log.Error(ex.Message);
                    notify.ShowFailure(ex.InnerException.Message, ex.Message);
                }
            }
            else
            {
                viewModel.JointIsActive = true;
            }
            RefreshVisualStateEvent();
        }


        public bool CanExecute()
        {
            return viewModel.Joint.IsActive && 
                   !viewModel.IsNew &&
                   ctx.HasAccess(global::Domain.Entity.Security.Privileges.DeactivateJoint);
        }
    }
}
