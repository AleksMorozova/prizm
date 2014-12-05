using Data.DAL.Setup;
using Data.DAL.Mill;
using Data.DAL;
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
using Domain.Entity.Mill;
using PrizmMain.Forms;
using PrizmMain.Documents;


namespace UnitTests.Forms.Settings
{
    [TestFixture]
    public class SaveSettingsCommandTest
    {
        [Test]
        public void TestSaveSettings()
        {
            var notify = new Mock<IUserNotify>();

            var modifiableView = new Mock<IModifiable>();

            var repoPipeSize = new Mock<IMillPipeSizeTypeRepository>();
            var repoPipeTests = new Mock<IPipeTestRepository>();
            var repoWelders = new Mock<IWelderRepository>();
            var repoInspectors = new Mock<IInspectorRepository>();
            var repoManufacturers = new Mock<IPlateManufacturerRepository>();
            var repoProjectSetting = new Mock<IProjectRepository>();

            var repoCategory = new Mock<ICategoryRepository>();
            
            var testProjectSetting = new Project();
            var testSizeType = new PipeMillSizeType();
            var testWelder = new Welder();
            var testManufacturer = new PlateManufacturer();
            var testInspector = new Inspector();

            repoPipeSize.Setup(_ => _.GetAll()).Returns(new List<PipeMillSizeType>() { testSizeType });
            repoWelders.Setup(_ => _.GetAll()).Returns(new List<Welder>() { testWelder });
            repoManufacturers.Setup(_ => _.GetAll()).Returns(new List<PlateManufacturer>() { testManufacturer });
            repoProjectSetting.Setup(_ => _.GetSingle()).Returns(testProjectSetting);
            repoInspectors.Setup(_ => _.GetAll()).Returns(new List<Inspector>() { testInspector });

            repoCategory.Setup(x => x.GetAll()).Returns(new List<Category>() { new Category() });

            Mock<ISettingsRepositories> settingsRepos = new Mock<ISettingsRepositories>();
            settingsRepos.SetupGet(_ => _.PipeSizeTypeRepo).Returns(repoPipeSize.Object);
            settingsRepos.SetupGet(_ => _.PipeTestRepo).Returns(repoPipeTests.Object);
            settingsRepos.SetupGet(_ => _.WelderRepo).Returns(repoWelders.Object);
            settingsRepos.SetupGet(_ => _.PlateManufacturerRepo).Returns(repoManufacturers.Object);
            settingsRepos.SetupGet(_ => _.ProjectRepo).Returns(repoProjectSetting.Object);
            settingsRepos.SetupGet(_ => _.InspectorRepo).Returns(repoInspectors.Object);
            settingsRepos.SetupGet(x => x.СategoryRepo).Returns(repoCategory.Object);

            modifiableView.SetupGet(x => x.IsModified).Returns(false);


            var viewModel = new SettingsViewModel(settingsRepos.Object, notify.Object);

            viewModel.LoadData();
            viewModel.ModifiableView = modifiableView.Object;

            var command = new SaveSettingsCommand(viewModel, settingsRepos.Object, notify.Object);

            command.Execute();

            settingsRepos.Verify(_ => _.BeginTransaction(), Times.Once());
            repoPipeSize.Verify(_ => _.SaveOrUpdate(testSizeType), Times.Once());
            settingsRepos.Verify(_ => _.Commit(), Times.Once());
            repoPipeSize.Verify(_ => _.Evict(testSizeType), Times.Once());
            repoWelders.Verify(_ => _.SaveOrUpdate(testWelder), Times.Once());
            repoWelders.Verify(_ => _.Evict(testWelder), Times.Once());
            repoManufacturers.Verify(_ => _.SaveOrUpdate(testManufacturer), Times.Once());
            repoManufacturers.Verify(_ => _.Evict(testManufacturer), Times.Once());
            repoProjectSetting.Verify(_ => _.SaveOrUpdate(testProjectSetting), Times.Once());
            repoProjectSetting.Verify(_ => _.Evict(testProjectSetting), Times.Once());
            repoInspectors.Verify(_ => _.SaveOrUpdate(testInspector), Times.Once());
            repoInspectors.Verify(_ => _.Evict(testInspector), Times.Once());
        }
    }
}
