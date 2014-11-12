using Data.DAL.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Railcar.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Forms.Railcar.Search
{
    [TestFixture]
    public class SearchRailcarCommandTest
    {
        public void TestSearchRailcar() 
        {
            var repo = new Mock<IRailcarRepository>();
            var viewModel = new RailcarSearchViewModel(repo.Object);

            var command = new SearchRailcarCommand(viewModel, repo.Object);

          

            command.Execute();
            //need to install nHibernate package for create Criteria
            //repo.Verify(_ => _.GetByCriteria(), Times.Once); 
        }
    }
}
