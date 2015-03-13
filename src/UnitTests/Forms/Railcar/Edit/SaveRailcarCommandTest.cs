using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using Moq;
using NUnit.Framework;
using Prizm.Main.Documents;
using Prizm.Main.Forms;
using Prizm.Main.Forms.ReleaseNote;
using Prizm.Main.Forms.ReleaseNote.NewEdit;
using System.Collections.Generic;
using System;
using Prizm.Main.Security;
using Prizm.Domain.Entity.SimpleReleaseNote;

namespace Prizm.UnitTests.Forms.Railcar.Edit
{
    [TestFixture]
    public class SaveRailcarCommandTest
    {
        [Test]
        public void TestSaveNewRailcar()
        {
            //FIX: Test was broken!
            var notify = new Mock<IUserNotify>();
            var view = new Mock<IModifiable>();
            var railcarRepo = new Mock<IRailcarRepository>();
            var pipeRepo = new Mock<IPipeRepository>();
            //pipeRepo.Setup(x => x.GetStored()).Returns(new List<SimplePipe>() { new SimplePipe() });
            var repos = new Mock<IReleaseNoteRepositories>();
            var ctx = new Mock<ISecurityContext>();
            repos.SetupGet(_ => _.PipeRepo).Returns(pipeRepo.Object);
            repos.SetupGet(_ => _.RailcarRepo).Returns(railcarRepo.Object);

            var viewModel = new ReleaseNoteViewModel(repos.Object, Guid.Empty, notify.Object,ctx.Object);
            viewModel.ModifiableView = new Mock<IModifiable>().Object;
            var validatable = new Mock<IValidatable>();
            validatable.Setup(x => x.Validate()).Returns(true);
            viewModel.validatableView = validatable.Object;
            viewModel.Railcar.Number = "Test Railcar";
            viewModel.ModifiableView = view.Object;
            viewModel.Railcar.Pipes.Add(new SimplePipe());
            var command = new SaveReleaseNoteCommand(viewModel, repos.Object, notify.Object, ctx.Object);

            command.Execute();

            repos.Verify(_ => _.BeginTransaction(), Times.Once());
            //railcarRepo.Verify(_ => _.SaveOrUpdate(viewModel.Railcar), Times.Once());
            repos.Verify(_ => _.Commit(), Times.Once());
            //railcarRepo.Verify(_ => _.Evict(viewModel.Railcar), Times.Once());
        }
    }
}