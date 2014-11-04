using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Pipe // : PipeLinePiece
    {
        public Pipe()
        {
            this.Spools = new List<Spool>();
            PipeCoating = new List<Coating>();
        }

        public int GuId { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }

        public PipeGeometry GeometryParam { get; set; }
        public Plate PipePlate { get; set; }
        public ChemicalComposition PipeChemicalComposition { get; set; }

        public virtual ICollection<Spool> Spools { get; set; }
        public virtual ICollection<Coating> PipeCoating { get; set; }

        public PipeStatus PipeStatus { get; set; }
    }


    public class PipeGeometry
    {
        public float Thickness { get; set; }
        public float Length { get; set; }
        public float Weight { get; set; }
        public float Diametr { get; set; }
    }


    public class Plate
    {
        public string Number { get; set; }
        public string Manufacturer { get; set; }
        public float Thickness { get; set; }
    }


    public class ChemicalComposition
    {
 
    }


    // TODO Spool is inherited from PipeLinePiece
    public class Spool // : PipeLinePiece
    {
        public string Number { get; set; }
    }


    public class TensilTests
    { 
    
    }


    public class Coating
    {
        public CoatingType CoatingType { get; set; }
        public DateTime Date { get; set; }

        // TODO check the data type IDictionary<string, string>
        public IDictionary<string, string> Coater { get; set; }
    }

    public enum CoatingType { }
    public enum PipeStatus { }

}
