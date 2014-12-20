﻿using Prizm.Data.DAL;
using Prizm.Data.DAL.Security;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Common;
using Prizm.Main.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Prizm.Data.DAL.Hibernate;
using NHibernate;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    public class FirstSetupSaveCommand : ICommand
    {
        FirstSetupViewModel viewModel;
        ISession session;
        IUserRepository userRepo;
        IProjectRepository projectRepo;

        public FirstSetupSaveCommand(FirstSetupViewModel vm)
        {
            viewModel = vm;
        }

        #region ICommand Members
        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.Admin.Name = viewModel.Name;
            viewModel.Admin.PasswordHash = PasswordEncryptor.EncryptPassword(viewModel.Password);
            viewModel.Admin.IsActive = true;

            viewModel.Project.IsActive = true;
            if(viewModel.Project.WorkstationType != Domain.Entity.Setup.WorkstationType.Mill)
            {
                viewModel.MillName = string.Empty;
                viewModel.MillPipeNumberMask = string.Empty;
            }

            ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();
            ctx.LoggedUser = viewModel.Admin;

            HibernateUtil.CurrentUser = ctx.GetLoggedPerson();
            session = HibernateUtil.OpenSession(false);
            userRepo = new UserRepository(session);
            projectRepo = new ProjectRepository(session);

            userRepo.BeginTransaction();
            userRepo.Save(viewModel.Admin);
            userRepo.Commit();
            userRepo.Evict(viewModel.Admin);

            projectRepo.BeginTransaction();
            projectRepo.Save(viewModel.Project);
            projectRepo.Commit();
            projectRepo.Evict(viewModel.Project);

            viewModel.IsSaved = true;
        }

        public bool CanExecute()
        {
            return !string.IsNullOrWhiteSpace(viewModel.Project.Title) && viewModel.Project.WorkstationType != Prizm.Domain.Entity.Setup.WorkstationType.Undef
                && !string.IsNullOrWhiteSpace(viewModel.Admin.Login) && !string.IsNullOrWhiteSpace(viewModel.Admin.Name.LastName) 
                && !string.IsNullOrWhiteSpace(viewModel.Admin.Name.FirstName);
        }

        public bool IsExecutable { get; set; }

        #endregion
    }
}
