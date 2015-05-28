using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Security;
using Ninject;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.Construction;
using Prizm.Data.DAL.ADO;
using Prizm.Domain.Entity;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class SaveJointCommand : ICommand
    {
        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;
        private int numberOfWeldOperationWithoutWelders = 0;
        private int numberOfControlOperationWithoutInspectors = 0;
        private bool jointWasWeld = false;
        readonly IDuplicateNumberRepository duplicateNumberRepo = new DuplicateNumberRepository();

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveJointCommand));

        public SaveJointCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify, ISecurityContext ctx)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            try
            {

                var duplicateNumber = duplicateNumberRepo.GetAllActiveDuplicateEntityByNumber(viewModel.Number).Distinct(new DuplicateNumberEntityComparer()).ToList();

                if (duplicateNumber != null && duplicateNumber.Count > 0)
                {
                    DuplicateNumberEntityType translateFirstElement = (DuplicateNumberEntityType)Enum.Parse(typeof(DuplicateNumberEntityType),
                             duplicateNumber[0].EntityType);
                    String result = viewModel.localizedAllType[(int)((object)translateFirstElement) - 1];

                    for (int i = 1; i <= duplicateNumber.Count - 1; i++)
                    {
                        DuplicateNumberEntityType translate = (DuplicateNumberEntityType)Enum.Parse(typeof(DuplicateNumberEntityType),
                             duplicateNumber[i].EntityType);
                        result = result + ", " + viewModel.localizedAllType[(int)((object)translate) - 1];
                    }

                    notify.ShowInfo(
                      string.Concat(Program.LanguageManager.GetString(StringResources.DuplicateEntity_Message) + result),
                      Program.LanguageManager.GetString(StringResources.DuplicateEntity_MessageHeader));
                    viewModel.Number = string.Empty;

                }
                else 
                {
                    if (!DateCheck())
                    {
                        notify.ShowInfo(Program.LanguageManager.GetString(StringResources.WrongDate),
                            Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                        log.Warn("Date limits not valid!");
                        return;
                    }
                    foreach (JointWeldResult w in viewModel.JointWeldResults)
                    {
                        if (w.Welders.Count <= 0
                            && w.Operation.Type == Prizm.Domain.Entity.Setup.JointOperationType.Weld)
                        {
                            numberOfWeldOperationWithoutWelders++;
                        }
                        if (w.IsCompleted)
                        {
                            jointWasWeld = true;
                        }
                    }

                    foreach (JointTestResult t in viewModel.JointTestResults)
                    {
                        if (t.Inspectors.Count <= 0)
                        {
                            numberOfControlOperationWithoutInspectors++;
                        }
                    }

                    if (viewModel.ValidatableView.Validate())
                    {
                        if (jointWasWeld)
                        {
                            if (numberOfWeldOperationWithoutWelders == 0)
                            {
                                if (numberOfControlOperationWithoutInspectors == 0)
                                {
                                    if (viewModel.Joint.LoweringDate == DateTime.MinValue)
                                    {
                                        viewModel.Joint.LoweringDate = null;
                                    }
                                    var joints = repo.RepoJoint.GetActiveByNumber(viewModel.Joint);
                                    foreach (var joint in joints)
                                    {
                                        repo.RepoJoint.Evict(joint);
                                    }
                                    if (joints != null && joints.Count > 0)
                                    {
                                        notify.ShowInfo(
                                            string.Concat(Program.LanguageManager.GetString(StringResources.Joint_Duplicate), viewModel.Number),
                                            Program.LanguageManager.GetString(StringResources.Joint_DuplicateHeader));
                                        viewModel.Number = string.Empty;
                                    }
                                    else
                                    {
                                        numberOfWeldOperationWithoutWelders = 0;
                                        numberOfControlOperationWithoutInspectors = 0;

                                        if (viewModel.Joint.Status == Domain.Entity.Construction.JointStatus.Withdrawn)
                                        {
                                            viewModel.SaveOrUpdateJointCommand.Execute();

                                        }
                                        else if (viewModel.MakeTheConnection())
                                        {
                                            viewModel.SaveOrUpdateJointCommand.Execute();
                                        }
                                        else
                                        {
                                            notify.ShowInfo(
                                            Program.LanguageManager.GetString(StringResources.Joint_IncorrectDiameter),
                                            Program.LanguageManager.GetString(StringResources.Joint_IncorrectDiameterHeader));

                                            log.Info(string.Format("There are no suitable diameters or wall thicknesses for the joint #{0}, id:{1} formation",
                                                viewModel.Joint.Number,
                                                viewModel.Joint.Id));
                                        }
                                    }
                                    RefreshVisualStateEvent();
                                }
                                else
                                {
                                    notify.ShowError(
                                        Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResult),
                                        Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResultHeader));
                                    numberOfControlOperationWithoutInspectors = 0;

                                    log.Warn(string.Format("There are no inspectors for appropriate control operations for the joint #{0}, id:{1} formation",
                                        viewModel.Joint.Number,
                                        viewModel.Joint.Id));
                                }
                            }
                            else
                            {
                                notify.ShowError(
                                                       Program.LanguageManager.GetString(StringResources.SelectWeldersForOperation),
                                                       Program.LanguageManager.GetString(StringResources.SelectWeldersForOperationHeader));
                                numberOfWeldOperationWithoutWelders = 0;


                                log.Warn(string.Format("There are no welders for appropriate weld operations for the joint #{0}, id:{1} formation",
                                    viewModel.Joint.Number,
                                    viewModel.Joint.Id));
                            }
                        }
                        else
                        {
                            notify.ShowError(
                                Program.LanguageManager.GetString(StringResources.JointNewNotAllWeldOperationCompleted),
                               Program.LanguageManager.GetString(StringResources.JointNewNotAllWeldOperationCompletedHeader));
                            jointWasWeld = false;
                            log.Warn(string.Format("Not all weld operations completed for the joint #{0}, id:{1}.",
                                        viewModel.Joint.Number,
                                        viewModel.Joint.Id));
                        }
                    }
                }
            }
            catch(RepositoryException ex)
            {
                log.Warn(this.GetType().Name + " | " + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        private bool DateCheck()
        {
            bool result = true;
            if(!viewModel.Joint.LoweringDate.IsValid())
            {
                result = false;
            }
            if(!viewModel.JointTestResults.All(x => x.Date.IsValid()))
            {
                result = false;
            }
            if(!viewModel.JointWeldResults.All(x => x.Date.IsValid()))
            {
                result = false;
            }
            return result;
        }

        public bool CanExecute()
        {
            return viewModel.SaveOrUpdateJointCommand.CanExecute();
        }
    }
}
