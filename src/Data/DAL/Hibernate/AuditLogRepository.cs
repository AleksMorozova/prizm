using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Ninject;
using Prizm.Domain.Entity;
using NHibernate.Criterion;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Construction;
using NHibernate.Transform;
using System.Collections;

namespace Prizm.Data.DAL.Hibernate
{
    public class AuditLogRepository : AbstractHibernateRepository<Guid, AuditLog>, IAuditLogRepository
    {
        [Inject]
        public AuditLogRepository(ISession session)
            : base(session)
        {
        }
        public IEnumerable<Guid> GetAllUsers()
        {
            IEnumerable<Guid> list = (from b in session.QueryOver<AuditLog>() select b.User).List<Guid>().Distinct();
            return list;
        }


        private Dictionary<Guid, string> DNumberLookupUpdate(Dictionary<Guid, string> DNumberLookup, IEnumerable<Guid> listGuids, IEnumerable<string> listNumbers)
        {
            for (int i = 0; i < listGuids.Count(); i++)
            {
                listGuids.ElementAt(i);
                listNumbers.ElementAt(i);
                if (listGuids.ElementAt(i) != null)
                {
                    DNumberLookup[listGuids.ElementAt(i)] = listNumbers.ElementAt(i);
                }
            }

            return DNumberLookup;
        }


        /// <summary>
        /// search by Number
        /// </summary>
        /// <param name="number"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>

        public IList<AuditLog> GetRecordsByNumber(string number, DateTime startDate, DateTime endDate)
        {
          var query = session.CreateSQLQuery(
                  @"select a.id, a.entityID, a.auditDate, a.userName, a.tableName, a.fieldName, a.oldValue, a.newValue, b.number as number " +
                  " from AuditLog a " +
                  " join (select id, number from Pipe WHERE number LIKE CONCAT(:entityNumber, '%')" + 
                  " union all" +
                  " select id, number from Spool WHERE number LIKE CONCAT(:entityNumber, '%')" + 
                  " union all" +
                  " select id, number from Joint WHERE number LIKE CONCAT(:entityNumber, '%')" +
                  " union all" +
                  " select id, number from Heat WHERE number LIKE CONCAT(:entityNumber, '%')" +
                  " union all" +
                  " select id, number from PurchaseOrder WHERE number LIKE CONCAT(:entityNumber, '%')" +
                  " union all" +
                  " select id,number from Component WHERE number LIKE CONCAT(:entityNumber, '%')) b on a.entityID = b.id" +
                  " where a.auditDate >= :startDate AND a.auditDate <= :endDate").SetResultTransformer(AuditLogQuery.Transformer);

            query.SetString("entityNumber", number.ToString());
            query.SetDateTime("startDate", startDate);
            query.SetDateTime("endDate", endDate.AddHours(23).AddMinutes(59).AddSeconds(59));
            var results = query.List<AuditLog>();
            return results;
        }

        /// <summary>
        /// search by User
        /// </summary>
        /// <param name="user"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public IList<AuditLog> GetRecordsByUser(string user, DateTime startDate, DateTime endDate)
        {
            var retVal = session.QueryOver<AuditLog>()
                .Where(_ => _.AuditDate <= endDate.AddHours(23).AddMinutes(59).AddSeconds(59) && _.AuditDate >= startDate)
                .WhereRestrictionOn(x => x.User).IsLike(user).List<AuditLog>();

            return retVal ?? new List<AuditLog>();
        }
    }

    public class AuditLogQuery : IResultTransformer
    {
        private ISession session;

        public static readonly AuditLogQuery Transformer = new AuditLogQuery();

        private AuditLogQuery()
        { }

        #region IResultTransformer Members

        public IList TransformList(IList collection)
        {
            return collection;
        }

        public object TransformTuple(object[] tuple, string[] aliases)
        {
            AuditLog rec = new AuditLog();
            rec.AuditID = (Guid)tuple[0];
            rec.EntityID = (Guid)tuple[1];
            rec.AuditDate = (DateTime)tuple[2];
            rec.User = (Guid)tuple[3];
            rec.TableName = (ItemTypes)tuple[4];
            rec.FieldName = (FieldNames)tuple[5];
            rec.OldValue = (tuple[6] == null) ? "just inserted" : tuple[6].ToString();
            rec.NewValue = (tuple[7] == null) ? "deleted" : tuple[7].ToString();
            rec.Number = tuple[8].ToString();
            //{
             //   AuditID = (Guid)tuple[0],
             //   EntityID = (Guid)tuple[1],
             //   AuditDate = (DateTime)tuple[2],
             //   User = (Guid)tuple[3],              
             //   TableName = (ItemTypes)tuple[4],
             //   FieldName = (FieldNames)tuple[5],
             //   OldValue = (tuple[6]==null) ? "just inserted" : tuple[6].ToString(),
             //   NewValue = (tuple[7] == null) ? "deleted" : tuple[7].ToString(),
             //   Number = tuple[8].ToString(),
            //};
           return rec;
        }
        #endregion
    }
}