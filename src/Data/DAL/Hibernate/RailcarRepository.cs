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

        public Railcar GetByNumber(string number)
        {
            return session.QueryOver<Railcar>().Where(n => n.Number == number).SingleOrDefault();
        }

        public new void SaveOrUpdate(Railcar car)
        {
            //foreach (var pipe in car.Pipes)
            //{
            //    pipe.Railcar = car;
            //    session.Merge(pipe);
            //}
            session.SaveOrUpdate(car);
        }


    }
}