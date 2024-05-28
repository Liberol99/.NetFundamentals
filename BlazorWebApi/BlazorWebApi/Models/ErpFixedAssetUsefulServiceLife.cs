using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpFixedAssetUsefulServiceLife
    {
        public ErpFixedAssetUsefulServiceLife()
        {
            ErpInventories = new HashSet<ErpInventory>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? UsefulServiceLifeCode { get; set; }
        public string? UsefulServiceLifeName { get; set; }
        public short? UsefulServiceLifeYear { get; set; }
        public decimal? DepreciationRate { get; set; }
        public string? SpecialCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
    }
}
