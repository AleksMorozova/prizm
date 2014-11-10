using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class PurchaseOrderMap : ClassMap<PurchaseOrder>
    {
        public PurchaseOrderMap()
        {
            Id(_ => _.Id, "id").Column("id").GeneratedBy.GuidComb();
            Map(_ => _.Number, "number");
            Map(_ => _.Date, "date");

            HasMany(_ => _.Pipes)
                .KeyColumn("purchaseOrderId")
                .Inverse();
        }
    }
}
