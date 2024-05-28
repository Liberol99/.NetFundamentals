using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpExpoItemDetail
    {
        public long RecId { get; set; }
        public short? Type { get; set; }
        public long? ExpoId { get; set; }
        public long? ExpoItemId { get; set; }
        public int? ItemOrderNo { get; set; }
        public string? Explanation { get; set; }
        public string? ContainerType { get; set; }
        public string? ContainerNo { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? GrossQuantity { get; set; }
        public int? UnitId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpExpo? Expo { get; set; }
        public virtual ErpExpoItem? ExpoItem { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
    }
}
