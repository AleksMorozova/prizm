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


namespace Prizm.Main.Forms.Railcar.Search
{
    public class RailcarSearchViewModel : ViewModelBase, IDisposable
    {
        private readonly IReleaseNoteRepository repo;
        private readonly SearchRailcarCommand searchCommand;
        private readonly IUserNotify notify;

        private List<Railcar> railcars;

        [Inject]
        public RailcarSearchViewModel(IReleaseNoteRepository repo, IUserNotify notify)
        {
            railcars = new List<Railcar>();
            this.repo = repo;
            this.notify = notify;
            searchCommand = ViewModelSource.Create(() => new SearchRailcarCommand(this, repo, notify));
        }

        public List<Railcar> Railcars
        {
            get { return railcars; }
            set
            {
                if (value != railcars)
                {
                    railcars = value;
                    RaisePropertyChanged("Railcars");
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
                if (value != releaseNoteNumber)
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
                if (value != releaseNoteDate)
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
                if (value != railcarNumber)
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
                if (value != receiver)
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
                if (value != certificate)
                {
                    certificate = value;
                    RaisePropertyChanged("Certificate");
                }
            }
        }

        private DateTime shippingDate = DateTime.MinValue;
        public DateTime ShippingDate
        {
            get { return shippingDate; }
            set
            {
                if (value != shippingDate)
                {
                    shippingDate = value;
                    RaisePropertyChanged("ShippingDate");
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
