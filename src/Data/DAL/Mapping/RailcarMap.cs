using Domain.Entity.Mill;
using FluentNHibernate.Mapping;

namespace Data.DAL.Mapping
{
    public class RailcarMap : SubclassMap<Railcar>
    {
        public RailcarMap()
        {
            Map(x => x.Number).Column("number");
            Map(_ => _.ShippingDate, "shippingDate");
            Map(_ => _.Destination, "destination");
            Map(_ => _.Certificate, "certificate");
        }
    }
}