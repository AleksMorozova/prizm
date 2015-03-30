using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Main.Security;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.SimpleReleaseNote;

namespace Prizm.Main.Forms.ReleaseNote.NewEdit
{
    public class SaveReleaseNoteCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveReleaseNoteCommand));

        private readonly IReleaseNoteRepositories repos;
        private readonly ReleaseNoteViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public SaveReleaseNoteCommand(ReleaseNoteViewModel viewModel, IReleaseNoteRepositories repo, IUserNotify notify, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.validatableView.Validate())
            {
                return;
            }

            if(!viewModel.Date.IsValid())
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.WrongDate),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                log.Warn("Date limits not valid!");
                return;
            }

            if(string.IsNullOrWhiteSpace(viewModel.Number))
            {
                notify.ShowError(Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_MissingReleaseNoteNumber),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                return;
            }


            try
            {
                var emptyRailcars = viewModel.Railcars.Where(x => x.Pipes.Count == 0).ToList<SimpleRailcar>();

                var empty = viewModel.Railcars.Where(x => x.Pipes.Count == 0).ToList<SimpleRailcar>();
                foreach(var item in empty)
                {
                    viewModel.Railcars.Remove(item);
                }

                foreach(var r in viewModel.Railcars)
                {
                    r.ReleaseNote = viewModel.ReleaseNote;
                }

                viewModel.ReleaseNote.Number = viewModel.ReleaseNote.Number.ToUpper();

                foreach(var item in viewModel.Railcars)
                {
                    item.Number = item.Number.ToUpper();
                }

                repos.BeginTransaction();
                repos.SimpleNoteRepo.SaveOrUpdate(viewModel.ReleaseNote);

                var filesViewModel = viewModel.FilesFormViewModel;


                //saving attached existingDocuments
                bool fileCopySuccess = true;
                if (null != filesViewModel)
                {
                    filesViewModel.FileRepo = repos.FileRepo;
                    viewModel.FilesFormViewModel.Item = viewModel.ReleaseNote.Id;
                    if (!viewModel.FilesFormViewModel.TrySaveFiles(viewModel.ReleaseNote))
                    {
                        fileCopySuccess = false;
                        repos.Rollback();
                    }
                }

                if (fileCopySuccess)
                {
                    repos.Commit();
                }

                repos.SimpleNoteRepo.Evict(viewModel.ReleaseNote);
                viewModel.ModifiableView.IsModified = false;
                viewModel.ModifiableView.Id = viewModel.ReleaseNote.Id;

                if (fileCopySuccess)
                {
                    if (null != filesViewModel)
                    {
                        filesViewModel.DetachFileEntities(); 
                    }

                    notify.ShowSuccess(Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_SaveSuccess),
                        Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_SaveSuccessHeader));

                    log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.", viewModel.ReleaseNote.Number, 
                        viewModel.ReleaseNote.Id));
                }
                else
                {
                    notify.ShowError(Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied),
                                Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied_Header));
                    log.Info(string.Format("File for entity #{0}, id:{1} hasn't been saved.", viewModel.ReleaseNote.Number,
                        viewModel.ReleaseNote.Id));
                }
            }
            catch(RepositoryException ex)
            {
                log.Error(String.Format("An error occured on saving release note {0},{1}: {2}", viewModel.ReleaseNote.Id, viewModel.ReleaseNote.Number, ex.Message));
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            bool condition = !string.IsNullOrWhiteSpace(viewModel.Number)
                && !viewModel.Shipped;

            bool conditionAndPermission;
            if(viewModel.IsNew)
            {
                conditionAndPermission = condition && ctx.HasAccess(global::Domain.Entity.Security.Privileges.CreateReleaseNote);
            }
            else
            {
                conditionAndPermission = condition && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditReleaseNote);
            }
            return conditionAndPermission;
        }
    }
}