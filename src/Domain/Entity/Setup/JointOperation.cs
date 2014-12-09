using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Setup
{
    public class JointOperation : Item
    {
        public virtual string Name { get; set; }
        public virtual bool IsRequired { get; set; }
        public virtual bool IsTest { get; set; }
        public virtual bool TestHasAcepted { get;  set; }
        public virtual bool TestHasToRepair { get; set; }
        public virtual bool TestHasToWithdrow { get; set; }
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

        public JointOperation(string name, bool isRequired, bool isTest)
        {
            this.Name = name;
            this.IsRequired = isRequired;
            this.IsTest = isTest;
            //TODO:
            //this.JointActionResults = new List<JointActionResults>();
            //this.JointTestResults = new List<JointTestResults>();
        }


    }
}
