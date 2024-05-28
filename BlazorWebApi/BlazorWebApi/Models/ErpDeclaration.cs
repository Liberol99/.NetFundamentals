using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDeclaration
    {
        public ErpDeclaration()
        {
            ErpDeclarationApp1s = new HashSet<ErpDeclarationApp1>();
            ErpDeclarationApp2s = new HashSet<ErpDeclarationApp2>();
            ErpDeclarationApp3s = new HashSet<ErpDeclarationApp3>();
            ErpDeclarationApp4s = new HashSet<ErpDeclarationApp4>();
            ErpDeclarationApp5s = new HashSet<ErpDeclarationApp5>();
            ErpDeclarationApp6s = new HashSet<ErpDeclarationApp6>();
            ErpDeclarationApp7s = new HashSet<ErpDeclarationApp7>();
            ErpDeclarationItems = new HashSet<ErpDeclarationItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? DecType { get; set; }
        public string? DocumentNo { get; set; }
        public short? DecYear { get; set; }
        public short? DecMonth { get; set; }
        public short? DecPeriod { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? DocumentSerialNo { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpDeclarationApp1> ErpDeclarationApp1s { get; set; }
        public virtual ICollection<ErpDeclarationApp2> ErpDeclarationApp2s { get; set; }
        public virtual ICollection<ErpDeclarationApp3> ErpDeclarationApp3s { get; set; }
        public virtual ICollection<ErpDeclarationApp4> ErpDeclarationApp4s { get; set; }
        public virtual ICollection<ErpDeclarationApp5> ErpDeclarationApp5s { get; set; }
        public virtual ICollection<ErpDeclarationApp6> ErpDeclarationApp6s { get; set; }
        public virtual ICollection<ErpDeclarationApp7> ErpDeclarationApp7s { get; set; }
        public virtual ICollection<ErpDeclarationItem> ErpDeclarationItems { get; set; }
    }
}
