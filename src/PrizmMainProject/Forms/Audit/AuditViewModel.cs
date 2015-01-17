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

namespace Prizm.Main.Forms.Audit
{
    public class AuditViewModel : ViewModelBase, IDisposable
    {
        private readonly IAuditLogRepository repo;
        private readonly AuditSearchCommand searchCommand;
        private BindingList<AuditLog> auditResults;
        private DateTime startDate = DateTime.Now.Date;
        private DateTime endDate = DateTime.Now.Date;
        public IEnumerable<string> UsersList;
        private string selectedUser = "";
        private string entityID = "";

        [Inject]
        public AuditViewModel(IAuditLogRepository repo)
        {
            this.repo = repo;
            UsersList = repo.GetAllUsers();
            searchCommand = ViewModelSource.Create(() => new AuditSearchCommand (this, repo));
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
                return endDate.AddHours(23).AddMinutes(59).AddSeconds(59);
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
                    foreach (AuditLog record in value)
                    {
                        record.TableName = Resources.ResourceManager.GetString(record.TableName) == null ? record.TableName : Resources.ResourceManager.GetString(record.TableName);
                        record.FieldName = Resources.ResourceManager.GetString(record.FieldName) == null ? record.FieldName : Resources.ResourceManager.GetString(record.FieldName);
                    }
                    auditResults = value;
                    RaisePropertyChanged("AuditResults");
                }
            }
        }

        public string SelectedUser
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

        public string EntityID
        {
            get
            {
                return entityID;
            }
            set
            {
                if (value != entityID)
                {
                    entityID = value;
                    RaisePropertyChanged("EntityID");
                }
            }
        }

        public TracingModeEnum TracingMode { get; set; }
    
    
    }
}
