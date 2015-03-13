using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.SimpleReleaseNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mill
{
    public interface ISimpleNoteRepository : IRepository<Guid, SimpleNote>
    {
        List<SimpleNote> SearchReleasesByRailcar(string number, DateTime startDate, DateTime endDate, string railcar, string certificate, string reciver);
        List<SimpleNote> SearchReleases(string number, DateTime startDate, DateTime endDate);
        List<SimpleNote> SearchReleasesAllCreteria(string number, DateTime startDate, DateTime endDate, string pipeNumber, string railcar, string certificate, string reciver);
        IList<SimplePipe> GetReleasedNotePipe(Guid Id);


        void SaveOrUpdatePipe(SimplePipe pipe);

        IList<SimplePipe> GetStoredPipes();
    }
}
