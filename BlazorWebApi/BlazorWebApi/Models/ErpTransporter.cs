using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpTransporter
    {
        public ErpTransporter()
        {
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpDespatchContacts = new HashSet<ErpDespatchContact>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPos = new HashSet<ErpPo>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpVehicles = new HashSet<ErpVehicle>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? TransporterCode { get; set; }
        public string? TransporterName { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? IsCargoCompany { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpDespatchContact> ErpDespatchContacts { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpVehicle> ErpVehicles { get; set; }
    }
}
