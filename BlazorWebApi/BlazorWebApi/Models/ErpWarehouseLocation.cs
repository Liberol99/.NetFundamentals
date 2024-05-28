using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWarehouseLocation
    {
        public ErpWarehouseLocation()
        {
            ErpBoxTotals = new HashSet<ErpBoxTotal>();
            ErpBoxes = new HashSet<ErpBox>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpInventoryReceiptItemInWarehouseLocations = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptItemOutWarehouseLocations = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptItemVariantInWarehouseLocations = new HashSet<ErpInventoryReceiptItemVariant>();
            ErpInventoryReceiptItemVariantOutWarehouseLocations = new HashSet<ErpInventoryReceiptItemVariant>();
            ErpInventoryReceiptShipments = new HashSet<ErpInventoryReceiptShipment>();
            ErpInventorySerialCardTotals = new HashSet<ErpInventorySerialCardTotal>();
            ErpInventorySerialTransactionInWarehouseLocations = new HashSet<ErpInventorySerialTransaction>();
            ErpInventorySerialTransactionOutWarehouseLocations = new HashSet<ErpInventorySerialTransaction>();
            ErpInventoryWarehouses = new HashSet<ErpInventoryWarehouse>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpWarehouseLocationTotals = new HashSet<ErpWarehouseLocationTotal>();
        }

        public int RecId { get; set; }
        public int? WarehouseId { get; set; }
        public string? LocationCode { get; set; }
        public string? Explanation { get; set; }
        public byte? BarcodeType { get; set; }
        public string? Barcode { get; set; }
        public string? Corridor { get; set; }
        public string? Shelf { get; set; }
        public string? Division { get; set; }
        public decimal? LocWidth { get; set; }
        public int? LocWidthUnitId { get; set; }
        public decimal? LocLength { get; set; }
        public int? LocLengthUnitId { get; set; }
        public decimal? LocHeight { get; set; }
        public int? LocHeightUnitId { get; set; }
        public decimal? MaxWeight { get; set; }
        public int? MaxWeightUnitId { get; set; }
        public decimal? LocVolume { get; set; }
        public int? LocVolumeUnitId { get; set; }
        public byte? InUse { get; set; }
        public string? AccessCode { get; set; }
        public string? SpecialCode { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? InventoryId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DepartmentId2 { get; set; }
        public int? InventoryWarehouseId { get; set; }
        public string? ShelfCompartment { get; set; }
        public short? PaletType { get; set; }
        public short? PackageType { get; set; }
        public byte? DefaultQuantity { get; set; }

        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpDepartment? DepartmentId2Navigation { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpWarehouse? InventoryWarehouse { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ICollection<ErpBoxTotal> ErpBoxTotals { get; set; }
        public virtual ICollection<ErpBox> ErpBoxes { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemInWarehouseLocations { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemOutWarehouseLocations { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> ErpInventoryReceiptItemVariantInWarehouseLocations { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> ErpInventoryReceiptItemVariantOutWarehouseLocations { get; set; }
        public virtual ICollection<ErpInventoryReceiptShipment> ErpInventoryReceiptShipments { get; set; }
        public virtual ICollection<ErpInventorySerialCardTotal> ErpInventorySerialCardTotals { get; set; }
        public virtual ICollection<ErpInventorySerialTransaction> ErpInventorySerialTransactionInWarehouseLocations { get; set; }
        public virtual ICollection<ErpInventorySerialTransaction> ErpInventorySerialTransactionOutWarehouseLocations { get; set; }
        public virtual ICollection<ErpInventoryWarehouse> ErpInventoryWarehouses { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpWarehouseLocationTotal> ErpWarehouseLocationTotals { get; set; }
    }
}
