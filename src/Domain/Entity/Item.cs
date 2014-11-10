using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Item
    {
        public virtual Guid Id { get; protected set; }

        public virtual bool IsActive { get; set; }
    }
}
