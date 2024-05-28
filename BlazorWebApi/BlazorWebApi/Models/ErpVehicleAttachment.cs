﻿using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpVehicleAttachment
    {
        public long RecId { get; set; }
        public int? VehicleId { get; set; }
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

        public virtual ErpVehicle? Vehicle { get; set; }
    }
}
