﻿using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mill
{
    public interface IReleaseNoteRepository : IRepository<Guid, ReleaseNote>
    {
        List<ReleaseNote> SearchReleasesByRailcar(string number, DateTime startDate, DateTime endDate, string railcar, string certificate, string reciver);
        List<ReleaseNote> SearchReleases(string number, DateTime startDate, DateTime endDate);
        List<ReleaseNote> SearchReleasesAllCreteria(string number, DateTime startDate, DateTime endDate, string pipeNumber, string railcar, string certificate, string reciver);
        IList<Pipe> GetReleasedNotePipe(Guid Id);
    }
}
