using System;

namespace Prizm.Domain.Entity
{
    public class Item
    {
        private bool isActive;

        public virtual Guid Id { get; protected set; }
        public virtual bool IsActive { get; set; }

        public virtual bool IsNotActive 
        {
            get
            {
                isActive = IsActive;
                return !isActive;
            }
            set
            {
                isActive = !value;
                IsActive = isActive;
            }
        }

    }
}