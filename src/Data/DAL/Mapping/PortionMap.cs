using FluentNHibernate.Mapping;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
   public class PortionMap : ClassMap<Portion>
   {
      public PortionMap()
      {
         Id(_ => _.Id).Column("Id").UnsavedValue(Guid.Empty).GeneratedBy.Assigned();
         Map(_ => _.ExportDateTime).Column("ExportDateTime");
         Map(_ => _.IsExport).Column("isExport");
         Map(_ => _.PortionNumber).Column("portionNumber");

         HasManyToMany<Pipe>(_ => _.Pipes)
            .Table("Portion_Pipe")
            .ParentKeyColumn("portionId")
            .ChildKeyColumn("pipeId").Not.LazyLoad();

         References<Project>(_ => _.Project).Column("projectId");

         HasManyToMany<Joint>(_ => _.Joints)
            .Table("Portion_Joint")
            .ParentKeyColumn("portionId")
            .ChildKeyColumn("jointId").Not.LazyLoad();
         HasManyToMany<Component>(_ => _.Components)
            .Table("Portion_Component")
            .ParentKeyColumn("portionId")
            .ChildKeyColumn("componentId").Not.LazyLoad();
      }
   }
}
