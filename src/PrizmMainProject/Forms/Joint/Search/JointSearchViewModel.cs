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
        private EnumWrapper<ActivityStatus> activityArray;
        public IList<EnumWrapper<ActivityStatus>> ActivityTypes;
        [Inject]
        public JointSearchViewModel(IJointRepository repo)
        {
            this.repo = repo;
            searchCommand = ViewModelSource.Create(() => new JointSearchCommand(this, repo));
            LoadStatuses();
        }

        #region BindingFields

        public EnumWrapper<ActivityStatus> ActivityArray
        {
            get
            {
                return activityArray;
            }
            set
            {
                if (value != activityArray)
                {
                    activityArray = value;
                    RaisePropertyChanged("ActivityArray");
                }
            }
        }

        private string activity;
        public string Activity
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

        private int pegNumber;
        public int PegNumber
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
            ActivityTypes = new List<EnumWrapper<ActivityStatus>>();

            foreach (string activeType in Enum.GetNames(typeof(ActivityStatus)))
            {
                ActivityTypes.Add(new EnumWrapper<ActivityStatus>() { Name = activeType });
            }
        }
    }
}
