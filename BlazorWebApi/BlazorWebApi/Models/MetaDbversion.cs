using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaDbversion
    {
        public int? ProgramNo { get; set; }
        public short? MajorNo { get; set; }
        public short? MinorNo { get; set; }
        public short? ReleaseNo { get; set; }
        public DateTime? VersionDate { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
