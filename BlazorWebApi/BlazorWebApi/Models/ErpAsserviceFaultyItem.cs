using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpAsserviceFaultyItem
    {
        public long RecId { get; set; }
        public long? AsserviceFaultyId { get; set; }
        public byte? ItemType { get; set; }
        public long? InventoryId { get; set; }
        public decimal? RepairTime { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? AsserviceServiceType { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? ForexId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public short? WorkOrderSubType { get; set; }
        public byte? RepairType { get; set; }

        public virtual ErpAsserviceFaulty? AsserviceFaulty { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
    }
}
