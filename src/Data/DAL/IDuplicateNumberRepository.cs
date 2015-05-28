using Prizm.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL
{
    public interface IDuplicateNumberRepository
    {
        List<DuplicateNumberEntity> GetAllActiveEntitites();
        List<string> GetAllActiveDuplicateNumber();
        List<DuplicateNumberEntity> GetAllActiveDuplicateEntityByNumber(string entityNumber);
    }
}
