using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;
using NHibernate;
using NHibernate.Exceptions;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace Prizm.Data.DAL.Hibernate
{
    public class JointRepository : AbstractHibernateRepository<Guid, Joint>, IJointRepository
    {
        [Inject]
        public JointRepository(ISession session)
            : base(session)
        {
        }
        
        #region IJointRepository Members
        
        public IList<Joint> GetActiveByNumber(Joint joint)
        {
            try
            {
                return session.QueryOver<Joint>().Where(_ => _.IsActive == true && _.Id != joint.Id && _.Number == joint.Number).List<Joint>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetActiveByNumber", ex);
            }
        }

        public IList<Joint> GetJointsToExport()
        {
           try
           {
              return session.QueryOver<Joint>().Where(_ => _.ToExport).List<Joint>();
           }
           catch (GenericADOException ex)
           {
              throw new RepositoryException("GetJointsToExport", ex);
           }
        }

        public IList<Joint> SearchJoint(string jointNumber, IList<JointStatus> statuses, DateTime? from, DateTime? to, int peg, bool? status)
        {

            var jointWithWeld = QueryOver.Of<Joint>()
                .Fetch(x => x.JointTestResults).Eager
                .JoinQueryOver<JointWeldResult>(j => j.JointWeldResults)
                .Select(Projections.Distinct(Projections.Property<Joint>(j => j.JointWeldResults)));
            if(from != null && from != DateTime.MinValue)
            {
                jointWithWeld.Where(f => f.Date >= from);
            }
            if(to != null && to != DateTime.MinValue)
            {
                jointWithWeld.Where(t => t.Date <= to);
            }

            
            var q = session.QueryOver<Joint>();
            // joint number
            if(!string.IsNullOrWhiteSpace(jointNumber))
            {
                q.WhereRestrictionOn(n => n.Number).IsLike(jointNumber, MatchMode.Start);
            }
            // statuses
            q.WhereRestrictionOn(x => x.Status).IsIn(statuses.ToArray());
            // status
            if(status != null)
            {
                q.Where(x => x.IsActive == status);
            }

            
            q.WithSubquery
                .WhereProperty(j => j.JointWeldResults)
                .In(jointWithWeld);


            return q.List<Joint>();
        }

        #endregion
    }
}
