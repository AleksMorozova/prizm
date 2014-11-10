using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAL.Mapping
{
   public class RailcarMap : ClassMap<Railcar>
   {
      public RailcarMap()
      {
          Id(_ => _.Id, "id").Column("id").GeneratedBy.GuidComb();
         Map(_ => _.Number, "number");
         Map(_ => _.ShippingDate, "shipingDate");
         Map(_ => _.Destination, "destination");
         Map(_ => _.Certificate, "certificate");
         Map(_ => _.IsActive, "is_active");
      }
   }
}
