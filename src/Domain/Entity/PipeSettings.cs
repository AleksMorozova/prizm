using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public enum SeamType
    { 
        Helical,
        Longitudinal,
        Seamless
    }

    public class PipeSettings
    {
        public PipeSettings()
        {
            this.CoatingSettings = new List<CoatingSettings>(2);
            this.PipeInspectionSettings = new List<PipeInspectionSettings>();
        }

        public SeamType SeamType { get; set; }

        public virtual ICollection<CoatingSettings> CoatingSettings { get; set; }
        public virtual ICollection<PipeInspectionSettings> PipeInspectionSettings { get; set; } //not sure
    }
}
