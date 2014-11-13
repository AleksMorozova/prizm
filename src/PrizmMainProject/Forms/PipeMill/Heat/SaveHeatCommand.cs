using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.Heat
{
    class SaveHeatCommand : ICommand
    {
        HeatViewModel viewModel;
        IHeatRepository repo;

        public SaveHeatCommand(HeatViewModel viewModel, IHeatRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            repo.BeginTransaction();
            repo.Save(viewModel.Heat);
            repo.Commit();
            repo.Evict(viewModel.Heat);
            viewModel.NewHeat();
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
