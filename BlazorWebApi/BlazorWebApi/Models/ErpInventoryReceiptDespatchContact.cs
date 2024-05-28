using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryReceiptDespatchContact
    {
        public long RecId { get; set; }
        public long? InventoryReceiptId { get; set; }
        public long? ContactId { get; set; }
        public int? VehicleId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpDespatchContact? Contact { get; set; }
        public virtual ErpInventoryReceipt? InventoryReceipt { get; set; }
        public virtual ErpVehicle? Vehicle { get; set; }
    }
}
