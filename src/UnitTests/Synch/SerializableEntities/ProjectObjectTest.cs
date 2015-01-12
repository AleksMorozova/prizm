using Moq;
using NUnit.Framework;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Synch.SerializableEntities
{
   [TestFixture]
   public class ProjectObjectTest
   {
      Guid id = Guid.NewGuid();
      const string TITLE = "TITLE";
      const string CLIENT = "CLIENT";
      const string MILL_NAME = "MILL_NAME";
      const int DOC_SIZE_LIMIT = 30;
      const WorkstationType WORKSTATION_TYPE = WorkstationType.Mill;
      const string NUMBER_MASK = "MASK";
      const string NUMBER_MASK_REGEX = "MASK_REGEX";

      Project SetupMock()
      {
         Mock<Project> moq = new Mock<Project>();
         moq.SetupProperty(_ => _.Id, id);
         moq.SetupProperty(_ => _.Title, TITLE);
         moq.SetupProperty(_ => _.Client, CLIENT);
         moq.SetupProperty(_ => _.MillName, MILL_NAME);
         moq.SetupProperty(_ => _.DocumentSizeLimit, DOC_SIZE_LIMIT);
         moq.SetupProperty(_ => _.WorkstationType, WORKSTATION_TYPE);
         moq.SetupProperty(_ => _.MillPipeNumberMask, NUMBER_MASK);
         moq.SetupProperty(_ => _.MillPipeNumberMaskRegexp, NUMBER_MASK_REGEX);
         moq.SetupProperty(_ => _.IsActive, true);

         return moq.Object;
      }

      void AssertProject(ProjectObject project)
      {
         Assert.AreEqual(id, project.Id);
         Assert.IsTrue(project.IsActive);
         Assert.AreEqual(TITLE, project.Title);
         Assert.AreEqual(CLIENT, project.Client);
         Assert.AreEqual(MILL_NAME, project.MillName);
         Assert.AreEqual(DOC_SIZE_LIMIT, project.DocumentSizeLimit);
         Assert.AreEqual(WORKSTATION_TYPE, project.WorkstationType);
         Assert.AreEqual(NUMBER_MASK, project.MillPipeNumberMask);
         Assert.AreEqual(NUMBER_MASK_REGEX, project.MillPipeNumberMaskRegexp);
      }

      [Test]
      public void TestProjectObjectCopyConstructor()
      {
         ProjectObject project = new ProjectObject(SetupMock());

         AssertProject(project);
      }

      [Test]
      public void TestProjectObjectCasting()
      {
         ProjectObject project = SetupMock();

         AssertProject(project);
      }

   }
}
