using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpTax
    {
        public ErpTax()
        {
            ErpInventoryRetailReturnVats = new HashSet<ErpInventory>();
            ErpInventoryRetailVats = new HashSet<ErpInventory>();
            ErpInventoryTaxes = new HashSet<ErpInventory>();
            ErpInventoryVats = new HashSet<ErpInventory>();
            ErpInventoryWholeSaleReturnVats = new HashSet<ErpInventory>();
            ErpInventoryWholeSaleVats = new HashSet<ErpInventory>();
            ErpServiceAccvats = new HashSet<ErpService>();
            ErpServiceExtvats = new HashSet<ErpService>();
            ErpServicePurchaseReturnVats = new HashSet<ErpService>();
            ErpServicePurchaseVats = new HashSet<ErpService>();
            ErpServiceSalesReturnVats = new HashSet<ErpService>();
            ErpServiceSalesVats = new HashSet<ErpService>();
            ErpServiceSctvats = new HashSet<ErpService>();
            ErpServiceTaxes = new HashSet<ErpService>();
            ErpTaxIas = new HashSet<ErpTaxIa>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public byte? TaxType { get; set; }
        public string? TaxCode { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public string? UniversalCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryRetailReturnVats { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryRetailVats { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryTaxes { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryVats { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryWholeSaleReturnVats { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryWholeSaleVats { get; set; }
        public virtual ICollection<ErpService> ErpServiceAccvats { get; set; }
        public virtual ICollection<ErpService> ErpServiceExtvats { get; set; }
        public virtual ICollection<ErpService> ErpServicePurchaseReturnVats { get; set; }
        public virtual ICollection<ErpService> ErpServicePurchaseVats { get; set; }
        public virtual ICollection<ErpService> ErpServiceSalesReturnVats { get; set; }
        public virtual ICollection<ErpService> ErpServiceSalesVats { get; set; }
        public virtual ICollection<ErpService> ErpServiceSctvats { get; set; }
        public virtual ICollection<ErpService> ErpServiceTaxes { get; set; }
        public virtual ICollection<ErpTaxIa> ErpTaxIas { get; set; }
    }
}
