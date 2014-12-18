using Prizm.Domain.Entity.Construction;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class InspectionTestResultMap: SubclassMap<InspectionTestResult>
    {
        public InspectionTestResultMap()
        {
            Map(x => x.Date).Column("inspectionDate");
            Map(x => x.Value).Column("value");
            Map(x => x.Status).Column("status");
            Map(x => x.Order).Column("[order]");

            HasManyToMany(_ => _.Inspectors)
                    .Table("[TestResult_Inspector]")
                    .ParentKeyColumn("resultId")
                    .ChildKeyColumn("inspectorId")
                    .Cascade.SaveUpdate()
                    .Not.LazyLoad();
        }
    }
}
