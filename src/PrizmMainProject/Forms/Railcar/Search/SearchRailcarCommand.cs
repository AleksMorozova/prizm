using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using NHibernate.Criterion;
using PrizmMain.Commands;
using System;
using System.Linq;

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


            var criteria = DetachedCriteria.For<Domain.Entity.Mill.Railcar>();

            if (!string.IsNullOrWhiteSpace(viewModel.RailcarNumber))
            {
                criteria.Add(Restrictions.Like("Number", viewModel.RailcarNumber, MatchMode.Anywhere));
            }

            if (!string.IsNullOrWhiteSpace(viewModel.Certificate))
            {
                criteria.Add(Restrictions.Like("Certificate", viewModel.Certificate, MatchMode.Anywhere));
            }

            if (!string.IsNullOrWhiteSpace(viewModel.Receiver))
            {
                criteria.Add(Restrictions.Like("Destination", viewModel.Receiver, MatchMode.Anywhere));
            }
            if (viewModel.ShippingDate > DateTime.MinValue)
            {
                criteria.Add(Restrictions.Eq("ShippingDate", viewModel.ShippingDate));
            }
            viewModel.Railcars = repo.GetByCriteria(criteria).ToList();
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
