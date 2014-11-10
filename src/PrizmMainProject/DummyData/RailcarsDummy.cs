using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.DummyData
{
    public class RailcarsDummy
    {
        private int railcarNumber;
        private string status;
        private DateTime deliveryDate;
        private DateTime shippedDate;

        public int RailcarNumber
        {
            get { return this.railcarNumber; }
            set { this.railcarNumber = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public DateTime DeliveryDate
        {
            get { return this.deliveryDate; }
            set { this.deliveryDate = value; }
        }

        public DateTime ShippedDate
        {
            get { return this.shippedDate; }
            set { this.shippedDate = value; }
        }
    }
}
