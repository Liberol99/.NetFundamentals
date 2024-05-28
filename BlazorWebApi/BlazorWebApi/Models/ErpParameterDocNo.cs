using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpParameterDocNo
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public byte? Module { get; set; }
        public short? ItemId { get; set; }
        public int? SubItemId { get; set; }
        public string? TableName { get; set; }
        public string? FieldName { get; set; }
        public string? TemplateString { get; set; }
        public string? ReceiptTypes { get; set; }
        public byte[]? Condition { get; set; }
        public byte? ControlType { get; set; }
        public byte? IsMandatory { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? CashId { get; set; }

        public virtual ErpCash? Cash { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
