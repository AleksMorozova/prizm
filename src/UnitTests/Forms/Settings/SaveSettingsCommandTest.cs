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
            var repoPipeSize = new Mock<IMillPipeSizeTypeRepository>();
            var repoPipeTests = new Mock<IPipeTestRepository>();
            var viewModel = new SettingsViewModel(repoPipeSize.Object, repoPipeTests.Object);

            var command = new SaveSettingsCommand(viewModel, repoPipeSize.Object);

            command.Execute();

            repoPipeSize.Verify(_ => _.BeginTransaction(), Times.Once());
            repoPipeSize.Verify(_ => _.Save(viewModel.CurrentPipeMillSizeType), Times.Once());
            repoPipeSize.Verify(_ => _.Commit(), Times.Once());
            repoPipeSize.Verify(_ => _.Evict(viewModel.CurrentPipeMillSizeType), Times.Once());
        }
    }
}
