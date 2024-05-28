using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmLeadContact
    {
        public CrmLeadContact()
        {
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
        }

        public long RecId { get; set; }
        public long? LeadId { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Position { get; set; }
        public string? EmailAddress { get; set; }
        public short? PositionType { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? GsmNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? MariageDate { get; set; }
        public byte? Gender { get; set; }
        public string? Explanation { get; set; }
        public string? Blog { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? LinkedIn { get; set; }
        public byte? IsDefault { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? Sentez { get; set; }

        public virtual CrmLead? Lead { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
    }
}
