using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaUnitSet
    {
        public MetaUnitSet()
        {
            ErpInitialCostCards = new HashSet<ErpInitialCostCard>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpPackingListItems = new HashSet<ErpPackingListItem>();
            ErpServices = new HashSet<ErpService>();
            MetaUnitSetItems = new HashSet<MetaUnitSetItem>();
        }

        public int RecId { get; set; }
        public string? SetCode { get; set; }
        public string? SetName { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? SystemSet { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<ErpInitialCostCard> ErpInitialCostCards { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpPackingListItem> ErpPackingListItems { get; set; }
        public virtual ICollection<ErpService> ErpServices { get; set; }
        public virtual ICollection<MetaUnitSetItem> MetaUnitSetItems { get; set; }
    }
}
