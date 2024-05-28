using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpRouteItem
    {
        public ErpRouteItem()
        {
            ErpRecipeOprs = new HashSet<ErpRecipeOpr>();
            ErpRoutePrecessorOverlapRouteItems = new HashSet<ErpRoutePrecessor>();
            ErpRoutePrecessorRouteItems = new HashSet<ErpRoutePrecessor>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
        }

        public long RecId { get; set; }
        public int? RouteId { get; set; }
        public int? ParentProcessId { get; set; }
        public int? ProcessId { get; set; }
        public long? CurrentAccountId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public short? ItemOrderNo { get; set; }
        public byte[]? Condition { get; set; }
        public byte? CheckManufacturing { get; set; }
        public byte? CheckPlanning { get; set; }
        public byte? CheckActiveManufacturing { get; set; }
        public byte? JumpControl { get; set; }
        public byte? RawMaterialConsumption { get; set; }
        public byte? DyeRawMaterialConsumption { get; set; }
        public int? TimeUnit { get; set; }
        public decimal? ProcessTime { get; set; }
        public decimal? LotQuantity { get; set; }
        public string? Explanation { get; set; }
        public int? RecipeProgramId { get; set; }
        public short? SubContractorType { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? ResourceId { get; set; }
        public short? ControlOrderNo { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpProcess? ParentProcess { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpRecipeProgram? RecipeProgram { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ICollection<ErpRecipeOpr> ErpRecipeOprs { get; set; }
        public virtual ICollection<ErpRoutePrecessor> ErpRoutePrecessorOverlapRouteItems { get; set; }
        public virtual ICollection<ErpRoutePrecessor> ErpRoutePrecessorRouteItems { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
    }
}
