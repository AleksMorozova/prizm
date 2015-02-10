using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Security;
using Ninject;
using Prizm.Main.Properties;
using Prizm.Main.Languages;


namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class NewSaveJointCommand : ICommand
    {
        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public NewSaveJointCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify, ISecurityContext ctx)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
            this.ctx = ctx;
        }

        public void Execute()
        {
            if (!viewModel.ValidatableView.Validate()) { return; }

            if(!DateCheck()){ return;}

            if (viewModel.Joint.LoweringDate == DateTime.MinValue)
            {
                viewModel.Joint.LoweringDate = null;
            }

            var joints = repo.RepoJoint.GetActiveByNumber(viewModel.Joint);

            foreach (var joint in joints) { repo.RepoJoint.Evict(joint); }

            if (joints != null && joints.Count > 0)
            {
                notify.ShowInfo(
                    string.Concat(Program.LanguageManager.GetString(StringResources.Joint_Duplicate), viewModel.Number),
                    Program.LanguageManager.GetString(StringResources.Joint_DuplicateHeader));
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
                }
                else
                {
                    notify.ShowInfo(
                    Program.LanguageManager.GetString(StringResources.Joint_IncorrectDiameter),
                    Program.LanguageManager.GetString(StringResources.Joint_IncorrectDiameterHeader));
                }

                viewModel.NewJoint();
            }

            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return viewModel.SaveOrUpdateJointCommand.CanExecute() 
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.CreateJoint)
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditJoint);
        }

        private bool DateCheck()
        {
            bool result = true;
            if(!viewModel.Joint.LoweringDate.IsValid())
            {
                result = false;
            }
            if(!viewModel.JointTestResults.All(x => x.Date.IsValid()))
            {
                result = false;
            }
            if(!viewModel.JointWeldResults.All(x => x.Date.IsValid()))
            {
                result = false;
            }
            return result;
        }
    }
}
