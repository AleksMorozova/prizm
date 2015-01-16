using Prizm.Data.DAL;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using Prizm.Main.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class SaveOrUpdateJointCommand: ICommand
    {
        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveOrUpdateJointCommand(
            IConstructionRepository repo, 
            JointNewEditViewModel viewModel, 
            IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        public void Execute()
        {
            try
            {
                repo.BeginTransaction();
                repo.RepoJoint.SaveOrUpdate(viewModel.Joint);
                repo.Commit();
                repo.RepoJoint.Evict(viewModel.Joint);

                viewModel.ModifiableView.IsModified = false;

                //saving attached documents
                if (viewModel.FilesFormViewModel != null)
                {
                    viewModel.FilesFormViewModel.Item = viewModel.Joint.Id;
                    viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
                    viewModel.FilesFormViewModel = null;
                }

                viewModel.ModifiableView.UpdateState();

                notify.ShowNotify(
                    string.Concat(Resources.DLG_JOINT_SAVED, viewModel.Number),
                    Resources.DLG_JOINT_SAVED_HEADER);
            }
            catch (RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
        }


        public bool CanExecute()
        {
             return !string.IsNullOrEmpty(viewModel.Number) 
                 && viewModel.FirstElement != null 
                 && viewModel.SecondElement != null
                 && viewModel.Joint.IsActive
                 && ctx.HasAccess(viewModel.IsNew 
                                    ? global::Domain.Entity.Security.Privileges.NewDataEntry
                                    : global::Domain.Entity.Security.Privileges.EditData);
        }
    }
}
