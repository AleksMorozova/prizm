﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity
{
    public class Certificate : Item
    {
        public virtual string Number { get; set; }
        public virtual DateTime ExpirationDate { get; set; }
        public virtual int Grade { get; set; }
    }
}
