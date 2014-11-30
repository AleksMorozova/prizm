using Data.DAL.Setup;
using Domain.Entity.Setup;
using NHibernate;
using NHibernate.Exceptions;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
{
    public class PipeTestRepository : AbstractHibernateRepository<Guid, PipeTest>, IPipeTestRepository
    {
        [Inject]
        public PipeTestRepository(ISession session)
            : base(session)
        {
        }

        public IList<PipeTest> GetByMillSizeType(PipeMillSizeType pipeType)
        {
            try
            {
                return session.QueryOver<PipeTest>().Where(n => n.pipeType == pipeType).List<PipeTest>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetByMillSizeType", ex);
            }
        }
    }
}
