using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDespatchContact
    {
        public ErpDespatchContact()
        {
            ErpInventoryReceiptDespatchContacts = new HashSet<ErpInventoryReceiptDespatchContact>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? TransporterId { get; set; }
        public string? ContactCode { get; set; }
        public string? ContactName { get; set; }
        public string? ContactSurname { get; set; }
        public string? Title { get; set; }
        public string? IdNo { get; set; }
        public byte? ContactType { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? PlateNumber { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpTransporter? Transporter { get; set; }
        public virtual ICollection<ErpInventoryReceiptDespatchContact> ErpInventoryReceiptDespatchContacts { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
    }
}
