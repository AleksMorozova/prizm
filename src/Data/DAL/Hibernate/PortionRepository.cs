using NHibernate;
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
          IList<Portion> portionList =  session.QueryOver<Portion>().Where(_ => _.IsExport == true && _.Project == currentProject).List<Portion>();
          return (portionList.Count == 0) ? 0 : portionList.Max(_ => _.PortionNumber) + 1;
      }

      public IList<int> CheckPortionSequence(Project importProject)
      {
         return session.QueryOver<Portion>().Where(_ => _.IsExport == false && _.Project == importProject)
                                                                        .Select(_ => _.PortionNumber).List<int>();

      }
   }
}
