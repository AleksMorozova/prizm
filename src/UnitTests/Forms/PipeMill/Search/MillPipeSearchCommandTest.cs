using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.DAL.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.PipeMill.Search;
using NHibernate.Criterion;

namespace UnitTests.Forms.PipeMill.Search
{
    [TestFixture]
    public class MillPipeSearchCommandTest
    {
        [Test]
        public void TestMillPipeSearchCommand()
        {
            var repo = new Mock<IPipeRepository>();

            var pipes = new List<Domain.Entity.Mill.Pipe>()
            {
                new Domain.Entity.Mill.Pipe {Number="test-1", Status="test-2"},
                new Domain.Entity.Mill.Pipe {Number="test-3", Status="test-4"}
            };

            repo.Setup(_ => _.GetByCriteria(It.IsAny<NHibernate.Criterion.DetachedCriteria>()))
                .Returns(pipes).Verifiable();

            var criteria = NHibernate.Criterion.DetachedCriteria
              .For<Domain.Entity.Mill.Pipe>()
              .Add(Restrictions.Like("Number", "test-1", MatchMode.Anywhere))
              .Add(Restrictions.Like("Status", "test-2", MatchMode.Anywhere));

            var viewModel = new MillPipeSearchViewModel(repo.Object);

            var command = new MillPipeSearchCommand(viewModel, repo.Object);



            command.Execute();



            repo.Verify(x => x.GetByCriteria(It.IsAny<DetachedCriteria>()), Times.Once());

            Assert.AreEqual(repo.Object.GetByCriteria(criteria), pipes);

        }

    }
}
