using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors;
using Domain.Entity.Mill;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

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
            int distinctSizes = viewModel.Railcar.Pipes.Select(p => p.Type).Distinct().Count();

            if (distinctSizes>1)
            {
                //TODO: extract hardcoded text
                XtraMessageBox.Show("Все трубы в в вагоне должны быть одного типоразмера", "Ошибка");
                return;
            }

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