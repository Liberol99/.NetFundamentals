using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDemandReceipt
    {
        public ErpDemandReceipt()
        {
            ErpDemandReceiptAttachments = new HashSet<ErpDemandReceiptAttachment>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            InverseSourceDemandReceipt = new HashSet<ErpDemandReceipt>();
            InverseWarehouseDemandReceipt = new HashSet<ErpDemandReceipt>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? ReceiptType { get; set; }
        public string? ReceiptNo { get; set; }
        public short? ReceiptUpType { get; set; }
        public short? ReceiptSubType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? ReceiptTime { get; set; }
        public DateTime? TermDate { get; set; }
        public string? DocumentNo { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? AddressId { get; set; }
        public long? ShippingAddressId { get; set; }
        public int? WarehouseId { get; set; }
        public int? CostCenterId { get; set; }
        public long? DealerId { get; set; }
        public long? PaymentPlanId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TransporterId { get; set; }
        public string? Explanation { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public byte? IsTaxExempted { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? SubTotalVatIncluded { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? VatAmountAccommodation { get; set; }
        public decimal? ExciseTaxAmount { get; set; }
        public decimal? CommunicationTaxAmount { get; set; }
        public decimal? DistributedDiscountsTotal { get; set; }
        public decimal? DistributedDiscountsTotalVatIncluded { get; set; }
        public decimal? DiscountsTotal { get; set; }
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
        public decimal? ExciseTaxAmountForex { get; set; }
        public decimal? CommunicationTaxAmountForex { get; set; }
        public decimal? DistributedDiscountsTotalForex { get; set; }
        public decimal? DistributedDiscountsTotalVatIncludedForex { get; set; }
        public decimal? DiscountsTotalForex { get; set; }
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
        public decimal? SubTotalCurrency3 { get; set; }
        public decimal? ExpensesTotalCurrency3 { get; set; }
        public decimal? DiscountsTotalCurrency3 { get; set; }
        public decimal? VatAmountCurrency3 { get; set; }
        public decimal? GrandTotalCurrency3 { get; set; }
        public decimal? WithholdingAmount1Currency3 { get; set; }
        public decimal? WithholdingAmount2Currency3 { get; set; }
        public long? WorkOrderReceiptId { get; set; }
        public long? GlreceiptId { get; set; }
        public long? CurrentAccountReceiptId { get; set; }
        public long? CustomerTransactionId { get; set; }
        public long? WarehouseDemandReceiptId { get; set; }
        public long? SourceDemandReceiptId { get; set; }
        public int? VehicleId { get; set; }
        public byte? IsPrinted { get; set; }
        public short? PageCount { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsForexReceipt { get; set; }
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
        public string? ApprovedExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? DocumentSerialNo { get; set; }
        public int? OutWarehouseId { get; set; }
        public int? WarehouseLocationId { get; set; }
        public long? LeadId { get; set; }

        public virtual ErpAddress? Address { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccountReceipt? CurrentAccountReceipt { get; set; }
        public virtual ErpCustomerTransaction? CustomerTransaction { get; set; }
        public virtual ErpCurrentAccount? Dealer { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual CrmLead? Lead { get; set; }
        public virtual ErpWarehouse? OutWarehouse { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpAddress? ShippingAddress { get; set; }
        public virtual ErpDemandReceipt? SourceDemandReceipt { get; set; }
        public virtual ErpTransporter? Transporter { get; set; }
        public virtual ErpVehicle? Vehicle { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpDemandReceipt? WarehouseDemandReceipt { get; set; }
        public virtual ErpWarehouseLocation? WarehouseLocation { get; set; }
        public virtual ErpWorkOrder? WorkOrderReceipt { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpDemandReceiptAttachment> ErpDemandReceiptAttachments { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceipt> InverseSourceDemandReceipt { get; set; }
        public virtual ICollection<ErpDemandReceipt> InverseWarehouseDemandReceipt { get; set; }
    }
}
