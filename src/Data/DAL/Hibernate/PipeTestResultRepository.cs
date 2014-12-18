using System;
using Prizm.Domain.Entity.Mill;
using Prizm.Data.DAL.Mill;
using NHibernate;
using Ninject;

namespace Prizm.Data.DAL.Hibernate
{
    public class PipeTestResultRepository : AbstractHibernateRepository<Guid, PipeTestResult>, IPipeTestResultRepository
    {
        [Inject]
        public PipeTestResultRepository(ISession session)
            : base(session)
        { }
    }
}
