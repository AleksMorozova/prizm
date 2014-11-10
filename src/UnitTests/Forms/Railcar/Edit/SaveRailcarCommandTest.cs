using Domain.DAL;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Railcar.Edit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Forms.Railcar.Edit
{
   [TestFixture]
   public class SaveRailcarCommandTest
   {
      [Test]
      public void TestSaveRailcar()
      {
         Mock<IRailcarRepository> repo = new Mock<IRailcarRepository>();
         RailcarViewModel viewModel = new RailcarViewModel(repo.Object);

         SaveRailcarCommand command = new SaveRailcarCommand(viewModel, repo.Object);

         command.Execute();

         repo.Verify(_ => _.BeginTransaction(), Times.Once());
         repo.Verify(_ => _.Save(viewModel.Railcar), Times.Once());
         repo.Verify(_ => _.Commit(), Times.Once());
         repo.Verify(_ => _.Evict(viewModel.Railcar), Times.Once());
      }
   }
}
