using Prizm.Main.Forms.Synch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch.Import
{
   public class ConflictEventArgs
   {
      public string Message { get; set; }
      public ConflictDecision Decision { get; set; }
      public bool ForAll { get; set; }
   }
}
