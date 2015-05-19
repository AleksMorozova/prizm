using System;
using System.Collections.Generic;

namespace Prizm.Domain.Entity.Construction
{
    public class Joint : Item
    {
        public Joint()
        {
            this.JointTestResults = new List<JointTestResult>();
            this.JointWeldResults = new List<JointWeldResult>();
        }

        public virtual string Number { get; set; }
        public virtual int NumberKP { get; set; }
        public virtual decimal DistanceFromKP { get; set; }
        public virtual DateTime? LoweringDate { get; set; }
        public virtual JointStatus Status { get; set; }
        // for GpsLatitude and GpsLongitude double is required for functioning of GPS mask (opportunity to enterring more than 9 characters)
        public virtual double GpsLatitude { get; set; }
        public virtual double GpsLongitude { get; set; }
        public virtual decimal GpsHeight { get; set; }
        public virtual PartData FirstElement { get; set; }
        public virtual PartData SecondElement { get; set; }
        public virtual IList<JointTestResult> JointTestResults { get; set; }
        public virtual IList<JointWeldResult> JointWeldResults { get; set; }
        public virtual bool ToExport { get; set; }

        public virtual IList<File> Attachments { get; set; }

        public override string ToString()
        {
            return Number;
        }
    }
}