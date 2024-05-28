using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBudgetItem
    {
        public ErpBudgetItem()
        {
            InverseParentItem = new HashSet<ErpBudgetItem>();
        }

        public long RecId { get; set; }
        public long? BudgetId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? TermDate { get; set; }
        public byte? ItemType { get; set; }
        public int? CostCenterId { get; set; }
        public int? WarehouseId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? ItemOrderNo { get; set; }
        public long? SellerId { get; set; }
        public long? ParentItemId { get; set; }
        public int? CategoryId { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryGroupId { get; set; }
        public long? ServiceCardId { get; set; }
        public long? ServiceCardGroupId { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public byte? ControlCode { get; set; }
        public string? CurrentAccountCode { get; set; }
        public long? ItemId { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Fcapacity { get; set; }
        public decimal? Fturnover { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? ForexAmount { get; set; }
        public byte? Cdtype { get; set; }
        public byte? RecursiveType { get; set; }
        public int? RecursiveRange { get; set; }
        public byte? DocumentType { get; set; }
        public byte? HasInvoice { get; set; }
        public byte? IsPriceUpdate { get; set; }
        public decimal? LastPrice { get; set; }
        public decimal? LastInflowPrice { get; set; }
        public decimal? LastInflowAmount { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? CostAmount { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public byte? IsCancelled { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? AccountId { get; set; }

        public virtual ErpGlaccount? Account { get; set; }
        public virtual ErpBudget? Budget { get; set; }
        public virtual ErpCategory? Category { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryGroup? InventoryGroup { get; set; }
        public virtual ErpBudgetItem? ParentItem { get; set; }
        public virtual ErpEmployee? Seller { get; set; }
        public virtual ErpService? ServiceCard { get; set; }
        public virtual ErpServiceGroup? ServiceCardGroup { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBudgetItem> InverseParentItem { get; set; }
    }
}
