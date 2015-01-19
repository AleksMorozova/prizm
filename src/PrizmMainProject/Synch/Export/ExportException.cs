using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch.Export
{
   public class ExportException : Exception
   {
      public ExportException() { }

      public ExportException(string message) : base(message)
      {
      }

      public ExportException(string message, Exception inner) : base(message, inner)
      {
      }

   }
}
