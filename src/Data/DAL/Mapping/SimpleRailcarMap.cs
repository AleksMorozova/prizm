using Prizm.Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using Prizm.Domain.Entity.SimpleReleaseNote;

namespace Prizm.Data.DAL.Mapping
{
    public class SimpleRailcarMap : SubclassMap<SimpleRailcar>
    {
        public SimpleRailcarMap()
        {
            Table("Railcar");
            Map(x => x.Number).Column("number");
            Map(_ => _.Destination, "destination");
            Map(_ => _.Certificate, "certificate");
            Map(_ => _.IsShipped, "isShipped");
            HasMany(_ => _.Pipes).KeyColumn("railcarId").Cascade.SaveUpdate();
            References<SimpleNote>(x => x.ReleaseNote).Column("releaseNoteId").Cascade.SaveUpdate();
        }
    }
}