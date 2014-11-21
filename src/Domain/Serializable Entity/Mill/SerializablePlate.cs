using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Serializable_Entity.Mill
{
    [Serializable]
    class SerializablePlate
    {
        public Guid Id { get; set; }
        public string PlateNumber { get; set; }
    }
}
