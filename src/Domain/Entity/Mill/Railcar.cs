using System;
using System.Collections.Generic;

namespace Prizm.Domain.Entity.Mill
{
    public class Railcar : Item
    {
        public Railcar()
        {
            this.Pipes = new List<Pipe>();
        }

        public virtual string ReleaseNoteNumber { get; set; }
        public virtual DateTime? ReleaseNoteDate { get; set; }
        public virtual string Number { get; set; }
        public virtual string Certificate { get; set; }
        public virtual string Destination { get; set; }
        public virtual DateTime? ShippingDate { get; set; }
        public virtual bool IsShipped { get; set; }

        public virtual IList<Pipe> Pipes { get; set; }

      
    }
}