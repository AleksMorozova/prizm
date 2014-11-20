using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public class SaveRailcarCommand : ICommand
    {
        private readonly IRailcarRepository repo;
        private readonly RailcarViewModel viewModel;

        public SaveRailcarCommand(RailcarViewModel viewModel, IRailcarRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (viewModel.Railcar.ShippingDate == DateTime.MinValue)
            {
                viewModel.Railcar.ShippingDate = null;
            }
            repo.BeginTransaction();
            repo.SaveOrUpdate(viewModel.Railcar);
            repo.Commit();
            repo.Evict(viewModel.Railcar);
            viewModel.NewRailcar();
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}