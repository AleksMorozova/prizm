using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Railcar
    {
        public Guid RailcarID { get; set; }
        public string Number { get; set; }
        public string Certificate { get; set; }
        public string Destination { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
