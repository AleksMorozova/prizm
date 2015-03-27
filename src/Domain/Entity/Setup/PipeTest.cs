using Prizm.Domain.Entity.Mill;
using System.Collections.Generic;

namespace Prizm.Domain.Entity.Setup
{
    public class PipeTest : Item
    {
        public PipeTest(string code, string subject, InspectionFrequencyType frequencyType, string expected)
            : this(code, subject, frequencyType)
        {
            this.StringExpected = expected;
        }

        //diapasone test
        public PipeTest(string code, string subject, InspectionFrequencyType frequencyType, int min, int max)
            : this(code, subject, frequencyType)
        {
            this.MinExpected = min;
            this.MaxExpected = max;
        }

        //bool test
        public PipeTest(string code, string subject, InspectionFrequencyType frequencyType, bool expected)
            : this(code, subject, frequencyType)
        {
            this.BoolExpected = expected;
        }

        public PipeTest(string code, string subject, InspectionFrequencyType frequencyType)
        {
            this.Code = code;
            this.FrequencyType = frequencyType;
            this.PipeTestResults = new List<PipeTestResult>();
            this.RepeatedInspections = new List<PipeTest>();
        }

        public PipeTest()
        {
            this.PipeTestResults = new List<PipeTestResult>();
        }

        //category of test
        public virtual Category Category { get; set; }

        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int MinExpected { get; set; }
        public virtual int MaxExpected { get; set; }
        public virtual string StringExpected { get; set; }
        public virtual bool BoolExpected { get; set; }

        public virtual InspectionFrequencyType FrequencyType { get; set; }
        public virtual PipeMillSizeType pipeType { get; set; }
        public virtual PipeTestFrequency Frequency { get; set; }
        //enums
        public virtual PipeTestControlType ControlType { get; set; }
        public virtual PipeTestResultType ResultType { get; set; }

        public virtual ICollection<PipeTestResult> PipeTestResults { get; set; }
        public virtual bool IsRequired
        { 
            get { return FrequencyType == InspectionFrequencyType.R; } 
        }

        public virtual List<PipeTest> RepeatedInspections { get; set; }

        public virtual string DisplayExpectedResult
        {
            get 
            {
                switch (this.ResultType)
                {
                    case PipeTestResultType.Boolean:
                        return this.BoolExpected.ToString();
                    case PipeTestResultType.Diapason:
                        return this.MinExpected + "-" + this.MaxExpected;
                    default:
                        return "";
                }
            } 
        }
        //string test

        public virtual void CustomShallowCopy(PipeTest original)
        {
            this.BoolExpected = original.BoolExpected;
            this.Category = original.Category;
            this.Code = original.Code;
            this.ControlType = original.ControlType;
            this.Frequency = original.Frequency;
            this.Id = original.Id;
            this.IsActive = original.IsActive;
            this.FrequencyType = original.FrequencyType;
            this.MaxExpected = original.MaxExpected;
            this.MinExpected = original.MinExpected;
            this.Name = original.Name;
            this.OwnerId = original.OwnerId;
            this.PipeTestResults = original.PipeTestResults;
            this.pipeType = original.pipeType;
            this.ResultType = original.ResultType;
            this.StringExpected = original.StringExpected;
        }
    }
}
