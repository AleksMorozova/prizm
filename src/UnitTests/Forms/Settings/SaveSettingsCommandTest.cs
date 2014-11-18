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
            
            var projectRepo = new Mock<Data.DAL.IProjectRepository>();
            projectRepo.Setup(_ => _.GetSingle()).Returns(new Domain.Entity.Project());

            var manufacturerRepo = new Mock<Data.DAL.Mill.IPlateManufacturerRepository>();
            manufacturerRepo.Setup(_ => _.GetAll()).Returns(new List<Domain.Entity.Mill.PlateManufacturer>() { new Domain.Entity.Mill.PlateManufacturer() });

            var viewModel = new SettingsViewModel(repo.Object, projectRepo.Object, manufacturerRepo.Object);

            var command = new SaveSettingsCommand(viewModel, repo.Object, projectRepo.Object, manufacturerRepo.Object);

            command.Execute();

            repo.Verify(_ => _.BeginTransaction(), Times.AtLeastOnce());
            repo.Verify(_ => _.SaveOrUpdate(viewModel.PipeMillSizeType[0]), Times.AtLeastOnce());
            repo.Verify(_ => _.Commit(), Times.AtLeastOnce());
            repo.Verify(_ => _.Evict(viewModel.PipeMillSizeType[0]), Times.AtLeastOnce());

            manufacturerRepo.Verify(_ => _.BeginTransaction(), Times.AtLeastOnce());
            manufacturerRepo.Verify(_ => _.SaveOrUpdate(viewModel.PlateManufacturers[0]), Times.AtLeastOnce());
            manufacturerRepo.Verify(_ => _.Commit(), Times.AtLeastOnce());
            manufacturerRepo.Verify(_ => _.Evict(viewModel.PlateManufacturers[0]), Times.AtLeastOnce());

            projectRepo.Verify(_ => _.BeginTransaction(), Times.AtLeastOnce());
            projectRepo.Verify(_ => _.SaveOrUpdate(viewModel.CurrentProjectSettings), Times.AtLeastOnce());
            projectRepo.Verify(_ => _.Commit(), Times.AtLeastOnce());
            projectRepo.Verify(_ => _.Evict(viewModel.CurrentProjectSettings), Times.AtLeastOnce());

        }
    }
}
