using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class Pipe // : PipeLinePiece
    {
        public virtual Guid Id { get; set; }
        public virtual PipeMillStatus Status { get; set; }
        public virtual string Mill { get; set; }
        public virtual int Diameter { get; set; }
        public virtual int WallThickness { get; set; }
        public virtual int Weight { get; set; }
        public virtual string PipeMillSizeType { get; set; }
        public virtual Railcar RailCar { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual ICollection<Weld> Welds { get; set; }
        public virtual ICollection<PipeTestResult> PipeTestResult { get; set; }

        public Pipe()
        {
            this.Welds = new List<Weld>();
            this.PipeTestResult = new List<PipeTestResult>();
        }



 
    }

    


   
}
