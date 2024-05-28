using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaCreditCardGroupItem
    {
        public int RecId { get; set; }
        public int? CreditCardGroupId { get; set; }
        public int? CreditCardId { get; set; }
        public string? Explanation { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCreditCard? CreditCard { get; set; }
        public virtual MetaCreditCardGroup? CreditCardGroup { get; set; }
    }
}
