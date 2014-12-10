using Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using PrizmMain.Properties;
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
            try
            {

                repo.BeginTransaction();
                repo.RepoJoint.SaveOrUpdate(viewModel.Joint);
                repo.Commit();
                repo.RepoJoint.Evict(viewModel.Joint);
                viewModel.ModifiableView.IsModified = false;
                notify.ShowNotify(
                    string.Concat(Resources.DLG_PIPE_SAVED, viewModel.Number),
                    Resources.DLG_PIPE_SAVED_HEADER);
            }
            catch (RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
        }

        public virtual bool IsExecutable { get; set; }

        public bool CanExecute()
        {
            return true;
        }
    }
}
