using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpAddress
    {
        public ErpAddress()
        {
            ErpAddressTelephoneFaxes = new HashSet<ErpAddressTelephoneFax>();
            ErpContracts = new HashSet<ErpContract>();
            ErpCurrentAccountContacts = new HashSet<ErpCurrentAccountContact>();
            ErpCustomerTransactionAddresses = new HashSet<ErpCustomerTransaction>();
            ErpCustomerTransactionCaaddresses = new HashSet<ErpCustomerTransaction>();
            ErpDemandReceiptAddresses = new HashSet<ErpDemandReceipt>();
            ErpDemandReceiptShippingAddresses = new HashSet<ErpDemandReceipt>();
            ErpExpoAddress1s = new HashSet<ErpExpo>();
            ErpExpoAddress2s = new HashSet<ErpExpo>();
            ErpExpoAddresses = new HashSet<ErpExpo>();
            ErpInventoryReceiptAddresses = new HashSet<ErpInventoryReceipt>();
            ErpInventoryReceiptCustomerAddresses = new HashSet<ErpInventoryReceipt>();
            ErpInventoryReceiptShipToAddresses = new HashSet<ErpInventoryReceipt>();
            ErpInvoiceAddresses = new HashSet<ErpInvoice>();
            ErpInvoiceCustomerAddresses = new HashSet<ErpInvoice>();
            ErpInvoiceShipToAddresses = new HashSet<ErpInvoice>();
            ErpOrderReceiptAddresses = new HashSet<ErpOrderReceipt>();
            ErpOrderReceiptCustomerAddresses = new HashSet<ErpOrderReceipt>();
            ErpOrderReceiptShipToAddresses = new HashSet<ErpOrderReceipt>();
            ErpOrderReceiptShippingAddresses = new HashSet<ErpOrderReceipt>();
            ErpPackingLists = new HashSet<ErpPackingList>();
            ErpPoAddresses = new HashSet<ErpPo>();
            ErpPoInvoiceAddresses = new HashSet<ErpPo>();
            ErpPoShipToAddresses = new HashSet<ErpPo>();
            ErpPoUserAddresses = new HashSet<ErpPo>();
            ErpProjects = new HashSet<ErpProject>();
            ErpQuotationReceiptAddresses = new HashSet<ErpQuotationReceipt>();
            ErpQuotationReceiptShippingAddresses = new HashSet<ErpQuotationReceipt>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
        }

        public long RecId { get; set; }
        public string? AddressCode { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? GuarantorId { get; set; }
        public long? LeadId { get; set; }
        public long? GuestId { get; set; }
        public byte? AddressType { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public long? SellerId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        public string? Direction1 { get; set; }
        public string? Direction2 { get; set; }
        public string? Direction3 { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public string? PostalCode { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? TownId { get; set; }
        public int? StreetId { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? TimeZone { get; set; }
        public byte? IsDefault { get; set; }
        public int? WarehouseId { get; set; }
        public string? Boulevard { get; set; }
        public string? Aveneu { get; set; }
        public string? Street { get; set; }
        public string? Neighborhood { get; set; }
        public string? ExteriorDoor { get; set; }
        public string? InteriorDoor { get; set; }
        public string? Village { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? UserId { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual ErpGuarantor? Guarantor { get; set; }
        public virtual CrmLead? Lead { get; set; }
        public virtual ErpEmployee? Seller { get; set; }
        public virtual MetaState? State { get; set; }
        public virtual MetaStreet? StreetNavigation { get; set; }
        public virtual MetaTown? Town { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpAddressTelephoneFax> ErpAddressTelephoneFaxes { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCurrentAccountContact> ErpCurrentAccountContacts { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactionAddresses { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactionCaaddresses { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceiptAddresses { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceiptShippingAddresses { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoAddress1s { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoAddress2s { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoAddresses { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptAddresses { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptCustomerAddresses { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptShipToAddresses { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceAddresses { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceCustomerAddresses { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceShipToAddresses { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceiptAddresses { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceiptCustomerAddresses { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceiptShipToAddresses { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceiptShippingAddresses { get; set; }
        public virtual ICollection<ErpPackingList> ErpPackingLists { get; set; }
        public virtual ICollection<ErpPo> ErpPoAddresses { get; set; }
        public virtual ICollection<ErpPo> ErpPoInvoiceAddresses { get; set; }
        public virtual ICollection<ErpPo> ErpPoShipToAddresses { get; set; }
        public virtual ICollection<ErpPo> ErpPoUserAddresses { get; set; }
        public virtual ICollection<ErpProject> ErpProjects { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceiptAddresses { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceiptShippingAddresses { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
    }
}
