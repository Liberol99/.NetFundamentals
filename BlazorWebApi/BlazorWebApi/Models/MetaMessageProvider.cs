using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaMessageProvider
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? ProviderCode { get; set; }
        public string? ProviderName { get; set; }
        public byte? ProviderType { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public string? ServerName { get; set; }
        public int? EmailPort { get; set; }
        public byte? EmailSsl { get; set; }
        public byte? EmailAuthenticateMode { get; set; }
        public string? Dealer { get; set; }
        public string? Sender { get; set; }
        public short? MaximumReceiver { get; set; }
        public short? MaximumSize { get; set; }
        public byte? InUse { get; set; }
        public byte? IsDefault { get; set; }
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
