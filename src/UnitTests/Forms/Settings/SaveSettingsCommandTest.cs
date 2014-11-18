using Data.DAL.Setup;
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
            var viewModel = new SettingsViewModel(repo.Object);

            var command = new SaveSettingsCommand(viewModel, repo.Object);

            //command.Execute();

            //repo.Verify(_ => _.BeginTransaction(), Times.Once());
            //repo.Verify(_ => _.Save(viewModel.CurrentPipeMillSizeType), Times.Once());
            //repo.Verify(_ => _.Commit(), Times.Once());
            //repo.Verify(_ => _.Evict(viewModel.CurrentPipeMillSizeType), Times.Once());
        }
    }
}
