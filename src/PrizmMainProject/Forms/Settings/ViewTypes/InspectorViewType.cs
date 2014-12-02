using Domain.Entity;
using Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings.ViewTypes
{
    public class InspectorViewType : PersonSetupViewType
   {
      readonly Inspector inspector;

      public InspectorViewType(Inspector inspector)
      {
         this.inspector = inspector;
      }

      public Inspector Inspector
      {
         get { return inspector; }
      }

      public InspectorViewType()
      {
         this.inspector = new Inspector();
         this.inspector.IsActive = true;
         CheckName();
         CheckCertificate();
      }

      public override string FirstName
      {
         get 
         {
            return inspector.Name.FirstName;
         }
         set
         {
            CheckName();
            if (value != inspector.Name.FirstName)
            {
               inspector.Name.FirstName = value;
               FirePropertyChanged("FirstName");
            }
         }
      }

      public override string LastName
      {
         get
         {
            return inspector.Name.LastName;
         }
         set
         {
            CheckName();
            if (value != inspector.Name.LastName)
            {
               inspector.Name.LastName = value;
               FirePropertyChanged("LastName");
            }
         }
      }

      public override string MiddleName
      {
         get
         {
            return inspector.Name.MiddleName;
         }
         set
         {
            CheckName();
            if (value != inspector.Name.MiddleName)
            {
               inspector.Name.MiddleName = value;
               FirePropertyChanged("MiddleName");
            }
         }
      }

      public IList<InspectorCertificate> Certificates
      {
         get
         {
            return inspector.Certificates;
         }
         set
         {
             CheckCertificate();
            if (value != inspector.Certificates)
            {
               inspector.Certificates = value;
               FirePropertyChanged("Certificate");
            }
         }
      }

      public override bool Active
      {
         get
         {
            return inspector.IsActive;
         }
         set
         {
            if (value != inspector.IsActive)
            {
               inspector.IsActive = value;
               FirePropertyChanged("Active");
            }
         }
      }

      protected override void CheckName()
      {
         if (inspector.Name == null)
            inspector.Name = new PersonName();
      }

      private void CheckCertificate()
      {
          if (inspector.Certificates == null)
          {
              inspector.Certificates = new BindingList<InspectorCertificate>();
          }
      }

      
   }
}
