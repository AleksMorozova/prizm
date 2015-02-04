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

namespace Prizm.Data.DAL.Hibernate
{
    public class AuditLogRepository : AbstractHibernateRepository<Guid, AuditLog>, IAuditLogRepository
    {
        [Inject]
        public AuditLogRepository(ISession session)
            : base(session)
        {
        }
        public IEnumerable<string> GetAllUsers()
        {
            return (from b in session.QueryOver<AuditLog>() select b.User).List<string>().Distinct();
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
        /// search by Number overload
        /// </summary>
        /// <param name="number"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>

        public IList<AuditLog> GetRecordsByNumber(string number, DateTime startDate, DateTime endDate)
        {

            //source for EntityID and Number matching
            Dictionary<Guid, string> DNumberLookup = new Dictionary<Guid, string>();

            //creating DB-wide list of EntityIDs with Number matching mask
            string[] tablesToLook = new string[] { "Spool", "Pipe", "Component", "Joint", "Heat", "PurchaseOrder" };
            object[] tablesToLookAsObjects = (object[])tablesToLook;

            IEnumerable<Guid> list1 = session.QueryOver<Prizm.Domain.Entity.Construction.Component>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            IEnumerable<string> listNumbers = session.QueryOver<Prizm.Domain.Entity.Construction.Component>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            DNumberLookup = DNumberLookupUpdate(DNumberLookup, list1, listNumbers);

            IEnumerable<Guid> list2 = session.QueryOver<Spool>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            listNumbers = session.QueryOver<Spool>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            DNumberLookup = DNumberLookupUpdate(DNumberLookup, list2, listNumbers);


            IEnumerable<Guid> list3 = session.QueryOver<Pipe>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            listNumbers = session.QueryOver<Pipe>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            DNumberLookup = DNumberLookupUpdate(DNumberLookup, list3, listNumbers);

            IEnumerable<Guid> list4 = session.QueryOver<Joint>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            listNumbers = session.QueryOver<Joint>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            DNumberLookup = DNumberLookupUpdate(DNumberLookup, list4, listNumbers);

            IEnumerable<Guid> list5 = session.QueryOver<PurchaseOrder>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            listNumbers = session.QueryOver<PurchaseOrder>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            DNumberLookup = DNumberLookupUpdate(DNumberLookup, list5, listNumbers);

            IEnumerable<Guid> list6 = session.QueryOver<Heat>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            listNumbers = session.QueryOver<Heat>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            DNumberLookup = DNumberLookupUpdate(DNumberLookup, list6, listNumbers);

            IEnumerable<Guid> list7 = session.QueryOver<AuditLog>().
                Where(_ => _.FieldName.IsLike("number")
                    && _.TableName.IsIn(tablesToLookAsObjects)
                    && _.OldValue.IsLike(number, MatchMode.Start)).
                Select(_ => _.EntityID).
                List<Guid>().
                Distinct();

            //unique DB-wide Guids values list with Numbers mask match
            var listOfGuids = list1.
                Concat<Guid>(list2).
                Concat<Guid>(list3).
                Concat<Guid>(list4).
                Concat<Guid>(list5).
                Concat<Guid>(list6).
                Concat<Guid>(list7).
                Distinct().
                ToArray();

            // getting values with Guids related to matching names
            var retVal = session.QueryOver<AuditLog>().
                Where(_ => _.AuditDate <= endDate && _.AuditDate >= startDate && _.EntityID.IsIn(listOfGuids)).
                List<AuditLog>();

            //updating retVal with actual Numbers
            foreach (var item in retVal)
            {
                if (DNumberLookup.ContainsKey(item.EntityID))
                {
                    item.Number = DNumberLookup[item.EntityID];
                }
            }

            return retVal ?? new List<AuditLog>();
        }

        /// <summary>
        /// search by User overload
        /// </summary>
        /// <param name="user"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public IList<AuditLog> GetRecordsByUser(string user, DateTime startDate, DateTime endDate)
        {

            var retVal = session.QueryOver<AuditLog>()
                .Where(_ => _.AuditDate <= endDate && _.AuditDate >= startDate)
                .WhereRestrictionOn(x => x.User).IsLike(user).List<AuditLog>();


            return retVal ?? new List<AuditLog>();
        }
    }
}