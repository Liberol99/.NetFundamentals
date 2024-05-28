using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpAddressTelephoneFax
    {
        public long RecId { get; set; }
        public long? AddressId { get; set; }
        public byte? NumberType { get; set; }
        public string? Explanation { get; set; }
        public string? TelephoneFaxNumber { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpAddress? Address { get; set; }
    }
}
