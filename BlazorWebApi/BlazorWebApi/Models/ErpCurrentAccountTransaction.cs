using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccountTransaction
    {
        public ErpCurrentAccountTransaction()
        {
            ErpCurrentAccountAttachments = new HashSet<ErpCurrentAccountAttachment>();
        }

        public long RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? SellerId { get; set; }
        public long? CurrentAccountRiskControlId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public short? TransactionType { get; set; }
        public int? ItemOrderNo { get; set; }
        public string? Explanation { get; set; }
        public decimal? RiskLimit { get; set; }
        public decimal? TransactionAmount { get; set; }
        public decimal? Quantity { get; set; }
        public short? TransactionActionType { get; set; }
        public short? TransactionActionKind { get; set; }
        public short? TransactionAggrementType { get; set; }
        public byte? IsTemporaryLimit { get; set; }
        public byte? IsManualStopSale { get; set; }
        public int? WorkplaceId { get; set; }
        public int? DepartmentId { get; set; }
        public int? WarehouseId { get; set; }
        public byte? CreatedBySystem { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? StatusDate { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccountRiskControl? CurrentAccountRiskControl { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpEmployee? Seller { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpCurrentAccountAttachment> ErpCurrentAccountAttachments { get; set; }
    }
}
