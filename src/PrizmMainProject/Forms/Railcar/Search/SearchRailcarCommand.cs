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
        private readonly IReleaseNoteRepository repo;
        private readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public SearchRailcarCommand(
            RailcarSearchViewModel viewmodel, 
            IReleaseNoteRepository repo,
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
                var list = viewModel.Releases;
                list = repo.SearchReleases(
                    viewModel.ReleaseNoteNumber,
                    viewModel.ReleaseNoteDate,
                    viewModel.RailcarNumber,
                    viewModel.Certificate,
                    viewModel.Receiver);
            
                
 
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
