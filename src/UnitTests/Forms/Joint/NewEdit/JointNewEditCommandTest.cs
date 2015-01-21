using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Prizm.Main.Documents;
using Prizm.Main.Forms;
using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Setup;
using Prizm.Data.DAL.Mill;
using Prizm.Main.Forms.Joint;
using Prizm.Main.Forms.Joint.NewEdit;
using Prizm.Data.DAL;
using Prizm.Domain.Entity.Setup;
using System.ComponentModel;
using Prizm.Main.Security;
using Prizm.Domain.Entity.Construction;

namespace Prizm.UnitTests.Forms.Joint.NewEdit
{

    [TestFixture]
    class JointNewEditCommandTest
    {
        [Test]
        public void TestJointNewEdit()
        {
            var modifiableView = new Mock<IModifiable>();
            var notify = new Mock<IUserNotify>();
            var repoJoint = new Mock<IJointRepository>();
            var repoJointTestResult = new Mock<IJointTestResultRepository>();
            var repoJointWeldResult = new Mock<IJointWeldResultRepository>();
            var repoJointOperation =  new Mock< IJointOperationRepository>();
            var repoInspector = new Mock<IInspectorRepository>();
            var repoWelder = new Mock<IWelderRepository>();
            var repoAdo = new Mock<IMillReportsRepository>();
            var securityCtx = new Mock<ISecurityContext>();
            var repoSpool = new Mock<ISpoolRepository>();
            var repoPipe = new Mock<IPipeRepository>();
            var repoComponent = new Mock<IComponentRepository>();

            var joint = new Prizm.Domain.Entity.Construction.Joint() { Status = Domain.Entity.Construction.JointStatus.Withdrawn};
            BindingList<JointOperation> operations = new BindingList<JointOperation>(); 

            Mock<IConstructionRepository> repoConstruction = new Mock<IConstructionRepository>();
            repoConstruction.SetupGet(_ => _.RepoJoint).Returns(repoJoint.Object);
            repoConstruction.SetupGet(_ => _.RepoJointTestResult).Returns(repoJointTestResult.Object);
            repoConstruction.SetupGet(_ => _.RepoJointWeldResult).Returns(repoJointWeldResult.Object);
            repoConstruction.SetupGet(_ => _.RepoJointOperation).Returns(repoJointOperation.Object);
            repoConstruction.SetupGet(_ => _.RepoInspector).Returns(repoInspector.Object);
            repoConstruction.SetupGet(_ => _.RepoWelder).Returns(repoWelder.Object);
            repoConstruction.SetupGet(_ => _.RepoSpool).Returns(repoSpool.Object);
            repoConstruction.SetupGet(_ => _.RepoPipe).Returns(repoPipe.Object);
            repoConstruction.SetupGet(_ => _.RepoComponent).Returns(repoComponent.Object);
            repoJointOperation.Setup(_ => _.GetControlOperations()).Returns(operations);
            repoJointOperation.Setup(_ => _.GetRepairOperations()).Returns(operations);
            repoJoint.Setup(_ => _.GetActiveByNumber(joint)).Returns(new List<Prizm.Domain.Entity.Construction.Joint>());
            repoSpool.Setup(_ => _.Get(It.IsAny<Guid>())).Returns(new Domain.Entity.Construction.Spool());


            modifiableView.SetupGet(x => x.IsModified).Returns(false);

            var viewModel = new JointNewEditViewModel(repoConstruction.Object, notify.Object, Guid.Empty, repoAdo.Object, securityCtx.Object);
            viewModel.Joint = joint;
            viewModel.FirstElement = new PartData();
            viewModel.SecondElement = new PartData();
            viewModel.ModifiableView = modifiableView.Object;
            var validatable = new Mock<IValidatable>();
            validatable.Setup(x => x.Validate()).Returns(true);
            viewModel.ValidatableView = validatable.Object;

            var command = new SaveJointCommand(repoConstruction.Object,viewModel, notify.Object, securityCtx.Object);
            command.Execute();
            repoConstruction.Verify(_ => _.BeginTransaction(), Times.Once());
            repoJoint.Verify(_ => _.SaveOrUpdate(It.IsAny<Prizm.Domain.Entity.Construction.Joint>()), Times.Once());
            repoConstruction.Verify(_ => _.Commit(), Times.Once());
            repoJoint.Verify(_ => _.Evict(It.IsAny<Prizm.Domain.Entity.Construction.Joint>()), Times.Once());
        }
    }
}
