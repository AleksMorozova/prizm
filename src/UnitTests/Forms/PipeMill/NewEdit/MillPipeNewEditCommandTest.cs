using Data.DAL.Mill;
using Moq;
using NUnit.Framework;
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
            var repoPipe = new Mock<IPipeRepository>();

            var repoPlate = new Mock<IPlateRepository>();
            var repoHeat = new Mock<IHeatRepository>();
            var repoPurchaseOrder = new Mock<IPurchaseOrderRepository>();
            var repoWeld = new Mock<IWeldRepository>();

            var viewModel = new MillPipeNewEditViewModel(
                repoPipe.Object,
                repoPlate.Object,
                repoHeat.Object,
                repoPurchaseOrder.Object,
                repoWeld.Object,
                Guid.Empty);

            var command = new MillPipeNewEditCommand(viewModel, repoPipe.Object);

            command.Execute();

            repoPipe.Verify(_ => _.BeginTransaction(), Times.Once());
            repoPipe.Verify(_ => _.Save(viewModel.Pipe), Times.Once());
            repoPipe.Verify(_ => _.Commit(), Times.Once());
            repoPipe.Verify(_ => _.Evict(viewModel.Pipe), Times.Once());
        }
    }
}
