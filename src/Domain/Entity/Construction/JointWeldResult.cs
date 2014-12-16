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

        /// <summary>
        /// Is empty if JointActionresult is saved
        /// </summary>
        public virtual IList<Welder> Welders { get; set; }
    }
}
