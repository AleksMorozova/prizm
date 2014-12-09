using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL.Setup;
using Data.DAL.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.PipeMill.Search;
using PrizmMain.Forms.PipeMill;
using NHibernate.Criterion;
using Domain.Entity.Setup;

namespace UnitTests.Forms.PipeMill.Search
{
    [TestFixture]
    public class MillPipeSearchCommandTest
    {
        [Test]
        public void TestMillPipeSearchCommand()
        {
            var repoPipe = new Mock<IPipeRepository>();
            var repoPlate = new Mock<IPlateRepository>();
            var repoHeat = new Mock<IHeatRepository>();
            var repoWeld = new Mock<IWeldRepository>();
            var repoPipeType = new Mock<IMillPipeSizeTypeRepository>();
            var repoPurchaseOrder = new Mock<IPurchaseOrderRepository>();
            var repoWelder = new Mock<IWelderRepository>();
            var repoPipeTestResult = new Mock<IPipeTestResultRepository>();
            var repoPipeTest = new Mock<IPipeTestRepository>();
            var repoInspector = new Mock<IInspectorRepository>();

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

            var pipes = new List<Domain.Entity.Mill.Pipe>();
            {
                new Domain.Entity.Mill.Pipe { Number = "test-1" };
                new Domain.Entity.Mill.Pipe { Number = "test-3" };
            };

             repoPipe.Setup(_ => _.GetByCriteria(It.IsAny<NHibernate.Criterion.DetachedCriteria>()))
                .Returns(pipes).Verifiable();

            var criteria = NHibernate.Criterion.DetachedCriteria
              .For<Domain.Entity.Mill.Pipe>()
              .Add(Restrictions.Like("Number", "test-1", MatchMode.Anywhere));



            var viewModel = new MillPipeSearchViewModel(millRepos.Object);
            viewModel.PipeNumber = "Test Number";
            viewModel.CheckedPipeTypes = new List<PipeMillSizeType>();


            var command = new MillPipeSearchCommand(viewModel, repoPipe.Object);



            command.Execute();



            repoPipe.Verify(x => x.GetByCriteria(It.IsAny<DetachedCriteria>()), Times.Once());

            Assert.AreEqual(repoPipe.Object.GetByCriteria(criteria), pipes);

        }

    }
}
