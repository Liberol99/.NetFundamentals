using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpVehicle
    {
        public ErpVehicle()
        {
            ErpContracts = new HashSet<ErpContract>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpInventoryReceiptDespatchContacts = new HashSet<ErpInventoryReceiptDespatchContact>();
            ErpInventoryReceiptShipments = new HashSet<ErpInventoryReceiptShipment>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPos = new HashSet<ErpPo>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpResources = new HashSet<ErpResource>();
            ErpVehicleAttachments = new HashSet<ErpVehicleAttachment>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? TransporterId { get; set; }
        public string? VehicleCode { get; set; }
        public string? VehicleName { get; set; }
        public short? VehicleType { get; set; }
        public decimal? WeightCapacity { get; set; }
        public decimal? VolumeCapacity { get; set; }
        public short? PaxCapacity { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public string? PlateNumber { get; set; }
        public string? MotorNo { get; set; }
        public string? ChassisNo { get; set; }
        public string? Mark { get; set; }
        public string? Model { get; set; }
        public DateTime? InspectionDate { get; set; }
        public DateTime? InsuranceDate { get; set; }
        public int? WarehouseId { get; set; }
        public int? ConnectedWarehouseId { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? CarInsuranceDate { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWarehouse? ConnectedWarehouse { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpTransporter? Transporter { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpInventoryReceiptDespatchContact> ErpInventoryReceiptDespatchContacts { get; set; }
        public virtual ICollection<ErpInventoryReceiptShipment> ErpInventoryReceiptShipments { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<ErpVehicleAttachment> ErpVehicleAttachments { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
    }
}
