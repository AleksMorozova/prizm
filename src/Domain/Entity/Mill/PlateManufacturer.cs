using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class PlateManufacturer : Item
    {
        public virtual string Name { get; set; }
        public virtual ICollection<Heat> Heats { get; set; }

        public PlateManufacturer(string name):this()
        {
            this.Name = name;
        }

        protected PlateManufacturer() 
        {
            this.Heats = new List<Heat>();
        }
     
    }
}
