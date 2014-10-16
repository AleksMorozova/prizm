using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain
{
    public class Pipe
    {
        private int pipeNumber;
        private string status;
        private string manufacturer;
        private string size;

        public int PipeNumber
        {
            get { return this.pipeNumber; }
            set { this.pipeNumber = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
    }
}
