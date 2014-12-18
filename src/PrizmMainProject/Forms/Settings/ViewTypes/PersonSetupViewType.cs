using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Settings.ViewTypes
{
   public abstract class PersonSetupViewType : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged = delegate { };

      protected void FirePropertyChanged(string prop)
      {
         PropertyChanged(this, new PropertyChangedEventArgs(prop));
      }

      public abstract String FirstName { get; set; }
      public abstract String LastName { get; set; }
      public abstract String MiddleName { get; set; }
      public abstract bool Active { get; set; }

      protected abstract void CheckName();
   }
}
