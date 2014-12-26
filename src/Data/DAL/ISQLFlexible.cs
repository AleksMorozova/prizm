using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity;

namespace Prizm.Data.DAL
{
    public interface ISQLFlexible
    {
        ISQLFlexible Top(int count);
        ISQLFlexible WhereAnd();
        ISQLFlexible Where(string a, string b, string c);
        string ToString();
    }
}
