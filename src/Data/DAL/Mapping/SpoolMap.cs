using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity;

namespace Prizm.Data.DAL.Mapping
{
    public class SpoolMap: SubclassMap<Spool>
    {
        public SpoolMap()
        {
            Map(_ => _.PipeNumber).Column("pipeNumber");
            HasMany<InspectionTestResult>(_ => _.InspectionTestResults).KeyColumn("partId").Cascade.All().Not.LazyLoad();
            References<Pipe>(x => x.Pipe).Column("pipeId");

            HasMany<File>(_ => _.Attachments).KeyColumn("item").Inverse().LazyLoad();
        }
    }
}
