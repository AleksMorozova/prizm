using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class PurchaseOrder
    {
        public virtual Guid Id { get; set; }
        public virtual string Number { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
