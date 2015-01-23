using FluentNHibernate.Mapping;
using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    class ReleaseNoteMap : SubclassMap<ReleaseNote>
    {
        public ReleaseNoteMap()
        {
            Table("ReleaseNote");
            Map(_ => _.Number, "releaseNoteNumber");
            Map(_ => _.Date, "releaseNoteDate");
            HasMany(_ => _.Railcars).KeyColumn("releaseNoteId");
        }
    }
}
