using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class Pipe : PipelinePiece
    {
        public Pipe(
            int diameter, int wallThikness, int weigh, string type
            )
        {
            this.Diameter = diameter;
            this.WallThickness = wallThikness;
            this.Weight = weigh;
            this.Type = type;
            this.Welds = new List<Weld>();
            this.PipeTestResult = new List<PipeTestResult>();
        }

        protected Pipe()
        {
            this.Welds = new List<Weld>();
            this.PipeTestResult = new List<PipeTestResult>();
        }

        public virtual string Number { get; set; }
        public virtual string Mill { get; set; }
        public virtual int Diameter { get; set; }
        public virtual int WallThickness { get; set; }
        public virtual int Weight { get; set; }
        public virtual string Type { get; set; } // from global dictionary type: PipeMillSizeType
        public virtual Railcar Railcar { get; set; }
        public virtual PipeMillStatus Status { get; set; } //enum
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual ICollection<Weld> Welds { get; set; }
        public virtual ICollection<PipeTestResult> PipeTestResult { get; set; }
    }
}