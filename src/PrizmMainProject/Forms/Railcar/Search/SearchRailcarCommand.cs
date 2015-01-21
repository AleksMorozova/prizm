using Prizm.Data.DAL;
using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using NHibernate;
using NHibernate.Criterion;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Prizm.Main.Forms.Railcar.Search
{
    public class SearchRailcarCommand : ICommand
    {
        private readonly RailcarSearchViewModel viewModel;
        private readonly IRailcarRepository repo;
        private readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

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
                var railcars = new List<Railcar>();

                var query = repo
                    .CreateSQLQuery(RailcarQuery.BuildSql(
                    viewModel.RailcarNumber, 
                    viewModel.Certificate, 
                    viewModel.Receiver,
                    viewModel.ShippingDate, 
                    viewModel.ReleaseNoteNumber,
                    viewModel.ReleaseNoteDate))
                    .SetResultTransformer(RailcarQuery.Transformer);

                var qparts = query.List<Railcar>();

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
    }
}
