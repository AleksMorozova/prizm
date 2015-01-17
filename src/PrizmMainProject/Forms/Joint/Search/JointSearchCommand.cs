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
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Joint.Search
{
    public class JointSearchCommand : ICommand
    {
        IJointRepository repo;
        JointSearchViewModel viewModel;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

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
                
                criteria.Add(Restrictions.Eq("NumberKP", viewModel.PegNumber));

                if(viewModel.FromDate > DateTime.MinValue)
                {
                    criteria.Add(Restrictions.Gt("LoweringDate", viewModel.FromDate));
                }
                if(viewModel.ToDate > DateTime.MinValue)
                {
                    criteria.Add(Restrictions.Lt("LoweringDate", viewModel.ToDate));
                }
                criteria.Add(Restrictions.In("Status", viewModel.Statuses));

                if (viewModel.Activity.Equals(Resources.PipeStatusComboActive))
                {
                    criteria.Add(Restrictions.Eq("IsActive", true));
                }
                else if (viewModel.Activity.Equals(Resources.PipeStatusComboUnactive))
                {
                    criteria.Add(Restrictions.Eq("IsActive", false));
                }

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

        #endregion
    }
}
