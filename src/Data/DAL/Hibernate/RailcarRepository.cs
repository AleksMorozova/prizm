using System;
using Data.DAL.Mill;
using Domain.Entity.Mill;
using NHibernate;
using Ninject;

namespace Data.DAL.Hibernate
{
    public class RailcarRepository : AbstractHibernateRepository<Guid, Railcar>, IRailcarRepository
    {
        [Inject]
        public RailcarRepository(ISession session)
            : base(session)
        {
        }
    }
}