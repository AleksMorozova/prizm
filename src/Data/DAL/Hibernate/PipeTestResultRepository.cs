using System;
using Domain.Entity.Mill;
using Data.DAL.Mill;
using NHibernate;
using Ninject;

namespace Data.DAL.Hibernate
{
    public class PipeTestResultRepository : AbstractHibernateRepository<Guid, PipeTestResult>, IPipeTestResultRepository
    {
        [Inject]
        public PipeTestResultRepository(ISession session)
            : base(session)
        { }
    }
}
