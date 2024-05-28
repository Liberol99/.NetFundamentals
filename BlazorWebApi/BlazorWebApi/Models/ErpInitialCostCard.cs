using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInitialCostCard
    {
        public ErpInitialCostCard()
        {
            ErpInitialCostItems = new HashSet<ErpInitialCostItem>();
            ErpProcesses = new HashSet<ErpProcess>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public byte? NameYesNo { get; set; }
        public byte? QuantityYesNo { get; set; }
        public decimal? Quantity { get; set; }
        public byte? UnitPriceYesNo { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitId { get; set; }
        public int? UnitSetId { get; set; }
        public byte? SubCost { get; set; }
        public decimal? Quantity2 { get; set; }
        public int? ActualCost { get; set; }
        public int? ForFuture { get; set; }
        public string? BudgetTerm { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? PieceYesNo { get; set; }
        public byte? InitialCostYesNo { get; set; }
        public byte? SubTotalYesNo { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpProcess? ForFutureNavigation { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual MetaUnitSet? UnitSet { get; set; }
        public virtual ICollection<ErpInitialCostItem> ErpInitialCostItems { get; set; }
        public virtual ICollection<ErpProcess> ErpProcesses { get; set; }
    }
}
