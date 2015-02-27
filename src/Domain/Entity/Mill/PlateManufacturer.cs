using System.Collections.Generic;

namespace Prizm.Domain.Entity.Mill
{
    public class PlateManufacturer : Item
    {
        public PlateManufacturer()
        {
            this.Heats = new List<Heat>();
        }

        public virtual string Name { get; set; }
        public virtual IList<Heat> Heats { get; set; }
        public virtual bool IsNative { get; set; }
        public virtual Project Project { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}