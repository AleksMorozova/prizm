using Prizm.Data.DAL;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Prizm.Domain.Entity;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using Prizm.Domain.Entity.Security;

namespace Prizm.Main.Forms.Audit
{
    public class AuditViewModel : ViewModelBase, IDisposable
    {
        private readonly IAuditRepository repo;
        private readonly AuditSearchCommand searchCommand;
        private BindingList<AuditLog> auditResults;
        private DateTime startDate = DateTime.Now.Date;
        private DateTime endDate = DateTime.Now.Date;
        public Dictionary<Guid,string> UsersList = new Dictionary<Guid, string>();
        private Guid selectedUser;
        private string number = "";
        private readonly IUserNotify notify;
        public List<string> OperationTypes { get; set; }

        [Inject]
        public AuditViewModel(IAuditRepository repo, IUserNotify notify)
        {
            this.repo = repo;
            this.notify = notify;
            UsersList = repo.AuditLogRepo.GetAllUsers();
            searchCommand = ViewModelSource.Create(() => new AuditSearchCommand(this, repo.AuditLogRepo, notify));
        }

        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        public void Dispose()
        {
            repo.Dispose();
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                if (value != startDate)
                {
                    startDate = value;
                    RaisePropertyChanged("StartDate");
                }
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                if (value != endDate)
                {
                    endDate = value;
                    RaisePropertyChanged("EndDate");
                }
            }
        }

       public BindingList<AuditLog> AuditResults
        {
            get
            {
                return auditResults;
            }
            set
            {
                if (value != auditResults)
                {
                    auditResults = value;
                    RaisePropertyChanged("AuditResults");
                }
            }
        }

        public Guid SelectedUser
        {
            get
            {
                return selectedUser;
            }
            set
            {
                if (value != selectedUser)
                {
                    selectedUser = value;
                    RaisePropertyChanged("SelectedUser");
                }
            }
        }

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value != number)
                {
                    number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public TracingModeEnum TracingMode { get; set; }
    
    
    }
}
