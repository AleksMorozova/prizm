using Data.DAL;
using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using NHibernate.Criterion;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Properties;
using System;
using System.Linq;

namespace PrizmMain.Forms.Railcar.Search
{
    public class SearchRailcarCommand : ICommand
    {
        private readonly RailcarSearchViewModel viewModel;
        private readonly IRailcarRepository repo;
        private readonly IUserNotify notify;

        [Inject]
        public SearchRailcarCommand(RailcarSearchViewModel viewmodel, IRailcarRepository repo, IUserNotify notify)
        {
            this.viewModel = viewmodel;
            this.repo = repo;
            this.notify = notify;
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

            try
            {
                viewModel.Railcars = repo.GetByCriteria(criteria).ToList();
                repo.Clear();
            }
            catch (RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
            
            
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
