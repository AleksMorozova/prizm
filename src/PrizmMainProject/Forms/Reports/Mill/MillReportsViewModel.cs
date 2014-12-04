using Data.DAL;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Domain.Entity.Mill;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DAL.Mill;

namespace PrizmMain.Forms.Reports.Mill
{
    public class MillReportsViewModel : ViewModelBase
    {
        readonly IMillReportsRepository repo;
        readonly ICategoryRepository repoCategory;
        private readonly IUserNotify notify;
        public DateTime startDate;
        public DateTime endDate;
        readonly CreateReportCommand createCommand;
        readonly PreviewReportCommand previewCommand;
        public object previewSource;
        private BindingList<Category> inspectionCategories;
        public List<Guid> SearchIds = new List<Guid>();

        [Inject]
        public MillReportsViewModel(IMillReportsRepository repo, IUserNotify notify, ICategoryRepository repoCategory)
        {
            this.repo = repo;
            this.notify = notify;
            this.repoCategory = repoCategory;
            createCommand = ViewModelSource.Create<CreateReportCommand>(() => new CreateReportCommand(this, repo, notify));
            previewCommand = ViewModelSource.Create<PreviewReportCommand>(() => new PreviewReportCommand(this, repo, notify));
            GetAllCategories();
        }

        public object PreviewSource
        {
            get
            {
                return previewSource;
            }
            set
            {
                if (value != previewSource)
                {
                    previewSource = value;
                    RaisePropertyChanged("PreviewSource");
                }
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                if (value != startDate)
                {
                    startDate = value;
                    RaisePropertyChanged("StartDate");
                }
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                if (value != endDate)
                {
                    endDate = value;
                    RaisePropertyChanged("EndDate");
                }
            }
        }

        public ICommand CreateCommand
        {
            get 
            {
                return createCommand; 
            }
        }

        public ICommand PreviewCommand
        {
            get { return previewCommand; }
        }

        private void GetAllCategories()
        {
            var categories = this.repoCategory.GetAll();
            if (categories != null)
                inspectionCategories = new BindingList<Category>(categories);
        }

        public BindingList<Category> InspectionCategories
        {
            get 
            { 
                return inspectionCategories; 
            }
        }

    }
}
