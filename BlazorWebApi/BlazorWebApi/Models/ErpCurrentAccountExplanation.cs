﻿using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccountExplanation
    {
        public long RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? ExplanationText { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
    }
}