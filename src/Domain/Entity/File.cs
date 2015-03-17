using System;

namespace Prizm.Domain.Entity
{
    public class File : Item
    {
        public virtual string FileName { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime UploadDate { get; set; }
        public virtual Guid Item { get; set; }
        public virtual string NewName { get; set; }

        public override Guid OwnerId
        {
            get
            {
                return Item;
            }
            set
            {
                base.OwnerId = value;
            }
        }
    }
}