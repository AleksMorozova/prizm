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
using Prizm.Domain.Entity;

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
            catch(GenericADOException ex)
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
            catch(GenericADOException ex)
            {
                throw new RepositoryException("GetJointsToExport", ex);
            }
        }

        public IList<Joint> QuickSearchByNumber(string number)
        {
            try
            {
                ICriteria crit = session.CreateCriteria<Joint>().Add(Restrictions.Like("Number", number, MatchMode.Start))
                    .SetProjection(Projections.ProjectionList()
                                 .Add(Projections.Property("Id"), "Id")
                                 .Add(Projections.Property("Number"), "Number"))
                                 .SetResultTransformer(Transformers.AliasToBean<Joint>());
                IList<Joint> results = crit.List<Joint>();
                return results;
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("GetJointsToExport", ex);
            }
        }

        public IList<Joint> SearchJoint(string jointNumber,
            IList<JointStatus> statuses,
            DateTime? from, DateTime? to,
            string peg,
            bool? status,
            Domain.Entity.Setup.WorkstationType currentWorkstation)
        {
            try{
            var q = session.QueryOver<Joint>();
            // joint number
            if(!string.IsNullOrWhiteSpace(jointNumber))
            {
                q.WhereRestrictionOn(n => n.Number).IsLike(jointNumber, MatchMode.Start);
            }
            // statuses
            if(statuses != null)
            {
                q.WhereRestrictionOn(x => x.Status).IsIn(statuses.ToArray());
            }
            // status
            if(status != null)
            {
                q.Where(x => x.IsActive == status);
            }
            //peg
            if(!string.IsNullOrWhiteSpace(peg))
            {
                int number = Convert.ToInt32(peg);
                q.Where(x => x.NumberKP == number);
            }

            IList<Joint> res;
            if(currentWorkstation == Domain.Entity.Setup.WorkstationType.Master)
            {
                res = q.List<Joint>();
            }
            else
            {
                var jointWithWeld = QueryOver.Of<Joint>()
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

                q.WithSubquery
               .WhereProperty(j => j.JointWeldResults)
               .In(jointWithWeld);
                res = q.List<Joint>();
            }

            return res.OrderBy(_ => _.Number).ToList<Joint>();
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("GetJointsToExport", ex);
            }
        }


        public IList<Joint> GetJointsForTracing()
        {
            try
            {
                JointWeldResult weldResult = null;
                JointTestResult testResult = null;
                List<Welder> welders = null;

                return
                    session.QueryOver<Joint>()
                    .Where(x => x.IsActive == true && x.FirstElement != null && x.SecondElement != null && x.Status != JointStatus.Withdrawn)
                    .JoinAlias(j => j.JointWeldResults, () => weldResult, JoinType.LeftOuterJoin)
                    .JoinAlias(() => weldResult.Welders, () => welders, JoinType.LeftOuterJoin)
                    .JoinAlias(j => j.JointTestResults, () => testResult, JoinType.LeftOuterJoin)
                    .TransformUsing(Transformers.DistinctRootEntity)
                    .List<Joint>();
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("GetJointsForTracing", ex);
            }
        }

        public ICriteria GetJointsProjections()
        {
            try
            {
                return
                    session.CreateCriteria<Joint>()
                    .Add(Restrictions.Eq("IsActive", true))
                    .Add(Restrictions.IsNotNull("FirstElement"))
                    .Add(Restrictions.IsNotNull("SecondElement"))
                    .Add(Restrictions.Not(Restrictions.Eq("Status", JointStatus.Withdrawn)))
                    .AddOrder(Order.Asc("Number"))
                    .SetProjection(Projections.ProjectionList()
                        .Add(Projections.Property<Joint>(x => x.Number), "Number")
                        .Add(Projections.Property<Joint>(x => x.Id), "Id")
                        .Add(Projections.Property<Joint>(x => x.NumberKP), "NumberKP")
                     );
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("GetJointsForTracing", ex);
            }
        }


        public bool PartIsWeldedIntoJoint(Guid partId)
        {
            try
            {
                return session.QueryOver<Joint>().Where(_ => (_.FirstElement.Id == partId || _.SecondElement.Id == partId) && _.IsActive).RowCount() > 0;
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("PartIsWeldedIntoJoint", ex);
            }
        }
        #endregion
    }
}
