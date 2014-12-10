using Data.DAL.Construction;
using Data.DAL.Hibernate;
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

        private readonly ISession session;

        [Inject]
        public ConstructionRepository(ISession session)
        {
            this.session = session;
            this.repoJoint = new JointRepository(session);
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
    }
}
