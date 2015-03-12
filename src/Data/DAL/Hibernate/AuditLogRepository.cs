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
using Prizm.Domain.Entity.Security;

namespace Prizm.Data.DAL.Hibernate
{
    public class AuditLogRepository : AbstractHibernateRepository<Guid, AuditLog>, IAuditLogRepository
    {
        private IList<User> userList;
        [Inject]
        public AuditLogRepository(ISession session)
            : base(session)
        {
            List<Guid> userIdList = (from b in session.QueryOver<AuditLog>() select b.User).List<Guid>().Distinct().ToList<Guid>();
            userList = session.QueryOver<User>().WhereRestrictionOn(x => x.Id).IsIn(userIdList).List<User>();
        }
        public Dictionary<Guid, string> GetAllUsers()
        {
            Dictionary<Guid, string> userNameList = new Dictionary<Guid, string>();
            foreach (User user in userList)
            {
                userNameList.Add(user.Id, user.Name.GetFullName());
            }
            return userNameList;
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
            AuditLogQuery.Transformer.Users = userList;
            var query = session.CreateSQLQuery(
                  @"select a.id, a.entityID, a.auditDate, a.userId, a.tableName, a.fieldName, a.oldValue, a.newValue, b.number as number " +
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
        public IList<AuditLog> GetRecordsByUser(Guid user, DateTime startDate, DateTime endDate)
        {
            var retVal = session.QueryOver<AuditLog>()
                .Where(_ => _.AuditDate <= endDate.AddHours(23).AddMinutes(59).AddSeconds(59) 
                         && _.AuditDate >= startDate
                         && _.User == user).List<AuditLog>();
            User selectedUser = userList.Where(_ => _.Id == user).SingleOrDefault();
            string userName = "";
            if (selectedUser != null)
            {
                userName = selectedUser.Name.GetFullName();
            }
            if (retVal != null)
            {
                foreach (AuditLog record in retVal)
                {
                    record.UserName = userName;
                }
            }
            return retVal ?? new List<AuditLog>();
        }

    }

    public class AuditLogQuery : IResultTransformer
    {
        public static readonly AuditLogQuery Transformer = new AuditLogQuery();
        public IList<User> Users { get; set; }
        private AuditLogQuery()
        {
        }

        #region IResultTransformer Members

        public IList TransformList(IList collection)
        {
            return collection;
        }

        public object TransformTuple(object[] tuple, string[] aliases)
        {

            return new AuditLog()
            {
                AuditID = (Guid)tuple[0],
                EntityID = (Guid)tuple[1],
                AuditDate = (DateTime)tuple[2],
                User = (Guid)tuple[3],
                TableName = (ItemTypes)tuple[4],
                FieldName = (FieldNames)tuple[5],
                OldValue = (tuple[6] == null) ? "just inserted" : tuple[6].ToString(),
                NewValue = (tuple[7] == null) ? "deleted" : tuple[7].ToString(),
                Number = tuple[8].ToString(),
                UserName = Users.Where(_ => _.Id == (Guid)tuple[3]).SingleOrDefault().Name.GetFullName()
            };
        }
        #endregion
    }
  
}