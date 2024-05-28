using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPaymentPlanItem
    {
        public long RecId { get; set; }
        public long? PaymentId { get; set; }
        public short? PaymentType { get; set; }
        public string? Explanation { get; set; }
        public int? BankAccountId { get; set; }
        public int? ForexId { get; set; }
        public string? ItemFormula { get; set; }
        public byte[]? ItemCondition { get; set; }
        public byte? Roundation { get; set; }
        public string? ItemDay { get; set; }
        public string? ItemMonth { get; set; }
        public string? ItemYear { get; set; }
        public decimal? Discount { get; set; }
        public string? UniversalCode { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? CustomerInterestRate { get; set; }
        public string? TransferDay { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? PaymentCardId { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpPaymentPlan? Payment { get; set; }
        public virtual ErpPaymentCard? PaymentCard { get; set; }
    }
}
