using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpVariantCard
    {
        public ErpVariantCard()
        {
            ErpVariantItems = new HashSet<ErpVariantItem>();
        }

        public int RecId { get; set; }
        public int? TypeId { get; set; }
        public string? VariantCardCode { get; set; }
        public string? VariantCardName { get; set; }
        public int? RelatedTypeId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpVariantType? RelatedType { get; set; }
        public virtual ErpVariantType? Type { get; set; }
        public virtual ICollection<ErpVariantItem> ErpVariantItems { get; set; }
    }
}
