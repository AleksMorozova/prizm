﻿using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public interface IFileRepository : IRepository<Guid, File>
    {
        IList<File> GetByItem(Item item);
    }
}
