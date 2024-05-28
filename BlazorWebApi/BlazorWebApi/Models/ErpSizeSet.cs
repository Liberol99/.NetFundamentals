using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpSizeSet
    {
        public ErpSizeSet()
        {
            ErpSizeSetItems = new HashSet<ErpSizeSetItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? AccessCode { get; set; }
        public long? InventoryId { get; set; }
        public byte? SizeSetType { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? MasterSize { get; set; }
        public string? StyleGroupCode { get; set; }
        public long? WorkOrderId { get; set; }
        public string? SvalueText { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ICollection<ErpSizeSetItem> ErpSizeSetItems { get; set; }
    }
}
