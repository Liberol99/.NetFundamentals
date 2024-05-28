using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkFlowMsgAddress
    {
        public ErpWorkFlowMsgAddress()
        {
            ErpTaskCompletionExpirationMsgs = new HashSet<ErpTask>();
            ErpTaskOnCancelMsgs = new HashSet<ErpTask>();
            ErpTaskOnFailureMsgs = new HashSet<ErpTask>();
            ErpTaskOnStartMsgs = new HashSet<ErpTask>();
            ErpTaskOnSuccessMsgs = new HashSet<ErpTask>();
            ErpTaskStartExpirationMsgs = new HashSet<ErpTask>();
            ErpWorkFlowCardItemCompletionExpirationMsgs = new HashSet<ErpWorkFlowCardItem>();
            ErpWorkFlowCardItemOnFailureMsgs = new HashSet<ErpWorkFlowCardItem>();
            ErpWorkFlowCardItemOnStartMsgs = new HashSet<ErpWorkFlowCardItem>();
            ErpWorkFlowCardItemOnSuccessMsgs = new HashSet<ErpWorkFlowCardItem>();
            ErpWorkFlowCardItemStartExpirationMsgs = new HashSet<ErpWorkFlowCardItem>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? Explanation { get; set; }
        public byte? MsgType { get; set; }
        public string? MsgAddress { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpTask> ErpTaskCompletionExpirationMsgs { get; set; }
        public virtual ICollection<ErpTask> ErpTaskOnCancelMsgs { get; set; }
        public virtual ICollection<ErpTask> ErpTaskOnFailureMsgs { get; set; }
        public virtual ICollection<ErpTask> ErpTaskOnStartMsgs { get; set; }
        public virtual ICollection<ErpTask> ErpTaskOnSuccessMsgs { get; set; }
        public virtual ICollection<ErpTask> ErpTaskStartExpirationMsgs { get; set; }
        public virtual ICollection<ErpWorkFlowCardItem> ErpWorkFlowCardItemCompletionExpirationMsgs { get; set; }
        public virtual ICollection<ErpWorkFlowCardItem> ErpWorkFlowCardItemOnFailureMsgs { get; set; }
        public virtual ICollection<ErpWorkFlowCardItem> ErpWorkFlowCardItemOnStartMsgs { get; set; }
        public virtual ICollection<ErpWorkFlowCardItem> ErpWorkFlowCardItemOnSuccessMsgs { get; set; }
        public virtual ICollection<ErpWorkFlowCardItem> ErpWorkFlowCardItemStartExpirationMsgs { get; set; }
    }
}
