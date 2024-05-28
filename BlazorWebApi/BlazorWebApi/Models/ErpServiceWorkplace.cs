﻿using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpServiceWorkplace
    {
        public long RecId { get; set; }
        public long? ServiceId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? WarehouseId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }

        public virtual ErpService? Service { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
