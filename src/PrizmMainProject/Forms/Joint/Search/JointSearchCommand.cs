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
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Joint.Search
{
    public class JointSearchCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(JointSearchCommand));
        IJointRepository repo;
        JointSearchViewModel viewModel;
        private readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public JointSearchCommand(JointSearchViewModel vm, IJointRepository repo,
            IUserNotify notify)
        {
            viewModel = vm;
            this.repo = repo;
            this.notify = notify;
        }

        #region ICommand Members
        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (Prizm.Main.Common.DateExtension.CheckDiapason(viewModel.FromDate, viewModel.ToDate))
            {
                repo.Clear();
                DetachedCriteria criteria = DetachedCriteria.For<Construction.Joint>();
                if (viewModel.Statuses.Count > 0)
                {
                    if (!string.IsNullOrWhiteSpace(viewModel.Number))
                    {
                        criteria.Add(Restrictions.Like("Number", viewModel.Number, MatchMode.Anywhere).IgnoreCase());
                    }

                    criteria.Add(Restrictions.Eq("NumberKP", viewModel.PegNumber));

                    if (viewModel.FromDate > DateTime.MinValue)
                    {
                        criteria.Add(Restrictions.Gt("LoweringDate", viewModel.FromDate));
                    }
                    if (viewModel.ToDate > DateTime.MinValue)
                    {
                        criteria.Add(Restrictions.Lt("LoweringDate", viewModel.ToDate));
                    }
                    criteria.Add(Restrictions.In("Status", viewModel.Statuses));

                    if (viewModel.Activity.Equals(ActivityCriteria.StatusActive))
                    {
                        criteria.Add(Restrictions.Eq("IsActive", true));
                    }
                    else if (viewModel.Activity.Equals(ActivityCriteria.StatusUnactive))
                    {
                        criteria.Add(Restrictions.Eq("IsActive", false));
                    }
                    criteria.AddOrder(Order.Asc("Number"));

                    var list = repo.GetByCriteria(criteria);
                    viewModel.Joints.Clear();
                    foreach (var item in list)
                    {
                        viewModel.Joints.Add(item);
                    }

                    viewModel.Amount = list.Count();
                    RefreshVisualStateEvent();
                }
            }
            else
            {
                notify.ShowInfo(Program.LanguageManager.GetString(StringResources.WrongDate),
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                log.Warn("Date limits not valid!" + "Diapason: start date= "
                    + viewModel.FromDate.ToString() + " end date= " + viewModel.ToDate.ToString());
            }
        }

        public bool CanExecute()
        {
            return true;
        }

        #endregion
    }
}
