using Prizm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch.Export
{
   public interface IExporter
   {
      ExportResult Export();
      ExportResult Export(Portion portion);
   }
}
