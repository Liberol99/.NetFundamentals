using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpTask
    {
        public ErpTask()
        {
            InverseNextTask = new HashSet<ErpTask>();
            InversePreviousTask = new HashSet<ErpTask>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public byte? StartingType { get; set; }
        public DateTime? StartingDate { get; set; }
        public short? Priority { get; set; }
        public byte? IsSingleUsage { get; set; }
        public byte? IsManualStart { get; set; }
        public int? ScheduleId { get; set; }
        public int? UserId { get; set; }
        public long? PreviousTaskId { get; set; }
        public long? NextTaskId { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public byte? Status { get; set; }
        public byte? Result { get; set; }
        public byte? TryCount { get; set; }
        public short? LatestStart { get; set; }
        public byte? LatestStartUnit { get; set; }
        public int? StartExpirationMsgId { get; set; }
        public short? MaxCompletion { get; set; }
        public byte? MaxCompletionUnit { get; set; }
        public int? CompletionExpirationMsgId { get; set; }
        public int? OnStartMsgId { get; set; }
        public int? OnSuccessMsgId { get; set; }
        public int? OnFailureMsgId { get; set; }
        public int? OnCancelMsgId { get; set; }
        public string? Explanation { get; set; }
        public byte? TranType { get; set; }
        public short? Module { get; set; }
        public short? ModuleCommand { get; set; }
        public string? ModuleCommandParameter { get; set; }
        public string? ServiceParameter { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWorkFlowMsgAddress? CompletionExpirationMsg { get; set; }
        public virtual ErpTask? NextTask { get; set; }
        public virtual ErpWorkFlowMsgAddress? OnCancelMsg { get; set; }
        public virtual ErpWorkFlowMsgAddress? OnFailureMsg { get; set; }
        public virtual ErpWorkFlowMsgAddress? OnStartMsg { get; set; }
        public virtual ErpWorkFlowMsgAddress? OnSuccessMsg { get; set; }
        public virtual ErpTask? PreviousTask { get; set; }
        public virtual MetaSchedule? Schedule { get; set; }
        public virtual ErpWorkFlowMsgAddress? StartExpirationMsg { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpTask> InverseNextTask { get; set; }
        public virtual ICollection<ErpTask> InversePreviousTask { get; set; }
    }
}
