using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaCreditCard
    {
        public MetaCreditCard()
        {
            ErpPaymentCards = new HashSet<ErpPaymentCard>();
            MetaCreditCardBinCodes = new HashSet<MetaCreditCardBinCode>();
            MetaCreditCardGroupItems = new HashSet<MetaCreditCardGroupItem>();
        }

        public int RecId { get; set; }
        public int? MetaBankId { get; set; }
        public string? CardName { get; set; }
        public long? SymbolId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaBank? MetaBank { get; set; }
        public virtual MetaSymbol? Symbol { get; set; }
        public virtual ICollection<ErpPaymentCard> ErpPaymentCards { get; set; }
        public virtual ICollection<MetaCreditCardBinCode> MetaCreditCardBinCodes { get; set; }
        public virtual ICollection<MetaCreditCardGroupItem> MetaCreditCardGroupItems { get; set; }
    }
}
