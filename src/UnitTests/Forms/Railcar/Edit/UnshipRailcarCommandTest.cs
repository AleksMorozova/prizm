using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using Moq;
using NUnit.Framework;
using Prizm.Main.Forms;
using Prizm.Main.Forms.Railcar;
using Prizm.Main.Forms.Railcar.NewEdit;
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
        Mock<IRailcarRepositories> repos;
        Mock<IPipeRepository> pipeRepo;
        Mock<IRailcarRepository> carRepo;
        RailcarViewModel viewModel;
        UnshipRailcarCommand command;
        Mock<IUserNotify> notify; 

        [Test]
        public void UnshipRailcarCommand()
        {
            notify = new Mock<IUserNotify>();
            repos = new Mock<IRailcarRepositories>();
            pipeRepo = new Mock<IPipeRepository>();
            carRepo = new Mock<IRailcarRepository>();
            var ctx = new Mock<ISecurityContext>();

            pipeRepo.Setup(x => x.GetStored()).Returns(new List<Pipe>() { new Pipe() });
            repos.SetupGet(_ => _.PipeRepo).Returns(pipeRepo.Object);
            repos.SetupGet(_ => _.RailcarRepo).Returns(carRepo.Object);


            viewModel = new RailcarViewModel(repos.Object, Guid.Empty, notify.Object, ctx.Object);
            viewModel.Railcar.Number = "Railcar";
            command = new UnshipRailcarCommand(viewModel, repos.Object, notify.Object, ctx.Object);

            command.Execute();

            Assert.That(viewModel.Railcar.ShippingDate, Is.EqualTo(DateTime.MinValue));

        }
    }
}
