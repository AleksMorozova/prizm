using System;
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

            if (viewModel.PipeMillStatus != null)
            {
                criteria.Add(Restrictions.Like("p.Status", viewModel.PipeMillStatus.Value));
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
