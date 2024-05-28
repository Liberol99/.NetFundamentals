using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkFlowCardItem
    {
        public int RecId { get; set; }
        public int? WorkFlowCardId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? WorkFlowRoleId { get; set; }
        public int? WorkFlowRoleUserId { get; set; }
        public byte[]? Condition { get; set; }
        public byte? TranType { get; set; }
        public short? Module { get; set; }
        public short? ModuleCommand { get; set; }
        public string? Explanation { get; set; }
        public short? LatestStart { get; set; }
        public byte? LatestStartUnit { get; set; }
        public int? StartExpirationMsgId { get; set; }
        public short? MaxCompletion { get; set; }
        public byte? MaxCompletionUnit { get; set; }
        public int? CompletionExpirationMsgId { get; set; }
        public int? OnStartMsgId { get; set; }
        public int? OnSuccessMsgId { get; set; }
        public int? OnFailureMsgId { get; set; }
        public string? ModuleCommandParameter { get; set; }
        public string? Boname { get; set; }
        public string? ItemTableName { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpWorkFlowMsgAddress? CompletionExpirationMsg { get; set; }
        public virtual ErpWorkFlowMsgAddress? OnFailureMsg { get; set; }
        public virtual ErpWorkFlowMsgAddress? OnStartMsg { get; set; }
        public virtual ErpWorkFlowMsgAddress? OnSuccessMsg { get; set; }
        public virtual ErpWorkFlowMsgAddress? StartExpirationMsg { get; set; }
        public virtual ErpWorkFlowCard? WorkFlowCard { get; set; }
        public virtual MetaUser? WorkFlowRoleUser { get; set; }
    }
}
