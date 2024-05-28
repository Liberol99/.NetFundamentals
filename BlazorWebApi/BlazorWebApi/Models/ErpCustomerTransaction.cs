using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCustomerTransaction
    {
        public ErpCustomerTransaction()
        {
            ErpContracts = new HashSet<ErpContract>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCustomerTransactionActivities = new HashSet<ErpCustomerTransactionActivity>();
            ErpCustomerTransactionAttachments = new HashSet<ErpCustomerTransactionAttachment>();
            ErpCustomerTransactionResources = new HashSet<ErpCustomerTransactionResource>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? DocumentNo { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? LeadId { get; set; }
        public long? CacontactId { get; set; }
        public long? LeadContactId { get; set; }
        public byte? IsOutOfOffice { get; set; }
        public long? AddressId { get; set; }
        public long? CaaddressId { get; set; }
        public long? TranTypeId { get; set; }
        public long? TranSubTypeId { get; set; }
        public short? TranStatus { get; set; }
        public long? MarketingActivityId { get; set; }
        public int? DepartmentId { get; set; }
        public long? ServiceId { get; set; }
        public int? ProjectId { get; set; }
        public long? FlowItemId { get; set; }
        public long? FlowResultId { get; set; }
        public long? PrevTransactionId { get; set; }
        public short? ErpModuleNo { get; set; }
        public short? ErpModuleType { get; set; }
        public string? Explanation { get; set; }
        public DateTime? PlannedDate { get; set; }
        public DateTime? PlannedTime { get; set; }
        public short? PlannedDuration { get; set; }
        public short? PlannedDurationUnit { get; set; }
        public DateTime? ActualDate { get; set; }
        public DateTime? ActualTime { get; set; }
        public short? ActualDuration { get; set; }
        public short? ActualDurationUnit { get; set; }
        public long? TranResultId { get; set; }
        public string? PutOffExplanation { get; set; }
        public short? CancellationType { get; set; }
        public string? CancellationExplanation { get; set; }
        public string? ResultExplanation { get; set; }
        public byte? IsResultApproved { get; set; }
        public string? ResultApprovedBy { get; set; }
        public short? Priority { get; set; }
        public decimal? Price { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexPrice { get; set; }
        public short? ConnectedDocumentType { get; set; }
        public long? ConnectionNo { get; set; }
        public string? TicketNo { get; set; }
        public short? SourceModule { get; set; }
        public long? SourceId { get; set; }
        public string? SourceDocumentNo { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public long? SerialCardId { get; set; }
        public byte? ServiceType { get; set; }
        public string? FailureExplanation { get; set; }
        public string? EquipmentExplanation { get; set; }
        public byte? IsDeposited { get; set; }
        public string? DepositeExplanation { get; set; }
        public byte? DeliveryType { get; set; }
        public string? InCargoReceiptNo { get; set; }
        public string? OutCargoReceiptNo { get; set; }
        public byte? InCargoPaymentType { get; set; }
        public byte? OutCargoPaymentType { get; set; }
        public long? InventoryId { get; set; }
        public byte? IsChecked { get; set; }
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
        public string? DocumentSerialNo { get; set; }
        public string? AsserviceCaller { get; set; }
        public string? AsservicePhone { get; set; }

        public virtual ErpAddress? Address { get; set; }
        public virtual ErpAddress? Caaddress { get; set; }
        public virtual ErpCurrentAccountContact? Cacontact { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual CrmTransactionFlowItem? FlowItem { get; set; }
        public virtual CrmTransactionFlowResult? FlowResult { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual CrmLead? Lead { get; set; }
        public virtual CrmLeadContact? LeadContact { get; set; }
        public virtual CrmMarketingActivity? MarketingActivity { get; set; }
        public virtual CrmTransactionType? PrevTransaction { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpInventorySerialCard? SerialCard { get; set; }
        public virtual ErpService? Service { get; set; }
        public virtual CrmTransactionTypeResult? TranResult { get; set; }
        public virtual CrmTransactionType? TranSubType { get; set; }
        public virtual CrmTransactionType? TranType { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCustomerTransactionActivity> ErpCustomerTransactionActivities { get; set; }
        public virtual ICollection<ErpCustomerTransactionAttachment> ErpCustomerTransactionAttachments { get; set; }
        public virtual ICollection<ErpCustomerTransactionResource> ErpCustomerTransactionResources { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
    }
}
