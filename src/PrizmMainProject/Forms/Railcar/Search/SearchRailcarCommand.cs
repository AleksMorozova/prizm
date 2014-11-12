using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using NHibernate.Criterion;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrizmMain.Forms.Railcar.Search
{
    public class SearchRailcarCommand : ICommand
    {
        private readonly RailcarSearchViewModel viewModel;
        private readonly IRailcarRepository repo;

        public SearchRailcarCommand(RailcarSearchViewModel viewmodel, IRailcarRepository repo)
        {
            this.viewModel = viewmodel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {


            List<Domain.Entity.Mill.Railcar> railcars = new List<Domain.Entity.Mill.Railcar>();

            var criteria = NHibernate.Criterion.DetachedCriteria.For<Domain.Entity.Mill.Railcar>()
                .Add(Restrictions.Like("Number", viewModel.RailcarNumber));
            var res = repo.GetByCriteria(criteria).ToList();

            viewModel.Railcars = res;
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
