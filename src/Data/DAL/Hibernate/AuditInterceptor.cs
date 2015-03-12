using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Ninject;
using Prizm.Domain.Entity;

namespace Prizm.Data.DAL.Hibernate
{
    [Serializable]
    public class AuditInterceptor : EmptyInterceptor, IDisposable
    {
        private IAuditLogRepository repo;
        private PersonName currentUser;

        [Inject]
        public AuditInterceptor(PersonName currentUser)
        {
            this.currentUser = currentUser;
        }

        public virtual IAuditLogRepository LogRepo
        {
            get
            {
                if (repo == null)
                {
                    repo = new AuditLogRepository(HibernateUtil.OpenSession(false));
                }
                return repo;
            }
            set
            {
                repo = value;
            }
        }

        enum Actions { Insert, Delete };

        /// <summary>
        /// Is called while inserting new record
        /// </summary>
        public override bool OnSave(
            object entity, 
            object id, 
            object[] state, 
            string[] propertyNames, 
            NHibernate.Type.IType[] types)
        {
            LogAudit(entity, propertyNames, Actions.Insert, state);
            return base.OnSave(entity, id, state, propertyNames, types);
        }

        /// <summary>
        /// Is called while updating existing record
        /// </summary>
        public override bool OnFlushDirty(
            object entity, 
            object id, 
            object[] currentState, 
            object[] previousState, 
            string[] propertyNames, 
            NHibernate.Type.IType[] types)
        {
            if (previousState == null) return false;

            var curentity = entity as Item;

            if (curentity != null)
            {
                for (var i = 0; i < currentState.Count(); i++)
                {
                    if (currentState[i] != null && IsAuditableType(currentState[i]) 
                        ||
                        previousState[i] != null && IsAuditableType(previousState[i]))
                    {
                        string newValue = string.Empty;
                        string oldValue = string.Empty;

                        if (currentState[i] is Item || previousState[i] is Item)
                        {
                            if (currentState[i] != null) newValue = ((Item)currentState[i]).Id.ToString();
                            if (previousState[i] != null) oldValue = ((Item)previousState[i]).Id.ToString();
                        }
                        else
                        {
                            if (currentState[i] != null) newValue = currentState[i].ToString();
                            if (previousState[i] != null) oldValue = previousState[i].ToString();
                        }

                        if (newValue != oldValue)
                        {
                            NewAuditRecord(curentity, propertyNames[i], newValue, oldValue);
                        }
                    }
                }
            }
            return base.OnFlushDirty(entity, id, currentState, previousState, propertyNames, types);
        }

        /// <summary>
        /// Creating log record and saving it to DB
        /// </summary>
        private void NewAuditRecord(
            Item curentity, 
            string fieldName, 
            string newValue, 
            string oldValue)
        {
            string entityType = curentity.GetType().ToString();
            string tableName = entityType.Substring(entityType.LastIndexOf('.') + 1);
            AuditLog record = new AuditLog()
            {
                AuditID = Guid.NewGuid(),
                EntityID = curentity.Id,
                AuditDate = DateTime.Now,
                User = currentUser.GetFullName(),
                TableName = tableName,
                FieldName = fieldName,
                NewValue = newValue,
                OldValue = oldValue
            };
            LogRepo.BeginTransaction();
            LogRepo.Save(record);
            LogRepo.Commit();
            LogRepo.Evict(record);
        }

        /// <summary>
        /// Is called whilr deleting record
        /// </summary>
        public override void OnDelete(
            object entity, 
            object id, 
            object[] state, 
            string[] propertyNames, 
            NHibernate.Type.IType[] types)
        {
            LogAudit(entity, propertyNames, Actions.Delete, state);
            base.OnDelete(entity, id, state, propertyNames, types);
        }

        /// <summary>
        /// Log  insert/delete record (just one state)
        /// </summary>
        private void LogAudit(
            object entity, 
            string[] propertyNames, 
            Actions actionType, 
            params object[] state)
        {
            string oldValue = "just inserted";
            string newValue = "";

            var curentity = entity as Item;

            if (curentity != null)
            {
                for (var i = 0; i < propertyNames.Count(); i++)
                {
                    if (state[i] != null && IsAuditableType(state[i]))
                    {
                        switch (actionType)
                        {
                            case Actions.Insert:
                                newValue = (state[i] is Item) ? ((Item)state[i]).Id.ToString() : state[i].ToString();
                                break;

                            case Actions.Delete:
                                oldValue = (state[i] is Item) ? ((Item)state[i]).Id.ToString() : state[i].ToString();
                                newValue = "deleted";
                                break;

                            default:
                                break;
                        }

                        NewAuditRecord(curentity, propertyNames[i], newValue, oldValue);
                    }
                }
            }
        }


        private bool IsAuditableType(object obj)
        {
            var a = obj.GetType().IsValueType;
            var b = obj.GetType() == typeof(string) ;
            var c = obj.GetType().FullName.StartsWith("Prizm.Domain");

            return 
                obj.GetType().IsValueType
                || obj.GetType() == typeof(string)
                || obj.GetType().FullName.StartsWith("Prizm.Domain");
        }

        #region IDisposable Members

        public void Dispose()
        {
            repo.Dispose();
        }

        #endregion
    }
}
