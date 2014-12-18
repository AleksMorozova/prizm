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

namespace Prizm.Main.Forms.Audit
{
    public class AuditViewModel : ViewModelBase, IDisposable
    {
        private readonly IAuditLogRepository repo;
        private readonly IMillReportsRepository adoRepo;
        private readonly AuditSearchCommand searchCommand;
        private DataTable auditResults;
        private DateTime startDate = DateTime.Now.Date;
        private DateTime endDate = DateTime.Now.Date;
        public IEnumerable<string> UsersList;
        private string selectedUser = "";

        [Inject]
        public AuditViewModel(IAuditLogRepository repo, IMillReportsRepository adoRepo)
        {
            this.repo = repo;
            this.adoRepo = adoRepo;
            UsersList = repo.GetAllUsers();
            searchCommand = ViewModelSource.Create(() => new AuditSearchCommand (this, adoRepo));
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

        public DataTable AuditResults
        {
            get
            {
                return auditResults;
            }
            set
            {
                if (value != auditResults)
                {

                    foreach (DataRow record in value.Rows)
                    {
                        string tableResourceValue = Resources.ResourceManager.GetString(record.Field<string>("tableName")) == null ? record.Field<string>("tableName") : Resources.ResourceManager.GetString(record.Field<string>("tableName"));
                        string fieldResourceValue = Resources.ResourceManager.GetString(record.Field<string>("fieldName")) == null ? record.Field<string>("fieldName") : Resources.ResourceManager.GetString(record.Field<string>("fieldName"));
                        record.SetField("tableName", tableResourceValue);
                        record.SetField("fieldName", fieldResourceValue);
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
    }
}
