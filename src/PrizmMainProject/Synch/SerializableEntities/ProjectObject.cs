using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Project")]
   public class ProjectObject
   {
      public ProjectObject()
      {
      }

      public ProjectObject(Project project)
      {
         this.Id = project.Id;
         this.IsActive = project.IsActive;
         this.Title = project.Title;
         this.Client = project.Client;
         this.MillName = project.MillName;
         this.DocumentSizeLimit = project.DocumentSizeLimit;
         this.WorkstationType = project.WorkstationType;
         this.MillPipeNumberMask = project.MillPipeNumberMask;
         this.MillPipeNumberMaskRegexp = project.MillPipeNumberMaskRegexp;
      }

      public static implicit operator ProjectObject(Project project)
      {
         return project != null ? new ProjectObject(project) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Title")]
      public string Title { get; set; }

      [XmlAttribute("Client")]
      public string Client { get; set; }

      [XmlAttribute("MillName")]
      public string MillName { get; set; }

      [XmlAttribute("DocumentSizeLimit")]
      public int DocumentSizeLimit { get; set; }

      [XmlAttribute("WorkstationType")]
      public WorkstationType WorkstationType { get; set; }

      [XmlAttribute("MillPipeNumberMask")]
      public string MillPipeNumberMask { get; set; }

      [XmlAttribute("MillPipeNumberMaskRegexp")]
      public string MillPipeNumberMaskRegexp { get; set; }

   }
}
