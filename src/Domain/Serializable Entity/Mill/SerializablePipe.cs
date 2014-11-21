using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Serializable_Entity.Mill
{
    [Serializable]
    class SerializablePipe
    {
        public Guid Id { get ;set ;}
        public string PipeNumber { get; set; }
        public int Diameter { get; set; }
        public int WallThickness { get; set; }
        public int Weight { get; set; }
        public int Length { get; set; }
    }
}
