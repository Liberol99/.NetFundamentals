using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpActualCost
    {
        public ErpActualCost()
        {
            InverseParent = new HashSet<ErpActualCost>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? ActualCostNo { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? ParentId { get; set; }
        public long? InventoryId { get; set; }
        public short? Year { get; set; }
        public short? Month { get; set; }
        public long? WorkOrderId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public short? ActualType { get; set; }
        public string? Explanation { get; set; }
        public int? ForexId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? CuttingQuantity { get; set; }
        public decimal? ShipmentQuantity { get; set; }
        public decimal? RemainingQuantity { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? ForexAmount { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? Forex2UnitPrice { get; set; }
        public decimal? Forex2Amount { get; set; }
        public decimal? TotalIncome { get; set; }
        public decimal? TotalForexIncome { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalForexCost { get; set; }
        public decimal? TotalProfit { get; set; }
        public decimal? TotalForexProfit { get; set; }
        public decimal? TotalUnitProfit { get; set; }
        public decimal? TotalUnitForexProfit { get; set; }
        public decimal? InitialQuantity { get; set; }
        public decimal? InitialUnitPrice { get; set; }
        public decimal? InitialAmount { get; set; }
        public decimal? InitialForexUnitPrice { get; set; }
        public decimal? InitialForexAmount { get; set; }
        public decimal? ReturnQuantity { get; set; }
        public decimal? ReturnUnitPrice { get; set; }
        public decimal? ReturnAmount { get; set; }
        public decimal? ReturnForexUnitPrice { get; set; }
        public decimal? ReturnForexAmount { get; set; }
        public decimal? ReturnForex2UnitPrice { get; set; }
        public decimal? ReturnForex2Amount { get; set; }
        public decimal? SalesQuantity { get; set; }
        public decimal? SalesUnitPrice { get; set; }
        public decimal? SalesAmount { get; set; }
        public decimal? SalesForexUnitPrice { get; set; }
        public decimal? SalesForexAmount { get; set; }
        public decimal? SalesReturnQuantity { get; set; }
        public decimal? SalesReturnUnitPrice { get; set; }
        public decimal? SalesReturnAmount { get; set; }
        public decimal? SalesReturnForexUnitPrice { get; set; }
        public decimal? SalesReturnForexAmount { get; set; }
        public short? ReceiptType { get; set; }
        public long? ReceiptRecId { get; set; }
        public string? Color { get; set; }
        public byte? InUse { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? GlreceiptId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? GroupCode { get; set; }
        public string? GroupName { get; set; }
        public string? ParentWorkOrderNo { get; set; }
        public string? VersionType { get; set; }
        public decimal? TotalForex2Income { get; set; }
        public decimal? TotalForex2Profit { get; set; }
        public decimal? TotalUnitForex2Profit { get; set; }
        public decimal? CutQuantity { get; set; }
        public decimal? SewingQuantity { get; set; }
        public decimal? LostQuantity { get; set; }
        public decimal? OverheadCostRate { get; set; }
        public decimal? OverheadCostAmount { get; set; }
        public decimal? OverheadCostForexAmount { get; set; }
        public decimal? OverheadCostForex2Amount { get; set; }
        public decimal? CommissionRate { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? CommissionForexAmount { get; set; }
        public decimal? CommissionForex2Amount { get; set; }
        public decimal? LeftoverGoodsPrice { get; set; }
        public decimal? TotalForex2Cost { get; set; }
        public decimal? SalesForex2UnitPrice { get; set; }
        public decimal? SalesForex2Amount { get; set; }
        public decimal? SalesReturnForex2UnitPrice { get; set; }
        public decimal? SalesReturnForex2Amount { get; set; }
        public DateTime? CostStartDate { get; set; }
        public DateTime? CostFinishDate { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpActualCost? Parent { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ICollection<ErpActualCost> InverseParent { get; set; }
    }
}
