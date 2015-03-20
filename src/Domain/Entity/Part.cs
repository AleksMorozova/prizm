using Prizm.Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prizm.Domain.Entity
{
    // TODO: Part 
    public class Part : Item
    {
        public virtual string Number { get; set; }
        public virtual int Length { get; set; }
        public virtual bool IsAvailableToJoint { get; set; }

        public virtual PartConstructionStatus ConstructionStatus { get; set; }
        public virtual PartInspectionStatus InspectionStatus { get; set; }

        public virtual IList<InspectionTestResult> InspectionTestResults { get; set; }
        
        /// <summary>
        /// PartInspectionStatus - is based on last inspection test result status. If there were several inspection test results on one date:
        /// select Accepted is exists.If doesn't exist - select the last one
        /// </summary>
        public virtual PartInspectionStatus GetPartInspectionStatus()
        {
            PartInspectionStatus status = PartInspectionStatus.Pending;

            if (this.InspectionTestResults != null && this.InspectionTestResults.Count > 0)
            {
                status = (this.InspectionTestResults.OrderByDescending(x => x.Order).First()).Status;
            }
            
            return status;
        }
    }
}