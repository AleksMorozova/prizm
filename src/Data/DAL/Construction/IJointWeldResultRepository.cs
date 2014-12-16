using Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Construction
{
    public interface IJointWeldResultRepository : IRepository <Guid, JointWeldResult>
    {
        IList<JointWeldResult> GetByJoint(Joint joint);
    }
}
