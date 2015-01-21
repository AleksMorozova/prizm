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


namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class JointDeactivationCommand : ICommand
    {
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
                   Resources.DLG_JOINT_DEACTIVATION,
                   Resources.DLG_JOINT_DEACTIVATION_HEADER))
            {              
                viewModel.JointIsActive = false;
                viewModel.Joint.Status = Domain.Entity.Construction.JointStatus.Deactivated;
                repo.BeginTransaction();
                repo.RepoJoint.Save(viewModel.Joint);
                repo.Commit();
                repo.RepoJoint.Evict(viewModel.Joint);
                viewModel.ModifiableView.IsEditMode = false;
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
