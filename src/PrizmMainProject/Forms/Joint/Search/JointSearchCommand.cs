using Prizm.Data.DAL.Construction;
using DevExpress.Mvvm.DataAnnotations;
using NHibernate.Criterion;
using Ninject;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Construction = Prizm.Domain.Entity.Construction;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.Joint.Search
{
    public class JointSearchCommand : ICommand
    {
        IJointRepository repo;
        JointSearchViewModel viewModel;

        [Inject]
        public JointSearchCommand(JointSearchViewModel vm, IJointRepository repo)
        {
            viewModel = vm;
            this.repo = repo;
        }

        #region ICommand Members
        [Command(UseCommandManager = false)]
        public void Execute()
        {
            DetachedCriteria criteria = DetachedCriteria.For<Construction.Joint>();
            if(viewModel.Statuses.Count == 0)
            {

            }
            else
            {
                if(!string.IsNullOrWhiteSpace(viewModel.Number))
                {
                    criteria.Add(Restrictions.Like("Number", viewModel.Number, MatchMode.Anywhere));
                }
                if(!string.IsNullOrWhiteSpace(viewModel.PegNumber))
                {
                    criteria.Add(Restrictions.Like("NumberKP", viewModel.PegNumber, MatchMode.Anywhere));
                }
                if(viewModel.FromDate > DateTime.MinValue)
                {
                    criteria.Add(Restrictions.Gt("LoweringDate", viewModel.FromDate));
                }
                if(viewModel.ToDate > DateTime.MinValue)
                {
                    criteria.Add(Restrictions.Lt("LoweringDate", viewModel.ToDate));
                }
                criteria.Add(Restrictions.In("Status", viewModel.Statuses));
                
                var list = repo.GetByCriteria(criteria);
                viewModel.Joints.Clear();
                foreach(var item in list)
                {
                    viewModel.Joints.Add(item);
                }
            }
        }

        public bool CanExecute()
        {
            return true;
        }

        public bool IsExecutable { get; set; }

        #endregion
    }
}
