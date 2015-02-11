using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Settings
{
    public class DuplicatesList
    {
        public List<string> Duplicates {get;set;}
        public FindDuplicates MethodsStore { get; set; }

        public delegate List<string> FindDuplicates();

    }
}
