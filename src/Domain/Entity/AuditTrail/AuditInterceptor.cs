using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace Domain.Entity.AuditTrail
{
    [Serializable]
    public class AuditInterceptor : EmptyInterceptor
    {
        private IAuditLogRepository repo;
        public AuditInterceptor(IAuditLogRepository repo)
        {
            this.repo = repo;
        }
        enum Actions { Insert, Delete };
        public override bool OnSave(object entity, object id, object[] state, string[] propertyNames, NHibernate.Type.IType[] types)
        {
            LogAudit(entity, propertyNames, Actions.Insert, state);
            return base.OnSave(entity, id, state, propertyNames, types);
        }

        public override bool OnFlushDirty(object entity, object id, object[] currentState, object[] previousState, string[] propertyNames, NHibernate.Type.IType[] types)
        {
            var curentity = entity as IAuditable;
            if (curentity != null)
            {
                for (var i = 0; i < currentState.Count(); i++)
                {
                    if (currentState[i].ToString() != previousState[i].ToString())
                    {
                        AuditLog record = new AuditLog()
                        {
                            AuditID = Guid.NewGuid(),
                            EntityID = curentity.GetID(),
                            AuditDate = DateTime.Now,
                            User = curentity.GetUser(),
                            TableName = curentity.GetType().ToString(),
                            FieldName = propertyNames[i],
                            NewValue = currentState[i].ToString(),
                            OldValue = previousState[i].ToString()
                        };
                        repo.Insert(record);
                    }
                }
            }
         return base.OnFlushDirty(entity, id, currentState, previousState, propertyNames, types);                 
        }

        public override void OnDelete(object entity, object id, object[] state, string[] propertyNames, NHibernate.Type.IType[] types)
        {
            LogAudit(entity, propertyNames, Actions.Delete, state);
            base.OnDelete(entity, id, state, propertyNames, types);
        }

        private  void LogAudit(object entity, string[] propertyNames, Actions actionType, params object[] state)
        {
            string newValue = ""; 
            var curentity = entity as IAuditable;
             if (curentity != null)
             {
                 switch (actionType)
                 {
                     case Actions.Insert: newValue = "inserted";
                         break;
                     case Actions.Delete: newValue = "deleted";
                         break;
                     default: break;
                 }
                 AuditLog record = new AuditLog()
                 {
                     AuditID = Guid.NewGuid(),
                     EntityID = curentity.GetID(),
                     AuditDate = DateTime.Now,
                     User = curentity.GetUser(),
                     TableName = curentity.GetType().ToString(),
                     FieldName = "All",
                     NewValue = newValue,
                     OldValue = ""
                 };
                 repo.Insert(record);
             }
        }
    }
}
