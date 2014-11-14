using Data.DAL.Mill;
using Domain.Entity.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
{
    public class PipeRepository : AbstractHibernateRepository<Guid, Pipe>, IPipeRepository
    {
        [Inject]
        public PipeRepository(ISession session)
            : base(session)
        {

        }

        public Pipe GetByNumber(string number)
        {
            return session.QueryOver<Pipe>().Where(n => n.Number == number).SingleOrDefault();
        }

        public new void Save(Pipe pipe)
        {
            if (pipe.Plate.Heat == null)
            {
                session.Save(pipe.Plate.Heat);
            }
            if (pipe.Plate == null)
            {
                session.Save(pipe.Plate);
            }
            session.Save(pipe);
        }
    }
}
