using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Properties;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Security;
using Ninject;
using Prizm.Main.Languages;
using Prizm.Data.DAL;
using Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Spool
{
    public class SaveSpoolCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveSpoolCommand));

        readonly ISpoolRepositories repos;
        readonly SpoolViewModel viewModel;
        readonly IUserNotify notify;
        readonly ISecurityContext ctx;
        private int numberOfOperationWithoutInspectors=0;
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
            if(!viewModel.InspectionTestResults.All(x => x.Date.IsValid()))
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.WrongDate),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                log.Warn("Date limits not valid!");
                return;
            }

            if (viewModel.Spool.Length != 0)
            {
                if (viewModel.CanCut)
                {
                    foreach (InspectionTestResult t in viewModel.InspectionTestResults)
                    {
                        if (t.Status != PartInspectionStatus.Pending && t.Inspectors.Count <= 0)
                        {
                            numberOfOperationWithoutInspectors++;
                        }
                    }

                    if (numberOfOperationWithoutInspectors == 0)
                    {
                        try
                        {
                            viewModel.Pipe.ToExport = true;
                            viewModel.Pipe.IsCutOnSpool = true;
                            viewModel.Spool.Number = viewModel.Spool.Number.ToUpper();
                            viewModel.Spool.InspectionStatus = viewModel.Spool.GetPartInspectionStatus();
                            repos.BeginTransaction();
                            repos.PipeRepo.SaveOrUpdate(viewModel.Pipe);
                            repos.SpoolRepo.SaveOrUpdate(viewModel.Spool);

                            var filesViewModel = viewModel.FilesFormViewModel;

                            //saving attached documents
                            bool fileCopySuccess = true;
                            if (null != filesViewModel)
                            {
                                filesViewModel.FileRepo = repos.FileRepo;
                                viewModel.FilesFormViewModel.Item = viewModel.Pipe.Id;
                                if (!viewModel.FilesFormViewModel.TrySaveFiles(viewModel.Pipe))
                                {
                                    fileCopySuccess = false;
                                    repos.Rollback();
                                }
                            }

                            repos.Commit();
                            repos.PipeRepo.Evict(viewModel.Pipe);
                            repos.SpoolRepo.Evict(viewModel.Spool);

                            if (fileCopySuccess)
                            {
                                if (null != filesViewModel)
                                { 
                                    filesViewModel.DetachFileEntities(); 
                                }

                                notify.ShowSuccess(
                                     string.Concat(Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipe), viewModel.Spool.Id),
                                     Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipeHeader));
                            }
                            else
                            {
                                notify.ShowError(Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied),
                                                 Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied_Header));
                            }

                            viewModel.ModifiableView.IsModified = false;

                            notify.ShowNotify(
                                Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipe),
                                Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipeHeader));

                            log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.",
                                viewModel.Spool.Number,
                                viewModel.Spool.Id));

                            string oldPipeNumber = viewModel.Pipe.Number;
                            viewModel.NewSpool();
                            viewModel.PipeNumber = oldPipeNumber;
                            RefreshVisualStateEvent();
                        }
                        catch (RepositoryException ex)
                        {
                            log.Error(ex.Message);
                            notify.ShowFailure(ex.InnerException.Message, ex.Message);
                        }
                    }
                    else 
                    {
                        notify.ShowError(
                      Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResult),
                        Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResultHeader));
                        viewModel.ModifiableView.IsEditMode = true;
                    }
                }
                else
                {
                    notify.ShowError(
                         Program.LanguageManager.GetString(StringResources.Spool_SpoolLengtBigerThenPipeLength),
                         Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipeHeader));
                    viewModel.ModifiableView.IsEditMode = true;
                    numberOfOperationWithoutInspectors = 0;
                }
            }
            else
            {
                notify.ShowError(
                      Program.LanguageManager.GetString(StringResources.Spool_NullSpoolLength),
                         Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipeHeader));
                viewModel.ModifiableView.IsEditMode = true;
            }

        }

        public bool CanExecute()
        {
            return viewModel.ModifiableView.IsEditMode
                && viewModel.SpoolIsActive
                && !string.IsNullOrEmpty(viewModel.PipeNumber)
                && ctx.HasAccess(viewModel.IsNew
                    ? global::Domain.Entity.Security.Privileges.CreateSpool
                    : global::Domain.Entity.Security.Privileges.EditSpool);
        }
    }
}
