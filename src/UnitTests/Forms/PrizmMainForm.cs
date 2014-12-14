using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Data.DAL.Hibernate;
using Data.DAL;
using PrizmMain.Forms.MainChildForm;
using Domain.Entity;

namespace UnitTests.Forms
{
    [TestFixture]
    public class GetOrCreateProjectTest
    {
        [Test]
        public void GetORCreateProjectTest()
        {
            var projectRepo = new Mock<IProjectRepository>();
            Project nullProject = null;
            var viewModel = new PrizmApplicationViewModel(projectRepo.Object);
            projectRepo.Setup(_ => _.GetSingle()).Returns(nullProject);
            //viewModel.GetOrCreateProject();
            projectRepo.Verify(_ => _.BeginTransaction(), Times.Once());
            projectRepo.Verify(_ => _.Save(It.IsAny<Project>()), Times.Once());
            projectRepo.Verify(_ => _.Commit(), Times.Once());
            projectRepo.Verify(_ => _.Evict(It.IsAny<Project>()), Times.Once());
   
        }

    }
}
