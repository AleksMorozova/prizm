using Data.DAL.Construction;
using Data.DAL.Hibernate;
using Data.DAL.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Component
{
    public class ComponentRepositories : IComponentRepositories
    {
        ISession session;
        private readonly IComponentRepository componentRepo;
        private readonly IComponentTypeRepository componentTypeRepo;
        private readonly IInspectorRepository repoInspector;

        [Inject]
        public ComponentRepositories(ISession session)
        {
            this.session = session;
            this.componentRepo = new ComponentRepository(session);
            this.componentTypeRepo = new ComponentTypeRepository(session);
            this.repoInspector = new InspectorRepository(session);
        }

        public IComponentRepository ComponentRepo
        {
            get { return componentRepo; }
        }

        public IComponentTypeRepository ComponentTypeRepo
        {
            get { return componentTypeRepo; }
        }

        public IInspectorRepository RepoInspector
        {
            get { return repoInspector; }
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
    }
}
