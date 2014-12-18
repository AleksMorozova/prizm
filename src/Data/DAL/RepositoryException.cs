using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL
{
    [Serializable]
    public class RepositoryException : ApplicationException
    {
        public RepositoryException(string message) :base(message)
        {
        }

        public RepositoryException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
