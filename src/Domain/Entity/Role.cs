using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class Role
    {
        public Role()
        {
            this.Users = new List<User>();
        }

        public int RoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
