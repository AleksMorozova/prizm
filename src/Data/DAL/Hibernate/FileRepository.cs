using Domain.Entity;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
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
