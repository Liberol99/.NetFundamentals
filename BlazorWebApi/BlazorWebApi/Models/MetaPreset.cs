using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaPreset
    {
        public MetaPreset()
        {
            MetaReports = new HashSet<MetaReport>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public byte? PresetType { get; set; }
        public string? PresetName { get; set; }
        public string? OwnerName { get; set; }
        public byte[]? Definition { get; set; }
        public string? UserIds { get; set; }
        public string? CompanyIds { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual ICollection<MetaReport> MetaReports { get; set; }
    }
}
