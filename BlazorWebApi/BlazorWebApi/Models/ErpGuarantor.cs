using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGuarantor
    {
        public ErpGuarantor()
        {
            ErpAddresses = new HashSet<ErpAddress>();
        }

        public long RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? GuarantorName { get; set; }
        public string? Explanation { get; set; }
        public string? IdNo { get; set; }
        public string? GsmPhone { get; set; }
        public byte? IsReference { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
    }
}
