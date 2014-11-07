using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class RailCar : Item
    {
        public virtual string Number { get; set; }
        public virtual string Certificate { get; set; }
        public virtual string Destination { get; set; }
        public virtual DateTime ShippingDate { get; set; }
        public virtual DateTime DeliveryDate { get; set; }

        public virtual ICollection<Pipe> Pipes { get; set; }

        public RailCar(string number, string certificate, string destination):this()
        {
            this.Number = number;
            this.Certificate = certificate;
            this.Destination = destination;
        }

        protected RailCar()
        {
            this.Pipes = new List<Pipe>();
        }
    }
}
