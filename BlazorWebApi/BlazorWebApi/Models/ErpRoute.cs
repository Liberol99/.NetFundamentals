using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpRoute
    {
        public ErpRoute()
        {
            ErpInitialCosts = new HashSet<ErpInitialCost>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpProductConfiguratorItems = new HashSet<ErpProductConfiguratorItem>();
            ErpProjects = new HashSet<ErpProject>();
            ErpQualityControls = new HashSet<ErpQualityControl>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpRecipes = new HashSet<ErpRecipe>();
            ErpRouteItems = new HashSet<ErpRouteItem>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? InventoryId { get; set; }
        public long? QualityControlId { get; set; }
        public string? RouteCode { get; set; }
        public string? RouteName { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public decimal? WastageRate { get; set; }
        public byte? InUse { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? WarehouseId { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpQualityControl? QualityControl { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCosts { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpProductConfiguratorItem> ErpProductConfiguratorItems { get; set; }
        public virtual ICollection<ErpProject> ErpProjects { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControls { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
        public virtual ICollection<ErpRouteItem> ErpRouteItems { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
    }
}
