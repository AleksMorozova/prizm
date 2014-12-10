using DevExpress.Mvvm;
using NHibernate;
using Ninject;
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
        ISession session;
        

        [Inject]
        public PartsSearchViewModel(ISession session)
        {
            this.session = session;

            var qparts = session.CreateSQLQuery(PartQuery.Sql)
                .SetResultTransformer(PartQuery.Transformer)
                .List<Part>();

            foreach(var item in qparts)
            {
                parts.Add(item);
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

        #region IDisposable Members

        public void Dispose()
        {
            session.Dispose();
        }

        #endregion
    }
}
