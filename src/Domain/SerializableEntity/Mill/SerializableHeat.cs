using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.SerializableEntity.Mill
{
    [Serializable]
    class SerializableHeat
    {
        public Guid Id { get; set; }
        public string HeatNumber { get; set; }
    }
}
