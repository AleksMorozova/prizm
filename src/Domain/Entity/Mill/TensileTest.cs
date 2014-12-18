namespace Prizm.Domain.Entity.Mill
{
    public class TensileTest : Item
    {
        public virtual string Parameter { get; set; }
        public virtual float BaseValue { get; set; }
        public virtual float JointValue { get; set; }
    }
}