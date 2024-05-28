﻿using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmTransactionTypeResult
    {
        public CrmTransactionTypeResult()
        {
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
        }

        public long RecId { get; set; }
        public long? TranTypeId { get; set; }
        public string? ResultCode { get; set; }
        public string? Explanation { get; set; }
        public int? Status { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual CrmTransactionType? TranType { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
    }
}
