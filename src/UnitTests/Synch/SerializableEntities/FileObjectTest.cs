using Moq;
using NUnit.Framework;
using Prizm.Domain.Entity;
using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Synch.SerializableEntities
{
   [TestFixture]
   public class FileObjectTest
   {
      Guid id = Guid.NewGuid();
      const string FILE_NAME = "FILE_NAME";
      const string DESCRIPTION = "DESCRIPTION";
      DateTime UPLOAD_DATE = DateTime.Now;
      const string NEW_NAME = "NEW_NAME";
      
      File SetupMock()
      {
         Mock<File> moq = new Mock<File>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.FileName, FILE_NAME);
         moq.SetupProperty(_ => _.IsActive, true);
         moq.SetupProperty(_ => _.NewName, NEW_NAME);
         moq.SetupProperty(_ => _.UploadDate, UPLOAD_DATE);
         moq.SetupProperty(_ => _.Description, DESCRIPTION);

         return moq.Object;
      }

      void AssertFile(FileObject file)
      {
         Assert.AreEqual(id, file.Id);
         Assert.IsTrue(file.IsActive);
         Assert.AreEqual(FILE_NAME, file.FileName);
         Assert.AreEqual(NEW_NAME, file.NewName);
         Assert.AreEqual(UPLOAD_DATE, file.UploadDate);
         Assert.AreEqual(DESCRIPTION, file.Description);
      }
      
      [Test]
      public void TestFileObjectCopyConstructor()
      {
         FileObject f = new FileObject(SetupMock());

         AssertFile(f);
      }

      [Test]
      public void TestFileObjectCasting()
      {
         FileObject f = SetupMock();

         AssertFile(f);
      }

   }
}
