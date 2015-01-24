﻿using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class JointCutCommand : ICommand
    {
        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public JointCutCommand(
            IConstructionRepository repo, 
            JointNewEditViewModel viewModel, 
            IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        public void Execute()
        {
            if (notify.ShowYesNo(
                   Resources.DLG_JOINT_WITHDRAWN,
                   Resources.DLG_JOINT_WITHDRAWN_HEADER))
            {
                viewModel.JointDisconnection();

                viewModel.FirstElement = null;
                viewModel.SecondElement = null;

                viewModel.Joint.FirstElement = null;
                viewModel.Joint.SecondElement = null;

                viewModel.Joint.Status = Domain.Entity.Construction.JointStatus.Withdrawn;

                repo.BeginTransaction();
                repo.RepoJoint.SaveOrUpdate(viewModel.Joint);
                repo.Commit();
                repo.RepoJoint.Evict(viewModel.Joint);

                viewModel.ModifiableView.IsModified = false;
            }
        }


        public bool CanExecute()
        {
            return true;
        }
    }
}
