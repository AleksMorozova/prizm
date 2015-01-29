using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using NHibernate.Linq;
using Ninject;
using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity;
using NHibernate.Exceptions;
using NHibernate.SqlCommand;

namespace Prizm.Data.DAL.Hibernate
{
    public class ReleaseNoteRepository : AbstractHibernateRepository<Guid, ReleaseNote>, IReleaseNoteRepository
    {
        [Inject]
        public ReleaseNoteRepository(ISession session) : base(session) { }
        public IList<Pipe> GetReleasedNotePipe(Guid Id)
        {
            try
            {
                PipeTestResult result = null;
                Inspector inspector = null;
                Certificate certificate = null;

                var q = session.QueryOver<Pipe>()
                    .Where(n => ((n.Railcar.ReleaseNote.Id==Id)))
                    .JoinAlias(r => r.PipeTestResult, () => result, JoinType.LeftOuterJoin)
                    .JoinAlias(() => result.Inspectors, () => inspector, JoinType.LeftOuterJoin)
                    .JoinAlias(() => inspector.Certificates, () => certificate, JoinType.LeftOuterJoin)
                    .TransformUsing(Transformers.DistinctRootEntity)
                    .List<Pipe>();

                return q;

            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetStored", ex);
            }

        }
        #region IReleaseNoteRepository Members
        public List<ReleaseNote> SearchReleases(string number, DateTime date, string railcar, string certificate, string reciver)
        {
            ReleaseNote note = null;
            Railcar car = null;

            var s = session.QueryOver<ReleaseNote>(() => note)
                .JoinAlias(() => note.Railcars, () => car)
                .TransformUsing(Transformers.DistinctRootEntity);

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
