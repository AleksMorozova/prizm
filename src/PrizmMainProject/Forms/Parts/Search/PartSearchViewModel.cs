using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Prizm.Domain.Entity.Construction;
using NHibernate;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Properties;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.Parts.Search
{
    public class PartSearchViewModel : ViewModelBase, IDisposable
    {
        PartsSearchCommand searchCommand;
        ISession session;


        [Inject]
        public PartSearchViewModel(ISession session)
        {
            this.session = session;
            searchCommand = ViewModelSource.Create(() => new PartsSearchCommand(this, session));
            LoadStatuses();
        }

        private int amount = 0;
        public int Amount
        {
            get { return amount; }
            set
            {
                if (value != amount)
                {
                    amount = value;
                    RaisePropertyChanged("Amount");
                }
            }
        }

        private ActivityCriteria activity;
        public ActivityCriteria Activity
        {
            get { return activity; }
            set
            {
                if (value != activity)
                {
                    activity = value;
                    RaisePropertyChanged("Activity");
                }
            }
        }

        public int ActivityIndex
        {
            get { return (int)Activity; }
            set
            {
                if (value != (int)Activity)
                {
                    Activity = (ActivityCriteria)value;
                    RaisePropertyChanged("ActivityIndex");
                }
            }
        }

        private string number = string.Empty;
        public string Number
        {
            get { return number; }
            set
            {
                if (value != number)
                {
                    number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        private BindingList<Part> parts = new BindingList<Part>();
        public BindingList<Part> Parts
        {
            get { return parts; }
            set
            {
                if (value != parts)
                {
                    parts = value;
                    RaisePropertyChanged("Parts");
                }
            }
        }

        private BindingList<PartType> types = new BindingList<PartType>();
        public BindingList<PartType> Types
        {
            get { return types; }
            set
            {
                if (value != types)
                {
                    types = value;
                    RaisePropertyChanged("Types");
                }
            }
        }

        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        #region IDisposable Members

        public void Dispose()
        {
            session.Dispose();
        }

        #endregion

        private void LoadStatuses()
        {
        }
    }
}
