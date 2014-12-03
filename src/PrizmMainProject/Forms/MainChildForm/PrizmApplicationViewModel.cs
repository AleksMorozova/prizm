using Data.DAL;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Domain.Entity;

namespace PrizmMain.Forms.MainChildForm
{
    public class PrizmApplicationViewModel : ViewModelBase, IDisposable
    {
        readonly IProjectRepository repo;
        public Project ProjectSettings;

        [Inject]
        public PrizmApplicationViewModel(IProjectRepository repo)
        {
            this.repo = repo;
        }

        public void GetOrCreateProject()
        {
            if (repo.GetSingle() == null)
            {
                ProjectSettings = new Project()
                {
                    Client = string.Empty,
                    MillName = string.Empty,
                    WorkstationType = Domain.Entity.Setup.WorkstationType.Mill,
                    MillPipeNumberMask = string.Empty,
                    IsActive = true
                };
                repo.BeginTransaction();
                repo.Save(ProjectSettings);
                repo.Commit();
                repo.Evict(ProjectSettings);
            }
            ProjectSettings = repo.GetSingle();
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
