using DevExpress.Mvvm.DataAnnotations;
using Prizm.Data.DAL;
using Prizm.Domain.Entity.Construction;
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

namespace Prizm.Main.Forms.Parts.Inspection
{
    public class SaveInspectionTestResultsCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveInspectionTestResultsCommand));

        private readonly IInspectionTestResultRepository repo;
        private readonly PartInspectionViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveInspectionTestResultsCommand(IInspectionTestResultRepository repo, PartInspectionViewModel viewModel, IUserNotify notify, ISecurityContext ctx)
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
                viewModel.ConvertedPart.InspectionStatus = viewModel.ConvertedPart.GetPartInspectionStatus();
                repo.BeginTransaction();
                foreach (InspectionTestResult itr in viewModel.InspectionTestResults)
                {
                    repo.SaveOrUpdate(itr);
                }
                repo.Commit();
                foreach (InspectionTestResult itr in viewModel.InspectionTestResults)
                {
                    repo.Evict(itr);
                }
                notify.ShowNotify(string.Concat(Program.LanguageManager.GetString(StringResources.PartInspection_InspectionsSaved), viewModel.SelectedElement.Number), Program.LanguageManager.GetString(StringResources.PartInspection_InspectionsSavedHeader));

                log.Info(string.Format("The Inspection Test Results for entity #{0}, id:{1} has been saved in DB.",
                    viewModel.SelectedElement.Number,
                    viewModel.SelectedElement.Id));
            }
            catch (RepositoryException ex)
            {
                log.Error(ex.Message);
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return (viewModel.InspectionTestResults != null && ctx.HasAccess(global::Domain.Entity.Security.Privileges.PartsInspection));
        }
    }
}
