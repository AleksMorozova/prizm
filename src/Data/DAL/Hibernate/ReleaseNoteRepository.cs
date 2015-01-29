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
                IList<Pipe> pipeList = new List<Pipe>();
                ReleaseNote note = null;
                Railcar car = null;
                Pipe pipe = null;

                var s = session.QueryOver<ReleaseNote>(() => note)
                    .Where(n => ((n.Id==Id)))
                    .JoinAlias(() => note.Railcars, () => car)
                    .JoinAlias(() => car.Pipes, () => pipe)
                    .TransformUsing(Transformers.DistinctRootEntity);

                var listReleaseNote = new List<ReleaseNote>(s.List<ReleaseNote>());
                foreach (ReleaseNote n in listReleaseNote) 
                {
                    foreach(Prizm.Domain.Entity.Mill.Railcar r in n.Railcars)
                    {
                        foreach (Pipe p in r.Pipes) 
                        {
                            pipeList.Add(p);
                        }
                    }
                }

                return pipeList;

            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Get pipes from Release note", ex);
            }

        }
        #region IReleaseNoteRepository Members
        public List<ReleaseNote> SearchReleases(string number, DateTime date, string railcar, string certificate, string reciver)
        {
            ReleaseNote note = null;
            Railcar car = null;
            Pipe pipe = null;

            var s = session.QueryOver<ReleaseNote>(() => note)
                .JoinAlias(() => note.Railcars, () => car)
                .JoinAlias(() => car.Pipes, () => pipe)
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
