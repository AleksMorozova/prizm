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
    public class JointSearchCommand : BaseCommand
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
        public override void Execute()
        {
            if (Prizm.Main.Common.DateExtension.CheckDiapason(viewModel.FromDate, viewModel.ToDate))
            {
                repo.Clear();
                if (viewModel.Statuses.Count > 0)
                {
                    bool? status;
                    switch(viewModel.Activity)
                    {
                        case ActivityCriteria.StatusActive:
                            status = true;
                            break;
                        case ActivityCriteria.StatusUnactive:
                            status = false;
                            break;
                        default:
                            status = null;
                            break;
                    }

                    IList<Construction.Joint> list = repo.SearchJoint
                        (
                            viewModel.Number,
                            viewModel.Statuses,
                            viewModel.FromDate,
                            viewModel.ToDate,
                            viewModel.PegNumber,
                            status
                        );

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

        public override bool CanExecute()
        {
            return true;
        }

        #endregion
    }
}
