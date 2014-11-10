using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class PlateManufacturer : Item
    {
        public PlateManufacturer(string name) : this()
        {
            this.Name = name;
        }

        protected PlateManufacturer()
        {
            this.Heats = new List<Heat>();
        }

        public virtual string Name { get; set; }
        public virtual ICollection<Heat> Heats { get; set; }
    }
}