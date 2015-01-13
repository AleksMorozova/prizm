using FluentNHibernate.Mapping;
using Prizm.Domain.Entity;
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
         Id(_ => _.Id).Column("Id");
         Map(_ => _.ExportDateTime).Column("ExportDateTime");
         HasManyToMany<Pipe>(_ => _.Pipes)
            .Table("Portion_Pipe")
            .ParentKeyColumn("portionId")
            .ChildKeyColumn("pipeId").Not.LazyLoad();
         HasManyToMany<Project>(_ => _.Projects)
            .Table("Portion_Project")
            .ParentKeyColumn("portionId")
            .ChildKeyColumn("projectId").Not.LazyLoad();
      }
   }
}
