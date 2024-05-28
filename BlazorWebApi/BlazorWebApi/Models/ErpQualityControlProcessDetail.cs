using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpQualityControlProcessDetail
    {
        public long RecId { get; set; }
        public long? QualityControlId { get; set; }
        public byte? DetailType { get; set; }
        public short? QualityControlType { get; set; }
        public int? ItemOrderNo { get; set; }
        public int? ProcessId { get; set; }
        public int? DepartmentId { get; set; }
        public long? ResourceId { get; set; }
        public DateTime? QualityControlTestDate { get; set; }
        public long? QualityControllerId { get; set; }
        public string? Explanation { get; set; }
        public decimal? Width { get; set; }
        public decimal? Gram { get; set; }
        public decimal? ShirinkingWidth { get; set; }
        public decimal? ShirinkingLength { get; set; }
        public decimal? ShirinkingRotation { get; set; }
        public int? QualityControlTestCardId { get; set; }
        public string? Method { get; set; }
        public string? Standart { get; set; }
        public string? QualityTestExplanation { get; set; }
        public string? Required { get; set; }
        public string? Actual { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? DiscardQuantity { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpQualityControl? QualityControl { get; set; }
        public virtual ErpQualityControlTestCard? QualityControlTestCard { get; set; }
        public virtual ErpEmployee? QualityController { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
    }
}
