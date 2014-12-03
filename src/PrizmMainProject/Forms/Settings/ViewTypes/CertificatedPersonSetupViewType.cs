using Domain.Entity;
using Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings.ViewTypes
{
   public abstract class CertificatedPersonSetupViewType : PersonSetupViewType
   {
       public abstract InspectorCertificate Certificate { get; set; }
   }
}
