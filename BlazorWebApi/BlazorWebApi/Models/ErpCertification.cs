using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCertification
    {
        public ErpCertification()
        {
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? CertificationName { get; set; }
        public string? Explanation { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? ShortCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
    }
}
