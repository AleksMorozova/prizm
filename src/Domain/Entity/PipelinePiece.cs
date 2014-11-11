using System;
namespace Domain.Entity
{
    // TODO: PipelinePiece 
    public class PipelinePiece //: Item
    {
        public virtual string Number { get; set; }
        public virtual float Length { get; set; }

        public virtual Guid Id { get; protected set; }
        public virtual bool IsActive { get; set; }
    }
}