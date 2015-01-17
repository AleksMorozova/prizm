using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch.Import
{
   public class ImportException : Exception
   {
      public ImportException() 
      { 
      }

      public ImportException(string message) : base(message)
      {
      }

      public ImportException(string message, Exception inner) : base(message, inner)
      {
      }
   }
}
