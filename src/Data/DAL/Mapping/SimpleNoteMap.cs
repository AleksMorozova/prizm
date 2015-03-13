using FluentNHibernate.Mapping;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.SimpleReleaseNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    class SimpleNoteMap : SubclassMap<SimpleNote>
    {
        public SimpleNoteMap()
        {
            Table("ReleaseNote");
            Map(_ => _.Number).Column("number");
            Map(_ => _.Date).Column("date");
            Map(x => x.Shipped).Column("Shipped");
            HasMany(_ => _.Railcars).KeyColumn("releaseNoteId").Cascade.SaveUpdate().Not.LazyLoad();//.Inverse()
            HasMany<File>(x => x.Attachments).KeyColumn("item").Inverse().LazyLoad();
        }

    }
}
