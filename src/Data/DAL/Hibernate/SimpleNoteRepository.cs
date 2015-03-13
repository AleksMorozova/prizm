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
                IList<SimplePipe> pipeList = new List<SimplePipe>();
                SimpleNote note = null;
                SimpleRailcar car = null;
                SimplePipe pipe = null;

                var s = session.QueryOver<SimpleNote>(() => note)
                .Where(n => ((n.Id == Id)))
                .JoinAlias(() => note.Railcars, () => car, JoinType.LeftOuterJoin)
                .JoinAlias(() => car.Pipes, () => pipe, JoinType.LeftOuterJoin)
                    .TransformUsing(Transformers.DistinctRootEntity);

                var listReleaseNote = new List<SimpleNote>(s.List<SimpleNote>());
                foreach(SimpleNote n in listReleaseNote)
                {
                    foreach(SimpleRailcar r in n.Railcars)
                    {
                        foreach(SimplePipe p in r.Pipes)
                        {
                            pipeList.Add(p);
                        }
                    }
                }

                return pipeList;

            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("Get pipes from Release note", ex);
            }

        }
        #region IReleaseNoteRepository Members

        public List<SimpleNote> SearchReleases(string number, DateTime startDate, DateTime endDate)
        {
            SimpleNote note = null;
            SimpleRailcar car = null;

            var s = session.QueryOver<SimpleNote>(() => note)
                .JoinAlias(() => note.Railcars, () => car, JoinType.LeftOuterJoin)
                .TransformUsing(Transformers.DistinctRootEntity);

            if (!string.IsNullOrWhiteSpace(number))
            {
                s.WhereRestrictionOn(x => x.Number).IsInsensitiveLike(number, MatchMode.Anywhere);
            }
            
            if (startDate != DateTime.MinValue && endDate != DateTime.MinValue)
            {
                s.WhereRestrictionOn(x => x.Date).IsBetween(startDate).And(endDate.AddHours(23).AddMinutes(59).AddSeconds(59));
            }
            var list = new List<SimpleNote>(s.List<SimpleNote>().OrderBy(x => x.Number));

            return list;
        }

        public List<SimpleNote> SearchReleasesByRailcar(string number, DateTime startDate, DateTime endDate, 
            string railcar,  string certificate, string reciver)
        {
            SimpleNote note = null;
            SimpleRailcar car = null;

            var s = session.QueryOver<SimpleNote>(() => note)
                .JoinAlias(() => note.Railcars, () => car, JoinType.LeftOuterJoin)
                .TransformUsing(Transformers.DistinctRootEntity);

            if (!string.IsNullOrWhiteSpace(railcar))
            {
                s.WhereRestrictionOn(() => car.Number).IsInsensitiveLike(railcar, MatchMode.Anywhere);
            }

            if (!string.IsNullOrWhiteSpace(number))
            {
                s.WhereRestrictionOn(x => x.Number).IsInsensitiveLike(number, MatchMode.Anywhere);
            }

            if (!string.IsNullOrWhiteSpace(certificate))
            {
                s.WhereRestrictionOn(() => car.Certificate).IsInsensitiveLike(certificate, MatchMode.Anywhere);
            }

            if (!string.IsNullOrWhiteSpace(reciver))
            {
                s.WhereRestrictionOn(() => car.Destination).IsInsensitiveLike(reciver, MatchMode.Anywhere);
            }

            if (startDate != DateTime.MinValue && endDate != DateTime.MinValue)
            {
                s.WhereRestrictionOn(x => x.Date).IsBetween(startDate).And(endDate.AddHours(23).AddMinutes(59).AddSeconds(59));
            }
            var list = new List<SimpleNote>(s.List<SimpleNote>().OrderBy(x => x.Number));

            return list;
        }

        public List<SimpleNote> SearchReleasesAllCreteria(string number, DateTime startDate, DateTime endDate, string pipeNumber, string railcar, string certificate, string reciver)
        {
            SimpleNote note = null;
            SimpleRailcar car = null;
            SimplePipe pipe = null;

            var s = session.QueryOver<SimpleNote>(() => note)
                .JoinAlias(() => note.Railcars, () => car, JoinType.LeftOuterJoin)
                .JoinAlias(() => car.Pipes, () => pipe, JoinType.LeftOuterJoin)
                .TransformUsing(Transformers.DistinctRootEntity);

            if (!string.IsNullOrWhiteSpace(pipeNumber))
            {
                s.WhereRestrictionOn(() => pipe.Number).IsInsensitiveLike(pipeNumber, MatchMode.Anywhere);
            }

            if (!string.IsNullOrWhiteSpace(railcar))
            {
                s.WhereRestrictionOn(() => car.Number).IsInsensitiveLike(railcar, MatchMode.Anywhere);
            }
            if (!string.IsNullOrWhiteSpace(number))
            {
                s.WhereRestrictionOn(x => x.Number).IsInsensitiveLike(number, MatchMode.Anywhere);
            }
            if (!string.IsNullOrWhiteSpace(certificate))
            {
                s.WhereRestrictionOn(() => car.Certificate).IsInsensitiveLike(certificate, MatchMode.Anywhere);
            }
            if (!string.IsNullOrWhiteSpace(reciver))
            {
                s.WhereRestrictionOn(() => car.Destination).IsInsensitiveLike(reciver, MatchMode.Anywhere);
            }
            if (startDate != DateTime.MinValue && endDate != DateTime.MinValue)
            {
                s.WhereRestrictionOn(x => x.Date).IsBetween(startDate).And(endDate.AddHours(23).AddMinutes(59).AddSeconds(59));
            }
            var list = new List<SimpleNote>(s.List<SimpleNote>().OrderBy(x => x.Number));

            return list;
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
