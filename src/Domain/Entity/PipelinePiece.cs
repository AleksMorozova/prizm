using System;
namespace Domain.Entity
{
    // TODO: PipelinePiece 
    public class PipelinePiece : Item
    {
        public virtual string Number { get; set; }
        public virtual int Length { get; set; }

    }
}