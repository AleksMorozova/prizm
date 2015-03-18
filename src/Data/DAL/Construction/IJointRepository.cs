using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Construction
{
    public interface IJointRepository : IRepository<Guid, Joint>
    {
        IList<Joint> GetActiveByNumber(Joint joint);
        IList<Joint> GetJointsToExport();

        IList<Joint> SearchJoint(
            string jointNumber, 
            IList<JointStatus> statuses, 
            DateTime? from, 
            DateTime? to,
            string peg, 
            bool? status);
    }
}
