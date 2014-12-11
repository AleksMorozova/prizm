using System;
using Domain.Entity.Setup;
using System.Collections.Generic;
using Domain.Entity.Construction;

namespace Domain.Entity.Mill
{
    public class Pipe : PipelinePiece
    {
        public Pipe()
        {
            this.Welds = new List<Weld>();
            this.Coats = new List<Coat>();
            this.Spools = new List<Spool>();
            this.PipeTestResult = new List<PipeTestResult>();

            this.Plate = new Plate() { Pipe = this };
        }

        public virtual Plate Plate { get; set; }

        public virtual string Mill { get; set; }
        public virtual int Diameter { get; set; }
        public virtual int WallThickness { get; set; }

        public virtual float Weight
        {
            get
            {
                return (float)(Math.PI * Ro * this.WallThickness * (this.Diameter - this.WallThickness) * this.Length);
            }
            set
            {
                weight = (float)(Math.PI * Ro * this.WallThickness * (this.Diameter - this.WallThickness) * this.Length);
            }
        }

        public virtual DateTime ProductionDate { get; set; }

        public virtual PipeMillSizeType Type { get; set; }

        public virtual Railcar Railcar { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }

        public virtual ChemicalComposition ChemicalComposition { get; set; }

        public virtual IList<Weld> Welds { get; set; }
        public virtual IList<PipeTestResult> PipeTestResult { get; set; }
        public virtual IList<Coat> Coats { get; set; }

        public virtual IList<Spool> Spools { get; set; }

        public virtual PipeMillStatus Status { get; set; }

        private float weight;

        public const float Ro = 0.00000785F;

    }
}