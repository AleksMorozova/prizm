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
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.ReleaseNote.Search
{
    public class SearchReleaseNoteCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SearchReleaseNoteCommand));

        private readonly ReleaseNoteSearchViewModel viewModel;
        private readonly IReleaseNoteRepository repo;
        private readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public SearchReleaseNoteCommand(
            ReleaseNoteSearchViewModel viewmodel,
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
                var projList = viewModel.Projection;
                projList.Clear();
                var list = repo.SearchReleases(
                    viewModel.ReleaseNoteNumber,
                    viewModel.StartDate,
                    viewModel.EndDate,
                    viewModel.PipeNumber,
                    viewModel.RailcarNumber,
                    viewModel.Certificate,
                    viewModel.Receiver);

                foreach(var release in list)
                {
                    foreach(var car in release.Railcars)
                    {
                        projList.Add(new ReleaseNoteProjection
                        {
                            Id = release.Id,
                            NoteNumber = release.Number,
                            NoteDate = release.Date.ToShortDateString(),
                            CarNumber = car.Number,
                            CarCertificate = car.Certificate,
                            CarDestination = car.Destination,
                            Status = release.Shipped
                        });
                    }
                }

                viewModel.Projection = new BindingList<ReleaseNoteProjection>(projList);

                RefreshVisualStateEvent();
            }
            catch(RepositoryException ex)
            {
                log.Error(ex.Message);
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }

        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
