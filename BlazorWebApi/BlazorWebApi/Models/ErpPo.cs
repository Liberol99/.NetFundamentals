using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPo
    {
        public ErpPo()
        {
            ErpCallerIdLogs = new HashSet<ErpCallerIdLog>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpGiftVoucherPosReceipts = new HashSet<ErpGiftVoucher>();
            ErpGiftVoucherReceivedPosReceipts = new HashSet<ErpGiftVoucher>();
            ErpInventoryReceiptItemPayments = new HashSet<ErpInventoryReceiptItemPayment>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpRefundChequePosReceipts = new HashSet<ErpRefundCheque>();
            ErpRefundChequeReceivedPosReceipts = new HashSet<ErpRefundCheque>();
            InverseParent = new HashSet<ErpPo>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CashId { get; set; }
        public short? Shift { get; set; }
        public short? TransactionType { get; set; }
        public short? ReceiptType { get; set; }
        public short? ReceiptUpType { get; set; }
        public short? ReceiptSubType { get; set; }
        public string? ReceiptNo { get; set; }
        public short? SalesType { get; set; }
        public short? OnlineCourierType { get; set; }
        public long? ReturnReceiptId { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? ReceiptTime { get; set; }
        public DateTime? SalesDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string? DocumentNo { get; set; }
        public string? PosUniqueId { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? AddressId { get; set; }
        public int? WarehouseId { get; set; }
        public int? CostCenterId { get; set; }
        public long? DealerId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public long? EmployeeId { get; set; }
        public long? CourierId { get; set; }
        public long? CashierId { get; set; }
        public int? TransporterId { get; set; }
        public int? VehicleId { get; set; }
        public short? Pax { get; set; }
        public string? Explanation { get; set; }
        public string? DeliveryNotes { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public string? ShopperName { get; set; }
        public string? PromotionCode { get; set; }
        public string? CancellationExplanation { get; set; }
        public long? LoyalityCardId { get; set; }
        public int? Bonus { get; set; }
        public int? AccountSummaryCounter { get; set; }
        public short? ComplimentaryType { get; set; }
        public short? DeliveryPaymentType { get; set; }
        public short? DeliveryType { get; set; }
        public DateTime? DepartureTime { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public string? DeliveryExplanation { get; set; }
        public string? KitchenExplanation { get; set; }
        public string? ReceiveExplanation { get; set; }
        public long? TableId { get; set; }
        public DateTime? ClosingTime { get; set; }
        public byte? IsTaxExempted { get; set; }
        public byte? IsInvoiced { get; set; }
        public short? WeatherCondition { get; set; }
        public DateTime? DeliveryStartTime { get; set; }
        public DateTime? DeliveredTime { get; set; }
        public DateTime? DeliveryRequestTime { get; set; }
        public byte? IsDelivered { get; set; }
        public DateTime? PackingStartTime { get; set; }
        public DateTime? PackedTime { get; set; }
        public byte? IsPacked { get; set; }
        public DateTime? LastAddProductTime { get; set; }
        public decimal? TaxFreeAmount { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? ExciseTaxAmount { get; set; }
        public decimal? CommunicationTaxAmount { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountsTotal { get; set; }
        public decimal? DiscountsTotalGross { get; set; }
        public decimal? ExpensesTotal { get; set; }
        public decimal? GrandTotal { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? SubTotalForex { get; set; }
        public decimal? VatAmountForex { get; set; }
        public decimal? ExciseTaxAmountForex { get; set; }
        public decimal? CommunicationTaxAmountForex { get; set; }
        public decimal? DiscountsTotalForex { get; set; }
        public decimal? DiscountsTotalGrossForex { get; set; }
        public decimal? ExpensesTotalForex { get; set; }
        public decimal? GrandTotalForex { get; set; }
        public long? WorkOrderId { get; set; }
        public long? CurrentAccountReceiptId { get; set; }
        public byte? IsInstallmentSale { get; set; }
        public decimal? Amount1 { get; set; }
        public decimal? Amount2 { get; set; }
        public decimal? Amount3 { get; set; }
        public decimal? Amount4 { get; set; }
        public decimal? Commission { get; set; }
        public byte? IsCorrection { get; set; }
        public byte? IsPrinted { get; set; }
        public short? PageCount { get; set; }
        public long? ShiftsId { get; set; }
        public long? PosEndOfDateRaportId { get; set; }
        public string? CashRegisterTransactionId { get; set; }
        public string? CashRegisterReceiptNo { get; set; }
        public byte? CashRegisterTransactionOk { get; set; }
        public string? OpenSalesComputer { get; set; }
        public string? ClosedSalesComputer { get; set; }
        public string? PosMacAddress { get; set; }
        public byte? FoodBasketType { get; set; }
        public byte? IsFoodBasketOrder { get; set; }
        public byte? IsCallerIdOrder { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? ControlCode { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? DocumentSerialNo { get; set; }
        public long? ParentId { get; set; }
        public decimal? GrandTotalVatIncluded { get; set; }
        public decimal? GrandTotalForexVatIncluded { get; set; }
        public long? ShipToAddressId { get; set; }
        public long? UserAddressId { get; set; }
        public long? InvoiceAddressId { get; set; }
        public byte? IsEguestCheck { get; set; }
        public byte? EguestCheckStatus { get; set; }
        public string? EguestCheckGuid { get; set; }
        public int? EguestCheckNo { get; set; }
        public string? EinvoiceGuid { get; set; }
        public string? OkcserialNo { get; set; }
        public string? IntegratorEguestCheckId { get; set; }

        public virtual ErpAddress? Address { get; set; }
        public virtual ErpCash? Cash { get; set; }
        public virtual ErpEmployee? Cashier { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpEmployee? Courier { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccount? Dealer { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpAddress? InvoiceAddress { get; set; }
        public virtual ErpLoyalityCard? LoyalityCard { get; set; }
        public virtual ErpPo? Parent { get; set; }
        public virtual ErpPosEndOfDateRaport? PosEndOfDateRaport { get; set; }
        public virtual PosShift? Shifts { get; set; }
        public virtual ErpAddress? ShipToAddress { get; set; }
        public virtual ErpResource? Table { get; set; }
        public virtual ErpTransporter? Transporter { get; set; }
        public virtual ErpAddress? UserAddress { get; set; }
        public virtual ErpVehicle? Vehicle { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpCallerIdLog> ErpCallerIdLogs { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpGiftVoucher> ErpGiftVoucherPosReceipts { get; set; }
        public virtual ICollection<ErpGiftVoucher> ErpGiftVoucherReceivedPosReceipts { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemPayment> ErpInventoryReceiptItemPayments { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpRefundCheque> ErpRefundChequePosReceipts { get; set; }
        public virtual ICollection<ErpRefundCheque> ErpRefundChequeReceivedPosReceipts { get; set; }
        public virtual ICollection<ErpPo> InverseParent { get; set; }
    }
}
