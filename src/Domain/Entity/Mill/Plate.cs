using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class Plate
    {
        public virtual int Id { get; set; }
        public virtual string Number { get; set; }
        public virtual int Thicknes { get; set; }
        public virtual Heat Heat { get; set; }
        public virtual ChemicalComposition ChemicalComposition { get; set; }
        public virtual TensileTests TensileTests { get; set; }
    }
}
