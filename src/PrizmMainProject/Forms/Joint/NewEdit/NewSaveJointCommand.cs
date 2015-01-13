using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
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
    public class NewSaveJointCommand : ICommand
    {
        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public NewSaveJointCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.ValidatableView.Validate())
            {
                return;
            }

            viewModel.SaveJointCommand.Execute();

            if (viewModel.Number != string.Empty)
            {
                viewModel.NewJoint();
            }
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return viewModel.SaveJointCommand.CanExecute() 
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.NewDataEntry);
        }
    }
}
