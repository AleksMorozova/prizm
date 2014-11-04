using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    class PipeTest
    {
        public virtual Guid Id { get; set; }
        public virtual string Code { get; set; }
        public virtual string TestSubject { get; set; }
        public virtual PipeTestControlType ControlType { get; set; }
        public virtual PipeTestResultType Resulttype { get; set; }
        public virtual int MinExpected { get; set; }
        public virtual int MaxExpected { get; set; }
        public virtual bool BoolExpected { get; set; }
        public virtual bool IsRequired { get; set; }
    }
}
