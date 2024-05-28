using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpAsserviceFaulty
    {
        public ErpAsserviceFaulty()
        {
            ErpAsserviceFaultyItems = new HashSet<ErpAsserviceFaultyItem>();
            ErpWorkOrderProgressAsserviceFaulties = new HashSet<ErpWorkOrderProgress>();
            ErpWorkOrderProgressAsserviceFaultyKindGroups = new HashSet<ErpWorkOrderProgress>();
            ErpWorkOrderProgressAsserviceFaultyKinds = new HashSet<ErpWorkOrderProgress>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public byte? FaultyType { get; set; }
        public string? FaultyCode { get; set; }
        public string? FaultyName { get; set; }
        public decimal? RepairTime { get; set; }
        public long? InventoryId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ICollection<ErpAsserviceFaultyItem> ErpAsserviceFaultyItems { get; set; }
        public virtual ICollection<ErpWorkOrderProgress> ErpWorkOrderProgressAsserviceFaulties { get; set; }
        public virtual ICollection<ErpWorkOrderProgress> ErpWorkOrderProgressAsserviceFaultyKindGroups { get; set; }
        public virtual ICollection<ErpWorkOrderProgress> ErpWorkOrderProgressAsserviceFaultyKinds { get; set; }
    }
}
