using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaBank
    {
        public MetaBank()
        {
            ErpBanks = new HashSet<ErpBank>();
            ErpCheques = new HashSet<ErpCheque>();
            ErpEmployees = new HashSet<ErpEmployee>();
            MetaBankBranches = new HashSet<MetaBankBranch>();
            MetaCreditCards = new HashSet<MetaCreditCard>();
        }

        public int RecId { get; set; }
        public int? CountryId { get; set; }
        public string? BankCode { get; set; }
        public string? BankName { get; set; }
        public string? Swift { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCountry? Country { get; set; }
        public virtual ICollection<ErpBank> ErpBanks { get; set; }
        public virtual ICollection<ErpCheque> ErpCheques { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<MetaBankBranch> MetaBankBranches { get; set; }
        public virtual ICollection<MetaCreditCard> MetaCreditCards { get; set; }
    }
}
