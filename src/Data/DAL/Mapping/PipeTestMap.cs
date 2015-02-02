using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class PipeTestMap : SubclassMap<PipeTest>
    {
        public PipeTestMap() 
        {
            Map(_ => _.Code, "code");
            Map(_ => _.Name, "name");
            Map(_ => _.ControlType, "controlType");       
            Map(_ => _.ResultType, "resultType");
            Map(_ => _.MinExpected, "minExpected");
            Map(_ => _.MaxExpected, "maxExpected");
            Map(_ => _.BoolExpected, "boolExpected");
            Map(_ => _.IsRequired, "isRequired");
            Component<PipeTestFrequency>(x => x.Frequency, m =>
            {
                m.Map(x => x.Quantaty).Column("frequency");
                m.Map(x => x.Measure).Column("frequencyMeasure");
            });

            References<Category>(x => x.Category).Column("categoryId").Cascade.All();

            References(_ => _.pipeType).Column("pipeMillSizeTypeId");
            HasMany(_ => _.PipeTestResults).KeyColumn("pipeTestId").Inverse();
        }
    }
}
