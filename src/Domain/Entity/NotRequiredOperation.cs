using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity
{
    public class NotRequiredOperation
    {
        public Guid operationId { get; set; }
        public int frequency { get; set; }
        public string measure { get; set; }
        public string operationCode { get; set; }
        public string operationName { get; set; }
        public string pipeSizeTypeName { get; set; }
    }
}
