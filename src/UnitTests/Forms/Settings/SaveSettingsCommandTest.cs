using Data.DAL.Setup;
﻿using Data.DAL.Mill;
using Domain.Entity.Setup;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

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
            var repoWelders = new Mock<IWelderRepository>();
            var testSizeType = new PipeMillSizeType();
            var testWelder = new Welder();
            repoPipeSize.Setup(_ => _.GetAll()).Returns(new List<PipeMillSizeType>() { testSizeType });
            repoWelders.Setup(_ => _.GetAll()).Returns(new List<Welder>() { testWelder });

            Mock<ISettingsRepositories> settingsRepos = new Mock<ISettingsRepositories>();
            settingsRepos.SetupGet(_ => _.PipeSizeTypeRepo).Returns(repoPipeSize.Object);
            settingsRepos.SetupGet(_ => _.PipeTestRepo).Returns(repoPipeTests.Object);
            settingsRepos.SetupGet(_ => _.WelderRepo).Returns(repoWelders.Object);

            var viewModel = new SettingsViewModel(settingsRepos.Object);
            viewModel.LoadData();

            var command = new SaveSettingsCommand(viewModel, settingsRepos.Object);

            command.Execute();

            settingsRepos.Verify(_ => _.BeginTransaction(), Times.Once());
            repoPipeSize.Verify(_ => _.SaveOrUpdate(testSizeType), Times.Once());
            settingsRepos.Verify(_ => _.Commit(), Times.Once());
            repoPipeSize.Verify(_ => _.Evict(testSizeType), Times.Once());
            repoWelders.Verify(_ => _.SaveOrUpdate(testWelder), Times.Once());
            repoWelders.Verify(_ => _.Evict(testWelder), Times.Once());
        }
    }
}
