﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrizmMain.Commands;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Data.DAL.Mill;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using Domain.Entity.Setup;
using Domain.Entity.Mill;
using PrizmMain.Properties;

namespace PrizmMain.Forms.PipeMill.Search
{
    public class MillPipeSearchCommand : ICommand
    {
        readonly IPipeRepository repo;
        readonly MillPipeSearchViewModel viewModel;

        public MillPipeSearchCommand(MillPipeSearchViewModel viewModel, IPipeRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            repo.Clear();

            var criteria = NHibernate.Criterion.DetachedCriteria
                    .For<Domain.Entity.Mill.Pipe>("p")
                    .Add(Restrictions.Like("p.Number", viewModel.PipeNumber, MatchMode.Anywhere))
                    .Add(Restrictions.InG<PipeMillSizeType>("p.Type", viewModel.CheckedPipeTypes));

            if (viewModel.CheckedStatusTypes != null && viewModel.CheckedStatusTypes.Count != viewModel.StatusTypes.Count)
            {
                var statuses = new List<PipeMillStatus>();
                foreach (var item in viewModel.CheckedStatusTypes)
                {
                    statuses.Add(item.Value);
                }
                criteria.Add(Restrictions.InG<PipeMillStatus>("p.Status",statuses));
            }

            if (viewModel.Activity.Equals(Resources.PipeStatusComboActive))
            {
                criteria.Add(Restrictions.Eq("p.IsActive", true));
            }
            else if (viewModel.Activity.Equals(Resources.PipeStatusComboUnactive))
            {
                criteria.Add(Restrictions.Eq("p.IsActive", false));
            }

            viewModel.Pipes = repo.GetByCriteria(criteria);
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
