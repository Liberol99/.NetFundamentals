using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventorySerialCard
    {
        public ErpInventorySerialCard()
        {
            ErpBoxItemVariants = new HashSet<ErpBoxItemVariant>();
            ErpBoxItems = new HashSet<ErpBoxItem>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpInventoryAllocations = new HashSet<ErpInventoryAllocation>();
            ErpInventoryReceiptShipments = new HashSet<ErpInventoryReceiptShipment>();
            ErpInventorySerialAttachments = new HashSet<ErpInventorySerialAttachment>();
            ErpInventorySerialCardItems = new HashSet<ErpInventorySerialCardItem>();
            ErpInventorySerialCardTotals = new HashSet<ErpInventorySerialCardTotal>();
            ErpInventorySerialTransactions = new HashSet<ErpInventorySerialTransaction>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpWorkOrderProductionItems = new HashSet<ErpWorkOrderProductionItem>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrderProgresses = new HashSet<ErpWorkOrderProgress>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            InverseParentSerial = new HashSet<ErpInventorySerialCard>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? SerialCode { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public long? ParentSerialId { get; set; }
        public string? Explanation { get; set; }
        public string? PartyNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? SecondQuantity { get; set; }
        public decimal? UsedQuantity { get; set; }
        public short? ShelfLife { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? WarrantyStartDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? FaultValue { get; set; }
        public long? EmployeeId { get; set; }
        public int? QualityTypeId { get; set; }
        public long? WorkOrderId { get; set; }
        public long? WorkOrderReceiptItemId { get; set; }
        public long? ResourceId { get; set; }
        public byte? IsMainSerial { get; set; }
        public byte? IsWastageFabric { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public short? OrderNo { get; set; }
        public DateTime? QualityControlDate { get; set; }
        public long? QualityControlId { get; set; }
        public long? OwnerId { get; set; }
        public string? EngineSerialNo { get; set; }
        public string? ChassisSerialNo { get; set; }
        public byte? SerialType { get; set; }
        public string? UniqueCode { get; set; }
        public string? InterimChassisSerialNo { get; set; }
        public long? AsservicePartnerId { get; set; }

        public virtual ErpCurrentAccount? AsservicePartner { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpMachineOwner? Owner { get; set; }
        public virtual ErpInventorySerialCard? ParentSerial { get; set; }
        public virtual ErpQualityControl? QualityControl { get; set; }
        public virtual ErpQualityType? QualityType { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderReceiptItem { get; set; }
        public virtual ICollection<ErpBoxItemVariant> ErpBoxItemVariants { get; set; }
        public virtual ICollection<ErpBoxItem> ErpBoxItems { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocations { get; set; }
        public virtual ICollection<ErpInventoryReceiptShipment> ErpInventoryReceiptShipments { get; set; }
        public virtual ICollection<ErpInventorySerialAttachment> ErpInventorySerialAttachments { get; set; }
        public virtual ICollection<ErpInventorySerialCardItem> ErpInventorySerialCardItems { get; set; }
        public virtual ICollection<ErpInventorySerialCardTotal> ErpInventorySerialCardTotals { get; set; }
        public virtual ICollection<ErpInventorySerialTransaction> ErpInventorySerialTransactions { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpWorkOrderProductionItem> ErpWorkOrderProductionItems { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
        public virtual ICollection<ErpWorkOrderProgress> ErpWorkOrderProgresses { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpInventorySerialCard> InverseParentSerial { get; set; }
    }
}
