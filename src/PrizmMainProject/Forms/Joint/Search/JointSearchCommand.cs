using Data.DAL.Construction;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Joint.Search
{
    public class JointSearchCommand : ICommand
    {
        IJointRepository repo;

        [Inject]
        public JointSearchCommand(IJointRepository repo)
        {
            this.repo = repo;
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
