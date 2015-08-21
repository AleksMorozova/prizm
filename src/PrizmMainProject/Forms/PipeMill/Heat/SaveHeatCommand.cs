using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.PipeMill.Heat
{
    public class SaveHeatCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveHeatCommand));
        private readonly HeatViewModel viewModel;
        private readonly IHeatRepositories repo;
        private readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveHeatCommand(HeatViewModel viewModel, IHeatRepositories repo,
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.notify = notify;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            var heat = viewModel.Heat;
            try
            {
                heat.Number = heat.Number.ToUpper();

                repo.BeginTransaction();
                repo.HeatRepo.SaveOrUpdate(heat);
                var filesViewModel = viewModel.FilesFormViewModel;

                //saving attached existingDocuments
                bool fileCopySuccess = true;
                if (null != filesViewModel)
                {
                    filesViewModel.FileRepo = repo.FileRepo;
                    viewModel.FilesFormViewModel.Item = viewModel.Heat.Id;
                    if (!viewModel.FilesFormViewModel.TrySaveFiles(viewModel.Heat))
                    {
                        fileCopySuccess = false;
                        repo.Rollback();
                    }
                }

                if (fileCopySuccess)
                {
                    repo.Commit();
                }

                repo.HeatRepo.Evict(viewModel.Heat);

                if (fileCopySuccess)
                {
                    if (null != filesViewModel)
                    {
                        filesViewModel.DetachFileEntities();
                    }
                }
                else
                {
                    notify.ShowError(Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied),
                        Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied_Header));
                    log.Info(string.Format("File for entity #{0}, id:{1} hasn't been saved", viewModel.Heat.Number,
                        viewModel.Heat.Id));
                }

                repo.HeatRepo.Evict(heat);

                log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.",
                    viewModel.Heat.Number,
                    viewModel.Heat.Id));
            }
            catch (RepositoryException ex)
            {
                log.Error(ex.Message);
            }
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
