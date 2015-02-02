using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Setup
{
    public interface IJointOperationRepository : IRepository<Guid, JointOperation>
    {
       IList<JointOperation> GetControlOperations();
       IList<JointOperation> GetRepairOperations();
       void SeedRequiredWeld(string requiredWeld);
       JointOperation GetRequiredWeld();
    }
}
