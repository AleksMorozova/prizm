using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings.ViewTypes
{
   public abstract class CertificatedPersonSetupViewType : PersonSetupViewType
   {
      public abstract string Certificate { get; set; }
      public abstract DateTime? CertificateExpiration { get; set; }
   }
}
