using Domain.DAL;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    interface INumberDAO<TItem> : IDAO<TItem> where TItem:Item 
    {
        TItem GetByNumber(string number);
    }
}
