using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity
{
    public class SelectiveOperation
    {
        public Guid PipeSizeTypeId { get; set; }
        public Guid OperationId { get; set; }
        public string OperationCode { get; set; }
        public string OperationName { get; set; }
        public string PipeSizeTypeName { get; set; }
        public int SelectivePercent { get; set; }
        public int PipesCount { get; set; }
    }
}
