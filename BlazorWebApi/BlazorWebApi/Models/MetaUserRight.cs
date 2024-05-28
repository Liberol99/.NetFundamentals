using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaUserRight
    {
        public int RecId { get; set; }
        public byte? Type { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public short? LogicalModule { get; set; }
        public short? Module { get; set; }
        public short? ItemId { get; set; }
        public int? SubItemId { get; set; }
        public string? TableName { get; set; }
        public string? FieldName { get; set; }
        public byte? UserRight { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual MetaUser? User { get; set; }
    }
}
