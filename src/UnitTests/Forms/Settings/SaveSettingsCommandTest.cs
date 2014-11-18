using Data.DAL.Setup;
using Domain.Entity.Setup;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Forms.Settings
{
    [TestFixture]
    public class SaveSettingsCommandTest
    {
        [Test]
        public void TestSaveSettings()
        {
            var repo = new Mock<IMillPipeSizeTypeRepository>();
            repo.Setup(_ => _.GetAll()).Returns(new List<PipeMillSizeType>() { new PipeMillSizeType()});

            var viewModel = new SettingsViewModel(repo.Object);

            var command = new SaveSettingsCommand(viewModel, repo.Object);

            command.Execute();

            repo.Verify(_ => _.BeginTransaction(), Times.AtLeastOnce());
            repo.Verify(_ => _.SaveOrUpdate(viewModel.PipeMillSizeType[0]), Times.AtLeastOnce());
            repo.Verify(_ => _.Commit(), Times.AtLeastOnce());
            repo.Verify(_ => _.Evict(viewModel.PipeMillSizeType[0]), Times.AtLeastOnce());
        }
    }
}
