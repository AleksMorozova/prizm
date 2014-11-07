using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mill
{
    interface IPipeDAO : INumberDAO<Pipe> 
    {
        Pipe GetBySizeType(string syzeType);
        Pipe GetByHeatNumber(string heatNumber);
        Pipe GetByPurchaseOrder(string order);
        Pipe GetByStatus(PipeMillStatus status);
        Pipe GetByDate(DateTime date);
    }
}
