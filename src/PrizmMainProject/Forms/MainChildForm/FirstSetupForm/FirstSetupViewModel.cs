using Data.DAL;
using Data.DAL.Security;
using DevExpress.Mvvm;
using Domain.Entity;
using Domain.Entity.Security;
using Domain.Entity.Setup;
using Ninject;
using PrizmMain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.MainChildForm.FirstSetupForm
{
    public class FirstSetupViewModel : ViewModelBase, IDisposable
    {
        IUserRepository userRepo;
        IProjectRepository projectRepo;

        [Inject]
        public FirstSetupViewModel(IUserRepository userRepo, IProjectRepository projectRepo)
        {
            this.userRepo = userRepo;
            this.projectRepo = projectRepo;

            var mill = new EnumWrapper<WorkstationType> { Value = WorkstationType.Mill };
            var construction = new EnumWrapper<WorkstationType> { Value = WorkstationType.Construction };
            var master = new EnumWrapper<WorkstationType> { Value = WorkstationType.Master };
            Types.Add(mill);
            Types.Add(construction);
            Types.Add(master);
        }

        public BindingList<EnumWrapper<WorkstationType>> Types = new BindingList<EnumWrapper<WorkstationType>>();
        private Project project = new Project();
        private User admin = new User();


        #region IDisposable Members

        public void Dispose()
        {
            userRepo.Dispose();
            projectRepo.Dispose();
        }

        #endregion
    }
}
