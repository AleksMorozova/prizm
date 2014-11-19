﻿using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings.ViewTypes
{
   public class WelderViewType : CertificatedPersonSetupViewType
   {
      readonly Welder welder;
      
      public WelderViewType(Welder welder)
      {
         this.welder = welder;
      }

      public WelderViewType()
      {
         this.welder = new Welder();
         this.welder.IsActive = true;
         CheckName();
      }

      public override String FirstName
      {
         get
         {
            return welder.Name.FirstName;
         }
         set
         {
            CheckName();
            if (value != welder.Name.FirstName)
            {
               welder.Name.FirstName = value;
               FirePropertyChanged("FirstName");
            }
         }
      }

      public override String LastName
      {
         get
         {
            return welder.Name.LastName;
         }
         set
         {
            CheckName();
            if (value != welder.Name.LastName)
            {
               welder.Name.LastName = value;
               FirePropertyChanged("LastName");
            }
         }
      }

      public override String MiddleName
      {
         get
         {
            return welder.Name.MiddleName;
         }
         set
         {
            CheckName();
            if (value != welder.Name.MiddleName)
            {
               welder.Name.MiddleName = value;
               FirePropertyChanged("MiddleName");
            }
         }
      }

      public override string Certificate 
      { 
         get
         {
            return welder.Certificate;
         }
         set
         {
            if (value != welder.Certificate)
            {
               welder.Certificate = value;
               FirePropertyChanged("Certificate");
            }
         }
      }

      public override DateTime? CertificateExpiration
      {
         get
         {
            return welder.CertificateExpiration;
         }
         set
         {
            if (value != welder.CertificateExpiration)
            {
               welder.CertificateExpiration = value;
               FirePropertyChanged("CertificateExpiration");
            }
         }
      }

      public string Stamp
      {
         get
         {
            return welder.Stamp;
         }
         set
         {
            if (value != welder.Stamp)
            {
               welder.Stamp = value;
               FirePropertyChanged("Stamp");
            }
         }
      }

      public int Grade
      {
         get
         {
            return welder.Grade;
         }
         set
         {
            if (value != welder.Grade)
            {
               welder.Grade = value;
               FirePropertyChanged("Grade");
            }
         }
      }

      public override bool Active
      {
         get
         {
            return welder.IsActive;
         }
         set
         {
            if (value != welder.IsActive)
            {
               welder.IsActive = value;
               FirePropertyChanged("Active");
            }
         }
      }

      protected override void CheckName()
      {
         if (welder.Name == null)
            welder.Name = new PersonName();
      }

      public Welder Welder
      {
         get
         {
            return welder;
         }
      }

   }
   
}