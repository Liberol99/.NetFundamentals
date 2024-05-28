﻿using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpLocalization
    {
        public long RecId { get; set; }
        public string? TableName { get; set; }
        public string? FieldName { get; set; }
        public Guid? UniqueId { get; set; }
        public long? SourceId { get; set; }
        public int? Language { get; set; }
        public string? Content { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}