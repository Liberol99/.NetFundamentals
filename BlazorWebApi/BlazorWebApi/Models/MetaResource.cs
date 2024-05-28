using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaResource
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? UserId { get; set; }
        public int? UserRoleId { get; set; }
        public byte? ResourceType { get; set; }
        public string? ResourceName { get; set; }
        public int? ItemId { get; set; }
        public int? SubItemId { get; set; }
        public byte[]? Resource { get; set; }
        public byte[]? TempResource { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual MetaUser? UserRole { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
