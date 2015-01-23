using Prizm.Data.DAL;
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
    public class SaveJointCommand : ICommand
    {
        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveJointCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify, ISecurityContext ctx)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.ValidatableView.Validate())
            {
                return;
            }

            if (viewModel.Joint.LoweringDate == DateTime.MinValue)
            {
                viewModel.Joint.LoweringDate = null;
            }
            var joints = repo.RepoJoint.GetActiveByNumber(viewModel.Joint);
            foreach (var joint in joints)
            {
                repo.RepoJoint.Evict(joint);
            }
            if (joints != null && joints.Count > 0)
            {
                notify.ShowInfo(
                    string.Concat(Resources.DLG_JOINT_DUPLICATE, viewModel.Number),
                    Resources.DLG_JOINT_DUPLICATE_HEADER);
                viewModel.Number = string.Empty;
            }
            else
            {
                if (viewModel.Joint.Status == Domain.Entity.Construction.JointStatus.Withdrawn)
                {
                    viewModel.SaveOrUpdateJointCommand.Execute();
                }
                else if (viewModel.MakeTheConnection())
                {
                    viewModel.SaveOrUpdateJointCommand.Execute();
                    viewModel.JointDisconnection();
                }
                else
                {
                    notify.ShowInfo(
                    Resources.DLG_JOINT_INCORRECT_DIAMETER,
                    Resources.DLG_JOINT_INCORRECT_DIAMETER_HEADER);
                }
            }
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return viewModel.SaveOrUpdateJointCommand.CanExecute();
        }
    }
}
