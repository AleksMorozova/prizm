using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Ninject;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Security;

namespace Prizm.Data.DAL.Hibernate
{
    [Serializable]
    public class AuditInterceptor : EmptyInterceptor, IDisposable
    {
        private IAuditLogRepository repo;
        private User currentUser;

        [Inject]
        public AuditInterceptor(User currentUser)
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
        public override bool OnSave(object entity, object id, object[] state, string[] propertyNames, NHibernate.Type.IType[] types)
        {
            LogAudit(entity, propertyNames, Actions.Insert, state);
            return base.OnSave(entity, id, state, propertyNames, types);
        }

        /// <summary>
        /// Is called while updating existing record
        /// </summary>
        public override bool OnFlushDirty(object entity, object id, object[] currentState, object[] previousState, string[] propertyNames, NHibernate.Type.IType[] types)
        {
            if (previousState == null) return false;
            var curentity = entity as Item;
            if (curentity != null)
            {
                for (var i = 0; i < currentState.Count(); i++)
                {
                    if (currentState[i] == null && previousState[i] == null) continue; // prevent exeption 
                    else if (currentState[i] == null || previousState[i] == null) //prevent exeption
                    {
                        string newValue = (currentState[i] == null) ? null : currentState[i].ToString();
                        string oldValue = (previousState[i] == null || previousState == null) ? null : previousState[i].ToString();
                        NewAuditRecord(curentity, propertyNames[i], newValue, oldValue);

                    }
                    else if (currentState[i].ToString().StartsWith("System.Collections.Generic") || currentState[i].ToString().StartsWith("System.ComponentModel.BindingList") || previousState[i].ToString().StartsWith("System.Collections.Generic") || previousState[i].ToString().StartsWith("System.ComponentModel.BindingList") || currentState[i].ToString().StartsWith("Prizm.Domain") || previousState[i].ToString().StartsWith("Prizm.Domain"))
                    {
                        continue;
                    }
                    else if (currentState[i] as Item == null && currentState[i].ToString() != previousState[i].ToString())
                    {
                        NewAuditRecord(curentity, propertyNames[i], currentState[i].ToString(), previousState[i].ToString());
                    }                
                    else
                    {
                        var previousStateId = previousState[i] as Item;
                        var currentStateId = currentState[i] as Item;
                        if (previousStateId != null && currentState[i].Equals(previousState[i]) == false)
                        {
                            NewAuditRecord(curentity, propertyNames[i], previousStateId.Id.ToString(), currentStateId.Id.ToString());
                        }
                    }
                }
            }
            return base.OnFlushDirty(entity, id, currentState, previousState, propertyNames, types);
        }

        /// <summary>
        /// Creating log record and saving it to DB
        /// </summary>
        private void NewAuditRecord(Item curentity, string fieldName, string newValue, string oldValue)
        {
            string entityType = curentity.GetType().ToString();
            string stringTableName = entityType.Substring(entityType.LastIndexOf('.') + 1);
            ItemTypes tableName = ItemTypes.Undefined;
            Enum.TryParse(stringTableName, true, out tableName);
            FieldNames enumFieldName = FieldNames.Undefined;
            Enum.TryParse(fieldName, true, out enumFieldName);

            AuditLog record = new AuditLog()
            {
                AuditID = Guid.NewGuid(),
                EntityID = curentity.Id,
                AuditDate = DateTime.Now,
                User = currentUser,
                TableName = tableName,
                FieldName = enumFieldName,
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
        public override void OnDelete(object entity, object id, object[] state, string[] propertyNames, NHibernate.Type.IType[] types)
        {
            LogAudit(entity, propertyNames, Actions.Delete, state);
            base.OnDelete(entity, id, state, propertyNames, types);
        }

        /// <summary>
        /// Log  insert/delete record (just one state)
        /// </summary>
        private void LogAudit(object entity, string[] propertyNames, Actions actionType, params object[] state)
        {
            string oldValue = null, newValue =null;
            var curentity = entity as Item;
            if (curentity != null)
            {
                for (var i = 0; i < propertyNames.Count(); i++)
                {
                    if (state[i] == null) continue;
                    var objectProperty = state[i] as Item;
                    switch (actionType)
                    {
                        case Actions.Insert: newValue = (objectProperty == null) ? state[i].ToString() : objectProperty.Id.ToString();
                            break;
                        case Actions.Delete: oldValue = (objectProperty == null) ? state[i].ToString() : objectProperty.Id.ToString();
                            newValue = "deleted";
                            break;
                        default: break;
                    }
                    if (state[i].ToString().StartsWith("System.Collections.Generic") || state[i].ToString().StartsWith("System.ComponentModel.BindingList") || state[i].ToString().StartsWith("Prizm.Domain") || state[i].ToString().StartsWith("Prizm.Domain"))
                        continue;
                    NewAuditRecord(curentity, propertyNames[i], newValue, oldValue);
                }
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            repo.Dispose();
        }

        #endregion
    }
}
