using System.Collections.Generic;

namespace Domain.Entity
{
    public class Component // TODO: :PipelinePiece
    {
        public enum Status
        {
            accepted,
            hold,
            rejected
        };

        public Component()
        {
            this.Connectors = new List<Connector>();
        }

        public int ComponentID { get; set; }
        //TODO: public ComponentType Type { get; set; }
        public int Number { get; set; }
        public string Sertificate { get; set; }
        public virtual ICollection<Connector> Connectors { get; set; }
    }
}