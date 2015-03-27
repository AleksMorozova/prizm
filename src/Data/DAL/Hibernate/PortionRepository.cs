using NHibernate;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using NHibernate.Transform;
using Ninject;
using Prizm.Data.DAL.Synch;
using Prizm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
   public class PortionRepository : AbstractHibernateRepository<Guid, Portion>, IPortionRepository
   {
      [Inject]
      public PortionRepository(ISession session) : base(session)
      {
      }
      public int GetPortionNumber(Project currentProject)
      {      
          var maxIndex = session.QueryOver<Portion>()
              .Where(x => x.IsExport == true)
              .Where(x => x.Project == currentProject)
              .Select
              (
              Projections.Max<Portion>(x => x.PortionNumber)
              ).SingleOrDefault<int>();
          return maxIndex + 1;

      }

      public List<int> CheckPortionSequence(Project importProject)
      {        
          IList<int> result = session.QueryOver<Portion>().Where(_ => _.IsExport == false && _.Project == importProject)
                                                                 .Select(_ => _.PortionNumber).List<int>();
          List<int> sorted =  new List<int>(result);
          sorted.Sort();

          return (result.Count == 0) ? new List<int>() { 0 } : sorted;
 
      }

      public override IList<Portion> GetAll()
      {
          try
          {
              var q = session.QueryOver<Portion>()
                  .Select
                  (
                    p => p.Id,
                    p => p.ExportDateTime,
                    p => p.IsExport,
                    p => p.Project,
                    p => p.PortionNumber
                  )
                  .TransformUsing(Transformers.AliasToBean<Portion>())
                  .List<Portion>();
              return q;
              //return session.CreateCriteria<Portion>().List<Portion>();
          }
          catch(GenericADOException ex)
          {
              throw new RepositoryException("GetAll", ex);
          }
      }
   }
}
