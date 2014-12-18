using Prizm.Domain.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class FileMap : SubclassMap <File>
    {
        public FileMap()
        {
            Map(_ => _.Description).Column("description");
            Map(_ => _.FileName).Column("fileName");
            Map(_ => _.UploadDate).Column("uploadDate");
            References<Item>(_ => _.Item).Column("item");
        }
    }
}
