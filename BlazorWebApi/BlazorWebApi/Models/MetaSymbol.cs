using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaSymbol
    {
        public MetaSymbol()
        {
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpProcesses = new HashSet<ErpProcess>();
            ErpResources = new HashSet<ErpResource>();
            MetaCreditCardGroups = new HashSet<MetaCreditCardGroup>();
            MetaCreditCards = new HashSet<MetaCreditCard>();
        }

        public long RecId { get; set; }
        public short? SymbolType { get; set; }
        public int? ForegroundColor { get; set; }
        public int? BackgroundColor { get; set; }
        public byte[]? Symbol { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpProcess> ErpProcesses { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<MetaCreditCardGroup> MetaCreditCardGroups { get; set; }
        public virtual ICollection<MetaCreditCard> MetaCreditCards { get; set; }
    }
}
