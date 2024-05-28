﻿using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDemandReceiptAttachment
    {
        public long RecId { get; set; }
        public long? DemandReceiptId { get; set; }
        public short? Type { get; set; }
        public string? Explanation { get; set; }
        public string? FileName { get; set; }
        public byte[]? Attachment { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpDemandReceipt? DemandReceipt { get; set; }
    }
}
