using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class Heat : Item
    {
       
        public Heat()
        {
            this.Plates = new List<Plate>();
            this.PlateManufacturer = new PlateManufacturer();
        }

        public virtual string Number { get; set; }
        public virtual string SteelGrade { get; set; }

        public virtual PlateManufacturer PlateManufacturer { get; set; }

        public virtual IList<Plate> Plates { get; set; }

        public override string ToString()
        {
            return Number;
        }
    }
}