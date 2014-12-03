using Data.DAL;
using Data.DAL.Mill;
using Data.DAL.Setup;
using Domain.Entity.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms;
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
            var repoPipe = new Mock<IPipeRepository>();
            var notify = new Mock<IUserNotify>();
            var repoPlate = new Mock<IPlateRepository>();
            var repoHeat = new Mock<IHeatRepository>();
            var repoWeld = new Mock<IWeldRepository>();
            var repoPipeType = new Mock<IMillPipeSizeTypeRepository>();
            var repoPurchaseOrder = new Mock<IPurchaseOrderRepository>();
            var repoWelder = new Mock<IWelderRepository>();
            var repoPipeTestResult = new Mock<IPipeTestResultRepository>();
            var repoPipeTest = new Mock<IPipeTestRepository>();
            var repoInspector = new Mock<IInspectorRepository>();
            var repoProject = new Mock<IProjectRepository>();

            Mock<IMillRepository> millRepos = new Mock<IMillRepository>();
            millRepos.SetupGet(_ => _.RepoPipe).Returns(repoPipe.Object);
            millRepos.SetupGet(_ => _.RepoPlate).Returns(repoPlate.Object);
            millRepos.SetupGet(_ => _.RepoHeat).Returns(repoHeat.Object);
            millRepos.SetupGet(_ => _.RepoWeld).Returns(repoWeld.Object);
            millRepos.SetupGet(_ => _.RepoPipeType).Returns(repoPipeType.Object);
            millRepos.SetupGet(_ => _.RepoPurchaseOrder).Returns(repoPurchaseOrder.Object);
            millRepos.SetupGet(_ => _.WelderRepo).Returns(repoWelder.Object);
            millRepos.SetupGet(_ => _.RepoPipeTestResult).Returns(repoPipeTestResult.Object);
            millRepos.SetupGet(_ => _.RepoPipeTest).Returns(repoPipeTest.Object);
            millRepos.SetupGet(_ => _.RepoInspector).Returns(repoInspector.Object);
            millRepos.SetupGet(_ => _.RepoProject).Returns(repoProject.Object);



            var viewModel = new MillPipeNewEditViewModel(
                millRepos.Object,
                Guid.Empty, 
                notify.Object);

          

            var command = new NewSavePipeCommand(
                viewModel, 
                millRepos.Object, 
                notify.Object);

            command.Execute();

            millRepos.Verify(_ => _.BeginTransaction(), Times.Once());
            repoPipe.Verify(_ => _.SaveOrUpdate(It.IsAny<Pipe>()), Times.Once());
            millRepos.Verify(_ => _.Commit(), Times.Once());
            repoPipe.Verify(_ => _.Evict(It.IsAny<Pipe>()), Times.Once());
        }
    }
}
