using Prizm.Data.DAL.Mill;
using Moq;
using NHibernate.Criterion;
using NUnit.Framework;
using Prizm.Main.Forms;
using Prizm.Main.Forms.Railcar.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Transform;

namespace Prizm.UnitTests.Forms.Railcar.Search
{
    [TestFixture]
    public class SearchRailcarCommandTest
    {
        [Test]
        public void RailcarSearchTest() 
        {
            var iQuery = new Mock<IQuery>();
            var iSQLQuery = new Mock<ISQLQuery>();
            var notify = new Mock<IUserNotify>();

            Mock<IReleaseNoteRepository> repo = new Mock<IReleaseNoteRepository>();

            var railcars = new List<Prizm.Domain.Entity.Mill.Railcar>();
            {
                new Prizm.Domain.Entity.Mill.Railcar { Number = "Test1" };
                new Prizm.Domain.Entity.Mill.Railcar { Number = "Test2" };
            };


            var viewModel = new RailcarSearchViewModel(repo.Object, notify.Object);
            viewModel.RailcarNumber = "Test";

            iQuery.Setup(x => x.List<Prizm.Domain.Entity.Mill.Railcar>())
                .Returns(railcars).Verifiable();

            iSQLQuery.Setup(x => x.SetResultTransformer(It.IsAny<IResultTransformer>()))
                .Returns(iQuery.Object).Verifiable();

            repo.Setup(x => x.CreateSQLQuery(It.IsAny<string>()))
                .Returns(iSQLQuery.Object).Verifiable();

            var command = new SearchRailcarCommand(viewModel, repo.Object, notify.Object);

            command.Execute();

            repo.Verify(x => x.CreateSQLQuery(It.IsAny<string>()), Times.Once());

            Assert.AreEqual(
                repo.Object
                .CreateSQLQuery(It.IsAny<string>())
                .SetResultTransformer(It.IsAny<IResultTransformer>())
                .List<Prizm.Domain.Entity.Mill.Railcar>(), railcars);

        }
    }
}
