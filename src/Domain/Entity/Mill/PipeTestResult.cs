using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class PipeTestResult
    {
        public virtual Guid Id { get; set; }
        public virtual PipeTest operation { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
