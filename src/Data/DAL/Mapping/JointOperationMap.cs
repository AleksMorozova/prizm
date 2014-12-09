using Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class JointOperationMap : SubclassMap<JointOperation>
    {
        public JointOperationMap() 
        {
            Map(_ => _.Name, "name");
            Map(_ => _.IsRequired, "isRequired");
            Map(_ => _.IsTest, "isTest");
            Map(_ => _.TestHasAcepted, "testHasAcepted");
            Map(_ => _.TestHasToRepair, "testHasToRepair");
            Map(_ => _.TestHasToWithdrow, "testHasToWithdrow");
            Map(_ => _.TestResultRequired, "testResultRequired");
        }
    }
}
