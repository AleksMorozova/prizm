using Data.DAL;
using DevExpress.Mvvm;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Reports.Mill
{
    public class MillReportsViewModel : ViewModelBase, IDisposable
    {
        readonly IMillReportRepository repo;
        public DataSet pipeDataSet;
        public DateTime StartDate;
        public DateTime EndDate;


        [Inject]
        public MillReportsViewModel(IMillReportRepository repo)
        {
            this.repo = repo;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
