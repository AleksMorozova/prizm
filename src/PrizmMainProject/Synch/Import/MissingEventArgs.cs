using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prizm.Main.Synch.Import
{
    public class MissingEventArgs
    {
        public int[] ExistingPortions { get; set; }
        public int[] MissingPortions { get; set; }
        public string MillName { get; set; }
    }
}
