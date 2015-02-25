using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.ReleaseNote.Search
{
    public class ReleaseNoteProjection
    {
        public Guid Id { get; set; }
        public string CarNumber { get; set; }
        public string CarCertificate { get; set; }
        public string CarDestination { get; set; }
        public string NoteNumber { get; set; }
        public string NoteDate { get; set; }
        public bool Status { get; set; }
    }
}
