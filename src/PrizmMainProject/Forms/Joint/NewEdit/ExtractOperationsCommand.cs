using DevExpress.Mvvm.DataAnnotations;
using Domain.Entity.Setup;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Joint.NewEdit
{
    public class ExtractOperationsCommand : ICommand
    {
        readonly IConstructionRepository repo;
        readonly JointNewEditViewModel viewModel;

        public ExtractOperationsCommand(IConstructionRepository repo, JointNewEditViewModel viewModel)
        {
            this.repo = repo;
            this.viewModel = viewModel;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            var operations = repo.RepoJointOperation.GetAll();
            if (operations != null)
                viewModel.Operations = new BindingList<JointOperation>(operations);
        }

        public bool CanExecute()
        {
            return true;
        }
        public virtual bool IsExecutable { get; set; }
    }
}
