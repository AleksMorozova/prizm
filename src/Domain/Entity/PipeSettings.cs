using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public enum PipeType
    { 
        Helical,
        Longitudinal
    }

    public class PipeSettings
    {
        public PipeSettings()
        {
            this.CoatingSettings = new List<CoatingSettings>(2);
            this.PipeInspectionSettings = new List<PipeInspectionSettings>();
        }
        
        public string WeldType { get; set; }
        public PipeType PipeType { get; set; }

        public virtual ICollection<CoatingSettings> CoatingSettings { get; set; }
        public virtual ICollection<PipeInspectionSettings> PipeInspectionSettings { get; set; } //not sure
    }
}
