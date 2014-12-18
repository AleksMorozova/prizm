using System;
namespace Prizm.Domain.Entity.Mill
{
    public class ChemicalComposition : Item
    {
        public virtual string Parameter { get; set;}
        public virtual float HeatValue { get; set; }
        public virtual float PlateValue { get; set; }
        public virtual float PipeValue { get; set; }

        public virtual Guid HeatId { get; set; }
    }
}