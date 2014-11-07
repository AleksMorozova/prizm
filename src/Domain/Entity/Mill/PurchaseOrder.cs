using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class PurchaseOrder : Item
    {
        public virtual string Number { get; set; }
        public virtual DateTime Date { get; set; }
        
        public virtual ICollection<Pipe> Pipes { get; set; }

        public PurchaseOrder(string number, DateTime date) : this()
        {
            this.Number = number;
            this.Date = date;
        }

        protected PurchaseOrder()
        {
            this.Pipes = new List<Pipe>();
        }
    }
}
