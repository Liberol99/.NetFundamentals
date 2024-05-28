using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaInventory
    {
        public long RecId { get; set; }
        public string? Barcode { get; set; }
        public string? InventoryName { get; set; }
        public string? DepartmentName { get; set; }
        public decimal? RetailTaxRate { get; set; }
        public decimal? WholeSaleTaxRate { get; set; }
        public string? UnitName { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
