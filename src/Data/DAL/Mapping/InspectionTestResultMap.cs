using Prizm.Domain.Entity.Construction;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity;

namespace Prizm.Data.DAL.Mapping
{
    public class InspectionTestResultMap: SubclassMap<InspectionTestResult>
    {
        public InspectionTestResultMap()
        {
            Map(x => x.Date).Column("inspectionDate");
            Map(x => x.Value).Column("value");
            Map(x => x.Status).Column("status");
            References<Part>(_ => _.Part).Column("partId");

            HasManyToMany(_ => _.Inspectors)
                    .Table("[TestResult_Inspector]")
                    .ParentKeyColumn("resultId")
                    .ChildKeyColumn("inspectorId")
                    .Cascade.SaveUpdate()
                    .Not.LazyLoad();
        }
    }
}
