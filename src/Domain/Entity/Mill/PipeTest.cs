using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class PipeTest : Item
    {
        public virtual string Code { get; set; }
        public virtual string TestSubject { get; set; }
        public virtual int MinExpected { get; set; }
        public virtual int MaxExpected { get; set; }
        public virtual string StringExpected { get; set; }
        public virtual bool BoolExpected { get; set; }
        public virtual bool IsRequired { get; set; }

        //enums
        public virtual PipeTestControlType ControlType { get; set; }
        public virtual PipeTestResultType Resulttype { get; set; }

        public virtual ICollection<PipeTestResult> PipeTestResults { get; set; }

        //string test
        public PipeTest(string code, string subject, bool isRequired, string expected)
            : this(code, subject, isRequired)
        {
            this.StringExpected = expected;
        }

        //diapasone test
        public PipeTest(string code, string subject, bool isRequired, int min, int max)
            : this(code, subject, isRequired)
        {
            this.MinExpected = min;
            this.MaxExpected = max;
        }

        //bool test
        public PipeTest(string code, string subject, bool isRequired, bool expected) 
            : this(code,subject,isRequired)
        {
            this.BoolExpected = expected;
        }

        public PipeTest(string code, string subject, bool isRequired)
        {
            this.Code = code;
            this.TestSubject = subject;
            this.IsRequired = isRequired;
            this.PipeTestResults = new List<PipeTestResult>();
        }

        protected PipeTest()
        {
            this.PipeTestResults = new List<PipeTestResult>();
        }
    }
}
