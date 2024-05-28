using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCompetitorProduct
    {
        public ErpCompetitorProduct()
        {
            CrmLeads = new HashSet<CrmLead>();
        }

        public int RecId { get; set; }
        public int? CompetitorId { get; set; }
        public string? ProductName { get; set; }
        public string? Explanation { get; set; }
        public long? InventoryId { get; set; }
        public long? ServiceId { get; set; }
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

        public virtual ErpCompetitor? Competitor { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpService? Service { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
    }
}
