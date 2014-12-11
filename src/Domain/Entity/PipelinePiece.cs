using Domain.Entity.Construction;
using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    // TODO: PipelinePiece 
    public class PipelinePiece : Item
    {
        public virtual string Number { get; set; }
        public virtual int Length { get; set; }

        public virtual PieceConstructionStatus ConstructionStatus { get; set; }

        public virtual PieceInspectionStatus InspectionStatus { get; set; } //???

        public virtual IList<Joint> Joints { get; set; }

        public virtual IList<InspectionTestResult> InspectionTestResults { get; set; }
    }
}