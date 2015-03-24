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
        public Guid PipeSizeTypeId { get; set; }
        public Guid OperationId { get; set; }
        public int Frequency { get; set; }
        public string Measure { get; set; }
        public string OperationCode { get; set; }
        public string OperationName { get; set; }
        public string PipeSizeTypeName { get; set; }
    }
}
