using Prizm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Attachment")]
   public class FileObject
   {
      public FileObject()
      {
      }

      public FileObject(File file)
      {
         this.Id = file.Id;
         this.IsActive = file.IsActive;
         this.FileName = file.FileName;
         this.Description = file.Description;
         this.UploadDate = file.UploadDate;
         this.NewName = file.NewName;
      }

      public static implicit operator FileObject(File f)
      {
         return f != null ? new FileObject(f) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("FileName")]
      public string FileName { get; set; }

      [XmlAttribute("Description")]
      public string Description { get; set; }

      [XmlAttribute("UploadDate")]
      public DateTime UploadDate { get; set; }

      [XmlAttribute("NewName")]
      public string NewName { get; set; }

   }
}
