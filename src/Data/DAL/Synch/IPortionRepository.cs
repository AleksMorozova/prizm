using Prizm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Synch
{
   public interface IPortionRepository : IRepository<Guid, Portion>
   {
       int GetPortionNumber(Project currentProject);
       List<int> CheckPortionSequence(Project importProject);
   }
}
