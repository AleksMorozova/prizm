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
            if (Prizm.Main.Common.DateExtension.CheckDiapason(viewModel.StartDate, viewModel.EndDate)) 
            {
                try
                {
                    var projList = viewModel.Projection;
                    projList.Clear();
                    List<Prizm.Domain.Entity.Mill.ReleaseNote> note = new List<Domain.Entity.Mill.ReleaseNote>(); ;

                    if ((viewModel.PipeNumber == string.Empty) &&
                        (viewModel.RailcarNumber == string.Empty)) 
                    {
                        note = repo.SearchReleases(viewModel.ReleaseNoteNumber,
                        viewModel.StartDate,
                        viewModel.EndDate);
                    }
                    else if ((viewModel.PipeNumber != string.Empty) &&
                        (viewModel.RailcarNumber != string.Empty)) 
                    {
                        note = repo.SearchReleasesAllCreteria(viewModel.ReleaseNoteNumber,
                    viewModel.StartDate,
                    viewModel.EndDate,
                    viewModel.PipeNumber,
                    viewModel.RailcarNumber,
                    viewModel.Certificate,
                    viewModel.Receiver);
                    }

                    else if ((viewModel.PipeNumber != string.Empty) &&
                        (viewModel.RailcarNumber == string.Empty))
                    {
                        note = repo.SearchReleasesByPipe(viewModel.ReleaseNoteNumber,
                    viewModel.StartDate,
                    viewModel.EndDate,
                    viewModel.PipeNumber);
                    }
                    else if ((viewModel.PipeNumber == string.Empty) &&
                        (viewModel.RailcarNumber != string.Empty))
                    {
                        note = repo.SearchReleasesByRailcar(viewModel.ReleaseNoteNumber,
                    viewModel.StartDate,
                    viewModel.EndDate,
                    viewModel.RailcarNumber,
                    viewModel.Certificate,
                    viewModel.Receiver);
                    }

                    //var list = repo.SearchReleases(
                    //    viewModel.ReleaseNoteNumber,
                    //    viewModel.StartDate,
                    //    viewModel.EndDate);

                    foreach (var release in note)
                    {
                        projList.Add(new ReleaseNoteProjection
                        {
                            Id = release.Id,
                            NoteNumber = release.Number,
                            NoteDate = release.Date.ToShortDateString(),
                            Status = release.Shipped
                        });
                    }

                    viewModel.Projection = new BindingList<ReleaseNoteProjection>(projList);

                    RefreshVisualStateEvent();
                }
                catch (RepositoryException ex)
                {
                    log.Error(ex.Message);
                    notify.ShowFailure(ex.InnerException.Message, ex.Message);
                }
            } 
            else 
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.WrongDate),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                log.Warn("Date limits not valid!");
            }

        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
