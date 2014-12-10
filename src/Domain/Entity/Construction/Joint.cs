using System;
using System.Collections.Generic;

namespace Domain.Entity.Construction
{
    public class Joint : Item
    {
        public Joint()
        {
            this.PipelinePieces = new List<PipelinePiece>(2);
            this.JointTestResults = new List<JointTestResult>();
            this.JointActionResults = new List<JointActionResult>();
        }

        public virtual string Number { get; set; }
        public virtual int NumberKP { get; set; }
        public virtual float DistanceFromKP { get; set; }
        public virtual DateTime LoweringDate { get; set; }
        public virtual JointStatus JointStatus { get; set; }
        public virtual float GpsLatitude { get; set; }
        public virtual float GpsLongitude { get; set; }
        public virtual float GpsHeight { get; set; }
        public virtual IList<PipelinePiece> PipelinePieces { get; set; }
        public virtual IList<JointTestResult> JointTestResults { get; set; }
        public virtual IList<JointActionResult> JointActionResults { get; set; } 

    }
}