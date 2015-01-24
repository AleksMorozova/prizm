using NHibernate;
using NHibernate.Criterion;
using Ninject;
using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class ReleaseNoteRepository : AbstractHibernateRepository<Guid, ReleaseNote>, IReleaseNoteRepository
    {
        [Inject]
        public ReleaseNoteRepository(ISession session) : base(session){ }

        #region IReleaseNoteRepository Members
        public List<ReleaseNote> SearchReleases(string number, DateTime date, string railcar, string certificate, string reciver)
        {
            ReleaseNote note = null;
            Railcar car = null;

            var s = session.QueryOver<ReleaseNote>(() => note)
                .JoinAlias(() => note.Railcars, () => car);
                
            if(!string.IsNullOrWhiteSpace(railcar))
            {
                s.WhereRestrictionOn(() => car.Number).IsLike(railcar, MatchMode.Anywhere);
            }
            if(!string.IsNullOrWhiteSpace(number))
            {
                s.WhereRestrictionOn(x => x.Number).IsLike(number, MatchMode.Anywhere);
            }
            if(!string.IsNullOrWhiteSpace(certificate))
            {
                s.WhereRestrictionOn(() => car.Certificate).IsLike(certificate, MatchMode.Anywhere);
            }
            if(!string.IsNullOrWhiteSpace(reciver))
            {
                s.WhereRestrictionOn(() => car.Destination).IsLike(reciver, MatchMode.Anywhere);
            }
            if(date != DateTime.MinValue)
            {
                s.Where(x => x.Date == date);
            }


            var list = new List<ReleaseNote>(s.List<ReleaseNote>());
                
            return list;
        }
        #endregion
    }
}
