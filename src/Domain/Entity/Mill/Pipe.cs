using Domain.Entity.Setup;
using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class Pipe : PipelinePiece
    {
public Pipe()
        {
            this.Welds = new List<Weld>();
            //this.PipeTestResult = new List<PipeTestResult>();
        }


        public virtual Plate Plate { get; set; }

        public virtual string Mill { get; set; }
        public virtual int Diameter { get; set; }
        public virtual int WallThickness { get; set; }
        public virtual int Weight { get; set; }

        public virtual PipeMillSizeType Type { get; set; } // from global dictionary type: PipeMillSizeType

        public virtual Railcar Railcar { get; set; }
        public virtual string Status { get; set; } //FIX: convert string to enum and map enum to database
        public virtual PurchaseOrder PurchaseOrder { get; set; }

        public virtual ChemicalComposition ChemicalComposition { get; set; }

        
        public virtual IList<Weld> Welds { get; set; }
        //public virtual IList<PipeTestResult> PipeTestResult { get; set; }
    }
}