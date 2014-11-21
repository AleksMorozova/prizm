using Data.DAL.Mill;
using Domain.Entity.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Railcar;
using PrizmMain.Forms.Railcar.NewEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Forms.Railcar.Edit
{
    [TestFixture]
    public class UnshipRailcarCommandTest
    {
        Domain.Entity.Mill.Railcar railcar;
        Mock<IRailcarRepositories> repos;
        Mock<IPipeRepository> pipeRepo;
        Mock<IRailcarRepository> carRepo;
        RailcarViewModel viewModel;
        UnshipRailcarCommand command;

        [SetUp]
        public void Init()
        {
            railcar = new Domain.Entity.Mill.Railcar()
            {
                Number = "Test Railcar",


            };

            pipeRepo.Setup(x => x.GetStored()).Returns(new List<Pipe>() { new Pipe() });
            repos.SetupGet(_ => _.PipeRepo).Returns(pipeRepo.Object);
            repos.SetupGet(_ => _.RailcarRepo).Returns(carRepo.Object);

            var viewModel = new RailcarViewModel(repos.Object, "");
            viewModel.Railcar.Number = "Test Railcar";
            viewModel.Railcar.Pipes.Add(new Pipe());
            var command = new SaveRailcarCommand(viewModel, repos.Object);
        }


        [Test]
        public void UnshipCommandShouldResetShippingDate()
        {
          
        }

        [Test]
        public void UnshipCommandShouldChangePipeStatus()
        {

        }

    }
}
