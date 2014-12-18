using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class JointTestResultMap : SubclassMap<JointTestResult>
    {
        public JointTestResultMap()
        {
            Map(x => x.Date).Column("date");
            Map(x => x.Value).Column("value");
            Map(x => x.Status).Column("status");
            Map(x => x.Order).Column("[order]");

            References<JointOperation>(_ => _.Operation).Column("jointOperationId");
            References<Joint>(_ => _.Joint).Column("jointId");

            HasManyToMany(_ => _.Inspectors)
                    .Table("[TestResult_Inspector]")
                    .ParentKeyColumn("resultId")
                    .ChildKeyColumn("inspectorId")
                    .Cascade.SaveUpdate().Not.LazyLoad();
        }
    }
}
