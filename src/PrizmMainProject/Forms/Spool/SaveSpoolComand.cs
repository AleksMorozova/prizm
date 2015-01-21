using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Properties;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Security;
using Ninject;

namespace Prizm.Main.Forms.Spool
{
    public class SaveSpoolCommand: ICommand
    {
        readonly ISpoolRepositories repos;
        readonly SpoolViewModel viewModel;
        readonly IUserNotify notify;
        readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveSpoolCommand(SpoolViewModel viewModel, ISpoolRepositories repos, IUserNotify notify, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute() 
        {
            if (viewModel.Spool.Length != 0)
            {
                if (viewModel.CanCut)
                {
                    viewModel.Pipe.ToExport = true;
                    viewModel.Pipe.IsCutOnSpool = true;
                    repos.BeginTransaction();
                    repos.PipeRepo.SaveOrUpdate(viewModel.Pipe);
                    repos.SpoolRepo.SaveOrUpdate(viewModel.Spool);
                    repos.Commit();
                    repos.PipeRepo.Evict(viewModel.Pipe);
                    repos.SpoolRepo.Evict(viewModel.Spool);

            //saving attached documents
            if (viewModel.FilesFormViewModel != null)
            {
               viewModel.FilesFormViewModel.Item = viewModel.Spool.Id;
               viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
               viewModel.FilesFormViewModel = null;
            }
                    viewModel.ModifiableView.IsModified = false;
                    notify.ShowNotify(Resources.Cut_Spool_from_pipe, Resources.Cut_Spool_from_pipe_Header);
                    string oldPipeNumber = viewModel.Pipe.Number;
                    viewModel.NewSpool();
                    viewModel.PipeNumber = oldPipeNumber;
                    RefreshVisualStateEvent();
                }
                else 
                {
                    notify.ShowError(Resources.Wrong_Spool_Lengs_MorePipeLength, Resources.Cut_Spool_from_pipe_Header);
                    viewModel.ModifiableView.IsEditMode = true;
                }
            }
            else
            {
                notify.ShowError(Resources.Wrong_Spool_Length_NullLength, Resources.Cut_Spool_from_pipe_Header);
                viewModel.ModifiableView.IsEditMode = true;
            }
            
        }

        public bool CanExecute()
        {
            return viewModel.ModifiableView.IsEditMode 
                &&viewModel.SpoolIsActive
                &&!string.IsNullOrEmpty(viewModel.PipeNumber)
                && ctx.HasAccess(viewModel.IsNew
                    ? global::Domain.Entity.Security.Privileges.NewDataEntry
                    : global::Domain.Entity.Security.Privileges.EditData);
        }
    }
}
