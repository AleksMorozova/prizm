using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Component // TODO: :PipelinePiece
    {
        public Component()
        {
            this.Connectors= new List<Connector>();
        }

        public int ComponentID { get; set; }
        //TODO: public ComponentType Type { get; set; }
        public int Number { get; set; }
        public string Sertificate { get; set; }
        public virtual ICollection<Connector> Connectors { get; set; }

        public enum Status { accepted,hold,rejected };
    }
}
