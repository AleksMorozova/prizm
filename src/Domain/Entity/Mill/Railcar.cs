using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Entity.Mill
{
    
    public class Railcar
    {
        public virtual Guid Id { get; set; }
        public virtual string Number { get; set; }
        public virtual string Certificate { get; set; }
        public virtual string Destination { get; set; }
        public virtual DateTime ShippingDate { get; set; }
        public virtual DateTime DeliveryDate { get; set; }
    }
}
