using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaMessageTemplate
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? TemplateCode { get; set; }
        public string? TemplateName { get; set; }
        public string? MessageText { get; set; }
        public byte? ProviderType { get; set; }
        public byte? DocumentType { get; set; }
        public string? MessageTextForDocumentType { get; set; }
        public string? Boname { get; set; }
        public short? BoreceiptType { get; set; }
        public short? BoreceiptUpType { get; set; }
        public short? BoreceiptSubType { get; set; }
        public string? BospecialCode { get; set; }
        public byte? BocontrolCode { get; set; }
        public byte? BoisApproved { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
