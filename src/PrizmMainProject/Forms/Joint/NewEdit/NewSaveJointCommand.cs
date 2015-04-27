using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Security;
using Ninject;
using Prizm.Main.Properties;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.Construction;
using Prizm.Data.DAL;


namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class NewSaveJointCommand : ICommand
    {
        private int numberOfWeldOperationWithoutWelders = 0;
        private int numberOfControlOperationWithoutInspectors = 0;

        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NewSaveJointCommand));

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public NewSaveJointCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify, ISecurityContext ctx)
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
                if(!viewModel.ValidatableView.Validate()) { return; }

                if(!DateCheck())
                {
                    notify.ShowInfo(Program.LanguageManager.GetString(StringResources.WrongDate),
                        Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                    log.Warn("Date limits not valid!");
                    return;
                }

                if(viewModel.Joint.LoweringDate == DateTime.MinValue)
                {
                    viewModel.Joint.LoweringDate = null;
                }

                numberOfWeldOperationWithoutWelders = 0;
                foreach(JointWeldResult w in viewModel.JointWeldResults)
                {
                    if(w.Welders.Count <= 0
                        && w.Operation.Type == Prizm.Domain.Entity.Setup.JointOperationType.Weld)
                    {
                        numberOfWeldOperationWithoutWelders++;
                    }
                }

                numberOfControlOperationWithoutInspectors = 0;
                foreach(JointTestResult t in viewModel.JointTestResults)
                {
                    if(t.Inspectors.Count <= 0)
                    {
                        numberOfControlOperationWithoutInspectors++;
                    }
                }

                if(numberOfWeldOperationWithoutWelders == 0)
                {
                    if(numberOfControlOperationWithoutInspectors == 0)
                    {

                        var joints = repo.RepoJoint.GetActiveByNumber(viewModel.Joint);

                        foreach(var joint in joints) { repo.RepoJoint.Evict(joint); }

                        if(joints != null && joints.Count > 0)
                        {
                            notify.ShowInfo(
                                string.Concat(Program.LanguageManager.GetString(StringResources.Joint_Duplicate), viewModel.Number),
                                Program.LanguageManager.GetString(StringResources.Joint_DuplicateHeader));
                            viewModel.Number = string.Empty;
                        }
                        else
                        {
                            if(viewModel.Joint.Status == Domain.Entity.Construction.JointStatus.Withdrawn)
                            {
                                viewModel.SaveOrUpdateJointCommand.Execute();

                                viewModel.RemovePartDataFromList(viewModel.Joint.FirstElement);
                                viewModel.RemovePartDataFromList(viewModel.Joint.SecondElement);
                            }
                            else if(viewModel.MakeTheConnection())
                            {
                                viewModel.SaveOrUpdateJointCommand.Execute();

                                viewModel.RemovePartDataFromList(viewModel.Joint.FirstElement);
                                viewModel.RemovePartDataFromList(viewModel.Joint.SecondElement);
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

                            viewModel.NewJoint();
                            viewModel.ModifiableView.Id = viewModel.Joint.Id;
                            viewModel.ModifiableView.IsModified = false;
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
            catch(RepositoryException ex)
            {
                log.Warn(this.GetType().Name + ex.ToString());
                notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
            Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
            }
        }

        public bool CanExecute()
        {
            return viewModel.SaveOrUpdateJointCommand.CanExecute()
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.CreateJoint)
                && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditJoint);
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
    }
}
