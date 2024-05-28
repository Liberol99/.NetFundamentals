using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaCtsp
    {
        public MetaCtsp()
        {
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
        }

        public int RecId { get; set; }
        public int? CountryId { get; set; }
        public string? CtspCode { get; set; }
        public string? CtspName { get; set; }
        public long? CurrentAccountId { get; set; }
        public decimal? AntiDampingTaxRate { get; set; }
        public decimal? CustomTaxRate { get; set; }
        public decimal? AdditionCustomTaxRate { get; set; }
        public decimal? ReferencePrice { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCountry? Country { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
    }
}
