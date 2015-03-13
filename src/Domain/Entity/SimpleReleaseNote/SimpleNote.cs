using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.SimpleReleaseNote
{
    public class SimpleNote
    {
        public SimpleNote()
        {
            this.Railcars = new List<SimpleRailcar>();
        }

        public virtual string Number { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual bool Shipped { get; set; }

        public virtual IList<SimpleRailcar> Railcars { get; set; }

        public virtual IList<File> Attachments { get; set; }

        //item
        private bool isActive = true;

        public virtual Guid Id { get; set; }
        public virtual bool IsActive { get { return isActive; } set {isActive=value ;} }

    }
}
