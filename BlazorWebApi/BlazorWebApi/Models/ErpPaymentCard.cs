using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPaymentCard
    {
        public ErpPaymentCard()
        {
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpCashTotalItems = new HashSet<ErpCashTotalItem>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpLoyalityCards = new HashSet<ErpLoyalityCard>();
            ErpPaymentCardDepts = new HashSet<ErpPaymentCardDept>();
            ErpPaymentCardItems = new HashSet<ErpPaymentCardItem>();
            ErpPaymentPlanItems = new HashSet<ErpPaymentPlanItem>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? PaymentCode { get; set; }
        public string? PaymentName { get; set; }
        public byte? PaymentType { get; set; }
        public int? BankAccountId { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? CreditCardId { get; set; }
        public int? ForexId { get; set; }
        public short? StartDay1 { get; set; }
        public short? EndDay1 { get; set; }
        public short? PaymentDay1 { get; set; }
        public short? StartDay2 { get; set; }
        public short? EndDay2 { get; set; }
        public short? PaymentDay2 { get; set; }
        public short? StartDay3 { get; set; }
        public short? EndDay3 { get; set; }
        public short? PaymentDay3 { get; set; }
        public byte? ShiftPaymentDay { get; set; }
        public decimal? CommRate1 { get; set; }
        public decimal? CommRate2 { get; set; }
        public decimal? CommRate3 { get; set; }
        public byte? DiscountCommOnFirst { get; set; }
        public byte? DiscountBonusOnFirst { get; set; }
        public short? DefaultInstallmentCount { get; set; }
        public decimal? RateForShortMonths { get; set; }
        public decimal? RateForOverMonths { get; set; }
        public short? MaxInstallmentCount { get; set; }
        public byte? CardNoFollowup { get; set; }
        public byte? InstallmentFollowup { get; set; }
        public byte? AddCommAmountToAmount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public byte? IsPaymentForMobile { get; set; }
        public byte? IsSingleUsage { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? PaymentSubType { get; set; }
        public byte? IsFoodTicket { get; set; }
        public byte? IsOnlinePayment { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual MetaCreditCard? CreditCard { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpCashTotalItem> ErpCashTotalItems { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpLoyalityCard> ErpLoyalityCards { get; set; }
        public virtual ICollection<ErpPaymentCardDept> ErpPaymentCardDepts { get; set; }
        public virtual ICollection<ErpPaymentCardItem> ErpPaymentCardItems { get; set; }
        public virtual ICollection<ErpPaymentPlanItem> ErpPaymentPlanItems { get; set; }
    }
}
