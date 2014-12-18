using Prizm.Domain.Entity.Mill;
using FluentNHibernate.Mapping;

namespace Prizm.Data.DAL.Mapping
{
    public class PurchaseOrderMap : SubclassMap<PurchaseOrder>
    {
        public PurchaseOrderMap()
        {
            Map(_ => _.Number, "number");
            Map(_ => _.Date, "date");

            HasMany(_ => _.Pipes)
                .KeyColumn("purchaseOrderId")
                .Inverse();
        }
    }
}