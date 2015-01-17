using DevExpress.Mvvm.DataAnnotations;
using NHibernate;
using NHibernate.Type;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Parts.Search
{
    public class PartsSearchCommand : ICommand
    {
        PartSearchViewModel viewModel;
        ISession session;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public PartsSearchCommand(PartSearchViewModel vm, ISession sess)
        {
            viewModel = vm;
            session = sess;
        }

        #region ICommand Members
        [Command(UseCommandManager = false)]
        public void Execute()
        {
            BindingList<Part> parts = new BindingList<Part>();

            var query = session.CreateSQLQuery(PartQuery.BuildSql(viewModel.Types, viewModel.Number, viewModel.Activity))
                .SetResultTransformer(PartQuery.Transformer);

            var qparts = query.List<Part>();

            foreach(var item in qparts)
            {
                parts.Add(item);
            }

            viewModel.Parts = parts;
        }

        public bool CanExecute()
        {
            return true;
        }

        #endregion
    }
}
