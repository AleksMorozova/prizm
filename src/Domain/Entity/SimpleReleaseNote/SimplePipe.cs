using System;
using Prizm.Domain.Entity.Setup;
using System.Collections.Generic;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;

namespace Prizm.Domain.Entity.SimpleReleaseNote
{
    public class SimplePipe : Part
    {
        public virtual PipeMillSizeType Type { get; set; }

        public virtual SimpleRailcar Railcar { get; set; }

        public virtual PipeMillStatus Status { get; set; }

        public virtual bool ToExport { get; set; }

        public virtual IList<File> Attachments { get; set; }

        //item
        private bool isActive = true;

        public virtual Guid Id { get; set; }
        public virtual bool IsActive { get { return isActive; } set { isActive = value; } }

        //part
        public virtual string Number { get; set; }
    }
}