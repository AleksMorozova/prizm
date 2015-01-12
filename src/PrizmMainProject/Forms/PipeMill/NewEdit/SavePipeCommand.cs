using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Properties;
using Prizm.Data.DAL;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class SavePipeCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public SavePipeCommand(
            MillPipeNewEditViewModel viewModel, 
            IMillRepository repo, 
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.ValidatableView.Validate())
            {
                return;
            }

            var p = repo.RepoPipe.GetActiveByNumber(viewModel.Pipe);
            foreach (var pipe in p)
            {
                repo.RepoPipe.Evict(pipe);
            }

            if (p != null && p.Count > 0)
            {
                notify.ShowInfo(
                    string.Concat(Resources.DLG_PIPE_DUPLICATE, viewModel.Number),
                    Resources.DLG_PIPE_DUPLICATE_HEDER);
                viewModel.Number = string.Empty;
            }
            else
            {
                if (viewModel.CheckStatus())
                {
                    try
                    {

                        repo.BeginTransaction();
                        repo.RepoPipe.SaveOrUpdate(viewModel.Pipe);
                        repo.Commit();
                        repo.RepoPipe.Evict(viewModel.Pipe);

                        //saving attached documents
                        if (viewModel.FilesFormViewModel != null)
                        {
                            viewModel.FilesFormViewModel.Item = viewModel.Pipe.Id;
                            viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
                            viewModel.FilesFormViewModel = null;
                        }

                        viewModel.ModifiableView.IsModified = false;
                        viewModel.ModifiableView.UpdateState();
                        notify.ShowNotify(
                            string.Concat(Resources.DLG_PIPE_SAVED, viewModel.Number),
                            Resources.DLG_PIPE_SAVED_HEADER);
                    }
                    catch (RepositoryException ex)
                    {
                        notify.ShowFailure(ex.InnerException.Message, ex.Message);
                    }
                }
                else 
                {
                    notify.ShowInfo(Resources.DLG_AddFailedControlOperation, Resources.DLG_PIPE_SAVED_HEADER);
                }
            }
        }


        public virtual bool IsExecutable { get; set; }

        protected virtual void OnIsExecutableChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Execute());
        }

        public bool CanExecute()
        {
            bool condition = viewModel.Heat != null &&
                viewModel.PipeMillSizeType != null &&
                viewModel.PipePurchaseOrder != null &&
                !string.IsNullOrEmpty(viewModel.Number) &&
                viewModel.ProductionDate != DateTime.MinValue &&
                viewModel.ModifiableView.IsEditMode;
            bool conditionAndPermission;
            if (viewModel.Pipe.Id == Guid.Empty)
            {
                conditionAndPermission = condition && ctx.HasAccess(global::Domain.Entity.Security.Privileges.NewDataEntry);
            }
            else
            {
                conditionAndPermission = condition && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditData);
            }
            return conditionAndPermission;
        }
    
    }
}
