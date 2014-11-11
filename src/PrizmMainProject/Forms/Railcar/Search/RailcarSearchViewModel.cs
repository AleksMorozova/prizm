using Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using PrizmMain.Commands;
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
        //private readonly SearchRailcarCommand searchCommand;

        private List<Domain.Entity.Mill.Railcar> railcars;

        [Inject]
        public RailcarSearchViewModel(IRailcarRepository repo)
        {
            railcars = new List<Domain.Entity.Mill.Railcar>();
            this.repo = repo;
            //searchCommand = ViewModelSource.Create(() => new SearchRailcarCommand(this, repo));
            GetAllRailcars();
        }

        public List<Domain.Entity.Mill.Railcar> Railcars {
            get { return railcars;}
            set
            {
                if (value != railcars)
                {
                    railcars = value;
                    RaisePropertyChanged("Railcars");
                }
            }
            }


        private void GetAllRailcars()
        {
            railcars = repo.GetAll().ToList();
            //FillGrid();
        }

        private void FillGrid()
        {
            throw new NotImplementedException();
        }

        //public ICommand SearchCommand
        //{
        //    get { return searchCommand; }
        //}

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
