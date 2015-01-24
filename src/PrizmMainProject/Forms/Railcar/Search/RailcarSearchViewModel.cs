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

        private BindingList<ReleaseNoteProjection> projection = new BindingList<ReleaseNoteProjection>();
        public BindingList<ReleaseNoteProjection> Projection
        { 
            get { return projection; }
            set 
            {
                if(projection != value)
                {
                    projection = value;
                    RaisePropertyChanged("Projection");
                }
            }
        }

        #region Search Fields

        private string releaseNoteNumber = "";
        public string ReleaseNoteNumber
        {
            get { return releaseNoteNumber; }
            set
            {
                if(value != releaseNoteNumber)
                {
                    releaseNoteNumber = value;
                    RaisePropertyChanged("ReleaseNoteNumber");
                }
            }
        }

        private DateTime releaseNoteDate = DateTime.MinValue;
        public DateTime ReleaseNoteDate
        {
            get { return releaseNoteDate; }
            set
            {
                if(value != releaseNoteDate)
                {
                    releaseNoteDate = value;
                    RaisePropertyChanged("ShippingDate");
                }
            }
        }

        private string railcarNumber = "";
        public string RailcarNumber
        {
            get { return railcarNumber; }
            set
            {
                if(value != railcarNumber)
                {
                    railcarNumber = value;
                    RaisePropertyChanged("RailcarNumber");
                }
            }
        }

        private string receiver = "";
        public string Receiver
        {
            get { return receiver; }
            set
            {
                if(value != receiver)
                {
                    receiver = value;
                    RaisePropertyChanged("Receiver");
                }
            }
        }

        private string certificate = "";
        public string Certificate
        {
            get { return certificate; }
            set
            {
                if(value != certificate)
                {
                    certificate = value;
                    RaisePropertyChanged("Certificate");
                }
            }
        }
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
