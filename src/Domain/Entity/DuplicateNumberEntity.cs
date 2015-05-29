using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity
{
    public class DuplicateNumberEntity
    {
        public Guid EntityID { get; set; }
        public string EntityNumber { get; set; }
        public string EntityType { get; set; }
    }

    public class DuplicateNumberEntityComparer : IEqualityComparer<DuplicateNumberEntity>
    {
        public bool Equals(DuplicateNumberEntity x, DuplicateNumberEntity y)
        { 
            if (Object.ReferenceEquals(x, y)) return true;
 
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            return x.EntityType == y.EntityType;
        }

        public int GetHashCode(DuplicateNumberEntity obj)
        {
            if (Object.ReferenceEquals(obj, null)) return 0;

            int hashEntitiNumber = obj.EntityNumber == null ? 0 : obj.EntityNumber.GetHashCode();

            return hashEntitiNumber;
        }
    }
}
