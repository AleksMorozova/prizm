using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.SerializableEntity.Mill
{
    [Serializable]
    class SerializableRailcar
    {
        public Guid Id { get; set; }
        public string RailcarNumber { get; set; }
        public string Certificate { get; set; }
    }
}
