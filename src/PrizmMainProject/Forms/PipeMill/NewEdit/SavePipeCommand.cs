﻿using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using Prizm.Main.Common;
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
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class SavePipeCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SavePipeCommand));

        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SavePipeCommand(
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
            if(!viewModel.ValidatableView.Validate())
            {
                return;
            }

            if(!DateValidate())
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.WrongDate),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                log.Warn("Date limits not valid!");
                return;
            }

            //Uppercase for db
            viewModel.Pipe.Plate.Number = viewModel.Pipe.Plate.Number.ToUpper();
            viewModel.Pipe.Number = viewModel.Pipe.Number.ToUpper();


            var p = repo.RepoPipe.GetActiveByNumber(viewModel.Pipe);
            foreach(var pipe in p)
            {
                repo.RepoPipe.Evict(pipe);
            }

            if(p != null && p.Count > 0)
            {
                notify.ShowInfo(
                    string.Concat(Program.LanguageManager.GetString(StringResources.MillPipe_ExistingNumberError), viewModel.Number),
                    Program.LanguageManager.GetString(StringResources.MillPipe_ExistingNumberErrorHeader));
                viewModel.Number = string.Empty;
            }
            else
            {
                if(viewModel.CheckStatus())
                {
                    try
                    {
                        viewModel.UpdatePipeSubStatus();
                        viewModel.Pipe.PipeTestResult = viewModel.PipeTestResults;
                        repo.BeginTransaction();
                        repo.RepoPipe.SaveOrUpdate(viewModel.Pipe);

                        var filesViewModel = viewModel.FilesFormViewModel;
                        filesViewModel.FileRepo = repo.FileRepo;

                        //saving attached documents
                        bool fileCopySuccess = true;
                        if (null != filesViewModel)
                        {
                            viewModel.FilesFormViewModel.Item = viewModel.Pipe.Id;
                            if (!viewModel.FilesFormViewModel.TrySaveFiles(viewModel.Pipe))
                            {
                                fileCopySuccess = false;
                                repo.Rollback();
                            }
                        }

                        repo.Commit();
                        repo.RepoPipe.Evict(viewModel.Pipe);

                        if (fileCopySuccess)
                        {
                            filesViewModel.DetachFileEntities();

                            notify.ShowSuccess(
                                 string.Concat(Program.LanguageManager.GetString(StringResources.MillPipe_PipeSaved), viewModel.Number),
                                 Program.LanguageManager.GetString(StringResources.MillPipe_PipeSavedHeader));
                        }
                        else
                        {
                            notify.ShowError(Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied),
                                Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied_Header));
                        }

                        viewModel.ModifiableView.IsModified = false;
                        viewModel.ModifiableView.UpdateState();
                        notify.ShowNotify(
                            string.Concat(Program.LanguageManager.GetString(StringResources.MillPipe_PipeSaved), viewModel.Number),
                            Program.LanguageManager.GetString(StringResources.MillPipe_PipeSavedHeader));

                        log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.",
                            viewModel.Pipe.Number,
                            viewModel.Pipe.Id));
                    }
                    catch(RepositoryException ex)
                    {
                        log.Error(ex.Message);
                        notify.ShowFailure(ex.InnerException.Message, ex.Message);
                    }
                }
                else
                {
                    notify.ShowInfo(
                        Program.LanguageManager.GetString(StringResources.MillPipe_ErrorEditingInspectionOperationPipeInRailcar),
                        Program.LanguageManager.GetString(StringResources.MillPipe_PipeSavedHeader));
                }
            }

            RefreshVisualStateEvent();
        }

        private bool DateValidate()
        {
            bool result = true;

            if(!viewModel.Pipe.ProductionDate.IsValid())
            {
                result = false;
            }
            if(!viewModel.Pipe.Coats.All(x => x.Date.IsValid()))
            {
                result = false;
            }
            if(!viewModel.Pipe.Welds.All(x => x.Date.IsValid()))
            {
                result = false;
            }
            return result;
        }


        public bool CanExecute()
        {
            return viewModel.Heat != null &&
                    viewModel.PipeMillSizeType != null &&
                    viewModel.PipePurchaseOrder != null &&
                    !string.IsNullOrEmpty(viewModel.Number) &&
                    !string.IsNullOrEmpty(viewModel.PlateNumber) &&
                    viewModel.ProductionDate != DateTime.MinValue &&
                !string.IsNullOrEmpty(viewModel.PlateNumber) &&
                    viewModel.ModifiableView.IsEditMode &&
                    ctx.HasAccess(viewModel.IsNew
                        ? global::Domain.Entity.Security.Privileges.CreatePipe
                        : global::Domain.Entity.Security.Privileges.EditPipe);
        }

    }
}
