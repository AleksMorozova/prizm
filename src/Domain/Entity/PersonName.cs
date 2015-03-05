using System;

namespace Prizm.Domain.Entity
{
    // TODO: Name convert Funtion (property)
    [Serializable()]
    public class PersonName : Item
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string GetFullName()
        {
            return LastName + " " + FirstName + " " + MiddleName;
        }
    }
}