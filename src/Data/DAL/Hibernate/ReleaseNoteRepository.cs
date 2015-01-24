using NHibernate;
using Ninject;
using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class ReleaseNoteRepository : AbstractHibernateRepository<Guid, ReleaseNote>, IReleaseNoteRepository
    {
        [Inject]
        public ReleaseNoteRepository(ISession session) : base(session){ }

        #region IReleaseNoteRepository Members
        public List<ReleaseNote> SearchReleases(string number, DateTime date, string railcar, string certificate, string reciver)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
