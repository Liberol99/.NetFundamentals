using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGiftVoucherType
    {
        public ErpGiftVoucherType()
        {
            ErpGiftVoucherTypeDepts = new HashSet<ErpGiftVoucherTypeDept>();
            ErpGiftVouchers = new HashSet<ErpGiftVoucher>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? VoucherTypeCode { get; set; }
        public string? Explanation { get; set; }
        public short? VoucherType { get; set; }
        public short? UsageType { get; set; }
        public byte? IsBonus { get; set; }
        public byte? IsReturn { get; set; }
        public string? CodeTemplate { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? MinumumAmount { get; set; }
        public decimal? MaximumAmount { get; set; }
        public long? InventoryCampaignId { get; set; }
        public int? ForexId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventoryCampaign? InventoryCampaign { get; set; }
        public virtual ICollection<ErpGiftVoucherTypeDept> ErpGiftVoucherTypeDepts { get; set; }
        public virtual ICollection<ErpGiftVoucher> ErpGiftVouchers { get; set; }
    }
}
