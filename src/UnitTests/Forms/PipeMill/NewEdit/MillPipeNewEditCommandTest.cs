using Data.DAL.Mill;
using Domain.Entity.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.PipeMill;
using PrizmMain.Forms.PipeMill.NewEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Forms.PipeMill.NewEdit
{
    [TestFixture]
    class MillPipeNewEditCommandTest
    {
        [Test]
        public void TestMillPipeNewEdit()
        {
            var repoMill = new Mock<IMillRepository>();
            var repoPipe = new Mock<IPipeRepository>();

            var viewModel = new MillPipeNewEditViewModel(
                repoMill.Object,
                Guid.Empty);

            var command = new MillPipeNewEditCommand(viewModel, repoPipe.Object);

            command.Execute();

            repoPipe.Verify(_ => _.BeginTransaction(), Times.Once());
            repoPipe.Verify(_ => _.Save(It.IsAny<Pipe>()), Times.Once());
            repoPipe.Verify(_ => _.Commit(), Times.Once());
            repoPipe.Verify(_ => _.Evict(It.IsAny<Pipe>()), Times.Once());
        }
    }
}
