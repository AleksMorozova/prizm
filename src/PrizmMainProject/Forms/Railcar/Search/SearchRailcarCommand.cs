using Data.DAL;
using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using NHibernate;
using NHibernate.Criterion;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PrizmMain.Forms.Railcar.Search
{
    public class SearchRailcarCommand : ICommand
    {
        private readonly RailcarSearchViewModel viewModel;
        private readonly IRailcarRepository repo;
        private readonly IUserNotify notify;

        [Inject]
        public SearchRailcarCommand(
            RailcarSearchViewModel viewmodel, 
            IRailcarRepository repo, 
            IUserNotify notify)
        {
            this.viewModel = viewmodel;
            this.repo = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            try
            {
                var railcars = new List<RailcarPartial>();

                var query = repo
                    .CreateSQLQuery(RailcarQuery.BuildSql(
                    viewModel.RailcarNumber, 
                    viewModel.Certificate, 
                    viewModel.Receiver,
                    viewModel.ShippingDate))
                    .SetResultTransformer(RailcarQuery.Transformer);

                var qparts = query.List<RailcarPartial>();

                foreach (var item in qparts)
                {
                    railcars.Add(item);
                }

                viewModel.Railcars = railcars;
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
        public virtual bool IsExecutable { get; set; }
    }
}
