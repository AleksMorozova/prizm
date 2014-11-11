using Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Railcar.Search
{
    public class RailcarSearchViewModel : ViewModelBase, IDisposable
    {
        private readonly IRailcarRepository repo;
        private readonly SearchRailcarCommand searchCommand;

        private BindingList<Domain.Entity.Mill.Railcar> railcars;

        [Inject]
        public RailcarSearchViewModel(IRailcarRepository repo)
        {
            railcars = new BindingList<Domain.Entity.Mill.Railcar>();
            this.repo = repo;
            //searchCommand = ViewModelSource.Create(() => new SearchRailcarCommand(this, repo));
            GetAllRailcars();
        }

        private void GetAllRailcars()
        {
            
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
