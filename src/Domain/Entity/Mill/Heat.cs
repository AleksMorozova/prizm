using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class Heat
    {
        public virtual int Id { get; set; }
        public virtual string Number { get; set; }
        public virtual PhysicalParameters PhysicalParameters { get; set; }
        public virtual ChemicalComposition ChemicalComposition { get; set; }
    }
}
