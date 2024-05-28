using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpLoyalityCard
    {
        public ErpLoyalityCard()
        {
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpLoyalityCardDepts = new HashSet<ErpLoyalityCardDept>();
            ErpLoyalityCardServices = new HashSet<ErpLoyalityCardService>();
            ErpPos = new HashSet<ErpPo>();
            InverseParentCard = new HashSet<ErpLoyalityCard>();
        }

        public long RecId { get; set; }
        public int CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? LoyalityCardTypeId { get; set; }
        public string? LoyalityCardCode { get; set; }
        public long? ParentCardId { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? CustomerName { get; set; }
        public string? ProxyNo { get; set; }
        public decimal? CriticalLimit { get; set; }
        public decimal? Limit { get; set; }
        public decimal? UsedLimit { get; set; }
        public decimal? LimitForex { get; set; }
        public decimal? UsedLimitForex { get; set; }
        public int? OpeningBonus { get; set; }
        public decimal? Discount { get; set; }
        public short? Days { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? InvalidStartDate { get; set; }
        public DateTime? InvalidEndDate { get; set; }
        public byte? IsComplimentary { get; set; }
        public int? CashId { get; set; }
        public int? PaymentCardId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? Explanation { get; set; }
        public string? PriceGroupCode { get; set; }
        public string? DiscountGroupCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCash? Cash { get; set; }
        public virtual ErpCompany Company { get; set; } = null!;
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpLoyalityCardType? LoyalityCardType { get; set; }
        public virtual ErpLoyalityCard? ParentCard { get; set; }
        public virtual ErpPaymentCard? PaymentCard { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpLoyalityCardDept> ErpLoyalityCardDepts { get; set; }
        public virtual ICollection<ErpLoyalityCardService> ErpLoyalityCardServices { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpLoyalityCard> InverseParentCard { get; set; }
    }
}
