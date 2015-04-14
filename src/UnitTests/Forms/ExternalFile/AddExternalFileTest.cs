using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Prizm.Main.Forms;
using Prizm.Main.Documents;
using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Forms.ReleaseNote;
using Prizm.Main.Forms.ReleaseNote.NewEdit;
using Prizm.Data.DAL;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Domain.Entity;
using Prizm.Main.Common;
using System.IO;
using Prizm.Main.Security;
using Prizm.Domain.Entity.SimpleReleaseNote;

namespace Prizm.UnitTests.Forms.ExternalFile
{
    [TestFixture]
    public class AddExternalFileTest
    {
        [Test]
        public void AddFileToRailcar()
        {
            if (!Directory.Exists(Directories.FilesToAttachFolder))
            {
                Directory.CreateDirectory(Directories.FilesToAttachFolder);
                DirectoryInfo directoryInfo = new DirectoryInfo(Directories.FilesToAttachFolder);
                directoryInfo.Attributes |= FileAttributes.Hidden;
            }
            using (FileStream fs = System.IO.File.Create(Directories.FilesToAttachFolder + "test.txt"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                fs.Write(info, 0, info.Length);
            }

            var notify = new Mock<IUserNotify>();
            var view = new Mock<IModifiable>();
            var railcarRepo = new Mock<IRailcarRepository>();
            var simpleNoteRepo = new Mock<ISimpleNoteRepository>();
            var pipeRepo = new Mock<IPipeRepository>();
            var ctx = new Mock<ISecurityContext>();
            pipeRepo.Setup(x => x.GetStored()).Returns(new List<Pipe>() { new Pipe() });
            var repos = new Mock<IReleaseNoteRepositories>();
            repos.SetupGet(_ => _.PipeRepo).Returns(pipeRepo.Object);
            repos.SetupGet(_ => _.RailcarRepo).Returns(railcarRepo.Object);
            repos.SetupGet(_ => _.SimpleNoteRepo).Returns(simpleNoteRepo.Object);

            var fileRepo = new Mock<IFileRepository>();
            var projectRepo = new Mock<IProjectRepository>();
            var externalFilesRepo = new Mock<IExternalFilesRepositories>();
            projectRepo.Setup(x => x.GetSingle()).Returns(new Project());
            externalFilesRepo.SetupGet(_ => _.FileRepo).Returns(fileRepo.Object);
            externalFilesRepo.SetupGet(_ => _.ProjectRepo).Returns(projectRepo.Object);

            var fileViewModel = new ExternalFilesViewModel(externalFilesRepo.Object, notify.Object);
            
            fileViewModel.FilesToAttach.Add("test.txt", "test.txt");

            var viewModel = new ReleaseNoteViewModel(repos.Object, Guid.Empty, notify.Object, ctx.Object);
            viewModel.ModifiableView = new Mock<IModifiable>().Object;
            var validatable = new Mock<IValidatable>();
            validatable.Setup(x => x.Validate()).Returns(true);
            viewModel.validatableView = validatable.Object;
            viewModel.Railcar.Number = "Test Railcar";
            viewModel.Number = "Test Railcar";
            viewModel.Date = DateTime.Now;
            viewModel.ModifiableView = view.Object;
            viewModel.FilesFormViewModel = fileViewModel;
            viewModel.Railcar.Pipes.Add(new SimplePipe());
            var command = new SaveReleaseNoteCommand(viewModel, repos.Object, notify.Object, ctx.Object);

            command.Execute();

            repos.Verify(_ => _.BeginTransaction(), Times.Once());
            simpleNoteRepo.Verify(_ => _.SaveOrUpdate(It.IsAny<SimpleNote>()), Times.Once());
            repos.Verify(_ => _.Rollback(), Times.AtMostOnce());
            repos.Verify(_ => _.Commit(), Times.Once());
            simpleNoteRepo.Verify(_ => _.Evict(It.IsAny<SimpleNote>()), Times.Once());

            if (Directory.Exists(Directories.TargetPath))
            {
                Directory.Delete(Directories.TargetPath, true);
            }
        }
    }
}
