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

        //public IList<AuditLog> GetRecords(string user, DateTime startDate, DateTime endDate, string entityID)
        //{

        //    return session.QueryOver<AuditLog>().Where(_ => _.AuditDate <= endDate && _.AuditDate >= startDate).WhereRestrictionOn(x => x.User).IsLike(user).List<AuditLog>();

        //}


        //public IList<AuditLog> GetRecords(string user, DateTime startDate, DateTime endDate, string entityIDSub)
        //{
        //     return session.QueryOver<AuditLog>().Where(_ => _.AuditDate <= endDate && _.AuditDate >= startDate && _.EntityID.ToString().StartsWith(entityIDSub)).List<AuditLog>();
        //}

        public IList<AuditLog> GetRecords(string entityIDSub, string user)
        {
            //Guid substr = new Guid(entityIDSub + "%");
            string substr = entityIDSub;
            //return session.QueryOver<AuditLog>().WhereRestrictionOn(_ => _.EntityID.ToString()).IsLike(substr, MatchMode.Start).WhereRestrictionOn(x => x.User).IsLike(user).List<AuditLog>();
            return session.QueryOver<AuditLog>().WhereRestrictionOn(x => x.User).IsLike(user).List<AuditLog>();
        }

        //public IList<AuditLog> GetRecords(string entityIDSub, DateTime startDate, DateTime endDate)
        //{
        //    return session.QueryOver<AuditLog>().Where(_ => _.AuditDate <= endDate && _.AuditDate >= startDate).List<AuditLog>();
        //}

        public IList<AuditLog> GetRecordsByNumber(string number, DateTime startDate, DateTime endDate)
        {

            //source for EntityID and Number matching
            Dictionary<Guid, string> DNumberLookup = new Dictionary<Guid, string>();

            //creating DB-wide list of EntityIDs with matching Number
            string[] tablesToLook = new string[] { "Spool", "Pipe", "Component", "Joint", "Heat", "PurchaseOrder" };
            object[] tablesToLookAsObjects = (object[])tablesToLook;
            
            IEnumerable<Guid> list1 = session.QueryOver<Prizm.Domain.Entity.Construction.Component>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            IEnumerable<string> list1a = session.QueryOver<Prizm.Domain.Entity.Construction.Component>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
          
            for (int i = 0; i < list1.Count(); i++)
            {
                list1.ElementAt(i);
                list1a.ElementAt(i);
                DNumberLookup.Add(list1.ElementAt(i), list1a.ElementAt(i));
            }

            IEnumerable<Guid> list2 = session.QueryOver<Spool>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            IEnumerable<string> list2a = session.QueryOver<Spool>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            for (int i = 0; i < list2.Count(); i++)
            {
                list2.ElementAt(i);
                list2a.ElementAt(i);
                DNumberLookup.Add(list2.ElementAt(i), list2a.ElementAt(i));
            }


            IEnumerable<Guid> list3 = session.QueryOver<Pipe>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            IEnumerable<string> list3a = session.QueryOver<Pipe>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            for (int i = 0; i < list3.Count(); i++)
            {
                list3.ElementAt(i);
                list3a.ElementAt(i);
                DNumberLookup.Add(list3.ElementAt(i), list3a.ElementAt(i));
            }

            IEnumerable<Guid> list4 = session.QueryOver<Joint>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            IEnumerable<string> list4a = session.QueryOver<Joint>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            for (int i = 0; i < list4.Count(); i++)
            {
                list4.ElementAt(i);
                list4a.ElementAt(i);
                DNumberLookup.Add(list4.ElementAt(i), list4a.ElementAt(i));
            }

            IEnumerable<Guid> list5 = session.QueryOver<PurchaseOrder>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            IEnumerable<string> list5a = session.QueryOver<PurchaseOrder>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            for (int i = 0; i < list5.Count(); i++)
            {
                list5.ElementAt(i);
                list5a.ElementAt(i);
                DNumberLookup.Add(list5.ElementAt(i), list5a.ElementAt(i));
            }
            
            IEnumerable<Guid> list6 = session.QueryOver<Heat>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Id).List<Guid>();
            IEnumerable<string> list6a = session.QueryOver<Heat>().Where(_ => _.Number.IsLike(number, MatchMode.Start)).Select(_ => _.Number).List<string>();
            for (int i = 0; i < list6.Count(); i++)
            {
                list6.ElementAt(i);
                list6a.ElementAt(i);
                DNumberLookup.Add(list6.ElementAt(i), list6a.ElementAt(i));
            }

            //IEnumerable<Guid> list7 = session.QueryOver<AuditLog>().
            //    Where(_ => _.FieldName.Equals("number", StringComparison.InvariantCultureIgnoreCase)
            //        && _.TableName.IsIn(tablesToLookAsObjects)
            //        && _.OldValue.StartsWith(number)).
            //    Select(_ => _.EntityID).
            //    List<Guid>().
            //    Distinct();

            //IEnumerable<string> list7a = session.QueryOver<AuditLog>().
            //    Where(_ => _.FieldName.Equals("number", StringComparison.InvariantCultureIgnoreCase)
            //        && _.TableName.IsIn(tablesToLookAsObjects)
            //        && _.OldValue.StartsWith(number)).
            //    Select(_ => _.OldValue).
            //    List<string>().
            //    Distinct();
                
                
            //for (int i = 0; i < list7.Count(); i++)
            //{
            //    list7.ElementAt(i);
            //    list7a.ElementAt(i);
            //    DNumberLookup.Add(list7.ElementAt(i), list7a.ElementAt(i));
            //}

            //unique Guids values only list
            var listOfGuids = list1.
                Concat<Guid>(list2).
                Concat<Guid>(list3).
                Concat<Guid>(list4).
                Concat<Guid>(list5).
                Concat<Guid>(list6).
                //Concat<Guid>(list7).
                Distinct().
                ToArray();

            var retVal = session.QueryOver<AuditLog>().
                Where(_ => _.AuditDate <= endDate && _.AuditDate >= startDate && _.EntityID.IsIn(listOfGuids)).
                List<AuditLog>();
            
            foreach (var item in retVal)
            {
                if (DNumberLookup.ContainsKey(item.EntityID))
                {
                    item.Number = DNumberLookup[item.EntityID];
                }
            }


            return retVal;
        }
    }
}
