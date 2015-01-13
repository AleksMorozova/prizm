using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using Prizm.UnitTests.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.Export
{
   public abstract class Exporter : IExporter
   {
      readonly protected IEncryptor encryptor;
      readonly protected IHasher hasher;

      protected Exporter(IEncryptor encryptor, IHasher hasher)
      {
         this.encryptor = encryptor;
         this.hasher = hasher;
      }


      public Action OnDone { get; set; }

      public Action<ExportException> OnError { get; set; }

      public Action<string> OnMessage { get; set; }

      public string ArchiveName { get; set; }

      public abstract ExportResult Export();

      public abstract ExportResult Export(Portion portion);

      protected void ZipContent(string tempDir)
      {
         if (ArchiveName == null)
            throw new ExportException("ArchiveName property should be set before exporting.");

         ZipFile.CreateFromDirectory(tempDir, ArchiveName);
      }

      protected void WriteData<T>(string tempDir, T data)
      {
         XmlSerializer serializer = new XmlSerializer(typeof(T));
         byte[] encryptedData;
         using (FileStream dataStream = new FileStream(Path.Combine(tempDir, "Data"), FileMode.CreateNew))
         {
            StringWriter sw = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sw);
            serializer.Serialize(sw, data);

            byte[] rawData = Encoding.Unicode.GetBytes(sw.ToString());
            encryptedData = encryptor.Encrypt(rawData, "^PRIZM_ENCRYPTION_KEY$");

            dataStream.Write(encryptedData, 0, encryptedData.Length);
         }

         System.IO.File.WriteAllText(Path.Combine(tempDir, "Data.sha1"), hasher.GetHash(encryptedData));
      }


      protected void WriteManifest(string tempDir, Guid portionId, DateTime exportDateTime, WorkstationType workstationType)
      {
         Manifest manifest = new Manifest();
         manifest.ExportDateTime = exportDateTime;
         manifest.PortionID = portionId;
         manifest.WorkstationType = workstationType;

         XmlSerializer serializer = new XmlSerializer(typeof(Manifest));
         byte[] encryptedData;
         using (FileStream dataStream = new FileStream(Path.Combine(tempDir, "Manifest"), FileMode.CreateNew))
         {
            StringWriter sw = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sw);
            serializer.Serialize(sw, manifest);

            byte[] rawData = Encoding.Unicode.GetBytes(sw.ToString());
            encryptedData = encryptor.Encrypt(rawData, "^PRIZM_ENCRYPTION_KEY$");

            dataStream.Write(encryptedData, 0, encryptedData.Length);
         }

         System.IO.File.WriteAllText(Path.Combine(tempDir, "Manifest.sha1"), hasher.GetHash(encryptedData));
      }
   }
}
