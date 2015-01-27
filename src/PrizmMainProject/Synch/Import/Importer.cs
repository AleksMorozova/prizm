using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Synch.Import
{
   public abstract class Importer : IImporter
   {
      protected readonly IHasher hasher;
      protected readonly IEncryptor encryptor;

      protected Importer(IHasher hasher, IEncryptor encryptor)
      {
         this.hasher = hasher;
         this.encryptor = encryptor;
      }

      public event Action<string> OnMessage;

      public event Action<int> OnProgress;

      public event Action<ImportException> OnError;

      public event Action<ConflictEventArgs> OnConflict;

      public event Action<MissingEventArgs> OnMissing;

      public event Action OnDone;

      protected void FireMessage(string msg)
      {
         if (OnMessage != null)
            OnMessage(msg);
      }

      protected void FireProgress(int progress)
      {
         if (OnProgress != null)
            OnProgress(progress);
      }

      protected ImportResult FireError(ImportException e)
      {
         if (OnError != null)
         {
            OnError(e);
            return ImportResult.Failed;
         }

         throw new ImportException(e.Message, e);
      }

      protected void FireConflict(ConflictEventArgs args)
      {
         if (OnConflict != null)
            OnConflict(args);
      }

      protected void FireMissing(MissingEventArgs args)
      {
          if (OnMissing != null)
              OnMissing(args);
      }

      protected void FireOnDone()
      {
         if (OnDone != null)
            OnDone();
      }

      protected bool ArchiveExists(string fileName)
      {
         return System.IO.File.Exists(fileName);
      }

      protected void UnzipContent(string archiveName, string tempDir)
      {
         ZipFile.ExtractToDirectory(archiveName, tempDir);
      }

      protected void ValidateChecksum(string fileName)
      {
         if (!System.IO.File.Exists(fileName))
         {
            throw new ImportException(string.Format("File {0} does not exists.", fileName));
         }

         string hashFileName = fileName + ".sha1";
         if (!System.IO.File.Exists(hashFileName))
         {
            throw new ImportException(string.Format("Hash file {0} does not exists.", hashFileName));
         }

         string hash = System.IO.File.ReadAllText(hashFileName);

         byte[] bytes;
         using (FileStream fs = new FileStream(fileName, FileMode.Open))
         {
            bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Close();
         }

         string actualHash = hasher.GetHash(bytes);

         if (actualHash != hash)
            throw new ImportException(string.Format("SHA-1 hashsum for file '{0}' does not match with actual.", fileName));
      }

      public abstract ImportResult Import(string archiveName);
   }
}
