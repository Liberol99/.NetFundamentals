using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaLocation
    {
        public MetaLocation()
        {
            RplTaskTargets = new HashSet<RplTaskTarget>();
            RplXrefs = new HashSet<RplXref>();
        }

        public int RecId { get; set; }
        public string? LocationCode { get; set; }
        public string? LocationName { get; set; }
        public string? Dbaddress { get; set; }
        public string? Dbname { get; set; }
        public string? Dbuser { get; set; }
        public string? Dbpassword { get; set; }
        public string? Dbprovider { get; set; }
        public string? CompanyCode { get; set; }
        public string? GroupCode { get; set; }
        public string? SpecialCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<RplTaskTarget> RplTaskTargets { get; set; }
        public virtual ICollection<RplXref> RplXrefs { get; set; }
    }
}
