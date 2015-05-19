using Prizm.Domain.Entity.Mill;
using System.Collections.Generic;
using System.Linq;

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
            : this()
        {
            this.Code = code;
            this.FrequencyType = frequencyType;
        }

        public PipeTest()
        {
            this.PipeTestResults = new List<PipeTestResult>();
            this.RepeatedInspections = new List<PipeTest>();
            this.SelectivePercent = 1;

        }

        //category of test
        public virtual Category Category { get; set; }

        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal MinExpected { get; set; }
        public virtual decimal MaxExpected { get; set; }
        public virtual string StringExpected { get; set; }
        public virtual bool BoolExpected { get; set; }
        public virtual int SelectivePercent { get; set; }

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

        public virtual IList<PipeTest> RepeatedInspections { get; set; }
        public virtual bool IsReadyToUse 
        {
            get
            {
                var condition = 
                       !string.IsNullOrWhiteSpace(this.Code)
                    && !string.IsNullOrWhiteSpace(this.Name)
                    && this.ResultType != PipeTestResultType.Undefined
                    && this.ControlType != PipeTestControlType.Undefined;

                if (this.FrequencyType == InspectionFrequencyType.U)
                {
                    condition &= this.Frequency != null && this.Frequency.Measure != FrequencyMeasure.Undefined;
                }

                return condition;
            }
        }

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


        public virtual string DisplayRepeatedInspections
        {
            get
            {
                string displayText = null;
                foreach (var insp in RepeatedInspections.Where<PipeTest>(x => x.IsActive))
                {
                    displayText += string.IsNullOrEmpty(displayText) ? insp.Code : string.Concat(", ", insp.Code);
                }
                return displayText;
            }
        }

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
            this.SelectivePercent = original.SelectivePercent;
            this.RepeatedInspections = new List<PipeTest>(original.RepeatedInspections);
        }
    }
}
