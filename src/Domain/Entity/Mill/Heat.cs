using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class Heat : Item
    {
       
        public Heat()
        {
            this.Plates = new List<Plate>();
        }

        public virtual string Number { get; set; }
        public virtual IList<Plate> Plates { get; set; }


        public virtual PhysicalParameters PhysicalParameters { get; set; }
        public virtual ChemicalComposition ChemicalComposition { get; set; }
        
    }
}