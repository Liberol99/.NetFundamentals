using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBudget
    {
        public ErpBudget()
        {
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            InverseRevisedReceipt = new HashSet<ErpBudget>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? CostCenterId { get; set; }
        public int? WarehouseId { get; set; }
        public long? RevisedReceiptId { get; set; }
        public short? BudgetType { get; set; }
        public string? BudgetNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? Explanation { get; set; }
        public byte? ControlCode { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? IsClosed { get; set; }
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

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpBudget? RevisedReceipt { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpBudget> InverseRevisedReceipt { get; set; }
    }
}
