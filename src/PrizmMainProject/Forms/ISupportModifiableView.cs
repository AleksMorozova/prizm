using Prizm.Main.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms
{
   public interface ISupportModifiableView
   {
      IModifiable ModifiableView { get; set; }
   }
}
