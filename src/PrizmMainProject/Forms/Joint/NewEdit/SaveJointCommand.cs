using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Joint.NewEdit
{
    public class SaveJointCommand : ICommand
    {
        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        public SaveJointCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
        }

        public virtual bool IsExecutable { get; set; }

        public bool CanExecute()
        {
            return true;
        }
    }
}
