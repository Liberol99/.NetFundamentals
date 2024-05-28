﻿using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBankAccountWorkplace
    {
        public long RecId { get; set; }
        public int? BankAccountId { get; set; }
        public int? WorkplaceId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}