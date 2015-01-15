using System;

namespace Prizm.Domain.Entity
{
    public class Item
    {
       public Item()
       {
          if (Id == Guid.Empty)
             Id = Guid.NewGuid();
       }

        private bool isActive = true;

        public virtual Guid Id { get; set; }
        public virtual bool IsActive { get { return isActive; } set {isActive=value ;} }

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