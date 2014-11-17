using System;

namespace Domain.Entity
{
    public class File : Item
    {
        public virtual string FileName { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime UploadDate { get; set; }
    }
}