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
using Prizm.Domain.Entity.SimpleReleaseNote;

namespace Prizm.Data.DAL.Hibernate
{
    public class SimpleNoteRepository : AbstractHibernateRepository<Guid, SimpleNote>, ISimpleNoteRepository
    {
        [Inject]
        public SimpleNoteRepository(ISession session) : base(session) { }

        public IList<SimplePipe> GetReleasedNotePipe(Guid Id)
        {
            try
            {
                var q = session.CreateCriteria<SimplePipe>()
                    .CreateCriteria("Railcar")
                    .CreateCriteria("ReleaseNote")
                    .Add(Restrictions.Eq("Id", Id))
                    .List<SimplePipe>();

                return q;
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("Get pipes from Release note", ex);
            }

        }
        #region IReleaseNoteRepository Members

        public List<SimpleNote> SearchReleases(string number, DateTime startDate, DateTime endDate)
        {
            try
            {
                SimpleNote note = null;
                SimpleRailcar car = null;

                var s = session.QueryOver<SimpleNote>(() => note)
                    .JoinAlias(() => note.Railcars, () => car, JoinType.LeftOuterJoin)
                    .TransformUsing(Transformers.DistinctRootEntity);

                if(!string.IsNullOrWhiteSpace(number))
                {
                    s.WhereRestrictionOn(x => x.Number).IsInsensitiveLike(number, MatchMode.Start);
                }

                if(startDate != DateTime.MinValue && endDate != DateTime.MinValue)
                {
                    s.WhereRestrictionOn(x => x.Date).IsBetween(startDate).And(endDate.AddHours(23).AddMinutes(59).AddSeconds(59));
                }
                var list = new List<SimpleNote>(s.List<SimpleNote>().OrderBy(x => x.Number));

                return list;
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("SearchReleases", ex);
            }
        }

        public List<SimpleNote> SearchReleasesByRailcar(string number, DateTime startDate, DateTime endDate,
            string railcar, string certificate, string reciver)
        {
            try
            {
                SimpleNote note = null;
                SimpleRailcar car = null;

                var s = session.QueryOver<SimpleNote>(() => note)
                    .JoinAlias(() => note.Railcars, () => car, JoinType.LeftOuterJoin)
                    .TransformUsing(Transformers.DistinctRootEntity);

                if(!string.IsNullOrWhiteSpace(railcar))
                {
                    s.WhereRestrictionOn(() => car.Number).IsInsensitiveLike(railcar, MatchMode.Start);
                }

                if(!string.IsNullOrWhiteSpace(number))
                {
                    s.WhereRestrictionOn(x => x.Number).IsInsensitiveLike(number, MatchMode.Start);
                }

                if(!string.IsNullOrWhiteSpace(certificate))
                {
                    s.WhereRestrictionOn(() => car.Certificate).IsInsensitiveLike(certificate, MatchMode.Start);
                }

                if(!string.IsNullOrWhiteSpace(reciver))
                {
                    s.WhereRestrictionOn(() => car.Destination).IsInsensitiveLike(reciver, MatchMode.Start);
                }

                if(startDate != DateTime.MinValue && endDate != DateTime.MinValue)
                {
                    s.WhereRestrictionOn(x => x.Date).IsBetween(startDate).And(endDate.AddHours(23).AddMinutes(59).AddSeconds(59));
                }
                var list = new List<SimpleNote>(s.List<SimpleNote>().OrderBy(x => x.Number));

                return list;
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("SearchReleasesByRailcar", ex);
            }
        }

        public List<SimpleNote> SearchReleasesAllCreteria(string number, DateTime startDate, DateTime endDate, string pipeNumber, string railcar, string certificate, string reciver)
        {
            try
            {
                SimpleNote note = null;
                SimpleRailcar car = null;
                SimplePipe pipe = null;

                var s = session.QueryOver<SimpleNote>(() => note)
                    .JoinAlias(() => note.Railcars, () => car, JoinType.LeftOuterJoin)
                    .JoinAlias(() => car.Pipes, () => pipe, JoinType.LeftOuterJoin)
                    .TransformUsing(Transformers.DistinctRootEntity);

                if(!string.IsNullOrWhiteSpace(pipeNumber))
                {
                    s.WhereRestrictionOn(() => pipe.Number).IsInsensitiveLike(pipeNumber, MatchMode.Start);
                }

                if(!string.IsNullOrWhiteSpace(railcar))
                {
                    s.WhereRestrictionOn(() => car.Number).IsInsensitiveLike(railcar, MatchMode.Start);
                }
                if(!string.IsNullOrWhiteSpace(number))
                {
                    s.WhereRestrictionOn(x => x.Number).IsInsensitiveLike(number, MatchMode.Start);
                }
                if(!string.IsNullOrWhiteSpace(certificate))
                {
                    s.WhereRestrictionOn(() => car.Certificate).IsInsensitiveLike(certificate, MatchMode.Start);
                }
                if(!string.IsNullOrWhiteSpace(reciver))
                {
                    s.WhereRestrictionOn(() => car.Destination).IsInsensitiveLike(reciver, MatchMode.Start);
                }
                if(startDate != DateTime.MinValue && endDate != DateTime.MinValue)
                {
                    s.WhereRestrictionOn(x => x.Date).IsBetween(startDate).And(endDate.AddHours(23).AddMinutes(59).AddSeconds(59));
                }
                var list = new List<SimpleNote>(s.List<SimpleNote>().OrderBy(x => x.Number));

                return list;
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("SearchReleasesAllCreteria", ex);
            }
        }

        #endregion

        #region ISimpleNoteRepository Members


        public void SaveOrUpdatePipe(SimplePipe pipe)
        {
            session.SaveOrUpdate(pipe);
        }
        #endregion

        public IList<SimplePipe> GetStoredPipes()
        {
            try
            {
                var q = session.QueryOver<SimplePipe>()
                    .Fetch(x => x.Type).Eager
                    .Fetch(x => x.Attachments).Eager
                    .Where(n => ((n.Status == PipeMillStatus.Stocked) && (n.IsActive == true) && n.Railcar == null))
                    .List<SimplePipe>();

                return q;

            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("GetStored", ex);
            }

        }
    }
}
