using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Ninject;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Setup;
using Prizm.Domain.Entity.Security;
using System.Reflection;

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
                        if ((IsMapLikeComponent(currentState[i]) || IsMapLikeComponent(previousState[i])) && currentState[i] != null )
                        {
                            FlushDirtyEntityMapLikeComponent(currentState[i], currentState[i], previousState[i], types);
                            continue;
                        }

                        string newValue = null;
                        string oldValue = null;

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
                User = currentUser.Id,
                TableName = tableName,
                FieldName = enumFieldName,
                NewValue = newValue,
                OldValue = oldValue,
                OwnerId = curentity.OwnerId
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
            string oldValue = null;
            string newValue = null;

            var curentity = entity as Item;

            if (curentity != null)
            {
                for (var i = 0; i < propertyNames.Count(); i++)
                {
                    if (state[i] != null && IsAuditableType(state[i]))
                    {
                        if (IsMapLikeComponent(state[i]))
                        {
                            LogAuditEntityMapLikeComponent(state[i], actionType);
                            continue;
                        }

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
            return 
                obj.GetType().IsValueType
                || obj.GetType() == typeof(string)
                || obj.GetType().FullName.StartsWith("Prizm.Domain");
        }

        private bool IsMapLikeComponent(object obj)
        {
            return
                obj is PersonName
                || obj is PartData
                || obj is Certificate
                || obj is PipeTestFrequency;
        }

        private void LogAuditEntityMapLikeComponent(object entity, Actions actionType)
        {
            List<string> tempNames = new List<string>();
            List<object> tempState = new List<object>();

            foreach (var property in entity.GetType().GetProperties())
            {
                if (property.Name == "Id") continue;

                tempNames.Add(property.Name);
                tempState.Add(property.GetValue(entity));
            }

            this.LogAudit(entity, tempNames.ToArray(), actionType, tempState.ToArray());
        }

        private void FlushDirtyEntityMapLikeComponent(
            object entity,
            object currentState,
            object previousState,
            NHibernate.Type.IType[] types)
        {
            List<string> tempNames = new List<string>();
            List<object> tempCurrentState = new List<object>();
            List<object> tempPreviousState = (previousState == null) ? null : new List<object>();

            var propertyEntity = entity.GetType().GetProperties();
            var propertyCurren = currentState.GetType().GetProperties();
            var propertyPrevious = (previousState == null) ? null : previousState.GetType().GetProperties();

            for (int i = 0; i < propertyEntity.Length; ++i)
            {
                if (propertyEntity[i].Name == "Id") continue;

                tempNames.Add(propertyEntity[i].Name);
                tempCurrentState.Add(propertyCurren[i].GetValue(currentState));
                if (propertyPrevious != null)
                {
                    tempPreviousState.Add(propertyPrevious[i].GetValue(previousState));
                }
            }

            this.OnFlushDirty(
                entity,
                propertyEntity.FirstOrDefault<PropertyInfo>(x => x.Name == "Id").GetValue(entity),
                tempCurrentState.ToArray(),
                (tempPreviousState == null) ? null : tempPreviousState.ToArray(),
                tempNames.ToArray(),
                types);
        }


        #region IDisposable Members

        public void Dispose()
        {
            repo.Dispose();
        }

        #endregion
    }
}
