using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Serializable_Entity.Mill
{
    [Serializable]
    class SerializableRailcar
    {
        public Guid Id { get; set; }
        public string RailcarNumber { get; set; }
        public string Certificate { get; set; }
    }
}
