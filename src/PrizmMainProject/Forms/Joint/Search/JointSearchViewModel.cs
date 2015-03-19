using Prizm.Data.DAL.Construction;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Prizm.Domain.Entity.Construction;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Construction = Prizm.Domain.Entity.Construction;
using Prizm.Main.Properties;
using Prizm.Domain.Entity.Mill;

namespace Prizm.Main.Forms.Joint.Search
{
    public class JointSearchViewModel : ViewModelBase, IDisposable
    {
        private readonly JointSearchCommand searchCommand;
        private readonly IJointRepository repo;
        private readonly IUserNotify notify;

        [Inject]
        public JointSearchViewModel(IJointRepository repo, IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;
            searchCommand = ViewModelSource.Create(() => new JointSearchCommand(this, repo, notify));
            LoadStatuses();
        }

        #region BindingFields

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

        private bool isActive;
        public bool IsActive
        {
            get { return isActive; }
            set
            {
                if (value != isActive)
                {
                    isActive = value;
                    RaisePropertyChanged("Activity");
                }
            }
        }


        private string number = "";
        public string Number
        {
            get { return number; }
            set
            {
                if(value != number)
                {
                    number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        private string pegNumber;
        public string PegNumber
        {
            get { return pegNumber; }
            set
            {
                if(value != pegNumber)
                {
                    pegNumber = value;
                    RaisePropertyChanged("PegNumber");
                }
            }
        }

        private DateTime fromDate;
        public DateTime FromDate
        {
            get { return fromDate; }
            set
            {
                if(value != fromDate)
                {
                    fromDate = value;
                    RaisePropertyChanged("FromDate");
                }
            }
        }

        private DateTime toDate;
        public DateTime ToDate
        {
            get { return toDate; }
            set
            {
                if(value != toDate)
                {
                    toDate = value;
                    RaisePropertyChanged("ToDate");
                }
            }
        }

        private BindingList<JointStatus> statuses = new BindingList<JointStatus>();
        public BindingList<JointStatus> Statuses
        {
            get { return statuses; }
            set
            {
                if(value != statuses)
                {
                    statuses = value;
                    RaisePropertyChanged("Statuses");
                }
            }
        }

        private BindingList<Construction.Joint> joints = new BindingList<Construction.Joint>();
        public BindingList<Construction.Joint> Joints
        {
            get { return joints; }
            set
            {
                if(value != joints)
                {
                    joints = value;
                    RaisePropertyChanged("Joints");
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

        private void LoadStatuses()
        {
        }
    }
}
