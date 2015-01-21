using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Railcar.Search
{
    public class Railcar
    {
        public Guid Id { get; set; }
        public virtual string ReleaseNoteNumber { get; set; }
        public virtual DateTime? ReleaseNoteDate { get; set; }
        public string Number { get; set; }
        public string Certificate { get; set; }
        public string Destination { get; set; }
        public DateTime? ShippingDate { get; set; }
        public bool IsShipped { get; set; }

        public string Status
        {
            get
            {
                return
                    this.IsShipped ?
                    Resources.ResourceManager.GetString("RailcarShipped") :
                    Resources.ResourceManager.GetString("RailcarPending");
            }
        }
    }
}
