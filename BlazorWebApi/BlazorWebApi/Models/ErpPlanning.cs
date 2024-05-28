using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPlanning
    {
        public ErpPlanning()
        {
            ErpPredecessorDependentPlannings = new HashSet<ErpPredecessor>();
            ErpPredecessorPredecessorPlannings = new HashSet<ErpPredecessor>();
            ErpResourceOutOfUses = new HashSet<ErpResourceOutOfUse>();
            InverseParent = new HashSet<ErpPlanning>();
        }

        public long RecId { get; set; }
        public short? PlanningType { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? WorkOrderId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public int? ProjectId { get; set; }
        public int? IndexOrder { get; set; }
        public int? ProcessId { get; set; }
        public long? ResourceId { get; set; }
        public long? RecipeId { get; set; }
        public long? LabRecipeId { get; set; }
        public long? PatternRecipeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? WorkplaceId { get; set; }
        public long? EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Explanation { get; set; }
        public int? LabelId { get; set; }
        public int? Indentation { get; set; }
        public int? IsExpanded { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public DateTime? MinStart { get; set; }
        public DateTime? MaxStart { get; set; }
        public DateTime? MinFinish { get; set; }
        public DateTime? MaxFinish { get; set; }
        public long? DurationTs { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualFinish { get; set; }
        public DateTime? Completion { get; set; }
        public byte? IsCompleted { get; set; }
        public decimal? CompletionPercentage { get; set; }
        public short? IsMilestone { get; set; }
        public DateTime? OldStart { get; set; }
        public DateTime? OldFinish { get; set; }
        public DateTime? OldStart2 { get; set; }
        public DateTime? OldFinish2 { get; set; }
        public DateTime? OldStart3 { get; set; }
        public DateTime? OldFinish3 { get; set; }
        public DateTime? OldStart4 { get; set; }
        public DateTime? OldFinish4 { get; set; }
        public DateTime? OldStart5 { get; set; }
        public DateTime? OldFinish5 { get; set; }
        public long? EffortTs { get; set; }
        public long? CompletedEffortTs { get; set; }
        public string? AssignedResources { get; set; }
        public string? PredecessorTaskIndexes { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexCostAmount { get; set; }
        public decimal? CostAmount { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? DailyQuantity { get; set; }
        public decimal? StartDailyQuantity { get; set; }
        public decimal? FinishDailyQuantity { get; set; }
        public string? StyleGroupCode { get; set; }
        public string? TemplateCode { get; set; }
        public byte? ControlType { get; set; }
        public byte? IsVariantBase { get; set; }
        public DateTime? FabricTermDate { get; set; }
        public int? PositionType { get; set; }
        public byte? IsManuelPosition { get; set; }
        public int? ItemOrderNo { get; set; }
        public long? ParentId { get; set; }
        public int? ReasonId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? Speed { get; set; }
        public int? TimeUnit { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpLabRecipe? LabRecipe { get; set; }
        public virtual ErpPlanning? Parent { get; set; }
        public virtual ErpLabRecipe? PatternRecipe { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpResourceOutOfUseReason? Reason { get; set; }
        public virtual ErpRecipe? Recipe { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpPredecessor> ErpPredecessorDependentPlannings { get; set; }
        public virtual ICollection<ErpPredecessor> ErpPredecessorPredecessorPlannings { get; set; }
        public virtual ICollection<ErpResourceOutOfUse> ErpResourceOutOfUses { get; set; }
        public virtual ICollection<ErpPlanning> InverseParent { get; set; }
    }
}
