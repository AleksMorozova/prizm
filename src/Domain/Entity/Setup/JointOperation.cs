using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Setup
{
    public class JointOperation : Item
    {
        public virtual string Name { get; set; }
        public virtual bool IsRequired { get; set; }
        public virtual JointOperationType Type { get; set; }
        public virtual bool TestHasAccepted { get;  set; }
        public virtual bool TestHasToRepair { get; set; }
        public virtual bool TestHasToWithdraw { get; set; }
        public virtual bool TestResultRequired { get; set; }
        //TODO:
        //public virtual ICollection<JointActionResults> { get; set; }
        //public virtual ICollection<JointTestResults> { get; set; } 

        public JointOperation()
        {
            //TODO: 
            //this.JointActionResults = new List<JointActionResults>();
            //this.JointTestResults = new List<JointTestResults>();
        }

        public JointOperation(string name, bool isRequired, JointOperationType type, bool testHasAccepted, bool testHasToRepair, bool testHasToWithdrow, bool testResultRequired)
        {
            this.Name = name;
            this.IsRequired = isRequired;
            this.Type = type;
            this.TestHasAccepted = testHasAccepted;
            this.TestHasToRepair = testHasToRepair;
            this.TestHasToWithdraw = testHasToWithdrow;
            this.TestResultRequired = testResultRequired;
            //TODO:
            //this.JointActionResults = new List<JointActionResults>();
            //this.JointTestResults = new List<JointTestResults>();
        }


    }
}
