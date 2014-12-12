using Data.DAL.Construction;
using Data.DAL.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Joint
{
    public interface IConstructionRepository : IDisposable
    {
        IJointRepository RepoJoint { get; }
        IJointActionResultRepository RepoJointActionResult { get; }
        IJointOperationRepository RepoJointOperation { get; }

        void Commit();
        void BeginTransaction();
    }
}
