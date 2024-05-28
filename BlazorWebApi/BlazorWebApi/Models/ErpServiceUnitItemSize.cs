using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpServiceUnitItemSize
    {
        public ErpServiceUnitItemSize()
        {
            ErpServicePriceLists = new HashSet<ErpServicePriceList>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
        }

        public long RecId { get; set; }
        public long? ServiceId { get; set; }
        public int? UnitItemId { get; set; }
        public byte? UseForCommon { get; set; }
        public byte? UseForPurchase { get; set; }
        public byte? UseForSale { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpService? Service { get; set; }
        public virtual MetaUnitSetItem? UnitItem { get; set; }
        public virtual ICollection<ErpServicePriceList> ErpServicePriceLists { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
    }
}
