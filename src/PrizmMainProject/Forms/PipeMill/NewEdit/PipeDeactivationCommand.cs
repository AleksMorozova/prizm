using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Properties;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Security;
using Ninject;
using Prizm.Main.Languages;
using Prizm.Data.DAL;


namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class PipeDeactivationCommand: ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PipeDeactivationCommand));

        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public PipeDeactivationCommand(
            MillPipeNewEditViewModel viewModel, 
            IMillRepository repo,
            IUserNotify notify,
            ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (viewModel.Pipe.Railcar == null)
            {
                if (notify.ShowYesNo(
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeQuestion),
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeQuestionHeader)))
                {
                    try
                    {
                        viewModel.Pipe.IsActive = false;
                        viewModel.CheckStatus();
                        viewModel.UpdatePipeSubStatus();
                        viewModel.Pipe.PipeTestResult = viewModel.PipeTestResults;

                        repo.BeginTransaction();
                        repo.RepoPipe.Save(viewModel.Pipe);
                        repo.Commit();

                        repo.RepoPipe.Evict(viewModel.Pipe);

                        viewModel.ModifiableView.IsEditMode = false;
                        viewModel.ModifiableView.IsModified = false;
                        viewModel.ModifiableView.UpdateState();

                        notify.ShowSuccess(
                            string.Concat(Program.LanguageManager.GetString(
                                StringResources.Pipe_Deactivated), viewModel.Number),
                            Program.LanguageManager.GetString(
                                StringResources.Pipe_DeactivatedHeader));

                        log.Info(string.Format("The Pipe #{0}, id:{1} has been deactivated.",
                            viewModel.Pipe.Number, viewModel.Pipe.Id));
                    }
                    catch (RepositoryException ex)
                    {
                        log.Error(ex.Message);
                        notify.ShowFailure(ex.InnerException.Message, ex.Message);
                    }
                }
                else
                {
                    //Refresh property so that binded control become unchecked
                    viewModel.PipeIsActive = false;
                    viewModel.PipeIsActive = true;
                }
            }
            else if (viewModel.PipeStatus == PipeMillStatus.Shipped)
            {
                notify.ShowInfo(
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeShippedError),
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeShippedErrorHeader));
            }
            else
            {
                notify.ShowInfo(
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeInRailcarError),
                    Program.LanguageManager.GetString(StringResources.MillPipe_DeactivatePipeInRailcarErrorHeader));
            }
            RefreshVisualStateEvent();
        }


        public bool CanExecute()
        {
            return
                viewModel.Pipe.Status != PipeMillStatus.Shipped
                && viewModel.Pipe.IsActive
                && !viewModel.IsNew
                && viewModel.ModifiableView.IsEditMode
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.DeactivatePipe);
        }
    }
}
