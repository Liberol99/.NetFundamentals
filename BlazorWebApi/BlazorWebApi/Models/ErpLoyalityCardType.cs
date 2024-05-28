using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpLoyalityCardType
    {
        public ErpLoyalityCardType()
        {
            ErpLoyalityCardTypeDepts = new HashSet<ErpLoyalityCardTypeDept>();
            ErpLoyalityCardTypeProxies = new HashSet<ErpLoyalityCardTypeProxy>();
            ErpLoyalityCardTypeServices = new HashSet<ErpLoyalityCardTypeService>();
            ErpLoyalityCards = new HashSet<ErpLoyalityCard>();
        }

        public int RecId { get; set; }
        public int CompanyId { get; set; }
        public string? TypeCode { get; set; }
        public string? Explanation { get; set; }
        public long? CurrentAccountId { get; set; }
        public short? UsageType { get; set; }
        public byte? IsComplimentary { get; set; }
        public short? LimitControl { get; set; }
        public short? LimitExceeding { get; set; }
        public byte? BonusApplication { get; set; }
        public int? OpeningBonus { get; set; }
        public short? Days { get; set; }
        public decimal? Discount { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
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

        public virtual ErpCompany Company { get; set; } = null!;
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ICollection<ErpLoyalityCardTypeDept> ErpLoyalityCardTypeDepts { get; set; }
        public virtual ICollection<ErpLoyalityCardTypeProxy> ErpLoyalityCardTypeProxies { get; set; }
        public virtual ICollection<ErpLoyalityCardTypeService> ErpLoyalityCardTypeServices { get; set; }
        public virtual ICollection<ErpLoyalityCard> ErpLoyalityCards { get; set; }
    }
}
