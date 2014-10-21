using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Joint
{
    public class Joint : PipelinePiece
    {
        public Joint()
        {
            this.Weldings = new List<ConstructionWelding>();
            this.Inspections = new List<JointInspection>();
        }

        public Guid JointID { get; set; }
        public string Number { get; set; }
        public DateTime LoweringDate { get; set; }
        public float DistansFromKilomiterPost { get; set; }

        public ICollection<ConstructionWelding> Weldings { get; set; }
        public ICollection<JointInspection> Inspections { get; set; }
        
    }
}
