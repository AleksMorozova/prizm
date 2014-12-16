using Data.DAL.Construction;
using Data.DAL.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Documents;
using PrizmMain.Forms;
using PrizmMain.Forms.Spool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Forms.Spool
{
    [TestFixture]
    class TestSaveSpoolCommand
    {
        [Test]
        public void TestSaveCommand()
        {
            var modifiableView = new Mock<IModifiable>();
            var notify = new Mock<IUserNotify>();

            var spoolRepo = new Mock<ISpoolRepository>();
            var pipeRepo = new Mock<IPipeRepository>();
            var inspectorRepo = new Mock<IInspectorRepository>();

            var spool = new Domain.Entity.Construction.Spool();

            spoolRepo.Setup(x => x.GetAvailablePipes()).Returns(new List<Domain.Entity.Mill.Pipe>());

            var spoolRepos = new Mock<ISpoolRepositories>();

            spoolRepos.SetupGet(_ => _.PipeRepo).Returns(pipeRepo.Object);
            spoolRepos.SetupGet(_ => _.RepoInspector).Returns(inspectorRepo.Object);
            spoolRepos.SetupGet(_ => _.SpoolRepo).Returns(spoolRepo.Object);


            modifiableView.SetupGet(x => x.IsModified).Returns(false);


            var viewModel = new SpoolViewModel(
                spoolRepos.Object,
                notify.Object);

            viewModel.Spool = spool;
            viewModel.ModifiableView = modifiableView.Object;

            var command = new SaveSpoolCommand(
                viewModel,
                spoolRepos.Object,
                notify.Object);

            command.Execute();

            spoolRepos.Verify(_ => _.BeginTransaction(), Times.Once());
            spoolRepo.Verify(_ => _.SaveOrUpdate(It.IsAny<Domain.Entity.Construction.Spool>()), Times.Once());
            spoolRepos.Verify(_ => _.Commit(), Times.Once());
            spoolRepo.Verify(_ => _.Evict(It.IsAny<Domain.Entity.Construction.Spool>()), Times.Once());
        }
    }
}
