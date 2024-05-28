using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBox
    {
        public ErpBox()
        {
            ErpBoxItemBoxes = new HashSet<ErpBoxItem>();
            ErpBoxItemInBoxes = new HashSet<ErpBoxItem>();
            ErpBoxTotals = new HashSet<ErpBoxTotal>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptShipments = new HashSet<ErpInventoryReceiptShipment>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public byte? BoxType { get; set; }
        public string? BoxCode { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? WorkOrderId { get; set; }
        public int? QualityTypeId { get; set; }
        public long? EmployeeId { get; set; }
        public long? InventoryReceiptShipmentId { get; set; }
        public long? ConsumptionReceiptItemId { get; set; }
        public byte? CreatedByShipmentOrder { get; set; }
        public long? WorkOrderReceiptItemId { get; set; }
        public int? WarehouseLocationId { get; set; }
        public long? OrderReceiptId { get; set; }
        public byte? InUse { get; set; }
        public byte? IsPrinted { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? PrintedAt { get; set; }
        public int? PrintedBy { get; set; }
        public long? InventoryReceiptId { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventoryReceiptItem? ConsumptionReceiptItem { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpInventoryReceipt? InventoryReceipt { get; set; }
        public virtual ErpInventoryReceiptShipment? InventoryReceiptShipment { get; set; }
        public virtual ErpOrderReceipt? OrderReceipt { get; set; }
        public virtual ErpQualityType? QualityType { get; set; }
        public virtual ErpWarehouseLocation? WarehouseLocation { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderReceiptItem { get; set; }
        public virtual ICollection<ErpBoxItem> ErpBoxItemBoxes { get; set; }
        public virtual ICollection<ErpBoxItem> ErpBoxItemInBoxes { get; set; }
        public virtual ICollection<ErpBoxTotal> ErpBoxTotals { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceiptShipment> ErpInventoryReceiptShipments { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
    }
}
