using System;
using Data.DAL.Mill;
using Domain.Entity.Mill;
using NHibernate;
using Ninject;
using NHibernate.Exceptions;

namespace Data.DAL.Hibernate
{
    public class RailcarRepository : AbstractHibernateRepository<Guid, Railcar>, IRailcarRepository
    {
        [Inject]
        public RailcarRepository(ISession session)
            : base(session)
        {
        }

        public Railcar GetByNumber(string number)
        {
            try
            {
                return session.QueryOver<Railcar>().Where(n => n.Number == number).SingleOrDefault();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetByNumber", ex);
            }
        }

        public new void SaveOrUpdate(Railcar car)
        {
            try
            {
                session.SaveOrUpdate(car);
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("SaveOrUpdate", ex);
            }
        }
    }
}