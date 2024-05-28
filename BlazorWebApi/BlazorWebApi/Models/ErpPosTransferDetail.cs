using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPosTransferDetail
    {
        public long RecId { get; set; }
        public short? TransferType { get; set; }
        public DateTime? TransferDate { get; set; }
        public long? OldPosReceiptId { get; set; }
        public long? OldTableId { get; set; }
        public long? OldEmployeeId { get; set; }
        public long? OldInventoryReceiptItemId { get; set; }
        public long? NewPosReceiptId { get; set; }
        public long? NewTableId { get; set; }
        public long? NewEmployeeId { get; set; }
        public long? NewInventoryReceiptItemId { get; set; }
        public string? Explanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
