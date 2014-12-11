using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using NHibernate;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Forms.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.InspectionParts.Search
{
    public class PartsSearchViewModel : ViewModelBase, IDisposable
    {
        PartsSearchCommand searchCommand;
        ISession session;
        

        [Inject]
        public PartsSearchViewModel(ISession session)
        {
            this.session = session;
            searchCommand = ViewModelSource.Create(() => new PartsSearchCommand(this, session));
        }

        private string number = string.Empty;
        public string Number
        {
            get { return number; }
            set
            {
                if(value != number)
                {
                    number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        private BindingList<Part> parts = new BindingList<Part>();
        public BindingList<Part> Parts 
        {
            get { return parts; }
            set
            {
                if(value != parts)
                {
                    parts = value;
                    RaisePropertyChanged("Parts");
                }
            }
        }

        private BindingList<PartType> types = new BindingList<PartType>();
        public BindingList<PartType> Types
        {
            get { return types; }
            set
            {
                if(value != types)
                {
                    types = value;
                    RaisePropertyChanged("Types");
                }
            }
        }

        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        #region IDisposable Members

        public void Dispose()
        {

        }

        #endregion
    }
}
