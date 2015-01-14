using Ninject;
using Prizm.Data.DAL.Synch;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Properties;
using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.IO.Compression;

namespace Prizm.Main.Synch.Export
{
   [XmlType("MillData")]
   public class MillData
   {
      [XmlElement("Project")]
      public ProjectObject Project { get; set; }

      [XmlArray("Pipes")]
      public List<PipeObject> Pipes { get; set; }
   }

   public class MillExporter : Exporter, IDisposable
   {
      readonly IExportRepository exportRepo;

      [Inject]
      public MillExporter(IExportRepository exportRepo, IEncryptor encryptor, IHasher hasher) : base(encryptor, hasher)
      {
         this.exportRepo = exportRepo;
      }

      public IList<Portion> GetAllPortions()
      {
         return exportRepo.PortionRepo.GetAll();
      }

      public bool AnyNewDataToExport()
      {
         IList<Pipe> toExport = exportRepo.PipeRepo.GetPipesToExport();
         return toExport != null && toExport.Count > 0;
      }

      public override ExportResult Export()
      {
         IList<Pipe> pipesToExport = exportRepo.PipeRepo.GetPipesToExport();
         
         if (pipesToExport == null || pipesToExport.Count == 0)
         {
            return ExportResult.NothingToExport;
         }

         exportRepo.PortionRepo.BeginTransaction();

         Portion portion = new Portion();
         portion.ExportDateTime = DateTime.Now;

         foreach (var pipe in pipesToExport)
         {
            portion.Pipes.Add(pipe);
         }

         exportRepo.PortionRepo.SaveOrUpdate(portion);
         exportRepo.PortionRepo.Commit();

         return Export(portion);
      }

      MillData PrepareData(Portion portion, Project project)
      {
         MillData data = new MillData();
         data.Pipes = new List<PipeObject>();
         data.Project = project;

         foreach (var pipe in portion.Pipes)
         {
            data.Pipes.Add(new PipeObject(pipe));
         }
         return data;
      }

      void WriteAttachments(string tempDir, MillData data)
      {
         Directory.CreateDirectory(Path.Combine(tempDir, "Attachments"));

         foreach (PipeObject pipe in data.Pipes)
         {
            if (pipe.Attachments != null)
            {
               foreach (var att in pipe.Attachments)
               {
                  string destFile = Path.Combine(tempDir, "Attachments", att.NewName);
                  System.IO.File.Copy(Path.Combine(Environment.CurrentDirectory, "Data", "Attachments", att.NewName), destFile);
                  using (FileStream fs = new FileStream(destFile, FileMode.Open))
                  {
                     byte[] bytes = new byte[fs.Length];
                     fs.Read(bytes, 0, bytes.Length);
                     fs.Close();

                     System.IO.File.WriteAllText(destFile + ".sha1", hasher.GetHash(bytes));
                  }
               }
            }
            
         }
      }


      string CreateTempDir()
      {
         string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
         Directory.CreateDirectory(tempDir);
         return tempDir;
      }

      public override ExportResult Export(Portion portion)
      {
         try
         {
            FireMessage(Resources.Export_ReadingData);

            Project project = exportRepo.ProjectRepo.GetSingle();
            MillData data = PrepareData(portion, project);

            FireMessage(Resources.Export_CreateTempStorage);

            string tempDir = CreateTempDir();

            FireMessage(Resources.Export_WritingData);

            WriteManifest(tempDir, portion.Id, portion.ExportDateTime, project.WorkstationType);

            WriteData<MillData>(tempDir, data);

            WriteAttachments(tempDir, data);

            FireMessage(Resources.Export_CreatingArchive);

            ZipContent(tempDir);

            FireDone();

            exportRepo.PipeRepo.BeginTransaction();

            UnmarkPipes(portion);

            exportRepo.PipeRepo.Commit();
            
            return ExportResult.Success;
         }
         catch (Exception e)
         {
            return FireError(e);
         }
      }

      private void UnmarkPipes(Portion portion)
      {
         foreach (var p in portion.Pipes)
         {
            p.ToExport = false;
            exportRepo.PipeRepo.SaveOrUpdate(p);
         }
      }

      public void Dispose()
      {
         exportRepo.Dispose();
      }
   }
}
