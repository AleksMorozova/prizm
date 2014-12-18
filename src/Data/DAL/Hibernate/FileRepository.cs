using Prizm.Domain.Entity;
using NHibernate;
using Ninject;
using Prizm.Data.DAL.Hibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL;

namespace Prizm.DAL.Hibernate
{
    public class FileRepository : AbstractHibernateRepository<Guid, File>, IFileRepository
    {
        [Inject]
        public FileRepository(ISession session)
            : base(session)
        {}

        public IList<File> GetByItem(Item item)
        {
            return session.QueryOver<File>().Where(_ => _.Item == item).List<File>();
        }
    }
}
