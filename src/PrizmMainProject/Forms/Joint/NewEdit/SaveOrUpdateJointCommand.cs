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
using Prizm.Main.Languages;
using Prizm.Domain.Entity.Construction;
using Prizm.Data.DAL.ADO;
using Prizm.Domain.Entity;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class SaveOrUpdateJointCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveOrUpdateJointCommand));

        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;
        private int numberOfOperationWithoutInspectors = 0;
        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };
        readonly IDuplicateNumberRepository duplicateNumberRepo = new DuplicateNumberRepository();
        public SaveOrUpdateJointCommand(
            IConstructionRepository repo,
            JointNewEditViewModel viewModel,
            IUserNotify notify,
            ISecurityContext ctx)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
            this.ctx = ctx;
        }

        public void Execute()
        {
            try
            {
                foreach(JointTestResult t in viewModel.JointTestResults)
                {
                    if(t.Inspectors.Count <= 0)
                    {
                        numberOfOperationWithoutInspectors++;
                    }
                }
                if(numberOfOperationWithoutInspectors == 0)
                {
                    try
                    {
                        var duplicateNumber = duplicateNumberRepo.GetAllActiveDuplicateEntityByNumber(viewModel.Number).Distinct(new DuplicateNumberEntityComparer()).ToList();
                        List<DuplicateNumberEntity> resultDuplicateNumber = new List<DuplicateNumberEntity>();
                        if (viewModel.Joint.Id != Guid.Empty && duplicateNumber != null)
                        {
                            foreach (var entity in duplicateNumber)
                            {
                                if (entity.EntityType != DuplicateNumberEntityType.Joint.ToString())
                                {
                                    resultDuplicateNumber.Add(entity);
                                }
                            }
                        }
                        if (duplicateNumber != null && resultDuplicateNumber.Count > 0)
                        {
                            DuplicateNumberEntityType translateFirstElement = (DuplicateNumberEntityType)Enum.Parse(typeof(DuplicateNumberEntityType),
                                     resultDuplicateNumber[0].EntityType);
                            String result = viewModel.localizedAllType[(int)((object)translateFirstElement) - 1];

                            for (int i = 1; i <= resultDuplicateNumber.Count - 1; i++)
                            {
                                DuplicateNumberEntityType translate = (DuplicateNumberEntityType)Enum.Parse(typeof(DuplicateNumberEntityType),
                                     resultDuplicateNumber[i].EntityType);
                                result = result + ", " + viewModel.localizedAllType[(int)((object)translate) - 1];
                            }

                            notify.ShowInfo(
                              string.Concat(Program.LanguageManager.GetString(StringResources.DuplicateEntity_Message) + result),
                              Program.LanguageManager.GetString(StringResources.DuplicateEntity_MessageHeader));
                            viewModel.Number = string.Empty;

                        }
else
{                        viewModel.Joint.Number = viewModel.Joint.Number.ToUpper();
                        viewModel.Joint.ToExport = true;
                        repo.BeginTransaction();
                        repo.RepoJoint.SaveOrUpdate(viewModel.Joint);

                        var filesViewModel = viewModel.FilesFormViewModel;


                        bool fileCopySuccess = true;
                        if(null != filesViewModel)
                        {
                            filesViewModel.FileRepo = repo.FileRepo;
                            viewModel.FilesFormViewModel.Item = viewModel.Joint.Id;
                            if(!viewModel.FilesFormViewModel.TrySaveFiles(viewModel.Joint))
                            {
                                fileCopySuccess = false;
                                repo.Rollback();
                            }
                        }

                        if(fileCopySuccess)
                        {
                            repo.Commit();
                        }
                        repo.RepoJoint.Evict(viewModel.Joint);

                        if(fileCopySuccess)
                        {
                            if(null != filesViewModel)
                            {
                                filesViewModel.DetachFileEntities();
                            }

                            notify.ShowSuccess(
                                 string.Concat(Program.LanguageManager.GetString(StringResources.Joint_Saved), viewModel.Number),
                                 Program.LanguageManager.GetString(StringResources.Joint_SavedHeader));

                            log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.",
                            viewModel.Joint.Number,
                            viewModel.Joint.Id));
                        }
                        else
                        {
                            notify.ShowError(
                                Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied),
                                Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied_Header));
                            log.Info(string.Format("File for entity #{0}, id:{1} hasn't been saved ",
                                viewModel.Joint.Number,
                                viewModel.Joint.Id));
                        }

                        viewModel.ModifiableView.IsModified = false;
                        viewModel.ModifiableView.Id = viewModel.Joint.Id;
                        viewModel.ModifiableView.UpdateState();
}
                    }
                    catch(RepositoryException ex)
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
                }
            }
            catch(RepositoryException ex)
            {
                log.Warn(this.GetType().Name + " | " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }


        public bool CanExecute()
        {
            return
                !string.IsNullOrEmpty(viewModel.Number)
                &&
                   ((viewModel.FirstElement != null && viewModel.SecondElement != null)
                   ||
                   viewModel.Joint.Status == Domain.Entity.Construction.JointStatus.Withdrawn)
                &&
                viewModel.Joint.IsActive
                &&
                ctx.HasAccess(viewModel.IsNew
                                   ? global::Domain.Entity.Security.Privileges.CreateJoint
                                   : global::Domain.Entity.Security.Privileges.EditJoint);
        }
    }
}
