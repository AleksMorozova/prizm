using Domain.Entity.Construction;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class JointWeldResultMap : SubclassMap<JointWeldResult>
    {
        public JointWeldResultMap()
        {
            HasManyToMany(_ => _.Welders)
            .Table("[WeldResult_Welder]")
            .ParentKeyColumn("resultId")
            .ChildKeyColumn("welderId")
            .Cascade.SaveUpdate().Not.LazyLoad();
        }
    }
}
