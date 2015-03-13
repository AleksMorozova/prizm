using System;
using System.Collections.Generic;

namespace Prizm.Domain.Entity.SimpleReleaseNote
{
    public class SimpleRailcar : Item
    {
        public SimpleRailcar()
        {
            this.Pipes = new List<SimplePipe>();
        }
        public virtual string Number { get; set; }
        public virtual string Certificate { get; set; }
        public virtual string Destination { get; set; }
        //remove!
        public virtual bool IsShipped { get; set; }
        public virtual SimpleNote ReleaseNote { get; set; }
        public virtual IList<SimplePipe> Pipes { get; set; }
    }
}