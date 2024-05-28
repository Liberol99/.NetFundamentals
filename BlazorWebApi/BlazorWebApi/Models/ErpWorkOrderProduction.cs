using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkOrderProduction
    {
        public ErpWorkOrderProduction()
        {
            ErpInventoryAllocations = new HashSet<ErpInventoryAllocation>();
            ErpInventorySerialTransactions = new HashSet<ErpInventorySerialTransaction>();
            ErpWorkOrderProductionEmployees = new HashSet<ErpWorkOrderProductionEmployee>();
            ErpWorkOrderProductionItems = new HashSet<ErpWorkOrderProductionItem>();
            ErpWorkOrderProductionVariants = new HashSet<ErpWorkOrderProductionVariant>();
            InverseParentProduction = new HashSet<ErpWorkOrderProduction>();
        }

        public long RecId { get; set; }
        public long? WorkOrderId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public long? InventoryId { get; set; }
        public short? ProductionType { get; set; }
        public short? ProductionSubType { get; set; }
        public int? SubNo { get; set; }
        public string? DocumentNo { get; set; }
        public int? ProcessId { get; set; }
        public long? StartEmployeeId { get; set; }
        public long? EmployeeId { get; set; }
        public long? OtherEmployeeId { get; set; }
        public long? ResourceId { get; set; }
        public long? RouteItemId { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? AddressId { get; set; }
        public byte? InOut { get; set; }
        public byte? InOutType { get; set; }
        public byte? SourceType { get; set; }
        public DateTime? StartProductionDate { get; set; }
        public DateTime? StartProductionTime { get; set; }
        public decimal? StartQuantity { get; set; }
        public decimal? StartFabricWidth { get; set; }
        public decimal? StartFabricGram { get; set; }
        public decimal? FabricWidth { get; set; }
        public decimal? FabricGram { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? ProductionTime { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? VatRate { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public int? Duration { get; set; }
        public string? Explanation { get; set; }
        public int? WorkOrderItemOrderNo { get; set; }
        public int? OperationItemOrderNo { get; set; }
        public long? SerialCardId { get; set; }
        public long? BoxId { get; set; }
        public long? ManufactureReceiptId { get; set; }
        public long? ConsumptionReceiptId { get; set; }
        public long? WasteReceiptId { get; set; }
        public long? InvoiceId { get; set; }
        public long? InventoryReceiptId { get; set; }
        public long? WorkOrderItemProcessId { get; set; }
        public short? RepairCount { get; set; }
        public decimal? StartPackageQuantity { get; set; }
        public decimal? PackageQuantity { get; set; }
        public decimal? ForexRate { get; set; }
        public long? InventoryAllocationId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? DocumentSerialNo { get; set; }
        public string? MarkerNo { get; set; }
        public string? Spreader { get; set; }
        public string? Cadoperator { get; set; }
        public string? Cutter { get; set; }
        public string? FabricCode { get; set; }
        public decimal? MarkerWidth { get; set; }
        public decimal? MarkerLength { get; set; }
        public decimal? WeightM2 { get; set; }
        public string? FabricType { get; set; }
        public decimal? MarkerWeight { get; set; }
        public decimal? NumberOfPlies { get; set; }
        public decimal? SentForCutting { get; set; }
        public decimal? Increase { get; set; }
        public decimal? EndOfAroll { get; set; }
        public decimal? Clipping { get; set; }
        public decimal? MarkerGrams { get; set; }
        public decimal? WeightInGrams { get; set; }
        public string? Variant1 { get; set; }
        public string? Variant2 { get; set; }
        public decimal? ReturnGrams { get; set; }
        public decimal? CuttingLoss { get; set; }
        public decimal? TotalMarker { get; set; }
        public string? Explanation1 { get; set; }
        public long? ParentProductionId { get; set; }
        public long? FabricId { get; set; }
        public int? Variant1Id { get; set; }
        public int? Variant2Id { get; set; }
        public string? PartiNo { get; set; }
        public string? WorkOrderItemIds { get; set; }

        public virtual ErpAddress? Address { get; set; }
        public virtual ErpBox? Box { get; set; }
        public virtual ErpInventoryReceipt? ConsumptionReceipt { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpInventory? Fabric { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryAllocation? InventoryAllocation { get; set; }
        public virtual ErpInventoryReceipt? InventoryReceipt { get; set; }
        public virtual ErpInvoice? Invoice { get; set; }
        public virtual ErpInventoryReceipt? ManufactureReceipt { get; set; }
        public virtual ErpEmployee? OtherEmployee { get; set; }
        public virtual ErpWorkOrderProduction? ParentProduction { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpRouteItem? RouteItem { get; set; }
        public virtual ErpInventorySerialCard? SerialCard { get; set; }
        public virtual ErpEmployee? StartEmployee { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual ErpVariantItem? Variant1Navigation { get; set; }
        public virtual ErpVariantItem? Variant2Navigation { get; set; }
        public virtual ErpInventoryReceipt? WasteReceipt { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ErpWorkOrderItemProcess? WorkOrderItemProcess { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocations { get; set; }
        public virtual ICollection<ErpInventorySerialTransaction> ErpInventorySerialTransactions { get; set; }
        public virtual ICollection<ErpWorkOrderProductionEmployee> ErpWorkOrderProductionEmployees { get; set; }
        public virtual ICollection<ErpWorkOrderProductionItem> ErpWorkOrderProductionItems { get; set; }
        public virtual ICollection<ErpWorkOrderProductionVariant> ErpWorkOrderProductionVariants { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> InverseParentProduction { get; set; }
    }
}
