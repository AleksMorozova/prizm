using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Construction
{
    public class JointWeldResult : JointActionResult
    {
        public JointWeldResult()
        {
            this.Welders = new List<Welder>();
        }
        public virtual IList<Welder> Welders { get; set; }
    }
}
