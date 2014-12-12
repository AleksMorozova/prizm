using Data.DAL.Construction;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Domain.Entity.Construction;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Joint.Search
{
    public class JointSearchViewModel : ViewModelBase
    {
        private readonly JointSearchCommand searchCommand;

        [Inject]
        public JointSearchViewModel(IJointRepository repo)
        {
            searchCommand = ViewModelSource.Create(() => new JointSearchCommand(this, repo));
        }

        #region BindingFields
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

        private string pegNumber = "";
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
        #endregion

        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }
    }
}
