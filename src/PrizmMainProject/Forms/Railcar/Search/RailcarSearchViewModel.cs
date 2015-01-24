using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using NHibernate;
using Ninject;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity.Mill;


namespace Prizm.Main.Forms.Railcar.Search
{
    public class RailcarSearchViewModel : ViewModelBase, IDisposable
    {
        private readonly IReleaseNoteRepository repo;
        private readonly SearchRailcarCommand searchCommand;
        private readonly IUserNotify notify;


        [Inject]
        public RailcarSearchViewModel(IReleaseNoteRepository repo, IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;
            searchCommand = ViewModelSource.Create(() => new SearchRailcarCommand(this, repo, notify));
        }

        private List<ReleaseNote> releases = new List<ReleaseNote>();
        public List<ReleaseNote> Releases
        {
            get { return releases; }
            set
            {
                if(value != releases)
                {
                    releases = value;
                    RaisePropertiesChanged("Releases");
                }
            }
        }

        #region Search Fields


        #endregion


        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
