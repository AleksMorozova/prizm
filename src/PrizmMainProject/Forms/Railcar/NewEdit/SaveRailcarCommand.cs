using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public class SaveRailcarCommand : ICommand
    {
        private readonly IRailcarRepositories repos;
        private readonly RailcarViewModel viewModel;

        public SaveRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo)
        {
            this.viewModel = viewModel;
            this.repos = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (viewModel.Railcar.ShippingDate == DateTime.MinValue)
            {
                viewModel.Railcar.ShippingDate = null;
            }
            repos.BeginTransaction();
            repos.RailcarRepo.SaveOrUpdate(viewModel.Railcar);
            repos.Commit();
            repos.RailcarRepo.Evict(viewModel.Railcar);
            viewModel.NewRailcar();
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}