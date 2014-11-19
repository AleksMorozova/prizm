using Data.DAL.Mill;
using Domain.Entity.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Railcar.NewEdit;
using System.Collections.Generic;

namespace UnitTests.Forms.Railcar.Edit
{
    [TestFixture]
    public class SaveRailcarCommandTest
    {
        [Test]
        public void TestSaveNewRailcar()
        {
            var repo = new Mock<IRailcarRepository>();
            
            var pipeRepo = new Mock<IPipeRepository>();
            
            pipeRepo.Setup(x => x.GetAll()).Returns(new List<Pipe>() { new Pipe() });

            var viewModel = new RailcarViewModel(repo.Object, pipeRepo.Object,"");

            var command = new SaveRailcarCommand(viewModel, repo.Object);

            command.Execute();

            repo.Verify(_ => _.BeginTransaction(), Times.Once());
            repo.Verify(_ => _.SaveOrUpdate(viewModel.Railcar), Times.Once());
            repo.Verify(_ => _.Commit(), Times.Once());
            repo.Verify(_ => _.Evict(viewModel.Railcar), Times.Once());
        }
    }
}