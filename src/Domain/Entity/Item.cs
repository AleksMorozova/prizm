using System;

namespace Domain.Entity
{
    public class Item
    {
        public virtual Guid Id { get; protected set; }
        public virtual bool IsActive { get; set; }

        public virtual string GetUser()
        {
            return "test user";
        }
    }
}