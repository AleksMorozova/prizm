using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Prizm.Main.Documents;
using Prizm.Main.Forms;
using Prizm.Data.DAL.Mill;
using Prizm.Main.Forms.Parts.Inspection;
using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL;
using NHibernate;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Common;
using Prizm.Main.Security;

namespace Prizm.UnitTests.Forms.Parts
{
    [TestFixture]
    public class SaveInspectionTestResultsCommandTest
    {
        [Test]
        public void TestSaveInspectionTestResults()
        {
            var session = new Mock<ISession>();
            var notify = new Mock<IUserNotify>();
            var repoInspector = new Mock<IInspectorRepository>();
            var repoPipe = new Mock<IPipeRepository>();
            var repoSpool =  new Mock<ISpoolRepository>();
            var repoComponent = new Mock<IComponentRepository>();
            var repoInspectionTestResult = new Mock<IInspectionTestResultRepository>();
            var modifiableView = new Mock<IModifiable>();
            var ctx = new Mock<ISecurityContext>();

            Mock<IPartInspectionRepository> repos = new Mock<IPartInspectionRepository>();
            repos.SetupGet(_ => _.RepoComponent).Returns(repoComponent.Object);
            repos.SetupGet(_ => _.RepoInspectionTestResult).Returns(repoInspectionTestResult.Object);
            repos.SetupGet(_ => _.RepoInspector).Returns(repoInspector.Object);
            repos.SetupGet(_ => _.RepoPipe).Returns(repoPipe.Object);
            repos.SetupGet(_ => _.RepoSpool).Returns(repoSpool.Object);

            List<InspectionTestResult> list = new List<InspectionTestResult>() { new InspectionTestResult() };
            var viewModel = new PartInspectionViewModel(session.Object, repos.Object, notify.Object, ctx.Object);
            viewModel.ModifiableView = modifiableView.Object;
            list.Add(new InspectionTestResult());
            Pipe part = new Pipe() { InspectionTestResults = list};
            Main.Forms.Parts.Search.Part notConverted = new Main.Forms.Parts.Search.Part()
            {
                Id = part.Id,
                Type = new EnumWrapper<PartType>() { Value = PartType.Pipe }
            };
            repoInspectionTestResult.Setup(_ => _.GetByPartId(notConverted.Id)).Returns(list);
            viewModel.SelectedElement = notConverted;
            var command = new SaveInspectionTestResultsCommand(repoInspectionTestResult.Object, viewModel, notify.Object, ctx.Object);
            command.Execute();
            repoInspectionTestResult.Verify(_ => _.BeginTransaction(), Times.Once);
            repoInspectionTestResult.Verify(_ => _.SaveOrUpdate(It.IsAny<InspectionTestResult>()), Times.AtLeastOnce);

        }
    }
}
