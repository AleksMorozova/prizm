using Data.DAL.Construction;
using Data.DAL.Hibernate;
using Data.DAL.Mill;
using Data.DAL.Setup;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Joint
{
    public class ConstructionRepository : IConstructionRepository
    {
        private readonly IJointRepository repoJoint;
        private readonly IJointActionResultRepository repoJointActionResult;
        private readonly IJointOperationRepository repoJointOperation;
        private readonly IInspectorRepository repoInspector;

        private readonly ISession session;

        [Inject]
        public ConstructionRepository(ISession session)
        {
            this.session = session;
            this.repoJoint = new JointRepository(session);
            this.repoJointActionResult = new JointActionResultRepository(session);
            this.repoJointOperation = new JointOperationRepository(session);
            this.repoInspector = new InspectorRepository(session);
        }
        public void Commit()
        {
            session.Transaction.Commit();
        }

        public void BeginTransaction()
        {
            session.BeginTransaction();
        }

        public void Dispose()
        {
            session.Dispose();
        }

        public IJointRepository RepoJoint
        {
            get { return repoJoint; }
        }

        public IJointActionResultRepository RepoJointActionResult
        {
            get { return repoJointActionResult; }
        }

        public IJointOperationRepository RepoJointOperation
        {
            get { return repoJointOperation; }
        }

        public IInspectorRepository RepoInspector
        {
            get { return repoInspector; }
        }
    }
}
