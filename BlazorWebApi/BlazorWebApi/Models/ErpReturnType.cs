using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpReturnType
    {
        public ErpReturnType()
        {
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? ReturnTypeCode { get; set; }
        public string? ReturnTypeName { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
    }
}
