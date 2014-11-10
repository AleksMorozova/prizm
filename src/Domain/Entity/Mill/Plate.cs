using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class Plate : Item
    {
        public virtual string Number { get; set; }
        public virtual int Thicknes { get; set; }
        public virtual Heat Heat { get; set; }
        public virtual ChemicalComposition ChemicalComposition { get; set; }
        //public virtual TensileTests TensileTests { get; set; }
        public virtual Pipe Pipe { get; set; }

        public Plate(string number, int thickness, Heat heat, Pipe pipe)
        {
            this.Number = number;
            this.Thicknes = thickness;
            this.Heat = heat;
            this.Pipe = pipe;
        }

        protected Plate()
        {

        }

    }
}
