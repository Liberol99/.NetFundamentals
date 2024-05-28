using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBankCreditItem
    {
        public ErpBankCreditItem()
        {
            ErpBankCreditExpoClosings = new HashSet<ErpBankCreditExpoClosing>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpInvoices = new HashSet<ErpInvoice>();
        }

        public long RecId { get; set; }
        public long? BankCreditId { get; set; }
        public byte? ItemType { get; set; }
        public byte? CreditUpType { get; set; }
        public int? CreditType { get; set; }
        public int? ItemOrderNo { get; set; }
        public long? WorkOrderId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public long? CurrentAccountId { get; set; }
        public decimal? UnitPrice { get; set; }
        public long? OrderReceiptId { get; set; }
        public long? OrderReceiptItemId { get; set; }
        public DateTime? OperationDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? ManufacturingPlace { get; set; }
        public string? InventoryCode { get; set; }
        public string? InventoryName { get; set; }
        public string? Explanation { get; set; }
        public DateTime? TermDate { get; set; }
        public decimal? ItemTotal { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? CommissionRate { get; set; }
        public decimal? InterestTotal { get; set; }
        public decimal? CommissionTotal { get; set; }
        public decimal? Bsmvrate { get; set; }
        public decimal? Kkdfrate { get; set; }
        public decimal? Bsmvamount { get; set; }
        public decimal? Kkdfamount { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexTotal { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? LocalItemTotal { get; set; }
        public decimal? LocalCommissionTotal { get; set; }
        public decimal? LocalInterestTotal { get; set; }
        public DateTime? InterestDate { get; set; }
        public int? GuaranteeType { get; set; }
        public DateTime? InstalmentDate { get; set; }
        public decimal? InstalmentTotal { get; set; }
        public decimal? ExpenseAmount { get; set; }
        public decimal? LeasingVatAmount { get; set; }
        public decimal? LeasingVatAmountForex { get; set; }
        public decimal? InterestTotalForex { get; set; }
        public decimal? CommissionTotalForex { get; set; }
        public decimal? InstalmentTotalForex { get; set; }
        public decimal? ExpenseAmountForex { get; set; }
        public decimal? ItemTotalForex { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public long? ExpoId { get; set; }
        public byte? IsPaid { get; set; }

        public virtual ErpBankCredit? BankCredit { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpExpo? Expo { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpOrderReceipt? OrderReceipt { get; set; }
        public virtual ErpOrderReceiptItem? OrderReceiptItem { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ICollection<ErpBankCreditExpoClosing> ErpBankCreditExpoClosings { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
    }
}
