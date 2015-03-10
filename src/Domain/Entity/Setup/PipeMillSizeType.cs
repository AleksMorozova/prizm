using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Setup
{
    public class PipeMillSizeType: Item
    {
        public PipeMillSizeType()
        {
            PipeTests = new List<PipeTest>();
        }
        public virtual string Type { get; set; }
        public virtual int Length { get; set; }
        public virtual float Diameter { get; set; }
        public virtual float Thickness { get; set; }
        public virtual bool IsNative { get; set; }
        public virtual Project Project { get; set; }

        public virtual SeamType SeamType { get; set; }


        public virtual IList<PipeTest> PipeTests { get; set; }

        public override string ToString()
        {
            return Type;
        }

        public virtual PipeMillSizeType Clone()
        {
            PipeMillSizeType clone = new PipeMillSizeType();
            var tests = new List<PipeTest>();

            foreach(var item in this.PipeTests)
            {
                tests.Add(new PipeTest()
                {
                    Category = item.Category,
                    Code = item.Code,
                    Name = item.Name,
                    MinExpected = item.MinExpected,
                    MaxExpected = item.MaxExpected,
                    StringExpected = item.StringExpected,
                    BoolExpected = item.BoolExpected,
                    IsRequired = item.IsRequired,
                    pipeType = clone,
                    ControlType = item.ControlType,
                    ResultType = item.ResultType,
                    IsActive = item.IsActive
                });
            }

            clone.Type = this.Type + " Copy";
            clone.PipeTests = new BindingList<PipeTest>(tests);
            clone.IsActive = this.IsActive;
            clone.Diameter = this.Diameter;
            clone.Thickness = this.Thickness;
            clone.Length = this.Length;
            clone.SeamType = this.SeamType;
            clone.IsNative = this.IsNative;
            clone.Project = this.Project;

            return clone;
        }
    }
}
