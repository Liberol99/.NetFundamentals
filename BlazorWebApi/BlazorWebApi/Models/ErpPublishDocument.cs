using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPublishDocument
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? DocumentType { get; set; }
        public string? DocumentCode { get; set; }
        public string? DocumentName { get; set; }
        public string? Explanation { get; set; }
        public string? GroupCode { get; set; }
        public byte[]? Content { get; set; }
        public string? ContentUrl { get; set; }
        public string? ContentFullPath { get; set; }
        public string? AccessCode { get; set; }
        public string? SpecialCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? WorkplaceIds { get; set; }
        public string? DepartmentIds { get; set; }
        public string? UserIds { get; set; }
        public string? UserGroupIds { get; set; }
        public string? CurrentAccountGroupIds { get; set; }
        public short? DocumentUpType { get; set; }
        public short? DocumentSubType { get; set; }
        public string? DocumentFileType { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
    }
}
