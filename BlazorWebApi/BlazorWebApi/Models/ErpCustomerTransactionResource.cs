using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCustomerTransactionResource
    {
        public long RecId { get; set; }
        public long? TransactionId { get; set; }
        public short? ResourceType { get; set; }
        public long? ResourceId { get; set; }
        public byte? IsMaster { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpResource? Resource { get; set; }
        public virtual ErpCustomerTransaction? Transaction { get; set; }
    }
}
