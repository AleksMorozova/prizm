using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Settings.ViewTypes
{
   public abstract class CertificatedPersonSetupViewType : PersonSetupViewType
   {
       public abstract InspectorCertificate Certificate { get; set; }
   }
}
