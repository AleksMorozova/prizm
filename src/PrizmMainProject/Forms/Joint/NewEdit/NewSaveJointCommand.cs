using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;


namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class NewSaveJointCommand : ICommand
    {
        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        public NewSaveJointCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.SaveJointCommand.Execute();

            if (viewModel.Number != string.Empty)
            {
                viewModel.NewJoint();
            }
            viewModel.CheckDeactivation();
        }
        public virtual bool IsExecutable { get; set; }

        protected virtual void OnIsExecutableChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Execute());
        }

        public bool CanExecute()
        {
            return viewModel.SaveJointCommand.CanExecute();
        }
    }
}
