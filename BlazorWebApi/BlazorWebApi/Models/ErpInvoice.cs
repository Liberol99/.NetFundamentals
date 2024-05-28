using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInvoice
    {
        public ErpInvoice()
        {
            ErpBankCredits = new HashSet<ErpBankCredit>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpEinvoices = new HashSet<ErpEinvoice>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpExpos = new HashSet<ErpExpo>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoiceAttachments = new HashSet<ErpInvoiceAttachment>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            InverseForexRateDifferenceInvoice = new HashSet<ErpInvoice>();
            InversePriceDifferenceInvoice = new HashSet<ErpInvoice>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? ReceiptType { get; set; }
        public string? ReceiptNo { get; set; }
        public short? ReceiptSubType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? ReceiptTime { get; set; }
        public string? DocumentNo { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? AddressId { get; set; }
        public long? ShipToCurrentAccountId { get; set; }
        public long? ShipToAddressId { get; set; }
        public long? PaymentToCurrentAccountId { get; set; }
        public int? InWarehouseId { get; set; }
        public int? OutWarehouseId { get; set; }
        public int? CostCenterId { get; set; }
        public long? DealerId { get; set; }
        public long? CustomerId { get; set; }
        public long? CustomerAddressId { get; set; }
        public long? BrokerId { get; set; }
        public long? ManufacturerId { get; set; }
        public long? PaymentPlanId { get; set; }
        public string? CustomerOrderNo { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public long? ContactId { get; set; }
        public int? CashId { get; set; }
        public int? TransporterId { get; set; }
        public int? VehicleId { get; set; }
        public byte? HasNegativeEffect { get; set; }
        public string? Explanation { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public DateTime? TermDate { get; set; }
        public byte? IsTaxExempted { get; set; }
        public byte? IsManualVat { get; set; }
        public byte? IsManuelWithholding { get; set; }
        public int? Bonus { get; set; }
        public decimal? RoundingAmount { get; set; }
        public byte? WithholdingFactor { get; set; }
        public byte? WithholdingDivisor { get; set; }
        public decimal? Rate1 { get; set; }
        public decimal? Rate2 { get; set; }
        public decimal? Rate3 { get; set; }
        public decimal? Rate4 { get; set; }
        public decimal? Rate5 { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? SubTotalVatIncluded { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? VatAmountAccommodation { get; set; }
        public decimal? WithholdingAmount1 { get; set; }
        public decimal? WithholdingAmount2 { get; set; }
        public short? WithholdingType { get; set; }
        public decimal? Rate1Amount { get; set; }
        public decimal? Rate2Amount { get; set; }
        public decimal? Rate3Amount { get; set; }
        public decimal? Rate4Amount { get; set; }
        public decimal? Rate5Amount { get; set; }
        public decimal? ExciseTaxAmount { get; set; }
        public decimal? CommunicationTaxAmount { get; set; }
        public decimal? DistributedDiscountsTotal { get; set; }
        public decimal? DistributedDiscountsTotalVatIncluded { get; set; }
        public decimal? DiscountsTotal { get; set; }
        public decimal? DiscountsTotalGross { get; set; }
        public decimal? DiscountsTotalVatIncluded { get; set; }
        public decimal? DistributedExpensesTotal { get; set; }
        public decimal? ExpensesTotal { get; set; }
        public decimal? GrandTotal { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? SubTotalForex { get; set; }
        public decimal? SubTotalVatIncludedForex { get; set; }
        public decimal? VatAmountForex { get; set; }
        public decimal? VatAmountAccommodationForex { get; set; }
        public decimal? WithholdingAmount1Forex { get; set; }
        public decimal? WithholdingAmount2Forex { get; set; }
        public decimal? Rate1AmountForex { get; set; }
        public decimal? Rate2AmountForex { get; set; }
        public decimal? Rate3AmountForex { get; set; }
        public decimal? Rate4AmountForex { get; set; }
        public decimal? Rate5AmountForex { get; set; }
        public decimal? ExciseTaxAmountForex { get; set; }
        public decimal? CommunicationTaxAmountForex { get; set; }
        public decimal? DistributedDiscountsTotalForex { get; set; }
        public decimal? DistributedDiscountsTotalVatIncludedForex { get; set; }
        public decimal? DiscountsTotalForex { get; set; }
        public decimal? DiscountsTotalGrossForex { get; set; }
        public decimal? DiscountsTotalVatIncludedForex { get; set; }
        public decimal? DistributedExpensesTotalForex { get; set; }
        public decimal? ExpensesTotalForex { get; set; }
        public decimal? GrandTotalForex { get; set; }
        public decimal? SubTotalCurrency2 { get; set; }
        public decimal? ExpensesTotalCurrency2 { get; set; }
        public decimal? DiscountsTotalCurrency2 { get; set; }
        public decimal? VatAmountCurrency2 { get; set; }
        public decimal? GrandTotalCurrency2 { get; set; }
        public decimal? WithholdingAmount1Currency2 { get; set; }
        public decimal? WithholdingAmount2Currency2 { get; set; }
        public decimal? Rate1AmountCurrency2 { get; set; }
        public decimal? Rate2AmountCurrency2 { get; set; }
        public decimal? Rate3AmountCurrency2 { get; set; }
        public decimal? Rate4AmountCurrency2 { get; set; }
        public decimal? Rate5AmountCurrency2 { get; set; }
        public decimal? SubTotalCurrency3 { get; set; }
        public decimal? ExpensesTotalCurrency3 { get; set; }
        public decimal? DiscountsTotalCurrency3 { get; set; }
        public decimal? VatAmountCurrency3 { get; set; }
        public decimal? GrandTotalCurrency3 { get; set; }
        public decimal? WithholdingAmount1Currency3 { get; set; }
        public decimal? WithholdingAmount2Currency3 { get; set; }
        public decimal? Rate1AmountCurrency3 { get; set; }
        public decimal? Rate2AmountCurrency3 { get; set; }
        public decimal? Rate3AmountCurrency3 { get; set; }
        public decimal? Rate4AmountCurrency3 { get; set; }
        public decimal? Rate5AmountCurrency3 { get; set; }
        public long? InventoryReceiptId { get; set; }
        public long? WorkOrderReceiptId { get; set; }
        public long? GlreceiptId { get; set; }
        public long? CurrentAccountReceiptId { get; set; }
        public long? CustomerTransactionId { get; set; }
        public DateTime? DischargeDate { get; set; }
        public byte? IsEximReceipt { get; set; }
        public byte? IsForexReceipt { get; set; }
        public byte? IsBrokerageInvoice { get; set; }
        public byte? IsExportRegistered { get; set; }
        public byte? IsPrinted { get; set; }
        public short? PageCount { get; set; }
        public decimal? BlockedAmount { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? ControlCode { get; set; }
        public byte? NotForPaymentPlan { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public byte? IsEtrade { get; set; }
        public byte? IsEinvoice { get; set; }
        public byte? IsForexEinvoice { get; set; }
        public byte? IsEsendMail { get; set; }
        public byte? EinvoiceScenario { get; set; }
        public byte? EinvoiceStatus { get; set; }
        public DateTime? EinvoicePeriodStart { get; set; }
        public DateTime? EinvoicePeriodEnd { get; set; }
        public string? EinvoiceGuid { get; set; }
        public int? EinvoiceNo { get; set; }
        public string? EinvoiceTaxTypeCode { get; set; }
        public string? EinvoiceTaxExemptionReasonCode { get; set; }
        public string? EarchivesShippingType { get; set; }
        public string? EarchivesSummaryValue { get; set; }
        public string? EarchivesInstallationNo { get; set; }
        public string? EarchivesWebAddress { get; set; }
        public string? EarchivesPaymentType { get; set; }
        public string? EarchivesPaymentTypeOtherExp { get; set; }
        public DateTime? EarchivesSendDate { get; set; }
        public long? EarchivesCargoId { get; set; }
        public long? CustomsCurrentAccountId { get; set; }
        public long? PosReceiptId { get; set; }
        public long? CreditCardReceiptId { get; set; }
        public long? BankCreditItemId { get; set; }
        public byte? IsLeasing { get; set; }
        public string? VatListField01 { get; set; }
        public string? VatListField02 { get; set; }
        public string? VatListField03 { get; set; }
        public byte? VatListField04 { get; set; }
        public string? VatListField05 { get; set; }
        public string? SgkDocumentNo { get; set; }
        public string? ReturnOperationType { get; set; }
        public byte? ExportImportType { get; set; }
        public byte? PaymentType { get; set; }
        public byte? DeliveryType { get; set; }
        public short? PackageType { get; set; }
        public string? PackageMark { get; set; }
        public string? PackagingNo { get; set; }
        public byte? TransportType { get; set; }
        public byte? IsFreeOfCharge { get; set; }
        public byte? IsSpecialBase { get; set; }
        public byte? IsShippedLater { get; set; }
        public byte? IsFromNetAmount { get; set; }
        public string? TradeName { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public string? ApprovedExplanation { get; set; }
        public string? DocumentSerialNo { get; set; }
        public string? UdEinvoiceIntegratorInvoiceId { get; set; }
        public long? CurrentAccountBankId { get; set; }
        public long? ForexRateDifferenceInvoiceId { get; set; }
        public long? PriceDifferenceInvoiceId { get; set; }
        public byte? IsGroupSales { get; set; }
        public byte? IsCostDistribution { get; set; }
        public int? QcrejectedWarehouseId { get; set; }
        public long? GlreceiptId1 { get; set; }
        public short? ReceiptUpType { get; set; }
        public int? PaymentCardId { get; set; }
        public byte? IsSendEinvoice { get; set; }

        public virtual ErpAddress? Address { get; set; }
        public virtual ErpBankCreditItem? BankCreditItem { get; set; }
        public virtual ErpCurrentAccount? Broker { get; set; }
        public virtual ErpCash? Cash { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccountContact? Contact { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccountBank? CurrentAccountBank { get; set; }
        public virtual ErpCurrentAccountReceiptItem? CurrentAccountReceipt { get; set; }
        public virtual ErpCurrentAccount? Customer { get; set; }
        public virtual ErpAddress? CustomerAddress { get; set; }
        public virtual ErpCustomerTransaction? CustomerTransaction { get; set; }
        public virtual ErpCurrentAccount? CustomsCurrentAccount { get; set; }
        public virtual ErpCurrentAccount? Dealer { get; set; }
        public virtual ErpCurrentAccount? EarchivesCargo { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInvoice? ForexRateDifferenceInvoice { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual ErpGlreceipt? GlreceiptId1Navigation { get; set; }
        public virtual ErpWarehouse? InWarehouse { get; set; }
        public virtual ErpInventoryReceipt? InventoryReceipt { get; set; }
        public virtual ErpCurrentAccount? Manufacturer { get; set; }
        public virtual ErpWarehouse? OutWarehouse { get; set; }
        public virtual ErpPaymentCard? PaymentCard { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual ErpCurrentAccount? PaymentToCurrentAccount { get; set; }
        public virtual ErpPo? PosReceipt { get; set; }
        public virtual ErpInvoice? PriceDifferenceInvoice { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpWarehouse? QcrejectedWarehouse { get; set; }
        public virtual ErpAddress? ShipToAddress { get; set; }
        public virtual ErpCurrentAccount? ShipToCurrentAccount { get; set; }
        public virtual ErpTransporter? Transporter { get; set; }
        public virtual ErpVehicle? Vehicle { get; set; }
        public virtual ErpWorkOrder? WorkOrderReceipt { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCredits { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpEinvoice> ErpEinvoices { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpExpo> ErpExpos { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoiceAttachment> ErpInvoiceAttachments { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpInvoice> InverseForexRateDifferenceInvoice { get; set; }
        public virtual ICollection<ErpInvoice> InversePriceDifferenceInvoice { get; set; }
    }
}
