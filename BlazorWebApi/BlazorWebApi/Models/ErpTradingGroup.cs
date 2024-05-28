using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpTradingGroup
    {
        public ErpTradingGroup()
        {
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            ErpInventoryMargins = new HashSet<ErpInventoryMargin>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? GroupCode { get; set; }
        public string? GroupName { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? GroupType { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<ErpInventoryMargin> ErpInventoryMargins { get; set; }
    }
}
