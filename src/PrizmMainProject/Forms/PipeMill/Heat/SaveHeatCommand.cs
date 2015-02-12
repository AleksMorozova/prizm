using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL;

namespace Prizm.Main.Forms.PipeMill.Heat
{
    public class SaveHeatCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveHeatCommand));
        private readonly HeatViewModel viewModel;
        private readonly IHeatRepositories repo;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveHeatCommand(HeatViewModel viewModel, IHeatRepositories repo)
        {
            this.viewModel = viewModel;
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
                repo.Commit();
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
