using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using Moq;
using NUnit.Framework;
using Prizm.Main.Forms;
using Prizm.Main.Forms.ReleaseNote;
using Prizm.Main.Forms.ReleaseNote.NewEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prizm.Main.Security;

namespace Prizm.UnitTests.Forms.Railcar.Edit
{
    [TestFixture]
    public class UnshipRailcarCommandTest
    {
        Mock<IReleaseNoteRepositories> repos;
        Mock<IPipeRepository> pipeRepo;
        Mock<IRailcarRepository> carRepo;
        ReleaseNoteViewModel viewModel;
        UnshipReleaseNoteCommand command;
        Mock<IUserNotify> notify; 

        [Test]
        public void UnshipRailcarCommand()
        {
            notify = new Mock<IUserNotify>();
            repos = new Mock<IReleaseNoteRepositories>();
            pipeRepo = new Mock<IPipeRepository>();
            carRepo = new Mock<IRailcarRepository>();
            var ctx = new Mock<ISecurityContext>();

            pipeRepo.Setup(x => x.GetStored()).Returns(new List<Pipe>() { new Pipe() });
            repos.SetupGet(_ => _.PipeRepo).Returns(pipeRepo.Object);
            repos.SetupGet(_ => _.RailcarRepo).Returns(carRepo.Object);


            viewModel = new ReleaseNoteViewModel(repos.Object, Guid.Empty, notify.Object, ctx.Object);
            viewModel.Railcar.Number = "Railcar";
            command = new UnshipReleaseNoteCommand(viewModel, repos.Object, notify.Object, ctx.Object);

            command.Execute();

        }
    }
}
