using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using NHibernate;
using NHibernate.Exceptions;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class SpoolRepository : AbstractHibernateRepository<Guid, Spool>, ISpoolRepository
    {
        [Inject]
        public SpoolRepository(ISession session)
            : base(session)
        {

        }

        public IList<Spool> GetAllSpoolFromPipe(string number)
        {
            try
            {
                return session
                    .QueryOver<Spool>()
                    .Where(x => x.PipeNumber == number)
                    .List<Spool>(); //.Count;
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("Get", ex);
            }
        }
    }
}
