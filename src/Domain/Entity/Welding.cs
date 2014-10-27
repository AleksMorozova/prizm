using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Welding
    {
        public Guid WeldingID { get; set; }
        public DateTime Date { get; set; }
        public Welder Welder { get; set; }
    }
}
