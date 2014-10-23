using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    //TODO : uncomment Pipes and KilometerPosts
    public class Project
    {
        public Project()
        {
            this.Heats = new List<Heat>();
            //this.Pipes = new List<Pipe>();
            this.Railcars = new List<Railcar>();
            //this.KilometerPosts = new List<KilometerPost>();
        }

        public string Title { get; set; }
        public string Client { get; set; }
        public string Designer { get; set; }
        public PipeSettings PipeSetting { get; set; }

        public virtual ICollection<Heat> Heats { get; set; }
        //public virtual ICollection<Pipe> Pipes { get; set; }
        public virtual ICollection<Railcar> Railcars { get; set; }
        //public virtual ICollection<KilometerPost> KilometerPosts { get; set; }
    }
}
