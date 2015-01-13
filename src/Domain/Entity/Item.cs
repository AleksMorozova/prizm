using System;

namespace Prizm.Domain.Entity
{
    public class Item
    {
        private bool isActive = true;

        public virtual Guid Id { get; set; }
        public virtual bool IsActive { get { return isActive; } set {isActive=value ;} }
    }
}