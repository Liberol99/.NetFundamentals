using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaHrmProfession
    {
        public MetaHrmProfession()
        {
            ErpEmployees = new HashSet<ErpEmployee>();
        }

        public int RecId { get; set; }
        public byte? Type { get; set; }
        public string? ProfessionCode { get; set; }
        public string? ProfessionName { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
    }
}
