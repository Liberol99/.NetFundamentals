using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpSizeSetParameter
    {
        public ErpSizeSetParameter()
        {
            ErpSizeSetItems = new HashSet<ErpSizeSetItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? AccessCode { get; set; }
        public string? Code { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Name3 { get; set; }
        public byte? SizeType { get; set; }
        public decimal? ShrinkageWidth { get; set; }
        public decimal? ShrinkageLength { get; set; }
        public byte? IsPercentage { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpSizeSetItem> ErpSizeSetItems { get; set; }
    }
}
