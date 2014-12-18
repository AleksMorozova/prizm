using Prizm.Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
   public class CoatMap : SubclassMap<Coat>
   {
      public CoatMap()
      {
         Map(_ => _.Date);
         Map(_ => _.Type);
         References<Pipe>(_ => _.Pipe).Column("pipeId");
      }
   }
}
