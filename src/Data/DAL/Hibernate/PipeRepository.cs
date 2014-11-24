using Data.DAL.Mill;
using Domain.Entity;
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

        // TODO: now pipeMillStatus - string, sometime it will be 
        // converted to type and condition must be changed
         public IList<Pipe> GetStored()
         {
             return session.QueryOver<Pipe>()
                 .Where(n => n.Status == PipeMillStatus.Stocked).List<Pipe>();
         }
    }
}
