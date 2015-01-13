using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.Heat
{
    public class SaveHeatCommand : ICommand
    {
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

            repo.BeginTransaction();
            repo.HeatRepo.SaveOrUpdate(heat);
            repo.Commit();
            repo.HeatRepo.Evict(heat);
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
