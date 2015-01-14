using DevExpress.Mvvm.DataAnnotations;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class ExtractOperationsCommand : ICommand
    {
        readonly IConstructionRepository repo;
        readonly JointNewEditViewModel viewModel;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public ExtractOperationsCommand(IConstructionRepository repo, JointNewEditViewModel viewModel)
        {
            this.repo = repo;
            this.viewModel = viewModel;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            var controlOperations = repo.RepoJointOperation.GetControlOperations();
            viewModel.ControlOperations = new BindingList<JointOperation>(controlOperations);
            var repairOperations = repo.RepoJointOperation.GetRepairOperations();
            viewModel.RepairOperations = new BindingList<JointOperation>(repairOperations);
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
