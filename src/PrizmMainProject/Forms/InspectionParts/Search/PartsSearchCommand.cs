using DevExpress.Mvvm.DataAnnotations;
using NHibernate;
using NHibernate.Type;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.InspectionParts.Search
{
    public class PartsSearchCommand : ICommand
    {
        PartsSearchViewModel viewModel;
        ISession session;

        [Inject]
        public PartsSearchCommand(PartsSearchViewModel vm, ISession sess)
        {
            viewModel = vm;
            session = sess;
        }

        #region ICommand Members
        [Command(UseCommandManager = false)]
        public void Execute()
        {
            BindingList<Part> parts = new BindingList<Part>();

            var query = session.CreateSQLQuery(PartQuery.BuildSql(viewModel.Types, viewModel.Number))
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

        public bool IsExecutable { get; set; }

        #endregion
    }
}
