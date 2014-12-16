using Domain.Entity.Mill;
using Domain.Entity.Setup;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.Search
{
    public class Pipe
    {
        public Guid Id { get; set; }
        public string Number{get; set;}
        public string HeatNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string Mill { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Type { get; set; }
        public string PipeMillStatus { get; set; }
        public bool IsActive { get; set; }
    }
}
