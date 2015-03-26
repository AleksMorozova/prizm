using Prizm.Main.Commands;
using Prizm.Main.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Properties;
using Prizm.Main.Languages;
using Prizm.Data.DAL;
using Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Spool
{
    public class SpoolDeactivationCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SpoolDeactivationCommand));

        private readonly ISpoolRepositories repo;
        private readonly SpoolViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SpoolDeactivationCommand(ISpoolRepositories repo, SpoolViewModel viewModel, IUserNotify notify, ISecurityContext ctx)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (viewModel.Spool.IsAvailableToJoint && viewModel.Spool.ConstructionStatus != PartConstructionStatus.Welded)
            {
                if (notify.ShowYesNo(
                      Program.LanguageManager.GetString(StringResources.Spool_DeactivationQuestion),
                      Program.LanguageManager.GetString(StringResources.Spool_DeactivationQuestionHeader)))
                {
                    try
                    {
                        viewModel.PipeLength = viewModel.PipeLength + viewModel.SpoolLength;

                        viewModel.Spool.IsActive = false;

                        repo.BeginTransaction();
                        repo.PipeRepo.SaveOrUpdate(viewModel.Pipe);
                        repo.SpoolRepo.SaveOrUpdate(viewModel.Spool);

                        repo.Commit();

                        repo.PipeRepo.Evict(viewModel.Pipe);
                        repo.SpoolRepo.Evict(viewModel.Spool);

                        viewModel.ModifiableView.IsEditMode = false;
                        viewModel.ModifiableView.IsModified = false;
                        viewModel.ModifiableView.UpdateState();

                        notify.ShowSuccess(
                            string.Concat(Program.LanguageManager.GetString(
                                StringResources.Spool_Deactivated), viewModel.SpoolNumber),
                            Program.LanguageManager.GetString(
                                StringResources.Spool_DeactivatedHeader));

                        log.Info(string.Format("The Spool #{0}, id:{1} has been deactivated.",
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
                    viewModel.SpoolIsActive = false;
                    viewModel.SpoolIsActive = true;
                }
            }
            else
            {
                notify.ShowInfo(
                    Program.LanguageManager.GetString(StringResources.Message_DeactivationConnectedSpool),
                    Program.LanguageManager.GetString(StringResources.Message_DeactivationConnectedSpoolHeader));

                //Refresh property so that binded control become unchecked
                viewModel.SpoolIsActive = false;
                viewModel.SpoolIsActive = true;
            }
            RefreshVisualStateEvent();
        }


        public bool CanExecute()
        {
            return viewModel.SpoolIsActive
                && !viewModel.IsNew
                && viewModel.ModifiableView.IsEditMode
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.DeactivateSpool);
        }
    }
}
