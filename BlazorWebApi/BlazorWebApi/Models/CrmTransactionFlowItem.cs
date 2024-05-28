using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmTransactionFlowItem
    {
        public CrmTransactionFlowItem()
        {
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
        }

        public long RecId { get; set; }
        public long? FlowId { get; set; }
        public int? ItemOrderNo { get; set; }
        public int? PrevItemOrderNo { get; set; }
        public long? PrevTranTypeId { get; set; }
        public byte? IsMandatory { get; set; }
        public short? TranStatus { get; set; }
        public short? ResultStatus { get; set; }
        public short? GroupNo { get; set; }
        public string? Explanation { get; set; }
        public long? NextFlowId { get; set; }
        public long? PrevFlowId { get; set; }
        public long? StartingFlowId { get; set; }
        public long? TranTypeId { get; set; }
        public long? ServiceCardId { get; set; }
        public long? WorkFlowStateId { get; set; }
        public short? ErpModuleNo { get; set; }
        public short? ErpModuleType { get; set; }
        public short? ErpModuleOperationType { get; set; }
        public byte? AssignResource { get; set; }
        public string? ItemDay { get; set; }
        public string? ItemMonth { get; set; }
        public string? ItemYear { get; set; }
        public byte[]? ItemCondition { get; set; }
        public byte? AsForDate { get; set; }
        public string? SpecialCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual CrmTransactionFlow? Flow { get; set; }
        public virtual CrmTransactionFlow? NextFlow { get; set; }
        public virtual CrmTransactionFlow? PrevFlow { get; set; }
        public virtual CrmTransactionType? PrevTranType { get; set; }
        public virtual ErpService? ServiceCard { get; set; }
        public virtual CrmTransactionFlow? StartingFlow { get; set; }
        public virtual CrmTransactionType? TranType { get; set; }
        public virtual CrmWorkFlowState? WorkFlowState { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
    }
}
