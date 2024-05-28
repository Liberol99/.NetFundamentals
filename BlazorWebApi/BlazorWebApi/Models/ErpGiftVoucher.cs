using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGiftVoucher
    {
        public ErpGiftVoucher()
        {
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpGiftVoucherDepts = new HashSet<ErpGiftVoucherDept>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? VoucherType { get; set; }
        public string? VoucherCode { get; set; }
        public string? SerialNo { get; set; }
        public DateTime? ProducedDate { get; set; }
        public long? PosReceiptId { get; set; }
        public DateTime? PosReceiptDate { get; set; }
        public byte? IsUsed { get; set; }
        public long? ReceivedPosReceiptId { get; set; }
        public DateTime? ReceivedPosReceiptDate { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? GiftVoucherTypeId { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGiftVoucherType? GiftVoucherType { get; set; }
        public virtual ErpPo? PosReceipt { get; set; }
        public virtual ErpPo? ReceivedPosReceipt { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpGiftVoucherDept> ErpGiftVoucherDepts { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
    }
}
