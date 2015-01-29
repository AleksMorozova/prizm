using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mill
{
    public interface IReleaseNoteRepository : IRepository<Guid, ReleaseNote>
    {
        List<ReleaseNote> SearchReleases(string number, DateTime date, string railcar, string certificate, string reciver);
        IList<Pipe> GetReleasedNotePipe(Guid Id);
    }
}
