using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    //TODO : uncomment CoatingType
    public class CoatingSettings
    {
        //public CoatingType CoatingType { get; set; }
        public float Thickness { get; set; }
        public float Adhesion { get; set; }
        public string Material { get; set; }

    }
}
