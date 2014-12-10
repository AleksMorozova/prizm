using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.InspectionParts.Search
{
    public class PartsSearchCommand : ICommand
    {

        [Inject]
        public PartsSearchCommand()
        {

        }

        #region ICommand Members
        [Command(UseCommandManager = false)]
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public bool CanExecute()
        {
            return true;
        }

        public bool IsExecutable { get; set; }

        #endregion
    }
}
