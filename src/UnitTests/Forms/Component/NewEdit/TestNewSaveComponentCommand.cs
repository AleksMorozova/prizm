using Data.DAL.Construction;
using Data.DAL.Mill;
using Domain.Entity.Construction;
using Moq;
using NUnit.Framework;
using PrizmMain.Documents;
using PrizmMain.Forms;
using PrizmMain.Forms.Component;
using PrizmMain.Forms.Component.NewEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Forms.Component.NewEdit
{
    [TestFixture]
    class TestNewSaveComponentCommand
    {
        [Test]
        public void TestNewSaveComponent()
        {
            var modifiableView = new Mock<IModifiable>();
            var notify = new Mock<IUserNotify>();


            var componentRepo = new Mock<IComponentRepository>();
            var componentTypeRepo = new Mock<IComponentTypeRepository>();
            var repoInspector = new Mock<IInspectorRepository>();

            var component = new Domain.Entity.Construction.Component();

            componentRepo.Setup(x => x.GetActiveByNumber(component)).Returns(new List<Domain.Entity.Construction.Component>());
            componentTypeRepo.Setup(x => x.GetAll()).Returns(new List<ComponentType>());
            componentTypeRepo.Setup(x => x.GetAll()).Returns(new List<ComponentType>());

            var componentsRepos = new Mock<IComponentRepositories>();

            componentsRepos.SetupGet(_ => _.ComponentRepo).Returns(componentRepo.Object);
            componentsRepos.SetupGet(_ => _.ComponentTypeRepo).Returns(componentTypeRepo.Object);
            componentsRepos.SetupGet(_ => _.RepoInspector).Returns(repoInspector.Object);


            modifiableView.SetupGet(x => x.IsModified).Returns(false);



            var viewModel = new ComponentNewEditViewModel(
                componentsRepos.Object,
                Guid.Empty,
                notify.Object);

            viewModel.Component = component;
            viewModel.ModifiableView = modifiableView.Object;

            var command = new NewSaveComponentCommand(
                viewModel,
                componentsRepos.Object,
                notify.Object);

            command.Execute();

            componentsRepos.Verify(_ => _.BeginTransaction(), Times.Once());
            componentRepo.Verify(_ => _.SaveOrUpdate(It.IsAny<Domain.Entity.Construction.Component>()), Times.Once());
            componentsRepos.Verify(_ => _.Commit(), Times.Once());
            componentRepo.Verify(_ => _.Evict(It.IsAny<Domain.Entity.Construction.Component>()), Times.Once());
        }
    }
}
