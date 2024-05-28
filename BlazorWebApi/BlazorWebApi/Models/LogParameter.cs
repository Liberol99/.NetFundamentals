using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class LogParameter
    {
        public int RecId { get; set; }
        public short? LogicalModule { get; set; }
        public short? Module { get; set; }
        public short? ItemId { get; set; }
        public int? SubItemId { get; set; }
        public byte? LogRight { get; set; }
        public byte[]? Condition { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
