using DevExpress.Mvvm.DataAnnotations;
using NHibernate;
using Ninject;
using PrizmMain.Commands;
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

            var qparts = session.CreateSQLQuery(PartQuery.Sql)
                .SetResultTransformer(PartQuery.Transformer)
                .List<Part>();

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
